// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.DBC
{
    public struct DBCHeader
    {
        public uint Magic;
        public uint RecordCount;
        public uint FieldCount;
        public uint RecordSize;
        public int StringBlockSize;
    }
}