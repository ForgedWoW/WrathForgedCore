DROP TABLE IF EXISTS `MovieVariation`; 
CREATE TABLE `MovieVariation` ( `ID` INT NOT NULL DEFAULT '0', `MovieID` INT NOT NULL DEFAULT '0', `FileDataID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `MovieVariation` VALUES (3,2,2); 
INSERT INTO `MovieVariation` VALUES (4,2,22); 
INSERT INTO `MovieVariation` VALUES (32,1,1); 
INSERT INTO `MovieVariation` VALUES (33,1,21); 
INSERT INTO `MovieVariation` VALUES (42,11,21); 
INSERT INTO `MovieVariation` VALUES (43,13,21); 
INSERT INTO `MovieVariation` VALUES (61,14,220063); 
INSERT INTO `MovieVariation` VALUES (62,14,220062); 
INSERT INTO `MovieVariation` VALUES (103,16,356943); 
INSERT INTO `MovieVariation` VALUES (104,16,356944); 
