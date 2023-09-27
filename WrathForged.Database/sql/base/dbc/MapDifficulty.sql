DROP TABLE IF EXISTS `MapDifficulty`; 
CREATE TABLE `MapDifficulty` ( `ID` INT NOT NULL DEFAULT '0', `MapID` INT NOT NULL DEFAULT '0', `Difficulty` INT NOT NULL DEFAULT '0', `Message_Lang_enUS` TEXT NULL, `Message_Lang_enGB` TEXT NULL, `Message_Lang_koKR` TEXT NULL, `Message_Lang_frFR` TEXT NULL, `Message_Lang_deDE` TEXT NULL, `Message_Lang_enCN` TEXT NULL, `Message_Lang_zhCN` TEXT NULL, `Message_Lang_enTW` TEXT NULL, `Message_Lang_zhTW` TEXT NULL, `Message_Lang_esES` TEXT NULL, `Message_Lang_esMX` TEXT NULL, `Message_Lang_ruRU` TEXT NULL, `Message_Lang_ptPT` TEXT NULL, `Message_Lang_ptBR` TEXT NULL, `Message_Lang_itIT` TEXT NULL, `Message_Lang_Unk` TEXT NULL, `Message_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `RaidDuration` INT NOT NULL DEFAULT '0', `MaxPlayers` INT NOT NULL DEFAULT '0', `Difficultystring` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `MapDifficulty` VALUES (1,0,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(2,1,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(3,13,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(4,25,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(5,29,0,"","","","","","","","","","","","","","","","",16712188,0,10,""),
(6,30,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(126,30,1,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(163,30,2,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(522,30,3,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(7,33,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(8,34,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(9,35,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(10,36,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(11,37,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(12,42,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(13,43,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(14,44,0,"","","","","","","","","","","","","","","","",16712188,0,10,""),
(15,47,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(16,48,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(17,70,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(18,90,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(19,109,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(20,129,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(21,169,0,"","","","","","","","","","","","","","","","",16712188,0,40,"RAID_DIFFICULTY_40PLAYER"),
(22,189,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(23,209,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(24,229,0,"","","","","","","","","","","","","","","","",16712188,0,15,""),
(25,230,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(26,249,0,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(323,249,1,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(27,269,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(127,269,1,"Heroic Difficulty requires the Key of Time.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(28,289,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(29,309,0,"","","","","","","","","","","","","","","","",16712188,259200,20,"RAID_DIFFICULTY_20PLAYER"),
(30,329,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(31,349,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(32,369,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(33,389,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(34,409,0,"","","","","","","","","","","","","","","","",16712188,604800,40,"RAID_DIFFICULTY_40PLAYER"),
(35,429,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(36,449,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(37,450,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(38,451,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(39,469,0,"","","","","","","","","","","","","","","","",16712188,604800,40,"RAID_DIFFICULTY_40PLAYER"),
(40,489,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(41,509,0,"","","","","","","","","","","","","","","","",16712188,259200,20,"RAID_DIFFICULTY_20PLAYER"),
(42,529,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(43,530,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(44,531,0,"","","","","","","","","","","","","","","","",16712188,604800,40,"RAID_DIFFICULTY_40PLAYER"),
(45,532,0,"","","","","","","","","","","","","","","","",16712188,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(46,533,0,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(128,533,1,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(47,534,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(48,540,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(129,540,1,"Heroic Difficulty requires the Flamewrought Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(49,542,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(130,542,1,"Heroic Difficulty requires the Flamewrought Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(50,543,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(131,543,1,"Heroic Difficulty requires the Flamewrought Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(51,544,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(52,545,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(132,545,1,"Heroic Difficulty requires the Reservoir Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(53,546,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(133,546,1,"Heroic Difficulty requires the Reservoir Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(54,547,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(134,547,1,"Heroic Difficulty requires the Reservoir Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(55,548,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(56,550,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(57,552,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(135,552,1,"Heroic Difficulty requires the Warpforged Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(58,553,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(136,553,1,"Heroic Difficulty requires the Warpforged Key.","","","","","","","","","","","","","","","",16712190,86400,0,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(59,554,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(137,554,1,"Heroic Difficulty requires the Warpforged Key.","","","","","","","","","","","","","","","",16712190,86400,0,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(60,555,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(138,555,1,"Heroic Difficulty requires the Auchenai Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(61,556,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(139,556,1,"Heroic Difficulty requires the Auchenai Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(62,557,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(140,557,1,"Heroic Difficulty requires the Auchenai Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(63,558,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(141,558,1,"Heroic Difficulty requires the Auchenai Key.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(64,559,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(65,560,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(142,560,1,"Heroic Difficulty requires the Key of Time.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(66,562,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(67,564,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(68,565,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(69,566,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(70,568,0,"","","","","","","","","","","","","","","","",16712188,259200,10,"RAID_DIFFICULTY_10PLAYER"),
(71,571,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(72,572,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(73,573,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(74,574,0,"You must be at least level 65 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(143,574,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(75,575,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(144,575,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(76,576,0,"You must be at least level 66 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(145,576,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(77,578,0,"You must be at least level 75 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(146,578,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(78,580,0,"","","","","","","","","","","","","","","","",16712188,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(79,582,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(80,584,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(81,585,0,"","","","","","","","","","","","","","","","",16712188,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(147,585,1,"Heroic Difficulty requires completion of the \"Hard to Kill\" quest.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(82,586,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(83,587,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(84,588,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(85,589,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(86,590,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(87,591,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(88,592,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(89,593,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(90,594,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(91,595,0,"You must be at least level 75 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(148,595,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(92,596,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(93,597,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(94,598,0,"","","","","","","","","","","","","","","","",16712188,0,5,""),
(149,598,1,"Heroic Difficulty requires the Sunforged Key[PH].","","","","","","","","","","","","","","","",16712190,86400,0,""),
(95,599,0,"You must be at least level 72 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(150,599,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(96,600,0,"You must be at least level 69 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(151,600,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(97,601,0,"You must be at least level 67 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(152,601,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(98,602,0,"You must be at least level 75 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(153,602,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(99,603,0,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(154,603,1,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(100,604,0,"You must be at least level 71 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(155,604,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(101,605,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(102,606,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(103,607,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(301,607,1,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(104,608,0,"You must be at least level 70 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(156,608,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(105,609,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(106,610,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(107,612,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(108,613,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(109,614,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(110,615,0,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(157,615,1,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(111,616,0,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(158,616,1,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(112,617,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(113,618,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(114,619,0,"You must be at least level 68 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(159,619,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(115,620,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(116,621,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(117,622,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(118,623,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(119,624,0,"You must be at least level 80, in control of Wintergrasp and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(160,624,1,"You must be at least level 80, in control of Wintergrasp and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(120,628,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(281,628,1,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(485,631,0,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(486,631,1,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(487,631,2,"You must have defeated The Lich King in the 10 Player raid before attempting 10 Player Heroic difficulty.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(488,631,3,"You must have defeated The Lich King in the 25 Player raid before attempting 25 Player Heroic difficulty.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(481,632,0,"You must be at least level 75 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(482,632,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(121,641,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(122,642,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(123,647,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(124,649,0,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(161,649,1,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(221,649,2,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER_HEROIC"),
(222,649,3,"You must be at least level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER_HEROIC"),
(125,650,0,"You must be at least level 75 to enter.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(162,650,1,"Heroic Difficulty requires you to be level 80.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(483,658,0,"You must complete the quest \"Echoes of Tortured Souls\" before entering the Pit of Saron.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(484,658,1,"You must complete the quest \"Echoes of Tortured Souls\" and be level 80 before entering the Heroic difficulty of the Pit of Saron.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(341,668,0,"You must complete the quest \"Deliverance from the Pit\" before entering the Halls of Reflection.","","","","","","","","","","","","","","","",16712190,0,5,"DUNGEON_DIFFICULTY_5PLAYER"),
(342,668,1,"You must complete the quest \"Deliverance from the Pit\" and be level 80 before entering the Heroic difficulty of the Halls of Reflection.","","","","","","","","","","","","","","","",16712190,86400,5,"DUNGEON_DIFFICULTY_5PLAYER_HEROIC"),
(642,712,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(641,713,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(701,718,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(744,723,0,"","","","","","","","","","","","","","","","",16712188,0,0,""),
(750,724,0,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(751,724,1,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"),
(752,724,2,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,10,"RAID_DIFFICULTY_10PLAYER"),
(753,724,3,"You must be level 80 and in a raid group to enter.","","","","","","","","","","","","","","","",16712190,604800,25,"RAID_DIFFICULTY_25PLAYER"); 
