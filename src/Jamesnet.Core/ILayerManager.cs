namespace Jamesnet.Core;

public interface ILayerManager
{
    void RegisterLayer(string layerName, ILayer layer);
    void AddView(string layerName, IView view);
    void ActivateView(string layerName, IView view);
    void DeactivateView(string layerName);
    void SetLayerViewMapping(string layerName, IView view);
}
