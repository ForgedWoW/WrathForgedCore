// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Enum;

public enum BillingPlanFlags : byte
{
    None = 0x00,
    Unused = 0x01,
    Recurring_Bill = 0x02,
    Free_Trial = 0x04,
    IGR = 0x08,
    Usage = 0x10,
    Time_Mixture = 0x20,
    Restricted = 0x40,
    Enable_CAIS = 0x80
}
