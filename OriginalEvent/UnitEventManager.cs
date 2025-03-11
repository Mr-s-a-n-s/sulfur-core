using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.OriginalEvent
{
    public static class UnitEventManager
    {
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnItemPickup onItemPickupEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnAllArmorDestroyed onAllArmorDestroyedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnSpawn onSpawnEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnDeath onDeathEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnHealthChange onHealthChangeEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnDamageRecieved onDamageRecievedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnHitRecieved onHitRecievedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Units.Unit.OnMutationChange onMutationChangeEvent;

        public static event global::PerfectRandom.Sulfur.Core.Units.Npc.OnInitialAggro onNpcInitialAggr;
        public static event global::PerfectRandom.Sulfur.Core.Units.Npc.OnShootingOnTarget onNpcShootingOnTarget;

        public static event global::PerfectRandom.Sulfur.Core.UnitStatus.OnStatusActivated OnUnitStatusStatusActivatedEvent;
        public static event global::PerfectRandom.Sulfur.Core.UnitStatus.OnStatusDeactivated OnUnitStatusStatusDeactivatedEvent;

        public static event global::PerfectRandom.Sulfur.Core.Stats.EntityStats.OnWorldResourceMod OnEntityStatsWorldResourceModEvent;
    }
}
