// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using WrathForged.Serialization.Models;

namespace WrathForged.Models.ConditionalSerializers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BitwiseCondition : Attribute, IConditionalSerialization
    {
        private readonly int _valIndex;
        private readonly BitwiseOperation _operation;
        private readonly int _vsValue;
        private readonly EqualityOperation _equalityOperation;
        private readonly int _equalityValue;

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

        public BitwiseCondition(int valIndex, BitwiseOperation operation, int vsValue, EqualityOperation equalityOperation, int equalityValue)
        {
            _valIndex = valIndex;
            _operation = operation;
            _vsValue = vsValue;
            _equalityOperation = equalityOperation;
            _equalityValue = equalityValue;
        }

        public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
        {
            var indexofCheckVal = allProperties[_valIndex];

            var checkValRaw = indexofCheckVal.ReflectedProperty.GetValue(obj);

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
