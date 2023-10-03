// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;
using System.Text;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;

namespace WrathForged.Common.Cryptography;

/// <summary>
/// Default constructor.
/// </summary>
/// <param name="srp">the SRP instance for our current session</param>
public class PasswordAuthenticator(SecureRemotePassword srp)
{
    /// <summary>
    /// The SRP instance we're using
    /// </summary>
    public SecureRemotePassword SRP { get; } = srp;

    public byte[] ReconnectProof { get; set; } = [];

    /// <summary>
    /// Checks if the client's proof matches our proof.
    /// </summary>
    /// <param name="packet">the packet to read from</param>
    /// <returns>true if the client proof matches; false otherwise</returns>
    public bool IsClientProofValid(AuthLoginProof packet)
    {
        SRP.PublicEphemeralValueA = packet.PublicEphemeralValueA;

        return SRP.IsClientProofValid(packet.Proof);
    }

    public bool IsReconnectProofValid(AuthReconnectedProof packet, Account authInfo)
    {
        if (authInfo.SessionKeyAuth == null)
            return false;

        //md5 hash of account name and secure random
        var md5Hash = packet.ReconnectProof;

        //byte[20] sha1 hash of account name, md5 from above, reconnectProof, byte[40] session key
        var shaHash1 = packet.R2;

        var username = Encoding.UTF8.GetBytes(SRP.Username);

        var sha = SHA1.Create();
        _ = sha.TransformBlock(username, 0, username.Length, username, 0);
        _ = sha.TransformBlock(md5Hash, 0, md5Hash.Length, md5Hash, 0);
        _ = sha.TransformBlock(ReconnectProof, 0, ReconnectProof.Length, ReconnectProof, 0);
        _ = sha.TransformBlock(authInfo.SessionKeyAuth, 0, authInfo.SessionKeyAuth.Length, authInfo.SessionKeyAuth, 0);
        var hash = sha.TransformFinalBlock([], 0, 0);

        for (var i = 0; i < 20; i++)
        {
            if (shaHash1[i] != hash[i])
                return false;
        }

        return true;
    }
}