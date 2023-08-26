using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Workers
{
    public class RealmListCache
    {
        private readonly AuthDatabase _authDatabase;
        private readonly ILogger _logger;
        private readonly Dictionary<uint, Realmlist> _realms = new Dictionary<uint, Realmlist>();
        private readonly Dictionary<uint, BuildInfo> _builds = new Dictionary<uint, BuildInfo>();
        private Timer _timer;

        public RealmListCache(AuthDatabase authDatabase, IConfiguration configuration, ILogger logger)
        {
            _authDatabase = authDatabase;
            _logger = logger;
            _timer = new Timer(Update, null, 0, TimeSpan.FromSeconds(configuration.GetDefaultValue("RealmStatusUpdate", 20)).Milliseconds);
        }

        private void Update(object? state)
        {
            _logger.Verbose("Updating RealmListCache");
            foreach (var realm in _authDatabase.Realmlists)
                _realms[realm.Id] = realm;

            foreach (var build in _authDatabase.BuildInfos)
                _builds[build.Build] = build;
        }

        public void Close()
        {
            _timer.Dispose(); 
        }

        public bool TryGetRealm(uint realmId, out Realmlist realmlist)
        {
            return _realms.TryGetValue(realmId, out realmlist);
        }

        public bool TryGetBuild(uint buildId, out BuildInfo buildInfo)
        {
            return _builds.TryGetValue(buildId, out buildInfo);
        }
    }
}
