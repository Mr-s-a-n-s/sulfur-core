using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class MeleeChargeMeleeEvent
    {
        public delegate bool BeforeChargeMeleeHandler(Weapon weapon, ref bool state);
        public delegate void AfterChargeMeleeHandler(Weapon weapon, bool state);

        public static event BeforeChargeMeleeHandler OnBeforeChargeMelee;
        public static event AfterChargeMeleeHandler OnAfterChargeMelee;

        internal static bool InvokeBeforeChargeMelee(Weapon weapon, ref bool state)
        {
            if (OnBeforeChargeMelee != null)
            {
                foreach (BeforeChargeMeleeHandler handler in OnBeforeChargeMelee.GetInvocationList())
                {
                    if(!handler.Invoke(weapon,ref state))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterChargeMelee(Weapon weapon, bool state)
        {
            OnAfterChargeMelee?.Invoke(weapon, state);
        }

    }
}
