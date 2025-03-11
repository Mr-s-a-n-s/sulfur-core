using LevelGeneration;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.Effects;
using PerfectRandom.Sulfur.Core.Items;
using PerfectRandom.Sulfur.Core.UI;
using PerfectRandom.Sulfur.Core.UI.Inventory;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore
{
    public static class MainAPI
    {
        public static ModCore modCore;

        public static UIManager UIManagers;

        public static GameManager GameManagers;

        public static Dictionary<string, ItemDefinition> Allitems = new Dictionary<string, ItemDefinition>();

        public static Dictionary<string, Texture2D> AllItemIcon = new Dictionary<string, Texture2D>();  

        public static Dictionary<string, Sprite> AllItemSpriteIcon = new Dictionary<string, Sprite>();

        public static string localizationLanguage;

        public static LevelGenerationContext levelGenerationContexts;

        public static EventManager MapEventManagers;

        public static LootManager LootManagers;

        public static GameSettings GameSetting;

        public static EnemySpawnManager enemySpawnManagers;

        public static UnitManager UnitManagers;

        public static AsyncAssetLoading AsyncAssetLoadings;

        public static MaterialManager MaterialManagers;

        public static PoolManager PoolManagers;

        public static EffectsManager EffectsManagers;

    }
}
