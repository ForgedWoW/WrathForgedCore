using SSDI.Parameters;

namespace SSDI.Registration;

public class FluentExportRegistration
{
    internal InternalRegistration RegistrationBlock { get; }
    internal HashSet<Type> Alias { get; }

    public LifestyleScope Lifestyle { get; }

    public List<IDIParameter> Parameters { get; } = new();

    internal FluentExportRegistration(InternalRegistration registrationBlock)
    {
        RegistrationBlock = registrationBlock;
        Lifestyle = new LifestyleScope(this);
        Alias = new HashSet<Type>();
    }

    public FluentExportRegistration As<TAlias>()
    {
        _ = Alias.Add(typeof(TAlias));
        return this;
    }

    public FluentExportRegistration As(Type t)
    {
        _ = Alias.Add(t);
        return this;
    }

    public FluentExportRegistration WithCtorParam<TParam>(TParam value) where TParam : notnull
    {
        Parameters.Add(new TypedParameter(value));
        return this;
    }

    public FluentExportRegistration WithCtorParam(string name, object value)
    {
        Parameters.Add(new NamedParameter(name, value));
        return this;
    }

    public FluentExportRegistration WithCtorParam(int position, object value)
    {
        Parameters.Add(new PositionalParameter(position, value));
        return this;
    }

    /// <summary>
    ///     Adds a positional parameters to the constructor. The order of the parameters is important. Starts at 0.
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public FluentExportRegistration WithCtorPositionalParams(params object[] parameters)
    {
        for (var i = 0; i < parameters.Length; i++)
        {
            Parameters.Add(new PositionalParameter(i, parameters[i]));
        }

        return this;
    }

    public FluentExportRegistration WithCtorParam(IDIParameter dIParameter)
    {
        Parameters.Add(dIParameter);
        return this;
    }
}
