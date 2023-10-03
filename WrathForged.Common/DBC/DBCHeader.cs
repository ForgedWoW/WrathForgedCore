// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Runtime.InteropServices;

namespace WrathForged.Common.DBC;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DBCHeader
{
    public uint Magic;
    public uint RecordCount;
    public uint FieldCount;
    public uint RecordSize;
    public uint StringBlockSize;
}