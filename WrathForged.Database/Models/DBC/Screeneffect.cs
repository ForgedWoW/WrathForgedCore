using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Screeneffect
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Effect { get; set; }

    public int Param1 { get; set; }

    public int Param2 { get; set; }

    public int Param3 { get; set; }

    public int Param4 { get; set; }

    public int LightParamsId { get; set; }

    public int SoundAmbienceId { get; set; }

    public int ZoneMusicId { get; set; }
}
