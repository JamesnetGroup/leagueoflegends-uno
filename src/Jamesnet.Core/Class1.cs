using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Jamesnet.Core;

public interface IContainer
{
    void Register<TInterface, TImplementation>() where TImplementation : TInterface;
    void RegisterSingleton<TInterface, TImplementation>() where TImplementation : TInterface;
    void RegisterInstance<TInterface>(TInterface instance);
    T Resolve<T>();
    object Resolve(Type type);
}

public class Container : IContainer
{
    private readonly Dictionary<(Type, string), Func<object>> _registrations = new Dictionary<(Type, string), Func<object>>();

    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        Register<TInterface, TImplementation>(null);
    }

    public void Register<TInterface, TImplementation>(string name) where TImplementation : TInterface
    {
        _registrations[(typeof(TInterface), name)] = () => CreateInstance(typeof(TImplementation));
    }

    public void RegisterSingleton<TInterface, TImplementation>() where TImplementation : TInterface
    {
        RegisterSingleton<TInterface, TImplementation>(null);
    }

    public void RegisterSingleton<TInterface, TImplementation>(string name) where TImplementation : TInterface
    {
        var instance = CreateInstance(typeof(TImplementation));
        _registrations[(typeof(TInterface), name)] = () => instance;
    }

    public void RegisterInstance<TInterface>(TInterface instance)
    {
        RegisterInstance(instance, null);
    }

    public void RegisterInstance<TInterface>(TInterface instance, string name)
    {
        _registrations[(typeof(TInterface), name)] = () => instance;
    }

    public T Resolve<T>()
    {
        return Resolve<T>(null);
    }

    public T Resolve<T>(string name)
    {
        return (T)Resolve(typeof(T), name);
    }

    public object Resolve(Type type)
    {
        return Resolve(type, null);
    }

    public object Resolve(Type type, string name)
    {
        if (_registrations.TryGetValue((type, name), out var creator))
        {
            return creator();
        }

        if (!type.IsAbstract && !type.IsInterface)
        {
            return CreateInstance(type);
        }

        throw new InvalidOperationException($"Type {type} has not been registered.");
    }

    private object CreateInstance(Type type)
    {
        var constructors = type.GetConstructors();
        var constructor = constructors.FirstOrDefault(c => c.GetParameters().Length > 0) ?? constructors.First();

        var parameters = constructor.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();
        return constructor.Invoke(parameters);
    }
}

public interface IView2
{ 
    string Name { get; set; }
}

public interface IView
{
    object DataContext { get; set; }
}

public interface IViewModelInitializer
{
    void InitializeViewModel(IView view);
}

public class DefaultViewModelInitializer : IViewModelInitializer
{
    private readonly IContainer _container;
    private readonly IViewModelMapper _viewModelMapper;

    public DefaultViewModelInitializer(IContainer container, IViewModelMapper viewModelMapper)
    {
        _container = container;
        _viewModelMapper = viewModelMapper;
    }

    public void InitializeViewModel(IView view)
    {
        var viewType = view.GetType();
        var viewModelType = _viewModelMapper.GetViewModelType(viewType);

        if (viewModelType != null)
        {
            var viewModel = CreateViewModel(viewModelType);
            view.DataContext = viewModel;
        }
    }

    private object CreateViewModel(Type viewModelType)
    {
        try
        {
            var constructor = viewModelType.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .First();

            var parameters = constructor.GetParameters()
                .Select(p => _container.Resolve(p.ParameterType))
                .ToArray();

            return constructor.Invoke(parameters);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to create ViewModel of type {viewModelType.Name}.", ex);
        }
    }

}

public static class ContainerProvider
{
    private static IContainer _container;

    public static void SetContainer(IContainer container)
    {
        _container = container;
    }

    public static IContainer GetContainer()
    {
        if (_container == null)
        {
            throw new InvalidOperationException("IContainer has not been set. Make sure to call ContainerProvider.SetContainer in your App class.");
        }
        return _container;
    }
}

public abstract class AppBootstrapper
{
    protected readonly IContainer Container;
    protected readonly IViewModelMapper ViewModelMapper;

    protected AppBootstrapper()
    {
        Container = new Container();
        ViewModelMapper = new ViewModelMapper();
        ContainerProvider.SetContainer(Container);
        ConfigureContainer();
    }

    protected virtual void ConfigureContainer()
    {
        Container.RegisterInstance<IContainer>(Container);
        Container.RegisterInstance<IViewModelMapper>(ViewModelMapper);
        Container.RegisterSingleton<IViewModelInitializer, DefaultViewModelInitializer>();
        Container.RegisterSingleton<ILayerManager, LayerManager>();
    }

    protected abstract void RegisterDependencies();
    protected abstract void RegisterViewModels();

    public void Run()
    {
        RegisterDependencies();
        RegisterViewModels();
        OnStartup();
    }

    protected abstract void OnStartup();
}

public interface IViewModelMapper
{
    void Register<TView, TViewModel>() where TView : IView where TViewModel : class;
    Type GetViewModelType(Type viewType);
}

public class ViewModelMapper : IViewModelMapper
{
    private readonly Dictionary<Type, Type> _mappings = new Dictionary<Type, Type>();

    public void Register<TView, TViewModel>() where TView : IView where TViewModel : class
    {
        _mappings[typeof(TView)] = typeof(TViewModel);
    }

    public Type GetViewModelType(Type viewType)
    {
        return _mappings.TryGetValue(viewType, out var viewModelType) ? viewModelType : null;
    }
}

public interface ILayer
{
    object Content { get; set; }
}

public interface ILayerManager
{
    void RegisterLayer(string layerName, ILayer layer);
    void AddView(string layerName, IView view);
    void ActivateView(string layerName, IView view);
    void DeactivateView(string layerName);
    void SetLayerViewMapping(string layerName, IView view);
}

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

public class RelayCommand<T> : ICommand
{
    private readonly Action<T> _execute;
    private readonly Func<T, bool> _canExecute;

    public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute((T)parameter);
    }

    public void Execute(object parameter)
    {
        _execute((T)parameter);
    }

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(storage, value))
            return false;

        storage = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}

public interface IViewLoadable
{
    void Loaded();
}
