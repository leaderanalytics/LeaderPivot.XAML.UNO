﻿using CommunityToolkit.WinUI.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LeaderAnalytics.LeaderPivot.XAML.UNO;

public sealed partial class LeaderPivotControl : Control
{
    #region Properties
    public PivotViewBuilder ViewBuilder
    {
        get { return (PivotViewBuilder)GetValue(ViewBuilderProperty); }
        set { SetValue(ViewBuilderProperty, value); }
    }

    public static readonly DependencyProperty ViewBuilderProperty =
        DependencyProperty.Register("ViewBuilder", typeof(PivotViewBuilder), typeof(LeaderPivotControl), new PropertyMetadata(null, async (s, e) => await ((LeaderPivotControl)s).BuildGrid(null)));


    public bool DisplayGrandTotalOption
    {
        get { return (bool)GetValue(DisplayGrandTotalOptionProperty); }
        set { SetValue(DisplayGrandTotalOptionProperty, value); }
    }

    public static readonly DependencyProperty DisplayGrandTotalOptionProperty =
        DependencyProperty.Register("DisplayGrandTotalOption", typeof(bool), typeof(LeaderPivotControl), new PropertyMetadata(true));


    public bool DisplayDimensionButtons
    {
        get { return (bool)GetValue(DisplayDimensionButtonsProperty); }
        set { SetValue(DisplayDimensionButtonsProperty, value); }
    }

    public static readonly DependencyProperty DisplayDimensionButtonsProperty =
        DependencyProperty.Register("DisplayDimensionButtons", typeof(bool), typeof(LeaderPivotControl), new PropertyMetadata(true));


    public bool DisplayMeasureSelectors
    {
        get { return (bool)GetValue(DisplayMeasureSelectorsProperty); }
        set { SetValue(DisplayMeasureSelectorsProperty, value); }
    }

    public static readonly DependencyProperty DisplayMeasureSelectorsProperty =
        DependencyProperty.Register("DisplayMeasureSelectors", typeof(bool), typeof(LeaderPivotControl), new PropertyMetadata(true));


    public bool DisplayReloadDataButton
    {
        get { return (bool)GetValue(DisplayReloadDataButtonProperty); }
        set { SetValue(DisplayReloadDataButtonProperty, value); }
    }

