DROP TABLE IF EXISTS `PageTextMaterial`; 
CREATE TABLE `PageTextMaterial` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `PageTextMaterial` VALUES (1,"Parchment"),
(2,"Stone"),
(3,"Marble"),
(4,"Silver"),
(5,"Bronze"),
(6,"Valentine"),
(7,"Illidan"); 
