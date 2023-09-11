DROP TABLE IF EXISTS `DungeonMap`; 
CREATE TABLE `DungeonMap` ( `ID` INT NOT NULL DEFAULT '0', `MapID` INT NOT NULL DEFAULT '0', `FloorIndex` INT NOT NULL DEFAULT '0', `MinX` FLOAT NOT NULL DEFAULT '0', `MaxX` FLOAT NOT NULL DEFAULT '0', `MinY` FLOAT NOT NULL DEFAULT '0', `MaxY` FLOAT NOT NULL DEFAULT '0', `ParentWorldMapID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `DungeonMap` VALUES (31,0,1,-510,424,-40.3333,582.333,0); 
INSERT INTO `DungeonMap` VALUES (44,0,1,0,0,0,0,0); 
INSERT INTO `DungeonMap` VALUES (28,43,1,-410.946,595.529,-483.479,187.504,0); 
INSERT INTO `DungeonMap` VALUES (56,533,1,-3734.1,-2640.27,2886.61,3615.83,488); 
INSERT INTO `DungeonMap` VALUES (57,533,2,-4234.1,-3140.27,2886.61,3615.83,488); 
INSERT INTO `DungeonMap` VALUES (58,533,3,-3787,-2587,2336,3136,488); 
INSERT INTO `DungeonMap` VALUES (59,533,4,-4287.35,-3087.02,2336.61,3136.83,488); 
INSERT INTO `DungeonMap` VALUES (60,533,5,-4400.09,-2330.28,2311.34,3691.22,488); 
INSERT INTO `DungeonMap` VALUES (73,533,6,-5522.29,-4866.35,3379.25,3816.54,488); 
INSERT INTO `DungeonMap` VALUES (27,571,1,222.495,1052.51,5513.33,6066.67,495); 
INSERT INTO `DungeonMap` VALUES (26,571,2,352.646,915.87,5599.85,5975.34,495); 
INSERT INTO `DungeonMap` VALUES (1,574,1,-310.406,424.175,25.6665,515.388,491); 
INSERT INTO `DungeonMap` VALUES (2,574,2,-238.156,242.925,-16.3333,304.387,491); 
INSERT INTO `DungeonMap` VALUES (41,574,3,-510.906,225.675,-75.3335,415.721,491); 
INSERT INTO `DungeonMap` VALUES (39,575,1,-697.559,-148.623,186.92,552.877,491); 
INSERT INTO `DungeonMap` VALUES (40,575,2,-747.558,8.62196,157.839,661.958,491); 
INSERT INTO `DungeonMap` VALUES (25,576,1,-708.069,393.212,64.0755,798.263,486); 
INSERT INTO `DungeonMap` VALUES (42,578,1,787.253,1301.96,877.071,1220.21,486); 
INSERT INTO `DungeonMap` VALUES (43,578,2,712.253,1376.96,927.071,1370.21,486); 
INSERT INTO `DungeonMap` VALUES (45,578,3,787.253,1301.96,927.071,1270.21,486); 
INSERT INTO `DungeonMap` VALUES (46,578,4,897.259,1191.96,990.406,1186.87,486); 
INSERT INTO `DungeonMap` VALUES (34,595,1,731.06,1856.36,1891.76,2641.96,161); 
INSERT INTO `DungeonMap` VALUES (53,599,1,206.324,1126.52,762.444,1375.91,495); 
INSERT INTO `DungeonMap` VALUES (37,600,1,-927.01,-307.069,-595.86,-182.566,496); 
INSERT INTO `DungeonMap` VALUES (38,600,2,-1002.01,-382.069,-595.86,-182.566,496); 
INSERT INTO `DungeonMap` VALUES (47,601,1,-30,722.974,292.142,794.125,488); 
INSERT INTO `DungeonMap` VALUES (48,601,2,400,692.974,450.474,645.79,488); 
INSERT INTO `DungeonMap` VALUES (49,601,3,462.125,829.625,395,640,488); 
INSERT INTO `DungeonMap` VALUES (54,602,1,-282.549,283.686,1157.05,1534.54,495); 
INSERT INTO `DungeonMap` VALUES (55,602,2,-538.549,169.688,959.72,1431.88,495); 
INSERT INTO `DungeonMap` VALUES (69,603,1,-445.235,224.216,1392.71,1839.01,495); 
INSERT INTO `DungeonMap` VALUES (70,603,2,-674.74,653.721,1679.04,2564.68,495); 
INSERT INTO `DungeonMap` VALUES (71,603,3,-315.75,594.75,1612,2219,495); 
INSERT INTO `DungeonMap` VALUES (72,603,4,1684.99,3254.45,2122.53,3168.83,495); 
INSERT INTO `DungeonMap` VALUES (98,603,5,-310.014,309.455,1834.77,2247.75,495); 
INSERT INTO `DungeonMap` VALUES (36,604,1,259.887,1164.92,1465.52,2068.87,496); 
INSERT INTO `DungeonMap` VALUES (52,608,1,665.347,921.576,1813.35,1984.17,504); 
INSERT INTO `DungeonMap` VALUES (61,616,1,1036.71,1466.78,611.128,897.841,486); 
INSERT INTO `DungeonMap` VALUES (50,619,1,-1205.72,-233.302,200.405,848.684,488); 
INSERT INTO `DungeonMap` VALUES (63,624,1,-812.519,585.736,-634.08,298.09,501); 
INSERT INTO `DungeonMap` VALUES (103,631,1,1384.33,2739.8,-764.84,138.807,492); 
INSERT INTO `DungeonMap` VALUES (104,631,2,1631,2698,-754.667,-43.3333,492); 
INSERT INTO `DungeonMap` VALUES (105,631,3,2116.33,2311.8,-580.313,-449.998,492); 
INSERT INTO `DungeonMap` VALUES (106,631,4,1993.57,2767.28,4012.41,4528.22,492); 
INSERT INTO `DungeonMap` VALUES (107,631,5,2216.06,3364.8,4002.41,4768.23,492); 
INSERT INTO `DungeonMap` VALUES (108,631,6,2586.57,2960.28,4455.75,4704.88,492); 
INSERT INTO `DungeonMap` VALUES (109,631,7,-2271.55,-1978.29,410.292,605.799,492); 
INSERT INTO `DungeonMap` VALUES (110,631,8,-2648.26,-2400.33,414.108,579.396,492); 
INSERT INTO `DungeonMap` VALUES (101,632,1,1686.03,3134.13,4814.53,5779.93,492); 
INSERT INTO `DungeonMap` VALUES (94,649,1,-41.2552,328.731,446.361,693.019,492); 
INSERT INTO `DungeonMap` VALUES (100,649,1,-41.2552,328.731,446.361,693.019,492); 
INSERT INTO `DungeonMap` VALUES (95,649,2,-211.26,528.736,433.024,926.354,492); 
INSERT INTO `DungeonMap` VALUES (96,650,1,437.4236,807.4098,629.4479,876.1059,492); 
INSERT INTO `DungeonMap` VALUES (99,650,1,437.424,807.41,629.448,876.106,492); 
INSERT INTO `DungeonMap` VALUES (102,668,1,1469.99,2349.01,5126.99,5713.01,492); 
