DROP TABLE IF EXISTS `CameraShakes`; 
CREATE TABLE `CameraShakes` ( `ID` INT NOT NULL DEFAULT '0', `ShakeType` INT NOT NULL DEFAULT '0', `Direction` INT NOT NULL DEFAULT '0', `Amplitude` FLOAT NOT NULL DEFAULT '0', `Frequency` FLOAT NOT NULL DEFAULT '0', `Duration` FLOAT NOT NULL DEFAULT '0', `Phase` FLOAT NOT NULL DEFAULT '0', `Coefficient` FLOAT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `CameraShakes` VALUES (1,1,2,2,3,0.4,0.06,1),
(2,1,2,7,3,0.4,0.06,1),
(4,0,0,2,6,4,0,0.4),
(5,0,1,2,4,4,0,0.4),
(6,0,2,4,5.2,4,0,0.4),
(7,1,0,2,6,2,0,0.4),
(8,1,1,2,4,2,0,0.4),
(9,1,2,4,5.2,2,0,0.4),
(10,1,2,3,2,0.6,0.16,2),
(11,1,2,4,3,0.6,0.1,2),
(12,1,2,6,4,0.65,0.08,1),
(13,0,0,2,6,0.6,0,3),
(14,0,1,2,6,0.6,0,3),
(15,0,2,2,6,0.6,0,3),
(16,1,0,1,7,1,0,0.4),
(17,1,1,1,4,1,0,0.4),
(18,1,2,1,6,1,0,0.4),
(36,0,0,2,6,10,0,0.4),
(37,0,1,2,4,10,0,0.4),
(38,0,2,4,5.2,10,0,0.4),
(56,0,0,5,2.5,0.25,0,1),
(76,0,0,2,6,20,0,0.4),
(77,0,1,2,4,20,0,0.4),
(78,0,2,4,5.2,20,0,0.4),
(79,0,0,2,6,7,0,0.4),
(80,0,1,2,4,7,0,0.4),
(81,0,2,4,5.2,7,0,0.4),
(82,1,2,12,3,0.6,0.06,1),
(83,1,2,9,8,2,0.06,1),
(84,0,2,10,10,1.5,0,3),
(85,0,1,10,10,1.5,0,3),
(86,0,0,10,10,1.5,0,3),
(87,0,0,2,4,4,0,0.4),
(89,0,1,2,4,4,0,0.4),
(90,0,2,2,4,4,0,0.4),
(91,0,0,4,6,4,0,0.4),
(92,0,2,4,6,7,0,0.4),
(93,0,1,4,6,4,0,0.4),
(94,0,0,6,8,7,0,0.4),
(95,0,1,6,8,7,0,0.4),
(96,0,2,6,8,7,0,0.4),
(97,0,0,10,6,10,0,0.4),
(98,0,1,10,4,10,0,0.4),
(99,0,2,10,5.2,10,0,0.4),
(100,0,0,2,6,4,0,0.4),
(101,0,1,2,4,4,0,0.4),
(102,0,2,4,5.2,4,0,0.4),
(103,0,0,4,6,1,0,0.4),
(104,0,1,4,6,1,0,0.4),
(105,0,2,4,6,1,0,0.4),
(106,1,2,10,8,1,0.06,1),
(107,0,0,10,10,0.75,0,3),
(109,0,1,10,10,0.75,0,3),
(110,0,2,10,10,0.75,0,3),
(111,0,0,0.05,12,2,0,0.4),
(112,0,1,0.05,12,2,0,0.4),
(113,0,2,0.07,12,2,0,0.4),
(114,0,0,1.5,5,1,0,0.4),
(115,0,1,1.5,5,1,0,0.4),
(116,0,2,1.5,5,1,0,0.4),
(117,1,0,1,8,0.2,0,0.4),
(118,1,1,1,8,0.2,0,0.4),
(119,1,2,1,8,0.3,0,0.4),
(120,0,0,8,0.5,2,0,0.4),
(121,0,1,8,0.5,2,0,0.4),
(122,0,2,8,0.5,2,0,0.4),
(123,0,0,2,4,1,0,0.4),
(124,0,1,2,4,1,0,0.4),
(125,0,2,2,4,1,0,0.4),
(132,0,0,2,6,5,0,0.4),
(133,0,1,2,4,5,0,0.4),
(134,0,2,4,5.2,5,0,0.4),
(141,0,0,10,10,4,0,3),
(142,0,1,10,10,4,0,3),
(143,1,2,6,10,6,0,3),
(144,0,0,8,8,12,0,0.4),
(145,0,1,8,8,12,0,0.4),
(146,0,2,8,8,12,0,0.4); 
