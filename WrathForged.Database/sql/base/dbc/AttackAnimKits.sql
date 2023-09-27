DROP TABLE IF EXISTS `AttackAnimKits`; 
CREATE TABLE `AttackAnimKits` ( `ID` INT NOT NULL DEFAULT '0', `Animation` INT NOT NULL DEFAULT '0', `Type` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', `Field04` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `AttackAnimKits` VALUES (1,0,1,1,0),
(2,1,5,1,0),
(3,4,1,1,0),
(4,5,5,1,0),
(5,6,3,1,0),
(6,6,4,1,0),
(7,7,1,4,0),
(8,7,2,1,0),
(9,8,5,1,0),
(10,10,4,4,0),
(11,11,1,1,0),
(12,11,2,1,0),
(13,12,5,2,0),
(14,0,7,1,1),
(15,4,7,1,1),
(16,7,7,1,1),
(17,11,7,1,1),
(18,11,8,1,1),
(19,7,8,4,1),
(21,10,3,1,0),
(22,15,2,1,0),
(23,15,8,1,1),
(24,15,1,1,0),
(25,15,7,1,1),
(26,14,1,1,0),
(27,14,7,1,1); 
