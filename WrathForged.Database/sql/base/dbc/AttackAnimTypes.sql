DROP TABLE IF EXISTS `AttackAnimTypes`; 
CREATE TABLE `AttackAnimTypes` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `AttackAnimTypes` VALUES (1,"1H_Main_Swing"),
(2,"1H_Main_Pierce"),
(3,"2HL_Pierce"),
(4,"2HL_Swing"),
(5,"2HT_Swing"),
(7,"OffH_Swing"),
(8,"OffH_Pierce"); 
