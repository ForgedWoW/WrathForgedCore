DROP TABLE IF EXISTS `StringLookups`; 
CREATE TABLE `StringLookups` ( `ID` INT NOT NULL DEFAULT '0', `String` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `StringLookups` VALUES (1,"Interface\Cursor\Cursor.mdx"); 
INSERT INTO `StringLookups` VALUES (2,"Interface\InventoryItems\InventoryArtGeometry.mdx"); 
INSERT INTO `StringLookups` VALUES (3,"Interface\Icons"); 
INSERT INTO `StringLookups` VALUES (4,"Textures\Expoint"); 
INSERT INTO `StringLookups` VALUES (5,"Interface\Buttons\TalkToMe.mdx"); 
INSERT INTO `StringLookups` VALUES (6,"Interface\Buttons\TalkToMeGrey.mdx"); 
INSERT INTO `StringLookups` VALUES (7,"Interface\Buttons\TalkToMeGreen.mdx"); 
INSERT INTO `StringLookups` VALUES (8,"Interface\Buttons\TalkToMeBlue.mdx"); 
INSERT INTO `StringLookups` VALUES (9,"Interface\Buttons\TalkToMeQuestionMark.mdx"); 