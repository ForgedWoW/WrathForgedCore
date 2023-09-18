// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;
using System.Text;
using WrathForged.Common.Networking;
using WrathForged.Models.Auth;

namespace WrathForged.Common.Cryptography
{
    public class PasswordAuthenticator
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="srp">the SRP instance for our current session</param>
        public PasswordAuthenticator(SecureRemotePassword srp) => SRP = srp;

        /// <summary>
        /// The SRP instance we're using
        /// </summary>
        public SecureRemotePassword SRP { get; }

        public byte[] ReconnectProof
        {
            get;
            set;
        } = Array.Empty<byte>();

        /// <summary>
        /// Writes the server's challenge.
        /// </summary>
        /// <param name="packet">the packet to write to</param>
        public void WriteServerChallenge(PrimitiveWriter packet)
        {
            packet.WriteBigInt(SRP.PublicEphemeralValueB, 32);
            packet.WriteBigIntLength(SRP.Generator, 1);

            // We will pad this out to 32 bytes.
            packet.WriteBigIntLength(SRP.Modulus, 32);
            packet.WriteBigInt(SRP.Salt);
        }

        /// <summary>
        /// Checks if the client's proof matches our proof.
        /// </summary>
        /// <param name="packet">the packet to read from</param>
        /// <returns>true if the client proof matches; false otherwise</returns>
        public bool IsClientProofValid(PrimitiveReader packet)
        {
            SRP.PublicEphemeralValueA = packet.ReadBigInteger(32);

            var proof = packet.ReadBigInteger(20);

            // SHA1 of PublicEphemeralValueA and the 16 random bytes sent in
            // AUTH_LOGON_CHALLENGE from the server
            _ = packet.ReadBytes(20);

            var keyCount = packet.ReadByte();
            for (var i = 0; i < keyCount; i++)
            {
                _ = packet.ReadUInt16();

                _ = packet.ReadUInt32();

                _ = packet.ReadBytes(4);

                // sha of the SRP's PublicEphemeralValueA, PublicEphemeralValueB,
                // and 20 unknown bytes
                _ = packet.ReadBytes(20);
            }

            var securityFlags = packet.ReadByte();

            if ((securityFlags & 1) != 0)
            {
                // PIN
                _ = packet.ReadBytes(16);

                _ = packet.ReadBytes(20);
            }

            if ((securityFlags & 2) != 0)
            {
                _ = packet.ReadBytes(20);
            }

            if ((securityFlags & 4) != 0)
            {
                var arrLen = packet.ReadByte();

                _ = packet.ReadBytes(arrLen);
            }

            return SRP.IsClientProofValid(proof);
        }

        /// <summary>
        /// Writes the server's proof.
        /// </summary>
        /// <param name="packet">the packet to write to</param>
        public void WriteServerProof(PrimitiveWriter packet) => packet.WriteBigInt(SRP.ServerSessionKeyProof, 20);

        public void WriteReconnectChallenge(PrimitiveWriter packet)
        {
            ReconnectProof = new byte[16];
            new System.Random(System.Environment.TickCount).NextBytes(ReconnectProof);

            packet.Write(ReconnectProof);
            // 16 bytes of 0's
            packet.Write(0L);
            packet.Write(0L);
        }

        public bool IsReconnectProofValid(PrimitiveReader packet, AuthenticationInfo authInfo)
        {
            //md5 hash of account name and secure random
            var md5Hash = packet.ReadBytes(16);

            //byte[20] sha1 hash of accountname, md5 from above, reconnectProof, byte[40] sessionkey
            var shaHash1 = packet.ReadBytes(20);

            //byte[20] sha1 hash of md5 from above and byte[20] (all zero)
            _ = packet.ReadBytes(20);

            var username = Encoding.UTF8.GetBytes(SRP.Username);

            var sha = SHA1.Create();
            _ = sha.TransformBlock(username, 0, username.Length, username, 0);
            _ = sha.TransformBlock(md5Hash, 0, md5Hash.Length, md5Hash, 0);
            _ = sha.TransformBlock(ReconnectProof, 0, ReconnectProof.Length, ReconnectProof, 0);
            _ = sha.TransformBlock(authInfo.SessionKey, 0, authInfo.SessionKey.Length, authInfo.SessionKey, 0);
            var hash = sha.TransformFinalBlock(Array.Empty<byte>(), 0, 0);

            for (var i = 0; i < 20; i++)
            {
                if (shaHash1[i] != hash[i])
                    return false;
            }

            return true;
        }
    }
}