using PerfectRandom.Sulfur.Core.UI.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SetupBagSpaceGridEvent
    {
        public delegate bool BeforeSetupBagSpaceGridHandler(InventoryUI inventoryUI);
        public delegate void AfterSetupBagSpaceGridHandler(InventoryUI inventoryUI);

        public static event BeforeSetupBagSpaceGridHandler OnBeforeSetupBagSpaceGrid;
        public static event AfterSetupBagSpaceGridHandler OnAfterSetupBagSpaceGrid;

        internal static bool InvokeBeforeSetupBagSpaceGrid(InventoryUI inventoryUI)
        {
            if (OnBeforeSetupBagSpaceGrid != null)
            {
                foreach (BeforeSetupBagSpaceGridHandler handler in OnBeforeSetupBagSpaceGrid.GetInvocationList())
                {
                    if(!handler.Invoke(inventoryUI))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSetupBagSpaceGrid(InventoryUI inventoryUI)
        {
            OnAfterSetupBagSpaceGrid?.Invoke(inventoryUI);
        }

    }
}
