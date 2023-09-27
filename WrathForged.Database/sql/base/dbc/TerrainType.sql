DROP TABLE IF EXISTS `Terraintype`; 
CREATE TABLE `Terraintype` ( `ID` INT NOT NULL DEFAULT '0', `TerrainID` INT NOT NULL DEFAULT '0', `TerrainDesc` TEXT NULL, `FootstepSprayRun` INT NOT NULL DEFAULT '0', `FootstepSprayWalk` INT NOT NULL DEFAULT '0', `SoundID` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Terraintype` VALUES (1,0,"Dirt",0,0,1,0),
(2,1,"Metallic",0,0,2,0),
(3,2,"Stone",0,0,3,0),
(4,3,"Snow",11,12,4,1),
(5,4,"Wood",0,0,5,0),
(6,5,"Grass",0,0,6,0),
(7,6,"Leaves",0,0,7,0),
(8,7,"Sand",0,0,8,1),
(9,8,"Soggy",0,0,9,0),
(10,9,"DustyGrass",0,0,6,0),
(11,10,"None",0,0,0,0),
(12,11,"Water",0,0,10,0); 
