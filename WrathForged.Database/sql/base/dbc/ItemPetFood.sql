DROP TABLE IF EXISTS `ItemPetFood`; 
CREATE TABLE `ItemPetFood` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ItemPetFood` VALUES (1,"Meat","","","","","","","","","","","","","","","",16712190),
(2,"Fish","","","","","","","","","","","","","","","",16712190),
(3,"Cheese","","","","","","","","","","","","","","","",16712190),
(4,"Bread","","","","","","","","","","","","","","","",16712190),
(5,"Fungus","","","","","","","","","","","","","","","",16712190),
(6,"Fruit","","","","","","","","","","","","","","","",16712190),
(7,"Raw Meat","","","","","","","","","","","","","","","",16712190),
(8,"Raw Fish","","","","","","","","","","","","","","","",16712190); 
