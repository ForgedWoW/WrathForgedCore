// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Runtime.InteropServices;
using WrathForged.Common.Networking;
using WrathForged.Common.Util;
using WrathForged.Models.Entities.Enum;

#pragma warning disable CS8767

namespace WrathForged.Common
{
    public enum HighId : ushort
    {
        Unit = 0xF130,
        UnitPet = 0xF140,

        //Unit = 0xF550,
        Unit_F4 = 0xF430,

        Unit_F7 = 0xF730,

        Unit_F1_Vehicle = 0xF150,
        Unit_F4_Vehicle = 0xF450,
        Unit_F7_Vehicle = 0xF750,

        Pet = 0xF140,

        MoTransport = 0x1FC0,
        Transport = 0xF120,
        Vehicle = 0xF550,

        GameObject = 0xF110,
        GameObject_F4 = 0xF410,
        GameObject_F7 = 0xF710,
        GameObject4 = 0xF009,

        /// <summary>
        /// Or Container
        /// </summary>
        Item = 0x4000,

        Player = 0x0000,
        DynamicObject = 0xF100,
        DynamicObject_2 = 0xF500,

        Corpse = 0xF101, // TODO: actually should be 0xF000, but can't due to duplicate entries in some dictionaries
        Corpse2 = 0xF400,
        Corpse3 = 0xF700,
    }

    public enum HighGuid8 : byte
    {
        Flag_MapObjectTransport = 0x1F,
        Item = 0x40,
        Flag_F1 = 0xF1,
        Flag_F4 = 0xF4,
        Flag_F5 = 0xF5,
        Flag_F7 = 0xF7,
    }

    public enum HighGuidType : byte
    {
        /// <summary>
        /// Also Player, Corpse, or DynamicObject
        /// </summary>
        NoEntry = 0x00,

        GameObject = 0x10,
        Transport = 0x20,
        Unit = 0x30,
        Pet = 0x40,
        Vehicle = 0x50,

