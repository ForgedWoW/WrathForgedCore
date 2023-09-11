DROP TABLE IF EXISTS `Exhaustion`; 
CREATE TABLE `Exhaustion` ( `ID` INT NOT NULL DEFAULT '0', `Xp` INT NOT NULL DEFAULT '0', `Factor` FLOAT NOT NULL DEFAULT '0', `OutdoorHours` FLOAT NOT NULL DEFAULT '0', `InnHours` FLOAT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `Threshold` FLOAT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Exhaustion` VALUES (1,10000,2,-1,8,"Rested","","","","","","","","","","","","","","","",16712190,12); 
INSERT INTO `Exhaustion` VALUES (2,13333,1,-1,6,"Normal","","","","","","","","","","","","","","","",16712190,0); 
INSERT INTO `Exhaustion` VALUES (3,20000,1,8,4,"XXXTired","","","","","","","","","","","","","","","",16712190,0); 
INSERT INTO `Exhaustion` VALUES (4,40000,0.5,4,2,"XXXTired","","","","","","","","","","","","","","","",16712190,0); 
INSERT INTO `Exhaustion` VALUES (5,-1,0.25,0,0,"XXXExhausted","","","","","","","","","","","","","","","",16712190,0); 
INSERT INTO `Exhaustion` VALUES (6,10000,2,-1,0,"Refer-A-Friend","","","","","","","","","","","","","","","",16712190,0); 
