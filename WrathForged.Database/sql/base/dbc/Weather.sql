DROP TABLE IF EXISTS `Weather`; 
CREATE TABLE `Weather` ( `ID` INT NOT NULL DEFAULT '0', `AmbienceID` INT NOT NULL DEFAULT '0', `EffectType` INT NOT NULL DEFAULT '0', `TransitionSkyBox` FLOAT NOT NULL DEFAULT '0', `EffectColor_1` FLOAT NOT NULL DEFAULT '0', `EffectColor_2` FLOAT NOT NULL DEFAULT '0', `EffectColor_3` FLOAT NOT NULL DEFAULT '0', `EffectTexture` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `Weather` VALUES (1,0,0,1,1,1,1,""),
(2,0,1,1,1,1,1,""),
(3,8533,1,1,1,1,1,""),
(4,8534,1,1,1,1,1,""),
(5,8535,1,1,1,1,1,""),
(6,8536,2,1,1,1,1,""),
(7,8537,2,1,1,1,1,""),
(8,8538,2,1,1,1,1,""),
(21,8535,1,1,1,1,1,"textures\Weather\RainDrop01.blp"),
(22,8558,3,1,1,1,1,""),
(41,8556,3,1,1,1,1,""),
(42,8557,3,1,1,1,1,""),
(61,0,2,1,1,1,1,""),
(81,0,1,1,1,1,1,""),
(83,0,2,1,1,1,1,"textures\Weather\SnowFlake01.blp"),
(84,8556,3,1,1,1,1,""),
(85,8556,3,1,1,1,1,""),
(86,4994,1,1,1,1,1,""),
(87,0,1,1,1,1,1,""),
(90,0,1,1,1,1,1,"Particles\LeafBrown.blp"),
(91,0,1,1,1,1,1,"textures\Weather\RainDrop01.blp"),
(96,8537,2,1,1,1,1,"textures\Weather\SnowFlake01.blp"),
(97,8537,2,1,1,1,1,"textures\Weather\SnowFlake01.blp"),
(98,0,2,1,1,1,1,"textures\Weather\SnowFlake01.blp"),
(99,8535,1,1,1,1,1,"textures\Weather\RainDrop01.blp"),
(100,8535,1,1,1,1,1,"textures\Weather\RainDropRed01.blp"),
(103,8557,3,0,1,0.502,0,""),
(104,0,3,1,0,0,0,"Textures\WEATHER\SNOWMIST01.BLP"),
(105,8556,3,0,1,1,1,""),
(106,8556,3,0,1,1,1,""),
(107,8556,3,0,1,1,1,""),
(108,8535,1,1,1,1,1,"textures\Weather\RainDropRed01.blp"); 
