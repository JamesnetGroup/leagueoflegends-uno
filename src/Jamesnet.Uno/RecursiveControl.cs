using System.Collections;

namespace Jamesnet.Uno;

public class RecursiveControl : Control
{
    public RecursiveControl()
    {
        DefaultStyleKey = typeof(RecursiveControl);
    }

    public object ItemsSource
    {
        get => GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public static readonly DependencyProperty ItemsSourceProperty =
        DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RecursiveControl), new PropertyMetadata(null, OnItemsSourceChanged));

    private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((RecursiveControl)d).GenerateItems();
    }

    private Panel _itemsPanel;

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _itemsPanel = GetTemplateChild("PART_ItemsPanel") as Panel;
        GenerateItems();
    }

    private void GenerateItems()
    {
        if (_itemsPanel == null || ItemsSource == null) return;

        _itemsPanel.Children.Clear();

        foreach (var item in ItemsSource as IEnumerable)
        {
            var container = GetContainerForItem();
            container.DataContext = item;
            _itemsPanel.Children.Add(container);
        }
    }

    protected virtual RecursiveItem GetContainerForItem()
    {
        return new RecursiveItem();
    }
}
