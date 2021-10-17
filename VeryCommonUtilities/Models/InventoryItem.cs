// -----------------------------------------------------------------------
// <copyright file="InventoryItem.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities.Models
{
    using UnityEngine;

    public class InventoryItem
    {
        private int chance;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItem"/> class.
        /// </summary>
        public InventoryItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItem"/> class.
        /// </summary>
        /// <param name="itemType"><inheritdoc cref="ItemType"/></param>
        /// <param name="chance"><inheritdoc cref="Chance"/></param>
        public InventoryItem(ItemType itemType, int chance)
        {
            ItemType = itemType;
            Chance = chance;
        }

        /// <summary>
        /// Gets or sets the item to use.
        /// </summary>
        public ItemType ItemType { get; set; } = ItemType.None;

        /// <summary>
        /// Gets or sets the odds that the item will be used. 0-100.
        /// </summary>
        public int Chance
        {
            get => chance;
            set => chance = Mathf.Clamp(value, 0, 100);
        }
    }
}