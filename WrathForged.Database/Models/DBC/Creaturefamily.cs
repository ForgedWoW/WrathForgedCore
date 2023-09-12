using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Creaturefamily
{
    public int Id { get; set; }

    public float MinScale { get; set; }

    public int MinScaleLevel { get; set; }

    public float MaxScale { get; set; }

    public int MaxScaleLevel { get; set; }

    public int? SkillLine1 { get; set; }

    public int? SkillLine2 { get; set; }

    public int PetFoodMask { get; set; }

    public int PetTalentType { get; set; }

    public int CategoryEnumId { get; set; }

    public string? NameLangEnUs { get; set; }

    public string? NameLangEnGb { get; set; }

    public string? NameLangKoKr { get; set; }

    public string? NameLangFrFr { get; set; }

    public string? NameLangDeDe { get; set; }

    public string? NameLangEnCn { get; set; }

    public string? NameLangZhCn { get; set; }

    public string? NameLangEnTw { get; set; }

    public string? NameLangZhTw { get; set; }

    public string? NameLangEsEs { get; set; }

    public string? NameLangEsMx { get; set; }

    public string? NameLangRuRu { get; set; }

    public string? NameLangPtPt { get; set; }

    public string? NameLangPtBr { get; set; }

    public string? NameLangItIt { get; set; }

    public string? NameLangUnk { get; set; }

    public uint NameLangMask { get; set; }

    public string? IconFile { get; set; }

    public virtual Skillline? SkillLine1Navigation { get; set; }

    public virtual Skillline? SkillLine2Navigation { get; set; }
}
