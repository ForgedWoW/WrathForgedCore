using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

public partial class SecretDigest
{
    public uint Id { get; set; }

    public string Digest { get; set; } = null!;
}
