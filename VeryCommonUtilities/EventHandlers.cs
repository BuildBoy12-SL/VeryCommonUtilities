// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using VeryCommonUtilities.Models;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the <see cref="Plugin"/> class.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnChangingRole(ChangingRoleEventArgs)"/>
        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (!plugin.Config.Inventories.TryGetValue(ev.NewRole, out Inventory inventory) || inventory is null)
                return;

            ev.Items.Clear();
            ev.Items.AddRange(inventory.Generate());
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnVerified(VerifiedEventArgs)"/>
        public void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(plugin.Config.JoinBroadcast);
        }

        /// <inheritdoc cref="PlayerMovementSync.OnPlayerSpawned"/>
        public void OnPlayerSpawned(ReferenceHub referenceHub)
        {
            Player player = Player.Get(referenceHub);
            if (plugin.Config.StartingHealth.TryGetValue(player.Role.Type, out int health))
                player.Health = player.MaxHealth = health;
        }
    }
}