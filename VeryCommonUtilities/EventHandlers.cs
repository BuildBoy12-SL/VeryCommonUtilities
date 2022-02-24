// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using Exiled.Events.EventArgs;
    using MEC;
    using VeryCommonUtilities.Extensions;
    using VeryCommonUtilities.Models;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly Dictionary<Player, CoroutineHandle> healthCoroutines = new Dictionary<Player, CoroutineHandle>();
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the <see cref="Plugin"/> class.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnChangingRole(ChangingRoleEventArgs)"/>
        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (plugin.Config.Inventories.TryGetValue(ev.NewRole, out Inventory inventory))
            {
                ev.Items.Clear();
                ev.Items.AddRange(Generate(inventory));
            }

            Timing.RunCoroutine(VerifyWeaponAmmo(ev));
            if (healthCoroutines.TryGetValue(ev.Player, out CoroutineHandle handle) && handle.IsRunning)
            {
                Timing.KillCoroutines(handle);
                healthCoroutines.Remove(ev.Player);
            }

            if (plugin.Config.StartingHealth.TryGetValue(ev.NewRole, out int health))
            {
                healthCoroutines[ev.Player] = Timing.RunCoroutine(HealthCoroutine(ev.Player, health, ev.NewRole), Segment.FixedUpdate);
            }
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnVerified(VerifiedEventArgs)"/>
        public void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player?.Broadcast(plugin.Config.JoinBroadcast);
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnWaitingForPlayers"/>
        public void OnWaitingForPlayers()
        {
            foreach (var coroutineHandle in healthCoroutines.Values)
                Timing.KillCoroutines(coroutineHandle);

            healthCoroutines.Clear();
        }

        private IEnumerator<float> VerifyWeaponAmmo(ChangingRoleEventArgs ev)
        {
            yield return Timing.WaitUntilTrue(() => ev.Player.Role == ev.NewRole);
            foreach (Item item in ev.Player.Items)
            {
                if (item is Firearm firearm)
                    firearm.Ammo = firearm.MaxAmmo;
            }
        }

        private IEnumerable<ItemType> Generate(Inventory inventory)
        {
            for (int i = 0; i < 8; i++)
            {
                IEnumerable<InventoryItem> slot = inventory[i];
                if (slot == null)
                    continue;

                yield return slot.GetOne().ItemType;
            }
        }

        private IEnumerator<float> HealthCoroutine(Player player, int health, RoleType targetRole)
        {
            yield return Timing.WaitForSeconds(1f);
            if (player == null || player.SessionVariables.ContainsKey("IsScp035") || player.SessionVariables.ContainsKey("IsNPC"))
                yield break;

            if (Round.ElapsedTime.TotalSeconds < 10)
                yield return Timing.WaitForSeconds(10f - (float)Round.ElapsedTime.TotalSeconds);

            if (targetRole == player.Role)
                player.Health = player.MaxHealth = health;

            healthCoroutines.Remove(player);
        }
    }
}