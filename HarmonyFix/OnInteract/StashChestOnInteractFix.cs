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
    [HarmonyPatch(typeof(StashChest), "OnInteract")]
    public class StashChestOnInteractFix
    {
        [HarmonyPrefix]
        public static bool Prefix(StashChest __instance)
        {
            return StashChestOnInteractEvent.InvokeBeforeStashInteract(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(StashChest __instance)
        {
            StashChestOnInteractEvent.InvokeAfterStashInteract(__instance);
        }
    }
}
