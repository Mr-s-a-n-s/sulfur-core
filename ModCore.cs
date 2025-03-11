using LevelGeneration;
using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.Effects;
using PerfectRandom.Sulfur.Core.Items;
using PerfectRandom.Sulfur.Core.Stats;
using PerfectRandom.Sulfur.Core.UI;
using PerfectRandom.Sulfur.Core.UI.Inventory;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace AetharNet.Mods.MODCore
{
    public class ModCore : MonoBehaviour
    {
        public static ModCore modCore;
        [Obsolete]
        public Player player; //为旧Mod适配
        [Obsolete]
        public InventoryUI inventoryUI;
        [Obsolete]
        public UIManager UI;
        [Obsolete]
        public Dictionary<string, ItemDefinition> Allitems = new Dictionary<string, ItemDefinition>();//为旧Mod适配
        [Obsolete]
        public Dictionary<string, Texture2D> AllItemIcon = new Dictionary<string, Texture2D>();  //为旧Mod适配
        [Obsolete]
        public Dictionary<string, Sprite> AllItemSpriteIcon = new Dictionary<string, Sprite>();//为旧Mod适配
        [Obsolete]
        public GameManager GameManager;


        public void Update()
        {


            //* Main API UP
            PlayerAPI.uplayer = GameManager.Instance.GetPlayerUnit();
            PlayerAPI.player = GameManager.Instance.GetPlayerScript();
            MainAPI.UIManagers = UIManager.Instance;


            

            inventoryUI = UIManager.Instance.InventoryUI;
            UI = UIManager.Instance;
            
            if(GameManager == null)
            {
                GameManager = GameManager.Instance;
                MainAPI.GameManagers = GameManager.Instance;
            }
            if (MainAPI.levelGenerationContexts == null)
            {
                MainAPI.levelGenerationContexts = LevelGenerationContext.instance;
            }
            if(MainAPI.MapEventManagers == null)
            {
                MainAPI.MapEventManagers = EventManager.Instance;
            }
            if(MainAPI.LootManagers == null)
            {
                MainAPI.LootManagers = LootManager.Instance;
            }
            if (MainAPI.GameSetting == null)
            {
                MainAPI.GameSetting = GameManager.Instance.Settings;
            }
            if(MainAPI.PoolManagers == null)
            {
                MainAPI.PoolManagers = PoolManager.Instance;
            }
            if(PlayerAPI.uplayer != null)
            {
                if (PlayerAPI.Stats == null)
                {
                    PlayerAPI.Stats = PlayerAPI.uplayer.Stats;
                }
            }
            if(MainAPI.enemySpawnManagers == null)
            {
                MainAPI.enemySpawnManagers = EnemySpawnManager.Instance;
            }
            if(MainAPI.UnitManagers == null)
            {
                MainAPI.UnitManagers = UnitManager.Instance;
            }
            if(MainAPI.AsyncAssetLoadings == null)
            {
                MainAPI.AsyncAssetLoadings = AsyncAssetLoading.Instance;
            }
            if(MainAPI.MaterialManagers == null)
            {
                MainAPI.MaterialManagers = MaterialManager.Instance;
            }
            if(MainAPI.EffectsManagers == null)
            {
                MainAPI.EffectsManagers = EffectsManager.Instance;
            }
            if(PlayerAPI.uplayer.lastUsedWeapon != null)
            {
                PlayerAPI.lastweapon = PlayerAPI.uplayer.lastUsedWeapon;
            }
            
        }

        public void Start()
        {
            modCore = this;
            MainAPI.modCore = this;

            GameManager = GameManager.Instance;
            MainAPI.GameManagers = GameManager.Instance;

            MainAPI.AllItemIcon.Clear();
            MainAPI.Allitems.Clear();
            MainAPI.AllItemSpriteIcon.Clear();
            Allitems.Clear();
            AllItemIcon.Clear();
            AllItemSpriteIcon.Clear();

            LoadAllItems();

        }




        public void LoadAllItems()
        {
            AsyncAssetLoading.Instance.ValidateOrLoadItemDefinitionDataBlocking();
            Allitems = AsyncAssetLoading.Instance.itemDefinitions;
            MainAPI.Allitems = AsyncAssetLoading.Instance.itemDefinitions;

            LoadItemIcons();
            LoadItemSpriteIcon();
        }

        public void LoadItemIcons()
        {
            foreach (var item in Allitems)
            {
                string itemName = item.Key;
                var itemDefinition = item.Value;

                itemDefinition.artworkReference.LoadAssetAsync<Sprite>().Completed += (handle) =>
                {
                    if (handle.Status == AsyncOperationStatus.Succeeded)
                    {
                        Sprite artworkSprite = handle.Result;
                        if (artworkSprite != null)
                        {
                            //Texture2D texture = SpriteToTexture2D(artworkSprite);
                            AllItemIcon[itemName] = artworkSprite.texture;
                            MainAPI.AllItemIcon[itemName] = artworkSprite.texture;
                        }
                    }
                    else
                    {
                        Debug.LogWarning($"加载图片失败: {itemName}");
                    }
                };
            }
        }

        public void LoadItemSpriteIcon()
        {
            foreach (var item in Allitems)
            {
                string itemName = item.Key;
                var itemDefinition = item.Value;

                itemDefinition.artworkReference.LoadAssetAsync<Sprite>().Completed += (handle) =>
                {
                    if (handle.Status == AsyncOperationStatus.Succeeded)
                    {
                        Sprite artworkSprite = handle.Result;
                        if (artworkSprite != null)
                        {
                            AllItemSpriteIcon[itemName] = artworkSprite;
                            MainAPI.AllItemSpriteIcon[itemName] = artworkSprite;
                        }
                    }
                    else
                    {
                        Debug.LogWarning($"加载图片失败: {itemName}");
                    }
                };
            }
        }

        public Texture2D SpriteToTexture2D(Sprite sprite)
        {
            if (sprite.rect.width != sprite.texture.width || sprite.rect.height != sprite.texture.height)
            {
                Texture2D newTexture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
                Color[] newPixels = sprite.texture.GetPixels((int)sprite.textureRect.x, (int)sprite.textureRect.y, (int)sprite.textureRect.width, (int)sprite.textureRect.height);
                newTexture.SetPixels(newPixels);
                newTexture.Apply();
                return newTexture;
            }
            else
            {
                return sprite.texture;
            }
        }




    }
}
