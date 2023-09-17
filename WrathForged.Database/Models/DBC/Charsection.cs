// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharSections.dbc")]
public partial class Charsection
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT, Nullable = true)]
    public int? RaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT)]
    public int SexId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT)]
    public int BaseSection { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? TextureName1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? TextureName2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? TextureName3 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT)]
    public int Flags { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT)]
    public int VariationIndex { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT)]
    public int ColorIndex { get; set; }

    public virtual Chrrace? Race { get; set; }
}