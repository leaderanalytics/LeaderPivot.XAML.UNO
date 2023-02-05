﻿namespace LeaderAnalytics.LeaderPivot.XAML.UNO;

public enum DimensionAction
{
    [Description("Do nothing")]
    NoOp,
    [Description("Sort Ascending")]
    SortAscending,
    [Description("Sort Descending")]
    SortDescending,
    [Description("Hide")]
    Hide,
    [Description("UnHide")]
    UnHide
}