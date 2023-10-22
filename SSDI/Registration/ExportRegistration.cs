namespace SSDI.Registration;

public class ExportRegistration
{
    internal List<InternalRegistration> Registrations { get; } = new List<InternalRegistration>();

    public FluentExportRegistration Export<T>() => Export(typeof(T));
    public FluentExportRegistration Export(Type t)
    {
        var registration = new InternalRegistration(t);
        Registrations.Add(registration);
        return registration.FluentExportRegistration;
    }

    public FluentExportRegistration ExportInstance<T>(T instance)
    {
        var registration = new InternalRegistration(typeof(T), instance);
        Registrations.Add(registration);
        _ = registration.FluentExportRegistration.Lifestyle.Singleton();
        return registration.FluentExportRegistration;
    }
}
