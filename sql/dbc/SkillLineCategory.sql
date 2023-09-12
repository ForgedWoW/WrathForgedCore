DROP TABLE IF EXISTS `SkillLineCategory`; 
CREATE TABLE `SkillLineCategory` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `SortIndex` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SkillLineCategory` VALUES (5,"Attributes","","","","","","","","","","","","","","","",16712190,1); 
INSERT INTO `SkillLineCategory` VALUES (6,"Weapon Skills","","","","","","","","","","","","","","","",16712190,5); 
INSERT INTO `SkillLineCategory` VALUES (7,"Class Skills","","","","","","","","","","","","","","","",16712190,2); 
INSERT INTO `SkillLineCategory` VALUES (8,"Armor Proficiencies","","","","","","","","","","","","","","","",16712190,6); 
INSERT INTO `SkillLineCategory` VALUES (9,"Secondary Skills","","","","","","","","","","","","","","","",16712190,4); 
INSERT INTO `SkillLineCategory` VALUES (10,"Languages","","","","","","","","","","","","","","","",16712190,7); 
INSERT INTO `SkillLineCategory` VALUES (11,"Professions","","","","","","","","","","","","","","","",16712190,3); 
INSERT INTO `SkillLineCategory` VALUES (12,"Not Displayed","","","","","","","","","","","","","","","",16712190,8); 