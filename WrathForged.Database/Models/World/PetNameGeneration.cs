using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PetNameGeneration
{
    public uint Id { get; set; }

    public string Word { get; set; } = null!;

    public uint Entry { get; set; }

    public byte Half { get; set; }
}
