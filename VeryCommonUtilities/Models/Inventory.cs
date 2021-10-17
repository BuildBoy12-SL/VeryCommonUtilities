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
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}