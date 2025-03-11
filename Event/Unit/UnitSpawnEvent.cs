using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{ 
    public static class UnitSpawnEvent
    {
        public delegate bool BeforeSpawnHandler(Unit unit);
        public delegate void AfterSpawnHandler(Unit unit);

        public static event BeforeSpawnHandler OnBeforeSpawn;
        public static event AfterSpawnHandler OnAfterSpawn;

        internal static bool InvokeBeforeSpawn(Unit unit)
        {
            if (OnBeforeSpawn != null)
            {
                foreach (BeforeSpawnHandler handler in OnBeforeSpawn.GetInvocationList())
                {
                    if (!handler.Invoke(unit))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSpawn(Unit unit)
        {
            OnAfterSpawn?.Invoke(unit);
        }

    }
}
