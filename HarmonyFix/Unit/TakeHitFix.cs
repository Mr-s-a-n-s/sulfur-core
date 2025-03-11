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
    [HarmonyPatch(typeof(Hitbox), "TakeHit", new[] { typeof(float), typeof(DamageType), typeof(DamageSourceData), typeof(Vector3) })]
    public class TakeHitFix_core
    {
        private static float originalHealth;

        [HarmonyPrefix]
        public static bool TakeHit_Prefix(Hitbox __instance, ref float damage, ref DamageType damageType, ref DamageSourceData source, ref Vector3 collisionPoint)
        {
            originalHealth = __instance.GetOwner().GetCurrentHealth();
            return TakeHitEvent.InvokeBeforeTakeHit(__instance, ref damage, ref damageType, ref source, ref collisionPoint);
        }

        [HarmonyPostfix]
        public static void TakeHit_Postfix(Hitbox __instance, float damage, DamageType damageType, DamageSourceData source, Vector3 collisionPoint)
        {
            float finalDamage = originalHealth - __instance.GetOwner().GetCurrentHealth();
            TakeHitEvent.InvokeAfterTakeHit(__instance, finalDamage, damageType, source, collisionPoint);
        }

    }
}