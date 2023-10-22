namespace SSDI.Registration;

public enum LifestyleType
{
    /// <summary>
    ///     Every time a dependency is resolved, a new instance is created.
    /// </summary>
    Scoped,

    /// <summary>
    ///    A single instance is created for the lifetime of the application.
    /// </summary>
    Singleton
}

public class LifestyleScope
{
    private readonly FluentExportRegistration _registrationBlock;
    private bool _set = false;

    public LifestyleScope(FluentExportRegistration registrationBlock) => _registrationBlock = registrationBlock;

    public LifestyleType Lifestyle { get; set; } = LifestyleType.Scoped;

    /// <summary>
    ///     A single instance is created for the lifetime of the application. Can be called only once per registration.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if the caller attempts to set the lifestyle more than once. The lifestyle cannot be changed after registration as the object DI graph is alreay registed.</exception>
    /// <returns></returns>
    public FluentExportRegistration Singleton()
    {
        if (_set)
            throw new InvalidOperationException("Lifestyle already set.");

        _set = true;
        Lifestyle = LifestyleType.Singleton;
        return _registrationBlock;
    }

    /// <summary>
    ///     Every time a dependency is resolved, a new instance is created. This is the default. Can be called only once per registration.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if the caller attempts to set the lifestyle more than once. The lifestyle cannot be changed after registration as the object DI graph is alreay registed.</exception>
    /// <returns></returns>
    public FluentExportRegistration Scoped()
    {
        if (_set)
            throw new InvalidOperationException("Lifestyle already set.");

        _set = true;
        Lifestyle = LifestyleType.Scoped;
        return _registrationBlock;
    }

    internal void Set() => _set = true;
}
