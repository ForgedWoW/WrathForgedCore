// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("LiquidType.dbc")]
    public partial class Liquidtype : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? Name { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Type { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int SoundId { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int SpellId { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float MaxDarkenDepth { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float FogDarkenintensity { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
        public float AmbDarkenintensity { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
        public float DirDarkenintensity { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int LightId { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
        public float ParticleScale { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int ParticleMovement { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int ParticleTexSlots { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int MaterialId { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? Texture1 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? Texture2 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING)]
        public string? Texture3 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING)]
        public string? Texture4 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING)]
        public string? Texture5 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING)]
        public string? Texture6 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int Color1 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
        public int Color2 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
        public float Float1 { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
        public float Float2 { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
        public float Float3 { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
        public float Float4 { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
        public float Float5 { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
        public float Float6 { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
        public float Float7 { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
        public float Float8 { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
        public float Float9 { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.FLOAT)]
        public float Float10 { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
        public float Float11 { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.FLOAT)]
        public float Float12 { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.FLOAT)]
        public float Float13 { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.FLOAT)]
        public float Float14 { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.FLOAT)]
        public float Float15 { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.FLOAT)]
        public float Float16 { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.FLOAT)]
        public float Float17 { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.FLOAT)]
        public float Float18 { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.INT32)]
        public int Int1 { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.INT32)]
        public int Int2 { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.INT32)]
        public int Int3 { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.INT32)]
        public int Int4 { get; set; }

        public virtual ICollection<Areatable> AreatableLiquidTypeId1Navigations { get; set; } = new List<Areatable>();

        public virtual ICollection<Areatable> AreatableLiquidTypeId2Navigations { get; set; } = new List<Areatable>();

        public virtual ICollection<Areatable> AreatableLiquidTypeId3Navigations { get; set; } = new List<Areatable>();

        public virtual ICollection<Areatable> AreatableLiquidTypeId4Navigations { get; set; } = new List<Areatable>();
    }
}
