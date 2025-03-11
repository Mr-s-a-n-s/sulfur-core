using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(ExtendedAdvancedWalkerController), "DoJump")]
    public class DoJumpFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(ExtendedAdvancedWalkerController __instance)
        {
            return DoJumpEvent.InvokeBeforeJump(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(ExtendedAdvancedWalkerController __instance)
        {
            DoJumpEvent.InvokeAfterJump(__instance);
        }
    }
}
