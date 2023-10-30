// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using static WrathForged.Models.CalculatedCollectionSizeAttribute;

namespace WrathForged.Models;

[AttributeUsage(AttributeTargets.Property)]
public class CalculatedCollectionSizeAttribute(int propertyNumber, CalculationType calculationType, CalculateBy calculateBy, int valueOrPropertyNumber, bool addOne = false) : Attribute
{
    private readonly int _propertyNumber = propertyNumber;
    private readonly CalculationType _calculationType = calculationType;
    private readonly CalculateBy _calculateBy = calculateBy;
    private readonly int _valueOrPropertyNumber = valueOrPropertyNumber;
    private readonly bool _addOne = addOne;

    public enum CalculationType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public enum CalculateBy
    {
        Property,
        Value
    }

    public int GetCalculatedValue(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var propertyVal = allProperties[_propertyNumber].ReflectedProperty.GetValue(obj) as int?;

        var calculatedValue = _calculateBy switch
        {
            CalculateBy.Property => allProperties[_valueOrPropertyNumber].ReflectedProperty.GetValue(obj) as int?,
            CalculateBy.Value => _valueOrPropertyNumber,
            _ => throw new NotImplementedException()
        };

        if (_addOne)
        {
            calculatedValue++;
            propertyVal++;
        }

        return propertyVal == null || calculatedValue == null
            ? throw new InvalidOperationException("Cannot calculate collection size when one of the values is null.")
            : (int)(_calculationType switch
            {
                CalculationType.Add => calculatedValue + propertyVal,
                CalculationType.Subtract => calculatedValue - propertyVal,
                CalculationType.Multiply => calculatedValue * propertyVal,
                CalculationType.Divide => calculatedValue / propertyVal,
                _ => throw new NotImplementedException()
            });
    }
}
