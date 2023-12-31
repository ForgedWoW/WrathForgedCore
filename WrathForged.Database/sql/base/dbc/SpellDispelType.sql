DROP TABLE IF EXISTS `SpellDispelType`; 
CREATE TABLE `SpellDispelType` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `Mask` INT NOT NULL DEFAULT '0', `ImmunityPossible` INT NOT NULL DEFAULT '0', `InternalName` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellDispelType` VALUES (0,"None","","","","","","","","","","","","","","","",16712190,0,0,""),
(1,"Magic","","","","","","","","","","","","","","","",16712190,0,1,"Magic"),
(2,"Curse","","","","","","","","","","","","","","","",16712190,0,1,"Curse"),
(3,"Disease","","","","","","","","","","","","","","","",16712190,0,1,"Disease"),
(4,"Poison","","","","","","","","","","","","","","","",16712190,0,1,"Poison"),
(5,"Stealth","","","","","","","","","","","","","","","",16712190,0,0,""),
(6,"Invisibility","","","","","","","","","","","","","","","",16712190,0,0,""),
(7,"All(M+C+D+P)","","","","","","","","","","","","","","","",16712190,30,0,""),
(8,"Special - npc only","","","","","","","","","","","","","","","",16712190,0,0,""),
(9,"Enrage","","","","","","","","","","","","","","","",16712190,0,1,""),
(10,"ZG Trinkets","","","","","","","","","","","","","","","",16712190,0,0,""),
(11,"ZZOLD UNUSED","","","","","","","","","","","","","","","",16712190,0,0,""); 
