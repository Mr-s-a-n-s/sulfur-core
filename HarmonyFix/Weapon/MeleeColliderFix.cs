using AetharNet.Mods.MODCore.Event;
using HarmonyLib;
using PerfectRandom.Sulfur.Core.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.HarmonyFix
{
    [HarmonyPatch(typeof(MeleeCollider), "OnTriggerEnter")]
    public class MeleeColliderFix_core
    {
        [HarmonyPrefix]
        public static bool Prefix(MeleeCollider __instance, Collider collider)
        {
            return MeleeOnTriggerEnterEvent.InvokeBeforeMeleeHit(__instance, collider);
        }

        [HarmonyPostfix]
        public static void Postfix(MeleeCollider __instance, Collider collider)
        {
            MeleeOnTriggerEnterEvent.InvokeAfterMeleeHit(__instance, collider);
        }
    }
}
