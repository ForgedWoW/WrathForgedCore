DROP TABLE IF EXISTS `SpellMissile`; 
CREATE TABLE `SpellMissile` ( `ID` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', `DefaultPitchMin` FLOAT NOT NULL DEFAULT '0', `DefaultPitchMax` FLOAT NOT NULL DEFAULT '0', `DefaultSpeedMin` FLOAT NOT NULL DEFAULT '0', `DefaultSpeedMax` FLOAT NOT NULL DEFAULT '0', `RandomizeFacingMin` FLOAT NOT NULL DEFAULT '0', `RandomizeFacingMax` FLOAT NOT NULL DEFAULT '0', `RandomizePitchMin` FLOAT NOT NULL DEFAULT '0', `RandomizePitchMax` FLOAT NOT NULL DEFAULT '0', `RandomizeSpeedMin` FLOAT NOT NULL DEFAULT '0', `RandomizeSpeedMax` FLOAT NOT NULL DEFAULT '0', `Gravity` FLOAT NOT NULL DEFAULT '0', `MaxDuration` FLOAT NOT NULL DEFAULT '0', `CollisionRadius` FLOAT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellMissile` VALUES (61,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(121,1,0.698132,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(161,1,0.698132,0.872665,10,120,0,0,0,0,-5,5,19.29,0,0),
(181,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(221,1,-0.261799,0.785398,10,120,0,0,0,0,0,0,19.29,0,0),
(222,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(241,1,0.349066,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(261,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(281,1,0.698132,0.872665,50,50,0,0,0,0,0,0,19.29,0,0),
(301,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(361,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(381,1,0.698132,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(382,1,0.698132,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(441,1,-0.436332,-2.094395,10,120,0,0,0,0,0,0,19.29,5,0),
(463,1,-0.261799,0.698132,35,40,0,0,0,0,0,0,19.29,0,0),
(481,1,-0.261799,1.570796,45,45,0,0,0,0,0,0,30,0,0),
(501,1,0.698132,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(502,1,0.523599,1.308997,10,120,0,0,0,0,0,0,19.29,0,0),
(526,1,0.523599,1.570796,65,65,0,0,0,0,0,0,30,0,0),
(561,1,-0.261799,1.570796,65,65,0,0,0,0,0,0,30,0,0),
(581,1,0,0,50,50,0,0,0,0,0,0,0,4,0),
(582,1,-0.523599,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(602,1,0.523599,0.523599,7,28,0,0,0,0,0,0,19.29,0,0),
(603,1,0.349066,0.523599,10,16,0.087266,0.174533,0.349066,0.523599,20,50,19.29,0,0),
(621,1,0.785398,0.785398,22,22,0,0,0,0,0,0,19.29,3,0),
(623,1,0.698132,0.872665,10,120,0,0,0,0,0,0,19.29,0,0),
(625,1,0,0,30,40,0,0,0,0,0,0,0,2,0),
(626,1,0,0.698132,20,30,0.523599,-0.523599,-0.174533,0.174533,0,0,-4.9,2,0),
(642,1,-0.261799,1.570796,60,60,0,0,0,0,0,0,30,0,0),
(661,1,0.698132,0.872665,60,70,0,0,0,0,0,0,19.29,0,0),
(701,1,-0.785398,-0.785398,0,40,0,0,0,0,0,0,9.8,0,0),
(762,1,0.785398,0.785398,0,40,0,0,0,0,0,0,19.29,0,0),
(763,63,0.698132,1.396263,10,120,-0.022689,0.022689,-0.017453,0.017453,-10,10,19.28,0,0),
(764,1,-0.349066,1.570796,50,55.48,0,0.017453,0,0,0,0,6.29,0,0),
(766,1,0.349066,0.349066,30,30,0,0,0,0,0,0,19.29,0,0),
(781,1,-0.349066,1.570796,50,55.48,0,0.017453,0,0,0,0,6.29,0,0),
(841,1,0.785398,0.785398,19,19,0,0,0,0,0,0,19.29,0,0),
(862,1,-0.785398,0.174533,80,80,0,0,0,0,0,0,19.29,0,0),
(903,1,0,0,50,55.48,0,0,0,0,0,0,9.29,0,0),
(923,1,-0.785398,0.174533,80,80,0,0,0,0,0,0,19.29,0,0),
(944,17,0,0,75,75,0,0,0,0,0,0,0,3,12),
(945,1,0.261799,0.261799,60,60,0,0,0,0,0,0,19.29,0,0),
(982,1,0,0.523599,30,40,0,0,0,0,0,0,9,0,0),
(1002,1,-0.698132,-1.047198,30,40,0,0,0,0,0,0,19.29,0,0),
(1003,1,0,0.872665,15,20,0,0,0,0,0,0,19.29,0,0),
(1004,1,0,0.872665,15,20,0,0,0,0,0,0,19.29,0,0),
(1005,1,0.698132,0.872665,60,70,0,0,0,0,0,0,19.29,0,0),
(1006,1,0,0,100,100,0,0,0,0,0,0,0,1.5,0),
(1007,1,0,0,50,50,0,0,0,0,0,0,0,1.2,0),
(1022,1,-0.261799,1.570796,45,45,0,0,0,0,0,0,30,0,0),
(1023,1,-0.261799,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(1024,1,0.523599,1.570796,65,65,0,0,0,0,0,0,30,0,0),
(1062,1,0,0,30,30,0,0,0,0,0,0,25.29,90,0),
(1102,1,0,0,90,90,0,0,0,0,0,0,0,1.5,0),
(1162,1,0,0,50,55.48,0,0,0,0,0,0,5,6,0),
(1182,1,0,0,90,90,0,0,0,0,0,0,0,1.5,0),
(1222,1,0.698132,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(1263,1,0,0,30,30,0,0,0,0,0,0,0,1,0),
(1264,1,0,0,30,30,0,0,0,0,0,0,0,1,0),
(1265,1,0,0,30,30,0,0,0,0,0,0,0,1,0),
(1266,1,0,0,30,30,0,0,0,0,0,0,0,1,0),
(1267,1,0,0,30,30,0,0,0,0,0,0,0,1,0),
(1342,19,0.523599,1.570796,25,90,0,0,0,0,0,0,19.29,0,0),
(1364,17,-0.261799,1.047198,65,65,0,0,0,0,0,0,40,0,5),
(1365,17,-0.523599,1.047198,120,120,0,0,-0.191986,-0.191986,0,0,0,2,5),
(1372,1,0.872665,0.872665,30,40,0,0,0,0,0,0,19.29,0,0),
(1382,1,0.523599,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(1402,17,0.523599,1.570796,65,65,0,0,0,0,0,0,30,0,0),
(1422,17,0,1.570796,20,90,0,0,-0.087266,-0.087266,0,0,19,0,3),
(1442,1,0.087266,0.087266,90,90,0,0,0,0,0,0,80,0,0),
(1482,1,-0.261799,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(1522,17,0,0,75,75,0,0,0,0,0,0,0,1.15,4),
(1523,17,0,0,100,100,0,0,0,0,0,0,0,1,4),
(1662,1,0.523599,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(1682,17,0.523599,1.570796,65,65,0,0,0,0,0,0,30,0,0),
(1702,17,-0.523599,1.047198,120,120,0,0,-0.191986,-0.191986,0,0,0,2,5),
(1802,1,-0.261799,1.570796,60,60,0,0,0,0,0,0,30,0,0),
(1824,3,0.698132,0.872665,60,60,0,0,0,0,0,0,19.4,0,0),
(1863,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(1882,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(1902,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(1922,1,-0.261799,0.785398,35,45,0,0,0,0,0,0,19.29,0,0),
(1962,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(1982,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(2022,1,-0.261799,1.570796,60,60,0,0,0,0,0,0,30,0,0),
(2023,1,-0.261799,0.785398,35,45,0,0,0,0,0,0,19.29,0,0),
(2024,1,-0.261799,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(2042,1,-0.261799,1.570796,60,60,0,0,0,0,0,0,30,0,0),
(2062,1,-0.261799,0.785398,35,45,0,0,0,0,0,0,19.29,0,0),
(2063,1,-0.261799,0.785398,35,45,0,0,0,0,0,0,19.29,0,0),
(2162,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2163,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(2164,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(2165,1,0.872665,0.872665,65,65,0,0,0,0,0,0,19.29,0,0),
(2166,1,-0.261799,1.570796,60,60,0,0,0,0,0,0,30,0,0),
(2264,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2342,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2362,1,-0.261799,1.047198,65,65,0,0,0,0,0,0,40,0,0),
(2503,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2674,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2675,1,-0.261799,1.570796,90,90,0,0,0,0,0,0,30,0,0),
(2694,1,0,1.570796,30,40,0,0,0,0,0,0,19.29,0,0),
(2702,17,0.523599,0.523599,120,120,0,0,0,0,0,0,1,0.5,4),
(2704,1,0.698132,0.872665,120,120,0,0,0,0,0,0,19.29,0,0),
(2706,1,-0.349066,0.872665,30,40,0,0,0,0,0,0,19.29,0,0); 
