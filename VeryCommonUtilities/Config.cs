// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using VeryCommonUtilities.Models;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the broadcast to display to a player when they join.
        /// </summary>
        public Broadcast JoinBroadcast { get; set; } = new Broadcast("Welcome to the Bone Zone", 8);

        /// <summary>
        /// Gets or sets a collection of all health values.
        /// </summary>
        public Dictionary<RoleType, int> StartingHealth { get; set; } = new Dictionary<RoleType, int>
        {
            [RoleType.Scp173] = 3000,
            [RoleType.Scp93953] = 1500,
            [RoleType.Scp93989] = 1500,
        };

        /// <summary>
        /// Gets or sets a collection of all modified inventories.
        /// </summary>
        public Dictionary<RoleType, Inventory> Inventories { get; set; } = new Dictionary<RoleType, Inventory>
        {
            [RoleType.ClassD] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Coin, 100),
                },
            },
            [RoleType.Scientist] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardScientist, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.SCP500, 10),
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Coin, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Flashlight, 25),
                    new InventoryItem(ItemType.Radio, 50),
                },
            },
            [RoleType.FacilityGuard] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardNTFOfficer, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunCrossvec, 75),
                    new InventoryItem(ItemType.GunFSP9, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Adrenaline, 80),
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Radio, 100),
                },
                Slot5 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 75),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorLight, 100),
                },
            },
            [RoleType.NtfPrivate] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardNTFLieutenant, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunCrossvec, 90),
                    new InventoryItem(ItemType.GunFSP9, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 50),
                },
                Slot7 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Radio, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorLight, 10),
                    new InventoryItem(ItemType.ArmorCombat, 100),
                },
            },
            [RoleType.NtfSergeant] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardNTFCommander, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunCrossvec, 25),
                    new InventoryItem(ItemType.GunE11SR, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.SCP500, 10),
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 100),
                },
                Slot7 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Radio, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorHeavy, 10),
                    new InventoryItem(ItemType.ArmorCombat, 100),
                },
            },
            [RoleType.NtfSpecialist] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardNTFCommander, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunCrossvec, 25),
                    new InventoryItem(ItemType.GunE11SR, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.SCP500, 60),
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 100),
                },
                Slot7 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Radio, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorHeavy, 10),
                    new InventoryItem(ItemType.ArmorCombat, 100),
                },
            },
            [RoleType.NtfCaptain] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardO5, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunCrossvec, 5),
                    new InventoryItem(ItemType.GunE11SR, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.SCP500, 40),
                    new InventoryItem(ItemType.Medkit, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 100),
                },
                Slot7 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Radio, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorCombat, 20),
                    new InventoryItem(ItemType.ArmorHeavy, 100),
                },
            },
            [RoleType.ChaosRifleman] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardChaosInsurgency, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunAK, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Medkit, 50),
                    new InventoryItem(ItemType.Adrenaline, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 50),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorCombat, 80),
                    new InventoryItem(ItemType.ArmorLight, 100),
                },
            },
            [RoleType.ChaosMarauder] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardChaosInsurgency, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunRevolver, 50),
                    new InventoryItem(ItemType.GunCOM18, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunShotgun, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Medkit, 50),
                    new InventoryItem(ItemType.Adrenaline, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorCombat, 80),
                    new InventoryItem(ItemType.ArmorHeavy, 100),
                },
            },
            [RoleType.ChaosRepressor] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardChaosInsurgency, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunLogicer, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Medkit, 50),
                    new InventoryItem(ItemType.Adrenaline, 100),
                },
                Slot4 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GrenadeFlash, 50),
                    new InventoryItem(ItemType.GrenadeHE, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorCombat, 60),
                    new InventoryItem(ItemType.ArmorHeavy, 100),
                },
            },
            [RoleType.ChaosConscript] = new Inventory
            {
                Slot1 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.KeycardChaosInsurgency, 100),
                },
                Slot2 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.GunAK, 100),
                },
                Slot3 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.Medkit, 50),
                    new InventoryItem(ItemType.Adrenaline, 100),
                },
                Slot8 = new List<InventoryItem>
                {
                    new InventoryItem(ItemType.ArmorCombat, 100),
                },
            },
        };
    }
}