        MapObjectTransport = 0xC0,
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct EntityId : IComparable, IEquatable<EntityId>, IConvertible
    {
        private const uint LOW_MASK = 0xFFFFFF;
        private const uint ENTRY_MASK = 0xFFFFFF;
        private const uint HIGH_MASK = 0xFFFF0000;
        private const uint HIGH_7_MASK = 0x00FF0000;
        private const uint HIGH_8_MASK = 0xFF000000;

        public static readonly EntityId Zero = new(0);

        public static byte[]? ZeroRaw => _zeroRaw.Clone() as byte[];

        private static readonly byte[] _zeroRaw = new byte[8];

        [FieldOffset(0)]
        public ulong Full;

        [FieldOffset(0)]
        private uint _low;

        [FieldOffset(3)]
        private readonly uint _entry;

        [FieldOffset(4)]
        private uint _high;

        public EntityId(byte[] fullRaw)
        {
            _low = 0;
            _high = 0;
            _entry = 0;
            Full = BitConverter.ToUInt64(fullRaw, 0);
        }

        public EntityId(ulong full)
        {
            _low = 0;
            _high = 0;
            _entry = 0;
            Full = full;
        }

        public EntityId(uint low, uint high)
        {
            Full = 0;
            _entry = 0;
            _low = low;
            _high = high;
        }

        public EntityId(uint low, HighId high)
        {
            Full = 0;
            _high = 0;
            _entry = 0;
            _low = low;
            High = high;
        }

        public EntityId(uint low, uint entry, HighId high)
        {
            Full = 0;
            _high = 0;
            _low = low;
            _entry = entry;
            High = high;
        }

        public uint Low
        {
            get => _low & LOW_MASK;

            private set
            {
                _low &= ~LOW_MASK;
                _low |= value & LOW_MASK;
            }
        }

        public uint Entry => _entry & ENTRY_MASK;

        public HighId High
        {
            get => (HighId)(_high >> 16);
            private set
            {
                _high &= ~HIGH_MASK;
                _high |= ((uint)value) << 16;
            }
        }

        public bool HasEntry =>
                //return ((m_high >> 16) & 0xFF) != 0;
                SeventhByte != HighGuidType.NoEntry;

        public uint LowRaw => _low;

        public uint HighRaw => _high;

        public bool IsItem => EighthByte == HighGuid8.Item;

        public HighGuidType SeventhByte => (HighGuidType)((_high & HIGH_7_MASK) >> 16);

        public HighGuid8 EighthByte => (HighGuid8)((_high & HIGH_8_MASK) >> 24);

        public ObjectTypeId ObjectType
        {
            get
            {
                switch (SeventhByte)
                {
                    case HighGuidType.NoEntry:
                    {
                        return IsItem ? ObjectTypeId.Item : ObjectTypeId.Player;
                    }
                    case HighGuidType.GameObject:
                        return ObjectTypeId.GameObject;

                    case HighGuidType.MapObjectTransport:
                        return ObjectTypeId.GameObject;

                    case HighGuidType.Pet:
                        return ObjectTypeId.Unit;

                    case HighGuidType.Transport:
                        return ObjectTypeId.GameObject;

                    case HighGuidType.Unit:
                        return ObjectTypeId.Unit;

                    case HighGuidType.Vehicle:
                        return ObjectTypeId.Unit;
                }

                return ObjectTypeId.Object;
            }
        }

        public int WritePacked(PrimitiveWriter binWriter) => binWriter.WritePackedUInt64(Full);

        public override bool Equals(object obj) => obj != null && obj is EntityId && Equals((EntityId)obj);

        public int CompareTo(object obj) => obj is EntityId ? Full.CompareTo(((EntityId)obj).Full) : obj is ulong ? Full.CompareTo((ulong)obj) : -1;

        public bool Equals(EntityId other) => other.Full == Full;

        public static bool operator ==(EntityId left, EntityId right) => left.Equals(right);

        public static bool operator !=(EntityId left, EntityId right) => !left.Equals(right);

        public override string ToString()
        {
            if (Full == 0)
            {
                // empty
                return "<null>";
            }

            return string.Format("High: 0x{0:X4} ({1}) - Low: {2}", _high, ObjectType, _low);
        }

        public static EntityId ReadPacked(PrimitiveReader packet)
        {
            var mask = FlagsUtil.GetSetIndices(packet.ReadByte());

            var rawId = new byte[8];
            foreach (var i in mask)
            {
                rawId[i] = packet.ReadByte();
            }

            return new EntityId(rawId);
        }

        public static implicit operator ulong(EntityId id) => id.Full;

        public static EntityId GetCorpseId(uint id) => new(id, 0, HighId.Corpse);

        public static EntityId GetUnitId(uint id, uint entry) => new(id, entry, HighId.Unit);

        public static EntityId GetPetId(uint id, uint petNumber) => new(id, petNumber, HighId.UnitPet);

        public static EntityId GetPlayerId(uint low) => new(low, 0, HighId.Player);

        public static EntityId GetItemId(uint low) => new(low, HighId.Item);

        public static EntityId GetDynamicObjectId(uint low) => new(low, 0, HighId.DynamicObject);

        public static EntityId GetMOTransportId(uint low, uint entry) => new(low, entry, HighId.MoTransport);

        public override int GetHashCode() => Full.GetHashCode();

        public TypeCode GetTypeCode() => TypeCode.Object;

        public bool ToBoolean(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Boolean");

        public byte ToByte(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Byte");

        public char ToChar(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Char");

        public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to DateTime");

        public decimal ToDecimal(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Decimal");

        public double ToDouble(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Double");

        public short ToInt16(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Int16");

        public int ToInt32(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Int32");

        public long ToInt64(IFormatProvider provider) => (long)Full;

        public sbyte ToSByte(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to SByte");

        public float ToSingle(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to Single");

        public string ToString(IFormatProvider provider) => ToString();

        public object ToType(Type conversionType, IFormatProvider provider) => Convert.ChangeType(Full, conversionType);

        public ushort ToUInt16(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to UInt16");

        public uint ToUInt32(IFormatProvider provider) => throw new InvalidCastException("Cannot cast EntityId to UInt32");

        public ulong ToUInt64(IFormatProvider provider) => Full;
    }
}