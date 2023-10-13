// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;

namespace WrathForged.Common.Cryptography;

public static class HashUtil
{
    public static byte[] ComputeHash(params byte[][] args) => SHA1.HashData(args.SelectMany(b => b).ToArray());
}
