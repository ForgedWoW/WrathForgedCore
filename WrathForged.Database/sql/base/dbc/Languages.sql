DROP TABLE IF EXISTS `Languages`; 
CREATE TABLE `Languages` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Languages` VALUES (1,"Orcish","","","","","","","","","","","","","","","",16712190),
(2,"Darnassian","","","","","","","","","","","","","","","",16712190),
(3,"Taurahe","","","","","","","","","","","","","","","",16712190),
(6,"Dwarvish","","","","","","","","","","","","","","","",16712190),
(7,"Common","","","","","","","","","","","","","","","",16712190),
(8,"Demonic","","","","","","","","","","","","","","","",16712190),
(9,"Titan","","","","","","","","","","","","","","","",16712190),
(10,"Thalassian","","","","","","","","","","","","","","","",16712190),
(11,"Draconic","","","","","","","","","","","","","","","",16712190),
(12,"Kalimag","","","","","","","","","","","","","","","",16712190),
(13,"Gnomish","","","","","","","","","","","","","","","",16716286),
(14,"Troll","","","","","","","","","","","","","","","",16712191),
(33,"Gutterspeak","","","","","","","","","","","","","","","",16712190),
(35,"Draenei","","","","","","","","","","","","","","","",16712190),
(36,"Zombie","","","","","","","","","","","","","","","",117437950),
(37,"Gnomish Binary","","","","","","","","","","","","","","","",16771070),
(38,"Goblin Binary","","","","","","","","","","","","","","","",16712190); 
