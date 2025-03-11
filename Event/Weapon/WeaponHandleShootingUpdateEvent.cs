using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class WeaponHandleShootingUpdateEvent
    {
        public delegate bool BeforeShootingUpdateHandler(Weapon weapon);
        public delegate void AfterShootingUpdateHandler(Weapon weapon);

        public static event BeforeShootingUpdateHandler OnBeforeShootingUpdate;
        public static event AfterShootingUpdateHandler OnAfterShootingUpdate;

        internal static bool InvokeBeforeShootingUpdate(Weapon weapon)
        {
            if (OnBeforeShootingUpdate != null)
            {
                foreach (BeforeShootingUpdateHandler handler in OnBeforeShootingUpdate.GetInvocationList())
                {
                    if(!handler.Invoke(weapon))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterShootingUpdate(Weapon weapon)
        {
            OnAfterShootingUpdate?.Invoke(weapon);
        }

    }
}
