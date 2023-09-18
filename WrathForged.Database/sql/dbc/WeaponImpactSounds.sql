DROP TABLE IF EXISTS `WeaponImpactSounds`; 
CREATE TABLE `WeaponImpactSounds` ( `ID` INT NOT NULL DEFAULT '0', `WeaponSubClassID` INT NOT NULL DEFAULT '0', `ParrySoundType` INT NOT NULL DEFAULT '0', `ImpactSoundID_1` INT NOT NULL DEFAULT '0', `ImpactSoundID_2` INT NOT NULL DEFAULT '0', `ImpactSoundID_3` INT NOT NULL DEFAULT '0', `ImpactSoundID_4` INT NOT NULL DEFAULT '0', `ImpactSoundID_5` INT NOT NULL DEFAULT '0', `ImpactSoundID_6` INT NOT NULL DEFAULT '0', `ImpactSoundID_7` INT NOT NULL DEFAULT '0', `ImpactSoundID_8` INT NOT NULL DEFAULT '0', `ImpactSoundID_9` INT NOT NULL DEFAULT '0', `ImpactSoundID_10` INT NOT NULL DEFAULT '0', `CritImpactSoundID_1` INT NOT NULL DEFAULT '0', `CritImpactSoundID_2` INT NOT NULL DEFAULT '0', `CritImpactSoundID_3` INT NOT NULL DEFAULT '0', `CritImpactSoundID_4` INT NOT NULL DEFAULT '0', `CritImpactSoundID_5` INT NOT NULL DEFAULT '0', `CritImpactSoundID_6` INT NOT NULL DEFAULT '0', `CritImpactSoundID_7` INT NOT NULL DEFAULT '0', `CritImpactSoundID_8` INT NOT NULL DEFAULT '0', `CritImpactSoundID_9` INT NOT NULL DEFAULT '0', `CritImpactSoundID_10` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `WeaponImpactSounds` VALUES (1,0,1,171,173,175,3263,3262,1002,1001,3202,3206,3210,172,174,176,3263,3262,1002,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (2,1,1,157,159,161,3263,3262,998,997,3204,3208,0,158,160,162,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (3,2,0,143,145,147,3263,3262,0,0,0,0,0,144,146,148,3263,3262,0,0,0,0,0); 
INSERT INTO `WeaponImpactSounds` VALUES (4,3,0,143,145,147,3263,3262,0,0,0,0,0,144,146,148,3263,3262,0,0,0,0,0); 
INSERT INTO `WeaponImpactSounds` VALUES (5,4,0,941,939,945,3263,3262,1000,999,3202,3206,3210,942,940,946,3263,3262,1000,999,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (6,5,0,955,953,959,3263,3262,996,995,3204,3208,1211,956,954,960,3263,3262,996,995,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (7,6,0,955,953,959,3263,3262,996,996,3204,3208,1211,956,954,960,3263,3262,996,996,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (8,7,1,143,145,147,3263,3262,1002,1001,3202,3206,3210,144,146,148,3263,3262,1002,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (9,8,1,129,131,133,3263,3262,998,997,3204,3208,1211,130,132,134,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (10,10,0,941,939,945,3263,3262,1000,999,3204,3208,1211,942,940,946,3263,3262,1000,999,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (11,11,0,143,145,147,3263,3262,1000,999,3202,3206,3210,144,146,148,3263,3262,1000,999,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (12,12,0,143,145,147,3263,3262,996,995,3204,3208,1211,144,146,148,3263,3262,996,995,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (13,13,0,1014,1014,1014,3263,3262,1019,1020,3202,3206,3210,1014,1014,1014,3263,3262,1019,1020,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (14,4,1,969,967,973,3263,3262,1002,1001,3202,3206,3210,970,968,974,3263,3262,1002,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (15,5,1,983,981,987,3263,3262,998,997,3204,3208,1211,984,982,988,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (16,6,1,129,131,133,3263,3262,998,997,3204,3208,1211,130,132,134,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (17,7,0,143,145,147,3263,3262,1000,999,3202,3206,3210,144,146,148,3263,3262,1000,999,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (18,8,0,129,131,133,3263,3262,996,995,3204,3208,1211,130,132,134,3263,3262,996,995,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (21,15,1,1151,1149,1155,3263,3262,1002,1001,3202,3206,3210,1152,1150,1156,3263,3262,0,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (22,15,0,1151,1149,1155,3263,3262,1002,1001,3202,3206,3210,1152,1150,1156,3263,3262,0,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (23,10,1,969,967,973,3263,3262,1002,1001,3204,3208,1211,970,968,974,3263,3262,1002,1001,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (24,1,0,157,159,161,3263,3262,998,997,3204,3208,1211,158,160,162,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (25,0,0,171,173,175,3263,3262,1002,1001,3202,3206,3210,172,174,176,3263,3262,1002,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (26,14,0,941,939,945,3263,3262,1000,999,3202,3206,3210,942,940,946,3263,3262,1000,999,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (27,14,1,969,967,973,3263,3262,1002,1001,3202,3206,3210,970,968,974,3263,3262,1002,1001,3203,3207,3210); 
INSERT INTO `WeaponImpactSounds` VALUES (28,20,0,941,939,945,3263,3262,1000,999,3204,3208,3210,942,940,946,3263,3262,1000,999,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (29,20,1,969,967,973,3263,3262,1002,1001,3204,3208,1211,970,968,974,3263,3262,1002,1001,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (68,17,0,955,953,959,3263,3262,996,996,3204,3208,1211,956,954,960,3263,3262,996,996,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (69,17,1,129,131,133,3263,3262,998,997,3204,3208,1211,130,132,134,3263,3262,998,997,3205,3209,1211); 
INSERT INTO `WeaponImpactSounds` VALUES (88,13,1,1014,1014,1014,3263,3262,1019,1019,3202,3206,3210,1014,1014,1014,3263,3262,1019,1019,3203,3207,3210); 