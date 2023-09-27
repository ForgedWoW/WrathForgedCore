DROP TABLE IF EXISTS `SpellVisualKitAreaModel`; 
CREATE TABLE `SpellVisualKitAreaModel` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, `EnumID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellVisualKitAreaModel` VALUES (1,"Spells\Blizzard_Impact_Base.mdx",0),
(2,"Spells\RainOfFire_Impact_Base.mdx",1),
(3,"Spells\CallLightning_Impact.mdx",2),
(4,"Spells\FlamestrikeSmall_Impact_Base.mdx",3),
(5,"Spells\DeathAndDecay_Area_Base.mdx",4),
(6,"Spells\ArcaneShot_Area.mdx",5),
(7,"Spells\StarShards_Impact_Base.mdx",6),
(8,"Spells\Fel_RainOfFire_Impact_Base.mdx",7),
(9,"Spells\HellfireRaid_Dust_Impact_Base.mdx",8),
(21,"Spells\DeathAndDecay.mdx",9),
(41,"Spells\DeathKnight_Desecration.mdx",10),
(61,"Spells\Druid_StarfallMissile.mdx",11),
(81,"Spells\archimonde_fire.mdx",12),
(82,"Spells\Archimonde_Blue_Fire.mdx",13),
(83,"Spells\DeathAndDecayGreen.mdx",14); 
