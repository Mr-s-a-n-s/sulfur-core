using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace AetharNet.Mods.MODCore
{

    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class loaderfix : BaseUnityPlugin
    {
        public const string PluginGUID = "AetharNet.Mods.MODCore";
        public const string PluginAuthor = "1";
        public const string PluginName = "Mod.Core by:InitLoader";
        public const string PluginVersion = "0.3.6";

        internal new static ManualLogSource Logger;

        private void Awake()
        {
            Logger = base.Logger;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGUID);
        }
    }

}