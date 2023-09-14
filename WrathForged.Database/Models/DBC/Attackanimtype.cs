// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AttackAnimTypes.dbc")]
public partial class Attackanimtype
{
    [DBCPropertyBinding(0, DBCBindingType.UINT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Name { get; set; }

    public virtual ICollection<Attackanimkit> Attackanimkits { get; set; } = new List<Attackanimkit>();
}