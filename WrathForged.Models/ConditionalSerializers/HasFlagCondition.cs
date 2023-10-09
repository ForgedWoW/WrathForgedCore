// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.ConditionalSerializers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class HasFlagCondition(int valIndex, Type enumType, int enumVal) : Attribute, IConditionalSerialization
    {
        private readonly int _valIndex = valIndex;
        private readonly Type _enumType = enumType;
        private readonly int _enumVal = enumVal;

        public bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties)
        {
            var indexOfCheckVal = allProperties[_valIndex];

            var checkValRaw = indexOfCheckVal.ReflectedProperty.GetValue(obj);

            if (checkValRaw == null)
                return false;

            if (_enumType.IsEnum && checkValRaw.GetType() == _enumType)
            {
                switch (Type.GetTypeCode(_enumType))
                {
                    case TypeCode.Byte:
                        return (((byte)checkValRaw) & (byte)_enumVal) == (byte)_enumVal;

                    case TypeCode.SByte:
                        return (((sbyte)checkValRaw) & (sbyte)_enumVal) == (sbyte)_enumVal;

                    case TypeCode.Int16:
                        return (((short)checkValRaw) & (short)_enumVal) == (short)_enumVal;

                    case TypeCode.UInt16:
                        return (((ushort)checkValRaw) & (ushort)_enumVal) == (ushort)_enumVal;

                    case TypeCode.Int32:
                        return (((int)checkValRaw) & _enumVal) == _enumVal;

                    case TypeCode.UInt32:
                        return (((uint)checkValRaw) & (uint)_enumVal) == (uint)_enumVal;

                    case TypeCode.Int64:
                        return (((long)checkValRaw) & _enumVal) == _enumVal;

                    case TypeCode.UInt64:
                        return (((ulong)checkValRaw) & (ulong)_enumVal) == (ulong)_enumVal;
                }
            }

            return false;
        }
    }


}
