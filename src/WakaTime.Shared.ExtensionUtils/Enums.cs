﻿using System.ComponentModel;
// ReSharper disable UnusedMember.Global

namespace WakaTime.Shared.ExtensionUtils
{
    public enum HeartbeatCategory
    {
        [Description("coding")]
        Coding,
        [Description("building")]
        Building,
        [Description("indexing")]
        Indexing,
        [Description("debugging")]
        Debugging,
        [Description("running tests")]
        RunningTests,
        [Description("writing tests")]
        WritingTests,
        [Description("manual testing")]
        ManualTesting,
        [Description("code reviewing")]
        CodeReviewing,
        [Description("browsing")]
        Browsing,
        [Description("designing")]
        Designing
    }

    public enum EntityType
    {
        [Description("file")]
        File,
        [Description("domain")]
        Domain,
        [Description("app")]
        App
    }
}
