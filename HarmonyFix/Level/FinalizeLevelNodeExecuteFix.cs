using HarmonyLib;
using LevelGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    public class FinalizeLevelNodeExecuteFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(FinalizeLevelNode __instance)
        {
            if(LevelGenerationAPI.hiddenChestCount != 0)
            {
                __instance.hiddenChestCount = LevelGenerationAPI.hiddenChestCount;
            }
            return true;
        }
    }
}
