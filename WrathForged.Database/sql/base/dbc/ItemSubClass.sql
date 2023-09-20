DROP TABLE IF EXISTS `ItemSubClass`; 
CREATE TABLE `ItemSubClass` ( `ID` INT NOT NULL DEFAULT '0', `ClassID` INT NOT NULL DEFAULT '0', `SubClassID` INT NOT NULL DEFAULT '0', `PrerequisiteProficiency` INT NOT NULL DEFAULT '0', `PostrequisiteProficiency` INT NOT NULL DEFAULT '0', `Flags` INT NOT NULL DEFAULT '0', `DisplayFlags` INT NOT NULL DEFAULT '0', `WeaponParrySeq` INT NOT NULL DEFAULT '0', `WeaponReadySeq` INT NOT NULL DEFAULT '0', `WeaponAttackSeq` INT NOT NULL DEFAULT '0', `WeaponSwingSize` INT NOT NULL DEFAULT '0', `DisplayName_Lang_enUS` TEXT NULL, `DisplayName_Lang_enGB` TEXT NULL, `DisplayName_Lang_koKR` TEXT NULL, `DisplayName_Lang_frFR` TEXT NULL, `DisplayName_Lang_deDE` TEXT NULL, `DisplayName_Lang_enCN` TEXT NULL, `DisplayName_Lang_zhCN` TEXT NULL, `DisplayName_Lang_enTW` TEXT NULL, `DisplayName_Lang_zhTW` TEXT NULL, `DisplayName_Lang_esES` TEXT NULL, `DisplayName_Lang_esMX` TEXT NULL, `DisplayName_Lang_ruRU` TEXT NULL, `DisplayName_Lang_ptPT` TEXT NULL, `DisplayName_Lang_ptBR` TEXT NULL, `DisplayName_Lang_itIT` TEXT NULL, `DisplayName_Lang_Unk` TEXT NULL, `DisplayName_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', `VerboseName_Lang_enUS` TEXT NULL, `VerboseName_Lang_enGB` TEXT NULL, `VerboseName_Lang_koKR` TEXT NULL, `VerboseName_Lang_frFR` TEXT NULL, `VerboseName_Lang_deDE` TEXT NULL, `VerboseName_Lang_enCN` TEXT NULL, `VerboseName_Lang_zhCN` TEXT NULL, `VerboseName_Lang_enTW` TEXT NULL, `VerboseName_Lang_zhTW` TEXT NULL, `VerboseName_Lang_esES` TEXT NULL, `VerboseName_Lang_esMX` TEXT NULL, `VerboseName_Lang_ruRU` TEXT NULL, `VerboseName_Lang_ptPT` TEXT NULL, `VerboseName_Lang_ptBR` TEXT NULL, `VerboseName_Lang_itIT` TEXT NULL, `VerboseName_Lang_Unk` TEXT NULL, `VerboseName_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `ItemSubClass` VALUES (1,0,0,-1,-1,0,3,3,2,3,0,"Consumable","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (2,0,5,-1,-1,0,1,3,2,3,0,"Food & Drink","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (3,0,1,-1,-1,0,1,3,2,3,0,"Potion","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (4,0,2,-1,-1,0,1,3,2,3,0,"Elixir","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (5,0,3,-1,-1,0,1,3,2,3,0,"Flask","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (6,0,7,-1,-1,0,1,3,2,3,0,"Bandage","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (7,0,6,-1,-1,0,1,3,2,3,0,"Item Enhancement","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (8,0,4,-1,-1,0,1,3,2,3,0,"Scroll","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (9,0,8,-1,-1,0,1,3,2,3,0,"Other","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (10,1,0,-1,-1,0,0,0,0,3,0,"Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (11,1,1,-1,-1,0,4,0,0,3,0,"Soul Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (12,1,2,-1,-1,0,0,0,0,3,0,"Herb Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (13,1,3,-1,-1,0,0,0,0,3,0,"Enchanting Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (14,1,4,-1,-1,0,0,0,0,3,0,"Engineering Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (15,1,5,-1,-1,0,0,0,0,3,0,"Gem Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (16,1,6,-1,-1,0,0,0,0,3,0,"Mining Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (17,1,7,-1,-1,0,0,0,0,3,0,"Leatherworking Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (18,1,8,-1,-1,0,0,3,0,3,0,"Inscription Bag","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (19,2,0,-1,1,3,0,2,2,3,1,"Axe","","","","","","","","","","","","","","","",16712190,"One-Handed Axes","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (20,2,1,0,-1,3,0,0,0,0,2,"Axe","","","","","","","","","","","","","","","",16712190,"Two-Handed Axes","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (21,2,2,-1,-1,128,0,3,3,2,1,"Bow","","","","","","","","","","","","","","","",16712190,"Bows","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (22,2,3,-1,-1,168,0,3,4,4,1,"Gun","","","","","","","","","","","","","","","",16712190,"Guns","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (23,2,4,-1,5,3,0,2,2,3,1,"Mace","","","","","","","","","","","","","","","",16712190,"One-Handed Maces","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (24,2,5,4,-1,3,0,0,0,0,2,"Mace","","","","","","","","","","","","","","","",16712190,"Two-Handed Maces","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (25,2,6,-1,-1,3,0,1,1,1,2,"Polearm","","","","","","","","","","","","","","","",16712190,"Polearms","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (26,2,7,-1,8,3,0,2,2,3,1,"Sword","","","","","","","","","","","","","","","",16712190,"One-Handed Swords","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (27,2,8,7,-1,3,0,0,0,0,2,"Sword","","","","","","","","","","","","","","","",16712190,"Two-Handed Swords","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (28,2,9,-1,-1,0,3,3,2,3,1,"Obsolete","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (29,2,10,-1,-1,3,0,1,1,1,2,"Staff","","","","","","","","","","","","","","","",16712190,"Staves","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (30,2,11,-1,12,0,3,3,2,3,1,"Exotic","","","","","","","","","","","","","","","",16712190,"One-Handed Exotics","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (31,2,12,11,-1,0,3,3,2,3,2,"Exotic","","","","","","","","","","","","","","","",16712190,"Two-Handed Exotics","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (32,2,13,-1,-1,5,0,3,2,3,0,"Fist Weapon","","","","","","","","","","","","","","","",16712190,"Fist Weapons","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (33,2,14,-1,-1,2,1,3,2,3,1,"Miscellaneous","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (34,2,15,-1,-1,3,0,2,2,3,0,"Dagger","","","","","","","","","","","","","","","",16712190,"Daggers","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (35,2,16,-1,-1,16,0,3,5,5,1,"Thrown","","","","","","","","","","","","","","","",16712190,"Thrown","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (36,2,17,-1,-1,3,2,1,1,1,2,"Spear","","","","","","","","","","","","","","","",16712190,"Spears","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (37,2,18,-1,-1,160,0,3,4,4,1,"Crossbow","","","","","","","","","","","","","","","",16712190,"Crossbows","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (38,2,19,-1,-1,256,0,3,2,3,1,"Wand","","","","","","","","","","","","","","","",16712190,"Wands","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (39,2,20,-1,-1,0,0,1,1,1,2,"Fishing Pole","","","","","","","","","","","","","","","",16712190,"Fishing Poles","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (40,3,0,-1,-1,0,1,0,0,0,0,"Red","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (41,3,1,-1,-1,0,1,3,2,3,0,"Blue","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (42,3,2,-1,-1,0,1,3,2,3,0,"Yellow","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (43,3,3,-1,-1,0,1,3,2,3,0,"Purple","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (44,3,4,-1,-1,0,1,3,2,3,0,"Green","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (45,3,5,-1,-1,0,1,3,2,3,0,"Orange","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (46,3,6,-1,-1,0,1,3,2,3,0,"Meta","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (47,3,7,-1,-1,0,1,3,2,3,0,"Simple","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (48,3,8,-1,-1,0,1,3,2,3,0,"Prismatic","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (49,4,0,-1,-1,512,1,0,0,3,0,"Miscellaneous","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (50,4,1,-1,-1,512,0,0,0,3,0,"Cloth","","","","","","","","","","","","","","","",16712190,"Cloth","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (51,4,2,-1,-1,512,0,0,0,3,0,"Leather","","","","","","","","","","","","","","","",16712190,"Leather","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (52,4,3,-1,-1,512,0,0,0,3,0,"Mail","","","","","","","","","","","","","","","",16712190,"Mail","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (53,4,4,-1,-1,512,0,0,0,3,0,"Plate","","","","","","","","","","","","","","","",16712190,"Plate","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (54,4,5,-1,-1,0,2,0,0,3,0,"Buckler(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"Bucklers","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (55,4,6,5,-1,0,0,0,0,3,0,"Shield","","","","","","","","","","","","","","","",16712190,"Shields","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (56,4,7,-1,-1,0,0,0,0,3,0,"Libram","","","","","","","","","","","","","","","",16712190,"Librams","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (57,4,8,-1,-1,0,0,0,0,3,0,"Idol","","","","","","","","","","","","","","","",16712190,"Idols","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (58,4,9,-1,-1,0,0,0,0,3,0,"Totem","","","","","","","","","","","","","","","",16712190,"Totems","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (59,4,10,-1,-1,0,0,0,0,3,0,"Sigil","","","","","","","","","","","","","","","",16712190,"Sigils","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (60,5,0,-1,-1,0,1,3,2,3,0,"Reagent","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (61,6,0,-1,-1,0,3,0,0,3,0,"Wand(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (62,6,1,-1,-1,0,2,0,0,3,0,"Bolt(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (63,6,2,-1,-1,0,0,0,0,3,0,"Arrow","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (64,6,3,-1,-1,0,0,0,0,3,0,"Bullet","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (65,6,4,-1,-1,64,2,3,2,3,0,"Thrown(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (66,7,0,-1,-1,0,3,3,2,3,0,"Trade Goods","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (67,7,10,-1,-1,0,1,3,2,3,0,"Elemental","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (68,7,5,-1,-1,0,1,3,2,3,0,"Cloth","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (69,7,6,-1,-1,0,1,3,2,3,0,"Leather","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (70,7,7,-1,-1,0,1,3,2,3,0,"Metal & Stone","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (71,7,8,-1,-1,0,1,3,2,3,0,"Meat","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (72,7,9,-1,-1,0,1,3,2,3,0,"Herb","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (73,7,12,-1,-1,0,1,3,2,3,0,"Enchanting","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (74,7,4,-1,-1,0,1,3,2,3,0,"Jewelcrafting","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (75,7,1,-1,-1,0,1,3,2,3,0,"Parts","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (76,7,3,-1,-1,0,1,3,2,3,0,"Devices","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (77,7,2,-1,-1,0,1,3,2,3,0,"Explosives","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (78,7,13,-1,-1,0,1,3,2,3,0,"Materials","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (79,7,11,-1,-1,0,1,3,2,3,0,"Other","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (80,7,14,-1,-1,0,1,3,2,3,0,"Armor Enchantment","","","","","","","","","","","","","","","",16712190,"Armor Enchantment","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (81,7,15,-1,-1,0,1,3,2,3,0,"Weapon Enchantment","","","","","","","","","","","","","","","",16712190,"Weapon Enchantment","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (82,8,0,-1,-1,0,1,3,2,3,0,"Generic(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (83,9,0,-1,-1,0,1,3,2,3,0,"Book","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (84,9,1,-1,-1,0,1,3,2,3,0,"Leatherworking","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (85,9,2,-1,-1,0,1,3,2,3,0,"Tailoring","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (86,9,3,-1,-1,0,1,3,2,3,0,"Engineering","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (87,9,4,-1,-1,0,1,3,2,3,0,"Blacksmithing","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (88,9,5,-1,-1,0,1,3,2,3,0,"Cooking","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (89,9,6,-1,-1,0,1,3,2,3,0,"Alchemy","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (90,9,7,-1,-1,0,1,3,2,3,0,"First Aid","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (91,9,8,-1,-1,0,1,3,2,3,0,"Enchanting","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (92,9,9,-1,-1,0,1,3,2,3,0,"Fishing","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (93,9,10,-1,-1,0,1,3,2,3,0,"Jewelcrafting","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (94,9,11,-1,-1,0,1,3,2,3,0,"Inscription","","","","","","","","","","","","","","","",16712190,"Inscription","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (95,10,0,-1,-1,0,1,3,2,3,0,"Money(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (96,11,0,-1,-1,0,7,0,0,3,0,"Quiver(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (97,11,1,-1,-1,0,7,0,0,3,0,"Quiver(OBSOLETE)","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (98,11,2,-1,-1,0,4,0,0,3,0,"Quiver","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (99,11,3,-1,-1,0,4,0,0,3,0,"Ammo Pouch","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (100,12,0,-1,-1,0,1,3,2,3,0,"Quest","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (101,13,0,-1,-1,0,1,3,2,3,0,"Key","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (102,13,1,-1,-1,0,1,3,2,3,0,"Lockpick","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (103,14,0,-1,-1,0,1,3,2,3,0,"Permanent","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (104,15,0,-1,-1,0,1,3,2,3,0,"Junk","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712188); 
INSERT INTO `ItemSubClass` VALUES (105,15,1,-1,-1,0,1,3,2,3,0,"Reagent","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (106,15,2,-1,-1,0,1,3,2,3,0,"Pet","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (107,15,3,-1,-1,0,1,3,2,3,0,"Holiday","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (108,15,4,-1,-1,0,1,3,2,3,0,"Other","","","","","","","","","","","","","","","",16712190,"","","","","","","","","","","","","","","","",16712172); 
INSERT INTO `ItemSubClass` VALUES (109,15,5,-1,-1,0,0,3,2,3,0,"Mount","","","","","","","","","","","","","","","",16712190,"Mount","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (110,16,1,-1,-1,0,0,0,0,0,0,"Warrior","","","","","","","","","","","","","","","",16712190,"Warrior","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (111,16,2,-1,-1,0,0,0,0,0,0,"Paladin","","","","","","","","","","","","","","","",16712190,"Paladin","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (112,16,3,-1,-1,0,0,0,0,0,0,"Hunter","","","","","","","","","","","","","","","",16712190,"Hunter","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (113,16,4,-1,-1,0,0,0,0,0,0,"Rogue","","","","","","","","","","","","","","","",16712190,"Rogue","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (114,16,5,-1,-1,0,0,0,0,0,0,"Priest","","","","","","","","","","","","","","","",16712190,"Priest","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (115,16,6,-1,-1,0,0,0,0,0,0,"Death Knight","","","","","","","","","","","","","","","",16712190,"Death Knight","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (116,16,7,-1,-1,0,0,0,0,0,0,"Shaman","","","","","","","","","","","","","","","",16712190,"Shaman","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (117,16,8,-1,-1,0,0,0,0,0,0,"Mage","","","","","","","","","","","","","","","",16712190,"Mage","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (118,16,9,-1,-1,0,0,0,0,0,0,"Warlock","","","","","","","","","","","","","","","",16712190,"Warlock","","","","","","","","","","","","","","","",16712190); 
INSERT INTO `ItemSubClass` VALUES (119,16,11,-1,-1,0,0,0,0,0,0,"Druid","","","","","","","","","","","","","","","",16712190,"Druid","","","","","","","","","","","","","","","",16712190); 