using Cysharp.Threading.Tasks;
using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AetharNet.Mods.MODCore.Event;
using LevelGeneration;
using System.Collections;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(SpawnPlayerNode), "Execute")]
    public class SpawnPlayerNodeFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            return SpawnPlayerEvent.InvokeBeforeSpawnPlayer();
        }

        [HarmonyPostfix]
        public static void Postfix(IEnumerator __result)
        {
            __result.MoveNext();

            SpawnPlayerEvent.InvokeAfterSpawnPlayer();
        }
    }
}
