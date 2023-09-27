DROP TABLE IF EXISTS `WowError_Strings`; 
CREATE TABLE `WowError_Strings` ( `ID` INT NOT NULL DEFAULT '0', `ErrorName` TEXT NULL, `ErrorString_enUS` TEXT NULL, `ErrorString_enGB` TEXT NULL, `ErrorString_koKR` TEXT NULL, `ErrorString_frFR` TEXT NULL, `ErrorString_deDE` TEXT NULL, `ErrorString_enCN` TEXT NULL, `ErrorString_zhCN` TEXT NULL, `ErrorString_enTW` TEXT NULL, `ErrorString_zhTW` TEXT NULL, `ErrorString_esES` TEXT NULL, `ErrorString_esMX` TEXT NULL, `ErrorString_ruRU` TEXT NULL, `ErrorString_ptPT` TEXT NULL, `ErrorString_ptBR` TEXT NULL, `ErrorString_itIT` TEXT NULL, `ErrorString_Unk` TEXT NULL, `ErrorString_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `WowError_Strings` VALUES (1,"APP_TITLE","WowError","","","","","","","","","","","","","","","",16712190),
(2,"WOWERROR","WOWERROR","","","","","","","","","","","","","","","",16712190),
(3,"HEADER","The following data will be sent to Blizzard when you click Send
Though you can opt not to send this information, doing so will help us to improve the game.","","","","","","","","","","","","","","","",16712190),
(4,"SEND","Send","","","","","","","","","","","","","","","",16712190),
(5,"CANCEL","Cancel","","","","","","","","","","","","","","","",16712190),
(6,"SEND_ERROR","Error sending data","","","","","","","","","","","","","","","",16712190),
(7,"PRESS_SEND","Press Send to Send","","","","","","","","","","","","","","","",16712190),
(8,"SEND_CONNECTING","Connecting","","","","","","","","","","","","","","","",16712190),
(9,"SEND_SENDING","Sending","","","","","","","","","","","","","","","",16712190),
(10,"SEND_DONE","Send successful","","","","","","","","","","","","","","","",16712190),
(11,"SEND_CANT_CONNECT","Can not connect to server","","","","","","","","","","","","","","","",16712190),
(12,"DONE","Done","","","","","","","","","","","","","","","",16712190),
(13,"DESCRIBE","Describe what you were doing when the crash occurred","","","","","","","","","","","","","","","",16712190); 
