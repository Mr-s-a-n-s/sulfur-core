using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    public class LoadPlayerSettingsFix_core
    {
        [HarmonyPostfix]
        public static void HarmonyPostfix(AsyncAssetLoading __instance)
        {
            PlayerSettingAlternative alternative = __instance.loadedLanguageSetting.alternatives[__instance.startupLanguage];
            MainAPI.localizationLanguage = alternative.localizationLanguageKey;
        }
    }

}
