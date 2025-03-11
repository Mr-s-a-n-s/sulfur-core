using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.LevelGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using AetharNet.Mods.MODCore.Event;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(GameManager), "StartLevelRoutineGraph")]
    public class StartLevelRoutineGraphFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(WorldEnvironment chapterSO, int levelIndex, LoadingMode loadingMode, string spawnIdentifier)
        {
            return StartLevelRoutineGraphEvent.InvokeBeforeLevelLoad(chapterSO, levelIndex, loadingMode, spawnIdentifier);
        }

        [HarmonyPostfix]
        public static void Postfix(IEnumerator __result)
        {
            StartLevelRoutineGraphEvent.InvokeAfterLevelLoad(__result);
        }
    }
}
