CREATE PROCEDURE `CHAR_DEL_EXPIRED_BANS`()
COMMENT 'Sets bans that are expired to active=false'
BEGIN
UPDATE character_banned SET active = 0 WHERE unbandate <= UNIX_TIMESTAMP() AND unbandate <> bandate;
END