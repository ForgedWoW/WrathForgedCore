// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using MathNet.Numerics.Statistics;
using WrathForged.Common.ObjectTypes;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Models.Networking.Packets;

namespace WrathForged.Common.Time;

public class ClientTime(IWoWClientSession clientSession) : IUpdateLoop
{
    private readonly IWoWClientSession _clientSession = clientSession;
    private uint _timeSyncTimer;
    private uint _nextTimeSyncCounter;
    private readonly ConcurrentDictionary<uint, uint> _pendingTimeSyncRequests = new();
    private readonly CircularBuffer<(long clockDelta, uint roundTripTime)> _timeSyncClockDeltaQueue = new(6);

    public uint ClientTimestamp { get; private set; }
    public uint ClientLatency { get; private set; }
    public long TimeSyncClockDelta { get; private set; }

    public void ResetTimeSync()
    {
        _timeSyncTimer = 0;
        _nextTimeSyncCounter = 0;
        _pendingTimeSyncRequests.Clear();
    }

    public void SendTimeSync()
    {
        _clientSession.Network.Send(new TimeSyncRequest() { TimeSyncCounter = _nextTimeSyncCounter });
        _ = _pendingTimeSyncRequests.TryAdd(_nextTimeSyncCounter, TimeUtil.GetMillisecondsSinceStartup());
        _timeSyncTimer = _nextTimeSyncCounter == 0u ? 5000u : 10000u;
        _nextTimeSyncCounter++;
    }

    public void TimeSync(uint timeSyncCounter, uint clientTimestamp)
    {
        ClientTimestamp = clientTimestamp;

        if (_pendingTimeSyncRequests.TryRemove(timeSyncCounter, out var timeSyncRequestTime))
        {
            var roundTripTime = TimeUtil.GetMillisecondsSinceStartup() - timeSyncRequestTime;
            ClientLatency = roundTripTime / 2;
            var clockDelta = (long)timeSyncRequestTime + ClientLatency - ClientTimestamp;
            _timeSyncClockDeltaQueue.PushBack((clockDelta, roundTripTime));
            ComputeNewClockDelta();
        }
    }

    public void ComputeNewClockDelta()
    {
        List<double> latencies = [];
        foreach (var (clockDelta, roundTripTime) in _timeSyncClockDeltaQueue)
        {
            latencies.Add(clockDelta);
        }

        var latencyMedian = Statistics.Median(latencies);
        var latencyStandardDeviation = Statistics.StandardDeviation(latencies);

        List<double> filteredClockDeltas = [];
        foreach (var (clockDelta, roundTripTime) in _timeSyncClockDeltaQueue)
        {
            if (roundTripTime < latencyStandardDeviation + latencyMedian)
            {
                filteredClockDeltas.Add(clockDelta);
            }
        }

        if (filteredClockDeltas.Count != 0)
        {
            var meanClockDelta = (long)Math.Round(Statistics.Mean(filteredClockDeltas));
            if (Math.Abs(meanClockDelta - TimeSyncClockDelta) > 25)
            {
                TimeSyncClockDelta = meanClockDelta;
            }
        }
        else if (TimeSyncClockDelta == 0)
        {
            TimeSyncClockDelta = _timeSyncClockDeltaQueue.Back().clockDelta;
        }
    }

    public void UpdateTick(uint diff)
    {
        if (_timeSyncTimer > 0)
        {
            _timeSyncTimer -= diff;

            if (_timeSyncTimer <= 0)
                SendTimeSync();
        }
    }
}

