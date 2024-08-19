using Jamesnet.Core;

namespace Jamesnet.Uno;

public class UnoView : ContentControl, IView
{
    public UnoView()
    {
        DefaultStyleKey = typeof(UnoView);
        InitializeViewModel();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (DataContext is IViewLoadable loadable)
        {
            loadable.Loaded();
        }

        Loaded -= OnLoaded;
    }

    public void InitializeViewModel()
    {
        var initializer = ContainerProvider.GetContainer().Resolve<IViewModelInitializer>();
        initializer.InitializeViewModel(this);
        OnViewModelInitialized();
    }

    protected virtual void OnViewModelInitialized()
    {
    }
}
