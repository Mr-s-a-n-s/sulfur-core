using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class UnitDieEvent
    {
        public delegate bool BeforeDieHandler(Unit unit);
        public delegate void AfterDieHandler(Unit unit);

        public static event BeforeDieHandler OnBeforeDie;
        public static event AfterDieHandler OnAfterDie;

        internal static bool InvokeBeforeDie(Unit unit)
        {
            if (OnBeforeDie != null)
            {
                foreach (BeforeDieHandler handler in OnBeforeDie.GetInvocationList())
                {
                    if (!handler.Invoke(unit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        internal static void InvokeAfterDie(Unit unit)
        {
            OnAfterDie?.Invoke(unit);
        }
    }
}
