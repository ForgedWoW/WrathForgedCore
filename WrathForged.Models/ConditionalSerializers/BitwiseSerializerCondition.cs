// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.ConditionalSerializers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BitwiseSerializerCondition(int valIndex, BitwiseSerializerCondition.BitwiseOperation operation, int vsValue, BitwiseSerializerCondition.EqualityOperation equalityOperation, int equalityValue) : Attribute, IConditionalSerialization
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
}
