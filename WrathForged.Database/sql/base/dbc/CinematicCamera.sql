DROP TABLE IF EXISTS `CinematicCamera`; 
CREATE TABLE `CinematicCamera` ( `ID` INT NOT NULL DEFAULT '0', `Model` TEXT NULL, `SoundID` INT NOT NULL DEFAULT '0', `OriginX` FLOAT NOT NULL DEFAULT '0', `OriginY` FLOAT NOT NULL DEFAULT '0', `OriginZ` FLOAT NOT NULL DEFAULT '0', `OriginFacing` FLOAT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `CinematicCamera` VALUES (1,"Cameras\PalantirOfAzora.mdx",0,-9282.42,-3329.66,116.341,4.60767),
(2,"Cameras\FlybyUndead.mdx",3358,1658.58,1662.91,141.234,3.14159),
(122,"Cameras\FlybyNightElf.mdx",3800,10474,813.131,1318.66,3.735),
(142,"Cameras\FlyByHuman.mdx",3840,-8945.52,-118.786,82.9306,0.191986),
(162,"Cameras\FlyByGnome.mdx",3841,-5784.35,424.736,426.592,0.925025),
(182,"Cameras\FlyByTroll.mdx",4080,-774.695,-4911.21,19.6127,2.94961),
(202,"Cameras\FlyByTauren.mdx",4122,-2873.26,-266.821,53.9164,3.15905),
(224,"Cameras\Scry_cam.mdx",0,-153.586,-3450.84,139.331,3.35103),
(234,"Cameras\FlyByDwarf.mdx",3740,-5579.16,-455.776,406.476,4.71239),
(235,"Cameras\FlybyOrc.mdx",3760,-603.411,-4193.41,41.092,4.67748),
(243,"Cameras\FlyByBloodElf.mdx",9156,8099.13,-6942.68,66.7039,1.13446),
(244,"Cameras\FlybyDraenei.mdx",9155,-3963.27,-13938.7,99.6888,5.20108),
(245,"Cameras\FlyBySunwell5Man.mdx",12213,-149.784,-354.238,-77.789,5.34071),
(246,"Cameras\FlyByDeathKnight.mdx",12938,2301.89,-5346.32,88.9573,2.16421); 
