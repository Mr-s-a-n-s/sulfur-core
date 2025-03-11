using HarmonyLib;
using PerfectRandom.Sulfur.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AetharNet.Mods.MODCore.Event;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Pickup), "Spawn")]
    public class PickupSpawnFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Pickup __instance, Vector3 position, LootSpawnBehaviour behaviour)
        {
            return SpawnPickItemEvent.InvokeBeforePickupSpawn(__instance,position, behaviour);
        }

        [HarmonyPostfix]
        public static void Postfix(Pickup __instance,Vector3 position, LootSpawnBehaviour behaviour)
        {
            SpawnPickItemEvent.InvokeAfterPickupSpawn(__instance,position, behaviour);
        }
    }
}
