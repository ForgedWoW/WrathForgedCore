using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Vehicleseat
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public int AttachmentId { get; set; }

    public float AttachmentOffsetX { get; set; }

    public float AttachmentOffsetY { get; set; }

    public float AttachmentOffsetZ { get; set; }

    public float EnterPreDelay { get; set; }

    public float EnterSpeed { get; set; }

    public float EnterGravity { get; set; }

    public float EnterMinDuration { get; set; }

    public float EnterMaxDuration { get; set; }

    public float EnterMinArcHeight { get; set; }

    public float EnterMaxArcHeight { get; set; }

    public int EnterAnimStart { get; set; }

    public int EnterAnimLoop { get; set; }

    public int RideAnimStart { get; set; }

    public int RideAnimLoop { get; set; }

    public int RideUpperAnimStart { get; set; }

    public int RideUpperAnimLoop { get; set; }

    public float ExitPreDelay { get; set; }

    public float ExitSpeed { get; set; }

    public float ExitGravity { get; set; }

    public float ExitMinDuration { get; set; }

    public float ExitMaxDuration { get; set; }

    public float ExitMinArcHeight { get; set; }

    public float ExitMaxArcHeight { get; set; }

    public int ExitAnimStart { get; set; }

    public int ExitAnimLoop { get; set; }

    public int ExitAnimEnd { get; set; }

    public float PassengerYaw { get; set; }

    public float PassengerPitch { get; set; }

    public float PassengerRoll { get; set; }

    public int PassengerAttachmentId { get; set; }

    public int VehicleEnterAnim { get; set; }

    public int VehicleExitAnim { get; set; }

    public int VehicleRideAnimLoop { get; set; }

    public int VehicleEnterAnimBone { get; set; }

    public int VehicleExitAnimBone { get; set; }

    public int VehicleRideAnimBone { get; set; }

    public float VehicleEnterAnimDelay { get; set; }

    public float VehicleExitAnimDelay { get; set; }

    public int VehicleAbilityDisplay { get; set; }

    public int EnterUisoundId { get; set; }

    public int ExitUisoundId { get; set; }

    public int UiSkin { get; set; }

    public int FlagsB { get; set; }

    public float CameraEnteringDelay { get; set; }

    public float CameraEnteringDuration { get; set; }

    public float CameraExitingDelay { get; set; }

    public float CameraExitingDuration { get; set; }

    public float CameraOffsetX { get; set; }

    public float CameraOffsetY { get; set; }

    public float CameraOffsetZ { get; set; }

    public float CameraPosChaseRate { get; set; }

    public float CameraFacingChaseRate { get; set; }

    public float CameraEnteringZoom { get; set; }

    public float CameraSeatZoomMin { get; set; }

    public float CameraSeatZoomMax { get; set; }
}
