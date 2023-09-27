DROP TABLE IF EXISTS `FootprintTextures`; 
CREATE TABLE `FootprintTextures` ( `ID` INT NOT NULL DEFAULT '0', `FootstepFilename` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `FootprintTextures` VALUES (1,"textures\Footsteps\BaseFootprint"),
(3,"textures\Footsteps\ClovenFootprint"),
(4,"textures\Footsteps\BareFootprint"),
(5,"textures\Footsteps\ClawFootprint"),
(6,"textures\Footsteps\HoofFootprint"),
(7,"textures\Footsteps\PawFootprint"); 
