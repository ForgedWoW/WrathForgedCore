DROP TABLE IF EXISTS `ObjectEffect`; 
CREATE TABLE `ObjectEffect` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, `ObjectEffectGroupID` INT NOT NULL DEFAULT '0', `TriggerType` INT NOT NULL DEFAULT '0', `EventType` INT NOT NULL DEFAULT '0', `EffectRecType` INT NOT NULL DEFAULT '0', `EffectRecID` INT NOT NULL DEFAULT '0', `Attachment` INT NOT NULL DEFAULT '0', `OffsetX` FLOAT NOT NULL DEFAULT '0', `OffsetY` FLOAT NOT NULL DEFAULT '0', `OffsetZ` FLOAT NOT NULL DEFAULT '0', `ObjectEffectModifierID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ObjectEffect` VALUES (52,"Vr_elevator_lift_Accellerate",34,1,1,1,15285,0,10,0,85,0),
(228,"Engine",157,2,0,1,12176,0,0,0,0,0),
(229,"Engine",158,2,0,1,13810,0,0,0,0,0),
(230,"Engine",159,2,0,1,13812,0,0,0,0,0),
(231,"Engine",160,2,0,1,12178,0,0,0,0,0),
(232,"Engine",161,2,0,1,12181,0,0,0,0,0),
(233,"Gear Shift",162,1,0,1,12177,0,0,0,0,0),
(234,"Gear Shift",163,1,0,1,12177,0,0,0,0,0),
(235,"Engine",164,2,0,1,12181,0,0,0,0,0),
(236,"Take Off",165,1,0,1,12175,0,0,0,0,0),
(237,"Land",166,1,0,1,12174,0,0,0,0,0),
(238,"Engine",167,2,0,1,12171,0,0,0,0,0),
(239,"Engine",168,2,0,1,12171,0,0,0,0,0),
(240,"Engine",169,2,0,1,12171,0,0,0,0,0),
(241,"Gear Shift",161,1,0,1,12173,0,0,0,0,0),
(242,"Gear Shift",164,1,0,1,12173,0,0,0,0,0),
(243,"Gear Shift",157,1,0,1,12173,0,0,0,0,0),
(244,"Engine",163,2,0,1,12178,0,0,0,0,0),
(245,"Engine",162,2,0,1,12178,0,0,0,0,0),
(246,"Engine",170,2,0,1,12172,0,0,0,0,0),
(247,"Gear Shift",170,1,0,1,12173,0,0,0,0,0),
(248,"Engine",171,2,0,1,12172,0,0,0,0,0),
(250,"Gear Shift",168,1,0,1,12173,0,0,0,0,0),
(251,"Gear Shift",167,1,0,1,12173,0,0,0,0,0),
(252,"Engine",165,2,0,1,12194,0,0,0,0,0),
(253,"Engine",166,2,0,1,12172,0,0,0,0,0),
(254,"Land",172,1,0,1,12174,0,0,0,0,0),
(255,"Engine",172,2,0,1,12171,0,0,0,0,0),
(256,"Engine",173,2,0,1,12194,0,0,0,0,0),
(258,"Catapult Arm",175,1,0,1,13809,0,0,0,0,0),
(260,"Catapult Arm",176,1,0,1,13807,0,0,0,0,0),
(265,"Engine",181,2,0,1,12301,0,0,0,0,0),
(266,"RocketMountWalk",182,2,0,1,12302,0,0,0,0,0),
(267,"Engine",183,2,0,1,12303,0,0,0,0,0),
(268,"Engine",184,2,0,1,12304,0,0,0,0,0),
(269,"Engine",185,2,0,1,12308,0,0,0,0,0),
(270,"Engine",186,2,0,1,12315,0,0,0,0,0),
(271,"Engine",187,2,0,1,12315,0,0,0,0,0),
(272,"Engine",188,2,0,1,12315,0,0,0,0,0),
(273,"Engine",189,2,0,1,12304,0,0,0,0,0),
(274,"Engine",190,2,0,1,12314,0,0,0,0,0),
(275,"Engine",191,2,0,1,12313,0,0,0,0,0),
(276,"Engine",192,2,0,1,12315,0,0,0,0,0),
(277,"Boost",187,1,0,1,12310,0,0,0,0,0),
(278,"Boost",188,1,0,1,12311,0,0,0,0,0),
(279,"Engine",193,2,0,1,12315,0,0,0,0,0),
(280,"Engine",194,2,0,1,12308,0,0,0,0,0),
(281,"Engine",195,2,0,1,12303,0,0,0,0,0),
(282,"Engine",196,2,0,1,12308,0,0,0,0,0),
(283,"SiegeVehicle_AttackThrown",197,1,0,1,13891,0,0,0,0,0),
(284,"SiegeVehicle_attackUnarmed",198,1,0,1,13892,0,0,0,0,0),
(285,"SiegeVehicle_Idle",199,2,0,1,13894,0,0,0,0,0),
(286,"SiegeVehicleSlow_Fast",200,2,0,1,13895,0,0,0,0,0),
(287,"SiegeVehicleSlow_FastGear",200,1,0,1,14719,0,0,0,0,0),
(290,"Gear Shift",158,1,0,1,14719,0,0,0,0,0),
(291,"Engine",202,2,0,1,13883,0,0,0,0,0),
(292,"Smack",203,1,0,1,13881,0,0,0,0,0),
(293,"Engine",204,2,0,1,13885,0,0,0,0,0),
(294,"Gear Shift",204,1,0,1,14719,0,0,0,0,0),
(295,"Launch",205,1,0,1,13880,0,0,0,0,0),
(296,"Load",206,1,0,1,13884,0,0,0,0,0),
(303,"Special",221,1,0,1,16003,0,0,0,0,0),
(304,"special",222,1,0,1,12179,0,0,0,0,0),
(323,"Death",241,1,0,1,13882,0,0,0,0,0),
(324,"Wound",242,1,0,1,13886,0,0,0,0,0),
(325,"FlyingMachineCreature_VehicleRun",243,2,0,1,13814,0,0,0,0,0),
(326,"FlyingMachineCreature_VehicleSGroundDown",244,1,0,1,13815,0,0,0,0,0),
(327,"FlyingMachineCreature_VehicleSitGroundUp",245,1,0,1,13816,0,0,0,0,0),
(329,"FlyingMachineCreature_VehicleWalkBackwards",247,2,0,1,13818,0,0,0,0,0),
(330,"GearShift",246,1,0,1,14720,0,0,0,0,0),
(331,"GearShift",243,1,0,1,14720,0,0,0,0,0),
(332,"GearShift",247,1,0,1,14720,0,0,0,0,0),
(343,"Death",261,1,0,1,13893,0,0,0,0,0),
(344,"SiegeVehicleWounds",262,1,0,1,13896,0,0,0,0,0),
(346,"Wintergrasp_Catapult_Death",263,1,0,1,13808,0,0,0,0,0),
(347,"Wintergrasp_Catapult_Wound",264,1,0,1,13813,0,0,0,0,0),
(348,"Attack Thrown",265,1,0,1,13897,0,0,0,0,0),
(349,"Jump End",266,1,0,1,13898,0,0,0,0,0),
(350,"Jump Start",267,1,0,1,13899,0,0,0,0,0),
(351,"Load Thrown",268,1,0,1,13900,0,0,0,0,0),
(352,"Stand",269,2,0,1,13901,0,0,0,0,0),
(353,"Walk Run",270,2,0,1,13902,0,0,0,0,0),
(354,"Gear",270,1,0,1,14719,0,0,0,0,0),
(355,"Run",267,2,0,1,13902,0,0,0,0,0),
(356,"Run",266,2,0,1,13902,0,0,0,0,0),
(384,"Stand",246,2,0,1,13817,0,0,0,0,0),
(443,"Off Vehicle",321,2,0,1,12748,0,0,0,0,0),
(463,"Flame Leviathan Wound",341,1,0,1,15378,0,0,0,0,0),
(464,"Flame Leviathan Death",342,1,0,1,15381,0,0,0,0,0),
(465,"Flame Leviathan Idle",343,2,0,1,15380,0,0,0,0,0),
(466,"Flame Leviathan Attack Unarmed",344,1,0,1,15382,0,0,0,0,0),
(467,"Flame Leviathan Attack Thrown",345,1,0,1,15383,0,0,0,0,0),
(468,"Flame Leviathan Walk run",346,2,0,1,15379,0,0,0,0,0),
(469,"Flame Leviathan Gearshift",346,1,0,1,14719,0,0,0,0,0),
(523,"MimironHeadMount_Run",361,2,0,1,15830,0,0,0,0,0),
(524,"GearShiftAir",361,1,0,1,14720,0,0,0,0,0),
(525,"MimironHeadMount_Walk",362,2,0,1,15831,0,0,0,0,0),
(526,"GearShiftGround",362,1,0,1,14719,0,0,0,0,0),
(527,"MimironHeadMount_JumpStart",363,1,0,1,15832,0,0,0,0,0),
(528,"MimironHeadMount_JumpEnd",364,1,0,1,15833,0,0,0,0,0),
(529,"Walk",364,2,0,1,15831,0,0,0,0,0),
(530,"SwimIdle",365,2,0,1,15830,0,0,0,0,0),
(543,"Orc_Fortress_Elevator01_Moving",381,2,0,1,15277,0,0,0,0,0),
(563,"Loop",33,2,0,1,12176,0,10,0,85,121),
(564,"Orc_Fortress_Elevator01_Decellerate",401,1,0,1,15276,0,0,0,0,0),
(565,"Orc_Fortress_Elevator01_Accellerate",402,1,0,1,15275,0,0,0,0,0),
(566,"Vr_elevator_lift_Decellerate",403,3,0,1,15286,0,10,0,85,0),
(567,"Vr_elevator_lift_Moving",404,2,0,1,15879,0,10,0,85,0),
(568,"Vr_elevator_lift_Moving",403,2,0,1,15287,0,10,0,85,123),
(569,"Vr_elevator_lift_Moving",34,2,0,1,15287,0,10,0,85,124),
(571,"GateClose",405,1,0,1,10998,0,0,0,0,0),
(583,"InMotion",421,2,0,1,15902,0,0,27,0,141),
(603,"Gear Loop",441,2,0,1,13978,0,0,0,0,0),
(623,"Loop",461,2,0,1,13977,0,0,0,0,0),
(624,"Open (center)",462,1,0,1,13973,0,0,0,0,0),
(625,"Close (center)",463,1,0,1,13974,0,0,0,0,0),
(626,"Open Loop (center)",464,2,0,1,15903,0,0,0,0,0),
(643,"Open Loop (west)",464,2,0,1,15903,0,0,30,0,0),
(644,"Open Loop (east)",464,2,0,1,15903,0,0,-30,0,0),
(663,"Open",481,1,0,1,15859,0,0,0,0,0),
(683,"Open",501,1,0,1,15325,0,0,0,0,0),
(703,"Fire",421,2,0,1,15916,0,0,0,0,0),
(723,"VrykulTransportShip_Inmotion",521,2,0,1,15281,0,0,0,0,0),
(743,"hf_elevator_lift_Loop",541,2,0,1,15274,0,0,0,0,161),
(783,"HordeGunShip (IceCrown)",282,2,0,1,15013,0,0,0,0,181),
(784,"LargePropellers_A (IceCrown)",281,2,0,1,16534,0,0,0,0,182),
(786,"ND_AllianceGunship_Always",582,2,0,1,17187,0,0,0,0,184),
(803,"HordeGunshipState_00 (Small)",581,2,0,1,17188,0,0,0,0,201),
(804,"IceCrown_Elevator02_Start",601,1,0,1,17207,0,0,0,0,0),
(805,"IceCrown_Elevator02_Moving",602,2,0,1,17209,0,0,0,0,202),
(806,"IceCrown_Elevator02_Stop",603,1,0,1,17208,0,0,0,0,0),
(807,"Icecrown_Elevator_Start",602,1,0,1,17207,0,0,0,0,0),
(808,"IcecrownElevatorStop",602,3,0,1,17208,0,0,0,0,0),
(814,"DeeprunTram_Start",608,1,0,1,17473,0,0,0,0,0),
(815,"DeeprunTram_Stop",608,3,0,1,17474,0,0,0,0,0),
(816,"Loop",608,2,0,1,17469,0,0,0,-10,0),
(819,"South",609,2,0,1,15344,0,-6,0,0,0),
(820,"North",609,2,0,1,15344,0,6,0,0,0),
(821,"West",609,2,0,1,15344,0,0,6,0,0),
(822,"East",609,2,0,1,15344,0,0,-6,0,0),
(823,"Loop",610,2,0,1,17478,0,0,0,0,0),
(824,"Flap",611,2,0,1,17477,0,0,0,0,0),
(826,"Flap (Copy)",611,2,0,1,17477,0,0,0,0,0),
(827,"Flap (Copy2)",611,2,0,1,17477,0,0,0,0,0),
(828,"Flap (Copy 3)",611,2,0,1,17477,0,0,0,0,0); 
