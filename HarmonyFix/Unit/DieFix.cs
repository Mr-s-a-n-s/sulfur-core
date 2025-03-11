using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AetharNet.Mods.MODCore.Event;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Unit), "Die")]
    public class DieFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Unit __instance)
        {
            return UnitDieEvent.InvokeBeforeDie(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(Unit __instance)
        {
            UnitDieEvent.InvokeAfterDie(__instance);
        }
    }

}
