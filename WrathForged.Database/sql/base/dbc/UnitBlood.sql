DROP TABLE IF EXISTS `UnitBlood`; 
CREATE TABLE `UnitBlood` ( `ID` INT NOT NULL DEFAULT '0', `CombatBloodSpurtFront_1` INT NOT NULL DEFAULT '0', `CombatBloodSpurtFront_2` INT NOT NULL DEFAULT '0', `CombatBloodSpurtBack_1` INT NOT NULL DEFAULT '0', `CombatBloodSpurtBack_2` INT NOT NULL DEFAULT '0', `GroundBlood_1` TEXT NULL, `GroundBlood_2` TEXT NULL, `GroundBlood_3` TEXT NULL, `GroundBlood_4` TEXT NULL, `GroundBlood_5` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `UnitBlood` VALUES (1,109,164,534,55,"textures\BloodSplats\BloodSplatRed01","textures\BloodSplats\BloodSplatRed02","textures\BloodSplats\BloodSplatRed03","textures\BloodSplats\BloodSplatRed04",""),
(2,183,184,535,537,"textures\BloodSplats\BloodSplatGreen01","textures\BloodSplats\BloodSplatGreen02","textures\BloodSplats\BloodSplatGreen03","textures\BloodSplats\BloodSplatGreen04",""),
(3,532,533,536,538,"textures\BloodSplats\BloodSplatBlack01","textures\BloodSplats\BloodSplatBlack02","textures\BloodSplats\BloodSplatBlack03","textures\BloodSplats\BloodSplatBlack04",""),
(4,3219,3086,3224,3165,"","","","",""); 
