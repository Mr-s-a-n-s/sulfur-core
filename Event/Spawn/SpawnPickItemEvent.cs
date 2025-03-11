using PerfectRandom.Sulfur.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SpawnPickItemEvent
    {
        public delegate bool BeforePickupSpawnHandler(Pickup pickup,Vector3 position, LootSpawnBehaviour behaviour);
        public delegate void AfterPickupSpawnHandler(Pickup pickup, Vector3 position, LootSpawnBehaviour behaviour);

        public static event BeforePickupSpawnHandler OnBeforePickupSpawn;
        public static event AfterPickupSpawnHandler OnAfterPickupSpawn;

        internal static bool InvokeBeforePickupSpawn(Pickup pickup,Vector3 position, LootSpawnBehaviour behaviour)
        {
            if (OnBeforePickupSpawn != null)
            {
                foreach (BeforePickupSpawnHandler handler in OnBeforePickupSpawn.GetInvocationList())
                {
                    if (!handler.Invoke(pickup,position, behaviour))
                    {
                        return false;
                    }
                }
            }
            return true; 
        }

        internal static void InvokeAfterPickupSpawn(Pickup pickup,Vector3 position, LootSpawnBehaviour behaviour)
        {
            OnAfterPickupSpawn?.Invoke(pickup,position, behaviour);
        }
    }
}
