// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;

namespace WrathForged.Common.External
{
    public class IpStackGeoLocationService(IConfiguration configuration, ClassFactory classFactory)
    {
        private readonly ClassFactory _classFactory = classFactory;
        private readonly string _ipStackApiKey = configuration.GetDefaultValue("IpStack:ApiKey", string.Empty);
        private readonly bool _ipStackEnabled = configuration.GetDefaultValue("IpStack:Enabled", false);
        private readonly bool _useCache = configuration.GetDefaultValue("IpStack:UseDatabaseCache", true);

        public IPStackServiceResponse? GetServiceResponse(string ip)
        {
            if (!_ipStackEnabled)
                return null;

            if (_useCache)
            {
                using var authDatabase = _classFactory.Locate<AuthDatabase>();

                var ipLocation = authDatabase.IpLocations.Find(ip);

                if (ipLocation != null)
                    return JsonSerializer.Deserialize<IPStackServiceResponse>(ipLocation.AddressInfo);

                var ipStackServiceResponse = GetServiceResponseInternal(ip);

                if (ipStackServiceResponse != null)
                {
                    ipLocation = new IpLocation
                    {
                        IpAddress = ip,
                        AddressInfo = JsonSerializer.Serialize(ipStackServiceResponse)
                    };

                    _ = authDatabase.Add(ipLocation);
                    _ = authDatabase.SaveChanges();
                }

                return ipStackServiceResponse;
            }

            return GetServiceResponseInternal(ip);
        }

        private IPStackServiceResponse? GetServiceResponseInternal(string ip)
        {
            var webClient = new HttpClient();
            var response = webClient.GetAsync($"http://api.ipstack.com/{ip}?access_key={_ipStackApiKey}");
            response.Wait();

            if (response.Result.StatusCode != HttpStatusCode.OK)
                return null;

            var result = response.Result.Content.ReadAsStringAsync();
            result.Wait();

            var ipStackServiceResponse = JsonSerializer.Deserialize<IPStackServiceResponse>(result.Result);
            return ipStackServiceResponse;
        }
    }
}
