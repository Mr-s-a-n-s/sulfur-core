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
    [HarmonyPatch(typeof(Unit), "Spawn")]
    public class UnitSpawnFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Unit __instance)
        {
            return UnitSpawnEvent.InvokeBeforeSpawn(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(Unit __instance)
        {
            UnitSpawnEvent.InvokeAfterSpawn(__instance);
        }
    }
}
