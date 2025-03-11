using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class WeaponReloadEvent
    {
        public delegate bool BeforeReloadHandler(Weapon weapon);
        public delegate void AfterReloadHandler(Weapon weapon);

        public static event BeforeReloadHandler OnBeforeReload;
        public static event AfterReloadHandler OnAfterReload;

        internal static bool InvokeBeforeReload(Weapon weapon)
        {
            if (OnBeforeReload != null)
            {
                foreach (BeforeReloadHandler handler in OnBeforeReload.GetInvocationList())
                {
                    if (!handler.Invoke(weapon))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterReload(Weapon weapon)
        {
            OnAfterReload?.Invoke(weapon);
        }

    }
}
