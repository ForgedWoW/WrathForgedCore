// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ItemSubClass.dbc")]
public partial class Itemsubclass : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? ClassId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int SubClassId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int PrerequisiteProficiency { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int PostrequisiteProficiency { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int DisplayFlags { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int WeaponParrySeq { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int WeaponReadySeq { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int WeaponAttackSeq { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int WeaponSwingSize { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? DisplayNameLangEnUs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? DisplayNameLangEnGb { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? DisplayNameLangKoKr { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? DisplayNameLangFrFr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? DisplayNameLangDeDe { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? DisplayNameLangEnCn { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? DisplayNameLangZhCn { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? DisplayNameLangEnTw { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? DisplayNameLangZhTw { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? DisplayNameLangEsEs { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? DisplayNameLangEsMx { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? DisplayNameLangRuRu { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DisplayNameLangPtPt { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? DisplayNameLangPtBr { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? DisplayNameLangItIt { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? DisplayNameLangUnk { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.UINT32)]
    public uint DisplayNameLangMask { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? VerboseNameLangEnUs { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? VerboseNameLangEnGb { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? VerboseNameLangKoKr { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? VerboseNameLangFrFr { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? VerboseNameLangDeDe { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? VerboseNameLangEnCn { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? VerboseNameLangZhCn { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? VerboseNameLangEnTw { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? VerboseNameLangZhTw { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING)]
    public string? VerboseNameLangEsEs { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? VerboseNameLangEsMx { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.STRING)]
    public string? VerboseNameLangRuRu { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? VerboseNameLangPtPt { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? VerboseNameLangPtBr { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? VerboseNameLangItIt { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? VerboseNameLangUnk { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.UINT32)]
    public uint VerboseNameLangMask { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupItemClassNavigations { get; set; } = new List<Sheathesoundlookup>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupItemSubclassNavigations { get; set; } = new List<Sheathesoundlookup>();
}
