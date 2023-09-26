// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("LockType.dbc")]
    public partial class Locktype : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
        public string? NameLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint NameLangMask { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEnUs { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEnGb { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangKoKr { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangFrFr { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangDeDe { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEnCn { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangZhCn { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEnTw { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangZhTw { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEsEs { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangEsMx { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangRuRu { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangPtPt { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangPtBr { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangItIt { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.STRING, Nullable = true)]
        public string? ResourceNameLangUnk { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.UINT32)]
        public uint ResourceNameLangMask { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEnUs { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEnGb { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangKoKr { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangFrFr { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangDeDe { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEnCn { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangZhCn { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEnTw { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangZhTw { get; set; }

        [DBCPropertyBinding(44, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEsEs { get; set; }

        [DBCPropertyBinding(45, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangEsMx { get; set; }

        [DBCPropertyBinding(46, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangRuRu { get; set; }

        [DBCPropertyBinding(47, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangPtPt { get; set; }

        [DBCPropertyBinding(48, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangPtBr { get; set; }

        [DBCPropertyBinding(49, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangItIt { get; set; }

        [DBCPropertyBinding(50, DBCBindingType.STRING, Nullable = true)]
        public string? VerbLangUnk { get; set; }

        [DBCPropertyBinding(51, DBCBindingType.UINT32)]
        public uint VerbLangMask { get; set; }

        [DBCPropertyBinding(52, DBCBindingType.STRING, Nullable = true)]
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
}
