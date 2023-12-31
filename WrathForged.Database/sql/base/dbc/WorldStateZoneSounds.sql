DROP TABLE IF EXISTS `WorldStateZoneSounds`; 
CREATE TABLE `WorldStateZoneSounds` ( `ID` INT NOT NULL DEFAULT '0', `WorldStateID` INT NOT NULL DEFAULT '0', `WorldStateValue` INT NOT NULL DEFAULT '0', `AreaID` INT NOT NULL DEFAULT '0', `WMOAreaID` INT NOT NULL DEFAULT '0', `ZoneintroMusicID` INT NOT NULL DEFAULT '0', `ZoneMusicID` INT NOT NULL DEFAULT '0', `SoundAmbienceID` INT NOT NULL DEFAULT '0', `SoundProviderPreferencesID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `WorldStateZoneSounds` VALUES (1,2019,1,159,0,62,14,36,84),
(2,2019,1,0,18154,182,13,43,0),
(3,2019,1,0,18153,401,232,103,0),
(4,843,0,3428,0,0,0,0,0),
(5,3202,0,3428,0,0,0,0,0),
(6,2465,0,3428,0,0,0,0,0),
(7,1946,0,3428,0,0,0,0,0),
(8,3426,0,4080,0,0,394,0,0),
(9,3426,1,4080,0,0,395,0,0),
(10,3426,2,4080,0,0,396,0,0),
(11,3426,0,0,40329,0,394,0,0),
(12,3426,1,0,40329,0,395,0,0),
(13,3426,2,0,40329,0,396,0,0),
(14,3426,0,0,40353,0,394,0,0),
(15,3426,1,0,40353,0,395,0,0),
(16,3426,2,0,40353,0,396,0,0),
(17,3426,0,0,43245,0,394,0,0),
(18,3426,1,0,43245,0,395,0,0),
(19,3426,2,0,43245,0,396,0,0),
(20,3426,0,0,40331,0,394,0,0),
(21,3426,1,0,40331,0,395,0,0),
(22,3426,2,0,40331,0,396,0,0),
(23,3426,0,0,43205,0,394,0,0),
(24,3426,1,0,43205,0,395,0,0),
(25,3426,2,0,43205,0,396,0,0),
(26,3427,1337,151,0,0,0,0,0),
(27,3427,5555,4019,0,0,0,0,0),
(28,3710,1,4197,0,0,445,463,84),
(29,4096,1,4273,0,0,527,0,0),
(30,4162,1,4273,0,0,529,0,0),
(31,4164,1,4273,0,0,530,0,0),
(32,4161,1,4273,0,0,528,0,0),
(33,4122,1,0,47321,0,531,0,0),
(34,4150,1,0,43600,0,533,0,0),
(35,4061,3,0,47478,0,534,0,0),
(36,4956,1,4820,0,0,548,0,0),
(37,4957,1,4820,0,0,547,0,0),
(38,4956,1,0,49438,0,548,0,0),
(39,4956,1,0,49439,0,548,0,0),
(40,4957,1,0,49438,0,547,0,0),
(41,4957,1,0,49437,0,547,0,0),
(42,4957,1,0,49441,0,547,0,0); 
