using Cysharp.Threading.Tasks;
using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.LevelGeneration;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using AetharNet.Mods.MODCore.Event;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(EnemySpawnManager), "SpawnLevelUnits")]
    public class SpawnLevelUnitsFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Level level, List<Room> levelRooms)
        {
            return SpawnLevelUnitsEvent.InvokeBeforeSpawnLevelUnits(level, levelRooms);
        }

        [HarmonyPostfix]
        public static void Postfix(Level level, List<Room> levelRooms)
        {
            SpawnLevelUnitsEvent.InvokeAfterSpawnLevelUnits(level, levelRooms);
        }

    }
}
