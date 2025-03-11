using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.OriginalEvent
{
    public static class GameEventManager
    {
        public static event global::PerfectRandom.Sulfur.Core.GameManager.OnPlayerSpawned OnPlayerSpawnedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Effects.EffectsManager.OnFogChange OnEffectFogChangeEvent;
        public static event global::PerfectRandom.Sulfur.Core.AsyncAssetLoading.OnLanguageChange OnLanguageChangeEvent;
        public static event global::PerfectRandom.Sulfur.Core.PlayerSetting.OnValueChanged OnValueChangedEvent;
        public static event global::PerfectRandom.Sulfur.Core.SteamworksManager.OnOverlayActivated OnSteamOverlayActivatedEvent;
    }
}
