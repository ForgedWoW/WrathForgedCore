DROP TABLE IF EXISTS `WorldMapTransforms`; 
CREATE TABLE `WorldMapTransforms` ( `ID` INT NOT NULL DEFAULT '0', `MapID` INT NOT NULL DEFAULT '0', `RegionMinX` FLOAT NOT NULL DEFAULT '0', `RegionMinY` FLOAT NOT NULL DEFAULT '0', `RegionMaxX` FLOAT NOT NULL DEFAULT '0', `RegionMaxY` FLOAT NOT NULL DEFAULT '0', `NewMapID` INT NOT NULL DEFAULT '0', `RegionOffsetX` FLOAT NOT NULL DEFAULT '0', `RegionOffsetY` FLOAT NOT NULL DEFAULT '0', `NewDungeonMapID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `WorldMapTransforms` VALUES (2,530,4800,-10133.33,16000,-2666.667,0,-2400,2400,0),
(3,530,-6933.333,-16000,533.3333,-8000,1,10133.33,17600,0),
(4,600,-20000,-20000,20000,20000,600,0,0,37),
(5,603,2113,-220,2530,1336,603,0,0,70),
(6,619,-20000,-20000,20000,20000,619,0,0,50),
(7,603,1940,1335,2530,2718,603,0,0,72),
(8,602,1408,10,1454,67,602,0,0,54),
(9,616,-20000,-20000,20000,20000,616,0,0,61),
(10,631,-20000,-20000,20000,20000,631,0,0,104); 
