﻿using System;
using RimHUD.Data.Configuration;
using UnityEngine;

namespace RimHUD.Data.Integration
{
    [Attributes.IntegratedOptions]
    internal static class Mod_Bubbles
    {
        public const string Url = "https://steamcommunity.com/sharedfiles/filedetails/?id=1516158345";
        public const string Description = "Shows bubbles when characters perform a social interaction with the text that would normally only be found in the log.";
        private const string VersionExpected = "1.6";

        public static IntegratedMod Instance { get; } = new IntegratedMod("Interaction Bubbles", "Bubbles", "Bubbles.Interface.Theme", new Version(VersionExpected));

        [Attributes.Option("Options", "Activated")] public static BoolOption Activated { get; } = new BoolOption(true, Lang.Get("Integration.Bubbles.Activated"), onChange: option => Instance.SetProperty("Activated", option.Object));
        [Attributes.Option("Options", "DoNonPlayer")] public static BoolOption DoNonPlayer { get; } = new BoolOption(true, Lang.Get("Integration.Bubbles.DoNonPlayer"), onChange: option => Instance.SetProperty("DoNonPlayer", option.Object));
        [Attributes.Option("Options", "DoAnimals")] public static BoolOption DoAnimals { get; } = new BoolOption(true, Lang.Get("Integration.Bubbles.DoAnimals"), onChange: option => Instance.SetProperty("DoAnimals", option.Object));

        [Attributes.Option("Geometry", "ScaleStart")] public static RangeOption ScaleStart { get; } = new RangeOption(100, 0, 100, Lang.Get("Integration.Bubbles.ScaleStart"), value => value + "%", onChange: option => Instance.SetProperty("ScaleStart", option.Object));
        [Attributes.Option("Geometry", "MinScale")] public static RangeOption MinScale { get; } = new RangeOption(35, 10, 75, Lang.Get("Integration.Bubbles.MinScale"), value => value + "%", onChange: option => Instance.SetProperty("MinScale", option.Object));
        [Attributes.Option("Geometry", "MaxWidth")] public static RangeOption MaxWidth { get; } = new RangeOption(250, 100, 500, Lang.Get("Integration.Bubbles.MaxWidth"), onChange: option => Instance.SetProperty("MaxWidth", option.Object));
        [Attributes.Option("Geometry", "Spacing")] public static RangeOption Spacing { get; } = new RangeOption(2, 2, 12, Lang.Get("Integration.Bubbles.Spacing"), onChange: option => Instance.SetProperty("Spacing", option.Object));
        [Attributes.Option("Geometry", "StartOffset")] public static RangeOption StartOffset { get; } = new RangeOption(15, 0, 250, Lang.Get("Integration.Bubbles.StartOffset"), onChange: option => Instance.SetProperty("StartOffset", option.Object));
        [Attributes.Option("Geometry", "OffsetDirection")] public static RangeOption OffsetDirection { get; } = new RangeOption(0, 0, 3, Lang.Get("Integration.Bubbles.OffsetDirection"), value => Lang.GetIndexed("Integration.Bubbles.OffsetDirections", value), onChange: option => Instance.SetProperty("OffsetDirection", option.Object));

        [Attributes.Option("Appearance", "StartOpacity")] public static RangeOption StartOpacity { get; } = new RangeOption(90, 30, 100, Lang.Get("Integration.Bubbles.StartOpacity"), value => value + "%", onChange: option => Instance.SetProperty("StartOpacity", option.Object));
        [Attributes.Option("Appearance", "MouseOverOpacity")] public static RangeOption MouseOverOpacity { get; } = new RangeOption(20, 5, 100, Lang.Get("Integration.Bubbles.MouseOverOpacity"), value => value + "%", onChange: option => Instance.SetProperty("MouseOverOpacity", option.Object));
        [Attributes.Option("Appearance", "MinTime")] public static RangeOption MinTime { get; } = new RangeOption(0, 1, 2000, Lang.Get("Integration.Bubbles.MinTime"), onChange: option => Instance.SetProperty("MinTime", option.Object));
        [Attributes.Option("Appearance", "FadeStart")] public static RangeOption FadeStart { get; } = new RangeOption(500, 1, 2000, Lang.Get("Integration.Bubbles.FadeStart"), onChange: option => Instance.SetProperty("FadeStart", option.Object));
        [Attributes.Option("Appearance", "FadeLength")] public static RangeOption FadeLength { get; } = new RangeOption(250, 1, 2000, Lang.Get("Integration.Bubbles.FadeLength"), onChange: option => Instance.SetProperty("FadeLength", option.Object));
        [Attributes.Option("Appearance", "MaxPerPawn")] public static RangeOption MaxPerPawn { get; } = new RangeOption(3, 1, 10, Lang.Get("Integration.Bubbles.MaxPerPawn"), onChange: option => Instance.SetProperty("MaxPerPawn", option.Object));

        [Attributes.Option("Text", "FontSize")] public static RangeOption FontSize { get; } = new RangeOption(12, 9, 30, Lang.Get("Integration.Bubbles.FontSize"), onChange: option => Instance.SetProperty("FontSize", option.Object));
        [Attributes.Option("Text", "PaddingX")] public static RangeOption PaddingX { get; } = new RangeOption(4, 1, 20, Lang.Get("Integration.Bubbles.PaddingX"), onChange: option => Instance.SetProperty("PaddingX", option.Object));
        [Attributes.Option("Text", "PaddingY")] public static RangeOption PaddingY { get; } = new RangeOption(2, 1, 20, Lang.Get("Integration.Bubbles.PaddingY"), onChange: option => Instance.SetProperty("PaddingY", option.Object));

        [Attributes.Option("Color", "ForeColor")] public static ColorOption ForeColor { get; } = new ColorOption(Color.black, Lang.Get("Integration.Bubbles.ForeColor"), onChange: option => Instance.SetProperty("ForeColor", option.Object));
        [Attributes.Option("Color", "BackColor")] public static ColorOption BackColor { get; } = new ColorOption(Color.white, Lang.Get("Integration.Bubbles.BackColor"), onChange: option => Instance.SetProperty("BackColor", option.Object));
        [Attributes.Option("Color", "SelectedForeColor")] public static ColorOption SelectedForeColor { get; } = new ColorOption(Color.black, Lang.Get("Integration.Bubbles.SelectedForeColor"), onChange: option => Instance.SetProperty("SelectedForeColor", option.Object));
        [Attributes.Option("Color", "SelectedBackColor")] public static ColorOption SelectedBackColor { get; } = new ColorOption(new Color(1f, 1f, 0.75f), Lang.Get("Integration.Bubbles.SelectedBackColor"), onChange: option => Instance.SetProperty("SelectedBackColor", option.Object));
    }
}
