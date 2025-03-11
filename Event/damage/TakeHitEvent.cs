using System;
using PerfectRandom.Sulfur.Core.Stats;
using PerfectRandom.Sulfur.Core.Units;
using UnityEngine;


namespace AetharNet.Mods.MODCore.Event
{
    public static class TakeHitEvent
    {
        public delegate bool BeforeTakeHitHandler(Hitbox unit, ref float damage, ref DamageType damageType, ref DamageSourceData source, ref Vector3 collisionPoint);
        public delegate void AfterTakeHitHandler(Hitbox unit, float finalDamage, DamageType damageType, DamageSourceData source, Vector3 collisionPoint);

        public static event BeforeTakeHitHandler OnBeforeTakeHit;
        public static event AfterTakeHitHandler OnAfterTakeHit;
        internal static bool InvokeBeforeTakeHit(Hitbox unit, ref float damage, ref DamageType damageType, ref DamageSourceData source, ref Vector3 collisionPoint)
        {
            if (OnBeforeTakeHit != null)
            {
                foreach (BeforeTakeHitHandler handler in OnBeforeTakeHit.GetInvocationList())
                {
                    if (!handler.Invoke(unit, ref damage, ref damageType, ref source, ref collisionPoint))
                    {
                        return false; 
                    }
                }
            }
            return true;
        }


        internal static void InvokeAfterTakeHit(Hitbox unit, float finalDamage, DamageType damageType, DamageSourceData source, Vector3 collisionPoint)
        {
            OnAfterTakeHit?.Invoke(unit, finalDamage, damageType, source, collisionPoint);
        }
    }
}