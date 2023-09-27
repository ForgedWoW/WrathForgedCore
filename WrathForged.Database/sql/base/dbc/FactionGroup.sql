DROP TABLE IF EXISTS `FactionGroup`; 
CREATE TABLE `FactionGroup` ( `ID` INT NOT NULL DEFAULT '0', `MaskID` INT NOT NULL DEFAULT '0', `InternalName` TEXT NULL, `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `FactionGroup` VALUES (1,0,"Player","","","","","","","","","","","","","","","","",16712188),
(2,1,"Alliance","Alliance","","","","","","","","","","","","","","","",16712190),
(3,2,"Horde","Horde","","","","","","","","","","","","","","","",16712190),
(4,3,"Monster","","","","","","","","","","","","","","","","",16712188); 
