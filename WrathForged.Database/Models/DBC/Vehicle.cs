// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Vehicle.dbc")]
public partial class Vehicle : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float TurnSpeed { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float PitchSpeed { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float PitchMin { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float PitchMax { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int SeatId1 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int SeatId2 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int SeatId3 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int SeatId4 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int SeatId5 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int SeatId6 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int SeatId7 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int SeatId8 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float MouseLookOffsetPitch { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float CameraFadeDistScalarMin { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
    public float CameraFadeDistScalarMax { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
    public float CameraPitchOffset { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.FLOAT)]
    public float FacingLimitRight { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float FacingLimitLeft { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float MsslTrgtTurnLingering { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
    public float MsslTrgtPitchLingering { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
    public float MsslTrgtMouseLingering { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
    public float MsslTrgtEndOpacity { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
    public float MsslTrgtArcSpeed { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
    public float MsslTrgtArcRepeat { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
    public float MsslTrgtArcWidth { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
    public float MsslTrgtImpactRadius1 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
    public float MsslTrgtImpactRadius2 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
    public string? MsslTrgtArcTexture { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
    public string? MsslTrgtImpactTexture { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
    public string? MsslTrgtImpactModel1 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
    public string? MsslTrgtImpactModel2 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
    public float CameraYawOffset { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32)]
    public int UilocomotionType { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.FLOAT)]
    public float MsslTrgtImpactTexRadius { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32)]
    public int VehicleUiindicatorId { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32, Nullable = true)]
    public int? PowerDisplayId1 { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32, Nullable = true)]
    public int? PowerDisplayId2 { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.INT32, Nullable = true)]
    public int? PowerDisplayId3 { get; set; }

    public virtual Powerdisplay? PowerDisplayId1Navigation { get; set; }
    public virtual Powerdisplay? PowerDisplayId2Navigation { get; set; }
    public virtual Powerdisplay? PowerDisplayId3Navigation { get; set; }
}
