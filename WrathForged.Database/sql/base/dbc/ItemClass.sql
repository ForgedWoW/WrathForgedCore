DROP TABLE IF EXISTS `ItemClass`; 
CREATE TABLE `ItemClass` ( `ID` INT NOT NULL DEFAULT '0', `ClassID` INT NOT NULL DEFAULT '0', `SubclassMapID` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', `ClassName_Lang_enUS` TEXT NULL, `ClassName_Lang_enGB` TEXT NULL, `ClassName_Lang_koKR` TEXT NULL, `ClassName_Lang_frFR` TEXT NULL, `ClassName_Lang_deDE` TEXT NULL, `ClassName_Lang_enCN` TEXT NULL, `ClassName_Lang_zhCN` TEXT NULL, `ClassName_Lang_enTW` TEXT NULL, `ClassName_Lang_zhTW` TEXT NULL, `ClassName_Lang_esES` TEXT NULL, `ClassName_Lang_esMX` TEXT NULL, `ClassName_Lang_ruRU` TEXT NULL, `ClassName_Lang_ptPT` TEXT NULL, `ClassName_Lang_ptBR` TEXT NULL, `ClassName_Lang_itIT` TEXT NULL, `ClassName_Lang_Unk` TEXT NULL, `ClassName_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ItemClass` VALUES (1,0,0,0,"Consumable","","","","","","","","","","","","","","","",16712190),
(2,1,1,0,"Container","","","","","","","","","","","","","","","",16712190),
(3,2,2,1,"Weapon","","","","","","","","","","","","","","","",16712190),
(4,3,3,0,"Gem","","","","","","","","","","","","","","","",16712190),
(5,4,4,0,"Armor","","","","","","","","","","","","","","","",16712190),
(6,5,5,0,"Reagent","","","","","","","","","","","","","","","",16712190),
(7,6,6,0,"Projectile","","","","","","","","","","","","","","","",16712190),
(8,7,7,0,"Trade Goods","","","","","","","","","","","","","","","",16712190),
(9,8,8,0,"Generic(OBSOLETE)","","","","","","","","","","","","","","","",16712190),
(10,9,9,0,"Recipe","","","","","","","","","","","","","","","",16712190),
(11,10,10,0,"Money","","","","","","","","","","","","","","","",16712190),
(12,11,6,0,"Quiver","","","","","","","","","","","","","","","",16712190),
(13,12,0,0,"Quest","","","","","","","","","","","","","","","",16712190),
(14,13,0,0,"Key","","","","","","","","","","","","","","","",16712190),
(15,14,1,0,"Permanent(OBSOLETE)","","","","","","","","","","","","","","","",16712190),
(16,15,0,0,"Miscellaneous","","","","","","","","","","","","","","","",16712190),
(17,16,12,0,"Glyph","","","","","","","","","","","","","","","",16712190); 
