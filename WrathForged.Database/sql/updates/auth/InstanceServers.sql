CREATE TABLE IF NOT EXISTS  `instancelist` (
	`id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
	`realm` INT(10) UNSIGNED NOT NULL,
	`ipaddress` VARCHAR(255) NOT NULL COLLATE 'utf8mb4_unicode_ci',
	`port` INT(10) UNSIGNED NOT NULL,
	`playercount` INT(10) UNSIGNED NOT NULL,
	`created` DATETIME NOT NULL,
	PRIMARY KEY (`id`) USING BTREE,
	INDEX `FK_instancelist_realmlist` (`realm`) USING BTREE,
	CONSTRAINT `FK_instancelist_realmlist` FOREIGN KEY (`realm`) REFERENCES `realmlist` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
);

DELETE FROM `instancelist` WHERE `id`=1;
INSERT INTO `instancelist` (`id`, `realm`, `ipaddress`, `port`, `playercount`, `created`) VALUES (1, 1, '127.0.0.1', 8780, 0, '2023-10-01 19:27:06');


CREATE TABLE IF NOT EXISTS  `instancemaps` (
	`instanceid` INT(10) UNSIGNED NOT NULL,
	`mapid` INT(10) UNSIGNED NOT NULL,
	`difficulty` INT(10) UNSIGNED NOT NULL,
	PRIMARY KEY (`instanceid`, `mapid`, `difficulty`) USING BTREE,
	INDEX `instanceid` (`instanceid`) USING BTREE,
	INDEX `mapid` (`mapid`) USING BTREE,
	CONSTRAINT `FK_instancemaps_instancelist` FOREIGN KEY (`instanceid`) REFERENCES `instancelist` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
);

DELETE FROM `instancemaps` WHERE `instanceid`=1 AND `mapid`=0 AND `difficulty`=0;
INSERT INTO `instancemaps` (`instanceid`, `mapid`, `difficulty`) VALUES (1, 0, 0);

CREATE TABLE IF NOT EXISTS  `instancecharacters` (
	`instanceid` INT(10) UNSIGNED NOT NULL,
	`accountid` INT(10) UNSIGNED NOT NULL,
	`characterid` INT(10) UNSIGNED NOT NULL,
	`jointime` DATETIME NOT NULL,
	`lastleavetime` DATETIME NOT NULL,
	`leavecount` DATETIME NOT NULL,
	PRIMARY KEY (`instanceid`, `accountid`, `characterid`) USING BTREE,
	INDEX `FK__account` (`accountid`) USING BTREE,
	CONSTRAINT `FK__account` FOREIGN KEY (`accountid`) REFERENCES `account` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK__instancelist` FOREIGN KEY (`instanceid`) REFERENCES `instancelist` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)