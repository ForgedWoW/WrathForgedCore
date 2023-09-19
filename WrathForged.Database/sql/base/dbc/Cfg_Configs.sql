CREATE TABLE `cfg_configs` (
  `Id` int NOT NULL DEFAULT '0',
  `RealmType` int NOT NULL DEFAULT '0',
  `PlayerKillingAllowed` int NOT NULL DEFAULT '0',
  `Roleplaying` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`));


--
-- Records of `cfg_configs`
--

INSERT INTO `cfg_configs` VALUES ('1', '0', '0', '0');
INSERT INTO `cfg_configs` VALUES ('2', '1', '1', '0');
INSERT INTO `cfg_configs` VALUES ('3', '2', '0', '0');
INSERT INTO `cfg_configs` VALUES ('4', '3', '1', '0');
INSERT INTO `cfg_configs` VALUES ('5', '4', '0', '0');
INSERT INTO `cfg_configs` VALUES ('6', '5', '1', '0');
INSERT INTO `cfg_configs` VALUES ('7', '6', '0', '1');
INSERT INTO `cfg_configs` VALUES ('8', '7', '0', '1');
INSERT INTO `cfg_configs` VALUES ('9', '8', '1', '1');
INSERT INTO `cfg_configs` VALUES ('10', '9', '0', '0');
INSERT INTO `cfg_configs` VALUES ('11', '10', '1', '0');
INSERT INTO `cfg_configs` VALUES ('12', '11', '0', '0');
INSERT INTO `cfg_configs` VALUES ('13', '12', '1', '0');