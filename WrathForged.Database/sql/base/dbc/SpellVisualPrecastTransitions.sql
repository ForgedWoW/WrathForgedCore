DROP TABLE IF EXISTS `SpellVisualPrecastTransitions`; 
CREATE TABLE `SpellVisualPrecastTransitions` ( `ID` INT NOT NULL DEFAULT '0', `LoadAnimation` TEXT NULL, `HoldAnimation` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellVisualPrecastTransitions` VALUES (1,"LoadBow","HoldBow"),
(2,"LoadRifle","HoldRifle"),
(3,"LoadThrown","HoldThrown"); 
