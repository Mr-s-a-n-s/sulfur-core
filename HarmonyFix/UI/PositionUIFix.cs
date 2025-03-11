using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(ServiceStation), "PositionUI")]
    public class PositionUIFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(ServiceStation __instance)
        {
            return InitStationPositionUIEvent.InvokeBeforePositionUI(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(ServiceStation __instance)
        {
            InitStationPositionUIEvent.InvokeAfterPositionUI(__instance);
        }
    }
}
