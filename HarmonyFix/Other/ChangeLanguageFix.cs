using HarmonyLib;
using PerfectRandom.Sulfur.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    public class ChangeLanguageFix_core
    {
        [HarmonyPostfix]
        public static void HarmonyPostfix(AsyncAssetLoading __instance,float index)
        {
            PlayerSettingAlternative alternative = __instance.loadedLanguageSetting.alternatives[(int)index];
            MainAPI.localizationLanguage = alternative.localizationLanguageKey;
        }
    }
}
