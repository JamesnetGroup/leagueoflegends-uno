namespace Jamesnet.Core;

public interface IContainer
{
    void Register<TInterface, TImplementation>() where TImplementation : TInterface;
    void RegisterSingleton<TInterface, TImplementation>() where TImplementation : TInterface;
    void RegisterInstance<TInterface>(TInterface instance);
    T Resolve<T>();
    object Resolve(Type type);
}
