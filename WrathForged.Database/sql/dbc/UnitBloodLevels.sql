DROP TABLE IF EXISTS `UnitBloodLevels`; 
CREATE TABLE `UnitBloodLevels` ( `ID` INT NOT NULL DEFAULT '0', `Violencelevel_1` INT NOT NULL DEFAULT '0', `Violencelevel_2` INT NOT NULL DEFAULT '0', `Violencelevel_3` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `UnitBloodLevels` VALUES (1,0,2,1); 
INSERT INTO `UnitBloodLevels` VALUES (2,0,2,2); 
INSERT INTO `UnitBloodLevels` VALUES (3,0,3,3); 
INSERT INTO `UnitBloodLevels` VALUES (4,0,4,4); 