    public static readonly DependencyProperty DisplayReloadDataButtonProperty =
        DependencyProperty.Register("DisplayReloadDataButton", typeof(bool), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public int CellPadding
    {
        get { return (int)GetValue(CellPaddingProperty); }
        set { SetValue(CellPaddingProperty, value); }
    }

    public static readonly DependencyProperty CellPaddingProperty =
        DependencyProperty.Register("CellPadding", typeof(int), typeof(LeaderPivotControl), new PropertyMetadata(4));


    public Thickness CellBorderThickness
    {
        get { return (Thickness)GetValue(CellBorderThicknessProperty); }
        set { SetValue(CellBorderThicknessProperty, value); }
    }

    public static readonly DependencyProperty CellBorderThicknessProperty =
        DependencyProperty.Register("CellBorderThickness", typeof(Thickness), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Brush CellBorderBrush
    {
        get { return (Brush)GetValue(CellBorderBrushProperty); }
        set { SetValue(CellBorderBrushProperty, value); }
    }

    public static readonly DependencyProperty CellBorderBrushProperty =
        DependencyProperty.Register("CellBorderBrush", typeof(Brush), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public bool IsBusy
    {
        get { return (bool)GetValue(IsBusyProperty); }
        set { SetValue(IsBusyProperty, value); }
    }

    public static readonly DependencyProperty IsBusyProperty =
        DependencyProperty.Register("IsBusy", typeof(bool), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style MeasureCellStyle
    {
        get { return (Style)GetValue(MeasureCellStyleProperty); }
        set { SetValue(MeasureCellStyleProperty, value); }
    }

    public static readonly DependencyProperty MeasureCellStyleProperty =
        DependencyProperty.Register("MeasureCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style TotalCellStyle
    {
        get { return (Style)GetValue(TotalCellStyleProperty); }
        set { SetValue(TotalCellStyleProperty, value); }
    }

    public static readonly DependencyProperty TotalCellStyleProperty =
        DependencyProperty.Register("TotalCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public Style GrandTotalCellStyle
    {
        get { return (Style)GetValue(GrandTotalCellStyleProperty); }
        set { SetValue(GrandTotalCellStyleProperty, value); }
    }

    public static readonly DependencyProperty GrandTotalCellStyleProperty =
        DependencyProperty.Register("GrandTotalCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public Style GroupHeaderCellStyle
    {
        get { return (Style)GetValue(GroupHeaderCellStyleProperty); }
        set { SetValue(GroupHeaderCellStyleProperty, value); }
    }

    public static readonly DependencyProperty GroupHeaderCellStyleProperty =
        DependencyProperty.Register("GroupHeaderCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public Style TotalHeaderCellStyle
    {
        get { return (Style)GetValue(TotalHeaderCellStyleProperty); }
        set { SetValue(TotalHeaderCellStyleProperty, value); }
    }

    public static readonly DependencyProperty TotalHeaderCellStyleProperty =
        DependencyProperty.Register("TotalHeaderCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public Style GrandTotalHeaderCellStyle
    {
        get { return (Style)GetValue(GrandTotalHeaderCellStyleProperty); }
        set { SetValue(GrandTotalHeaderCellStyleProperty, value); }
    }

    public static readonly DependencyProperty GrandTotalHeaderCellStyleProperty =
        DependencyProperty.Register("GrandTotalHeaderCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public Style MeasureTotalLabelCellStyle
    {
        get { return (Style)GetValue(MeasureTotalLabelCellStyleProperty); }
        set { SetValue(MeasureTotalLabelCellStyleProperty, value); }
    }

    public static readonly DependencyProperty MeasureTotalLabelCellStyleProperty =
        DependencyProperty.Register("MeasureTotalLabelCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style MeasureContainerCellStyle
    {
        get { return (Style)GetValue(MeasureContainerCellStyleProperty); }
        set { SetValue(MeasureContainerCellStyleProperty, value); }
    }

    public static readonly DependencyProperty MeasureContainerCellStyleProperty =
        DependencyProperty.Register("MeasureContainerCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style DimensionContainerCellStyle
    {
        get { return (Style)GetValue(DimensionContainerCellStyleProperty); }
        set { SetValue(DimensionContainerCellStyleProperty, value); }
    }

    public static readonly DependencyProperty DimensionContainerCellStyleProperty =
        DependencyProperty.Register("DimensionContainerCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style MeasureLabelCellStyle
    {
        get { return (Style)GetValue(MeasureLabelCellStyleProperty); }
        set { SetValue(MeasureLabelCellStyleProperty, value); }
    }

    public static readonly DependencyProperty MeasureLabelCellStyleProperty =
        DependencyProperty.Register("MeasureLabelCellStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style DimensionButtonStyle
    {
        get { return (Style)GetValue(DimensionButtonStyleProperty); }
        set { SetValue(DimensionButtonStyleProperty, value); }
    }

    public static readonly DependencyProperty DimensionButtonStyleProperty =
        DependencyProperty.Register("DimensionButtonStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public Style MeasureCheckboxStyle
    {
        get { return (Style)GetValue(MeasureCheckboxStyleProperty); }
        set { SetValue(MeasureCheckboxStyleProperty, value); }
    }

    public static readonly DependencyProperty MeasureCheckboxStyleProperty =
        DependencyProperty.Register("MeasureCheckboxStyle", typeof(Style), typeof(LeaderPivotControl), new PropertyMetadata(null));

    #endregion


    #region Commands

    public ICommand ReloadDataCommand
    {
        get { return (ICommand)GetValue(ReloadDataCommandProperty); }
        set { SetValue(ReloadDataCommandProperty, value); }
    }

    public static readonly DependencyProperty ReloadDataCommandProperty =
        DependencyProperty.Register("command", typeof(ICommand), typeof(LeaderPivotControl), new PropertyMetadata(null));


    public ICommand DimensionEventCommand
    {
        get { return (ICommand)GetValue(DimensionEventCommandProperty); }
        set { SetValue(DimensionEventCommandProperty, value); }
    }

    public static readonly DependencyProperty DimensionEventCommandProperty =
        DependencyProperty.Register("DimensionEventCommand", typeof(ICommand), typeof(LeaderPivotControl), new PropertyMetadata(null));



    public IRelayCommand ToggleMeasureEnabledCommand
    {
        get { return (IRelayCommand)GetValue(ToggleMeasureEnabledCommandProperty); }
        set { SetValue(ToggleMeasureEnabledCommandProperty, value); }
    }

    public static readonly DependencyProperty ToggleMeasureEnabledCommandProperty =
        DependencyProperty.Register("ToggleMeasureEnabledCommand", typeof(IRelayCommand), typeof(LeaderPivotControl), new PropertyMetadata(null));

    #endregion

    private byte[,]? table;
    private Grid grid;
    private ICommand toggleNodeExpansionCommand;
    private bool IsLoaded;

    public LeaderPivotControl()
    {
        this.DefaultStyleKey = typeof(LeaderPivotControl);
        ReloadDataCommand = new AsyncRelayCommand(() => BuildGrid(null));
        DimensionEventCommand = new AsyncRelayCommand<DimensionEventArgs>(DimensionEventCommandHandler);
        toggleNodeExpansionCommand = new AsyncRelayCommand<string>(x => BuildGrid(x));
        ToggleMeasureEnabledCommand = new AsyncRelayCommand<Selectable<Measure>>(ToggleMeasureEnabledCommandHandler, (m) => {

            // The intent of this logic is to require at least one measure to be selected.
            // Therefore, the checkbox should be enabled if any of the following is true:
            // 1.) Checkbox is unchecked - user should always be able to select (check) a measure.
            // 2.) More than one checkbox is checked.

            bool canExecute = !m.IsSelected || ViewBuilder.Measures.Count(x => x.Item.IsEnabled) > 1;
            return canExecute;
        });

        Loaded += OnLoaded;
    }

    protected async void OnLoaded(object sender, RoutedEventArgs e)
    { 
        IsLoaded = true;
        Loaded -= OnLoaded;
        await BuildGrid(null);
    }

    protected override void OnApplyTemplate()
    {
        grid = (Grid)GetTemplateChild("PART_Grid");
        base.OnApplyTemplate();
    }

    public async Task BuildGrid(string? nodeID)
    {
        if(!IsLoaded)
            return;

        // Row span takes precidence over column span.
        // If a cell spans multiple rows, cells in the second and subsequent rows are pushed to the right - not down.
        // A cell is never pushed down to a lower row - it is pushed to the right.  Therefore a cells row index in the matrix is
        // always the same as it's row number in the grid.
        IsBusy = true;
        await ViewBuilder.BuildMatrix(nodeID);
        grid.Children.Clear();
        grid.RowDefinitions.Clear();
        grid.ColumnDefinitions.Clear();
        int rowCount = ViewBuilder.Matrix.Rows.Count;
        int columnCount = ViewBuilder.Matrix.Rows[0].Cells.Sum(x => x.ColSpan);

        table = new byte[rowCount, columnCount];

        for (int j = 0; j < columnCount; j++)
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

        for (int i = 0; i < rowCount; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            int columnIndex = 0;

            for (int j = 0; j < ViewBuilder.Matrix.Rows[i].Cells.Count; j++)
            {
                MatrixCell? mCell = ViewBuilder.Matrix.Rows[i].Cells[j];

                BaseCell cell = mCell.CellType switch
                {
                    CellType.Measure => new MeasureCell(),
                    CellType.Total => new TotalCell(),
                    CellType.GrandTotal => new GrandTotalCell(),
                    CellType.GroupHeader => new GroupHeaderCell { NodeID = mCell.NodeID, IsExpanded = mCell.IsExpanded, CanToggleExpansion = mCell.CanToggleExapansion, ToggleNodeExpansionCommand = toggleNodeExpansionCommand },
                    CellType.TotalHeader => new TotalHeaderCell(),
                    CellType.GrandTotalHeader => new GrandTotalHeaderCell(),
                    CellType.MeasureTotalLabel => new MeasureTotalLabelCell(),
                    CellType.MeasureLabel when i == 0 && j == 0 => new MeasureContainerCell(),
                    CellType.MeasureLabel when i == 0 && j == 1 => new DimensionContainerCell { Dimensions = ViewBuilder.ColumnDimensions, IsRows = false },
                    CellType.MeasureLabel => new MeasureLabelCell(),
                    _ => throw new NotImplementedException($"Cell type not recognised: {mCell.CellType}.")
                };

                Style? style = cell switch
                {
                    MeasureCell => MeasureCellStyle,
                    TotalCell => TotalCellStyle,
                    GrandTotalCell => GrandTotalCellStyle,
                    GroupHeaderCell => GroupHeaderCellStyle,
                    TotalHeaderCell => TotalHeaderCellStyle,
                    GrandTotalHeaderCell => GrandTotalHeaderCellStyle,
                    MeasureTotalLabelCell => MeasureTotalLabelCellStyle,
                    MeasureContainerCell => MeasureContainerCellStyle,
                    DimensionContainerCell => DimensionContainerCellStyle,
                    MeasureLabelCell => MeasureLabelCellStyle,
                    _ => throw new NotImplementedException($"Object type not recognised: {cell.GetType()}.")
                };

                if (style != null)
                    cell.Style = style;

                CellContainer container = new CellContainer();

                container.RowSpan = mCell.RowSpan;
                container.ColSpan = mCell.ColSpan;
                container.Content = cell;
                cell.Content = mCell.Value?.ToString();
                columnIndex = IncrementCol(i, columnIndex, container);
                Grid.SetRow(container, i);
                Grid.SetRowSpan(container, container.RowSpan);
                Grid.SetColumn(container, columnIndex);
                Grid.SetColumnSpan(container, container.ColSpan);
                grid.Children.Add(container);
            }
        }
        IsBusy = false;
    }

    public async Task DimensionEventCommandHandler(DimensionEventArgs dimensionEvent)
    {
        if (dimensionEvent == null)
            throw new ArgumentNullException(nameof(dimensionEvent));
        if (dimensionEvent.Action == DimensionAction.NoOp)
            return;

        Dimension dimension = ViewBuilder.Dimensions.First(x => x.DisplayValue == dimensionEvent.DimensionID);

        var x = dimensionEvent.Action switch
        {
            DimensionAction.SortAscending => dimension.IsAscending = true,
            DimensionAction.SortDescending => dimension.IsAscending = false,
            DimensionAction.Hide => dimension.IsEnabled = false,
            DimensionAction.UnHide => dimension.IsEnabled = true,
            _ => throw new Exception($"DimensionAction not recognised: {dimensionEvent.Action}"),
        };
        await BuildGrid(null);
    }

    private int IncrementCol(int rowIndex, int colIndex, CellContainer cell)
    {
        while (table[rowIndex, colIndex] == 1)
            colIndex++;

        for (int r = rowIndex; r < rowIndex + cell.RowSpan; r++)
            for (int c = colIndex; c < colIndex + cell.ColSpan; c++)
                table[r, c] = 1;

        return colIndex;
    }


    public async Task ToggleMeasureEnabledCommandHandler(Selectable<Measure> measure)
    {
        measure.Item.IsEnabled = measure.IsSelected;
        ToggleMeasureEnabledCommand.NotifyCanExecuteChanged();
        await BuildGrid(null);
    }
}
