using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class WeaponAddExperienceEvent
    {
        public delegate bool BeforeAddExperienceHandler(Weapon weapon, ref int experience);
        public delegate void AfterAddExperienceHandler(Weapon weapon, int experience);

        public static event BeforeAddExperienceHandler OnBeforeAddExperience;
        public static event AfterAddExperienceHandler OnAfterAddExperience;

        internal static bool InvokeBeforeAddExperience(Weapon weapon, ref int experience)
        {
            if (OnBeforeAddExperience != null)
            {
                foreach (BeforeAddExperienceHandler handler in OnBeforeAddExperience.GetInvocationList())
                {
                    if(!handler.Invoke(weapon,ref experience))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterAddExperience(Weapon weapon, int experience)
        {
            OnAfterAddExperience?.Invoke(weapon, experience);
        }

    }
}
