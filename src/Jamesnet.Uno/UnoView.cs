using Jamesnet.Core;

namespace Jamesnet.Uno;

public class UnoView : ContentControl, IView
{
    private bool _viewModelInitialized = false;

    public UnoView()
    {
        DefaultStyleKey = typeof(UnoView);
        InitializeViewModel();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (_viewModelInitialized && DataContext is IViewLoadable loadable)
        {
            loadable.Loaded();
        }
        Loaded -= OnLoaded;
    }

    public void InitializeViewModel()
    {
        var initializer = ContainerProvider.GetContainer().Resolve<IViewModelInitializer>();
        initializer.InitializeViewModel(this);

        _viewModelInitialized = DataContext != null;

        OnViewModelInitialized();
    }

    protected virtual void OnViewModelInitialized()
    {
    }
}
