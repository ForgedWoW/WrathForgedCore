// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("UnitBloodLevels.dbc")]
public partial class Unitbloodlevel : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Violencelevel1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Violencelevel2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Violencelevel3 { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
    public virtual ICollection<Creaturemodeldatum> Creaturemodeldata { get; set; } = new List<Creaturemodeldatum>();
}
