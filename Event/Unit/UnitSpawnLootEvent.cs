using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class UnitSpawnLootEvent
    {
        public delegate bool BeforeSpawnLootHandler(Unit unit);
        public delegate void AfterSpawnLootHandler(Unit unit);

        public static event BeforeSpawnLootHandler OnBeforeSpawnLoot;
        public static event AfterSpawnLootHandler OnAfterSpawnLoot;

        internal static bool InvokeBeforeSpawnLoot(Unit unit)
        {
            if (OnBeforeSpawnLoot != null)
            {
                foreach (BeforeSpawnLootHandler handler in OnBeforeSpawnLoot.GetInvocationList())
                {
                    if (!handler.Invoke(unit))
                    {
                        return false;
                    }
                }
            }
            return true; 
        }

        internal static void InvokeAfterSpawnLoot(Unit unit)
        {
            OnAfterSpawnLoot?.Invoke(unit);
        }

    }
}
