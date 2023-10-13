// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Time;

namespace WrathForged.Common
{
    public interface IWoWClientSession : IDisposable
    {
        /// <summary>
        ///     Game and local time for the client.
        /// </summary>
        ClientTime ClientTime { get; }

        /// <summary>
        ///     The network session for the client. Contains:
        ///    <br>* <see cref="WrathForged.Common.Networking.ClientSocket"/>: The TCP connection to the client.</br>
        ///    <br>* <see cref="Networking.PacketBuffer"/>: The incoming data buffer.</br>
        ///    <br>* <see cref="SessionNetwork.Send(object, Models.Realm.Enum.RealmServerOpCode?)"/>: to write out op code packets.</br>
        /// </summary>
        SessionNetwork Network { get; }

        /// <summary>
        ///    The security session for the client. Contains:
        ///    <br>* <see cref="SessionSecurity.Account"/>: The account information.</br>
        ///    <br>* Current Realm: <see cref="SessionSecurity.CurrentRealm"/>.</br>
        ///    <br>* <see cref="SessionSecurity.HasPermission(uint)"/>: To check if the account has permission to perform an action or command.</br>
        ///    <br>* <see cref="SessionSecurity.IsAuthenticated"/>: To check if the account has been fully authenticated.</br>
        /// </summary>
        SessionSecurity Security { get; }

        public T As<T>() where T : IWoWClientSession => (T)this;
    }
}