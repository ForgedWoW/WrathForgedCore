using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Locktype
{
    public int Id { get; set; }

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

    public string? ResourceNameLangEnUs { get; set; }

    public string? ResourceNameLangEnGb { get; set; }

    public string? ResourceNameLangKoKr { get; set; }

    public string? ResourceNameLangFrFr { get; set; }

    public string? ResourceNameLangDeDe { get; set; }

    public string? ResourceNameLangEnCn { get; set; }

    public string? ResourceNameLangZhCn { get; set; }

    public string? ResourceNameLangEnTw { get; set; }

    public string? ResourceNameLangZhTw { get; set; }

    public string? ResourceNameLangEsEs { get; set; }

    public string? ResourceNameLangEsMx { get; set; }

    public string? ResourceNameLangRuRu { get; set; }

    public string? ResourceNameLangPtPt { get; set; }

    public string? ResourceNameLangPtBr { get; set; }

    public string? ResourceNameLangItIt { get; set; }

    public string? ResourceNameLangUnk { get; set; }

    public uint ResourceNameLangMask { get; set; }

    public string? VerbLangEnUs { get; set; }

    public string? VerbLangEnGb { get; set; }

    public string? VerbLangKoKr { get; set; }

    public string? VerbLangFrFr { get; set; }

    public string? VerbLangDeDe { get; set; }

    public string? VerbLangEnCn { get; set; }

    public string? VerbLangZhCn { get; set; }

    public string? VerbLangEnTw { get; set; }

    public string? VerbLangZhTw { get; set; }

    public string? VerbLangEsEs { get; set; }

    public string? VerbLangEsMx { get; set; }

    public string? VerbLangRuRu { get; set; }

    public string? VerbLangPtPt { get; set; }

    public string? VerbLangPtBr { get; set; }

    public string? VerbLangItIt { get; set; }

    public string? VerbLangUnk { get; set; }

    public uint VerbLangMask { get; set; }

    public string? CursorName { get; set; }

    public virtual ICollection<Lock> LockType1Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType2Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType3Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType4Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType5Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType6Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType7Navigations { get; set; } = new List<Lock>();

    public virtual ICollection<Lock> LockType8Navigations { get; set; } = new List<Lock>();
}
