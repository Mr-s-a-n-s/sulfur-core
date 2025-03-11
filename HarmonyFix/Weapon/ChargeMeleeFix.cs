using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Weapon), "ChargeMelee")]
    public class ChargeMeleeFix
    {
        [HarmonyPrefix]
        public static bool Prefix(Weapon __instance, ref bool state)
        {
            return MeleeChargeMeleeEvent.InvokeBeforeChargeMelee(__instance, ref state);
        }

        [HarmonyPostfix]
        public static void Postfix(Weapon __instance, bool state)
        {
            MeleeChargeMeleeEvent.InvokeAfterChargeMelee(__instance, state);
        }
    }
}
