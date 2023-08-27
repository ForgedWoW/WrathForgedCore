// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Serialization
{
    public class SerializablePropertyAttribute : Attribute
    {
        public SerializablePropertyAttribute(uint index, TypeCode overrideType = TypeCode.Empty)
        {
            Index = index;
            OverrideType = overrideType;
        }

        public uint Index { get; }
        public TypeCode OverrideType { get; }
    }
}