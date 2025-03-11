using PerfectRandom.Sulfur.Core.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class DoJumpEvent
    {
        public delegate bool BeforeJumpHandler(ExtendedAdvancedWalkerController controller);
        public delegate void AfterJumpHandler(ExtendedAdvancedWalkerController controller);

        public static event BeforeJumpHandler OnBeforeJump;
        public static event AfterJumpHandler OnAfterJump;

        internal static bool InvokeBeforeJump(ExtendedAdvancedWalkerController controller)
        {
            if (OnBeforeJump != null)
            {
                foreach (BeforeJumpHandler handler in OnBeforeJump.GetInvocationList())
                {
                    if(!handler.Invoke(controller))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterJump(ExtendedAdvancedWalkerController controller)
        {
            OnAfterJump?.Invoke(controller);
        }

    }
}
