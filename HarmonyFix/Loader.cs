using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.LevelGeneration;
using PerfectRandom.Sulfur.Core.UI;
using PerfectRandom.Sulfur.Core.Units;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{

    [HarmonyPatch(typeof(GameManager), "Start")]
    public class Patch_Modcore_Restart_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(GameManager __instance)
        {
            __instance.gameObject.AddComponent<ModCore>();

        }
    }
}