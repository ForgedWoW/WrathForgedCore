using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

public partial class Autobroadcast
{
    public int Realmid { get; set; }

    public byte Id { get; set; }

    public byte? Weight { get; set; }

    public string Text { get; set; } = null!;
}
