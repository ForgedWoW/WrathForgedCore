DROP TABLE IF EXISTS `ObjectEffectGroup`; 
CREATE TABLE `ObjectEffectGroup` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ObjectEffectGroup` VALUES (33,"vr_elevator_lift_always"); 
INSERT INTO `ObjectEffectGroup` VALUES (34,"vr_elevator_lift_accelerating"); 
INSERT INTO `ObjectEffectGroup` VALUES (157,"FlyingMachineMount_Sprint"); 
INSERT INTO `ObjectEffectGroup` VALUES (158,"WintergraspCatapult_Moving"); 
INSERT INTO `ObjectEffectGroup` VALUES (159,"WintergraspCatapult_NotMoving"); 
INSERT INTO `ObjectEffectGroup` VALUES (160,"FlyingMachineMount_Stand"); 
INSERT INTO `ObjectEffectGroup` VALUES (161,"FlyingMachineMount_Walk"); 
INSERT INTO `ObjectEffectGroup` VALUES (162,"FlyingMachineMount_ShuffleLeft"); 
INSERT INTO `ObjectEffectGroup` VALUES (163,"FlyingMachineMount_ShuffleRight"); 
INSERT INTO `ObjectEffectGroup` VALUES (164,"FlyingMachineMount_WalkBackwards"); 
INSERT INTO `ObjectEffectGroup` VALUES (165,"FlyingMachineMount_JumpStart"); 
INSERT INTO `ObjectEffectGroup` VALUES (166,"FlyingMachineMount_JumpEnd"); 
INSERT INTO `ObjectEffectGroup` VALUES (167,"FlyingMachineMount_SwimRight"); 
INSERT INTO `ObjectEffectGroup` VALUES (168,"FlyingMachineMount_SwimLeft"); 
INSERT INTO `ObjectEffectGroup` VALUES (169,"FlyingMachineMount_Swim"); 
INSERT INTO `ObjectEffectGroup` VALUES (170,"FlyingMachineMount_SwimBackwards"); 
INSERT INTO `ObjectEffectGroup` VALUES (171,"FlyingMachineMount_SwimIdle"); 
INSERT INTO `ObjectEffectGroup` VALUES (172,"FlyingMachineMount_JumpLandRun"); 
INSERT INTO `ObjectEffectGroup` VALUES (173,"FlyingMachineMount_Ascending"); 
INSERT INTO `ObjectEffectGroup` VALUES (175,"WintergraspCatapult_LoadThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (176,"WintergraspCatapult_AttackThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (181,"RocketMount_Stand"); 
INSERT INTO `ObjectEffectGroup` VALUES (182,"RocketMount_Walk"); 
INSERT INTO `ObjectEffectGroup` VALUES (183,"RocketMount_Run"); 
INSERT INTO `ObjectEffectGroup` VALUES (184,"RocketMount_WalkBackwards"); 
INSERT INTO `ObjectEffectGroup` VALUES (185,"RocketMount_SwimIdle"); 
INSERT INTO `ObjectEffectGroup` VALUES (186,"RocketMount_Swim"); 
INSERT INTO `ObjectEffectGroup` VALUES (187,"RocketMount_SwimLeft"); 
INSERT INTO `ObjectEffectGroup` VALUES (188,"RocketMount_SwimRight"); 
INSERT INTO `ObjectEffectGroup` VALUES (189,"RocketMount_SwimBackwards"); 
INSERT INTO `ObjectEffectGroup` VALUES (190,"RocketMount_RunLeft"); 
INSERT INTO `ObjectEffectGroup` VALUES (191,"RocketMount_RunRight"); 
INSERT INTO `ObjectEffectGroup` VALUES (192,"RocketMount_Fly"); 
INSERT INTO `ObjectEffectGroup` VALUES (193,"RocketMount_JumpStart"); 
INSERT INTO `ObjectEffectGroup` VALUES (194,"RocketMount_JumpEnd"); 
INSERT INTO `ObjectEffectGroup` VALUES (195,"RocketMount_Ascending"); 
INSERT INTO `ObjectEffectGroup` VALUES (196,"RocketMount_Descending"); 
INSERT INTO `ObjectEffectGroup` VALUES (197,"SiegeVehicle_AttackThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (198,"SiegeVehicle_AttackUnarmed"); 
INSERT INTO `ObjectEffectGroup` VALUES (199,"SiegeVehicle_Idle"); 
INSERT INTO `ObjectEffectGroup` VALUES (200,"SiegeVehicleSlow_Fast"); 
INSERT INTO `ObjectEffectGroup` VALUES (202,"WintergraspDemolisher_NotMoving"); 
INSERT INTO `ObjectEffectGroup` VALUES (203,"WintergraspDemolisher_AttackUnarmed"); 
INSERT INTO `ObjectEffectGroup` VALUES (204,"WintergraspDemolisher_Moving"); 
INSERT INTO `ObjectEffectGroup` VALUES (205,"WintergraspDemolisher_AttackThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (206,"WintergraspDemolisher_LoadThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (221,"FlyingMachineMount_SwimIdleVar1"); 
INSERT INTO `ObjectEffectGroup` VALUES (222,"FlyingMachineMount_StandVar1"); 
INSERT INTO `ObjectEffectGroup` VALUES (241,"WintergraspDemolisherdeath"); 
INSERT INTO `ObjectEffectGroup` VALUES (242,"WintergraspDemolisherWound"); 
INSERT INTO `ObjectEffectGroup` VALUES (243,"FlyingMachineCreature_VehicleRun"); 
INSERT INTO `ObjectEffectGroup` VALUES (244,"FlyingMachineCreature_VehicleSGroundDown"); 
INSERT INTO `ObjectEffectGroup` VALUES (245,"FlyingMachineCreature_VehicleSitGroundUp"); 
INSERT INTO `ObjectEffectGroup` VALUES (246,"FlyingMachineCreature_VehicleWalk"); 
INSERT INTO `ObjectEffectGroup` VALUES (247,"FlyingMachineCreature_VehicleWalkBackwards"); 
INSERT INTO `ObjectEffectGroup` VALUES (261,"SiegeVehicleDeath"); 
INSERT INTO `ObjectEffectGroup` VALUES (262,"SiegeVehicleWounds"); 
INSERT INTO `ObjectEffectGroup` VALUES (263,"Wintergrasp_Catapult_Death"); 
INSERT INTO `ObjectEffectGroup` VALUES (264,"Wintergrasp_Catapult_Wound"); 
INSERT INTO `ObjectEffectGroup` VALUES (265,"MotorCycleAttackThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (266,"MotorCycleJumpEnd"); 
INSERT INTO `ObjectEffectGroup` VALUES (267,"MotorCycleJumpStart"); 
INSERT INTO `ObjectEffectGroup` VALUES (268,"MotorCycleLoadThrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (269,"MotorCycleStand"); 
INSERT INTO `ObjectEffectGroup` VALUES (270,"MotorCycleWalkRun"); 
INSERT INTO `ObjectEffectGroup` VALUES (281,"ND_AllianceGunship_Always"); 
INSERT INTO `ObjectEffectGroup` VALUES (282,"HordeGunShipState"); 
INSERT INTO `ObjectEffectGroup` VALUES (321,"Off_Vehicle"); 
INSERT INTO `ObjectEffectGroup` VALUES (341,"Flame Leviathan Wound"); 
INSERT INTO `ObjectEffectGroup` VALUES (342,"Flame Leviathan Death"); 
INSERT INTO `ObjectEffectGroup` VALUES (343,"Flame Leviathan Idle"); 
INSERT INTO `ObjectEffectGroup` VALUES (344,"Flame Leviathan Attack Unarmed"); 
INSERT INTO `ObjectEffectGroup` VALUES (345,"Flame Leviathan Attack Thrown"); 
INSERT INTO `ObjectEffectGroup` VALUES (346,"Flame Leviathan Walk Run"); 
INSERT INTO `ObjectEffectGroup` VALUES (361,"MimironHeadMount_Run"); 
INSERT INTO `ObjectEffectGroup` VALUES (362,"MimironHeadMount_Walk"); 
INSERT INTO `ObjectEffectGroup` VALUES (363,"MimironHeadMount_JumpStart"); 
INSERT INTO `ObjectEffectGroup` VALUES (364,"MimironHeadMount_JumpEnd"); 
INSERT INTO `ObjectEffectGroup` VALUES (365,"SwimIdle"); 
INSERT INTO `ObjectEffectGroup` VALUES (381,"Orc_Fortress_Elevator01"); 
INSERT INTO `ObjectEffectGroup` VALUES (401,"Orc_Fortress_Elevator01_Decellerate"); 
INSERT INTO `ObjectEffectGroup` VALUES (402,"Orc_Fortress_Elevator01_Accellerate"); 
INSERT INTO `ObjectEffectGroup` VALUES (403,"Vr_elevator_lift_Decellerate"); 
INSERT INTO `ObjectEffectGroup` VALUES (404,"Vr_elevator_lift_Moving"); 
INSERT INTO `ObjectEffectGroup` VALUES (405,"Gate"); 
INSERT INTO `ObjectEffectGroup` VALUES (421,"UlduarRaid_GnomeWing_Transport_InMotion"); 
INSERT INTO `ObjectEffectGroup` VALUES (441,"Org_Arena_Gear_Open"); 
INSERT INTO `ObjectEffectGroup` VALUES (461,"Org_Arena_Pulley_Loop"); 
INSERT INTO `ObjectEffectGroup` VALUES (462,"Org_Arena_Firedoor_Open"); 
INSERT INTO `ObjectEffectGroup` VALUES (463,"Org_Arena_Firedoor_Close"); 
INSERT INTO `ObjectEffectGroup` VALUES (464,"Org_Arena_Firedoor_Opened"); 
INSERT INTO `ObjectEffectGroup` VALUES (481,"Ul_train_turnaround_Open"); 
INSERT INTO `ObjectEffectGroup` VALUES (501,"UL_SigilDoor01_Open"); 
INSERT INTO `ObjectEffectGroup` VALUES (521,"VrykulTransportShip_InMotion"); 
INSERT INTO `ObjectEffectGroup` VALUES (541,"hf_elevator_lift_Loop"); 
INSERT INTO `ObjectEffectGroup` VALUES (581,"HordeGunship_00"); 
INSERT INTO `ObjectEffectGroup` VALUES (582,"ND_AllianceGunship_Always_0"); 
INSERT INTO `ObjectEffectGroup` VALUES (601,"IceCrown_Elevator02_Start"); 
INSERT INTO `ObjectEffectGroup` VALUES (602,"IceCrown_Elevator02_ShipMoving"); 
INSERT INTO `ObjectEffectGroup` VALUES (603,"IceCrown_Elevator02_Stop"); 
INSERT INTO `ObjectEffectGroup` VALUES (608,"DeepRunTram_Loop"); 
INSERT INTO `ObjectEffectGroup` VALUES (609,"FlyingCarpetMount_Test"); 
INSERT INTO `ObjectEffectGroup` VALUES (610,"Flying Carpet - Magic Loop"); 
INSERT INTO `ObjectEffectGroup` VALUES (611,"Flying Carpet - Periodic"); 
