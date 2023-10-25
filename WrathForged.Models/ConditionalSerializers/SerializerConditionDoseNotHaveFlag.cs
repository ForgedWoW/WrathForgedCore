// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.ConditionalSerializers;

/// <summary>
///    Gets the value of the <paramref name="valIndex"/> property and checks if it has the flag of <paramref name="expectedValue" /> for the input <paramref name="enumType"/>.
///    If they are not null and the property has the flag, the property will be serialized                                                                                    .
/// </summary>
/// <param name="valIndex"></param>
/// <param name="enumType"></param>
/// <param name="enumVal"></param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class SerializerConditionDoseNotHaveFlag<T>(int valIndex, T enumVal) : Attribute, IConditionalSerialization where T : Enum
{
    private readonly int _valIndex = valIndex;
    private readonly Type _enumType = typeof(T);
    private readonly T _enumVal = enumVal;

    public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var indexOfCheckVal = allProperties[_valIndex];
        var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

        if (checkValRaw == null || checkValRaw.GetType() != _enumType)
        {
            return false;
        }

        var checkValEnum = (Enum)checkValRaw;

        return !checkValEnum.HasFlag(_enumVal);
    }
}
