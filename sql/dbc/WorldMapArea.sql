DROP TABLE IF EXISTS `WorldMapArea`; 
CREATE TABLE `WorldMapArea` ( `ID` INT NOT NULL DEFAULT '0', `MapID` INT NOT NULL DEFAULT '0', `AreaID` INT NOT NULL DEFAULT '0', `AreaName` TEXT NULL, `LocLeft` FLOAT NOT NULL DEFAULT '0', `LocRight` FLOAT NOT NULL DEFAULT '0', `LocTop` FLOAT NOT NULL DEFAULT '0', `LocBottom` FLOAT NOT NULL DEFAULT '0', `DisplayMapID` INT NOT NULL DEFAULT '0', `DefaultDungeonFloor` INT NOT NULL DEFAULT '0', `ParentWorldMapID` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `WorldMapArea` VALUES (4,1,14,"Durotar",-1962.5,-7250,1808.333,-1716.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (9,1,215,"Mulgore",2047.917,-3089.583,-272.9167,-3697.917,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (11,1,17,"Barrens",2622.917,-7510.417,1612.5,-5143.75,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (13,1,0,"Kalimdor",17066.6,-19733.21,12799.9,-11733.3,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (14,0,0,"Azeroth",18171.97,-22569.21,11176.34,-15973.34,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (15,0,36,"Alterac",783.3333,-2016.667,1500,-366.6667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (16,0,45,"Arathi",-866.6666,-4466.667,-133.3333,-2533.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (17,0,3,"Badlands",-2079.167,-4566.667,-5889.583,-7547.917,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (19,0,4,"BlastedLands",-1241.667,-4591.667,-10566.67,-12800,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (20,0,85,"Tirisfal",3033.333,-1485.417,3837.5,824.9999,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (21,0,130,"Silverpine",3450,-750,1666.667,-1133.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (22,0,28,"WesternPlaguelands",416.6667,-3883.333,3366.667,500,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (23,0,139,"EasternPlaguelands",-2287.5,-6318.75,3704.167,1016.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (24,0,267,"Hilsbrad",1066.667,-2133.333,400,-1733.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (26,0,47,"Hinterlands",-1575,-5425,1466.667,-1100,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (27,0,1,"DunMorogh",1802.083,-3122.917,-3877.083,-7160.417,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (28,0,51,"SearingGorge",-322.9167,-2554.167,-6100,-7587.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (29,0,46,"BurningSteppes",-266.6667,-3195.833,-7031.25,-8983.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (30,0,12,"Elwynn",1535.417,-1935.417,-7939.583,-10254.17,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (32,0,41,"DeadwindPass",-833.3333,-3333.333,-9866.666,-11533.33,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (34,0,10,"Duskwood",833.3333,-1866.667,-9716.666,-11516.67,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (35,0,38,"LochModan",-1993.75,-4752.083,-4487.5,-6327.083,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (36,0,44,"Redridge",-1570.833,-3741.667,-8575,-10022.92,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (37,0,33,"Stranglethorn",2220.833,-4160.417,-11168.75,-15422.92,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (38,0,8,"SwampOfSorrows",-2222.917,-4516.667,-9620.833,-11150,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (39,0,40,"Westfall",3016.667,-483.3333,-9400,-11733.33,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (40,0,11,"Wetlands",-389.5833,-4525,-2147.917,-4904.167,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (41,1,141,"Teldrassil",3814.583,-1277.083,11831.25,8437.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (42,1,148,"Darkshore",2941.667,-3608.333,8333.333,3966.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (43,1,331,"Ashenvale",1700,-4066.667,4672.917,829.1666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (61,1,400,"ThousandNeedles",-433.3333,-4833.333,-3966.667,-6900,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (81,1,406,"StonetalonMountains",3245.833,-1637.5,2916.667,-339.5833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (101,1,405,"Desolace",4233.333,-262.5,452.0833,-2545.833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (121,1,357,"Feralas",5441.667,-1508.333,-2366.667,-7000,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (141,1,15,"Dustwallow",-974.9999,-6225,-2033.333,-5533.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (161,1,440,"Tanaris",-218.75,-7118.75,-5875,-10475,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (181,1,16,"Aszhara",-3277.083,-8347.916,5341.667,1960.417,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (182,1,361,"Felwood",1641.667,-4108.333,7133.333,3300,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (201,1,490,"UngoroCrater",533.3333,-3166.667,-5966.667,-8433.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (241,1,493,"Moonglade",-1381.25,-3689.583,8491.666,6952.083,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (261,1,1377,"Silithus",2537.5,-945.834,-5958.334,-8281.25,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (281,1,618,"Winterspring",-316.6667,-7416.667,8533.333,3800,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (301,0,1519,"Stormwind",1722.917,-14.58333,-7995.833,-9154.166,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (321,1,1637,"Ogrimmar",-3680.601,-5083.206,2273.877,1338.461,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (341,0,1537,"Ironforge",-713.5914,-1504.216,-4569.241,-5096.846,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (362,1,1638,"ThunderBluff",516.6666,-527.0833,-849.9999,-1545.833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (381,1,1657,"Darnassis",2938.363,1880.03,10238.32,9532.587,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (382,0,1497,"Undercity",873.1926,-86.1824,1877.945,1237.841,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (401,30,2597,"AlteracValley",1781.25,-2456.25,1085.417,-1739.583,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (443,489,3277,"WarsongGulch",2041.667,895.8333,1627.083,862.4999,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (461,529,3358,"ArathiBasin",1858.333,102.0833,1508.333,337.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (462,530,3430,"EversongWoods",-4487.5,-9412.5,11041.67,7758.333,0,0,0); 
INSERT INTO `WorldMapArea` VALUES (463,530,3433,"Ghostlands",-5283.333,-8583.333,8266.666,6066.667,0,0,0); 
INSERT INTO `WorldMapArea` VALUES (464,530,3524,"AzuremystIsle",-10500,-14570.83,-2793.75,-5508.333,1,0,0); 
INSERT INTO `WorldMapArea` VALUES (465,530,3483,"Hellfire",5539.583,375,1481.25,-1962.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (466,530,0,"Expansion01",12996.04,-4468.039,5821.359,-5821.359,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (467,530,3521,"Zangarmarsh",9475,4447.917,1935.417,-1416.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (471,530,3557,"TheExodar",-11066.37,-12123.14,-3609.683,-4314.371,1,0,0); 
INSERT INTO `WorldMapArea` VALUES (473,530,3520,"ShadowmoonValley",4225,-1275,-1947.917,-5614.583,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (475,530,3522,"BladesEdgeMountains",8845.833,3420.833,4408.333,791.6666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (476,530,3525,"BloodmystIsle",-10075,-13337.5,-758.3333,-2933.333,1,0,0); 
INSERT INTO `WorldMapArea` VALUES (477,530,3518,"Nagrand",10295.83,4770.833,41.66666,-3641.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (478,530,3519,"TerokkarForest",7083.333,1683.333,-999.9999,-4600,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (479,530,3523,"Netherstorm",5483.333,-91.66666,5456.25,1739.583,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (480,530,3487,"SilvermoonCity",-6400.75,-7612.208,10153.71,9346.938,0,0,0); 
INSERT INTO `WorldMapArea` VALUES (481,530,3703,"ShattrathCity",6135.259,4829.009,-1473.954,-2344.788,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (482,566,3820,"NetherstormArena",2660.417,389.5833,2918.75,1404.167,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (485,571,0,"Northrend",9217.152,-8534.246,10593.38,-1240.89,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (486,571,3537,"BoreanTundra",8570.833,2806.25,4897.917,1054.167,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (488,571,65,"Dragonblight",3627.083,-1981.25,5575,1835.417,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (490,571,394,"GrizzlyHills",-1110.417,-6360.417,5516.667,2016.667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (491,571,495,"HowlingFjord",-1397.917,-7443.75,3116.667,-914.5833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (492,571,210,"IcecrownGlacier",5443.75,-827.0833,9427.083,5245.833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (493,571,3711,"SholazarBasin",6929.167,2572.917,7287.5,4383.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (495,571,67,"TheStormPeaks",1841.667,-5270.833,10197.92,5456.25,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (496,571,66,"ZulDrak",-600,-5593.75,7668.75,4339.583,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (499,530,4080,"Sunwell",-5302.083,-8629.166,13568.75,11350,0,0,0); 
INSERT INTO `WorldMapArea` VALUES (501,571,4197,"LakeWintergrasp",4329.167,1354.167,5716.667,3733.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (502,609,4298,"ScarletEnclave",-4047.917,-7210.417,3087.5,979.1666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (504,571,4395,"Dalaran",0,0,0,0,-1,27,510); 
INSERT INTO `WorldMapArea` VALUES (510,571,2817,"CrystalsongForest",1443.75,-1279.167,6502.083,4687.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (512,607,4384,"StrandoftheAncients",787.5,-956.2499,1883.333,720.8333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (520,576,4265,"TheNexus",0,0,0,0,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (521,595,4100,"CoTStratholme",2152.083,327.0833,2297.917,1081.25,-1,-1,0); 
INSERT INTO `WorldMapArea` VALUES (522,619,4494,"Ahnkahet",-233.3333,-1206.25,849.9999,202.0833,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (523,574,206,"UtgardeKeep",0,0,0,0,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (524,575,1196,"UtgardePinnacle",3275,-3275,2166.667,-2200,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (525,602,4272,"HallsofLightning",2500,-899.9999,2200,-66.66666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (526,599,4264,"Ulduar77",2766.667,-633.3333,2200,-66.66666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (527,616,4500,"TheEyeofEternity",2766.667,-633.3333,2200,-66.66666,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (528,578,4228,"Nexus80",2337.5,-262.5,1956.25,222.9167,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (529,603,4273,"Ulduar",1583.333,-1704.167,1168.75,-1022.917,-1,-1,0); 
INSERT INTO `WorldMapArea` VALUES (530,604,4416,"Gundrak",1310.417,166.6667,2122.917,1360.417,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (531,615,4493,"TheObsidianSanctum",1133.333,-29.16667,3616.667,2841.667,-1,0,488); 
INSERT INTO `WorldMapArea` VALUES (532,624,4603,"VaultofArchavon",1033.333,-1566.667,600,-1133.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (533,601,4277,"AzjolNerub",1020.833,-52.08333,872.9166,158.3333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (534,600,4196,"DrakTharonKeep",-377.0833,-1004.167,-168.75,-587.5,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (535,533,3456,"Naxxramas",-2520.833,-4377.083,3597.917,2360.417,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (536,608,4415,"VioletHold",983.3333,600,2006.25,1750,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (540,628,4710,"IsleofConquest",525,-2125,1708.333,-58.33333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (541,571,4742,"HrothgarsLanding",2797.917,-879.1666,10781.25,8329.166,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (542,650,4723,"TheArgentColiseum",2100,-500,2200,466.6667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (543,649,4722,"TheArgentColiseum",2100,-500,2200,466.6667,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (601,632,4809,"TheForgeofSouls",7033.333,-4366.667,6466.667,-1133.333,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (602,658,4813,"PitofSaron",839.5833,-693.75,1256.25,233.3333,-1,0,492); 
INSERT INTO `WorldMapArea` VALUES (603,668,4820,"HallsofReflection",7033.333,-5966.667,6466.667,-2200,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (604,631,4812,"IcecrownCitadel",6366.667,-5833.333,5933.333,-2200,-1,0,0); 
INSERT INTO `WorldMapArea` VALUES (609,724,4987,"TheRubySanctum",902.0833,150,3429.167,2927.083,-1,0,0); 
