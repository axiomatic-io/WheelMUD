﻿//-----------------------------------------------------------------------------
// <copyright file="RendererDefinitions.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team.  See LICENSE.txt.  This file is 
//   subject to the Microsoft Public License.  All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace WheelMUD.Core
{
    /// <summary>
    /// Provides definitions for the set of easily-overridden view renderers.
    /// There will be a default renderer for each of these housed here in WheelMUD.Core.
    /// However, each will also have an associated export attributes for a customized renderer to claim priority over the default.
    /// </summary>
    public static class RendererDefinitions
    {
        public abstract class Inventory
        {
            public abstract string Render(Thing player);
        }

        public abstract class PerceivedRoom
        {
            public abstract string Render(Thing viewer, Thing viewedRoom);
        }

        public abstract class PerceivedThing
        {
            public abstract string Render(Thing viewer, Thing viewedThing);
        }

        public abstract class Score
        {
            public abstract string Render(Thing player);
        }

        public abstract class SplashScreen
        {
            public abstract string Render();
        }

        public abstract class Who
        {
            public abstract string Render(Thing player);
        }
    }
}