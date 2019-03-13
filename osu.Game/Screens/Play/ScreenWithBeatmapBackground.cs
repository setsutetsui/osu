﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Screens;
using osu.Game.Configuration;
using osu.Game.Screens.Backgrounds;
using osuTK;

namespace osu.Game.Screens.Play
{
    public abstract class ScreenWithBeatmapBackground : OsuScreen
    {
        protected override BackgroundScreen CreateBackground() => new BackgroundScreenBeatmap(Beatmap.Value);

        protected new BackgroundScreenBeatmap Background => (BackgroundScreenBeatmap)base.Background;

        protected Bindable<bool> ShowStoryboard;

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            ShowStoryboard = config.GetBindable<bool>(OsuSetting.ShowStoryboard);
        }
    }
}
