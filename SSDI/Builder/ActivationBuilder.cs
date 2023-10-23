using System.Collections;
using SSDI.Parameters;
using SSDI.Registration;

namespace SSDI.Builder;

public class ActivationBuilder
{
    private readonly Dictionary<Type, List<CachedConstructor[]>> _constructors = new();
    private readonly Dictionary<Type, LifestyleType> _lifetimes = new();
    private readonly Dictionary<Type, HashSet<object>> _singletonInstances = new();
    private readonly Dictionary<Type, HashSet<Type>> _alias = new();

    internal void Add(ExportRegistration reg)
    {
        foreach (var exportRegistration in reg.Registrations)
        {
            _lifetimes[exportRegistration.ExportedType] = exportRegistration.FluentExportRegistration.Lifestyle.Lifestyle;

            foreach (var aliasType in exportRegistration.FluentExportRegistration.Alias)
            {
                if (!_alias.TryGetValue(aliasType, out var aliasSet))
                {
                    aliasSet = new HashSet<Type>();
                    _alias[aliasType] = aliasSet;
                }

                _ = aliasSet.Add(exportRegistration.ExportedType);
                _lifetimes[aliasType] = exportRegistration.FluentExportRegistration.Lifestyle.Lifestyle;
            }

            if (exportRegistration.FluentExportRegistration.Lifestyle.Lifestyle == LifestyleType.Singleton &&
                exportRegistration.Instance is not null)
            {
                if (!_singletonInstances.TryGetValue(exportRegistration.ExportedType, out var singletons))
                {
                    singletons = new HashSet<object>();
                    _singletonInstances[exportRegistration.ExportedType] = singletons;
                }

                _ = singletons.Add(exportRegistration.Instance);
                continue;
            }

            // Order constructors by parameter count, descending so we get the lowest parameter count constructor first
            if (!_constructors.TryGetValue(exportRegistration.ExportedType, out var constructors))
            {
                constructors = new List<CachedConstructor[]>();
                _constructors[exportRegistration.ExportedType] = constructors;
            }

            constructors.Add(exportRegistration.ExportedType.GetConstructors().Select(c => new CachedConstructor(c, exportRegistration.FluentExportRegistration.Parameters)).ToArray());
        }
    }

    public T Locate<T>() => (T)Locate(typeof(T));

    public object Locate(Type type) => Locate(type, Array.Empty<IDIParameter>());

    public T LocateWithPositionalParams<T>(params object[] parameters) => (T)Locate(typeof(T), parameters.Select((p, i) => new PositionalParameter(i, p)).ToArray());

    public T LocateWithNamedParameters<T>(params (string name, object value)[] parameters) => (T)Locate(typeof(T), parameters.Select(p => new NamedParameter(p.name, p.value)).ToArray());

    public T LocateWithTypedParams<T>(params object[] parameters) => (T)Locate(typeof(T), parameters.Select(p => new TypedParameter(p)).ToArray());

    public T Locate<T>(params IDIParameter[] parameters) => (T)Locate(typeof(T), parameters);

    public T Locate<T>(int position, object value) => (T)Locate(typeof(T), new PositionalParameter(position, value));

    public T LocateWithParams<T>(params IDIParameter[] parameters) => (T)Locate(typeof(T), parameters);

    public object Locate(Type type, params IDIParameter[] parameters)
    {
        var isEnumerable = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>);
        type = isEnumerable ? type.GetGenericArguments()[0] : type;

