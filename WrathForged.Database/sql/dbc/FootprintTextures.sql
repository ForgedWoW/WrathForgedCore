DROP TABLE IF EXISTS `FootprintTextures`; 
CREATE TABLE `FootprintTextures` ( `ID` INT NOT NULL DEFAULT '0', `FootstepFilename` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `FootprintTextures` VALUES (1,"textures\Footsteps\BaseFootprint"); 
INSERT INTO `FootprintTextures` VALUES (3,"textures\Footsteps\ClovenFootprint"); 
INSERT INTO `FootprintTextures` VALUES (4,"textures\Footsteps\BareFootprint"); 
INSERT INTO `FootprintTextures` VALUES (5,"textures\Footsteps\ClawFootprint"); 
INSERT INTO `FootprintTextures` VALUES (6,"textures\Footsteps\HoofFootprint"); 
INSERT INTO `FootprintTextures` VALUES (7,"textures\Footsteps\PawFootprint"); 
