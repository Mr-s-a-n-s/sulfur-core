using PerfectRandom.Sulfur.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class InitStationPositionUIEvent
    {
        public delegate bool BeforePositionUIHandler(ServiceStation serviceStation);
        public delegate void AfterPositionUIHandler(ServiceStation serviceStation);

        public static event BeforePositionUIHandler OnBeforePositionUI;
        public static event AfterPositionUIHandler OnAfterPositionUI;

        internal static bool InvokeBeforePositionUI(ServiceStation serviceStation)
        {
            if (OnBeforePositionUI != null)
            {
                foreach (BeforePositionUIHandler handler in OnBeforePositionUI.GetInvocationList())
                {
                    if(!handler.Invoke(serviceStation))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterPositionUI(ServiceStation serviceStation)
        {
            OnAfterPositionUI?.Invoke(serviceStation);
        }

    }
}
