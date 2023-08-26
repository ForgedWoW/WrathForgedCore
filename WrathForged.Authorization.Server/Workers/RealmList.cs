using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Workers
{
    public class RealmList
    {
        private readonly AuthDatabase _authDatabase;
        private Dictionary<uint, Realmlist> _realms = new Dictionary<uint, Realmlist>();
        Timer _timer;

        public RealmList(AuthDatabase authDatabase, IConfiguration configuration)
        {
            _authDatabase = authDatabase;
            _timer = new Timer(Update, null, 0, TimeSpan.FromSeconds(configuration.GetDefaultValue("RealmStatusUpdate", 20)).Milliseconds);
        }

        private void Update(object? state)
        {
            foreach (var realm in _authDatabase.Realmlists)
                _realms[realm.Id] = realm;

        }

        public void Close()
        {
            _timer.Dispose();
        }

        public bool TryGetRealm(uint realmId, out Realmlist realmlist)
        {
            return _realms.TryGetValue(realmId, out realmlist);
        }
    }
}
