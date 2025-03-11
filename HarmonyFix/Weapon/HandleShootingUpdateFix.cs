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
    [HarmonyPatch(typeof(Weapon), "HandleShootingUpdate")]
    public class HandleShootingUpdateFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(Weapon __instance)
        {
            return WeaponHandleShootingUpdateEvent.InvokeBeforeShootingUpdate(__instance);
        }

        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            WeaponHandleShootingUpdateEvent.InvokeAfterShootingUpdate(__instance);
        }
    }
}
