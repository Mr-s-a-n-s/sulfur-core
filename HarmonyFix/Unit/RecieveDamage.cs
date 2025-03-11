using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Stats;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Unit), "RecieveDamage", new[] { typeof(float), typeof(DamageType), typeof(DamageSourceData), typeof(Hitbox), typeof(Vector3) })]
    public class RecieveDamageFix_core
    {
        private static float originalHealth;

        [HarmonyPrefix]
        public static bool RecieveDamage_Prefix(Unit __instance, ref float damage, ref DamageType damageType, ref DamageSourceData sourceData, ref Hitbox hitHitbox, ref Vector3 collisionPoint)
        {
            originalHealth = __instance.GetCurrentHealth();
            return DamageEvent.InvokeBeforeDamage(__instance, ref damage, ref damageType, ref sourceData, ref hitHitbox, ref collisionPoint);
        }
   
        [HarmonyPostfix]
        public static void RecieveDamage_Postfix(Unit __instance,float damage, DamageType damageType, DamageSourceData sourceData, Hitbox hitHitbox, Vector3 collisionPoint)
        {
            float finalDamage = originalHealth - __instance.GetCurrentHealth();
            DamageEvent.InvokeAfterDamage(__instance, finalDamage, damageType, sourceData, hitHitbox, collisionPoint);
        }

    }
}
