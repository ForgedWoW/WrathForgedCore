// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.ConditionalSerializers;

/// <summary>
///     Gets the value of the <paramref name="valIndex"/> property and checks if it equals the <paramref name="expectedValue" />.
///     If they are not null and equal, the property will be serialized.
/// </summary>
/// <param name="valIndex">Index of the value you wish to compare the <paramref name="expectedValue"/> to.</param>
/// <param name="expectedValue">The expected value of the <paramref name="valIndex"/> Property.</param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ValueDoesNotEqualSerializerCondition(int valIndex, object expectedValue) : Attribute, IConditionalSerialization
{
    private readonly int _valIndex = valIndex;
    private readonly object _expectedValue = expectedValue;

    public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var indexOfCheckVal = allProperties[_valIndex];

        var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

        return checkValRaw != null && checkValRaw == _expectedValue;
    }
}
