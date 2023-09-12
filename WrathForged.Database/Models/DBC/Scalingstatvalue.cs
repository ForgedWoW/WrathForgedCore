using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Scalingstatvalue
{
    public int Id { get; set; }

    public int Charlevel { get; set; }

    public int ShoulderBudget { get; set; }

    public int TrinketBudget { get; set; }

    public int WeaponBudget1H { get; set; }

    public int RangedBudget { get; set; }

    public int ClothShoulderArmor { get; set; }

    public int LeatherShoulderArmor { get; set; }

    public int MailShoulderArmor { get; set; }

    public int PlateShoulderArmor { get; set; }

    public int WeaponDps1h { get; set; }

    public int WeaponDps2h { get; set; }

    public int SpellcasterDps1h { get; set; }

    public int SpellcasterDps2h { get; set; }

    public int RangedDps { get; set; }

    public int WandDps { get; set; }

    public int SpellPower { get; set; }

    public int PrimaryBudget { get; set; }

    public int TertiaryBudget { get; set; }

    public int ClothCloakArmor { get; set; }

    public int ClothChestArmor { get; set; }

    public int LeatherChestArmor { get; set; }

    public int MailChestArmor { get; set; }

    public int PlateChestArmor { get; set; }
}
