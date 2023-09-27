DROP TABLE IF EXISTS `CreatureType`; 
CREATE TABLE `CreatureType` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `CreatureType` VALUES (1,"Beast","","","","","","","","","","","","","","","",16712190,0),
(2,"Dragonkin","","","","","","","","","","","","","","","",16712190,0),
(3,"Demon","","","","","","","","","","","","","","","",16712190,0),
(4,"Elemental","","","","","","","","","","","","","","","",16712190,0),
(5,"Giant","","","","","","","","","","","","","","","",16712190,0),
(6,"Undead","","","","","","","","","","","","","","","",16712190,0),
(7,"Humanoid","","","","","","","","","","","","","","","",16712190,0),
(8,"Critter","","","","","","","","","","","","","","","",16712190,1),
(9,"Mechanical","","","","","","","","","","","","","","","",16712190,0),
(10,"Not specified","","","","","","","","","","","","","","","",16712190,0),
(11,"Totem","","","","","","","","","","","","","","","",16712190,0),
(12,"Non-combat Pet","","","","","","","","","","","","","","","",16712190,1),
(13,"Gas Cloud","","","","","","","","","","","","","","","",16712190,1); 
