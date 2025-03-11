using HarmonyLib;
using LevelGeneration;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.LevelGeneration;
using PerfectRandom.Sulfur.Core.UI;
using PerfectRandom.Sulfur.Core.Units;
using System.Collections.Generic;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{

    [HarmonyPatch(typeof(RegStaticUnitsAndMutateUnitsNode), "Execute")]
    public class Patch_RegStaticUnitsAndMutateUnitsNodeFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(RegStaticUnitsAndMutateUnitsNode __instance)
        {
            if(LevelGenerationAPI.SpawnEnemies_mutationChance != 0)
            {
                __instance.mutationChance = LevelGenerationAPI.SpawnEnemies_mutationChance;
            }
            
            return true;
        }
    }
}