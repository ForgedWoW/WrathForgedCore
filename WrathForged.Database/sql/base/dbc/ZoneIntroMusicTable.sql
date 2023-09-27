DROP TABLE IF EXISTS `ZoneintroMusicTable`; 
CREATE TABLE `ZoneintroMusicTable` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, `SoundID` INT NOT NULL DEFAULT '0', `Priority` INT NOT NULL DEFAULT '0', `MinDelayMinutes` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ZoneintroMusicTable` VALUES (61,"Valley of Heroes",2541,1,60),
(62,"Orgrimmar Intro",3402,1,60),
(63,"Darnassus Intro",3900,1,60),
(81,"Angelic01",4517,1,10),
(101,"Spooky01",5037,1,10),
(102,"Warrior Terrace",5354,1,10),
(103,"Druid Grove",4434,1,10),
(121,"Swamp01",4514,1,10),
(122,"Stormwind-Southseas",6837,1,10),
(123,"Stormwind03",5054,1,10),
(141,"Stormwind08",5294,1,10),
(161,"Haunted02",5174,1,10),
(162,"Jungle",2535,1,10),
(181,"Stormwind02",5036,1,10),
(182,"Stormwind01",5035,1,10),
(201,"Magic",6669,1,10),
(221,"Sacred01",4454,1,10),
(241,"Orgrimmar Walking",5055,1,10),
(281,"Undercity",6080,1,60),
(301,"Battle03",6078,1,10),
(302,"Gloomy01",6074,1,10),
(303,"Gloomy02",6075,1,10),
(321,"Battle02",6262,1,10),
(322,"Battle01",6077,1,10),
(323,"Battle04",6079,1,10),
(324,"Battle05",6253,1,10),
(325,"Battle06",6350,1,10),
(326,"Sacred02",6076,1,10),
(341,"Ironforge City Intro",7318,1,60),
(361,"Stormwind07",6794,1,10),
(381,"Thunderbluff Intro",7076,1,60),
(401,"Ironforge King",7338,1,60),
(421,"Orc Barren",7474,1,10),
(441,"Desert",5194,1,10),
(461,"Raid Battle03",6078,1,3),
(462,"Raid Battle06",6350,1,3),
(463,"Raid Battle02",6262,1,3),
(464,"Raid Battle04",6079,1,3),
(465,"Raid Desert",5194,1,3),
(466,"Raid Battle01",6077,1,3),
(467,"Raid Warrior Terrace",5354,1,3),
(468,"Raid Battle05",6253,1,3),
(469,"AhnQirajInteriorMainEntrance",8564,1,120),
(470,"BloodmystNaga",9462,1,30),
(471,"OL_Demon01",9774,1,10),
(472,"HE_PathOfGlory01",9775,1,10),
(473,"HE_Stairs01",9776,1,10),
(474,"HE_Armoury01",9777,1,10),
(475,"OL_Historic01",9778,1,10),
(477,"HE_Citadel01",9779,1,10),
(478,"HE_Wistful01",9780,1,10),
(479,"HE_Wistful02",9781,1,10),
(480,"OL_Arakkoa01",9782,1,10),
(481,"OL_Arakkoa02",9783,1,10),
(482,"OL_Shaman01",9784,1,10),
(483,"SilvermoonIntro",9801,1,120),
(484,"ScenicIntroNight",9802,1,10),
(485,"Corrupt Intro",9872,1,30),
(486,"Exodar",9971,1,60),
(487,"OutlandBurningLegion01",10610,1,60),
(488,"OutlandBurningLegion02",10611,1,60),
(489,"OutlandScenic",10612,1,60),
(490,"OutlandCrystal01",10613,1,60),
(491,"OutlandCrystal02",10614,1,60),
(492,"OutlandCrystal03",10615,1,60),
(493,"OutlandCenarion01",10616,1,60),
(494,"OutlandCenarion02",10617,1,69),
(495,"OutlandCenarion03",10618,1,60),
(496,"NetherstormPlant01",10619,1,60),
(497,"NetherstormPlant02",10620,1,60),
(498,"NetherstormPlant03",10621,1,60),
(499,"NetherstormPlant04",10622,1,60),
(500,"NagrandDiamond",10623,1,60),
(501,"OL_FelOrc01",10701,1,60),
(502,"OL_FelOrc02",10702,1,60),
(503,"OL_Orc01",10703,1,60),
(504,"OL_Orc02",10704,1,60),
(505,"OL_Orc03",10705,1,60),
(506,"OL_Orc04",10706,1,60),
(507,"OL_IllidansArmy01",10707,1,60),
(508,"OL_Ogre01",10708,1,60),
(509,"OL_Orc02",10709,1,60),
(510,"OL_Ogre02",10709,1,60),
(511,"OL_Shaman02",10710,1,60),
(512,"CavernsOfTimeBlackMorass",10732,1,60),
(513,"Intro-CavernsofTimeEscapeDurn",10771,1,300),
(514,"Intro-CavernsofTimeThrallEscape",10772,1,60),
(515,"Intro-CavernsofTimeFlight",10773,1,60),
(516,"Intro-NetherStormMushroom01",10851,1,60),
(517,"Intro-NetherStormMushroom02",10852,1,60),
(518,"Intro-NetherStormMushroom03",10853,1,60),
(519,"OL_Broken",10855,1,60),
(520,"DraeneiRestUni",10898,1,60),
(521,"HyjalPastBase",11654,1,60),
(522,"HyjalPastHordeCamp",11655,1,60),
(523,"HyjalPastNordrassil",11656,1,60),
(524,"BlackTempleKarabor",11704,1,60),
(525,"BlackTempleIllidari",11705,1,60),
(526,"BlackTempleSanctuary",11706,1,60),
(527,"New Intro",0,0,0),
(528,"BlackTempleDen",11707,1,60),
(529,"BlackTempleAnguish",11708,1,60),
(530,"BlackTempleVigil",11709,1,60),
(531,"BlackTempleReliquary",11710,1,60),
(532,"BlackTempleRefectory",11711,1,60),
(533,"BladesEdgeOgrila",11770,1,30),
(534,"OutlandMilitaryBattle",11771,1,30),
(535,"TempesttKeep1",12130,1,10),
(536,"TempestKeep2",12131,1,10),
(537,"TempestKeep3",12132,1,10),
(538,"Intro-KarazhanStableWalk",12158,1,10),
(539,"Intro-KarazhanFoyer",12155,1,10),
(540,"Intro-MagistersTerrace",12530,1,60),
(541,"Intro-SunwellPlateau",12534,1,60),
(543,"Intro-IcecrownGeneral",13803,1,60),
(544,"Intro-ZulDrakGeneralWalk",13806,1,60),
(545,"Intro-DragonblightGeneral",14892,1,60),
(546,"Intro-DalaranCity",14907,1,60),
(550,"Intro-StratholmePastOutdoors",14919,1,60),
(551,"Intro-StratholmePastIndoors",14925,1,10),
(552,"Intro-StratholmePastTownHall",14926,1,60),
(553,"Intro-StratholmePastChronoLordEpoch",14927,1,60),
(554,"Intro-StratholmePastAlleyIntro",14928,1,10),
(555,"Intro-StratholmePastAlleyEnd",14929,1,60),
(556,"Intro-StratholmePastMal'Ganis",14930,1,60),
(557,"Intro-HallsofStone",14936,1,60),
(558,"Intro-UlduarStoneTribunal",14940,1,60),
(559,"Intro-UldarLightning",14941,1,60),
(560,"Intro-UldarLightningWatchers",14943,1,10),
(561,"Intro-UldarLightningAzeroth",14944,1,60),
(562,"New Intro",15035,1,60),
(563,"Intro-GrizzlyHillsGeneral",15035,1,60),
(564,"Intro-GrizzlyHillsGeneralB",15040,1,60),
(565,"Intro-NorthrenOrc",15043,1,60),
(566,"Intro-NorthrenRiplash01",15046,1,60),
(567,"Intro-NorthrenRiplash02",15047,1,60),
(568,"Intro-ChamberAspects01Day",15075,1,60),
(569,"Intro-ChamberAspects01Night",15076,1,60),
(570,"Intro-StratholmePastPortal",15080,1,10),
(571,"Intro-UlduarStoneRepose",15081,1,60),
(572,"Intro-DragonBlightWyrmrest",15123,1,60),
(573,"Intro-AzjolNerubD",15124,1,60),
(574,"Intro-AzjolNerubE",15127,1,60),
(576,"Intro-UlduarRaidGeneralIntro",15873,1,60),
(577,"Intro-UlduarRaidDescent",15874,1,60),
(578,"Intro-UlduarRaidConservatory",15875,1,60),
(579,"Intro-UlduarRaidTram",15876,1,60),
(580,"Intro-UlduarRaidExtBaseCamp",15849,1,60),
(581,"Intro-UlduarRaidExtIronConcourse",15855,1,60),
(582,"Intro-UlduarRaidExtFormationGrounds",15860,1,60),
(583,"Intro-UlduarRaidExtColossalForge",15863,1,60),
(584,"Intro-UlduarRaidExtRazorscalesAerie",15866,1,60),
(585,"Intro-UlduarRaidExtScrapyard",15869,1,60),
(587,"Intro-IcecrownDungeon",17279,1,60),
(588,"Intro-IcecrownSummit",17285,1,60),
(589,"Intro-IcecrownRaidFloor1Entry",17306,1,60),
(590,"Intro-IcecrownRaidFloor1Spire",17304,1,60),
(591,"Intro-IcecrownRaidFloor1Deathwhisper",17302,1,60),
(592,"Intro-PitofSaronCave",17312,1,60),
(593,"Intro-PitofSaron",17309,1,60),
(594,"Intro-IcecrownRaidFloor2Intro",17292,1,60),
(595,"Intro-IcecrownRaidFloor2Spire",17295,1,60),
(596,"Intro-IcecrownRaidFloor2Plague",17293,1,60),
(597,"Intro-IcecrownRaidFloor2Frost",17297,1,60),
(598,"Intro-IcecrownRaidFloor2Valithria",17299,1,60),
(599,"Intro-IcecrownSummit",17285,1,60),
(600,"Intro-PitofSaronEntry",17307,1,60),
(601,"Intro-PitofSaronTyrannus",17313,1,60); 
