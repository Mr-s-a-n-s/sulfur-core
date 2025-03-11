using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.OriginalEvent
{
    public static class ItemEventManager
    {
        public static event global::PerfectRandom.Sulfur.Core.Items.ItemGrid.OnContentsChanged OnContentsChangedEvent;
        public static event global::PerfectRandom.Sulfur.Core.Items.ItemGrid.OnItemPickup OnItemPickupEvent;

        public static event global::PerfectRandom.Sulfur.Core.World.Pickup.OnPickup OnWorldItemPickupEvent;
    }
}
