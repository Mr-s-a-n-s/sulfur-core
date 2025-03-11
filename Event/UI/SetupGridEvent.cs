using PerfectRandom.Sulfur.Core.Items;
using PerfectRandom.Sulfur.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AetharNet.Mods.MODCore.Event
{
    public static class SetupGridEvent
    {
        public delegate bool BeforeSetupGridHandler(ItemGrid itemGrid, ref Vector2Int gridSize, ref Unit owner, ref GridType gridType);
        public delegate void AfterSetupGridHandler(ItemGrid itemGrid, Vector2Int gridSize, Unit owner, GridType gridType);

        public static event BeforeSetupGridHandler OnBeforeSetupGrid;
        public static event AfterSetupGridHandler OnAfterSetupGrid;

        internal static bool InvokeBeforeSetupGrid(ItemGrid itemGrid, ref Vector2Int gridSize, ref Unit owner, ref GridType gridType)
        {
            if (OnBeforeSetupGrid != null)
            {
                foreach (BeforeSetupGridHandler handler in OnBeforeSetupGrid.GetInvocationList())
                {           
                    if(!handler.Invoke(itemGrid,ref gridSize,ref owner,ref gridType))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterSetupGrid(ItemGrid itemGrid, Vector2Int gridSize, Unit owner, GridType gridType)
        {
            OnAfterSetupGrid?.Invoke(itemGrid, gridSize, owner, gridType);
        }

    }
}
