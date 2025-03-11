using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.Event
{
    public static class MeleeOnTriggerEnterEvent
    {
        public delegate bool BeforeMeleeHitHandler(MeleeCollider melee, Collider collider);
        public delegate void AfterMeleeHitHandler(MeleeCollider melee, Collider collider);

        public static event BeforeMeleeHitHandler OnBeforeMeleeHit;
        public static event AfterMeleeHitHandler OnAfterMeleeHit;

        internal static bool InvokeBeforeMeleeHit(MeleeCollider melee, Collider collider)
        {
            if (OnBeforeMeleeHit != null)
            {
                foreach (BeforeMeleeHitHandler handler in OnBeforeMeleeHit.GetInvocationList())
                {
                    if(!handler.Invoke(melee,collider))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterMeleeHit(MeleeCollider melee, Collider collider)
        {
            OnAfterMeleeHit?.Invoke(melee, collider);
        }

    }
}
