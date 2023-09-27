DROP TABLE IF EXISTS `GameObjectArtKit`; 
CREATE TABLE `GameObjectArtKit` ( `ID` INT NOT NULL DEFAULT '0', `TextureVariation_1` TEXT NULL, `TextureVariation_2` TEXT NULL, `TextureVariation_3` TEXT NULL, `AttachModel_1` TEXT NULL, `AttachModel_2` TEXT NULL, `AttachModel_3` TEXT NULL, `AttachModel_4` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `GameObjectArtKit` VALUES (1,"","","","World\Generic\PVP\BattlefieldBanners\BattlefieldBanner_State_FlagH_Plaguelands.mdx","","",""),
(2,"","","","World\Generic\PVP\BattlefieldBanners\BattlefieldBanner_State_FlagA_Plaguelands.mdx","","",""),
(21,"","","","World\Generic\PVP\BattlefieldBanners\BattlefieldBanner_State_FlagN_Plaguelands.mdx","","",""),
(61,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_NorthFortFlagsH.mdx","","",""),
(62,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_NorthFortFlagsA.mdx","","",""),
(63,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_NorthFortFlagsN.mdx","","",""),
(64,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_SouthFortFlagsH.mdx","","",""),
(65,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_SouthFortFlagsA.mdx","","",""),
(66,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_SouthFortFlagsN.mdx","","",""),
(67,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_WestFortFlagsA.mdx","","",""),
(68,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_WestFortFlagsH.mdx","","",""),
(69,"","","","World\Expansion01\Doodads\HellfirePeninsula\PVPFlags\Hellfire_PVPFlags_WestFortFlagsN.mdx","","",""),
(81,"","","","World\Generic\PassiveDoodads\ParticleEmitters\LavaSplashParticle.mdx","World\Generic\PassiveDoodads\ParticleEmitters\LavaSplashParticle.mdx","World\Generic\PassiveDoodads\ParticleEmitters\LavaSplashParticle.mdx","World\Generic\PassiveDoodads\ParticleEmitters\LavaSplashParticle.mdx"),
(82,"","","","World\Generic\PassiveDoodads\Traps\SpellObject_InvisibleTrap.mdx","","",""),
(101,"","","","World\Expansion01\Doodads\Auchindoun\Passivedoodads\Ethereal_Ribbons\Auchindoun_Ethereal_Ribbon_Type1.mdx","","",""),
(121,"","","","World\Generic\PassiveDoodads\SummerFestival\SummerFest_Bonfire_ON.mdx","","",""),
(122,"","","","World\Generic\PassiveDoodads\SummerFestival\SummerFest_Bonfire_OFF.mdx","","",""); 
