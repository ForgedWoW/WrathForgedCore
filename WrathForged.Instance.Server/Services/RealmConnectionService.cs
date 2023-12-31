﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Core.Packets;

namespace WrathForged.Instance.Server.Services;

public class RealmConnectionService : IPacketService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;
    private readonly AuthDatabase _authDatabase;

    public RealmConnectionService(ClassFactory classFactory, IConfiguration configuration, ILogger logger, AuthDatabase authDatabase)
    {
        InstanceServer = new InstanceServerRegistration
        {
            Id = configuration.GetDefaultValue("InstanceServerId", 1u),
            Address = System.Net.IPAddress.Parse(configuration.GetDefaultValue("ForgedServerComm:LocalAddress", "*")),
            Port = (ushort)configuration.GetDefaultValue("ForgedServerComm:Port", 8783)
        };
        _ = authDatabase.InstanceLists.DeleteByKey(InstanceServer.Id);

        authDatabase.InstanceLists.SingleInsert(new InstanceList()
        {
            Id = InstanceServer.Id,
            IpAddress = InstanceServer.Address.ToString(),
            Port = InstanceServer.Port,
            Created = DateTime.UtcNow,
            Realm = configuration.GetDefaultValue("RealmId", 1u),
            PlayerCount = 0
        });

        var maps = authDatabase.InstanceMaps.Where(x => x.InstanceId == InstanceServer.Id).ToList();
        Dictionary<uint, InstanceMapInfo> mapInfoDict = [];

        foreach (var map in maps)
        {
            if (mapInfoDict.TryGetValue(map.MapId, out var mapInfo))
            {
                mapInfo.Difficulties.Add(map.Difficulty);
            }
            else
            {
                mapInfoDict[map.MapId] = new InstanceMapInfo
                {
                    MapId = map.MapId,
                    Difficulties = [map.Difficulty]
                };
            }
        }

        InstanceServer.MapIDs = [.. mapInfoDict.Values];

        ClientConnection = classFactory.Container.LocateWithPositionalParams<ForgedTCPClient>(
                            configuration.GetDefaultValue("ForgedServerComm:LocalAddress", "*"),
                            configuration.GetDefaultValue("ForgedServerComm:Realm:Address", "127.0.0.1"),
                            configuration.GetDefaultValue("ForgedServerComm:Realm:Port", 8780));

        _configuration = configuration;
        _logger = logger;
        _authDatabase = authDatabase;
        ClientConnection.Connect();
        ClientConnection.Send(InstanceServer);
    }

    public ForgedTCPClient ClientConnection { get; set; }
    public InstanceServerRegistration InstanceServer { get; set; }
}
