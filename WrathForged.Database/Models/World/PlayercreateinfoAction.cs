using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayercreateinfoAction
{
    public byte Race { get; set; }

    public byte Class { get; set; }

    public ushort Button { get; set; }

    public uint Action { get; set; }

    public ushort Type { get; set; }
}
