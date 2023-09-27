DROP TABLE IF EXISTS `StringLookups`; 
CREATE TABLE `StringLookups` ( `ID` INT NOT NULL DEFAULT '0', `String` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `StringLookups` VALUES (1,"Interface\Cursor\Cursor.mdx"),
(2,"Interface\InventoryItems\InventoryArtGeometry.mdx"),
(3,"Interface\Icons"),
(4,"Textures\Expoint"),
(5,"Interface\Buttons\TalkToMe.mdx"),
(6,"Interface\Buttons\TalkToMeGrey.mdx"),
(7,"Interface\Buttons\TalkToMeGreen.mdx"),
(8,"Interface\Buttons\TalkToMeBlue.mdx"),
(9,"Interface\Buttons\TalkToMeQuestionMark.mdx"); 
