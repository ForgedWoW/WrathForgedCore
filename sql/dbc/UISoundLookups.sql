DROP TABLE IF EXISTS `UISoundLookups`; 
CREATE TABLE `UISoundLookups` ( `ID` INT NOT NULL DEFAULT '0', `SoundID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `UISoundLookups` VALUES (1,777,"TITLEENTERWORLD"); 
INSERT INTO `UISoundLookups` VALUES (2,779,"TITLEQUIT"); 
INSERT INTO `UISoundLookups` VALUES (3,778,"TITLEOPTIONS"); 
INSERT INTO `UISoundLookups` VALUES (4,793,"TITLEOPTION16BIT"); 
INSERT INTO `UISoundLookups` VALUES (5,794,"TITLEOPTION32BIT"); 
INSERT INTO `UISoundLookups` VALUES (6,795,"TITLEOPTIONOPENGL"); 
INSERT INTO `UISoundLookups` VALUES (7,796,"TITLEOPTIONDIRECT3D"); 
INSERT INTO `UISoundLookups` VALUES (8,797,"TITLEOPTIONFULLSCREENMODE"); 
INSERT INTO `UISoundLookups` VALUES (9,798,"TITLEOPTIONOK"); 
INSERT INTO `UISoundLookups` VALUES (10,799,"TITLEOPTIONEXIT"); 
INSERT INTO `UISoundLookups` VALUES (11,800,"LOGIN"); 
INSERT INTO `UISoundLookups` VALUES (12,801,"LOGINNEWACCOUNT"); 
INSERT INTO `UISoundLookups` VALUES (13,802,"LOGINCHANGEREALM"); 
INSERT INTO `UISoundLookups` VALUES (14,803,"LOGINEXIT"); 
INSERT INTO `UISoundLookups` VALUES (15,792,"TITLEOPTIONSCREENRESOLUTION"); 
INSERT INTO `UISoundLookups` VALUES (16,790,"TITLECREDITS"); 
INSERT INTO `UISoundLookups` VALUES (17,791,"TITLEINTROMOVIE"); 
INSERT INTO `UISoundLookups` VALUES (18,805,"LOGINCHANGEREALMOK"); 
INSERT INTO `UISoundLookups` VALUES (19,806,"LOGINCHANGEREALMSELECT"); 
INSERT INTO `UISoundLookups` VALUES (20,807,"LOGINCHANGEREALMCANCEL"); 
INSERT INTO `UISoundLookups` VALUES (21,808,"CHARACTERSELECTION"); 
INSERT INTO `UISoundLookups` VALUES (22,809,"CHARACTERSELECTIONENTERWORLD"); 
INSERT INTO `UISoundLookups` VALUES (23,810,"CHARACTERSELECTIONDELCHARACTER"); 
INSERT INTO `UISoundLookups` VALUES (24,811,"CHARACTERSELECTIONACCTOPTIONS"); 
INSERT INTO `UISoundLookups` VALUES (25,812,"CHARACTERSELECTIONEXIT"); 
INSERT INTO `UISoundLookups` VALUES (26,813,"CHARACTERSELECTIONCREATENEW"); 
INSERT INTO `UISoundLookups` VALUES (27,814,"CHARACTERCREATIONCLASS"); 
INSERT INTO `UISoundLookups` VALUES (28,815,"CHARACTERCREATIONRACE"); 
INSERT INTO `UISoundLookups` VALUES (29,816,"CHARACTERCREATIONGENDER"); 
INSERT INTO `UISoundLookups` VALUES (30,817,"CHARACTERCREATIONLOOK"); 
INSERT INTO `UISoundLookups` VALUES (31,818,"CHARACTERCREATIONCREATECHAR"); 
INSERT INTO `UISoundLookups` VALUES (32,819,"CHARACTERCREATIONCANCEL"); 
INSERT INTO `UISoundLookups` VALUES (33,820,"CURRENTACTIVESPELL"); 
INSERT INTO `UISoundLookups` VALUES (34,821,"MINIMAPOPEN"); 
INSERT INTO `UISoundLookups` VALUES (35,822,"MINIMAPCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (36,823,"MINIMAPZOOMIN"); 
INSERT INTO `UISoundLookups` VALUES (37,824,"MINIMAPZOOMOUT"); 
INSERT INTO `UISoundLookups` VALUES (38,825,"CHATEMOTEBUTTON"); 
INSERT INTO `UISoundLookups` VALUES (39,826,"CHATSCROLLUP"); 
INSERT INTO `UISoundLookups` VALUES (40,827,"CHATSCROLLDOWN"); 
INSERT INTO `UISoundLookups` VALUES (41,828,"CHATBOTTOM"); 
INSERT INTO `UISoundLookups` VALUES (42,829,"SPELLBOOKOPEN"); 
INSERT INTO `UISoundLookups` VALUES (43,830,"SPELLBOOKCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (44,836,"SPELLBOKPAGETURN"); 
INSERT INTO `UISoundLookups` VALUES (45,832,"SPELLBOOKSPELLICONPICKUP"); 
INSERT INTO `UISoundLookups` VALUES (46,833,"SPELLBOOKSPELLICONDROP"); 
INSERT INTO `UISoundLookups` VALUES (47,834,"ABILITYOPEN"); 
INSERT INTO `UISoundLookups` VALUES (48,835,"ABILITYCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (49,836,"ABILIITYPAGETURN"); 
INSERT INTO `UISoundLookups` VALUES (50,837,"ABILITYICONPICKUP"); 
INSERT INTO `UISoundLookups` VALUES (51,838,"ABILITYICONDROP"); 
INSERT INTO `UISoundLookups` VALUES (52,839,"CHARACTERINFOOPEN"); 
INSERT INTO `UISoundLookups` VALUES (53,840,"CHARACTERINFOCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (54,841,"CHARACTERINFOTAB"); 
INSERT INTO `UISoundLookups` VALUES (55,842,"CHARACTERINFOSCROLLUP"); 
INSERT INTO `UISoundLookups` VALUES (56,843,"CHARACTERINFOSCROLLDOWN"); 
INSERT INTO `UISoundLookups` VALUES (57,844,"QUESTLOGOPEN"); 
INSERT INTO `UISoundLookups` VALUES (58,845,"QUESTLOGCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (59,846,"QUESTLOGABANDONQUEST"); 
INSERT INTO `UISoundLookups` VALUES (60,847,"QUESTFAILED"); 
INSERT INTO `UISoundLookups` VALUES (61,848,"SOCIALOPEN"); 
INSERT INTO `UISoundLookups` VALUES (62,849,"SOCIALCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (63,850,"MAINMENUOPEN"); 
INSERT INTO `UISoundLookups` VALUES (64,851,"MAINMENUCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (65,852,"MAINMENUOPTION"); 
INSERT INTO `UISoundLookups` VALUES (66,853,"MAINMENULOGOUT"); 
INSERT INTO `UISoundLookups` VALUES (67,854,"MAINMENUQUIT"); 
INSERT INTO `UISoundLookups` VALUES (68,855,"MAINMENUCONTINUE"); 
INSERT INTO `UISoundLookups` VALUES (69,856,"MAINMENUOPTIONCHECKBOXON"); 
INSERT INTO `UISoundLookups` VALUES (70,857,"MAINMENUOPTIONCHECKBOXOFF"); 
INSERT INTO `UISoundLookups` VALUES (71,858,"MAINMENUOPTIONFADERTAB"); 
INSERT INTO `UISoundLookups` VALUES (72,859,"INVENTORYOEPN"); 
INSERT INTO `UISoundLookups` VALUES (73,860,"INVENTORYCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (74,861,"INVENTORYROTATECHARACTER"); 
INSERT INTO `UISoundLookups` VALUES (75,862,"BACKPACKOPEN"); 
INSERT INTO `UISoundLookups` VALUES (76,863,"BACKPACKCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (77,864,"BACKPACKCOINSELECT"); 
INSERT INTO `UISoundLookups` VALUES (78,865,"BACKPACKCOINOK"); 
INSERT INTO `UISoundLookups` VALUES (79,866,"BACKPACKCOINCANCEL"); 
INSERT INTO `UISoundLookups` VALUES (80,867,"CHARACTERNPCSELECT"); 
INSERT INTO `UISoundLookups` VALUES (81,868,"CHARACTERNPCDESELECT"); 
INSERT INTO `UISoundLookups` VALUES (82,869,"CHARACTERSELECT"); 
INSERT INTO `UISoundLookups` VALUES (83,870,"CHARACTERDESELECT"); 
INSERT INTO `UISoundLookups` VALUES (84,871,"CREATURENEUTRALSELECT"); 
INSERT INTO `UISoundLookups` VALUES (85,872,"CREATURENEUTRALDESELECT"); 
INSERT INTO `UISoundLookups` VALUES (86,873,"CREATUREAGGROSELECT"); 
INSERT INTO `UISoundLookups` VALUES (87,874,"CREATUREAGGRODESELECT"); 
INSERT INTO `UISoundLookups` VALUES (88,875,"QUESTLISTOPEN"); 
INSERT INTO `UISoundLookups` VALUES (89,876,"QUESTLISTCLOSE"); 
INSERT INTO `UISoundLookups` VALUES (90,877,"QUESTLISTSELECT"); 
INSERT INTO `UISoundLookups` VALUES (91,878,"QUESTLISTCOMPLETE"); 
INSERT INTO `UISoundLookups` VALUES (92,879,"QUESTCANCEL"); 
INSERT INTO `UISoundLookups` VALUES (93,880,"PLAYERINVITE"); 
INSERT INTO `UISoundLookups` VALUES (94,881,"PLAYERINVITEACCEPT"); 
INSERT INTO `UISoundLookups` VALUES (95,882,"PLAYERINVITEDECLINE"); 
INSERT INTO `UISoundLookups` VALUES (96,885,"GAMEERRORUNABLETOEQUIP"); 
INSERT INTO `UISoundLookups` VALUES (97,886,"ITEMGENERICSOUND"); 
INSERT INTO `UISoundLookups` VALUES (98,887,"GAMEERRORINVALIDTARGET"); 
INSERT INTO `UISoundLookups` VALUES (99,888,"LEVELUP"); 
INSERT INTO `UISoundLookups` VALUES (100,889,"GAMEERROROUTOFRANGE"); 
INSERT INTO `UISoundLookups` VALUES (101,890,"QUESTADDED"); 
INSERT INTO `UISoundLookups` VALUES (102,891,"MONEYFRAMEOPEN"); 
INSERT INTO `UISoundLookups` VALUES (103,892,"MONEYFRAMECLOSE"); 
INSERT INTO `UISoundLookups` VALUES (104,893,"LOOTFRAMEOPEN"); 
INSERT INTO `UISoundLookups` VALUES (105,894,"LOOTFRAMECLOSE"); 
INSERT INTO `UISoundLookups` VALUES (106,895,"LOOTFRAMECOINSOUND"); 
INSERT INTO `UISoundLookups` VALUES (107,897,"GAMEHIGHLIGHTHOSTILEUNIT"); 
INSERT INTO `UISoundLookups` VALUES (108,898,"GAMEHIGHLIGHTNEUTRALUNIT"); 
INSERT INTO `UISoundLookups` VALUES (109,899,"GAMEHIGHLIGHTFRIENDLYUNIT"); 
INSERT INTO `UISoundLookups` VALUES (110,900,"LOSTTARGETUNIT"); 
INSERT INTO `UISoundLookups` VALUES (111,902,"CURSORGRABOBJECT"); 
INSERT INTO `UISoundLookups` VALUES (112,903,"CURSORDROPOBJECT"); 
INSERT INTO `UISoundLookups` VALUES (113,904,"GAMESCREENMEDIUMBUTTONMOUSEDOWN"); 
INSERT INTO `UISoundLookups` VALUES (114,905,"GAMEABILITYACTIVATE"); 
INSERT INTO `UISoundLookups` VALUES (115,906,"GAMESPELLACTIVATE"); 
INSERT INTO `UISoundLookups` VALUES (116,1115,"CHATOPTIONSBUTTONS"); 
INSERT INTO `UISoundLookups` VALUES (117,1115,"ACTIONBARSCROLLBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (118,1115,"STATSELECTIONBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (119,1115,"OPTIONSSCREENCONTROLS"); 
INSERT INTO `UISoundLookups` VALUES (120,1115,"TRADESCREENSCROLLBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (121,1115,"TRAINERSCREENSCROLLBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (122,1115,"SPLITITEMBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (123,1115,"SPLITMONEYBUTTONDOWN"); 
INSERT INTO `UISoundLookups` VALUES (124,1264,"LOOTFRAMEOPENEMPTY"); 
INSERT INTO `UISoundLookups` VALUES (125,1519,"NEWTAXIPATH"); 
INSERT INTO `UISoundLookups` VALUES (126,2580,"UNWRAPGIFT"); 
INSERT INTO `UISoundLookups` VALUES (127,3093,"WRITEQUEST"); 
INSERT INTO `UISoundLookups` VALUES (147,3081,"TELLMESSAGE"); 
INSERT INTO `UISoundLookups` VALUES (167,3356,"LOOTWINDOWOPENFISHING"); 