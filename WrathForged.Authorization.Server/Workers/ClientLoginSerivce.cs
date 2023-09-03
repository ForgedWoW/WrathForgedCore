using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Authorization.Server.Workers
{
    public class ClientLoginSerivce : IPacketService
    {
        private readonly ForgeCache _forgeCache;
        private readonly IConfiguration _configuration;
        private readonly Dictionary<IPAddress, LoginTracker> _loginTracker = new();

        public ClientLoginSerivce(ForgeCache forgeCache, IConfiguration configuration)
        {
            _forgeCache = forgeCache;
            _configuration = configuration;
        }

        [PacketHandler(Serialization.PacketScope.Auth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public void ChallangeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {

        }

        private void LoginFailed(WoWClientSession session, AuthStatus status)
        {
            if (!_loginTracker.TryGetValue(session.ClientSocket.IPEndPoint.Address, out var tracker))
            {
                tracker = new LoginTracker();
                _loginTracker[session.ClientSocket.IPEndPoint.Address] = tracker;
            }

            tracker.Attempts++;
            tracker.LastAttempt = DateTime.UtcNow;

            if (_configuration.GetDefaultValue("MaxLoginAttempts", 5) <= tracker.Attempts)
            {
                
            }
        }
    }
}
