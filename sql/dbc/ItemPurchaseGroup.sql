DROP TABLE IF EXISTS `ItemPurchaseGroup`; 
CREATE TABLE `ItemPurchaseGroup` ( `ID` INT NOT NULL DEFAULT '0', `ItemID_1` INT NOT NULL DEFAULT '0', `ItemID_2` INT NOT NULL DEFAULT '0', `ItemID_3` INT NOT NULL DEFAULT '0', `ItemID_4` INT NOT NULL DEFAULT '0', `ItemID_5` INT NOT NULL DEFAULT '0', `ItemID_6` INT NOT NULL DEFAULT '0', `ItemID_7` INT NOT NULL DEFAULT '0', `ItemID_8` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ItemPurchaseGroup` VALUES (1,34529,34530,33006,0,0,0,0,0,"Vengeful Gladiator Ranged Weapon","","","","","","","","","","","","","","","",16712190); 
