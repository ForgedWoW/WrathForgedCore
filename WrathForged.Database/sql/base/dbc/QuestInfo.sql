DROP TABLE IF EXISTS `QuestInfo`; 
CREATE TABLE `QuestInfo` ( `ID` INT NOT NULL DEFAULT '0', `InfoName_Lang_enUS` TEXT NULL, `InfoName_Lang_enGB` TEXT NULL, `InfoName_Lang_koKR` TEXT NULL, `InfoName_Lang_frFR` TEXT NULL, `InfoName_Lang_deDE` TEXT NULL, `InfoName_Lang_enCN` TEXT NULL, `InfoName_Lang_zhCN` TEXT NULL, `InfoName_Lang_enTW` TEXT NULL, `InfoName_Lang_zhTW` TEXT NULL, `InfoName_Lang_esES` TEXT NULL, `InfoName_Lang_esMX` TEXT NULL, `InfoName_Lang_ruRU` TEXT NULL, `InfoName_Lang_ptPT` TEXT NULL, `InfoName_Lang_ptBR` TEXT NULL, `InfoName_Lang_itIT` TEXT NULL, `InfoName_Lang_Unk` TEXT NULL, `InfoName_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `QuestInfo` VALUES (1,"Group","","","","","","","","","","","","","","","",16712190),
(21,"Life","","","","","","","","","","","","","","","",16712190),
(41,"PvP","","","","","","","","","","","","","","","",16712190),
(62,"Raid","","","","","","","","","","","","","","","",16712190),
(81,"Dungeon","","","","","","","","","","","","","","","",16712190),
(82,"World Event","","","","","","","","","","","","","","","",16712190),
(83,"Legendary","","","","","","","","","","","","","","","",16712190),
(84,"Escort","","","","","","","","","","","","","","","",16712190),
(85,"Heroic","","","","","","","","","","","","","","","",16712190),
(88,"Raid (10)","","","","","","","","","","","","","","","",16712190),
(89,"Raid (25)","","","","","","","","","","","","","","","",16712190); 
