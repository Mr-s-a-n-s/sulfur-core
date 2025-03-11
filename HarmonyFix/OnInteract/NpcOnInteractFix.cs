using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Npc), "Interact")]
    public class NpcOnInteractFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Npc __instance)
        {
            return NpcOnInteractEvent.InvokeBeforeInteract(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(Npc __instance)
        {
            NpcOnInteractEvent.InvokeAfterInteract(__instance);
        }
    }
}
