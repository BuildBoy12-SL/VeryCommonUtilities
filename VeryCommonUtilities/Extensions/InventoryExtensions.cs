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

    public static class InventoryExtensions
    {
        public static InventoryItem GetOne(this IEnumerable<InventoryItem> items)
        {
            foreach (var item in items)
            {
                if (item.Chance > Exiled.Loader.Loader.Random.Next(100))
                    return item;
            }

            return default;
        }
    }
}