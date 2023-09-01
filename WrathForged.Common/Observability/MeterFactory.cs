// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics.Metrics;

namespace WrathForged.Common.Observability
{
    public class MeterFactory
    {
        private readonly Dictionary<string, Meter> _meters = new();

        public Meter GetOrCreateMeter(string meterName, string version = "1.0.0")
        {
            if (_meters.TryGetValue(meterName, out var meter))
                return meter;

            meter = new Meter(meterName, version);
            _meters[meterName] = meter;

            return meter;
        }
    }
}