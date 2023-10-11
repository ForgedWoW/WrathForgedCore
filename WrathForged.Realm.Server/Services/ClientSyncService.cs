// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Models.Networking;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.Services
{
    public class ClientSyncService(IConfiguration configuration, ILogger logger) : IPacketService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly ILogger _logger = logger;

        [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_PING)]
        public void PingRequest(IWoWClientSession session, PingRequest pingRequest)
        {
            var pingResponse = new PingResponse
            {
                Sequence = pingRequest.Sequence
            };

            var timeDiff = session.Network.LastPing - DateTime.UtcNow;

            if (timeDiff.TotalSeconds > 27)
            {
                session.Network.OverspeedPingCount++;

                if (_configuration.GetDefaultValue("ClientTCPServer:MaxOverPingCount", 2) < session.Network.OverspeedPingCount &&
                    !session.Security.CurrentRealmRole.HasPermission(23))
                {
                    _logger.Information("Client {Address} has been disconnected for overspeed pinging.", session.Network.ClientSocket.IPEndPoint);
                    session.Network.ClientSocket.Disconnect();
                    return;
                }
            }
            else
            {
                session.Network.OverspeedPingCount = 0;
            }

            session.Network.Latency = pingRequest.Latency;

            session.Network.Send(pingResponse);
        }

        [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_KEEP_ALIVE)]
        public static void KeepAlive(IWoWClientSession session) => session.Network.LastKeepAlive = DateTime.UtcNow;

        [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_TIME_SYNC_RESP)]
        public static void TimeSync(IWoWClientSession session, TimeSyncResponse timeSyncRequest) => session.ClientTime.TimeSync(timeSyncRequest.TimeSyncCounter, timeSyncRequest.ClientTimestamp);
    }
}
