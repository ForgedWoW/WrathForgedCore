using SSDI.Builder;
using SSDI.Registration;

namespace SSDI;

public class DependencyInjectionContainer : ActivationBuilder
{
    public void Configure(Action<ExportRegistration> registration)
    {
        var exportRegistration = new ExportRegistration();
        registration(exportRegistration);
        Add(exportRegistration);
    }
}