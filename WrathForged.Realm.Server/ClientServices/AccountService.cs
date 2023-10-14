﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
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
    private const uint GLOBAL_CACHE_MASK = 0x15;
    private const uint PER_CHARACTER_CACHE_MASK = 0xEA;

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
}
