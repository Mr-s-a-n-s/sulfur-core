using PerfectRandom.Sulfur.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class StashChestOnInteractEvent
    {
        public delegate bool BeforeStashInteractHandler(StashChest chest);
        public delegate void AfterStashInteractHandler(StashChest chest);

        public static event BeforeStashInteractHandler OnBeforeStashInteract;
        public static event AfterStashInteractHandler OnAfterStashInteract;

        internal static bool InvokeBeforeStashInteract(StashChest chest)
        {
            if (OnBeforeStashInteract != null)
            {
                foreach (BeforeStashInteractHandler handler in OnBeforeStashInteract.GetInvocationList())
                {
                    if(!handler.Invoke(chest))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterStashInteract(StashChest chest)
        {
            OnAfterStashInteract?.Invoke(chest);
        }

    }
}
