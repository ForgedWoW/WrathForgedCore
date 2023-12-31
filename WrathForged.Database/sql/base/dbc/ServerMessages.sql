DROP TABLE IF EXISTS `ServerMessages`; 
CREATE TABLE `ServerMessages` ( `ID` INT NOT NULL DEFAULT '0', `Text_Lang_enUS` TEXT NULL, `Text_Lang_enGB` TEXT NULL, `Text_Lang_koKR` TEXT NULL, `Text_Lang_frFR` TEXT NULL, `Text_Lang_deDE` TEXT NULL, `Text_Lang_enCN` TEXT NULL, `Text_Lang_zhCN` TEXT NULL, `Text_Lang_enTW` TEXT NULL, `Text_Lang_zhTW` TEXT NULL, `Text_Lang_esES` TEXT NULL, `Text_Lang_esMX` TEXT NULL, `Text_Lang_ruRU` TEXT NULL, `Text_Lang_ptPT` TEXT NULL, `Text_Lang_ptBR` TEXT NULL, `Text_Lang_itIT` TEXT NULL, `Text_Lang_Unk` TEXT NULL, `Text_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ServerMessages` VALUES (1,"[SERVER] Shutdown in %s","","","","","","","","","","","","","","","",16712190),
(2,"[SERVER] Restart in %s","","","","","","","","","","","","","","","",16712190),
(3,"%s","","","","","","","","","","","","","","","",16712190),
(4,"[SERVER] Shutdown cancelled","","","","","","","","","","","","","","","",16712190),
(5,"[SERVER] Restart cancelled","","","","","","","","","","","","","","","",16712190),
(6,"[SERVER] Battleground shutdown in %s","","","","","","","","","","","","","","","",16712190),
(7,"[SERVER] Battleground restart in %s","","","","","","","","","","","","","","","",16712190),
(8,"[SERVER] Instance shutdown in %s","","","","","","","","","","","","","","","",16712190),
(9,"[SERVER] Instance restart in %s","","","","","","","","","","","","","","","",16712190); 
