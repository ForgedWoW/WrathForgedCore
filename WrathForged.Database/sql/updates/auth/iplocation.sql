CREATE TABLE IF NOT EXISTS `ip_location` (
	`ipaddress` VARCHAR(16) NOT NULL COLLATE 'utf8mb4_unicode_ci',
	`addressinfo` VARCHAR(4000) NOT NULL COLLATE 'utf8mb4_unicode_ci',
	PRIMARY KEY (`ipaddress`) USING BTREE
)