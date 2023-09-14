DROP TABLE IF EXISTS `AttackAnimTypes`; 
CREATE TABLE `AttackAnimTypes` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `AttackAnimTypes` VALUES (1,"1H_Main_Swing"); 
INSERT INTO `AttackAnimTypes` VALUES (2,"1H_Main_Pierce"); 
INSERT INTO `AttackAnimTypes` VALUES (3,"2HL_Pierce"); 
INSERT INTO `AttackAnimTypes` VALUES (4,"2HL_Swing"); 
INSERT INTO `AttackAnimTypes` VALUES (5,"2HT_Swing"); 
INSERT INTO `AttackAnimTypes` VALUES (7,"OffH_Swing"); 
INSERT INTO `AttackAnimTypes` VALUES (8,"OffH_Pierce"); 
