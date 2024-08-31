
namespace Leagueoflegends.Support.UI.Units;

public class RiotTabMenu : ListBox
{
    private Grid _uniformGrid;
    private int _columns = 2;  // 기본값을 2로 설정

    public int Columns
    {
        get => _columns;
        set
        {
            _columns = value;
            UpdateUniformGrid();
        }
    }

    public RiotTabMenu()
    {
        DefaultStyleKey = typeof(RiotTabMenu);
        SelectionChanged += RiotRiotTabMenu_SelectionChanged;
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _uniformGrid = GetTemplateChild("PART_UniformGrid") as Grid;
        UpdateUniformGrid();
    }

    protected override void OnItemsChanged(object e)
    {
        base.OnItemsChanged(e);
        UpdateUniformGrid();
    }

    private void UpdateUniformGrid()
    {
        if (_uniformGrid == null) return;

        _uniformGrid.ColumnDefinitions.Clear();
        for (int i = 0; i < _columns; i++)
        {
            _uniformGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        }

        int itemCount = Items.Count;
        int rows = (itemCount + _columns - 1) / _columns;

        _uniformGrid.RowDefinitions.Clear();
        for (int i = 0; i < rows; i++)
        {
            _uniformGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        }

        for (int i = 0; i < itemCount; i++)
        {
            var item = Items[i] as FrameworkElement;
            if (item != null)
            {
                Grid.SetRow(item, i / _columns);
                Grid.SetColumn(item, i % _columns);
            }
        }
    }

    private void RiotRiotTabMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.RemovedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = false;
            }
        }

        foreach (var item in e.AddedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = true;
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotTabMenuItem();
    }
}
