// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spellchaineffect
{
    public int Id { get; set; }

    public float AvgSegLen { get; set; }

    public float Width { get; set; }

    public float NoiseScale { get; set; }

    public float TexCoordScale { get; set; }

    public int SegDuration { get; set; }

    public int SegDelay { get; set; }

    public string? Texture { get; set; }

    public int Flags { get; set; }

    public int JointCount { get; set; }

    public float JointOffsetRadius { get; set; }

    public int JointsPerMinorJoint { get; set; }

    public int MinorJointsPerMajorJoint { get; set; }

    public float MinorJointScale { get; set; }

    public float MajorJointScale { get; set; }

    public float JointMoveSpeed { get; set; }

    public float JointSmoothness { get; set; }

    public float MinDurationBetweenJointJumps { get; set; }

    public float MaxDurationBetweenJointJumps { get; set; }

    public float WaveHeight { get; set; }

    public float WaveFreq { get; set; }

    public float WaveSpeed { get; set; }

    public float MinWaveAngle { get; set; }

    public float MaxWaveAngle { get; set; }

    public float MinWaveSpin { get; set; }

    public float MaxWaveSpin { get; set; }

    public float ArcHeight { get; set; }

    public float MinArcAngle { get; set; }

    public float MaxArcAngle { get; set; }

    public float MinArcSpin { get; set; }

    public float MaxArcSpin { get; set; }

    public float DelayBetweenEffects { get; set; }

    public float MinFlickerOnDuration { get; set; }

    public float MaxFlickerOnDuration { get; set; }

    public float MinFlickerOffDuration { get; set; }

    public float MaxFlickerOffDuration { get; set; }

    public float PulseSpeed { get; set; }

    public float PulseOnLength { get; set; }

    public float PulseFadeLength { get; set; }

    public byte Alpha { get; set; }

    public byte Red { get; set; }

    public byte Green { get; set; }

    public byte Blue { get; set; }

    public byte BlendMode { get; set; }

    public string? Combo { get; set; }

    public int RenderLayer { get; set; }

    public float TextureLength { get; set; }

    public float WavePhase { get; set; }
}
