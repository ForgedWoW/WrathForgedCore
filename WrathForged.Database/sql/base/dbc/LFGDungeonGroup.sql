DROP TABLE IF EXISTS `LfgDungeonGroup`; 
CREATE TABLE `LfgDungeonGroup` ( `ID` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `Order_Index` INT NOT NULL DEFAULT '0', `Parent_Group_Id` INT NOT NULL DEFAULT '0', `Typeid` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `LfgDungeonGroup` VALUES (5,"Wrath of the Lich King Heroic","","","","","","","","","","","","","","","",16712190,1,0,5),
(4,"Wrath of the Lich King Normal","","","","","","","","","","","","","","","",16712190,2,0,1),
(3,"Burning Crusade Heroic","","","","","","","","","","","","","","","",16712190,3,0,5),
(2,"Burning Crusade Normal","","","","","","","","","","","","","","","",16712190,4,0,1),
(1,"Classic Dungeons","","","","","","","","","","","","","","","",16712190,5,0,1),
(9,"Wrath of the Lich King Raid (25)","","","","","","","","","","","","","","","",16712190,17,0,2),
(8,"Wrath of the Lich King Raid (10)","","","","","","","","","","","","","","","",16712190,18,0,2),
(7,"Burning Crusade Raid","","","","","","","","","","","","","","","",16712190,19,0,2),
(6,"Classic Raid","","","","","","","","","","","","","","","",16712190,20,0,2),
(11,"World Events","","","","","","","","","","","","","","","",16712190,21,0,0); 
