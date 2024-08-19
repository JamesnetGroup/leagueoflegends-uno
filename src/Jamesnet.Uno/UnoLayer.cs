using Jamesnet.Core;

namespace Jamesnet.Uno;

public class UnoLayer : ContentControl, ILayer
{
    public static readonly DependencyProperty LayerNameProperty =
        DependencyProperty.Register(nameof(LayerName), typeof(string), typeof(UnoLayer), new PropertyMetadata(null, OnLayerNameChanged));

    public string LayerName
    {
        get => (string)GetValue(LayerNameProperty);
        set => SetValue(LayerNameProperty, value);
    }

    public UnoLayer()
    {
        DefaultStyleKey = typeof(UnoLayer);
        Loaded += UnoLayer_Loaded;
    }

    private void UnoLayer_Loaded(object sender, RoutedEventArgs e)
    {
        RegisterToLayerManager();
    }

    private void RegisterToLayerManager()
    {
        if (!string.IsNullOrEmpty(LayerName))
        {
            var layerManager = ContainerProvider.GetContainer().Resolve<ILayerManager>();
            layerManager.RegisterLayer(LayerName, this);
        }
    }

    private static void OnLayerNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is UnoLayer layer)
        {
            layer.RegisterToLayerManager();
        }
    }
}
