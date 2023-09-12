using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Transportphysic
{
    public int Id { get; set; }

    public float WaveAmp { get; set; }

    public float WaveTimeScale { get; set; }

    public float RollAmp { get; set; }

    public float RollTimeScale { get; set; }

    public float PitchAmp { get; set; }

    public float PitchTimeScale { get; set; }

    public float MaxBank { get; set; }

    public float MaxBankTurnSpeed { get; set; }

    public float SpeedDampThresh { get; set; }

    public float SpeedDamp { get; set; }
}
