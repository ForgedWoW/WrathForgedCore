DROP TABLE IF EXISTS `SkillTiers`; 
CREATE TABLE `SkillTiers` ( `ID` INT NOT NULL DEFAULT '0', `Cost_1` INT NOT NULL DEFAULT '0', `Cost_2` INT NOT NULL DEFAULT '0', `Cost_3` INT NOT NULL DEFAULT '0', `Cost_4` INT NOT NULL DEFAULT '0', `Cost_5` INT NOT NULL DEFAULT '0', `Cost_6` INT NOT NULL DEFAULT '0', `Cost_7` INT NOT NULL DEFAULT '0', `Cost_8` INT NOT NULL DEFAULT '0', `Cost_9` INT NOT NULL DEFAULT '0', `Cost_10` INT NOT NULL DEFAULT '0', `Cost_11` INT NOT NULL DEFAULT '0', `Cost_12` INT NOT NULL DEFAULT '0', `Cost_13` INT NOT NULL DEFAULT '0', `Cost_14` INT NOT NULL DEFAULT '0', `Cost_15` INT NOT NULL DEFAULT '0', `Cost_16` INT NOT NULL DEFAULT '0', `Value_1` INT NOT NULL DEFAULT '0', `Value_2` INT NOT NULL DEFAULT '0', `Value_3` INT NOT NULL DEFAULT '0', `Value_4` INT NOT NULL DEFAULT '0', `Value_5` INT NOT NULL DEFAULT '0', `Value_6` INT NOT NULL DEFAULT '0', `Value_7` INT NOT NULL DEFAULT '0', `Value_8` INT NOT NULL DEFAULT '0', `Value_9` INT NOT NULL DEFAULT '0', `Value_10` INT NOT NULL DEFAULT '0', `Value_11` INT NOT NULL DEFAULT '0', `Value_12` INT NOT NULL DEFAULT '0', `Value_13` INT NOT NULL DEFAULT '0', `Value_14` INT NOT NULL DEFAULT '0', `Value_15` INT NOT NULL DEFAULT '0', `Value_16` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SkillTiers` VALUES (2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(21,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,300,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(22,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(23,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(24,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(41,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(61,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(62,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(63,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(81,100,400,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,0,0,0,0,0,0,0,0,0,0,0,0,0),
(121,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(122,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(123,75,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(124,15,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(125,200,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(126,60,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(127,25,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(141,120,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(142,180,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(143,60,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(161,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,375,450,0,0,0,0,0,0,0,0,0,0),
(181,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,300,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(182,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,300,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(221,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(222,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),
(223,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,75,150,225,300,0,0,0,0,0,0,0,0,0,0,0,0); 
