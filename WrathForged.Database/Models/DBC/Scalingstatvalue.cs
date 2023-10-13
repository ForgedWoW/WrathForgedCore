// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ScalingStatValues.dbc")]
public partial class Scalingstatvalue : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Charlevel { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int ShoulderBudget { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int TrinketBudget { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int WeaponBudget1H { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int RangedBudget { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int ClothShoulderArmor { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int LeatherShoulderArmor { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int MailShoulderArmor { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int PlateShoulderArmor { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int WeaponDps1h { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int WeaponDps2h { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int SpellcasterDps1h { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int SpellcasterDps2h { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int RangedDps { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int WandDps { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int SpellPower { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int PrimaryBudget { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int TertiaryBudget { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int ClothCloakArmor { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int ClothChestArmor { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int LeatherChestArmor { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int MailChestArmor { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int PlateChestArmor { get; set; }
}
