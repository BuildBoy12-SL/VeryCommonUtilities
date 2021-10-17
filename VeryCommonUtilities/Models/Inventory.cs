// -----------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities.Models
{
    using System.Collections.Generic;
    using VeryCommonUtilities.Extensions;

    public class Inventory
    {
        public List<InventoryItem> Slot1 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot2 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot3 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot4 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot5 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot6 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot7 { get; set; } = new List<InventoryItem>();

        public List<InventoryItem> Slot8 { get; set; } = new List<InventoryItem>();

        public List<ItemType> Generate()
        {
            return new List<ItemType>
            {
                Slot1.GetOne().ItemType,
                Slot2.GetOne().ItemType,
                Slot3.GetOne().ItemType,
                Slot4.GetOne().ItemType,
                Slot5.GetOne().ItemType,
                Slot6.GetOne().ItemType,
                Slot7.GetOne().ItemType,
                Slot8.GetOne().ItemType,
            };
        }
    }
}