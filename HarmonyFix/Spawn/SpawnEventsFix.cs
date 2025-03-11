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
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(EventManager), "SpawnEvents")]
    public class SpawnEventsFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(List<Room> roomInstances, int eventsToSpawn, Transform root)
        {
            return SpawnMapeventEvent.InvokeBeforeSpawnEvents(roomInstances, eventsToSpawn, root);
        }

        [HarmonyPostfix]
        public static void Postfix(List<Room> roomInstances, int eventsToSpawn, Transform root)
        {
            SpawnMapeventEvent.InvokeAfterSpawnEvents(roomInstances, eventsToSpawn, root);
        }
    }

}
