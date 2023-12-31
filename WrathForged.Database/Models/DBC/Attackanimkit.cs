﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AttackAnimKits.dbc")]
public partial class Attackanimkit : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Animation { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? Type { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Field04 { get; set; }

    public virtual Animationdatum? AnimationNavigation { get; set; }

    public virtual Attackanimtype? TypeNavigation { get; set; }
}