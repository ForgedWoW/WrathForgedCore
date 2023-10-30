// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using static WrathForged.Models.ConditionalSerializers.SerializerConditionValue;

namespace WrathForged.Models.ConditionalSerializers;

/// <summary>
///     Gets the value of the <paramref name="valIndex"/> property and checks if it equals the <paramref name="expectedValue" />.
///     If they are not null and equal, the property will be serialized.
/// </summary>
/// <param name="valIndex">Index of the value you wish to compare the <paramref name="expectedValue"/> to.</param>
/// <param name="condition">The condition to check the <paramref name="valIndex"/> Property against.</param>
/// <param name="expectedValue">The expected value of the <paramref name="valIndex"/> Property.</param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class SerializerConditionValue(int valIndex, ConditionalSerializationType condition, object expectedValue) : Attribute, IConditionalSerialization
{
    public enum ConditionalSerializationType
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        NotNull,
        Null
    }

    private readonly int _valIndex = valIndex;
    private readonly ConditionalSerializationType _condition = condition;
    private readonly object _expectedValue = expectedValue;

    public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var indexOfCheckVal = allProperties[_valIndex];

        var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

        return checkValRaw == null
            ? _condition == ConditionalSerializationType.Null
            : _condition switch
            {
                ConditionalSerializationType.Equal => checkValRaw.Equals(_expectedValue),
                ConditionalSerializationType.NotEqual => !checkValRaw.Equals(_expectedValue),
                ConditionalSerializationType.GreaterThan => (int)checkValRaw > (int)_expectedValue,
                ConditionalSerializationType.LessThan => (int)checkValRaw < (int)_expectedValue,
                ConditionalSerializationType.GreaterThanOrEqual => (int)checkValRaw >= (int)_expectedValue,
                ConditionalSerializationType.LessThanOrEqual => (int)checkValRaw <= (int)_expectedValue,
                ConditionalSerializationType.NotNull => checkValRaw != null,
                ConditionalSerializationType.Null => checkValRaw == null,
                _ => false
            };
        ;
    }
}
