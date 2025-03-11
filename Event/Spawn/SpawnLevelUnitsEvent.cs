using PerfectRandom.Sulfur.Core.LevelGeneration;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SpawnLevelUnitsEvent
    {
        public delegate bool BeforeSpawnLevelUnitsHandler(Level level, List<Room> levelRooms);
        public delegate void AfterSpawnLevelUnitsHandler(Level level, List<Room> levelRooms);

        public static event BeforeSpawnLevelUnitsHandler OnBeforeSpawnLevelUnits;
        public static event AfterSpawnLevelUnitsHandler OnAfterSpawnLevelUnits;

        internal static bool InvokeBeforeSpawnLevelUnits(Level level, List<Room> levelRooms)
        {
            if (OnBeforeSpawnLevelUnits != null)
            {
                foreach (BeforeSpawnLevelUnitsHandler handler in OnBeforeSpawnLevelUnits.GetInvocationList())
                {
                    if (!handler.Invoke(level, levelRooms))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSpawnLevelUnits(Level level, List<Room> levelRooms)
        {
            OnAfterSpawnLevelUnits?.Invoke(level, levelRooms);
        }

    }
}
