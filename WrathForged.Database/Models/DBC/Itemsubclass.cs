using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemsubclass
{
    public int Id { get; set; }

    public int? ClassId { get; set; }

    public int SubClassId { get; set; }

    public int PrerequisiteProficiency { get; set; }

    public int PostrequisiteProficiency { get; set; }

    public int Flags { get; set; }

    public int DisplayFlags { get; set; }

    public int WeaponParrySeq { get; set; }

    public int WeaponReadySeq { get; set; }

    public int WeaponAttackSeq { get; set; }

    public int WeaponSwingSize { get; set; }

    public string? DisplayNameLangEnUs { get; set; }

    public string? DisplayNameLangEnGb { get; set; }

    public string? DisplayNameLangKoKr { get; set; }

    public string? DisplayNameLangFrFr { get; set; }

    public string? DisplayNameLangDeDe { get; set; }

    public string? DisplayNameLangEnCn { get; set; }

    public string? DisplayNameLangZhCn { get; set; }

    public string? DisplayNameLangEnTw { get; set; }

    public string? DisplayNameLangZhTw { get; set; }

    public string? DisplayNameLangEsEs { get; set; }

    public string? DisplayNameLangEsMx { get; set; }

    public string? DisplayNameLangRuRu { get; set; }

    public string? DisplayNameLangPtPt { get; set; }

    public string? DisplayNameLangPtBr { get; set; }

    public string? DisplayNameLangItIt { get; set; }

    public string? DisplayNameLangUnk { get; set; }

    public uint DisplayNameLangMask { get; set; }

    public string? VerboseNameLangEnUs { get; set; }

    public string? VerboseNameLangEnGb { get; set; }

    public string? VerboseNameLangKoKr { get; set; }

    public string? VerboseNameLangFrFr { get; set; }

    public string? VerboseNameLangDeDe { get; set; }

    public string? VerboseNameLangEnCn { get; set; }

    public string? VerboseNameLangZhCn { get; set; }

    public string? VerboseNameLangEnTw { get; set; }

    public string? VerboseNameLangZhTw { get; set; }

    public string? VerboseNameLangEsEs { get; set; }

    public string? VerboseNameLangEsMx { get; set; }

    public string? VerboseNameLangRuRu { get; set; }

    public string? VerboseNameLangPtPt { get; set; }

    public string? VerboseNameLangPtBr { get; set; }

    public string? VerboseNameLangItIt { get; set; }

    public string? VerboseNameLangUnk { get; set; }

    public uint VerboseNameLangMask { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupItemClassNavigations { get; set; } = new List<Sheathesoundlookup>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupItemSubclassNavigations { get; set; } = new List<Sheathesoundlookup>();
}
