DROP TABLE IF EXISTS `ItemSubClassMask`; 
CREATE TABLE `ItemSubClassMask` ( `ID` INT NOT NULL DEFAULT '0', `ClassID` INT NOT NULL DEFAULT '0', `Mask` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ItemSubClassMask` VALUES (1,2,173555,"Melee Weapon","","","","","","","","","","","","","","","",16712190),
(2,4,96,"Shield","","","","","","","","","","","","","","","",16712190),
(3,2,262156,"Ranged Weapon","","","","","","","","","","","","","","","",16712190),
(4,2,41105,"One-Handed Melee Weapon","","","","","","","","","","","","","","","",16712190); 
