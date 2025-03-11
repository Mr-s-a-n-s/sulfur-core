using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Items;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(ItemGrid), "SetupGrid")]
    public class SetupGridFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(ItemGrid __instance, ref Vector2Int gridSize, ref Unit owner, ref GridType gridType)
        {
            return SetupGridEvent.InvokeBeforeSetupGrid(__instance, ref gridSize, ref owner, ref gridType);
        }

        [HarmonyPostfix]
        public static void Postfix(ItemGrid __instance, Vector2Int gridSize, Unit owner, GridType gridType)
        {
            SetupGridEvent.InvokeAfterSetupGrid(__instance, gridSize, owner, gridType);
        }
    }
}
