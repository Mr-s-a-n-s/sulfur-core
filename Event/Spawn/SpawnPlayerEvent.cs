using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SpawnPlayerEvent
    {
        public delegate bool BeforeSpawnPlayerHandler();
        public delegate void AfterSpawnPlayerHandler();

        public static event BeforeSpawnPlayerHandler OnBeforeSpawnPlayer;
        public static event AfterSpawnPlayerHandler OnAfterSpawnPlayer;
        internal static bool InvokeBeforeSpawnPlayer()
        {
            if (OnBeforeSpawnPlayer != null)
            {
                foreach (BeforeSpawnPlayerHandler handler in OnBeforeSpawnPlayer.GetInvocationList())
                {
                    if (!handler.Invoke())
                    {
                        return false; 
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSpawnPlayer()
        {
            OnAfterSpawnPlayer?.Invoke();
        }

    }
}
