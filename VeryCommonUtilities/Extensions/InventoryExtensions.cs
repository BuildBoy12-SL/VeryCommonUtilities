// -----------------------------------------------------------------------
// <copyright file="InventoryExtensions.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities.Extensions
{
    using System.Collections.Generic;
    using VeryCommonUtilities.Models;

    /// <summary>
    /// Various extensions to deal with <see cref="Inventory"/>s and <see cref="InventoryItem"/>s.
    /// </summary>
    public static class InventoryExtensions
    {
        /// <summary>
        /// Gets the first element of an <see cref="IEnumerable{T}"/> of <see cref="InventoryItem"/>s that passes the RNG check, or <see langword="default"/> if one is not selected.
        /// </summary>
        /// <param name="items">The <see cref="IEnumerable{T}"/> of <see cref="InventoryItem"/>s to chose an item from.</param>
        /// <returns>The found <see cref="InventoryItem"/> or <see langword="default"/> if one is not found.</returns>
        public static InventoryItem GetOne(this IEnumerable<InventoryItem> items)
        {
            foreach (InventoryItem item in items)
            {
                if (item.Chance > Exiled.Loader.Loader.Random.Next(100))
                    return item;
            }

            return default;
        }
    }
}