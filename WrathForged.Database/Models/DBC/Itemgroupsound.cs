// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ItemGroupSounds.dbc")]
public partial class Itemgroupsound : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? Sound1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int? Sound2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int? Sound3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int? Sound4 { get; set; }

    public virtual ICollection<Itemdisplayinfo> Itemdisplayinfos { get; set; } = new List<Itemdisplayinfo>();
    public virtual Soundentry? Sound1Navigation { get; set; }
    public virtual Soundentry? Sound2Navigation { get; set; }
    public virtual Soundentry? Sound3Navigation { get; set; }
    public virtual Soundentry? Sound4Navigation { get; set; }
}
