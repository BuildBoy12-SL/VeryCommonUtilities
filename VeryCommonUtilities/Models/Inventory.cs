// -----------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities.Models
{
    using System;
    using System.Collections.Generic;
    using VeryCommonUtilities.Extensions;

    /// <summary>
    /// Represents a player's inventory.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the first inventory slot.
        /// </summary>
        public List<InventoryItem> Slot1 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the second inventory slot.
        /// </summary>
        public List<InventoryItem> Slot2 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the third inventory slot.
        /// </summary>
        public List<InventoryItem> Slot3 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the fourth inventory slot.
        /// </summary>
        public List<InventoryItem> Slot4 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the fifth inventory slot.
        /// </summary>
        public List<InventoryItem> Slot5 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the sixth inventory slot.
        /// </summary>
        public List<InventoryItem> Slot6 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the seventh inventory slot.
        /// </summary>
        public List<InventoryItem> Slot7 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets or sets the list of items to be selected for insertion in the eighth inventory slot.
        /// </summary>
        public List<InventoryItem> Slot8 { get; set; } = new List<InventoryItem>();

        /// <summary>
        /// Gets the <see cref="List{T}"/> of <see cref="InventoryItem"/>s that resides at the specified index.
        /// </summary>
        /// <param name="i">The index of the inventory.</param>
        public IEnumerable<InventoryItem> this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return Slot1;
                    case 1:
                        return Slot2;
                    case 2:
                        return Slot3;
                    case 3:
                        return Slot4;
                    case 4:
                        return Slot5;
                    case 5:
                        return Slot6;
                    case 6:
                        return Slot7;
                    case 7:
                        return Slot8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i), "An inventory has eight elements.");
                }
            }
        }

        /// <summary>
        /// Generates an inventory set from the <see cref="InventoryItem"/>s.
        /// </summary>
        /// <returns>The collection of <see cref="ItemType"/>s that were selected.</returns>
        public IEnumerable<ItemType> Generate()
        {
            for (int i = 0; i < 8; i++)
            {
                InventoryItem item = this[i]?.GetOne();
                if (item == null)
                    continue;

                yield return item.ItemType;
            }
        }
    }
}