DROP TABLE IF EXISTS `PetitionType`; 
CREATE TABLE `PetitionType` ( `ID` INT NOT NULL DEFAULT '0', `RefName` INT NOT NULL DEFAULT '0', `Field02` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `PetitionType` VALUES (0,1,1); 
INSERT INTO `PetitionType` VALUES (1,7,3); 