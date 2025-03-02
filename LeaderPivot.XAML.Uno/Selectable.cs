﻿namespace LeaderAnalytics.LeaderPivot.XAML.UNO;

public partial class Selectable<T> : ObservableObject
{
    [ObservableProperty]
    private bool _IsSelected;

    public T Item { get; set; }

    public Selectable(T item, bool isSelected = false)
    {
        Item = item;
        IsSelected = isSelected;
    }
}
