// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.ObjectTypes;
using WrathForged.Models.Account;
using WrathForged.Realm.Server.ClientServices;

namespace WrathForged.Realm.Server.RealmSession;

public class RealmAccountSessionData
{
    public RealmAccountSessionData()
    {
        for (byte i = 0; i < AccountService.MAX_TUTORIAL_COUNT; i++)
            Tutorials.Items.Add(i, 0u);
    }

    public Dictionary<uint, AccountData> AccountData { get; } = [];

    public FlaggableDictionary<byte, uint> Tutorials { get; } = new FlaggableDictionary<byte, uint>();
}
