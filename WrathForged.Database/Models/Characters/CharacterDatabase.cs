// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.EntityFrameworkCore;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterDatabase : DbContext
{
    public CharacterDatabase()
    {
    }

    public CharacterDatabase(DbContextOptions<CharacterDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountDatum> AccountData { get; set; }

    public virtual DbSet<AccountInstanceTime> AccountInstanceTimes { get; set; }

    public virtual DbSet<AccountTutorial> AccountTutorials { get; set; }

    public virtual DbSet<Addon> Addons { get; set; }

    public virtual DbSet<ArenaTeam> ArenaTeams { get; set; }

    public virtual DbSet<ArenaTeamMember> ArenaTeamMembers { get; set; }

    public virtual DbSet<Auctionbidder> Auctionbidders { get; set; }

    public virtual DbSet<Auctionhouse> Auctionhouses { get; set; }

    public virtual DbSet<BannedAddon> BannedAddons { get; set; }

    public virtual DbSet<BattlegroundDeserter> BattlegroundDeserters { get; set; }

    public virtual DbSet<Bugreport> Bugreports { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<CalendarInvite> CalendarInvites { get; set; }

    public virtual DbSet<Channel> Channels { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<CharacterAccountDatum> CharacterAccountData { get; set; }

    public virtual DbSet<CharacterAchievement> CharacterAchievements { get; set; }

    public virtual DbSet<CharacterAchievementProgress> CharacterAchievementProgresses { get; set; }

    public virtual DbSet<CharacterAction> CharacterActions { get; set; }

    public virtual DbSet<CharacterArenaStat> CharacterArenaStats { get; set; }

    public virtual DbSet<CharacterAura> CharacterAuras { get; set; }

    public virtual DbSet<CharacterBanned> CharacterBanneds { get; set; }

    public virtual DbSet<CharacterBattlegroundDatum> CharacterBattlegroundData { get; set; }

    public virtual DbSet<CharacterBattlegroundRandom> CharacterBattlegroundRandoms { get; set; }

    public virtual DbSet<CharacterDeclinedname> CharacterDeclinednames { get; set; }

    public virtual DbSet<CharacterEquipmentset> CharacterEquipmentsets { get; set; }

    public virtual DbSet<CharacterFishingstep> CharacterFishingsteps { get; set; }

    public virtual DbSet<CharacterGift> CharacterGifts { get; set; }

    public virtual DbSet<CharacterGlyph> CharacterGlyphs { get; set; }

    public virtual DbSet<CharacterHomebind> CharacterHomebinds { get; set; }

    public virtual DbSet<CharacterInstance> CharacterInstances { get; set; }

    public virtual DbSet<CharacterInventory> CharacterInventories { get; set; }

    public virtual DbSet<CharacterPet> CharacterPets { get; set; }

    public virtual DbSet<CharacterPetDeclinedname> CharacterPetDeclinednames { get; set; }

    public virtual DbSet<CharacterQueststatus> CharacterQueststatuses { get; set; }

    public virtual DbSet<CharacterQueststatusDaily> CharacterQueststatusDailies { get; set; }

    public virtual DbSet<CharacterQueststatusMonthly> CharacterQueststatusMonthlies { get; set; }

    public virtual DbSet<CharacterQueststatusRewarded> CharacterQueststatusRewardeds { get; set; }

    public virtual DbSet<CharacterQueststatusSeasonal> CharacterQueststatusSeasonals { get; set; }

    public virtual DbSet<CharacterQueststatusWeekly> CharacterQueststatusWeeklies { get; set; }

    public virtual DbSet<CharacterReputation> CharacterReputations { get; set; }

    public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }

    public virtual DbSet<CharacterSocial> CharacterSocials { get; set; }

    public virtual DbSet<CharacterSpell> CharacterSpells { get; set; }

    public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldowns { get; set; }

    public virtual DbSet<CharacterStat> CharacterStats { get; set; }

    public virtual DbSet<CharacterTalent> CharacterTalents { get; set; }

    public virtual DbSet<Corpse> Corpses { get; set; }

    public virtual DbSet<GameEventConditionSave> GameEventConditionSaves { get; set; }

    public virtual DbSet<GameEventSave> GameEventSaves { get; set; }

    public virtual DbSet<GmSubsurvey> GmSubsurveys { get; set; }

    public virtual DbSet<GmSurvey> GmSurveys { get; set; }

    public virtual DbSet<GmTicket> GmTickets { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupInstance> GroupInstances { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Guild> Guilds { get; set; }

    public virtual DbSet<GuildBankEventlog> GuildBankEventlogs { get; set; }

    public virtual DbSet<GuildBankItem> GuildBankItems { get; set; }

    public virtual DbSet<GuildBankRight> GuildBankRights { get; set; }

    public virtual DbSet<GuildBankTab> GuildBankTabs { get; set; }

    public virtual DbSet<GuildEventlog> GuildEventlogs { get; set; }

    public virtual DbSet<GuildMember> GuildMembers { get; set; }

    public virtual DbSet<GuildMemberWithdraw> GuildMemberWithdraws { get; set; }

    public virtual DbSet<GuildRank> GuildRanks { get; set; }

    public virtual DbSet<Instance> Instances { get; set; }

    public virtual DbSet<InstanceReset> InstanceResets { get; set; }

    public virtual DbSet<ItemInstance> ItemInstances { get; set; }

    public virtual DbSet<ItemLootItem> ItemLootItems { get; set; }

    public virtual DbSet<ItemLootMoney> ItemLootMoneys { get; set; }

    public virtual DbSet<ItemRefundInstance> ItemRefundInstances { get; set; }

    public virtual DbSet<ItemSoulboundTradeDatum> ItemSoulboundTradeData { get; set; }

    public virtual DbSet<LagReport> LagReports { get; set; }

    public virtual DbSet<LfgDatum> LfgData { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<MailItem> MailItems { get; set; }

    public virtual DbSet<PetAura> PetAuras { get; set; }

    public virtual DbSet<PetSpell> PetSpells { get; set; }

    public virtual DbSet<PetSpellCooldown> PetSpellCooldowns { get; set; }

    public virtual DbSet<Petition> Petitions { get; set; }

    public virtual DbSet<PetitionSign> PetitionSigns { get; set; }

    public virtual DbSet<PoolQuestSave> PoolQuestSaves { get; set; }

    public virtual DbSet<PvpstatsBattleground> PvpstatsBattlegrounds { get; set; }

    public virtual DbSet<PvpstatsPlayer> PvpstatsPlayers { get; set; }

    public virtual DbSet<QuestTracker> QuestTrackers { get; set; }

    public virtual DbSet<ReservedName> ReservedNames { get; set; }

    public virtual DbSet<Respawn> Respawns { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<WardenAction> WardenActions { get; set; }

    public virtual DbSet<Worldstate> Worldstates { get; set; }

    private static readonly int[] _default2byteArray = [0, 0];
    private static readonly int[] _default3byteArray = [0, 0, 0];
    private static readonly int[] _default4byteArray = [0, 0, 0, 0];
    private static readonly int[] _default5byteArray = [0, 0, 0, 0, 0];

    public void RunSqlFile(string filePath)
    {
        var sql = File.ReadAllText(filePath);
        _ = Database.ExecuteSqlRaw(sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        _ = modelBuilder.Entity<AccountDatum>(entity =>
        {
            _ = entity.HasKey(e => new { e.AccountId, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("account_data")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AccountId)
                .HasComment("Account Identifier")
                .HasColumnName("accountId");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.Data)
                .HasColumnType("blob")
                .HasColumnName("data");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<AccountInstanceTime>(entity =>
        {
            _ = entity.HasKey(e => new { e.AccountId, e.InstanceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("account_instance_times")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AccountId).HasColumnName("accountId");
            _ = entity.Property(e => e.InstanceId).HasColumnName("instanceId");
            _ = entity.Property(e => e.ReleaseTime).HasColumnName("releaseTime");
        });

        _ = modelBuilder.Entity<AccountTutorial>(entity =>
        {
            _ = entity.HasKey(e => e.AccountId).HasName("PRIMARY");

            _ = entity
                .ToTable("account_tutorial")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasComment("Account Identifier")
                .HasColumnName("accountId");
            _ = entity.Property(e => e.Tut0).HasColumnName("tut0");
            _ = entity.Property(e => e.Tut1).HasColumnName("tut1");
            _ = entity.Property(e => e.Tut2).HasColumnName("tut2");
            _ = entity.Property(e => e.Tut3).HasColumnName("tut3");
            _ = entity.Property(e => e.Tut4).HasColumnName("tut4");
            _ = entity.Property(e => e.Tut5).HasColumnName("tut5");
            _ = entity.Property(e => e.Tut6).HasColumnName("tut6");
            _ = entity.Property(e => e.Tut7).HasColumnName("tut7");
        });

        _ = modelBuilder.Entity<Addon>(entity =>
        {
            _ = entity.HasKey(e => e.Name).HasName("PRIMARY");

            _ = entity
                .ToTable("addons", tb => tb.HasComment("Addons"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.Crc).HasColumnName("crc");
        });

        _ = modelBuilder.Entity<ArenaTeam>(entity =>
        {
            _ = entity.HasKey(e => e.ArenaTeamId).HasName("PRIMARY");

            _ = entity
                .ToTable("arena_team")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ArenaTeamId)
                .ValueGeneratedNever()
                .HasColumnName("arenaTeamId");
            _ = entity.Property(e => e.BackgroundColor).HasColumnName("backgroundColor");
            _ = entity.Property(e => e.BorderColor).HasColumnName("borderColor");
            _ = entity.Property(e => e.BorderStyle).HasColumnName("borderStyle");
            _ = entity.Property(e => e.CaptainGuid).HasColumnName("captainGuid");
            _ = entity.Property(e => e.EmblemColor).HasColumnName("emblemColor");
            _ = entity.Property(e => e.EmblemStyle).HasColumnName("emblemStyle");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
            _ = entity.Property(e => e.Rating).HasColumnName("rating");
            _ = entity.Property(e => e.SeasonGames).HasColumnName("seasonGames");
            _ = entity.Property(e => e.SeasonWins).HasColumnName("seasonWins");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.WeekGames).HasColumnName("weekGames");
            _ = entity.Property(e => e.WeekWins).HasColumnName("weekWins");
        });

        _ = modelBuilder.Entity<ArenaTeamMember>(entity =>
        {
            _ = entity.HasKey(e => new { e.ArenaTeamId, e.Guid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("arena_team_member")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ArenaTeamId).HasColumnName("arenaTeamId");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.PersonalRating).HasColumnName("personalRating");
            _ = entity.Property(e => e.SeasonGames).HasColumnName("seasonGames");
            _ = entity.Property(e => e.SeasonWins).HasColumnName("seasonWins");
            _ = entity.Property(e => e.WeekGames).HasColumnName("weekGames");
            _ = entity.Property(e => e.WeekWins).HasColumnName("weekWins");
        });

        _ = modelBuilder.Entity<Auctionbidder>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Bidderguid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("auctionbidders")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Bidderguid).HasColumnName("bidderguid");
        });

        _ = modelBuilder.Entity<Auctionhouse>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("auctionhouse")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Itemguid, "item_guid").IsUnique();

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Buyguid).HasColumnName("buyguid");
            _ = entity.Property(e => e.Buyoutprice).HasColumnName("buyoutprice");
            _ = entity.Property(e => e.Deposit).HasColumnName("deposit");
            _ = entity.Property(e => e.Houseid)
                .HasDefaultValueSql("'7'")
                .HasColumnName("houseid");
            _ = entity.Property(e => e.Itemguid).HasColumnName("itemguid");
            _ = entity.Property(e => e.Itemowner).HasColumnName("itemowner");
            _ = entity.Property(e => e.Lastbid).HasColumnName("lastbid");
            _ = entity.Property(e => e.Startbid).HasColumnName("startbid");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<BannedAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("banned_addons")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Name, e.Version }, "idx_name_ver").IsUnique();

            _ = entity.Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            _ = entity.Property(e => e.Version).HasDefaultValueSql("''");
        });

        _ = modelBuilder.Entity<BattlegroundDeserter>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("battleground_deserters")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Datetime)
                .HasComment("datetime of the desertion")
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            _ = entity.Property(e => e.Guid)
                .HasComment("characters.guid")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Type)
                .HasComment("type of the desertion")
                .HasColumnName("type");
        });

        _ = modelBuilder.Entity<Bugreport>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("bugreport", tb => tb.HasComment("Debug System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Content).HasColumnName("content");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<CalendarEvent>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("calendar_events")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Creator).HasColumnName("creator");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            _ = entity.Property(e => e.Dungeon)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("dungeon");
            _ = entity.Property(e => e.Eventtime).HasColumnName("eventtime");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Time2).HasColumnName("time2");
            _ = entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            _ = entity.Property(e => e.Type)
                .HasDefaultValueSql("'4'")
                .HasColumnName("type");
        });

        _ = modelBuilder.Entity<CalendarInvite>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("calendar_invites")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Event).HasColumnName("event");
            _ = entity.Property(e => e.Invitee).HasColumnName("invitee");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
            _ = entity.Property(e => e.Sender).HasColumnName("sender");
            _ = entity.Property(e => e.Status).HasColumnName("status");
            _ = entity.Property(e => e.Statustime).HasColumnName("statustime");
            _ = entity.Property(e => e.Text)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("text");
        });

        _ = modelBuilder.Entity<Channel>(entity =>
        {
            _ = entity.HasKey(e => new { e.Name, e.Team })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("channels", tb => tb.HasComment("Channel System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            _ = entity.Property(e => e.Team).HasColumnName("team");
            _ = entity.Property(e => e.Announce)
                .HasDefaultValueSql("'1'")
                .HasColumnName("announce");
            _ = entity.Property(e => e.BannedList)
                .HasColumnType("text")
                .HasColumnName("bannedList");
            _ = entity.Property(e => e.LastUsed).HasColumnName("lastUsed");
            _ = entity.Property(e => e.Ownership)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ownership");
            _ = entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasColumnName("password");
        });

        _ = modelBuilder.Entity<Character>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("characters", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Account, "idx_account");

            _ = entity.HasIndex(e => e.Name, "idx_name");

            _ = entity.HasIndex(e => e.Online, "idx_online");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Account)
                .HasComment("Account Identifier")
                .HasColumnName("account");
            _ = entity.Property(e => e.ActionBars).HasColumnName("actionBars");
            _ = entity.Property(e => e.ActiveTalentGroup).HasColumnName("activeTalentGroup");
            _ = entity.Property(e => e.AmmoId).HasColumnName("ammoId");
            _ = entity.Property(e => e.ArenaPoints).HasColumnName("arenaPoints");
            _ = entity.Property(e => e.AtLogin).HasColumnName("at_login");
            _ = entity.Property(e => e.BankSlots).HasColumnName("bankSlots");
            _ = entity.Property(e => e.ChosenTitle).HasColumnName("chosenTitle");
            _ = entity.Property(e => e.Cinematic).HasColumnName("cinematic");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.DeathExpireTime).HasColumnName("death_expire_time");
            _ = entity.Property(e => e.DeleteDate).HasColumnName("deleteDate");
            _ = entity.Property(e => e.DeleteInfosAccount).HasColumnName("deleteInfos_Account");
            _ = entity.Property(e => e.DeleteInfosName)
                .HasMaxLength(12)
                .HasColumnName("deleteInfos_Name");
            _ = entity.Property(e => e.Drunk).HasColumnName("drunk");
            _ = entity.Property(e => e.EquipmentCache).HasColumnName("equipmentCache");
            _ = entity.Property(e => e.ExploredZones).HasColumnName("exploredZones");
            _ = entity.Property(e => e.ExtraFlags).HasColumnName("extra_flags");
            _ = entity.Property(e => e.Face).HasColumnName("face");
            _ = entity.Property(e => e.FacialStyle).HasColumnName("facialStyle");
            _ = entity.Property(e => e.Gender).HasColumnName("gender");
            _ = entity.Property(e => e.GrantableLevels).HasColumnName("grantableLevels");
            _ = entity.Property(e => e.HairColor).HasColumnName("hairColor");
            _ = entity.Property(e => e.HairStyle).HasColumnName("hairStyle");
            _ = entity.Property(e => e.Health).HasColumnName("health");
            _ = entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            _ = entity.Property(e => e.InstanceModeMask).HasColumnName("instance_mode_mask");
            _ = entity.Property(e => e.IsLogoutResting).HasColumnName("is_logout_resting");
            _ = entity.Property(e => e.KnownCurrencies).HasColumnName("knownCurrencies");
            _ = entity.Property(e => e.KnownTitles).HasColumnName("knownTitles");
            _ = entity.Property(e => e.Latency)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("latency");
            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Leveltime).HasColumnName("leveltime");
            _ = entity.Property(e => e.LogoutTime).HasColumnName("logout_time");
            _ = entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            _ = entity.Property(e => e.Money).HasColumnName("money");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasColumnName("name")
                .UseCollation("utf8mb4_bin");
            _ = entity.Property(e => e.Online).HasColumnName("online");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PlayerFlags).HasColumnName("playerFlags");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.Power1).HasColumnName("power1");
            _ = entity.Property(e => e.Power2).HasColumnName("power2");
            _ = entity.Property(e => e.Power3).HasColumnName("power3");
            _ = entity.Property(e => e.Power4).HasColumnName("power4");
            _ = entity.Property(e => e.Power5).HasColumnName("power5");
            _ = entity.Property(e => e.Power6).HasColumnName("power6");
            _ = entity.Property(e => e.Power7).HasColumnName("power7");
            _ = entity.Property(e => e.Race).HasColumnName("race");
            _ = entity.Property(e => e.ResettalentsCost).HasColumnName("resettalents_cost");
            _ = entity.Property(e => e.ResettalentsTime).HasColumnName("resettalents_time");
            _ = entity.Property(e => e.RestBonus).HasColumnName("rest_bonus");
            _ = entity.Property(e => e.RestState).HasColumnName("restState");
            _ = entity.Property(e => e.Skin).HasColumnName("skin");
            _ = entity.Property(e => e.StableSlots).HasColumnName("stable_slots");
            _ = entity.Property(e => e.TalentGroupsCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("talentGroupsCount");
            _ = entity.Property(e => e.TaxiPath)
                .HasColumnType("text")
                .HasColumnName("taxi_path");
            _ = entity.Property(e => e.Taximask)
                .HasColumnType("text")
                .HasColumnName("taximask");
            _ = entity.Property(e => e.TodayHonorPoints).HasColumnName("todayHonorPoints");
            _ = entity.Property(e => e.TodayKills).HasColumnName("todayKills");
            _ = entity.Property(e => e.TotalHonorPoints).HasColumnName("totalHonorPoints");
            _ = entity.Property(e => e.TotalKills).HasColumnName("totalKills");
            _ = entity.Property(e => e.Totaltime).HasColumnName("totaltime");
            _ = entity.Property(e => e.TransO).HasColumnName("trans_o");
            _ = entity.Property(e => e.TransX).HasColumnName("trans_x");
            _ = entity.Property(e => e.TransY).HasColumnName("trans_y");
            _ = entity.Property(e => e.TransZ).HasColumnName("trans_z");
            _ = entity.Property(e => e.Transguid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("transguid");
            _ = entity.Property(e => e.WatchedFaction).HasColumnName("watchedFaction");
            _ = entity.Property(e => e.Xp).HasColumnName("xp");
            _ = entity.Property(e => e.YesterdayHonorPoints).HasColumnName("yesterdayHonorPoints");
            _ = entity.Property(e => e.YesterdayKills).HasColumnName("yesterdayKills");
            _ = entity.Property(e => e.Zone).HasColumnName("zone");
        });

        _ = modelBuilder.Entity<CharacterAccountDatum>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_account_data")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.Data)
                .HasColumnType("blob")
                .HasColumnName("data");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<CharacterAchievement>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Achievement })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_achievement")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Achievement).HasColumnName("achievement");
            _ = entity.Property(e => e.Date).HasColumnName("date");
        });

        _ = modelBuilder.Entity<CharacterAchievementProgress>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Criteria })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_achievement_progress")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Criteria).HasColumnName("criteria");
            _ = entity.Property(e => e.Counter).HasColumnName("counter");
            _ = entity.Property(e => e.Date).HasColumnName("date");
        });

        _ = modelBuilder.Entity<CharacterAction>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spec, e.Button })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("character_action")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Spec).HasColumnName("spec");
            _ = entity.Property(e => e.Button).HasColumnName("button");
            _ = entity.Property(e => e.Action).HasColumnName("action");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<CharacterArenaStat>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Slot })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_arena_stats")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Slot).HasColumnName("slot");
            _ = entity.Property(e => e.MatchMakerRating).HasColumnName("matchMakerRating");
        });

        _ = modelBuilder.Entity<CharacterAura>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell, e.EffectMask })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default5byteArray);

            _ = entity
                .ToTable("character_aura", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("casterGuid");
            _ = entity.Property(e => e.ItemGuid).HasColumnName("itemGuid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.EffectMask).HasColumnName("effectMask");
            _ = entity.Property(e => e.Amount0).HasColumnName("amount0");
            _ = entity.Property(e => e.Amount1).HasColumnName("amount1");
            _ = entity.Property(e => e.Amount2).HasColumnName("amount2");
            _ = entity.Property(e => e.ApplyResilience).HasColumnName("applyResilience");
            _ = entity.Property(e => e.BaseAmount0).HasColumnName("base_amount0");
            _ = entity.Property(e => e.BaseAmount1).HasColumnName("base_amount1");
            _ = entity.Property(e => e.BaseAmount2).HasColumnName("base_amount2");
            _ = entity.Property(e => e.CritChance).HasColumnName("critChance");
            _ = entity.Property(e => e.MaxDuration).HasColumnName("maxDuration");
            _ = entity.Property(e => e.RecalculateMask).HasColumnName("recalculateMask");
            _ = entity.Property(e => e.RemainCharges).HasColumnName("remainCharges");
            _ = entity.Property(e => e.RemainTime).HasColumnName("remainTime");
            _ = entity.Property(e => e.StackCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackCount");
        });

        _ = modelBuilder.Entity<CharacterBanned>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Bandate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_banned", tb => tb.HasComment("Ban List"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Bandate).HasColumnName("bandate");
            _ = entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            _ = entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasColumnName("bannedby");
            _ = entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasColumnName("banreason");
            _ = entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        _ = modelBuilder.Entity<CharacterBattlegroundDatum>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_battleground_data", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.InstanceId)
                .HasComment("Instance Identifier")
                .HasColumnName("instanceId");
            _ = entity.Property(e => e.JoinMapId)
                .HasComment("Map Identifier")
                .HasColumnName("joinMapId");
            _ = entity.Property(e => e.JoinO).HasColumnName("joinO");
            _ = entity.Property(e => e.JoinX).HasColumnName("joinX");
            _ = entity.Property(e => e.JoinY).HasColumnName("joinY");
            _ = entity.Property(e => e.JoinZ).HasColumnName("joinZ");
            _ = entity.Property(e => e.MountSpell).HasColumnName("mountSpell");
            _ = entity.Property(e => e.TaxiEnd).HasColumnName("taxiEnd");
            _ = entity.Property(e => e.TaxiStart).HasColumnName("taxiStart");
            _ = entity.Property(e => e.Team).HasColumnName("team");
        });

        _ = modelBuilder.Entity<CharacterBattlegroundRandom>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_battleground_random")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
        });

        _ = modelBuilder.Entity<CharacterDeclinedname>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_declinedname")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Accusative)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("accusative");
            _ = entity.Property(e => e.Dative)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("dative");
            _ = entity.Property(e => e.Genitive)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("genitive");
            _ = entity.Property(e => e.Instrumental)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("instrumental");
            _ = entity.Property(e => e.Prepositional)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("prepositional");
        });

        _ = modelBuilder.Entity<CharacterEquipmentset>(entity =>
        {
            _ = entity.HasKey(e => e.Setguid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_equipmentsets")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Setindex, "Idx_setindex");

            _ = entity.HasIndex(e => new { e.Guid, e.Setguid, e.Setindex }, "idx_set").IsUnique();

            _ = entity.Property(e => e.Setguid).HasColumnName("setguid");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Iconname)
                .HasMaxLength(100)
                .HasColumnName("iconname");
            _ = entity.Property(e => e.IgnoreMask).HasColumnName("ignore_mask");
            _ = entity.Property(e => e.Item0).HasColumnName("item0");
            _ = entity.Property(e => e.Item1).HasColumnName("item1");
            _ = entity.Property(e => e.Item10).HasColumnName("item10");
            _ = entity.Property(e => e.Item11).HasColumnName("item11");
            _ = entity.Property(e => e.Item12).HasColumnName("item12");
            _ = entity.Property(e => e.Item13).HasColumnName("item13");
            _ = entity.Property(e => e.Item14).HasColumnName("item14");
            _ = entity.Property(e => e.Item15).HasColumnName("item15");
            _ = entity.Property(e => e.Item16).HasColumnName("item16");
            _ = entity.Property(e => e.Item17).HasColumnName("item17");
            _ = entity.Property(e => e.Item18).HasColumnName("item18");
            _ = entity.Property(e => e.Item2).HasColumnName("item2");
            _ = entity.Property(e => e.Item3).HasColumnName("item3");
            _ = entity.Property(e => e.Item4).HasColumnName("item4");
            _ = entity.Property(e => e.Item5).HasColumnName("item5");
            _ = entity.Property(e => e.Item6).HasColumnName("item6");
            _ = entity.Property(e => e.Item7).HasColumnName("item7");
            _ = entity.Property(e => e.Item8).HasColumnName("item8");
            _ = entity.Property(e => e.Item9).HasColumnName("item9");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(31)
                .HasColumnName("name");
            _ = entity.Property(e => e.Setindex).HasColumnName("setindex");
        });

        _ = modelBuilder.Entity<CharacterFishingstep>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_fishingsteps")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.FishingSteps).HasColumnName("fishingSteps");
        });

        _ = modelBuilder.Entity<CharacterGift>(entity =>
        {
            _ = entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_gifts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.ItemGuid)
                .ValueGeneratedNever()
                .HasColumnName("item_guid");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
        });

        _ = modelBuilder.Entity<CharacterGlyph>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.TalentGroup })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_glyphs")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.TalentGroup).HasColumnName("talentGroup");
            _ = entity.Property(e => e.Glyph1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph1");
            _ = entity.Property(e => e.Glyph2)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph2");
            _ = entity.Property(e => e.Glyph3)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph3");
            _ = entity.Property(e => e.Glyph4)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph4");
            _ = entity.Property(e => e.Glyph5)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph5");
            _ = entity.Property(e => e.Glyph6)
                .HasDefaultValueSql("'0'")
                .HasColumnName("glyph6");
        });

        _ = modelBuilder.Entity<CharacterHomebind>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_homebind", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.MapId)
                .HasComment("Map Identifier")
                .HasColumnName("mapId");
            _ = entity.Property(e => e.PosX).HasColumnName("posX");
            _ = entity.Property(e => e.PosY).HasColumnName("posY");
            _ = entity.Property(e => e.PosZ).HasColumnName("posZ");
            _ = entity.Property(e => e.ZoneId)
                .HasComment("Zone Identifier")
                .HasColumnName("zoneId");
        });

        _ = modelBuilder.Entity<CharacterInstance>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Instance })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_instance")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Instance, "instance");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Instance).HasColumnName("instance");
            _ = entity.Property(e => e.ExtendState)
                .HasDefaultValueSql("'1'")
                .HasColumnName("extendState");
            _ = entity.Property(e => e.Permanent).HasColumnName("permanent");
        });

        _ = modelBuilder.Entity<CharacterInventory>(entity =>
        {
            _ = entity.HasKey(e => e.Item).HasName("PRIMARY");

            _ = entity
                .ToTable("character_inventory", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Guid, e.Bag, e.Slot }, "guid").IsUnique();

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.Item)
                .ValueGeneratedNever()
                .HasComment("Item Global Unique Identifier")
                .HasColumnName("item");
            _ = entity.Property(e => e.Bag).HasColumnName("bag");
            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Slot).HasColumnName("slot");
        });

        _ = modelBuilder.Entity<CharacterPet>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("character_pet", tb => tb.HasComment("Pet System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Slot, "idx_slot");

            _ = entity.HasIndex(e => e.Owner, "owner");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Abdata)
                .HasColumnType("text")
                .HasColumnName("abdata");
            _ = entity.Property(e => e.CreatedBySpell)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            _ = entity.Property(e => e.Curhappiness).HasColumnName("curhappiness");
            _ = entity.Property(e => e.Curhealth)
                .HasDefaultValueSql("'1'")
                .HasColumnName("curhealth");
            _ = entity.Property(e => e.Curmana).HasColumnName("curmana");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Exp).HasColumnName("exp");
            _ = entity.Property(e => e.Level)
                .HasDefaultValueSql("'1'")
                .HasColumnName("level");
            _ = entity.Property(e => e.Modelid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modelid");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(21)
                .HasDefaultValueSql("'Pet'")
                .HasColumnName("name");
            _ = entity.Property(e => e.Owner).HasColumnName("owner");
            _ = entity.Property(e => e.Renamed).HasColumnName("renamed");
            _ = entity.Property(e => e.Savetime).HasColumnName("savetime");
            _ = entity.Property(e => e.Slot).HasColumnName("slot");
        });

        _ = modelBuilder.Entity<CharacterPetDeclinedname>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("character_pet_declinedname")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Owner, "owner_key");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Accusative)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("accusative");
            _ = entity.Property(e => e.Dative)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("dative");
            _ = entity.Property(e => e.Genitive)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("genitive");
            _ = entity.Property(e => e.Instrumental)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("instrumental");
            _ = entity.Property(e => e.Owner).HasColumnName("owner");
            _ = entity.Property(e => e.Prepositional)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("prepositional");
        });

        _ = modelBuilder.Entity<CharacterQueststatus>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
            _ = entity.Property(e => e.Explored).HasColumnName("explored");
            _ = entity.Property(e => e.Itemcount1).HasColumnName("itemcount1");
            _ = entity.Property(e => e.Itemcount2).HasColumnName("itemcount2");
            _ = entity.Property(e => e.Itemcount3).HasColumnName("itemcount3");
            _ = entity.Property(e => e.Itemcount4).HasColumnName("itemcount4");
            _ = entity.Property(e => e.Itemcount5).HasColumnName("itemcount5");
            _ = entity.Property(e => e.Itemcount6).HasColumnName("itemcount6");
            _ = entity.Property(e => e.Mobcount1).HasColumnName("mobcount1");
            _ = entity.Property(e => e.Mobcount2).HasColumnName("mobcount2");
            _ = entity.Property(e => e.Mobcount3).HasColumnName("mobcount3");
            _ = entity.Property(e => e.Mobcount4).HasColumnName("mobcount4");
            _ = entity.Property(e => e.Playercount).HasColumnName("playercount");
            _ = entity.Property(e => e.Status).HasColumnName("status");
            _ = entity.Property(e => e.Timer).HasColumnName("timer");
        });

        _ = modelBuilder.Entity<CharacterQueststatusDaily>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus_daily", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<CharacterQueststatusMonthly>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus_monthly", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<CharacterQueststatusRewarded>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus_rewarded", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
            _ = entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
        });

        _ = modelBuilder.Entity<CharacterQueststatusSeasonal>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus_seasonal", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
            _ = entity.Property(e => e.Event)
                .HasComment("Event Identifier")
                .HasColumnName("event");
        });

        _ = modelBuilder.Entity<CharacterQueststatusWeekly>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_queststatus_weekly", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "idx_guid");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<CharacterReputation>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Faction })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_reputation", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Faction).HasColumnName("faction");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Standing).HasColumnName("standing");
        });

        _ = modelBuilder.Entity<CharacterSkill>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Skill })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_skills", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Skill).HasColumnName("skill");
            _ = entity.Property(e => e.Max).HasColumnName("max");
            _ = entity.Property(e => e.Value).HasColumnName("value");
        });

        _ = modelBuilder.Entity<CharacterSocial>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Friend, e.Flags })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("character_social", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Friend, "friend");

            _ = entity.Property(e => e.Guid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Friend)
                .HasComment("Friend Global Unique Identifier")
                .HasColumnName("friend");
            _ = entity.Property(e => e.Flags)
                .HasComment("Friend Flags")
                .HasColumnName("flags");
            _ = entity.Property(e => e.Note)
                .HasMaxLength(48)
                .HasDefaultValueSql("''")
                .HasComment("Friend Note")
                .HasColumnName("note");
        });

        _ = modelBuilder.Entity<CharacterSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_spell", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasComment("Spell Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            _ = entity.Property(e => e.Disabled).HasColumnName("disabled");
        });

        _ = modelBuilder.Entity<CharacterSpellCooldown>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("character_spell_cooldown")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasComment("Spell Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.CategoryEnd).HasColumnName("categoryEnd");
            _ = entity.Property(e => e.CategoryId)
                .HasComment("Spell category Id")
                .HasColumnName("categoryId");
            _ = entity.Property(e => e.Item)
                .HasComment("Item Identifier")
                .HasColumnName("item");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<CharacterStat>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("character_stats")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Agility).HasColumnName("agility");
            _ = entity.Property(e => e.Armor).HasColumnName("armor");
            _ = entity.Property(e => e.AttackPower).HasColumnName("attackPower");
            _ = entity.Property(e => e.BlockPct)
                .HasColumnType("float unsigned")
                .HasColumnName("blockPct");
            _ = entity.Property(e => e.CritPct)
                .HasColumnType("float unsigned")
                .HasColumnName("critPct");
            _ = entity.Property(e => e.DodgePct)
                .HasColumnType("float unsigned")
                .HasColumnName("dodgePct");
            _ = entity.Property(e => e.Intellect).HasColumnName("intellect");
            _ = entity.Property(e => e.Maxhealth).HasColumnName("maxhealth");
            _ = entity.Property(e => e.Maxpower1).HasColumnName("maxpower1");
            _ = entity.Property(e => e.Maxpower2).HasColumnName("maxpower2");
            _ = entity.Property(e => e.Maxpower3).HasColumnName("maxpower3");
            _ = entity.Property(e => e.Maxpower4).HasColumnName("maxpower4");
            _ = entity.Property(e => e.Maxpower5).HasColumnName("maxpower5");
            _ = entity.Property(e => e.Maxpower6).HasColumnName("maxpower6");
            _ = entity.Property(e => e.Maxpower7).HasColumnName("maxpower7");
            _ = entity.Property(e => e.ParryPct)
                .HasColumnType("float unsigned")
                .HasColumnName("parryPct");
            _ = entity.Property(e => e.RangedAttackPower).HasColumnName("rangedAttackPower");
            _ = entity.Property(e => e.RangedCritPct)
                .HasColumnType("float unsigned")
                .HasColumnName("rangedCritPct");
            _ = entity.Property(e => e.ResArcane).HasColumnName("resArcane");
            _ = entity.Property(e => e.ResFire).HasColumnName("resFire");
            _ = entity.Property(e => e.ResFrost).HasColumnName("resFrost");
            _ = entity.Property(e => e.ResHoly).HasColumnName("resHoly");
            _ = entity.Property(e => e.ResNature).HasColumnName("resNature");
            _ = entity.Property(e => e.ResShadow).HasColumnName("resShadow");
            _ = entity.Property(e => e.Resilience).HasColumnName("resilience");
            _ = entity.Property(e => e.SpellCritPct)
                .HasColumnType("float unsigned")
                .HasColumnName("spellCritPct");
            _ = entity.Property(e => e.SpellPower).HasColumnName("spellPower");
            _ = entity.Property(e => e.Spirit).HasColumnName("spirit");
            _ = entity.Property(e => e.Stamina).HasColumnName("stamina");
            _ = entity.Property(e => e.Strength).HasColumnName("strength");
        });

        _ = modelBuilder.Entity<CharacterTalent>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spell, e.TalentGroup })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("character_talent")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Spell)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.TalentGroup).HasColumnName("talentGroup");
        });

        _ = modelBuilder.Entity<Corpse>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("corpse", tb => tb.HasComment("Death System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.InstanceId, "idx_instance");

            _ = entity.HasIndex(e => e.Time, "idx_time");

            _ = entity.HasIndex(e => e.CorpseType, "idx_type");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Bytes1).HasColumnName("bytes1");
            _ = entity.Property(e => e.Bytes2).HasColumnName("bytes2");
            _ = entity.Property(e => e.CorpseType).HasColumnName("corpseType");
            _ = entity.Property(e => e.DisplayId).HasColumnName("displayId");
            _ = entity.Property(e => e.DynFlags).HasColumnName("dynFlags");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.GuildId).HasColumnName("guildId");
            _ = entity.Property(e => e.InstanceId)
                .HasComment("Instance Identifier")
                .HasColumnName("instanceId");
            _ = entity.Property(e => e.ItemCache)
                .HasColumnType("text")
                .HasColumnName("itemCache");
            _ = entity.Property(e => e.MapId)
                .HasComment("Map Identifier")
                .HasColumnName("mapId");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PhaseMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("phaseMask");
            _ = entity.Property(e => e.PosX).HasColumnName("posX");
            _ = entity.Property(e => e.PosY).HasColumnName("posY");
            _ = entity.Property(e => e.PosZ).HasColumnName("posZ");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<GameEventConditionSave>(entity =>
        {
            _ = entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("game_event_condition_save")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry).HasColumnName("eventEntry");
            _ = entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            _ = entity.Property(e => e.Done)
                .HasDefaultValueSql("'0'")
                .HasColumnName("done");
        });

        _ = modelBuilder.Entity<GameEventSave>(entity =>
        {
            _ = entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event_save")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry).HasColumnName("eventEntry");
            _ = entity.Property(e => e.NextStart).HasColumnName("next_start");
            _ = entity.Property(e => e.State)
                .HasDefaultValueSql("'1'")
                .HasColumnName("state");
        });

        _ = modelBuilder.Entity<GmSubsurvey>(entity =>
        {
            _ = entity.HasKey(e => new { e.SurveyId, e.QuestionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("gm_subsurvey", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SurveyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("surveyId");
            _ = entity.Property(e => e.QuestionId).HasColumnName("questionId");
            _ = entity.Property(e => e.Answer).HasColumnName("answer");
            _ = entity.Property(e => e.AnswerComment)
                .HasColumnType("text")
                .HasColumnName("answerComment");
        });

        _ = modelBuilder.Entity<GmSurvey>(entity =>
        {
            _ = entity.HasKey(e => e.SurveyId).HasName("PRIMARY");

            _ = entity
                .ToTable("gm_survey", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SurveyId).HasColumnName("surveyId");
            _ = entity.Property(e => e.Comment).HasColumnName("comment");
            _ = entity.Property(e => e.CreateTime).HasColumnName("createTime");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.MainSurvey).HasColumnName("mainSurvey");
        });

        _ = modelBuilder.Entity<GmTicket>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("gm_ticket", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.AssignedTo)
                .HasComment("GUID of admin to whom ticket is assigned")
                .HasColumnName("assignedTo");
            _ = entity.Property(e => e.ClosedBy).HasColumnName("closedBy");
            _ = entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            _ = entity.Property(e => e.Completed).HasColumnName("completed");
            _ = entity.Property(e => e.CreateTime).HasColumnName("createTime");
            _ = entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            _ = entity.Property(e => e.Escalated).HasColumnName("escalated");
            _ = entity.Property(e => e.LastModifiedTime).HasColumnName("lastModifiedTime");
            _ = entity.Property(e => e.MapId).HasColumnName("mapId");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasComment("Name of ticket creator")
                .HasColumnName("name");
            _ = entity.Property(e => e.NeedMoreHelp).HasColumnName("needMoreHelp");
            _ = entity.Property(e => e.PlayerGuid)
                .HasComment("Global Unique Identifier of ticket creator")
                .HasColumnName("playerGuid");
            _ = entity.Property(e => e.PosX).HasColumnName("posX");
            _ = entity.Property(e => e.PosY).HasColumnName("posY");
            _ = entity.Property(e => e.PosZ).HasColumnName("posZ");
            _ = entity.Property(e => e.ResolvedBy)
                .HasComment("GUID of GM who resolved the ticket")
                .HasColumnName("resolvedBy");
            _ = entity.Property(e => e.Response)
                .HasColumnType("text")
                .HasColumnName("response");
            _ = entity.Property(e => e.Type)
                .HasComment("0 open, 1 closed, 2 character deleted")
                .HasColumnName("type");
            _ = entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        _ = modelBuilder.Entity<Group>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("groups", tb => tb.HasComment("Groups"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.LeaderGuid, "leaderGuid");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            _ = entity.Property(e => e.GroupType).HasColumnName("groupType");
            _ = entity.Property(e => e.Icon1).HasColumnName("icon1");
            _ = entity.Property(e => e.Icon2).HasColumnName("icon2");
            _ = entity.Property(e => e.Icon3).HasColumnName("icon3");
            _ = entity.Property(e => e.Icon4).HasColumnName("icon4");
            _ = entity.Property(e => e.Icon5).HasColumnName("icon5");
            _ = entity.Property(e => e.Icon6).HasColumnName("icon6");
            _ = entity.Property(e => e.Icon7).HasColumnName("icon7");
            _ = entity.Property(e => e.Icon8).HasColumnName("icon8");
            _ = entity.Property(e => e.LeaderGuid).HasColumnName("leaderGuid");
            _ = entity.Property(e => e.LootMethod).HasColumnName("lootMethod");
            _ = entity.Property(e => e.LootThreshold).HasColumnName("lootThreshold");
            _ = entity.Property(e => e.LooterGuid).HasColumnName("looterGuid");
            _ = entity.Property(e => e.MasterLooterGuid).HasColumnName("masterLooterGuid");
            _ = entity.Property(e => e.RaidDifficulty).HasColumnName("raidDifficulty");
        });

        _ = modelBuilder.Entity<GroupInstance>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Instance })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("group_instance")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Instance, "instance");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Instance).HasColumnName("instance");
            _ = entity.Property(e => e.Permanent).HasColumnName("permanent");
        });

        _ = modelBuilder.Entity<GroupMember>(entity =>
        {
            _ = entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            _ = entity
                .ToTable("group_member", tb => tb.HasComment("Groups"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MemberGuid)
                .ValueGeneratedNever()
                .HasColumnName("memberGuid");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.MemberFlags).HasColumnName("memberFlags");
            _ = entity.Property(e => e.Roles).HasColumnName("roles");
            _ = entity.Property(e => e.Subgroup).HasColumnName("subgroup");
        });

        _ = modelBuilder.Entity<Guild>(entity =>
        {
            _ = entity.HasKey(e => e.Guildid).HasName("PRIMARY");

            _ = entity
                .ToTable("guild", tb => tb.HasComment("Guild System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guildid)
                .ValueGeneratedNever()
                .HasColumnName("guildid");
            _ = entity.Property(e => e.Createdate).HasColumnName("createdate");
            _ = entity.Property(e => e.Info)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            _ = entity.Property(e => e.Leaderguid).HasColumnName("leaderguid");
            _ = entity.Property(e => e.Motd)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("motd");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        _ = modelBuilder.Entity<GuildBankEventlog>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.LogGuid, e.TabId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("guild_bank_eventlog")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

            _ = entity.HasIndex(e => e.PlayerGuid, "Idx_PlayerGuid");

            _ = entity.HasIndex(e => e.Guildid, "guildid_key");

            _ = entity.Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            _ = entity.Property(e => e.LogGuid).HasComment("Log record identificator - auxiliary column");
            _ = entity.Property(e => e.TabId).HasComment("Guild bank TabId");
            _ = entity.Property(e => e.DestTabId).HasComment("Destination Tab Id");
            _ = entity.Property(e => e.EventType).HasComment("Event type");
            _ = entity.Property(e => e.TimeStamp).HasComment("Event UNIX time");
        });

        _ = modelBuilder.Entity<GuildBankItem>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.TabId, e.SlotId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("guild_bank_item")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.ItemGuid, "Idx_item_guid");

            _ = entity.HasIndex(e => e.Guildid, "guildid_key");

            _ = entity.Property(e => e.Guildid).HasColumnName("guildid");
            _ = entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
        });

        _ = modelBuilder.Entity<GuildBankRight>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.TabId, e.Rid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("guild_bank_right")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guildid, "guildid_key");

            _ = entity.Property(e => e.Guildid).HasColumnName("guildid");
            _ = entity.Property(e => e.Rid).HasColumnName("rid");
            _ = entity.Property(e => e.Gbright).HasColumnName("gbright");
        });

        _ = modelBuilder.Entity<GuildBankTab>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.TabId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("guild_bank_tab")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guildid, "guildid_key");

            _ = entity.Property(e => e.Guildid).HasColumnName("guildid");
            _ = entity.Property(e => e.TabIcon)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.TabName)
                .HasMaxLength(16)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.TabText).HasMaxLength(500);
        });

        _ = modelBuilder.Entity<GuildEventlog>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.LogGuid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("guild_eventlog", tb => tb.HasComment("Guild Eventlog"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

            _ = entity.HasIndex(e => e.PlayerGuid1, "Idx_PlayerGuid1");

            _ = entity.HasIndex(e => e.PlayerGuid2, "Idx_PlayerGuid2");

            _ = entity.Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            _ = entity.Property(e => e.LogGuid).HasComment("Log record identificator - auxiliary column");
            _ = entity.Property(e => e.EventType).HasComment("Event type");
            _ = entity.Property(e => e.NewRank).HasComment("New rank(in case promotion/demotion)");
            _ = entity.Property(e => e.PlayerGuid1).HasComment("Player 1");
            _ = entity.Property(e => e.PlayerGuid2).HasComment("Player 2");
            _ = entity.Property(e => e.TimeStamp).HasComment("Event UNIX time");
        });

        _ = modelBuilder.Entity<GuildMember>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("guild_member", tb => tb.HasComment("Guild System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Guid, "guid_key").IsUnique();

            _ = entity.HasIndex(e => e.Guildid, "guildid_key");

            _ = entity.HasIndex(e => new { e.Guildid, e.Rank }, "guildid_rank_key");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            _ = entity.Property(e => e.Offnote)
                .HasMaxLength(31)
                .HasDefaultValueSql("''")
                .HasColumnName("offnote");
            _ = entity.Property(e => e.Pnote)
                .HasMaxLength(31)
                .HasDefaultValueSql("''")
                .HasColumnName("pnote");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
        });

        _ = modelBuilder.Entity<GuildMemberWithdraw>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("guild_member_withdraw", tb => tb.HasComment("Guild Member Daily Withdraws"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.Money).HasColumnName("money");
            _ = entity.Property(e => e.Tab0).HasColumnName("tab0");
            _ = entity.Property(e => e.Tab1).HasColumnName("tab1");
            _ = entity.Property(e => e.Tab2).HasColumnName("tab2");
            _ = entity.Property(e => e.Tab3).HasColumnName("tab3");
            _ = entity.Property(e => e.Tab4).HasColumnName("tab4");
            _ = entity.Property(e => e.Tab5).HasColumnName("tab5");
        });

        _ = modelBuilder.Entity<GuildRank>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guildid, e.Rid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("guild_rank", tb => tb.HasComment("Guild System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Rid, "Idx_rid");

            _ = entity.Property(e => e.Guildid).HasColumnName("guildid");
            _ = entity.Property(e => e.Rid).HasColumnName("rid");
            _ = entity.Property(e => e.Rights)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("rights");
            _ = entity.Property(e => e.Rname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("rname");
        });

        _ = modelBuilder.Entity<Instance>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("instance")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Difficulty, "difficulty");

            _ = entity.HasIndex(e => e.Map, "map");

            _ = entity.HasIndex(e => e.Resettime, "resettime");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.CompletedEncounters).HasColumnName("completedEncounters");
            _ = entity.Property(e => e.Data)
                .HasColumnType("tinytext")
                .HasColumnName("data");
            _ = entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            _ = entity.Property(e => e.Map).HasColumnName("map");
            _ = entity.Property(e => e.Resettime).HasColumnName("resettime");
        });

        _ = modelBuilder.Entity<InstanceReset>(entity =>
        {
            _ = entity.HasKey(e => new { e.Mapid, e.Difficulty })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("instance_reset")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Difficulty, "difficulty");

            _ = entity.Property(e => e.Mapid).HasColumnName("mapid");
            _ = entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            _ = entity.Property(e => e.Resettime).HasColumnName("resettime");
        });

        _ = modelBuilder.Entity<ItemInstance>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("item_instance", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.Charges)
                .HasColumnType("tinytext")
                .HasColumnName("charges");
            _ = entity.Property(e => e.Count)
                .HasDefaultValueSql("'1'")
                .HasColumnName("count");
            _ = entity.Property(e => e.CreatorGuid).HasColumnName("creatorGuid");
            _ = entity.Property(e => e.Durability).HasColumnName("durability");
            _ = entity.Property(e => e.Duration).HasColumnName("duration");
            _ = entity.Property(e => e.Enchantments)
                .HasColumnType("text")
                .HasColumnName("enchantments");
            _ = entity.Property(e => e.Flags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flags");
            _ = entity.Property(e => e.GiftCreatorGuid).HasColumnName("giftCreatorGuid");
            _ = entity.Property(e => e.ItemEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("itemEntry");
            _ = entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            _ = entity.Property(e => e.PlayedTime).HasColumnName("playedTime");
            _ = entity.Property(e => e.RandomPropertyId).HasColumnName("randomPropertyId");
            _ = entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        _ = modelBuilder.Entity<ItemLootItem>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("item_loot_items")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Blocked).HasColumnName("blocked");
            _ = entity.Property(e => e.ContainerId)
                .HasComment("guid of container (item_instance.guid)")
                .HasColumnName("container_id");
            _ = entity.Property(e => e.Counted).HasColumnName("counted");
            _ = entity.Property(e => e.Ffa)
                .HasComment("free-for-all")
                .HasColumnName("ffa");
            _ = entity.Property(e => e.FollowRules)
                .HasComment("follow loot rules")
                .HasColumnName("follow_rules");
            _ = entity.Property(e => e.ItemCount)
                .HasComment("stack size")
                .HasColumnName("item_count");
            _ = entity.Property(e => e.ItemId)
                .HasComment("loot item entry (item_instance.itemEntry)")
                .HasColumnName("item_id");
            _ = entity.Property(e => e.ItemIndex).HasColumnName("item_index");
            _ = entity.Property(e => e.NeedsQuest)
                .HasComment("quest drop")
                .HasColumnName("needs_quest");
            _ = entity.Property(e => e.RndProp)
                .HasComment("random enchantment added when originally rolled")
                .HasColumnName("rnd_prop");
            _ = entity.Property(e => e.RndSuffix)
                .HasComment("random suffix added when originally rolled")
                .HasColumnName("rnd_suffix");
            _ = entity.Property(e => e.UnderThreshold).HasColumnName("under_threshold");
        });

        _ = modelBuilder.Entity<ItemLootMoney>(entity =>
        {
            _ = entity.HasKey(e => e.ContainerId).HasName("PRIMARY");

            _ = entity
                .ToTable("item_loot_money")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ContainerId)
                .ValueGeneratedNever()
                .HasComment("guid of container (item_instance.guid)")
                .HasColumnName("container_id");
            _ = entity.Property(e => e.Money)
                .HasComment("money loot (in copper)")
                .HasColumnName("money");
        });

        _ = modelBuilder.Entity<ItemRefundInstance>(entity =>
        {
            _ = entity.HasKey(e => new { e.ItemGuid, e.PlayerGuid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("item_refund_instance", tb => tb.HasComment("Item Refund System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ItemGuid)
                .HasComment("Item GUID")
                .HasColumnName("item_guid");
            _ = entity.Property(e => e.PlayerGuid)
                .HasComment("Player GUID")
                .HasColumnName("player_guid");
            _ = entity.Property(e => e.PaidExtendedCost).HasColumnName("paidExtendedCost");
            _ = entity.Property(e => e.PaidMoney).HasColumnName("paidMoney");
        });

        _ = modelBuilder.Entity<ItemSoulboundTradeDatum>(entity =>
        {
            _ = entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            _ = entity
                .ToTable("item_soulbound_trade_data", tb => tb.HasComment("Item Refund System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ItemGuid)
                .ValueGeneratedNever()
                .HasComment("Item GUID")
                .HasColumnName("itemGuid");
            _ = entity.Property(e => e.AllowedPlayers)
                .HasComment("Space separated GUID list of players who can receive this item in trade")
                .HasColumnType("text")
                .HasColumnName("allowedPlayers");
        });

        _ = modelBuilder.Entity<LagReport>(entity =>
        {
            _ = entity.HasKey(e => e.ReportId).HasName("PRIMARY");

            _ = entity
                .ToTable("lag_reports", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ReportId).HasColumnName("reportId");
            _ = entity.Property(e => e.CreateTime).HasColumnName("createTime");
            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.LagType).HasColumnName("lagType");
            _ = entity.Property(e => e.Latency).HasColumnName("latency");
            _ = entity.Property(e => e.MapId).HasColumnName("mapId");
            _ = entity.Property(e => e.PosX).HasColumnName("posX");
            _ = entity.Property(e => e.PosY).HasColumnName("posY");
            _ = entity.Property(e => e.PosZ).HasColumnName("posZ");
        });

        _ = modelBuilder.Entity<LfgDatum>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("lfg_data", tb => tb.HasComment("LFG Data"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Dungeon).HasColumnName("dungeon");
            _ = entity.Property(e => e.State).HasColumnName("state");
        });

        _ = modelBuilder.Entity<Mail>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("mail", tb => tb.HasComment("Mail System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Receiver, "idx_receiver");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Body).HasColumnName("body");
            _ = entity.Property(e => e.Checked).HasColumnName("checked");
            _ = entity.Property(e => e.Cod).HasColumnName("cod");
            _ = entity.Property(e => e.DeliverTime).HasColumnName("deliver_time");
            _ = entity.Property(e => e.ExpireTime).HasColumnName("expire_time");
            _ = entity.Property(e => e.HasItems).HasColumnName("has_items");
            _ = entity.Property(e => e.MailTemplateId).HasColumnName("mailTemplateId");
            _ = entity.Property(e => e.MessageType).HasColumnName("messageType");
            _ = entity.Property(e => e.Money).HasColumnName("money");
            _ = entity.Property(e => e.Receiver)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver");
            _ = entity.Property(e => e.Sender)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("sender");
            _ = entity.Property(e => e.Stationery)
                .HasDefaultValueSql("'41'")
                .HasColumnName("stationery");
            _ = entity.Property(e => e.Subject).HasColumnName("subject");
        });

        _ = modelBuilder.Entity<MailItem>(entity =>
        {
            _ = entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            _ = entity
                .ToTable("mail_items")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.MailId, "idx_mail_id");

            _ = entity.HasIndex(e => e.Receiver, "idx_receiver");

            _ = entity.Property(e => e.ItemGuid)
                .ValueGeneratedNever()
                .HasColumnName("item_guid");
            _ = entity.Property(e => e.MailId).HasColumnName("mail_id");
            _ = entity.Property(e => e.Receiver)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver");
        });

        _ = modelBuilder.Entity<PetAura>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.CasterGuid, e.Spell, e.EffectMask })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default4byteArray);

            _ = entity
                .ToTable("pet_aura", tb => tb.HasComment("Pet System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("casterGuid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.EffectMask).HasColumnName("effectMask");
            _ = entity.Property(e => e.Amount0)
                .HasColumnType("mediumint")
                .HasColumnName("amount0");
            _ = entity.Property(e => e.Amount1)
                .HasColumnType("mediumint")
                .HasColumnName("amount1");
            _ = entity.Property(e => e.Amount2)
                .HasColumnType("mediumint")
                .HasColumnName("amount2");
            _ = entity.Property(e => e.ApplyResilience).HasColumnName("applyResilience");
            _ = entity.Property(e => e.BaseAmount0)
                .HasColumnType("mediumint")
                .HasColumnName("base_amount0");
            _ = entity.Property(e => e.BaseAmount1)
                .HasColumnType("mediumint")
                .HasColumnName("base_amount1");
            _ = entity.Property(e => e.BaseAmount2)
                .HasColumnType("mediumint")
                .HasColumnName("base_amount2");
            _ = entity.Property(e => e.CritChance).HasColumnName("critChance");
            _ = entity.Property(e => e.MaxDuration).HasColumnName("maxDuration");
            _ = entity.Property(e => e.RecalculateMask).HasColumnName("recalculateMask");
            _ = entity.Property(e => e.RemainCharges).HasColumnName("remainCharges");
            _ = entity.Property(e => e.RemainTime).HasColumnName("remainTime");
            _ = entity.Property(e => e.StackCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackCount");
        });

        _ = modelBuilder.Entity<PetSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("pet_spell", tb => tb.HasComment("Pet System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasComment("Spell Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.Active).HasColumnName("active");
        });

        _ = modelBuilder.Entity<PetSpellCooldown>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("pet_spell_cooldown")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Spell)
                .HasDefaultValueSql("'0'")
                .HasComment("Spell Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("spell");
            _ = entity.Property(e => e.CategoryEnd).HasColumnName("categoryEnd");
            _ = entity.Property(e => e.CategoryId)
                .HasComment("Spell category Id")
                .HasColumnName("categoryId");
            _ = entity.Property(e => e.Time).HasColumnName("time");
        });

        _ = modelBuilder.Entity<Petition>(entity =>
        {
            _ = entity.HasKey(e => new { e.Ownerguid, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("petition", tb => tb.HasComment("Guild System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Ownerguid, e.Petitionguid }, "index_ownerguid_petitionguid").IsUnique();

            _ = entity.Property(e => e.Ownerguid).HasColumnName("ownerguid");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            _ = entity.Property(e => e.Petitionguid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("petitionguid");
        });

        _ = modelBuilder.Entity<PetitionSign>(entity =>
        {
            _ = entity.HasKey(e => new { e.Petitionguid, e.Playerguid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("petition_sign", tb => tb.HasComment("Guild System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Ownerguid, "Idx_ownerguid");

            _ = entity.HasIndex(e => e.Playerguid, "Idx_playerguid");

            _ = entity.Property(e => e.Petitionguid).HasColumnName("petitionguid");
            _ = entity.Property(e => e.Playerguid).HasColumnName("playerguid");
            _ = entity.Property(e => e.Ownerguid).HasColumnName("ownerguid");
            _ = entity.Property(e => e.PlayerAccount).HasColumnName("player_account");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<PoolQuestSave>(entity =>
        {
            _ = entity.HasKey(e => new { e.PoolId, e.QuestId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("pool_quest_save")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.PoolId).HasColumnName("pool_id");
            _ = entity.Property(e => e.QuestId).HasColumnName("quest_id");
        });

        _ = modelBuilder.Entity<PvpstatsBattleground>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("pvpstats_battlegrounds")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.BracketId).HasColumnName("bracket_id");
            _ = entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.WinnerFaction).HasColumnName("winner_faction");
        });

        _ = modelBuilder.Entity<PvpstatsPlayer>(entity =>
        {
            _ = entity.HasKey(e => new { e.BattlegroundId, e.CharacterGuid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default2byteArray);

            _ = entity
                .ToTable("pvpstats_players")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.BattlegroundId).HasColumnName("battleground_id");
            _ = entity.Property(e => e.CharacterGuid).HasColumnName("character_guid");
            _ = entity.Property(e => e.Attr1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("attr_1");
            _ = entity.Property(e => e.Attr2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("attr_2");
            _ = entity.Property(e => e.Attr3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("attr_3");
            _ = entity.Property(e => e.Attr4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("attr_4");
            _ = entity.Property(e => e.Attr5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("attr_5");
            _ = entity.Property(e => e.ScoreBonusHonor)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_bonus_honor");
            _ = entity.Property(e => e.ScoreDamageDone)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_damage_done");
            _ = entity.Property(e => e.ScoreDeaths)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_deaths");
            _ = entity.Property(e => e.ScoreHealingDone)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_healing_done");
            _ = entity.Property(e => e.ScoreHonorableKills)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_honorable_kills");
            _ = entity.Property(e => e.ScoreKillingBlows)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("score_killing_blows");
            _ = entity.Property(e => e.Winner)
                .HasColumnType("bit(1)")
                .HasColumnName("winner");
        });

        _ = modelBuilder.Entity<QuestTracker>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("quest_tracker")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CharacterGuid).HasColumnName("character_guid");
            _ = entity.Property(e => e.CompletedByGm).HasColumnName("completed_by_gm");
            _ = entity.Property(e => e.CoreHash)
                .HasMaxLength(120)
                .HasDefaultValueSql("'0'")
                .HasColumnName("core_hash");
            _ = entity.Property(e => e.CoreRevision)
                .HasMaxLength(120)
                .HasDefaultValueSql("'0'")
                .HasColumnName("core_revision");
            _ = entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            _ = entity.Property(e => e.QuestAbandonTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_abandon_time");
            _ = entity.Property(e => e.QuestAcceptTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_accept_time");
            _ = entity.Property(e => e.QuestCompleteTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_complete_time");
        });

        _ = modelBuilder.Entity<ReservedName>(entity =>
        {
            _ = entity.HasKey(e => e.Name).HasName("PRIMARY");

            _ = entity
                .ToTable("reserved_name", tb => tb.HasComment("Player Reserved Names"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        _ = modelBuilder.Entity<Respawn>(entity =>
        {
            _ = entity.HasKey(e => new { e.Type, e.SpawnId, e.InstanceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", _default3byteArray);

            _ = entity
                .ToTable("respawn", tb => tb.HasComment("Stored respawn times"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.InstanceId, "idx_instance");

            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.SpawnId).HasColumnName("spawnId");
            _ = entity.Property(e => e.InstanceId).HasColumnName("instanceId");
            _ = entity.Property(e => e.MapId).HasColumnName("mapId");
            _ = entity.Property(e => e.RespawnTime).HasColumnName("respawnTime");
        });

        _ = modelBuilder.Entity<Update>(entity =>
        {
            _ = entity.HasKey(e => e.Name).HasName("PRIMARY");

            _ = entity
                .ToTable("updates", tb => tb.HasComment("List of all applied updates in this database."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            _ = entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            _ = entity.Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            _ = entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
            _ = entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        _ = modelBuilder.Entity<UpdatesInclude>(entity =>
        {
            _ = entity.HasKey(e => e.Path).HasName("PRIMARY");

            _ = entity
                .ToTable("updates_include", tb => tb.HasComment("List of directories where we want to include sql updates."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            _ = entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
        });

        _ = modelBuilder.Entity<WardenAction>(entity =>
        {
            _ = entity.HasKey(e => e.WardenId).HasName("PRIMARY");

            _ = entity
                .ToTable("warden_action")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.WardenId)
                .ValueGeneratedNever()
                .HasColumnName("wardenId");
            _ = entity.Property(e => e.Action).HasColumnName("action");
        });

        _ = modelBuilder.Entity<Worldstate>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("worldstates", tb => tb.HasComment("Variable Saves"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Comment)
                .HasColumnType("tinytext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.Value).HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
