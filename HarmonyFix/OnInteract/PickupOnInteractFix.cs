using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Pickup), "OnInteract")]
    public class PickupOnInteractFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Pickup __instance)
        {
            return PickupOnInteractEvent.InvokeBeforeInteract(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(Pickup __instance)
        {
            PickupOnInteractEvent.InvokeAfterInteract(__instance);
        }
    }
}
