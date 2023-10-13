// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SummonProperties.dbc")]
public partial class Summonproperty : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Control { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Faction { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Title { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Slot { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Flags { get; set; }
}
