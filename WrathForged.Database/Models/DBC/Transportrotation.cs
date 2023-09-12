using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Transportrotation
{
    public int Id { get; set; }

    public int GameObjectsId { get; set; }

    public int TimeIndex { get; set; }

    public float RotX { get; set; }

    public float RotY { get; set; }

    public float RotZ { get; set; }

    public float RotW { get; set; }
}
