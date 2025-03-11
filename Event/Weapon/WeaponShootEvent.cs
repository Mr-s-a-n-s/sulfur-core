using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class WeaponShootEvent
    {
        public delegate bool BeforeShootHandler(Weapon weapon);
        public delegate void AfterShootHandler(Weapon weapon);

        public static event BeforeShootHandler OnBeforeShoot;
        public static event AfterShootHandler OnAfterShoot;

        internal static bool InvokeBeforeShoot(Weapon weapon)
        {
            if (OnBeforeShoot != null)
            {
                foreach (BeforeShootHandler handler in OnBeforeShoot.GetInvocationList())
                {
                    if(!handler.Invoke(weapon))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterShoot(Weapon weapon)
        {
            OnAfterShoot?.Invoke(weapon);
        }

    }
}
