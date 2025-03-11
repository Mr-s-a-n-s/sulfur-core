using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.UI.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(InventoryUI), "SetupBagSpaceGrid")]
    public class inventoryUIFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(InventoryUI __instance)
        {
            return SetupBagSpaceGridEvent.InvokeBeforeSetupBagSpaceGrid(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(InventoryUI __instance)
        {
            SetupBagSpaceGridEvent.InvokeAfterSetupBagSpaceGrid(__instance);
        }
    }
}
