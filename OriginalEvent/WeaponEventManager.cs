using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.OriginalEvent
{
    public static class WeaponEventManager
    {
        public static event global::PerfectRandom.Sulfur.Core.Weapons.Weapon.OnFire onFireEvent;
        public static event global::PerfectRandom.Sulfur.Core.Weapons.Weapon.OnWeaponHit onWeaponHitEvent;
        public static event global::PerfectRandom.Sulfur.Core.Weapons.Weapon.OnAmmoUpdate onAmmoUpdateEvent;

        public static event global::PerfectRandom.Sulfur.Core.Units.Hitbox.OnDamageReceived onHitboxDamageReceivedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Hitbox.OnHit onHitboxHitEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Hitbox.OnMeleeHit onHitboxMeleeHitEvent;

        public static event global::PerfectRandom.Sulfur.Core.Weapons.Projectile.OnHitDone onProjectileHitDoneEvent;

    }
}
