using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class NpcOnInteractEvent
    {
        public delegate bool BeforeInteractHandler(Npc npc);
        public delegate void AfterInteractHandler(Npc npc);

        public static event BeforeInteractHandler OnBeforeInteract;
        public static event AfterInteractHandler OnAfterInteract;

        internal static bool InvokeBeforeInteract(Npc npc)
        {
            if (OnBeforeInteract != null)
            {
                foreach (BeforeInteractHandler handler in OnBeforeInteract.GetInvocationList())
                {
                    if(!handler.Invoke(npc))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterInteract(Npc npc)
        {
            OnAfterInteract?.Invoke(npc);
        }
    }
}
