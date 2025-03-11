using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.OriginalEvent
{
    public static class LevelEventManager
    {
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnLevelGenerationFail OnLevelGenerationFailEvent;
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnLevelReady OnLevelReadyEvent;
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnProgress OnProgressEvent;
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnRoomRegistered OnRoomRegisteredEvent;
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnRoomUnregistered OnRoomUnregisteredEvent;
        public static event global::PerfectRandom.Sulfur.Core.LevelGeneration.LevelGenerator.OnSolidify OnSolidifyEvent;

        public static event global::PerfectRandom.Sulfur.Core.Items.LootManager.OnLootTableRoll OnLootTableRollEvent;
    }
}
