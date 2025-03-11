using HarmonyLib;
using LevelGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(SpawnEventsNode), "Execute")]
    public class SpawnEventsNodeExecuteFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(SpawnEventsNode __instance)
        { 
            if (LevelGenerationAPI.maxMapEvents != 0)
            {
                __instance.maxEvents = LevelGenerationAPI.maxMapEvents;
            }
            return true;
        }

    }
}
