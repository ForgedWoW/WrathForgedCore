﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Cfg_Configs.dbc")]
public partial class CfgConfigs : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int RealmType { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int PlayerKillingAllowed { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Roleplaying { get; set; }
}