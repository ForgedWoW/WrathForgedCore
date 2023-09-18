DROP TABLE IF EXISTS `SoundProviderPreferences`; 
CREATE TABLE `SoundProviderPreferences` ( `ID` INT NOT NULL DEFAULT '0', `Description` TEXT NULL, `Flags` INT NOT NULL DEFAULT '0', `EAXEnvironmentSelection` INT NOT NULL DEFAULT '0', `EAXDecayTime` FLOAT NOT NULL DEFAULT '0', `EAX2EnvironmentSize` FLOAT NOT NULL DEFAULT '0', `EAX2EnvironmentDiffusion` FLOAT NOT NULL DEFAULT '0', `EAX2Room` INT NOT NULL DEFAULT '0', `EAX2RoomHF` INT NOT NULL DEFAULT '0', `EAX2DecayHFRatio` FLOAT NOT NULL DEFAULT '0', `EAX2Reflections` INT NOT NULL DEFAULT '0', `EAX2ReflectionsDelay` FLOAT NOT NULL DEFAULT '0', `EAX2Reverb` INT NOT NULL DEFAULT '0', `EAX2ReverbDelay` FLOAT NOT NULL DEFAULT '0', `EAX2RoomRolloff` FLOAT NOT NULL DEFAULT '0', `EAX2AirAbsorption` FLOAT NOT NULL DEFAULT '0', `EAX3RoomLF` INT NOT NULL DEFAULT '0', `EAX3DecayLFRatio` FLOAT NOT NULL DEFAULT '0', `EAX3EchoTime` FLOAT NOT NULL DEFAULT '0', `EAX3EchoDepth` FLOAT NOT NULL DEFAULT '0', `EAX3ModulationTime` FLOAT NOT NULL DEFAULT '0', `EAX3ModulationDepth` FLOAT NOT NULL DEFAULT '0', `EAX3HFReference` FLOAT NOT NULL DEFAULT '0', `EAX3LFReference` FLOAT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SoundProviderPreferences` VALUES (3,"TESTVOLUMENONE",0,0,0.1,1,1,0,0,1,0,0,0,0,1,-0.05,0,0.1,0.25,0,1,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (4,"TESTVOLUMEFULL",0,0,20,50,1,0,0,1,1000,0.3,0,0.1,1,-0.05,0,0.1,0.25,0,1,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (5,"TESTVOLUMEHALF",0,0,10,1,1,0,0,1,200,0.2,0,0.1,1,-0.05,0,0.1,0.25,0,1,0,1000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (11,"Underwater",4,15,1,1.8,1,-1000,-10000,0.1,-449,0.007,1700,0.0131,10,-100,0,1,0.25,0,1.18,0.348,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (19,"TESTVOLUMEPSYCHOTIC",0,25,2.31,11.6,1,0,0,0.64,-711,0.012,83,0.017,0,5,0,0.1,0.075,0,1,0,10000,30); 
INSERT INTO `SoundProviderPreferences` VALUES (66,"PRESET_OFF",831,-1,1,7.5,1,-10000,-10000,1,-2602,0.007,200,0.011,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (67,"PRESET_GENERIC",63,0,1.49,7.5,1,-1000,-100,0.863,-2602,0.007,200,0.0131,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (68,"PRESET_PADDEDCELL",63,1,0.17,1.4,1,-1000,-6000,0.1,-1204,0.0031,207,0.002,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (69,"PRESET_ROOM",63,2,0.4,1.9,1,-1000,-454,0.863,-1646,0.002,53,0.0063,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (70,"PRESET_BATHROOM",63,3,1.49,1.4,1,-1000,-1200,0.54,-370,0.007,1030,0.0131,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (71,"PRESET_LIVINGROOM",63,4,0.5,2.5,1,-1000,-6000,0.1,-1376,0.0063,-1104,0.004,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (72,"PRESET_STONEROOM",63,5,2.331,11.6,1,-1000,-300,0.64,-711,0.012,83,0.017,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (73,"PRESET_AUDITORIUM",63,6,4.32,21.6,1,-1000,-476,0.59,-789,0.02,-289,0.03,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (74,"PRESET_CONCERTHALL",63,7,3.92,19.6,1,-1000,-500,0.7,-1230,0.02,-2,0.029,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (75,"PRESET_CAVE",31,8,3,14.6,1,-1000,-500,1.3,-602,0.015,-402,0.022,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (76,"PRESET_ARENA",63,9,7.24,36.2,1,-1000,-698,0.363,-1166,0.02,16,0.03,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (77,"PRESET_HANGAR",63,10,10.05,50.63,1,-1000,-1000,0.263,-602,0.02,198,0.03,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (78,"PRESET_CARPETTEDHALLWAY",63,11,0.3,1.9,1,-1000,-4000,0.1,-1831,0.002,-1630,0.03,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (79,"PRESET_HALLWAY",63,12,1.49,1.8,1,-1000,-300,0.59,-1219,0.007,441,0.0131,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (80,"PRESET_STONECORRIDOR",63,13,2.7,13.5,1,-1000,-237,0.79,-1214,0.0163,395,0.02,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (81,"PRESET_ALLEY",63,14,1.49,7.5,0.3,-1000,-270,0.86,-1204,0.007,-4,0.0131,0,-5,0,1,0.125,0.95,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (82,"PRESET_FOREST",63,15,1.49,38,0.3,-1000,-3300,0.54,-2560,0.162,-229,0.088,0,-5,0,1,0.125,1,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (83,"PRESET_CITY",63,16,1.49,7.5,0.5,-1000,-800,0.67,-2273,0.007,-1691,0.0131,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (84,"PRESET_MOUNTAINS",31,17,1.49,100,0.27,-1000,-2500,0.231,-2780,0.3,-1434,0.1,0,-5,0,1,0.25,1,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (85,"PRESET_QUARRY",63,18,1.49,17.5,1,-1000,-1000,0.863,-10000,0.0631,500,0.025,0,-5,0,1,0.125,0.7,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (86,"PRESET_PLAIN",63,19,1.49,42.5,0.231,-1000,-2000,0.5,-2466,0.179,-1926,0.1,0,-5,0,1,0.25,1,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (87,"PRESET_PARKINGLOT",31,20,1.65,8.63,1,-1000,0,1.5,-1363,0.008,-1153,0.012,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (88,"PRESET_SEWERPIPE",63,21,2.831,1.7,0.8,-1000,-1000,0.14,429,0.014,1023,0.0231,0,-5,0,1,0.25,0,0.25,0,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (89,"PRESET_UNDERWATER",63,22,1,1.8,1,-1000,-10000,0.1,-449,0.007,1700,0.0131,10,-100,0,1,0.25,0,1.18,0.348,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (90,"PRESET_DRUGGED",31,23,8.39,1.9,0.5,-1000,0,1.39,-115,0.002,985,0.03,0,-5,0,1,0.25,0,0.25,1,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (91,"PRESET_DIZZY",31,24,17.263,1.8,0.6,-1000,-400,0.56,-1713,0.02,-613,0.03,0,-5,0,1,0.25,1,0.831,0.31,5000,250); 
INSERT INTO `SoundProviderPreferences` VALUES (92,"PRESET_PSYCHOTIC",31,25,7.56,1,0.5,-1000,-151,0.931,-626,0.02,774,0.03,0,-5,0,1,0.25,0,4,1,5000,250); 