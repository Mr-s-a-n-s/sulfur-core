using PerfectRandom.Sulfur.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class PickupOnInteractEvent
    {
        public delegate bool BeforeInteractHandler(Pickup unit);
        public delegate void AfterInteractHandler(Pickup unit);

        public static event BeforeInteractHandler OnBeforeInteract;
        public static event AfterInteractHandler OnAfterInteract;

        internal static bool InvokeBeforeInteract(Pickup unit)
        {
            if (OnBeforeInteract != null)
            {
                foreach (BeforeInteractHandler handler in OnBeforeInteract.GetInvocationList())
                {
                    if (!handler.Invoke(unit))
                    {
                        return false; 
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterInteract(Pickup unit)
        {
            OnAfterInteract?.Invoke(unit);
        }
    }
}
