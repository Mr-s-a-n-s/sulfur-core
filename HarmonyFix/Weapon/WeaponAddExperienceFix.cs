using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(Weapon), "AddExperience")]
    public class WeaponAddExperienceFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Weapon __instance, ref int experienceIncrease)
        {
            return WeaponAddExperienceEvent.InvokeBeforeAddExperience(__instance, ref experienceIncrease);
        }

        [HarmonyPostfix]
        public static void Postfix(Weapon __instance, int experienceIncrease)
        {
            WeaponAddExperienceEvent.InvokeAfterAddExperience(__instance, experienceIncrease);
        }
    }
}
