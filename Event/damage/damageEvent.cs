using System;
using PerfectRandom.Sulfur.Core.Stats;
using PerfectRandom.Sulfur.Core.Units;
using UnityEngine;

namespace AetharNet.Mods.MODCore.Event
{
    public static class DamageEvent
    {
        public delegate bool BeforeDamageHandler(Unit unit, ref float damage, ref DamageType damageType, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 collisionPoint);
        public delegate void AfterDamageHandler(Unit unit, float finaldamage, DamageType damageType, DamageSourceData source, Hitbox hitbox, Vector3 collisionPoint);

        public static event BeforeDamageHandler OnBeforeDamage;
        public static event AfterDamageHandler OnAfterDamage;

        internal static bool InvokeBeforeDamage(Unit unit, ref float damage, ref DamageType damageType, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 collisionPoint)
        {
            if (OnBeforeDamage != null)
            {
                foreach (BeforeDamageHandler handler in OnBeforeDamage.GetInvocationList())
                {
                    if (!handler.Invoke(unit, ref damage, ref damageType, ref source, ref hitbox, ref collisionPoint))
                    {
                        return false; 
                    }
                }
            }
            
            return true;
        }

        internal static void InvokeAfterDamage(Unit unit, float damage, DamageType damageType, DamageSourceData source, Hitbox hitbox, Vector3 collisionPoint)
        {
            OnAfterDamage?.Invoke(unit, damage, damageType, source, hitbox, collisionPoint);
        }


    }
}
