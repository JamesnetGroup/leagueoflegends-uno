namespace Jamesnet.Core;

public class LayerManager : ILayerManager
{
    private readonly Dictionary<string, ILayer> _layers = new Dictionary<string, ILayer>();
    private readonly Dictionary<string, List<IView>> _layerViews = new Dictionary<string, List<IView>>();
    private readonly Dictionary<string, IView> _layerViewMappings = new Dictionary<string, IView>();

    public void RegisterLayer(string layerName, ILayer layer)
    {
        if (!_layers.ContainsKey(layerName))
        {
            _layers[layerName] = layer;
            _layerViews[layerName] = new List<IView>();

            if (_layerViewMappings.TryGetValue(layerName, out var view))
            {
                AddView(layerName, view);
                ActivateView(layerName, view);
            }
        }
    }

    public void AddView(string layerName, IView view)
    {
        if (!_layerViews.TryGetValue(layerName, out var views))
        {
            throw new InvalidOperationException($"Layer not registered: {layerName}");
        }
        views.Add(view);
    }

    public void ActivateView(string layerName, IView view)
    {
        if (!_layers.TryGetValue(layerName, out var layer))
        {
            throw new InvalidOperationException($"Layer not registered: {layerName}");
        }
        if (!_layerViews[layerName].Contains(view))
        {
            throw new InvalidOperationException($"View not added to layer: {layerName}");
        }
        layer.Content = view;
    }

    public void DeactivateView(string layerName)
    {
        if (_layers.TryGetValue(layerName, out var layer))
        {
            layer.Content = null;
        }
    }

    public void SetLayerViewMapping(string layerName, IView view)
    {
        _layerViewMappings[layerName] = view;
    }
}
