﻿// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace VeryCommonUtilities
{
    using System;
    using Exiled.API.Features;
    using Scp914Handlers = Exiled.Events.Handlers.Scp914;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc />
        public override string Author => "Build";

        /// <inheritdoc />
        public override string Name => "VeryCommonUtilities";

        /// <inheritdoc />
        public override string Prefix => "VeryCommonUtilities";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Player.ChangingRole += eventHandlers.OnChangingRole;
            Exiled.Events.Handlers.Player.Verified += eventHandlers.OnVerified;
            PlayerMovementSync.OnPlayerSpawned += eventHandlers.OnPlayerSpawned;
            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= eventHandlers.OnChangingRole;
            Exiled.Events.Handlers.Player.Verified -= eventHandlers.OnVerified;
            PlayerMovementSync.OnPlayerSpawned -= eventHandlers.OnPlayerSpawned;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}