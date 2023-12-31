DROP TABLE IF EXISTS `GMSurveyQuestions`; 
CREATE TABLE `GMSurveyQuestions` ( `ID` INT NOT NULL DEFAULT '0', `Question_Lang_enUS` TEXT NULL, `Question_Lang_enGB` TEXT NULL, `Question_Lang_koKR` TEXT NULL, `Question_Lang_frFR` TEXT NULL, `Question_Lang_deDE` TEXT NULL, `Question_Lang_enCN` TEXT NULL, `Question_Lang_zhCN` TEXT NULL, `Question_Lang_enTW` TEXT NULL, `Question_Lang_zhTW` TEXT NULL, `Question_Lang_esES` TEXT NULL, `Question_Lang_esMX` TEXT NULL, `Question_Lang_ruRU` TEXT NULL, `Question_Lang_ptPT` TEXT NULL, `Question_Lang_ptBR` TEXT NULL, `Question_Lang_itIT` TEXT NULL, `Question_Lang_Unk` TEXT NULL, `Question_Lang_Mask` INT UNSIGNED NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `GMSurveyQuestions` VALUES (28,"Did the GM provide an appropriate answer or solution to your question/problem?","","","","","","","","","","","","","","","",16712190),
(29,"How easy was it to understand and/or follow the information provided?","","","","","","","","","","","","","","","",16712190),
(30,"Was the GM knowledgeable, respectful, and empathetic during your interactions?","","","","","","","","","","","","","","","",16712190),
(31,"How would you rate the response time to address your petition?","","","","","","","","","","","","","","","",16712190),
(32,"How would you rate the overall experience with the GM that assisted you with your petition?","","","","","","","","","","","","","","","",16712190),
(33,"Based on your support experience, how likely is it that you would recommend WoW to others?","","","","","","","","","","","","","","","",16712190),
(35,"Based on this customer service experience, how likely are you to recommend Blizzard products and services to a friend?","","","","","","","","","","","","","","","",16712190),
(36,"Was your problem solved?","","","","","","","","","","","","","","","",16712190),
(37,"My overall experience with Blizzard Customer Service was:","","","","","","","","","","","","","","","",16712190),
(38,"My wait time for Blizzard Customer Service was:","","","","","","","","","","","","","","","",16712190),
(39,"This Blizzard Representative’s professionalism was:","","","","","","","","","","","","","","","",16712190),
(40,"This Blizzard Representative’s communication skills were:","","","","","","","","","","","","","","","",16712190),
(41,"This Blizzard Representative’s overall service was:","","","","","","","","","","","","","","","",16712190); 
