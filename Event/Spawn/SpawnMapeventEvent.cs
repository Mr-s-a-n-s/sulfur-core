using PerfectRandom.Sulfur.Core.LevelGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SpawnMapeventEvent
    {
        public delegate bool BeforeSpawnEventsHandler(List<Room> roomInstances, int eventsToSpawn, Transform root);
        public delegate void AfterSpawnEventsHandler(List<Room> roomInstances, int eventsToSpawn, Transform root);

        public static event BeforeSpawnEventsHandler OnBeforeSpawnEvents;
        public static event AfterSpawnEventsHandler OnAfterSpawnEvents;

        internal static bool InvokeBeforeSpawnEvents(List<Room> roomInstances, int eventsToSpawn, Transform root)
        {
            if (OnBeforeSpawnEvents != null)
            {
                foreach (BeforeSpawnEventsHandler handler in OnBeforeSpawnEvents.GetInvocationList())
                {
                    if (!handler.Invoke(roomInstances, eventsToSpawn, root))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSpawnEvents(List<Room> roomInstances, int eventsToSpawn, Transform root)
        {
            OnAfterSpawnEvents?.Invoke(roomInstances, eventsToSpawn, root);
        }
    }
}
