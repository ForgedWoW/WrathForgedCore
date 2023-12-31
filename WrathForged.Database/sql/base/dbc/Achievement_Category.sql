DROP TABLE IF EXISTS `Achievement_Category`; 
CREATE TABLE `Achievement_Category` ( `ID` INT NOT NULL DEFAULT '0', `Parent` INT NOT NULL DEFAULT '0', `Name_Lang_enUS` TEXT NULL, `Name_Lang_enGB` TEXT NULL, `Name_Lang_koKR` TEXT NULL, `Name_Lang_frFR` TEXT NULL, `Name_Lang_deDE` TEXT NULL, `Name_Lang_enCN` TEXT NULL, `Name_Lang_zhCN` TEXT NULL, `Name_Lang_enTW` TEXT NULL, `Name_Lang_zhTW` TEXT NULL, `Name_Lang_esES` TEXT NULL, `Name_Lang_esMX` TEXT NULL, `Name_Lang_ruRU` TEXT NULL, `Name_Lang_ptPT` TEXT NULL, `Name_Lang_ptBR` TEXT NULL, `Name_Lang_itIT` TEXT NULL, `Name_Lang_Unk` TEXT NULL, `Name_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `Ui_Order` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Achievement_Category` VALUES (92,-1,"General","","","","","","","","","","","","","","","",16712190,1),
(123,122,"Arenas","","","","","","","","","","","","","","","",16712190,1),
(130,1,"Character","","","","","","","","","","","","","","","",16712190,1),
(135,128,"Creatures","","","","","","","","","","","","","","","",16712190,1),
(140,130,"Wealth","","","","","","","","","","","","","","","",16712190,1),
(152,21,"Rated Arenas","","","","","","","","","","","","","","","",16712190,1),
(160,155,"Lunar Festival","","","","","","","","","","","","","","","",16712190,1),
(165,95,"Arena","","","","","","","","","","","","","","","",16712190,1),
(170,169,"Cooking","","","","","","","","","","","","","","","",16712190,1),
(178,132,"Secondary Skills","","","","","","","","","","","","","","","",16712190,1),
(14777,97,"Eastern Kingdoms","","","","","","","","","","","","","","","",16712190,1),
(14808,168,"Classic","","","","","","","","","","","","","","","",16712190,1),
(14821,14807,"Classic","","","","","","","","","","","","","","","",16712190,1),
(14861,96,"Classic","","","","","","","","","","","","","","","",16712190,1),
(14864,201,"Classic","","","","","","","","","","","","","","","",16712190,1),
(96,-1,"Quests","","","","","","","","","","","","","","","",16712190,2),
(124,122,"Battlegrounds","","","","","","","","","","","","","","","",16712190,2),
(136,128,"Honorable Kills","","","","","","","","","","","","","","","",16712190,2),
(141,1,"Combat","","","","","","","","","","","","","","","",16712190,2),
(145,130,"Consumables","","","","","","","","","","","","","","","",16712190,2),
(153,21,"Battlegrounds","","","","","","","","","","","","","","","",16712190,2),
(171,169,"Fishing","","","","","","","","","","","","","","","",16712190,2),
(173,132,"Professions","","","","","","","","","","","","","","","",16712190,2),
(187,155,"Love is in the Air","","","","","","","","","","","","","","","",16712190,2),
(14778,97,"Kalimdor","","","","","","","","","","","","","","","",16712190,2),
(14801,95,"Alterac Valley","","","","","","","","","","","","","","","",16712190,2),
(14805,168,"The Burning Crusade","","","","","","","","","","","","","","","",16712190,2),
(14822,14807,"The Burning Crusade","","","","","","","","","","","","","","","",16712190,2),
(14862,96,"The Burning Crusade","","","","","","","","","","","","","","","",16712190,2),
(14865,201,"The Burning Crusade","","","","","","","","","","","","","","","",16712190,2),
(97,-1,"Exploration","","","","","","","","","","","","","","","",16712190,3),
(125,122,"Dungeons","","","","","","","","","","","","","","","",16712190,3),
(128,1,"Kills","","","","","","","","","","","","","","","",16712190,3),
(137,128,"Killing Blows","","","","","","","","","","","","","","","",16712190,3),
(147,130,"Reputation","","","","","","","","","","","","","","","",16712190,3),
(154,21,"World","","","","","","","","","","","","","","","",16712190,3),
(159,155,"Noblegarden","","","","","","","","","","","","","","","",16712190,3),
(172,169,"First Aid","","","","","","","","","","","","","","","",16712190,3),
(14779,97,"Outland","","","","","","","","","","","","","","","",16712190,3),
(14802,95,"Arathi Basin","","","","","","","","","","","","","","","",16712190,3),
(14806,168,"Lich King Dungeon","","","","","","","","","","","","","","","",16712190,3),
(14823,14807,"Wrath of the Lich King","","","","","","","","","","","","","","","",16712190,3),
(14863,96,"Wrath of the Lich King","","","","","","","","","","","","","","","",16712190,3),
(14866,201,"Wrath of the Lich King","","","","","","","","","","","","","","","",16712190,3),
(95,-1,"Player vs. Player","","","","","","","","","","","","","","","",16712190,4),
(122,1,"Deaths","","","","","","","","","","","","","","","",16712190,4),
(126,122,"World","","","","","","","","","","","","","","","",16712190,4),
(163,155,"Children's Week","","","","","","","","","","","","","","","",16712190,4),
(191,130,"Gear","","","","","","","","","","","","","","","",16712190,4),
(14780,97,"Northrend","","","","","","","","","","","","","","","",16712190,4),
(14803,95,"Eye of the Storm","","","","","","","","","","","","","","","",16712190,4),
(14921,168,"Lich King Heroic","","","","","","","","","","","","","","","",16712190,4),
(14963,14807,"Secrets of Ulduar","","","","","","","","","","","","","","","",16712190,4),
(127,122,"Resurrection","","","","","","","","","","","","","","","",16712190,5),
(133,1,"Quests","","","","","","","","","","","","","","","",16712190,5),
(161,155,"Midsummer","","","","","","","","","","","","","","","",16712190,5),
(168,-1,"Dungeons & Raids","","","","","","","","","","","","","","","",16712190,5),
(14804,95,"Warsong Gulch","","","","","","","","","","","","","","","",16712190,5),
(14922,168,"Lich King 10-Player Raid","","","","","","","","","","","","","","","",16712190,5),
(15021,14807,"Call of the Crusade","","","","","","","","","","","","","","","",16712190,5),
(162,155,"Brewfest","","","","","","","","","","","","","","","",16712190,6),
(169,-1,"Professions","","","","","","","","","","","","","","","",16712190,6),
(14807,1,"Dungeons & Raids","","","","","","","","","","","","","","","",16712190,6),
(14881,95,"Strand of the Ancients","","","","","","","","","","","","","","","",16712190,6),
(14923,168,"Lich King 25-Player Raid","","","","","","","","","","","","","","","",16712190,6),
(15062,14807,"Fall of the Lich King","","","","","","","","","","","","","","","",16712190,6),
(132,1,"Skills","","","","","","","","","","","","","","","",16712190,7),
(158,155,"Hallow's End","","","","","","","","","","","","","","","",16712190,7),
(201,-1,"Reputation","","","","","","","","","","","","","","","",16712190,7),
(14901,95,"Wintergrasp","","","","","","","","","","","","","","","",16712190,7),
(14961,168,"Secrets of Ulduar 10-Player Raid","","","","","","","","","","","","","","","",16712190,7),
(134,1,"Travel","","","","","","","","","","","","","","","",16712190,8),
(155,-1,"World Events","","","","","","","","","","","","","","","",16712190,8),
(14962,168,"Secrets of Ulduar 25-Player Raid","","","","","","","","","","","","","","","",16712190,8),
(14981,155,"Pilgrim's Bounty","","","","","","","","","","","","","","","",16712190,8),
(15003,95,"Isle of Conquest","","","","","","","","","","","","","","","",16712190,8),
(81,-1,"Feats of Strength","","","","","","","","","","","","","","","",16712190,9),
(131,1,"Social","","","","","","","","","","","","","","","",16712190,9),
(156,155,"Winter Veil","","","","","","","","","","","","","","","",16712190,9),
(15001,168,"Call of the Crusade 10-Player Raid","","","","","","","","","","","","","","","",16712190,9),
(1,-1,"Statistics","","","","","","","","","","","","","","","",16712190,10),
(21,1,"Player vs. Player","","","","","","","","","","","","","","","",16712190,10),
(14941,155,"Argent Tournament","","","","","","","","","","","","","","","",16712190,10),
(15002,168,"Call of the Crusade 25-Player Raid","","","","","","","","","","","","","","","",16712190,10),
(15041,168,"Fall of the Lich King 10-Player Raid","","","","","","","","","","","","","","","",16712190,11),
(15042,168,"Fall of the Lich King 25-Player Raid","","","","","","","","","","","","","","","",16712190,12); 
