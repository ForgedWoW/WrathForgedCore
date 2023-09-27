DROP TABLE IF EXISTS `Resistances`; 
CREATE TABLE `Resistances` ( `ID` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', `FizzleSoundID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Resistances` VALUES (0,1,0,"Physical","","","","","","","","","","","","","","","",16712190),
(1,0,1428,"Holy","","","","","","","","","","","","","","","",16712190),
(2,0,1424,"Fire","","","","","","","","","","","","","","","",16712190),
(3,0,1426,"Nature","","","","","","","","","","","","","","","",16712190),
(4,0,1425,"Frost","","","","","","","","","","","","","","","",16712190),
(5,0,1427,"Shadow","","","","","","","","","","","","","","","",16712190),
(6,0,1428,"Arcane","","","","","","","","","","","","","","","",16712190); 
