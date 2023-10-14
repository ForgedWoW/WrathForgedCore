// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Account;

namespace WrathForged.Realm.Server.RealmSession;

public class RealmAccountSessionData
{

    public Dictionary<uint, AccountData> AccountData { get; } = [];

    public Dictionary<uint, uint> Tutorials { get; } = [];
}
