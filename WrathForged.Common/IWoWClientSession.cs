// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Time;

namespace WrathForged.Common
{
    public interface IWoWClientSession
    {
        ClientTime ClientTime { get; }
        SessionNetwork Network { get; }
        SessionSecurity Security { get; }

        public T As<T>() where T : IWoWClientSession => (T)this;
    }
}