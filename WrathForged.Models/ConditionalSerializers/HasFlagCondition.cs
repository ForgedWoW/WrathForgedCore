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


            return true;
        }
    }


}
