DROP TABLE IF EXISTS `DanceMoves`; 
CREATE TABLE `DanceMoves` ( `ID` INT NOT NULL DEFAULT '0', `Type` INT NOT NULL DEFAULT '0', `Param` INT NOT NULL DEFAULT '0', `Fallback` INT NOT NULL DEFAULT '0', `Racemask` INT NOT NULL DEFAULT '0', `Internal_Name` TEXT NULL, `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `LockID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `DanceMoves` VALUES (1,0,65,0,0,"Default fallback -EmoteTalkQuestion","Shrug","","","","","","","","","","","","","","","",16712190,0),
(22,0,60,1,0,"All - Talk","Talk","","","","","","","","","","","","","","","",16712190,0),
(23,0,66,1,0,"All - Bow","Bow","","","","","","","","","","","","","","","",16712190,0),
(24,0,67,1,0,"All - Wave","Wave","","","","","","","","","","","","","","","",16712190,0),
(25,0,68,1,0,"All - Cheer","Cheer","","","","","","","","","","","","","","","",16712190,0),
(26,0,73,1,0,"All - Rude","Rude","","","","","","","","","","","","","","","",16712190,0),
(27,0,74,1,0,"All - Roar","Roar","","","","","","","","","","","","","","","",16712190,0),
(28,0,78,1,0,"All - Chicken","Chicken","","","","","","","","","","","","","","","",16712190,0),
(41,1,160,1,0,"All - FX - Frost Nova","Icy Finale","","","","","","","","","","","","","","","",16712190,1),
(42,2,6908,1,64,"Gnome - FemaleLaugh","","","","","","","","","","","","","","","","",16712190,0),
(61,0,213,1,0,"Dance Ready","Ready","","","","","","","","","","","","","","","",16712190,0),
(62,0,214,1,512,"Blood Elf - Female - Dance Var 2","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(63,0,215,1,512,"Blood Elf - Female - Dance Var 3","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,3),
(64,0,216,1,512,"Blood Elf - Female - Dance Var 4","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(65,0,217,1,512,"Blood Elf - Female - Dance Var 5","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,4),
(66,0,218,1,512,"Blood Elf - Female - Dance Var 6","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(67,0,219,1,512,"Blood Elf - Female - Dance Var 7","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(68,0,220,1,512,"Blood Elf - Female - Dance Var 8","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,2),
(69,0,221,1,512,"Blood Elf - Female - Dance Var 9","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(70,0,222,1,512,"Blood Elf - Female - Dance Var 10","DO NOT TRANSLATE","","","","","","","","","","","","","","","",16712190,0),
(82,3,2,1,0,"Hold - 2 Sec","Hold for two seconds","","","","","","","","","","","","","","","",16712190,0),
(83,3,4,1,0,"Hold - 4 Sec","Hold for four seconds","","","","","","","","","","","","","","","",16712190,0),
(84,4,5,1,0,"Repeat - 5 Sec","Repeat for five seconds","","","","","","","","","","","","","","","",16712190,0),
(85,4,10,1,0,"Repeat - 10 Sec","Repeat for ten seconds","","","","","","","","","","","","","","","",16712190,0); 
