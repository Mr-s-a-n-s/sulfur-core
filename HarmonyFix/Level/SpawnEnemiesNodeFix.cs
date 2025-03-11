using HarmonyLib;
using LevelGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(SpawnEnemiesNode), "Execute")]
    public class SpawnEnemiesNodeFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(SpawnEnemiesNode __instance)
        {
            if (LevelGenerationAPI.SpawnEnemies_packDensity != 0)
            {
                __instance.packDensity = LevelGenerationAPI.SpawnEnemies_packDensity;
            }
            if(LevelGenerationAPI.SpawnEnemies_powerscore != 0)
            {
                __instance.powerscore = LevelGenerationAPI.SpawnEnemies_powerscore;
            }
            if(LevelGenerationAPI.SpawnEnemies_civilianSpawnChance != 0)
            {
                __instance.civilianSpawnChance = LevelGenerationAPI.SpawnEnemies_civilianSpawnChance;
            }
            //__instance.spawnPointsToRemoveFromStart = LevelGenerationAPI.spawnPointsToRemoveFromStart; //在往期的版本中大概是0.9.12以前的参数

            return true;
        }
    }
}
