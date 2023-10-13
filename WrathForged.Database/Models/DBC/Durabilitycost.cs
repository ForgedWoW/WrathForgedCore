// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("DurabilityCosts.dbc")]
public partial class Durabilitycost : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int WeaponSubClassCost1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int WeaponSubClassCost2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int WeaponSubClassCost3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int WeaponSubClassCost4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int WeaponSubClassCost5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int WeaponSubClassCost6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int WeaponSubClassCost7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int WeaponSubClassCost8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int WeaponSubClassCost9 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int WeaponSubClassCost10 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int WeaponSubClassCost11 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int WeaponSubClassCost12 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int WeaponSubClassCost13 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int WeaponSubClassCost14 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int WeaponSubClassCost15 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int WeaponSubClassCost16 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int WeaponSubClassCost17 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int WeaponSubClassCost18 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int WeaponSubClassCost19 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int WeaponSubClassCost20 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int WeaponSubClassCost21 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int ArmorSubClassCost1 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int ArmorSubClassCost2 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int ArmorSubClassCost3 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int ArmorSubClassCost4 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int ArmorSubClassCost5 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int ArmorSubClassCost6 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int ArmorSubClassCost7 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int ArmorSubClassCost8 { get; set; }
}
