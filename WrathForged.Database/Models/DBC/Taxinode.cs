// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("TaxiNodes.dbc")]
public partial class Taxinode : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? ContinentId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float X { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Y { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Z { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int MountCreatureId1 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int MountCreatureId2 { get; set; }

    public virtual Map? Continent { get; set; }
    public virtual ICollection<Taxipath> TaxipathFromTaxiNodeNavigations { get; set; } = new List<Taxipath>();
    public virtual ICollection<Taxipath> TaxipathToTaxiNodeNavigations { get; set; } = new List<Taxipath>();
}
