using System.Collections;

namespace Jamesnet.Uno;

public class RecursiveItem : ContentControl
{
    public RecursiveItem()
    {
        DefaultStyleKey = typeof(RecursiveItem);
    }

    public object ItemsSource
    {
        get => GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public static readonly DependencyProperty ItemsSourceProperty =
        DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RecursiveItem), new PropertyMetadata(null, OnItemsSourceChanged));

    public string ItemsBindingPath
    {
        get => (string)GetValue(ItemsBindingPathProperty);
        set => SetValue(ItemsBindingPathProperty, value);
    }

    public static readonly DependencyProperty ItemsBindingPathProperty =
        DependencyProperty.Register(nameof(ItemsBindingPath), typeof(string), typeof(RecursiveItem), new PropertyMetadata(null));

    private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((RecursiveItem)d).GenerateItems();
    }

    public bool IsExpanded
    {
        get => (bool)GetValue(IsExpandedProperty);
        set => SetValue(IsExpandedProperty, value);
    }

    public static readonly DependencyProperty IsExpandedProperty = DependencyProperty.Register(nameof(IsExpanded), typeof(bool), typeof(RecursiveItem), new PropertyMetadata(true, OnIsExpandedChanged));

    private static void OnIsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((RecursiveItem)d).UpdateChildrenVisibility();
    }

    private Panel _itemsPanel;

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _itemsPanel = GetTemplateChild("PART_ItemsPanel") as Panel;
        UpdateChildrenVisibility();
        SetItemsSourceFromDataContext();
    }

    private void SetItemsSourceFromDataContext()
    {
        if (DataContext == null || string.IsNullOrEmpty(ItemsBindingPath)) return;

        var dataContextType = DataContext.GetType();
        var property = dataContextType.GetProperty(ItemsBindingPath);

        if (property != null && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
        {
            var value = property.GetValue(DataContext);
            if (value is IEnumerable enumerable)
            {
                ItemsSource = enumerable;
            }
        }
    }

    private void GenerateItems()
    {
        if (_itemsPanel == null || ItemsSource == null) return;

        _itemsPanel.Children.Clear();

        foreach (var item in ItemsSource as IEnumerable)
        {
            var container = GetContainerForItemOverride();

            if (container is FrameworkElement fe)
            {
                fe.DataContext = item;
                _itemsPanel.Children.Add(fe);
            }
        }
    }

    protected virtual DependencyObject GetContainerForItemOverride()
    {
        return new RecursiveItem();
    }

    private void UpdateChildrenVisibility()
    {
        if (_itemsPanel != null)
        {
            _itemsPanel.Visibility = IsExpanded ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
