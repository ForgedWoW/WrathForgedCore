﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.ConditionalSerializers;

/// <summary>
///     Perform the input bitwise operation on the value of the <paramref name="valIndex"/> property and check if it equals the <paramref name="equalityValue" />.
///     If they are not null and equal, the property will be serialized.
/// </summary>
/// <param name="valIndex"></param>
/// <param name="operation"></param>
/// <param name="vsValue"></param>
/// <param name="equalityOperation"></param>
/// <param name="equalityValue"></param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class SerializerConditionBitwise(int valIndex, SerializerConditionBitwise.BitwiseOperation operation, int vsValue, SerializerConditionBitwise.EqualityOperation equalityOperation, int equalityValue) : Attribute, IConditionalSerialization
{
    private readonly int _valIndex = valIndex;
    private readonly BitwiseOperation _operation = operation;
    private readonly int _vsValue = vsValue;
    private readonly EqualityOperation _equalityOperation = equalityOperation;
    private readonly int _equalityValue = equalityValue;

    public enum BitwiseOperation
    {
        And,
        Or,
        Xor,
        Not
    }

    public enum EqualityOperation
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual
    }

    public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
    {
        var indexOfCheckVal = allProperties[_valIndex];

        var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

        if (checkValRaw == null)
            return false;

        var checkVal = Convert.ToInt32(checkValRaw);

        switch (_operation)
        {

            case BitwiseOperation.And:
                switch (_equalityOperation)
                {
                    case EqualityOperation.Equal:
                        return (checkVal & _vsValue) == _equalityValue;

                    case EqualityOperation.NotEqual:
                        return (checkVal & _vsValue) != _equalityValue;

                    case EqualityOperation.GreaterThan:
                        return (checkVal & _vsValue) > _equalityValue;

                    case EqualityOperation.LessThan:
                        return (checkVal & _vsValue) < _equalityValue;

                    case EqualityOperation.GreaterThanOrEqual:
                        return (checkVal & _vsValue) >= _equalityValue;

                    case EqualityOperation.LessThanOrEqual:
                        return (checkVal & _vsValue) <= _equalityValue;
                }

                break;

            case BitwiseOperation.Or:
                switch (_equalityOperation)
                {
                    case EqualityOperation.Equal:
                        return (checkVal | _vsValue) == _equalityValue;

                    case EqualityOperation.NotEqual:
                        return (checkVal | _vsValue) != _equalityValue;

                    case EqualityOperation.GreaterThan:
                        return (checkVal | _vsValue) > _equalityValue;

                    case EqualityOperation.LessThan:
                        return (checkVal | _vsValue) < _equalityValue;

                    case EqualityOperation.GreaterThanOrEqual:
                        return (checkVal | _vsValue) >= _equalityValue;

                    case EqualityOperation.LessThanOrEqual:
                        return (checkVal | _vsValue) <= _equalityValue;
                }

                break;

            case BitwiseOperation.Xor:
                switch (_equalityOperation)
                {
                    case EqualityOperation.Equal:
                        return (checkVal ^ _vsValue) == _equalityValue;

                    case EqualityOperation.NotEqual:
                        return (checkVal ^ _vsValue) != _equalityValue;

                    case EqualityOperation.GreaterThan:
                        return (checkVal ^ _vsValue) > _equalityValue;

                    case EqualityOperation.LessThan:
                        return (checkVal ^ _vsValue) < _equalityValue;

                    case EqualityOperation.GreaterThanOrEqual:
                        return (checkVal ^ _vsValue) >= _equalityValue;

                    case EqualityOperation.LessThanOrEqual:
                        return (checkVal ^ _vsValue) <= _equalityValue;
                }

                break;
        }

        return true;
    }
}
