// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("VehicleSeat.dbc")]
public partial class Vehicleseat : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int AttachmentId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float AttachmentOffsetX { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float AttachmentOffsetY { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float AttachmentOffsetZ { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float EnterPreDelay { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float EnterSpeed { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float EnterGravity { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float EnterMinDuration { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float EnterMaxDuration { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
    public float EnterMinArcHeight { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float EnterMaxArcHeight { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int EnterAnimStart { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int EnterAnimLoop { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int RideAnimStart { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int RideAnimLoop { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int RideUpperAnimStart { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int RideUpperAnimLoop { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float ExitPreDelay { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float ExitSpeed { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
    public float ExitGravity { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
    public float ExitMinDuration { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
    public float ExitMaxDuration { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
    public float ExitMinArcHeight { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
    public float ExitMaxArcHeight { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int ExitAnimStart { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int ExitAnimLoop { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int ExitAnimEnd { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
    public float PassengerYaw { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
    public float PassengerPitch { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
    public float PassengerRoll { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int PassengerAttachmentId { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32)]
    public int VehicleEnterAnim { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32)]
    public int VehicleExitAnim { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT32)]
    public int VehicleRideAnimLoop { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32)]
    public int VehicleEnterAnimBone { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int VehicleExitAnimBone { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32)]
    public int VehicleRideAnimBone { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.FLOAT)]
    public float VehicleEnterAnimDelay { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.FLOAT)]
    public float VehicleExitAnimDelay { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.INT32)]
    public int VehicleAbilityDisplay { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.INT32)]
    public int EnterUisoundId { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.INT32)]
    public int ExitUisoundId { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.INT32)]
    public int UiSkin { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.INT32)]
    public int FlagsB { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.FLOAT)]
    public float CameraEnteringDelay { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.FLOAT)]
    public float CameraEnteringDuration { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.FLOAT)]
    public float CameraExitingDelay { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.FLOAT)]
    public float CameraExitingDuration { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.FLOAT)]
    public float CameraOffsetX { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.FLOAT)]
    public float CameraOffsetY { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.FLOAT)]
    public float CameraOffsetZ { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.FLOAT)]
    public float CameraPosChaseRate { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.FLOAT)]
    public float CameraFacingChaseRate { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.FLOAT)]
    public float CameraEnteringZoom { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.FLOAT)]
    public float CameraSeatZoomMin { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.FLOAT)]
    public float CameraSeatZoomMax { get; set; }
}
