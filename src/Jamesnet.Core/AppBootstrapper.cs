namespace Jamesnet.Core;

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
