// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("LightSkybox.dbc")]
public partial class Lightskybox : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Flags { get; set; }

    public virtual ICollection<Lightparam> Lightparams { get; set; } = new List<Lightparam>();
}
