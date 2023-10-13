// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("LoadingScreens.dbc")]
public partial class Loadingscreen : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? FileName { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int HasWideScreen { get; set; }

    public virtual ICollection<Map> Maps { get; set; } = new List<Map>();
}
