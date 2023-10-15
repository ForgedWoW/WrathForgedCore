// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Characters;
using WrathForged.Models.Account;
using WrathForged.Models.Account.Packets;
using WrathForged.Models.Realm.Enum;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ClientServices;

public class AccountService(ClassFactory classFactory, ILogger logger) : IPacketService
{
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ILogger _logger = logger;
    public const uint GLOBAL_CACHE_MASK = 0x15;
    public const uint PER_CHARACTER_CACHE_MASK = 0xEA;
    public const byte MAX_TUTORIAL_COUNT = 8;

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_REQUEST_ACCOUNT_DATA)]
    public void ClientAccountDataRequest(RealmClientSession session, AccountDataRequest packet)
    {
        _logger.Debug("Received account data request from {AccountId}:{AccountName}", session.Security.Account.Id, session.Security.Account.Username);
        SendAccountData(session, packet.AccountDataType);
    }

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES)]
    public void ReadyForAccountData(RealmClientSession session)
    {
        _logger.Debug("Received account data times request from {AccountId}:{AccountName}", session.Security.Account.Id, session.Security.Account.Username);
        SendAccountDataTimes(session, GLOBAL_CACHE_MASK);
    }

    public void SendAccountDataTimes(RealmClientSession session, uint mask)
    {
        _logger.Verbose("Sending account data times to {AccountId}:{AccountName}", session.Security.Account.Id, session.Security.Account.Username);
        session.Network.Send(new AccountDataTimesResponse()
        {
            Time = DateTime.Now,
            Mask = mask,
            Times = session.AccountSessionData.AccountData.Where(x => (mask & (1 << (int)x.Key)) != 0).Select(x => x.Value.Time).ToList()
        }, RealmServerOpCode.SMSG_ACCOUNT_DATA_TIMES);
    }

    public void SendAccountData(RealmClientSession session, uint type)
    {
        if (session.AccountSessionData.AccountData.TryGetValue(type, out var accountData))
        {
            session.Network.Send(new AccountDataResponse()
            {
                AccountDataType = type,
                Time = accountData.Time,
                Data = accountData.Data,
                PlayerId = session.Player.EntityId,
                Size = (uint)accountData.Data.Length
            }, RealmServerOpCode.SMSG_UPDATE_ACCOUNT_DATA);
        }
        else
            _logger.Warning("Account data request for {AccountId}:{AccountName} failed. No data found for type {AccountDataType}", session.Security.Account.Id, session.Security.Account.Username, type);
    }

    public void LoadAccountData(RealmClientSession session)
    {
        _logger.Verbose("Loading account data for {AccountId}:{AccountName}", session.Security.Account.Id, session.Security.Account.Username);
        session.AccountSessionData.AccountData.Clear();
        using var characterDatabase = _classFactory.Locate<CharacterDatabase>();

        foreach (var data in characterDatabase.AccountData.Where(x => x.AccountId == session.Security.Account.Id))
            session.AccountSessionData.AccountData[data.Type] = new AccountData()
            {
                Time = data.Time,
                Data = data.Data
            };

        _logger.Verbose("Loaded {Count} account data entries for {AccountId}:{AccountName}", session.AccountSessionData.AccountData.Count, session.Security.Account.Id, session.Security.Account.Username);
    }

    public void SendTutorialData(RealmClientSession session)
    {
        _logger.Verbose("Sending tutorial data to {AccountId}:{AccountName}", session.Security.Account.Id, session.Security.Account.Username);
        session.Network.Send(new TutorialFlagsResponse()
        {
            Tutorials = session.AccountSessionData.Tutorials.Items.Select(x => x.Value).ToArray()
        }, RealmServerOpCode.SMSG_TUTORIAL_FLAGS);
    }

    public void LoadTutorialData(RealmClientSession session)
    {
        using var characterDatabase = _classFactory.Locate<CharacterDatabase>();

        var tutorialData = characterDatabase.AccountTutorials.FirstOrDefault(x => x.AccountId == session.Security.Account.Id);

        if (tutorialData != null)
        {
            var tutorials = tutorialData.TutorialFlags;

            for (byte i = 0; i < MAX_TUTORIAL_COUNT; i++)
                session.AccountSessionData.Tutorials.Items[i] = tutorials[i];
        }
    }

    public void SaveTutorialData(RealmClientSession session)
    {
        using var characterDatabase = _classFactory.Locate<CharacterDatabase>();

        var tutorialData = characterDatabase.AccountTutorials.FirstOrDefault(x => x.AccountId == session.Security.Account.Id);

        if (tutorialData == null)
        {
            tutorialData = new AccountTutorial()
            {
                AccountId = session.Security.Account.Id
            };

            _ = characterDatabase.AccountTutorials.Add(tutorialData);
        }

        tutorialData.Tut0 = session.AccountSessionData.Tutorials.Items[0];
        tutorialData.Tut1 = session.AccountSessionData.Tutorials.Items[1];
        tutorialData.Tut2 = session.AccountSessionData.Tutorials.Items[2];
        tutorialData.Tut3 = session.AccountSessionData.Tutorials.Items[3];
        tutorialData.Tut4 = session.AccountSessionData.Tutorials.Items[4];
        tutorialData.Tut5 = session.AccountSessionData.Tutorials.Items[5];
        tutorialData.Tut6 = session.AccountSessionData.Tutorials.Items[6];
        tutorialData.Tut7 = session.AccountSessionData.Tutorials.Items[7];

        _ = characterDatabase.SaveChanges();
    }
}
