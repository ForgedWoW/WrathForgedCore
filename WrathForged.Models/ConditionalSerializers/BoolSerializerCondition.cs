// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.ConditionalSerializers;

[AttributeUsage(AttributeTargets.Property)]
public class BoolSerializerCondition(int valIndex, bool expectedValue = true) : Attribute, IConditionalSerialization
{
    private readonly int _valIndex = valIndex;
    private readonly bool _expectedValue = expectedValue;

    public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var indexOfCheckVal = allProperties[_valIndex];

        var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

        return checkValRaw != null && (bool)checkValRaw == _expectedValue;
    }
}
