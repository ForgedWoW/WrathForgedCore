DROP TABLE IF EXISTS `SpellVisualPrecastTransitions`; 
CREATE TABLE `SpellVisualPrecastTransitions` ( `ID` INT NOT NULL DEFAULT '0', `LoadAnimation` TEXT NULL, `HoldAnimation` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellVisualPrecastTransitions` VALUES (1,"LoadBow","HoldBow"); 
INSERT INTO `SpellVisualPrecastTransitions` VALUES (2,"LoadRifle","HoldRifle"); 
INSERT INTO `SpellVisualPrecastTransitions` VALUES (3,"LoadThrown","HoldThrown"); 