        if (_alias.TryGetValue(type, out var alias))
        {
            if (isEnumerable)
            {
                var list = CreateListOfTType(type);

                foreach (var a in alias)
                {
                    if (LocateInternal(a, isEnumerable, parameters) is IList listOfObj)
                        foreach (var o in listOfObj)
                            _ = list.Add(o);
                }

                return list;
            }
            else
            {
                foreach (var a in alias)
                    return LocateInternal(a, isEnumerable, parameters);

                throw new Exception($"Could not find a concrete type for interface {type.FullName}");
            }
        }
        else
        {
            return LocateInternal(type, isEnumerable, parameters);
        }
    }

    private object LocateInternal(Type type, bool isEnumerable, params IDIParameter[] parameters)
    {
        if (_lifetimes.TryGetValue(type, out var lifestyleType) &&
            lifestyleType == LifestyleType.Singleton &&
            _singletonInstances.TryGetValue(type, out var instance))
        {
            return isEnumerable ? instance : instance.First();
        }

        if (_constructors.TryGetValue(type, out var constructors))
            foreach (var c in constructors)
            {
                if (isEnumerable)
                {
                    var list = CreateListOfTType(type);

                    foreach (var cc in c)
                    {
                        var param = cc.ParameterValues.Concat(parameters).ToList(); // if parameters where provided use constructor that has them.

                        if (cc.Parameters.Length >= param.Count && Locate(cc, type, lifestyleType, param, out var val))
                            _ = list.Add(val);
                    }

                    return list;
                }
                else
                {
                    foreach (var cc in c)
                    {
                        var param = cc.ParameterValues.Concat(parameters).ToList(); // if parameters where provided use constructor that has them.

                        if (cc.Parameters.Length >= param.Count && Locate(cc, type, lifestyleType, param, out var val))
                            return val;
                    }
                }
            }

        return isEnumerable ? CreateListOfTType(type) : Activator.CreateInstance(type)!;
    }

    private static IList CreateListOfTType(Type type)
    {
        var listType = typeof(List<>).MakeGenericType(type);
        var listObj = Activator.CreateInstance(listType) ?? throw new Exception($"Could not create list of type {listType.FullName}");

        var list = (IList)listObj;
        return list;
    }

    private bool Locate(CachedConstructor c, Type type, LifestyleType lifestyleType, List<IDIParameter> parameterValues, out object val)
    {
        if (c.Parameters.Length == 0)
        {
            var noParamsInstance = c.ConstructorDelegate.DynamicInvoke(null);

            if (noParamsInstance is null)
            {
                val = default!;
                return false;
            }

            if (lifestyleType == LifestyleType.Singleton)
            {
                if (!_singletonInstances.TryGetValue(type, out var singletons))
                {
                    singletons = new HashSet<object>();
                    _singletonInstances[type] = singletons;
                }

                _ = singletons.Add(noParamsInstance);
            }

            val = noParamsInstance;
            return true;
        }

        var parameters = new object?[c.Parameters.Length];
        var i = 0;
        var found = true;

        foreach (var p in c.Parameters)
        {
            var foundParameter = false;

            foreach (var parameterValue in parameterValues)
            {
                if (parameterValue.GetParameterValue(p.Name ?? "", p.Position, p.ParameterType))
                {
                    parameters[i] = parameterValue.Value;
                    foundParameter = true;
                    _ = parameterValues.Remove(parameterValue);
                    break;
                }
            }

            if (foundParameter)
            {
                i++;
                continue;
            }

            if (!_constructors.ContainsKey(type))
            {
                if (p.IsOptional)
                {
                    parameters[i] = p.DefaultValue;
                    i++;
                    continue;
                }

                found = false;
                break;
            }

            parameters[i] = Locate(p.ParameterType);
            i++;
        }

        if (!found)
        {
            val = default!;
            return false;
        }

        var instance = c.ConstructorDelegate.DynamicInvoke(parameters);

        if (instance is null)
        {
            val = default!;
            return false;
        }

        if (lifestyleType == LifestyleType.Singleton)
        {
            if (!_singletonInstances.TryGetValue(type, out var singletons))
            {
                singletons = new HashSet<object>();
                _singletonInstances[type] = singletons;
            }

            _ = singletons.Add(instance);
        }

        val = instance;
        return true;
    }
}
