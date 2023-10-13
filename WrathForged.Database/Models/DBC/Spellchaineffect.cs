// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellChainEffects.dbc")]
public partial class Spellchaineffect : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.FLOAT)]
    public float AvgSegLen { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float Width { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float NoiseScale { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float TexCoordScale { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int SegDuration { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int SegDelay { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? Texture { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int JointCount { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float JointOffsetRadius { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int JointsPerMinorJoint { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int MinorJointsPerMajorJoint { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
    public float MinorJointScale { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float MajorJointScale { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float JointMoveSpeed { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
    public float JointSmoothness { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
    public float MinDurationBetweenJointJumps { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.FLOAT)]
    public float MaxDurationBetweenJointJumps { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float WaveHeight { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float WaveFreq { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
    public float WaveSpeed { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
    public float MinWaveAngle { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
    public float MaxWaveAngle { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
    public float MinWaveSpin { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
    public float MaxWaveSpin { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
    public float ArcHeight { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
    public float MinArcAngle { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
    public float MaxArcAngle { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
    public float MinArcSpin { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
    public float MaxArcSpin { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
    public float DelayBetweenEffects { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.FLOAT)]
    public float MinFlickerOnDuration { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
    public float MaxFlickerOnDuration { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.FLOAT)]
    public float MinFlickerOffDuration { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.FLOAT)]
    public float MaxFlickerOffDuration { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.FLOAT)]
    public float PulseSpeed { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.FLOAT)]
    public float PulseOnLength { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.FLOAT)]
    public float PulseFadeLength { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.BYTE)]
    public byte Alpha { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.BYTE)]
    public byte Red { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.BYTE)]
    public byte Green { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.BYTE)]
    public byte Blue { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.BYTE)]
    public byte BlendMode { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? Combo { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.INT32)]
    public int RenderLayer { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.FLOAT)]
    public float TextureLength { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.FLOAT)]
    public float WavePhase { get; set; }
}
