// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.EntityFrameworkCore;

namespace WrathForged.Database.Models.World;

public partial class WorldDatabase : DbContext
{
    public WorldDatabase()
    {
    }

    public WorldDatabase(DbContextOptions<WorldDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessRequirement> AccessRequirements { get; set; }

    public virtual DbSet<AchievementCriteriaDatum> AchievementCriteriaData { get; set; }

    public virtual DbSet<AchievementDbc> AchievementDbcs { get; set; }

    public virtual DbSet<AchievementReward> AchievementRewards { get; set; }

    public virtual DbSet<AchievementRewardLocale> AchievementRewardLocales { get; set; }

    public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelations { get; set; }

    public virtual DbSet<AreatriggerScript> AreatriggerScripts { get; set; }

    public virtual DbSet<AreatriggerTavern> AreatriggerTaverns { get; set; }

    public virtual DbSet<AreatriggerTeleport> AreatriggerTeleports { get; set; }

    public virtual DbSet<BattlefieldTemplate> BattlefieldTemplates { get; set; }

    public virtual DbSet<BattlegroundTemplate> BattlegroundTemplates { get; set; }

    public virtual DbSet<BattlemasterEntry> BattlemasterEntries { get; set; }

    public virtual DbSet<BroadcastText> BroadcastTexts { get; set; }

    public virtual DbSet<BroadcastTextLocale> BroadcastTextLocales { get; set; }

    public virtual DbSet<Command> Commands { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Creature> Creatures { get; set; }

    public virtual DbSet<CreatureAddon> CreatureAddons { get; set; }

    public virtual DbSet<CreatureClasslevelstat> CreatureClasslevelstats { get; set; }

    public virtual DbSet<CreatureDefaultTrainer> CreatureDefaultTrainers { get; set; }

    public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplates { get; set; }

    public virtual DbSet<CreatureFormation> CreatureFormations { get; set; }

    public virtual DbSet<CreatureLootTemplate> CreatureLootTemplates { get; set; }

    public virtual DbSet<CreatureModelInfo> CreatureModelInfos { get; set; }

    public virtual DbSet<CreatureMovementInfo> CreatureMovementInfos { get; set; }

    public virtual DbSet<CreatureMovementOverride> CreatureMovementOverrides { get; set; }

    public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputations { get; set; }

    public virtual DbSet<CreatureQuestender> CreatureQuestenders { get; set; }

    public virtual DbSet<CreatureQuestitem> CreatureQuestitems { get; set; }

    public virtual DbSet<CreatureQueststarter> CreatureQueststarters { get; set; }

    public virtual DbSet<CreatureSummonGroup> CreatureSummonGroups { get; set; }

    public virtual DbSet<CreatureTemplate> CreatureTemplates { get; set; }

    public virtual DbSet<CreatureTemplateAddon> CreatureTemplateAddons { get; set; }

    public virtual DbSet<CreatureTemplateLocale> CreatureTemplateLocales { get; set; }

    public virtual DbSet<CreatureTemplateMovement> CreatureTemplateMovements { get; set; }

    public virtual DbSet<CreatureTemplateResistance> CreatureTemplateResistances { get; set; }

    public virtual DbSet<CreatureTemplateSpell> CreatureTemplateSpells { get; set; }

    public virtual DbSet<CreatureText> CreatureTexts { get; set; }

    public virtual DbSet<CreatureTextLocale> CreatureTextLocales { get; set; }

    public virtual DbSet<Disable> Disables { get; set; }

    public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplates { get; set; }

    public virtual DbSet<EventScript> EventScripts { get; set; }

    public virtual DbSet<ExplorationBasexp> ExplorationBasexps { get; set; }

    public virtual DbSet<FishingLootTemplate> FishingLootTemplates { get; set; }

    public virtual DbSet<GameEvent> GameEvents { get; set; }

    public virtual DbSet<GameEventArenaSeason> GameEventArenaSeasons { get; set; }

    public virtual DbSet<GameEventBattlegroundHoliday> GameEventBattlegroundHolidays { get; set; }

    public virtual DbSet<GameEventCondition> GameEventConditions { get; set; }

    public virtual DbSet<GameEventCreature> GameEventCreatures { get; set; }

    public virtual DbSet<GameEventCreatureQuest> GameEventCreatureQuests { get; set; }

    public virtual DbSet<GameEventGameobject> GameEventGameobjects { get; set; }

    public virtual DbSet<GameEventGameobjectQuest> GameEventGameobjectQuests { get; set; }

    public virtual DbSet<GameEventModelEquip> GameEventModelEquips { get; set; }

    public virtual DbSet<GameEventNpcVendor> GameEventNpcVendors { get; set; }

    public virtual DbSet<GameEventNpcflag> GameEventNpcflags { get; set; }

    public virtual DbSet<GameEventPool> GameEventPools { get; set; }

    public virtual DbSet<GameEventPrerequisite> GameEventPrerequisites { get; set; }

    public virtual DbSet<GameEventQuestCondition> GameEventQuestConditions { get; set; }

    public virtual DbSet<GameEventSeasonalQuestrelation> GameEventSeasonalQuestrelations { get; set; }

    public virtual DbSet<GameTele> GameTeles { get; set; }

    public virtual DbSet<GameWeather> GameWeathers { get; set; }

    public virtual DbSet<Gameobject> Gameobjects { get; set; }

    public virtual DbSet<GameobjectAddon> GameobjectAddons { get; set; }

    public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplates { get; set; }

    public virtual DbSet<GameobjectOverride> GameobjectOverrides { get; set; }

    public virtual DbSet<GameobjectQuestender> GameobjectQuestenders { get; set; }

    public virtual DbSet<GameobjectQuestitem> GameobjectQuestitems { get; set; }

    public virtual DbSet<GameobjectQueststarter> GameobjectQueststarters { get; set; }

    public virtual DbSet<GameobjectTemplate> GameobjectTemplates { get; set; }

    public virtual DbSet<GameobjectTemplateAddon> GameobjectTemplateAddons { get; set; }

    public virtual DbSet<GameobjectTemplateLocale> GameobjectTemplateLocales { get; set; }

    public virtual DbSet<GossipMenu> GossipMenus { get; set; }

    public virtual DbSet<GossipMenuOption> GossipMenuOptions { get; set; }

    public virtual DbSet<GossipMenuOptionLocale> GossipMenuOptionLocales { get; set; }

    public virtual DbSet<GraveyardZone> GraveyardZones { get; set; }

    public virtual DbSet<HolidayDate> HolidayDates { get; set; }

    public virtual DbSet<InstanceEncounter> InstanceEncounters { get; set; }

    public virtual DbSet<InstanceSpawnGroup> InstanceSpawnGroups { get; set; }

    public virtual DbSet<InstanceTemplate> InstanceTemplates { get; set; }

    public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplates { get; set; }

    public virtual DbSet<ItemLootTemplate> ItemLootTemplates { get; set; }

    public virtual DbSet<ItemSetName> ItemSetNames { get; set; }

    public virtual DbSet<ItemSetNamesLocale> ItemSetNamesLocales { get; set; }

    public virtual DbSet<ItemTemplate> ItemTemplates { get; set; }

    public virtual DbSet<ItemTemplateLocale> ItemTemplateLocales { get; set; }

    public virtual DbSet<LfgDungeonReward> LfgDungeonRewards { get; set; }

    public virtual DbSet<LfgDungeonTemplate> LfgDungeonTemplates { get; set; }

    public virtual DbSet<LinkedRespawn> LinkedRespawns { get; set; }

    public virtual DbSet<MailLevelReward> MailLevelRewards { get; set; }

    public virtual DbSet<MailLootTemplate> MailLootTemplates { get; set; }

    public virtual DbSet<MillingLootTemplate> MillingLootTemplates { get; set; }

    public virtual DbSet<NpcSpellclickSpell> NpcSpellclickSpells { get; set; }

    public virtual DbSet<NpcText> NpcTexts { get; set; }

    public virtual DbSet<NpcTextLocale> NpcTextLocales { get; set; }

    public virtual DbSet<NpcVendor> NpcVendors { get; set; }

    public virtual DbSet<OutdoorpvpTemplate> OutdoorpvpTemplates { get; set; }

    public virtual DbSet<PageText> PageTexts { get; set; }

    public virtual DbSet<PageTextLocale> PageTextLocales { get; set; }

    public virtual DbSet<PetLevelstat> PetLevelstats { get; set; }

    public virtual DbSet<PetNameGeneration> PetNameGenerations { get; set; }

    public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplates { get; set; }

    public virtual DbSet<PlayerClasslevelstat> PlayerClasslevelstats { get; set; }

    public virtual DbSet<PlayerFactionchangeAchievement> PlayerFactionchangeAchievements { get; set; }

    public virtual DbSet<PlayerFactionchangeItem> PlayerFactionchangeItems { get; set; }

    public virtual DbSet<PlayerFactionchangeQuest> PlayerFactionchangeQuests { get; set; }

    public virtual DbSet<PlayerFactionchangeReputation> PlayerFactionchangeReputations { get; set; }

    public virtual DbSet<PlayerFactionchangeSpell> PlayerFactionchangeSpells { get; set; }

    public virtual DbSet<PlayerFactionchangeTitle> PlayerFactionchangeTitles { get; set; }

    public virtual DbSet<PlayerLevelstat> PlayerLevelstats { get; set; }

    public virtual DbSet<PlayerTotemModel> PlayerTotemModels { get; set; }

    public virtual DbSet<PlayerXpForLevel> PlayerXpForLevels { get; set; }

    public virtual DbSet<Playercreateinfo> Playercreateinfos { get; set; }

    public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoActions { get; set; }

    public virtual DbSet<PlayercreateinfoCastSpell> PlayercreateinfoCastSpells { get; set; }

    public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItems { get; set; }

    public virtual DbSet<PlayercreateinfoSkill> PlayercreateinfoSkills { get; set; }

    public virtual DbSet<PlayercreateinfoSpellCustom> PlayercreateinfoSpellCustoms { get; set; }

    public virtual DbSet<PointsOfInterest> PointsOfInterests { get; set; }

    public virtual DbSet<PointsOfInterestLocale> PointsOfInterestLocales { get; set; }

    public virtual DbSet<PoolMember> PoolMembers { get; set; }

    public virtual DbSet<PoolTemplate> PoolTemplates { get; set; }

    public virtual DbSet<ProspectingLootTemplate> ProspectingLootTemplates { get; set; }

    public virtual DbSet<QuestDetail> QuestDetails { get; set; }

    public virtual DbSet<QuestGreeting> QuestGreetings { get; set; }

    public virtual DbSet<QuestGreetingLocale> QuestGreetingLocales { get; set; }

    public virtual DbSet<QuestMailSender> QuestMailSenders { get; set; }

    public virtual DbSet<QuestOfferReward> QuestOfferRewards { get; set; }

    public virtual DbSet<QuestOfferRewardLocale> QuestOfferRewardLocales { get; set; }

    public virtual DbSet<QuestPoi> QuestPois { get; set; }

    public virtual DbSet<QuestPoiPoint> QuestPoiPoints { get; set; }

    public virtual DbSet<QuestPoolMember> QuestPoolMembers { get; set; }

    public virtual DbSet<QuestPoolTemplate> QuestPoolTemplates { get; set; }

    public virtual DbSet<QuestRequestItem> QuestRequestItems { get; set; }

    public virtual DbSet<QuestRequestItemsLocale> QuestRequestItemsLocales { get; set; }

    public virtual DbSet<QuestTemplate> QuestTemplates { get; set; }

    public virtual DbSet<QuestTemplateAddon> QuestTemplateAddons { get; set; }

    public virtual DbSet<QuestTemplateLocale> QuestTemplateLocales { get; set; }

    public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplates { get; set; }

    public virtual DbSet<ReputationRewardRate> ReputationRewardRates { get; set; }

    public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplates { get; set; }

    public virtual DbSet<ScriptSplineChainMetum> ScriptSplineChainMeta { get; set; }

    public virtual DbSet<ScriptSplineChainWaypoint> ScriptSplineChainWaypoints { get; set; }

    public virtual DbSet<ScriptWaypoint> ScriptWaypoints { get; set; }

    public virtual DbSet<SkillDiscoveryTemplate> SkillDiscoveryTemplates { get; set; }

    public virtual DbSet<SkillExtraItemTemplate> SkillExtraItemTemplates { get; set; }

    public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevels { get; set; }

    public virtual DbSet<SkillPerfectItemTemplate> SkillPerfectItemTemplates { get; set; }

    public virtual DbSet<SkinningLootTemplate> SkinningLootTemplates { get; set; }

    public virtual DbSet<SmartScript> SmartScripts { get; set; }

    public virtual DbSet<SpawnGroup> SpawnGroups { get; set; }

    public virtual DbSet<SpawnGroupTemplate> SpawnGroupTemplates { get; set; }

    public virtual DbSet<SpellArea> SpellAreas { get; set; }

    public virtual DbSet<SpellBonusDatum> SpellBonusData { get; set; }

    public virtual DbSet<SpellCustomAttr> SpellCustomAttrs { get; set; }

    public virtual DbSet<SpellDbc> SpellDbcs { get; set; }

    public virtual DbSet<SpellEnchantProcDatum> SpellEnchantProcData { get; set; }

    public virtual DbSet<SpellGroup> SpellGroups { get; set; }

    public virtual DbSet<SpellGroupStackRule> SpellGroupStackRules { get; set; }

    public virtual DbSet<SpellLearnSpell> SpellLearnSpells { get; set; }

    public virtual DbSet<SpellLinkedSpell> SpellLinkedSpells { get; set; }

    public virtual DbSet<SpellLootTemplate> SpellLootTemplates { get; set; }

    public virtual DbSet<SpellPetAura> SpellPetAuras { get; set; }

    public virtual DbSet<SpellProc> SpellProcs { get; set; }

    public virtual DbSet<SpellRank> SpellRanks { get; set; }

    public virtual DbSet<SpellRequired> SpellRequireds { get; set; }

    public virtual DbSet<SpellScript> SpellScripts { get; set; }

    public virtual DbSet<SpellScriptName> SpellScriptNames { get; set; }

    public virtual DbSet<SpellTargetPosition> SpellTargetPositions { get; set; }

    public virtual DbSet<SpellThreat> SpellThreats { get; set; }

    public virtual DbSet<SpelldifficultyDbc> SpelldifficultyDbcs { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<TrainerLocale> TrainerLocales { get; set; }

    public virtual DbSet<TrainerSpell> TrainerSpells { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<TrinityString> TrinityStrings { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<VehicleAccessory> VehicleAccessories { get; set; }

    public virtual DbSet<VehicleSeatAddon> VehicleSeatAddons { get; set; }

    public virtual DbSet<VehicleTemplate> VehicleTemplates { get; set; }

    public virtual DbSet<VehicleTemplateAccessory> VehicleTemplateAccessories { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VwConditionsWithLabel> VwConditionsWithLabels { get; set; }

    public virtual DbSet<VwDisablesWithLabel> VwDisablesWithLabels { get; set; }

    public virtual DbSet<VwSmartScriptsWithLabel> VwSmartScriptsWithLabels { get; set; }

    public virtual DbSet<WardenCheck> WardenChecks { get; set; }

    public virtual DbSet<Waypoint> Waypoints { get; set; }

    public virtual DbSet<WaypointDatum> WaypointData { get; set; }

    public virtual DbSet<WaypointScript> WaypointScripts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        _ = modelBuilder.Entity<AccessRequirement>(entity =>
        {
            _ = entity.HasKey(e => new { e.MapId, e.Difficulty })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("access_requirement", tb => tb.HasComment("Access Requirements"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MapId).HasColumnName("mapId");
            _ = entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            _ = entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.CompletedAchievement).HasColumnName("completed_achievement");
            _ = entity.Property(e => e.Item).HasColumnName("item");
            _ = entity.Property(e => e.Item2).HasColumnName("item2");
            _ = entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            _ = entity.Property(e => e.LevelMax).HasColumnName("level_max");
            _ = entity.Property(e => e.LevelMin).HasColumnName("level_min");
            _ = entity.Property(e => e.QuestDoneA).HasColumnName("quest_done_A");
            _ = entity.Property(e => e.QuestDoneH).HasColumnName("quest_done_H");
            _ = entity.Property(e => e.QuestFailedText)
                .HasColumnType("mediumtext")
                .HasColumnName("quest_failed_text");
        });

        _ = modelBuilder.Entity<AchievementCriteriaDatum>(entity =>
        {
            _ = entity.HasKey(e => new { e.CriteriaId, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("achievement_criteria_data", tb => tb.HasComment("Achievment system"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CriteriaId).HasColumnName("criteria_id");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.Value1).HasColumnName("value1");
            _ = entity.Property(e => e.Value2).HasColumnName("value2");
        });

        _ = modelBuilder.Entity<AchievementDbc>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("achievement_dbc")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.Count).HasColumnName("count");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.MapId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("mapID");
            _ = entity.Property(e => e.Points).HasColumnName("points");
            _ = entity.Property(e => e.RefAchievement).HasColumnName("refAchievement");
            _ = entity.Property(e => e.RequiredFaction)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("requiredFaction");
        });

        _ = modelBuilder.Entity<AchievementReward>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("achievement_reward", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.Body).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ItemId).HasColumnName("ItemID");
            _ = entity.Property(e => e.MailTemplateId).HasColumnName("MailTemplateID");
            _ = entity.Property(e => e.Subject).HasMaxLength(255);
        });

        _ = modelBuilder.Entity<AchievementRewardLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("achievement_reward_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale).HasMaxLength(4);
            _ = entity.Property(e => e.Body).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Subject).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("areatrigger_involvedrelation", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<AreatriggerScript>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("areatrigger_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength();
        });

        _ = modelBuilder.Entity<AreatriggerTavern>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("areatrigger_tavern", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
        });

        _ = modelBuilder.Entity<AreatriggerTeleport>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("areatrigger_teleport", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Name, "name").HasAnnotation("MySql:FullTextIndex", true);

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
            _ = entity.Property(e => e.TargetMap).HasColumnName("target_map");
            _ = entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");
            _ = entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");
            _ = entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");
            _ = entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
        });

        _ = modelBuilder.Entity<BattlefieldTemplate>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("battlefield_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
        });

        _ = modelBuilder.Entity<BattlegroundTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("battleground_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(32)
                .IsFixedLength();
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.Weight).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<BattlemasterEntry>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("battlemaster_entry")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Entry of a creature")
                .HasColumnName("entry");
            _ = entity.Property(e => e.BgTemplate)
                .HasComment("Battleground template id")
                .HasColumnName("bg_template");
        });

        _ = modelBuilder.Entity<BroadcastText>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("broadcast_text")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.EmoteId1).HasColumnName("EmoteID1");
            _ = entity.Property(e => e.EmoteId2).HasColumnName("EmoteID2");
            _ = entity.Property(e => e.EmoteId3).HasColumnName("EmoteID3");
            _ = entity.Property(e => e.EmotesId).HasColumnName("EmotesID");
            _ = entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            _ = entity.Property(e => e.SoundEntriesId).HasColumnName("SoundEntriesID");
        });

        _ = modelBuilder.Entity<BroadcastTextLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("broadcast_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Text).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Text1).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<Command>(entity =>
        {
            _ = entity.HasKey(e => e.Name).HasName("PRIMARY");

            _ = entity
                .ToTable("command", tb => tb.HasComment("Chat System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.Help).HasColumnName("help");
        });

        _ = modelBuilder.Entity<Condition>(entity =>
        {
            _ = entity.HasKey(e => new { e.SourceTypeOrReferenceId, e.SourceGroup, e.SourceEntry, e.SourceId, e.ElseGroup, e.ConditionTypeOrReference, e.ConditionTarget, e.ConditionValue1, e.ConditionValue2, e.ConditionValue3 })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            _ = entity
                .ToTable("conditions", tb => tb.HasComment("Condition System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        _ = modelBuilder.Entity<Creature>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("creature", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Id, "idx_id");

            _ = entity.HasIndex(e => e.Map, "idx_map");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.AreaId)
                .HasComment("Area Identifier")
                .HasColumnName("areaId");
            _ = entity.Property(e => e.Curhealth)
                .HasDefaultValueSql("'1'")
                .HasColumnName("curhealth");
            _ = entity.Property(e => e.Curmana).HasColumnName("curmana");
            _ = entity.Property(e => e.Currentwaypoint).HasColumnName("currentwaypoint");
            _ = entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            _ = entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            _ = entity.Property(e => e.Id)
                .HasComment("Creature Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            _ = entity.Property(e => e.Modelid).HasColumnName("modelid");
            _ = entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PhaseMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("phaseMask");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.SpawnMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spawnMask");
            _ = entity.Property(e => e.Spawntimesecs)
                .HasDefaultValueSql("'120'")
                .HasColumnName("spawntimesecs");
            _ = entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            _ = entity.Property(e => e.VerifiedBuild).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.WanderDistance).HasColumnName("wander_distance");
            _ = entity.Property(e => e.ZoneId)
                .HasComment("Zone Identifier")
                .HasColumnName("zoneId");
        });

        _ = modelBuilder.Entity<CreatureAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.Auras)
                .HasColumnType("mediumtext")
                .HasColumnName("auras");
            _ = entity.Property(e => e.Emote).HasColumnName("emote");
            _ = entity.Property(e => e.Mount).HasColumnName("mount");
            _ = entity.Property(e => e.MountCreatureId).HasColumnName("MountCreatureID");
            _ = entity.Property(e => e.PathId).HasColumnName("path_id");
            _ = entity.Property(e => e.PvPflags).HasColumnName("PvPFlags");
            _ = entity.Property(e => e.SheathState).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        _ = modelBuilder.Entity<CreatureClasslevelstat>(entity =>
        {
            _ = entity.HasKey(e => new { e.Level, e.Class })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_classlevelstats")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Attackpower).HasColumnName("attackpower");
            _ = entity.Property(e => e.Basearmor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basearmor");
            _ = entity.Property(e => e.Basehp0)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp0");
            _ = entity.Property(e => e.Basehp1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp1");
            _ = entity.Property(e => e.Basehp2)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp2");
            _ = entity.Property(e => e.Basemana).HasColumnName("basemana");
            _ = entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.DamageBase).HasColumnName("damage_base");
            _ = entity.Property(e => e.DamageExp1).HasColumnName("damage_exp1");
            _ = entity.Property(e => e.DamageExp2).HasColumnName("damage_exp2");
            _ = entity.Property(e => e.Rangedattackpower).HasColumnName("rangedattackpower");
        });

        _ = modelBuilder.Entity<CreatureDefaultTrainer>(entity =>
        {
            _ = entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_default_trainer")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).ValueGeneratedNever();
        });

        _ = modelBuilder.Entity<CreatureEquipTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_equip_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            _ = entity.Property(e => e.Id)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ID");
            _ = entity.Property(e => e.ItemId1).HasColumnName("ItemID1");
            _ = entity.Property(e => e.ItemId2).HasColumnName("ItemID2");
            _ = entity.Property(e => e.ItemId3).HasColumnName("ItemID3");
        });

        _ = modelBuilder.Entity<CreatureFormation>(entity =>
        {
            _ = entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_formations")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MemberGuid)
                .ValueGeneratedNever()
                .HasColumnName("memberGUID");
            _ = entity.Property(e => e.Angle)
                .HasColumnType("float unsigned")
                .HasColumnName("angle");
            _ = entity.Property(e => e.Dist)
                .HasColumnType("float unsigned")
                .HasColumnName("dist");
            _ = entity.Property(e => e.GroupAi).HasColumnName("groupAI");
            _ = entity.Property(e => e.LeaderGuid).HasColumnName("leaderGUID");
            _ = entity.Property(e => e.Point1).HasColumnName("point_1");
            _ = entity.Property(e => e.Point2).HasColumnName("point_2");
        });

        _ = modelBuilder.Entity<CreatureLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<CreatureModelInfo>(entity =>
        {
            _ = entity.HasKey(e => e.DisplayId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_model_info", tb => tb.HasComment("Creature System (Model related info)"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.DisplayId)
                .ValueGeneratedNever()
                .HasColumnName("DisplayID");
            _ = entity.Property(e => e.DisplayIdOtherGender).HasColumnName("DisplayID_Other_Gender");
            _ = entity.Property(e => e.Gender).HasDefaultValueSql("'2'");
        });

        _ = modelBuilder.Entity<CreatureMovementInfo>(entity =>
        {
            _ = entity.HasKey(e => e.MovementId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_movement_info")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MovementId)
                .ValueGeneratedNever()
                .HasComment("creature_template.movementId value")
                .HasColumnName("MovementID");
            _ = entity.Property(e => e.RunSpeed).HasColumnType("float unsigned");
            _ = entity.Property(e => e.WalkSpeed).HasColumnType("float unsigned");
        });

        _ = modelBuilder.Entity<CreatureMovementOverride>(entity =>
        {
            _ = entity.HasKey(e => e.SpawnId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_movement_override")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpawnId).ValueGeneratedNever();
            _ = entity.Property(e => e.InteractionPauseTimer).HasComment("Time (in milliseconds) during which creature will not move after interaction with player");
        });

        _ = modelBuilder.Entity<CreatureOnkillReputation>(entity =>
        {
            _ = entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_onkill_reputation", tb => tb.HasComment("Creature OnKill Reputation gain"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId)
                .ValueGeneratedNever()
                .HasComment("Creature Identifier")
                .HasColumnName("creature_id");
        });

        _ = modelBuilder.Entity<CreatureQuestender>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_questender", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<CreatureQuestitem>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureEntry, e.Idx })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_questitem")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<CreatureQueststarter>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_queststarter", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<CreatureSummonGroup>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("creature_summon_groups")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.GroupId).HasColumnName("groupId");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.SummonTime).HasColumnName("summonTime");
            _ = entity.Property(e => e.SummonType).HasColumnName("summonType");
            _ = entity.Property(e => e.SummonerId).HasColumnName("summonerId");
            _ = entity.Property(e => e.SummonerType).HasColumnName("summonerType");
        });

        _ = modelBuilder.Entity<CreatureTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_template", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Name, "idx_name");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            _ = entity.Property(e => e.ArmorModifier).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.BaseVariance).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.DamageModifier).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.DifficultyEntry1).HasColumnName("difficulty_entry_1");
            _ = entity.Property(e => e.DifficultyEntry2).HasColumnName("difficulty_entry_2");
            _ = entity.Property(e => e.DifficultyEntry3).HasColumnName("difficulty_entry_3");
            _ = entity.Property(e => e.Dmgschool).HasColumnName("dmgschool");
            _ = entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            _ = entity.Property(e => e.Exp).HasColumnName("exp");
            _ = entity.Property(e => e.ExperienceModifier).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.Faction).HasColumnName("faction");
            _ = entity.Property(e => e.Family).HasColumnName("family");
            _ = entity.Property(e => e.FlagsExtra).HasColumnName("flags_extra");
            _ = entity.Property(e => e.GossipMenuId).HasColumnName("gossip_menu_id");
            _ = entity.Property(e => e.HealthModifier).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.HoverHeight).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.IconName)
                .HasMaxLength(100)
                .IsFixedLength();
            _ = entity.Property(e => e.Lootid).HasColumnName("lootid");
            _ = entity.Property(e => e.ManaModifier).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            _ = entity.Property(e => e.Maxlevel)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxlevel");
            _ = entity.Property(e => e.MechanicImmuneMask).HasColumnName("mechanic_immune_mask");
            _ = entity.Property(e => e.Mingold).HasColumnName("mingold");
            _ = entity.Property(e => e.Minlevel)
                .HasDefaultValueSql("'1'")
                .HasColumnName("minlevel");
            _ = entity.Property(e => e.Modelid1).HasColumnName("modelid1");
            _ = entity.Property(e => e.Modelid2).HasColumnName("modelid2");
            _ = entity.Property(e => e.Modelid3).HasColumnName("modelid3");
            _ = entity.Property(e => e.Modelid4).HasColumnName("modelid4");
            _ = entity.Property(e => e.MovementId).HasColumnName("movementId");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasColumnName("name");
            _ = entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            _ = entity.Property(e => e.Pickpocketloot).HasColumnName("pickpocketloot");
            _ = entity.Property(e => e.RangeVariance).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
            _ = entity.Property(e => e.RegenHealth).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.Scale)
                .HasDefaultValueSql("'1'")
                .HasColumnName("scale");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.Skinloot).HasColumnName("skinloot");
            _ = entity.Property(e => e.SpeedRun)
                .HasDefaultValueSql("'1.14286'")
                .HasComment("Result of 8.0/7.0, most common value")
                .HasColumnName("speed_run");
            _ = entity.Property(e => e.SpeedWalk)
                .HasDefaultValueSql("'1'")
                .HasComment("Result of 2.5/2.5, most common value")
                .HasColumnName("speed_walk");
            _ = entity.Property(e => e.SpellSchoolImmuneMask).HasColumnName("spell_school_immune_mask");
            _ = entity.Property(e => e.Subname)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("subname");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.TypeFlags).HasColumnName("type_flags");
            _ = entity.Property(e => e.UnitClass).HasColumnName("unit_class");
            _ = entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            _ = entity.Property(e => e.UnitFlags2).HasColumnName("unit_flags2");
        });

        _ = modelBuilder.Entity<CreatureTemplateAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Auras)
                .HasColumnType("mediumtext")
                .HasColumnName("auras");
            _ = entity.Property(e => e.Emote).HasColumnName("emote");
            _ = entity.Property(e => e.Mount).HasColumnName("mount");
            _ = entity.Property(e => e.MountCreatureId).HasColumnName("MountCreatureID");
            _ = entity.Property(e => e.PathId).HasColumnName("path_id");
            _ = entity.Property(e => e.PvPflags).HasColumnName("PvPFlags");
            _ = entity.Property(e => e.SheathState).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        _ = modelBuilder.Entity<CreatureTemplateLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Title).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<CreatureTemplateMovement>(entity =>
        {
            _ = entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            _ = entity
                .ToTable("creature_template_movement")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).ValueGeneratedNever();
            _ = entity.Property(e => e.InteractionPauseTimer).HasComment("Time (in milliseconds) during which creature will not move after interaction with player");
        });

        _ = modelBuilder.Entity<CreatureTemplateResistance>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureId, e.School })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_template_resistance")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        _ = modelBuilder.Entity<CreatureTemplateSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureId, e.Index })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("creature_template_spell")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        _ = modelBuilder.Entity<CreatureText>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("creature_text")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            _ = entity.Property(e => e.GroupId).HasColumnName("GroupID");
            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            _ = entity.Property(e => e.Probability).HasColumnType("float unsigned");
        });

        _ = modelBuilder.Entity<CreatureTextLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            _ = entity
                .ToTable("creature_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            _ = entity.Property(e => e.GroupId).HasColumnName("GroupID");
            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale).HasMaxLength(4);
            _ = entity.Property(e => e.Text).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<Disable>(entity =>
        {
            _ = entity.HasKey(e => new { e.SourceType, e.Entry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("disables")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SourceType).HasColumnName("sourceType");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Params0)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_0");
            _ = entity.Property(e => e.Params1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_1");
        });

        _ = modelBuilder.Entity<DisenchantLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("disenchant_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<EventScript>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("event_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Command).HasColumnName("command");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Dataint).HasColumnName("dataint");
            _ = entity.Property(e => e.Datalong).HasColumnName("datalong");
            _ = entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            _ = entity.Property(e => e.Delay).HasColumnName("delay");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.O).HasColumnName("o");
            _ = entity.Property(e => e.X).HasColumnName("x");
            _ = entity.Property(e => e.Y).HasColumnName("y");
            _ = entity.Property(e => e.Z).HasColumnName("z");
        });

        _ = modelBuilder.Entity<ExplorationBasexp>(entity =>
        {
            _ = entity.HasKey(e => e.Level).HasName("PRIMARY");

            _ = entity
                .ToTable("exploration_basexp", tb => tb.HasComment("Exploration System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Basexp).HasColumnName("basexp");
        });

        _ = modelBuilder.Entity<FishingLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("fishing_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<GameEvent>(entity =>
        {
            _ = entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Announce)
                .HasDefaultValueSql("'2'")
                .HasComment("0 dont announce, 1 announce, 2 value from config")
                .HasColumnName("announce");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Description of the event displayed in console")
                .HasColumnName("description");
            _ = entity.Property(e => e.EndTime)
                .HasComment("Absolute end date, the event will never start after")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            _ = entity.Property(e => e.Holiday)
                .HasComment("Client side holiday id")
                .HasColumnName("holiday");
            _ = entity.Property(e => e.HolidayStage).HasColumnName("holidayStage");
            _ = entity.Property(e => e.Length)
                .HasDefaultValueSql("'2592000'")
                .HasComment("Length in minutes of the event")
                .HasColumnName("length");
            _ = entity.Property(e => e.Occurence)
                .HasDefaultValueSql("'5184000'")
                .HasComment("Delay in minutes between occurences of the event")
                .HasColumnName("occurence");
            _ = entity.Property(e => e.StartTime)
                .HasComment("Absolute start date, the event will never start before")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
            _ = entity.Property(e => e.WorldEvent)
                .HasComment("0 if normal event, 1 if world event")
                .HasColumnName("world_event");
        });

        _ = modelBuilder.Entity<GameEventArenaSeason>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("game_event_arena_seasons")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Season, e.EventEntry }, "season").IsUnique();

            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Season)
                .HasComment("Arena season number")
                .HasColumnName("season");
        });

        _ = modelBuilder.Entity<GameEventBattlegroundHoliday>(entity =>
        {
            _ = entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event_battleground_holiday")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry).HasComment("game_event EventEntry identifier");
            _ = entity.Property(e => e.BattlegroundId).HasColumnName("BattlegroundID");
        });

        _ = modelBuilder.Entity<GameEventCondition>(entity =>
        {
            _ = entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_condition")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            _ = entity.Property(e => e.DoneWorldStateField).HasColumnName("done_world_state_field");
            _ = entity.Property(e => e.MaxWorldStateField).HasColumnName("max_world_state_field");
            _ = entity.Property(e => e.ReqNum)
                .HasDefaultValueSql("'0'")
                .HasColumnName("req_num");
        });

        _ = modelBuilder.Entity<GameEventCreature>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_creature")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameEventCreatureQuest>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_creature_quest")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Quest).HasColumnName("quest");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameEventGameobject>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_gameobject")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameEventGameobjectQuest>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("game_event_gameobject_quest")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Quest).HasColumnName("quest");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameEventModelEquip>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event_model_equip")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Modelid).HasColumnName("modelid");
        });

        _ = modelBuilder.Entity<GameEventNpcVendor>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_npc_vendor")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Slot, "slot");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Item).HasColumnName("item");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            _ = entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            _ = entity.Property(e => e.Slot).HasColumnName("slot");
        });

        _ = modelBuilder.Entity<GameEventNpcflag>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_npcflag")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Npcflag).HasColumnName("npcflag");
        });

        _ = modelBuilder.Entity<GameEventPool>(entity =>
        {
            _ = entity.HasKey(e => e.PoolEntry).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event_pool")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.PoolEntry)
                .ValueGeneratedNever()
                .HasComment("Id of the pool")
                .HasColumnName("pool_entry");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameEventPrerequisite>(entity =>
        {
            _ = entity.HasKey(e => new { e.EventEntry, e.PrerequisiteEvent })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_prerequisite")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.PrerequisiteEvent).HasColumnName("prerequisite_event");
        });

        _ = modelBuilder.Entity<GameEventQuestCondition>(entity =>
        {
            _ = entity.HasKey(e => e.Quest).HasName("PRIMARY");

            _ = entity
                .ToTable("game_event_quest_condition")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Quest)
                .ValueGeneratedNever()
                .HasColumnName("quest");
            _ = entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            _ = entity.Property(e => e.Num)
                .HasDefaultValueSql("'0'")
                .HasColumnName("num");
        });

        _ = modelBuilder.Entity<GameEventSeasonalQuestrelation>(entity =>
        {
            _ = entity.HasKey(e => new { e.QuestId, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("game_event_seasonal_questrelation", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.QuestId, "idx_quest");

            _ = entity.Property(e => e.QuestId)
                .HasComment("Quest Identifier")
                .HasColumnName("questId");
            _ = entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        _ = modelBuilder.Entity<GameTele>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("game_tele", tb => tb.HasComment("Tele Command"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Map).HasColumnName("map");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        _ = modelBuilder.Entity<GameWeather>(entity =>
        {
            _ = entity.HasKey(e => e.Zone).HasName("PRIMARY");

            _ = entity
                .ToTable("game_weather", tb => tb.HasComment("Weather System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Zone)
                .ValueGeneratedNever()
                .HasColumnName("zone");
            _ = entity.Property(e => e.FallRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_rain_chance");
            _ = entity.Property(e => e.FallSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_snow_chance");
            _ = entity.Property(e => e.FallStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_storm_chance");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.SpringRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_rain_chance");
            _ = entity.Property(e => e.SpringSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_snow_chance");
            _ = entity.Property(e => e.SpringStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_storm_chance");
            _ = entity.Property(e => e.SummerRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_rain_chance");
            _ = entity.Property(e => e.SummerSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_snow_chance");
            _ = entity.Property(e => e.SummerStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_storm_chance");
            _ = entity.Property(e => e.WinterRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_rain_chance");
            _ = entity.Property(e => e.WinterSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_snow_chance");
            _ = entity.Property(e => e.WinterStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_storm_chance");
        });

        _ = modelBuilder.Entity<Gameobject>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("gameobject", tb => tb.HasComment("Gameobject System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Animprogress).HasColumnName("animprogress");
            _ = entity.Property(e => e.AreaId)
                .HasComment("Area Identifier")
                .HasColumnName("areaId");
            _ = entity.Property(e => e.Id)
                .HasComment("Gameobject Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PhaseMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("phaseMask");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.Rotation0).HasColumnName("rotation0");
            _ = entity.Property(e => e.Rotation1).HasColumnName("rotation1");
            _ = entity.Property(e => e.Rotation2).HasColumnName("rotation2");
            _ = entity.Property(e => e.Rotation3).HasColumnName("rotation3");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            _ = entity.Property(e => e.SpawnMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spawnMask");
            _ = entity.Property(e => e.Spawntimesecs).HasColumnName("spawntimesecs");
            _ = entity.Property(e => e.State).HasColumnName("state");
            _ = entity.Property(e => e.ZoneId)
                .HasComment("Zone Identifier")
                .HasColumnName("zoneId");
        });

        _ = modelBuilder.Entity<GameobjectAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("gameobject_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.InvisibilityType).HasColumnName("invisibilityType");
            _ = entity.Property(e => e.InvisibilityValue).HasColumnName("invisibilityValue");
            _ = entity.Property(e => e.ParentRotation0).HasColumnName("parent_rotation0");
            _ = entity.Property(e => e.ParentRotation1).HasColumnName("parent_rotation1");
            _ = entity.Property(e => e.ParentRotation2).HasColumnName("parent_rotation2");
            _ = entity.Property(e => e.ParentRotation3)
                .HasDefaultValueSql("'1'")
                .HasColumnName("parent_rotation3");
        });

        _ = modelBuilder.Entity<GameobjectLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gameobject_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<GameobjectOverride>(entity =>
        {
            _ = entity.HasKey(e => e.SpawnId).HasName("PRIMARY");

            _ = entity
                .ToTable("gameobject_overrides")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpawnId)
                .ValueGeneratedNever()
                .HasColumnName("spawnId");
            _ = entity.Property(e => e.Faction).HasColumnName("faction");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
        });

        _ = modelBuilder.Entity<GameobjectQuestender>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gameobject_questender")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<GameobjectQuestitem>(entity =>
        {
            _ = entity.HasKey(e => new { e.GameObjectEntry, e.Idx })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gameobject_questitem")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<GameobjectQueststarter>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gameobject_queststarter")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        _ = modelBuilder.Entity<GameobjectTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("gameobject_template", tb => tb.HasComment("Gameobject System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Name, "idx_name");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            _ = entity.Property(e => e.CastBarCaption)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("castBarCaption");
            _ = entity.Property(e => e.DisplayId).HasColumnName("displayId");
            _ = entity.Property(e => e.IconName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Size)
                .HasDefaultValueSql("'1'")
                .HasColumnName("size");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.Unk1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("unk1");
        });

        _ = modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("gameobject_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Artkit0).HasColumnName("artkit0");
            _ = entity.Property(e => e.Artkit1).HasColumnName("artkit1");
            _ = entity.Property(e => e.Artkit2).HasColumnName("artkit2");
            _ = entity.Property(e => e.Artkit3).HasColumnName("artkit3");
            _ = entity.Property(e => e.Faction).HasColumnName("faction");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            _ = entity.Property(e => e.Mingold).HasColumnName("mingold");
        });

        _ = modelBuilder.Entity<GameobjectTemplateLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gameobject_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.CastBarCaption)
                .HasColumnType("mediumtext")
                .HasColumnName("castBarCaption");
            _ = entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
        });

        _ = modelBuilder.Entity<GossipMenu>(entity =>
        {
            _ = entity.HasKey(e => new { e.MenuId, e.TextId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gossip_menu")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MenuId).HasColumnName("MenuID");
            _ = entity.Property(e => e.TextId).HasColumnName("TextID");
        });

        _ = modelBuilder.Entity<GossipMenuOption>(entity =>
        {
            _ = entity.HasKey(e => new { e.MenuId, e.OptionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("gossip_menu_option")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MenuId).HasColumnName("MenuID");
            _ = entity.Property(e => e.OptionId).HasColumnName("OptionID");
            _ = entity.Property(e => e.ActionMenuId).HasColumnName("ActionMenuID");
            _ = entity.Property(e => e.ActionPoiId).HasColumnName("ActionPoiID");
            _ = entity.Property(e => e.BoxBroadcastTextId).HasColumnName("BoxBroadcastTextID");
            _ = entity.Property(e => e.BoxText).HasColumnType("mediumtext");
            _ = entity.Property(e => e.OptionBroadcastTextId).HasColumnName("OptionBroadcastTextID");
            _ = entity.Property(e => e.OptionText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<GossipMenuOptionLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.MenuId, e.OptionId, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("gossip_menu_option_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.MenuId).HasColumnName("MenuID");
            _ = entity.Property(e => e.OptionId).HasColumnName("OptionID");
            _ = entity.Property(e => e.Locale).HasMaxLength(4);
            _ = entity.Property(e => e.BoxText).HasColumnType("mediumtext");
            _ = entity.Property(e => e.OptionText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<GraveyardZone>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.GhostZone })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("graveyard_zone", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Comment).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<HolidayDate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.DateId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("holiday_dates")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.DateId).HasColumnName("date_id");
            _ = entity.Property(e => e.DateValue).HasColumnName("date_value");
            _ = entity.Property(e => e.HolidayDuration).HasColumnName("holiday_duration");
        });

        _ = modelBuilder.Entity<InstanceEncounter>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("instance_encounters")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Unique entry from DungeonEncounter.dbc")
                .HasColumnName("entry");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            _ = entity.Property(e => e.CreditEntry).HasColumnName("creditEntry");
            _ = entity.Property(e => e.CreditType).HasColumnName("creditType");
            _ = entity.Property(e => e.LastEncounterDungeon)
                .HasComment("If not 0, LfgDungeon.dbc entry for the instance it is last encounter in")
                .HasColumnName("lastEncounterDungeon");
        });

        _ = modelBuilder.Entity<InstanceSpawnGroup>(entity =>
        {
            _ = entity.HasKey(e => new { e.InstanceMapId, e.BossStateId, e.SpawnGroupId, e.BossStates })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            _ = entity
                .ToTable("instance_spawn_groups")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.InstanceMapId).HasColumnName("instanceMapId");
            _ = entity.Property(e => e.BossStateId).HasColumnName("bossStateId");
            _ = entity.Property(e => e.SpawnGroupId).HasColumnName("spawnGroupId");
            _ = entity.Property(e => e.BossStates).HasColumnName("bossStates");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
        });

        _ = modelBuilder.Entity<InstanceTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Map).HasName("PRIMARY");

            _ = entity
                .ToTable("instance_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Map)
                .ValueGeneratedNever()
                .HasColumnName("map");
            _ = entity.Property(e => e.AllowMount).HasColumnName("allowMount");
            _ = entity.Property(e => e.Parent).HasColumnName("parent");
            _ = entity.Property(e => e.Script)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script");
        });

        _ = modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Ench })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("item_enchantment_template", tb => tb.HasComment("Item Random Enchantment System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Ench).HasColumnName("ench");
            _ = entity.Property(e => e.Chance)
                .HasColumnType("float unsigned")
                .HasColumnName("chance");
        });

        _ = modelBuilder.Entity<ItemLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("item_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<ItemSetName>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("item_set_names")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        _ = modelBuilder.Entity<ItemSetNamesLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("item_set_names_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<ItemTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("item_template", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Name, "idx_name");

            _ = entity.HasIndex(e => e.Class, "items_index");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.AllowableClass).HasDefaultValueSql("'-1'");
            _ = entity.Property(e => e.AllowableRace).HasDefaultValueSql("'-1'");
            _ = entity.Property(e => e.AmmoType).HasColumnName("ammo_type");
            _ = entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            _ = entity.Property(e => e.Area).HasColumnName("area");
            _ = entity.Property(e => e.Armor).HasColumnName("armor");
            _ = entity.Property(e => e.Block).HasColumnName("block");
            _ = entity.Property(e => e.Bonding).HasColumnName("bonding");
            _ = entity.Property(e => e.BuyCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Delay)
                .HasDefaultValueSql("'1000'")
                .HasColumnName("delay");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            _ = entity.Property(e => e.DisenchantId).HasColumnName("DisenchantID");
            _ = entity.Property(e => e.Displayid).HasColumnName("displayid");
            _ = entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");
            _ = entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");
            _ = entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");
            _ = entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");
            _ = entity.Property(e => e.DmgType1).HasColumnName("dmg_type1");
            _ = entity.Property(e => e.DmgType2).HasColumnName("dmg_type2");
            _ = entity.Property(e => e.Duration).HasColumnName("duration");
            _ = entity.Property(e => e.FireRes).HasColumnName("fire_res");
            _ = entity.Property(e => e.FlagsCustom).HasColumnName("flagsCustom");
            _ = entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            _ = entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            _ = entity.Property(e => e.Itemset).HasColumnName("itemset");
            _ = entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            _ = entity.Property(e => e.Lockid).HasColumnName("lockid");
            _ = entity.Property(e => e.MaxMoneyLoot).HasColumnName("maxMoneyLoot");
            _ = entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            _ = entity.Property(e => e.MinMoneyLoot).HasColumnName("minMoneyLoot");
            _ = entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            _ = entity.Property(e => e.RequiredDisenchantSkill).HasDefaultValueSql("'-1'");
            _ = entity.Property(e => e.Requiredhonorrank).HasColumnName("requiredhonorrank");
            _ = entity.Property(e => e.Requiredspell).HasColumnName("requiredspell");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            _ = entity.Property(e => e.Sheath).HasColumnName("sheath");
            _ = entity.Property(e => e.SocketBonus).HasColumnName("socketBonus");
            _ = entity.Property(e => e.SocketColor1).HasColumnName("socketColor_1");
            _ = entity.Property(e => e.SocketColor2).HasColumnName("socketColor_2");
            _ = entity.Property(e => e.SocketColor3).HasColumnName("socketColor_3");
            _ = entity.Property(e => e.SocketContent1).HasColumnName("socketContent_1");
            _ = entity.Property(e => e.SocketContent2).HasColumnName("socketContent_2");
            _ = entity.Property(e => e.SocketContent3).HasColumnName("socketContent_3");
            _ = entity.Property(e => e.SoundOverrideSubclass).HasDefaultValueSql("'-1'");
            _ = entity.Property(e => e.Spellcategory1).HasColumnName("spellcategory_1");
            _ = entity.Property(e => e.Spellcategory2).HasColumnName("spellcategory_2");
            _ = entity.Property(e => e.Spellcategory3).HasColumnName("spellcategory_3");
            _ = entity.Property(e => e.Spellcategory4).HasColumnName("spellcategory_4");
            _ = entity.Property(e => e.Spellcategory5).HasColumnName("spellcategory_5");
            _ = entity.Property(e => e.Spellcategorycooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_1");
            _ = entity.Property(e => e.Spellcategorycooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_2");
            _ = entity.Property(e => e.Spellcategorycooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_3");
            _ = entity.Property(e => e.Spellcategorycooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_4");
            _ = entity.Property(e => e.Spellcategorycooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_5");
            _ = entity.Property(e => e.Spellcharges1).HasColumnName("spellcharges_1");
            _ = entity.Property(e => e.Spellcharges2).HasColumnName("spellcharges_2");
            _ = entity.Property(e => e.Spellcharges3).HasColumnName("spellcharges_3");
            _ = entity.Property(e => e.Spellcharges4).HasColumnName("spellcharges_4");
            _ = entity.Property(e => e.Spellcharges5).HasColumnName("spellcharges_5");
            _ = entity.Property(e => e.Spellcooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_1");
            _ = entity.Property(e => e.Spellcooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_2");
            _ = entity.Property(e => e.Spellcooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_3");
            _ = entity.Property(e => e.Spellcooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_4");
            _ = entity.Property(e => e.Spellcooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_5");
            _ = entity.Property(e => e.Spellid1).HasColumnName("spellid_1");
            _ = entity.Property(e => e.Spellid2).HasColumnName("spellid_2");
            _ = entity.Property(e => e.Spellid3).HasColumnName("spellid_3");
            _ = entity.Property(e => e.Spellid4).HasColumnName("spellid_4");
            _ = entity.Property(e => e.Spellid5).HasColumnName("spellid_5");
            _ = entity.Property(e => e.SpellppmRate1).HasColumnName("spellppmRate_1");
            _ = entity.Property(e => e.SpellppmRate2).HasColumnName("spellppmRate_2");
            _ = entity.Property(e => e.SpellppmRate3).HasColumnName("spellppmRate_3");
            _ = entity.Property(e => e.SpellppmRate4).HasColumnName("spellppmRate_4");
            _ = entity.Property(e => e.SpellppmRate5).HasColumnName("spellppmRate_5");
            _ = entity.Property(e => e.Spelltrigger1).HasColumnName("spelltrigger_1");
            _ = entity.Property(e => e.Spelltrigger2).HasColumnName("spelltrigger_2");
            _ = entity.Property(e => e.Spelltrigger3).HasColumnName("spelltrigger_3");
            _ = entity.Property(e => e.Spelltrigger4).HasColumnName("spelltrigger_4");
            _ = entity.Property(e => e.Spelltrigger5).HasColumnName("spelltrigger_5");
            _ = entity.Property(e => e.Stackable)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackable");
            _ = entity.Property(e => e.Startquest).HasColumnName("startquest");
            _ = entity.Property(e => e.StatType1).HasColumnName("stat_type1");
            _ = entity.Property(e => e.StatType10).HasColumnName("stat_type10");
            _ = entity.Property(e => e.StatType2).HasColumnName("stat_type2");
            _ = entity.Property(e => e.StatType3).HasColumnName("stat_type3");
            _ = entity.Property(e => e.StatType4).HasColumnName("stat_type4");
            _ = entity.Property(e => e.StatType5).HasColumnName("stat_type5");
            _ = entity.Property(e => e.StatType6).HasColumnName("stat_type6");
            _ = entity.Property(e => e.StatType7).HasColumnName("stat_type7");
            _ = entity.Property(e => e.StatType8).HasColumnName("stat_type8");
            _ = entity.Property(e => e.StatType9).HasColumnName("stat_type9");
            _ = entity.Property(e => e.StatValue1).HasColumnName("stat_value1");
            _ = entity.Property(e => e.StatValue10).HasColumnName("stat_value10");
            _ = entity.Property(e => e.StatValue2).HasColumnName("stat_value2");
            _ = entity.Property(e => e.StatValue3).HasColumnName("stat_value3");
            _ = entity.Property(e => e.StatValue4).HasColumnName("stat_value4");
            _ = entity.Property(e => e.StatValue5).HasColumnName("stat_value5");
            _ = entity.Property(e => e.StatValue6).HasColumnName("stat_value6");
            _ = entity.Property(e => e.StatValue7).HasColumnName("stat_value7");
            _ = entity.Property(e => e.StatValue8).HasColumnName("stat_value8");
            _ = entity.Property(e => e.StatValue9).HasColumnName("stat_value9");
            _ = entity.Property(e => e.Subclass).HasColumnName("subclass");
        });

        _ = modelBuilder.Entity<ItemTemplateLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("item_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Description).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<LfgDungeonReward>(entity =>
        {
            _ = entity.HasKey(e => new { e.DungeonId, e.MaxLevel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("lfg_dungeon_rewards")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.DungeonId)
                .HasComment("Dungeon entry from dbc")
                .HasColumnName("dungeonId");
            _ = entity.Property(e => e.MaxLevel)
                .HasComment("Max level at which this reward is rewarded")
                .HasColumnName("maxLevel");
            _ = entity.Property(e => e.FirstQuestId)
                .HasComment("Quest id with rewards for first dungeon this day")
                .HasColumnName("firstQuestId");
            _ = entity.Property(e => e.OtherQuestId)
                .HasComment("Quest id with rewards for Nth dungeon this day")
                .HasColumnName("otherQuestId");
        });

        _ = modelBuilder.Entity<LfgDungeonTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.DungeonId).HasName("PRIMARY");

            _ = entity
                .ToTable("lfg_dungeon_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.DungeonId)
                .ValueGeneratedNever()
                .HasComment("Unique id from LFGDungeons.dbc")
                .HasColumnName("dungeonId");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        _ = modelBuilder.Entity<LinkedRespawn>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.LinkType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("linked_respawn", tb => tb.HasComment("Creature Respawn Link System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("dependent creature")
                .HasColumnName("guid");
            _ = entity.Property(e => e.LinkType).HasColumnName("linkType");
            _ = entity.Property(e => e.LinkedGuid)
                .HasComment("master creature")
                .HasColumnName("linkedGuid");
        });

        _ = modelBuilder.Entity<MailLevelReward>(entity =>
        {
            _ = entity.HasKey(e => new { e.Level, e.RaceMask })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("mail_level_reward", tb => tb.HasComment("Mail System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            _ = entity.Property(e => e.MailTemplateId).HasColumnName("mailTemplateId");
            _ = entity.Property(e => e.SenderEntry).HasColumnName("senderEntry");
        });

        _ = modelBuilder.Entity<MailLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("mail_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<MillingLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("milling_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<NpcSpellclickSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.NpcEntry, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("npc_spellclick_spells")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.NpcEntry)
                .HasComment("reference to creature_template")
                .HasColumnName("npc_entry");
            _ = entity.Property(e => e.SpellId)
                .HasComment("spell which should be casted ")
                .HasColumnName("spell_id");
            _ = entity.Property(e => e.CastFlags)
                .HasComment("first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit")
                .HasColumnName("cast_flags");
            _ = entity.Property(e => e.UserType)
                .HasComment("relation with summoner: 0-no 1-friendly 2-raid 3-party player can click")
                .HasColumnName("user_type");
        });

        _ = modelBuilder.Entity<NpcText>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("npc_text")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.BroadcastTextId0).HasColumnName("BroadcastTextID0");
            _ = entity.Property(e => e.BroadcastTextId1).HasColumnName("BroadcastTextID1");
            _ = entity.Property(e => e.BroadcastTextId2).HasColumnName("BroadcastTextID2");
            _ = entity.Property(e => e.BroadcastTextId3).HasColumnName("BroadcastTextID3");
            _ = entity.Property(e => e.BroadcastTextId4).HasColumnName("BroadcastTextID4");
            _ = entity.Property(e => e.BroadcastTextId5).HasColumnName("BroadcastTextID5");
            _ = entity.Property(e => e.BroadcastTextId6).HasColumnName("BroadcastTextID6");
            _ = entity.Property(e => e.BroadcastTextId7).HasColumnName("BroadcastTextID7");
            _ = entity.Property(e => e.Emote00).HasColumnName("Emote0_0");
            _ = entity.Property(e => e.Emote01).HasColumnName("Emote0_1");
            _ = entity.Property(e => e.Emote02).HasColumnName("Emote0_2");
            _ = entity.Property(e => e.Emote10).HasColumnName("Emote1_0");
            _ = entity.Property(e => e.Emote11).HasColumnName("Emote1_1");
            _ = entity.Property(e => e.Emote12).HasColumnName("Emote1_2");
            _ = entity.Property(e => e.Emote20).HasColumnName("Emote2_0");
            _ = entity.Property(e => e.Emote21).HasColumnName("Emote2_1");
            _ = entity.Property(e => e.Emote22).HasColumnName("Emote2_2");
            _ = entity.Property(e => e.Emote30).HasColumnName("Emote3_0");
            _ = entity.Property(e => e.Emote31).HasColumnName("Emote3_1");
            _ = entity.Property(e => e.Emote32).HasColumnName("Emote3_2");
            _ = entity.Property(e => e.Emote40).HasColumnName("Emote4_0");
            _ = entity.Property(e => e.Emote41).HasColumnName("Emote4_1");
            _ = entity.Property(e => e.Emote42).HasColumnName("Emote4_2");
            _ = entity.Property(e => e.Emote50).HasColumnName("Emote5_0");
            _ = entity.Property(e => e.Emote51).HasColumnName("Emote5_1");
            _ = entity.Property(e => e.Emote52).HasColumnName("Emote5_2");
            _ = entity.Property(e => e.Emote60).HasColumnName("Emote6_0");
            _ = entity.Property(e => e.Emote61).HasColumnName("Emote6_1");
            _ = entity.Property(e => e.Emote62).HasColumnName("Emote6_2");
            _ = entity.Property(e => e.Emote70).HasColumnName("Emote7_0");
            _ = entity.Property(e => e.Emote71).HasColumnName("Emote7_1");
            _ = entity.Property(e => e.Emote72).HasColumnName("Emote7_2");
            _ = entity.Property(e => e.EmoteDelay00).HasColumnName("EmoteDelay0_0");
            _ = entity.Property(e => e.EmoteDelay01).HasColumnName("EmoteDelay0_1");
            _ = entity.Property(e => e.EmoteDelay02).HasColumnName("EmoteDelay0_2");
            _ = entity.Property(e => e.EmoteDelay10).HasColumnName("EmoteDelay1_0");
            _ = entity.Property(e => e.EmoteDelay11).HasColumnName("EmoteDelay1_1");
            _ = entity.Property(e => e.EmoteDelay12).HasColumnName("EmoteDelay1_2");
            _ = entity.Property(e => e.EmoteDelay20).HasColumnName("EmoteDelay2_0");
            _ = entity.Property(e => e.EmoteDelay21).HasColumnName("EmoteDelay2_1");
            _ = entity.Property(e => e.EmoteDelay22).HasColumnName("EmoteDelay2_2");
            _ = entity.Property(e => e.EmoteDelay30).HasColumnName("EmoteDelay3_0");
            _ = entity.Property(e => e.EmoteDelay31).HasColumnName("EmoteDelay3_1");
            _ = entity.Property(e => e.EmoteDelay32).HasColumnName("EmoteDelay3_2");
            _ = entity.Property(e => e.EmoteDelay40).HasColumnName("EmoteDelay4_0");
            _ = entity.Property(e => e.EmoteDelay41).HasColumnName("EmoteDelay4_1");
            _ = entity.Property(e => e.EmoteDelay42).HasColumnName("EmoteDelay4_2");
            _ = entity.Property(e => e.EmoteDelay50).HasColumnName("EmoteDelay5_0");
            _ = entity.Property(e => e.EmoteDelay51).HasColumnName("EmoteDelay5_1");
            _ = entity.Property(e => e.EmoteDelay52).HasColumnName("EmoteDelay5_2");
            _ = entity.Property(e => e.EmoteDelay60).HasColumnName("EmoteDelay6_0");
            _ = entity.Property(e => e.EmoteDelay61).HasColumnName("EmoteDelay6_1");
            _ = entity.Property(e => e.EmoteDelay62).HasColumnName("EmoteDelay6_2");
            _ = entity.Property(e => e.EmoteDelay70).HasColumnName("EmoteDelay7_0");
            _ = entity.Property(e => e.EmoteDelay71).HasColumnName("EmoteDelay7_1");
            _ = entity.Property(e => e.EmoteDelay72).HasColumnName("EmoteDelay7_2");
            _ = entity.Property(e => e.Lang0).HasColumnName("lang0");
            _ = entity.Property(e => e.Lang1).HasColumnName("lang1");
            _ = entity.Property(e => e.Lang2).HasColumnName("lang2");
            _ = entity.Property(e => e.Lang3).HasColumnName("lang3");
            _ = entity.Property(e => e.Lang4).HasColumnName("lang4");
            _ = entity.Property(e => e.Lang5).HasColumnName("lang5");
            _ = entity.Property(e => e.Lang6).HasColumnName("lang6");
            _ = entity.Property(e => e.Lang7).HasColumnName("lang7");
            _ = entity.Property(e => e.Text00).HasColumnName("text0_0");
            _ = entity.Property(e => e.Text01).HasColumnName("text0_1");
            _ = entity.Property(e => e.Text10).HasColumnName("text1_0");
            _ = entity.Property(e => e.Text11).HasColumnName("text1_1");
            _ = entity.Property(e => e.Text20).HasColumnName("text2_0");
            _ = entity.Property(e => e.Text21).HasColumnName("text2_1");
            _ = entity.Property(e => e.Text30).HasColumnName("text3_0");
            _ = entity.Property(e => e.Text31).HasColumnName("text3_1");
            _ = entity.Property(e => e.Text40).HasColumnName("text4_0");
            _ = entity.Property(e => e.Text41).HasColumnName("text4_1");
            _ = entity.Property(e => e.Text50).HasColumnName("text5_0");
            _ = entity.Property(e => e.Text51).HasColumnName("text5_1");
            _ = entity.Property(e => e.Text60).HasColumnName("text6_0");
            _ = entity.Property(e => e.Text61).HasColumnName("text6_1");
            _ = entity.Property(e => e.Text70).HasColumnName("text7_0");
            _ = entity.Property(e => e.Text71).HasColumnName("text7_1");
        });

        _ = modelBuilder.Entity<NpcTextLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("npc_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale).HasMaxLength(4);
            _ = entity.Property(e => e.Text00).HasColumnName("Text0_0");
            _ = entity.Property(e => e.Text01).HasColumnName("Text0_1");
            _ = entity.Property(e => e.Text10).HasColumnName("Text1_0");
            _ = entity.Property(e => e.Text11).HasColumnName("Text1_1");
            _ = entity.Property(e => e.Text20).HasColumnName("Text2_0");
            _ = entity.Property(e => e.Text21).HasColumnName("Text2_1");
            _ = entity.Property(e => e.Text30).HasColumnName("Text3_0");
            _ = entity.Property(e => e.Text31).HasColumnName("Text3_1");
            _ = entity.Property(e => e.Text40).HasColumnName("Text4_0");
            _ = entity.Property(e => e.Text41).HasColumnName("Text4_1");
            _ = entity.Property(e => e.Text50).HasColumnName("Text5_0");
            _ = entity.Property(e => e.Text51).HasColumnName("Text5_1");
            _ = entity.Property(e => e.Text60).HasColumnName("Text6_0");
            _ = entity.Property(e => e.Text61).HasColumnName("Text6_1");
            _ = entity.Property(e => e.Text70).HasColumnName("Text7_0");
            _ = entity.Property(e => e.Text71).HasColumnName("Text7_1");
        });

        _ = modelBuilder.Entity<NpcVendor>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item, e.ExtendedCost })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("npc_vendor", tb => tb.HasComment("Npc System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Slot, "slot");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Item).HasColumnName("item");
            _ = entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            _ = entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            _ = entity.Property(e => e.Slot).HasColumnName("slot");
        });

        _ = modelBuilder.Entity<OutdoorpvpTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.TypeId).HasName("PRIMARY");

            _ = entity
                .ToTable("outdoorpvp_template", tb => tb.HasComment("OutdoorPvP Templates"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        _ = modelBuilder.Entity<PageText>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("page_text", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.NextPageId).HasColumnName("NextPageID");
        });

        _ = modelBuilder.Entity<PageTextLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("page_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Text).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<PetLevelstat>(entity =>
        {
            _ = entity.HasKey(e => new { e.CreatureEntry, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("pet_levelstats", tb => tb.HasComment("Stores pet levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureEntry).HasColumnName("creature_entry");
            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Agi).HasColumnName("agi");
            _ = entity.Property(e => e.Armor).HasColumnName("armor");
            _ = entity.Property(e => e.Hp).HasColumnName("hp");
            _ = entity.Property(e => e.Inte).HasColumnName("inte");
            _ = entity.Property(e => e.Mana).HasColumnName("mana");
            _ = entity.Property(e => e.MaxDmg).HasColumnName("max_dmg");
            _ = entity.Property(e => e.MinDmg).HasColumnName("min_dmg");
            _ = entity.Property(e => e.Spi).HasColumnName("spi");
            _ = entity.Property(e => e.Sta).HasColumnName("sta");
            _ = entity.Property(e => e.Str).HasColumnName("str");
        });

        _ = modelBuilder.Entity<PetNameGeneration>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("pet_name_generation")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Half).HasColumnName("half");
            _ = entity.Property(e => e.Word)
                .HasColumnType("text")
                .HasColumnName("word");
        });

        _ = modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("pickpocketing_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<PlayerClasslevelstat>(entity =>
        {
            _ = entity.HasKey(e => new { e.Class, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_classlevelstats", tb => tb.HasComment("Stores levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Basehp).HasColumnName("basehp");
            _ = entity.Property(e => e.Basemana).HasColumnName("basemana");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeAchievement>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_achievement")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeItem>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_items")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
            _ = entity.Property(e => e.CommentA)
                .HasColumnType("mediumtext")
                .HasColumnName("commentA");
            _ = entity.Property(e => e.CommentH)
                .HasColumnType("mediumtext")
                .HasColumnName("commentH");
            _ = entity.Property(e => e.RaceA).HasColumnName("race_A");
            _ = entity.Property(e => e.RaceH).HasColumnName("race_H");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeQuest>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_quests")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.AllianceId, "alliance_uniq").IsUnique();

            _ = entity.HasIndex(e => e.HordeId, "horde_uniq").IsUnique();

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeReputation>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_reputations")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_spells")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        _ = modelBuilder.Entity<PlayerFactionchangeTitle>(entity =>
        {
            _ = entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_factionchange_titles")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            _ = entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        _ = modelBuilder.Entity<PlayerLevelstat>(entity =>
        {
            _ = entity.HasKey(e => new { e.Race, e.Class, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("player_levelstats", tb => tb.HasComment("Stores levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Race).HasColumnName("race");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Agi).HasColumnName("agi");
            _ = entity.Property(e => e.Inte).HasColumnName("inte");
            _ = entity.Property(e => e.Spi).HasColumnName("spi");
            _ = entity.Property(e => e.Sta).HasColumnName("sta");
            _ = entity.Property(e => e.Str).HasColumnName("str");
        });

        _ = modelBuilder.Entity<PlayerTotemModel>(entity =>
        {
            _ = entity.HasKey(e => new { e.TotemSlot, e.RaceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("player_totem_model")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<PlayerXpForLevel>(entity =>
        {
            _ = entity.HasKey(e => e.Level).HasName("PRIMARY");

            _ = entity
                .ToTable("player_xp_for_level")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<Playercreateinfo>(entity =>
        {
            _ = entity.HasKey(e => new { e.Race, e.Class })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("playercreateinfo")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Race).HasColumnName("race");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Map).HasColumnName("map");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.Zone).HasColumnName("zone");
        });

        _ = modelBuilder.Entity<PlayercreateinfoAction>(entity =>
        {
            _ = entity.HasKey(e => new { e.Race, e.Class, e.Button })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("playercreateinfo_action")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            _ = entity.Property(e => e.Race).HasColumnName("race");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Button).HasColumnName("button");
            _ = entity.Property(e => e.Action).HasColumnName("action");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<PlayercreateinfoCastSpell>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("playercreateinfo_cast_spell")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.ClassMask).HasColumnName("classMask");
            _ = entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
            _ = entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            _ = entity.Property(e => e.Spell).HasColumnName("spell");
        });

        _ = modelBuilder.Entity<PlayercreateinfoItem>(entity =>
        {
            _ = entity.HasKey(e => new { e.Race, e.Class, e.Itemid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("playercreateinfo_item")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            _ = entity.Property(e => e.Race).HasColumnName("race");
            _ = entity.Property(e => e.Class).HasColumnName("class");
            _ = entity.Property(e => e.Itemid).HasColumnName("itemid");
            _ = entity.Property(e => e.Amount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("amount");
        });

        _ = modelBuilder.Entity<PlayercreateinfoSkill>(entity =>
        {
            _ = entity.HasKey(e => new { e.RaceMask, e.ClassMask, e.Skill })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("playercreateinfo_skills")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            _ = entity.Property(e => e.ClassMask).HasColumnName("classMask");
            _ = entity.Property(e => e.Skill).HasColumnName("skill");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
        });

        _ = modelBuilder.Entity<PlayercreateinfoSpellCustom>(entity =>
        {
            _ = entity.HasKey(e => new { e.Racemask, e.Classmask, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("playercreateinfo_spell_custom")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Racemask).HasColumnName("racemask");
            _ = entity.Property(e => e.Classmask).HasColumnName("classmask");
            _ = entity.Property(e => e.Note).HasMaxLength(255);
        });

        _ = modelBuilder.Entity<PointsOfInterest>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("points_of_interest")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<PointsOfInterestLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("points_of_interest_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<PoolMember>(entity =>
        {
            _ = entity.HasKey(e => new { e.Type, e.SpawnId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("pool_members")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.SpawnId).HasColumnName("spawnId");
            _ = entity.Property(e => e.Chance).HasColumnName("chance");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            _ = entity.Property(e => e.PoolSpawnId).HasColumnName("poolSpawnId");
        });

        _ = modelBuilder.Entity<PoolTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("pool_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Pool entry")
                .HasColumnName("entry");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            _ = entity.Property(e => e.MaxLimit)
                .HasComment("Max number of objects (0) is no limit")
                .HasColumnName("max_limit");
        });

        _ = modelBuilder.Entity<ProspectingLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("prospecting_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<QuestDetail>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_details")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        _ = modelBuilder.Entity<QuestGreeting>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("quest_greeting")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Greeting).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestGreetingLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Type, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("quest_greeting_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.Greeting).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestMailSender>(entity =>
        {
            _ = entity.HasKey(e => e.QuestId).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_mail_sender")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.QuestId).ValueGeneratedNever();
        });

        _ = modelBuilder.Entity<QuestOfferReward>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_offer_reward")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.RewardText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestOfferRewardLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("quest_offer_reward_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.RewardText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestPoi>(entity =>
        {
            _ = entity.HasKey(e => new { e.QuestId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("quest_poi")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.QuestId, e.Id }, "idx");

            _ = entity.Property(e => e.QuestId).HasColumnName("QuestID");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        _ = modelBuilder.Entity<QuestPoiPoint>(entity =>
        {
            _ = entity.HasKey(e => new { e.QuestId, e.Idx1, e.Idx2 })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("quest_poi_points")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.QuestId, e.Idx1 }, "questId_id");

            _ = entity.Property(e => e.QuestId).HasColumnName("QuestID");
        });

        _ = modelBuilder.Entity<QuestPoolMember>(entity =>
        {
            _ = entity.HasKey(e => e.QuestId).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_pool_members")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.QuestId)
                .ValueGeneratedNever()
                .HasColumnName("questId");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            _ = entity.Property(e => e.PoolId).HasColumnName("poolId");
            _ = entity.Property(e => e.PoolIndex)
                .HasComment("Multiple quests with the same index will always spawn together!")
                .HasColumnName("poolIndex");
        });

        _ = modelBuilder.Entity<QuestPoolTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.PoolId).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_pool_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.PoolId)
                .ValueGeneratedNever()
                .HasColumnName("poolId");
            _ = entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            _ = entity.Property(e => e.NumActive)
                .HasComment("Number of indices to have active at any time")
                .HasColumnName("numActive");
        });

        _ = modelBuilder.Entity<QuestRequestItem>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_request_items")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.CompletionText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestRequestItemsLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("quest_request_items_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.CompletionText).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<QuestTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_template", tb => tb.HasComment("Quest System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.AreaDescription).HasColumnType("mediumtext");
            _ = entity.Property(e => e.LogDescription).HasColumnType("mediumtext");
            _ = entity.Property(e => e.LogTitle).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText1).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText2).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText3).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText4).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Poicontinent).HasColumnName("POIContinent");
            _ = entity.Property(e => e.Poipriority).HasColumnName("POIPriority");
            _ = entity.Property(e => e.Poix).HasColumnName("POIx");
            _ = entity.Property(e => e.Poiy).HasColumnName("POIy");
            _ = entity.Property(e => e.QuestCompletionLog).HasColumnType("mediumtext");
            _ = entity.Property(e => e.QuestDescription).HasColumnType("mediumtext");
            _ = entity.Property(e => e.QuestInfoId).HasColumnName("QuestInfoID");
            _ = entity.Property(e => e.QuestLevel).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.QuestSortId).HasColumnName("QuestSortID");
            _ = entity.Property(e => e.QuestType).HasDefaultValueSql("'2'");
            _ = entity.Property(e => e.RewardChoiceItemId1).HasColumnName("RewardChoiceItemID1");
            _ = entity.Property(e => e.RewardChoiceItemId2).HasColumnName("RewardChoiceItemID2");
            _ = entity.Property(e => e.RewardChoiceItemId3).HasColumnName("RewardChoiceItemID3");
            _ = entity.Property(e => e.RewardChoiceItemId4).HasColumnName("RewardChoiceItemID4");
            _ = entity.Property(e => e.RewardChoiceItemId5).HasColumnName("RewardChoiceItemID5");
            _ = entity.Property(e => e.RewardChoiceItemId6).HasColumnName("RewardChoiceItemID6");
            _ = entity.Property(e => e.RewardFactionId1)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID1");
            _ = entity.Property(e => e.RewardFactionId2)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID2");
            _ = entity.Property(e => e.RewardFactionId3)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID3");
            _ = entity.Property(e => e.RewardFactionId4)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID4");
            _ = entity.Property(e => e.RewardFactionId5)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID5");
            _ = entity.Property(e => e.RewardXpdifficulty).HasColumnName("RewardXPDifficulty");
        });

        _ = modelBuilder.Entity<QuestTemplateAddon>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("quest_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            _ = entity.Property(e => e.NextQuestId).HasColumnName("NextQuestID");
            _ = entity.Property(e => e.PrevQuestId).HasColumnName("PrevQuestID");
            _ = entity.Property(e => e.RequiredSkillId).HasColumnName("RequiredSkillID");
            _ = entity.Property(e => e.RewardMailTemplateId).HasColumnName("RewardMailTemplateID");
            _ = entity.Property(e => e.SourceSpellId).HasColumnName("SourceSpellID");
        });

        _ = modelBuilder.Entity<QuestTemplateLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("quest_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("ID");
            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.CompletedText).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Details).HasColumnType("mediumtext");
            _ = entity.Property(e => e.EndText).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText1).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText2).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText3).HasColumnType("mediumtext");
            _ = entity.Property(e => e.ObjectiveText4).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Objectives).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Title).HasColumnType("mediumtext");
        });

        _ = modelBuilder.Entity<ReferenceLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("reference_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<ReputationRewardRate>(entity =>
        {
            _ = entity.HasKey(e => e.Faction).HasName("PRIMARY");

            _ = entity
                .ToTable("reputation_reward_rate")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Faction)
                .ValueGeneratedNever()
                .HasColumnName("faction");
            _ = entity.Property(e => e.CreatureRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("creature_rate");
            _ = entity.Property(e => e.QuestDailyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_daily_rate");
            _ = entity.Property(e => e.QuestMonthlyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_monthly_rate");
            _ = entity.Property(e => e.QuestRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_rate");
            _ = entity.Property(e => e.QuestRepeatableRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_repeatable_rate");
            _ = entity.Property(e => e.QuestWeeklyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_weekly_rate");
            _ = entity.Property(e => e.SpellRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spell_rate");
        });

        _ = modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.Faction).HasName("PRIMARY");

            _ = entity
                .ToTable("reputation_spillover_template", tb => tb.HasComment("Reputation spillover reputation gain"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Faction)
                .ValueGeneratedNever()
                .HasComment("faction entry")
                .HasColumnName("faction");
            _ = entity.Property(e => e.Faction1)
                .HasComment("faction to give spillover for")
                .HasColumnName("faction1");
            _ = entity.Property(e => e.Faction2).HasColumnName("faction2");
            _ = entity.Property(e => e.Faction3).HasColumnName("faction3");
            _ = entity.Property(e => e.Faction4).HasColumnName("faction4");
            _ = entity.Property(e => e.Rank1)
                .HasComment("max rank,above this will not give any spillover")
                .HasColumnName("rank_1");
            _ = entity.Property(e => e.Rank2).HasColumnName("rank_2");
            _ = entity.Property(e => e.Rank3).HasColumnName("rank_3");
            _ = entity.Property(e => e.Rank4).HasColumnName("rank_4");
            _ = entity.Property(e => e.Rate1)
                .HasComment("the given rep points * rate")
                .HasColumnName("rate_1");
            _ = entity.Property(e => e.Rate2).HasColumnName("rate_2");
            _ = entity.Property(e => e.Rate3).HasColumnName("rate_3");
            _ = entity.Property(e => e.Rate4).HasColumnName("rate_4");
        });

        _ = modelBuilder.Entity<ScriptSplineChainMetum>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("script_spline_chain_meta")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.ChainId).HasColumnName("chainId");
            _ = entity.Property(e => e.SplineId).HasColumnName("splineId");
            _ = entity.Property(e => e.ExpectedDuration).HasColumnName("expectedDuration");
            _ = entity.Property(e => e.MsUntilNext).HasColumnName("msUntilNext");
            _ = entity.Property(e => e.Velocity)
                .HasDefaultValueSql("'0'")
                .HasColumnType("float unsigned")
                .HasColumnName("velocity");
        });

        _ = modelBuilder.Entity<ScriptSplineChainWaypoint>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId, e.WpId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            _ = entity
                .ToTable("script_spline_chain_waypoints")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.ChainId).HasColumnName("chainId");
            _ = entity.Property(e => e.SplineId).HasColumnName("splineId");
            _ = entity.Property(e => e.WpId).HasColumnName("wpId");
            _ = entity.Property(e => e.X).HasColumnName("x");
            _ = entity.Property(e => e.Y).HasColumnName("y");
            _ = entity.Property(e => e.Z).HasColumnName("z");
        });

        _ = modelBuilder.Entity<ScriptWaypoint>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Pointid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("script_waypoint", tb => tb.HasComment("Script Creature waypoints"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .HasComment("creature_template entry")
                .HasColumnName("entry");
            _ = entity.Property(e => e.Pointid).HasColumnName("pointid");
            _ = entity.Property(e => e.LocationX).HasColumnName("location_x");
            _ = entity.Property(e => e.LocationY).HasColumnName("location_y");
            _ = entity.Property(e => e.LocationZ).HasColumnName("location_z");
            _ = entity.Property(e => e.PointComment)
                .HasColumnType("mediumtext")
                .HasColumnName("point_comment");
            _ = entity.Property(e => e.Waittime)
                .HasComment("waittime in millisecs")
                .HasColumnName("waittime");
        });

        _ = modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("skill_discovery_template", tb => tb.HasComment("Skill Discovery System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpellId)
                .HasComment("SpellId of the discoverable spell")
                .HasColumnName("spellId");
            _ = entity.Property(e => e.ReqSpell)
                .HasComment("spell requirement")
                .HasColumnName("reqSpell");
            _ = entity.Property(e => e.Chance)
                .HasComment("chance to discover")
                .HasColumnName("chance");
            _ = entity.Property(e => e.ReqSkillValue)
                .HasComment("skill points requirement")
                .HasColumnName("reqSkillValue");
        });

        _ = modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            _ = entity
                .ToTable("skill_extra_item_template", tb => tb.HasComment("Skill Specialization System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpellId)
                .ValueGeneratedNever()
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            _ = entity.Property(e => e.AdditionalCreateChance)
                .HasComment("chance to create add")
                .HasColumnName("additionalCreateChance");
            _ = entity.Property(e => e.AdditionalMaxNum)
                .HasComment("max num of adds")
                .HasColumnName("additionalMaxNum");
            _ = entity.Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        _ = modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("skill_fishing_base_level", tb => tb.HasComment("Fishing system"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Area identifier")
                .HasColumnName("entry");
            _ = entity.Property(e => e.Skill)
                .HasComment("Base skill level requirement")
                .HasColumnName("skill");
        });

        _ = modelBuilder.Entity<SkillPerfectItemTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            _ = entity
                .ToTable("skill_perfect_item_template", tb => tb.HasComment("Crafting Perfection System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpellId)
                .ValueGeneratedNever()
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            _ = entity.Property(e => e.PerfectCreateChance)
                .HasComment("chance to create the perfect item instead")
                .HasColumnName("perfectCreateChance");
            _ = entity.Property(e => e.PerfectItemType)
                .HasComment("perfect item type to create instead")
                .HasColumnName("perfectItemType");
            _ = entity.Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        _ = modelBuilder.Entity<SkinningLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("skinning_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<SmartScript>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entryorguid, e.SourceType, e.Id, e.Link })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            _ = entity
                .ToTable("smart_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entryorguid).HasColumnName("entryorguid");
            _ = entity.Property(e => e.SourceType).HasColumnName("source_type");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Link).HasColumnName("link");
            _ = entity.Property(e => e.ActionParam1).HasColumnName("action_param1");
            _ = entity.Property(e => e.ActionParam2).HasColumnName("action_param2");
            _ = entity.Property(e => e.ActionParam3).HasColumnName("action_param3");
            _ = entity.Property(e => e.ActionParam4).HasColumnName("action_param4");
            _ = entity.Property(e => e.ActionParam5).HasColumnName("action_param5");
            _ = entity.Property(e => e.ActionParam6).HasColumnName("action_param6");
            _ = entity.Property(e => e.ActionType).HasColumnName("action_type");
            _ = entity.Property(e => e.Comment)
                .HasComment("Event Comment")
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            _ = entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            _ = entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            _ = entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            _ = entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            _ = entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            _ = entity.Property(e => e.EventParam5).HasColumnName("event_param5");
            _ = entity.Property(e => e.EventPhaseMask).HasColumnName("event_phase_mask");
            _ = entity.Property(e => e.EventType).HasColumnName("event_type");
            _ = entity.Property(e => e.TargetO).HasColumnName("target_o");
            _ = entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            _ = entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            _ = entity.Property(e => e.TargetParam3).HasColumnName("target_param3");
            _ = entity.Property(e => e.TargetParam4).HasColumnName("target_param4");
            _ = entity.Property(e => e.TargetType).HasColumnName("target_type");
            _ = entity.Property(e => e.TargetX).HasColumnName("target_x");
            _ = entity.Property(e => e.TargetY).HasColumnName("target_y");
            _ = entity.Property(e => e.TargetZ).HasColumnName("target_z");
        });

        _ = modelBuilder.Entity<SpawnGroup>(entity =>
        {
            _ = entity.HasKey(e => new { e.GroupId, e.SpawnType, e.SpawnId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("spawn_group")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.GroupId).HasColumnName("groupId");
            _ = entity.Property(e => e.SpawnType).HasColumnName("spawnType");
            _ = entity.Property(e => e.SpawnId).HasColumnName("spawnId");
        });

        _ = modelBuilder.Entity<SpawnGroupTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            _ = entity
                .ToTable("spawn_group_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("groupId");
            _ = entity.Property(e => e.GroupFlags).HasColumnName("groupFlags");
            _ = entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .HasColumnName("groupName");
        });

        _ = modelBuilder.Entity<SpellArea>(entity =>
        {
            _ = entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.AuraSpell, e.Racemask, e.Gender })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            _ = entity
                .ToTable("spell_area")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Spell).HasColumnName("spell");
            _ = entity.Property(e => e.Area).HasColumnName("area");
            _ = entity.Property(e => e.QuestStart).HasColumnName("quest_start");
            _ = entity.Property(e => e.AuraSpell).HasColumnName("aura_spell");
            _ = entity.Property(e => e.Racemask).HasColumnName("racemask");
            _ = entity.Property(e => e.Gender)
                .HasDefaultValueSql("'2'")
                .HasColumnName("gender");
            _ = entity.Property(e => e.Autocast).HasColumnName("autocast");
            _ = entity.Property(e => e.QuestEnd).HasColumnName("quest_end");
            _ = entity.Property(e => e.QuestEndStatus)
                .HasDefaultValueSql("'11'")
                .HasColumnName("quest_end_status");
            _ = entity.Property(e => e.QuestStartStatus)
                .HasDefaultValueSql("'64'")
                .HasColumnName("quest_start_status");
        });

        _ = modelBuilder.Entity<SpellBonusDatum>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_bonus_data")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.ApBonus).HasColumnName("ap_bonus");
            _ = entity.Property(e => e.ApDotBonus).HasColumnName("ap_dot_bonus");
            _ = entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            _ = entity.Property(e => e.DirectBonus).HasColumnName("direct_bonus");
            _ = entity.Property(e => e.DotBonus).HasColumnName("dot_bonus");
        });

        _ = modelBuilder.Entity<SpellCustomAttr>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_custom_attr", tb => tb.HasComment("SpellInfo custom attributes"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("spell id")
                .HasColumnName("entry");
            _ = entity.Property(e => e.Attributes)
                .HasComment("SpellCustomAttributes")
                .HasColumnName("attributes");
        });

        _ = modelBuilder.Entity<SpellDbc>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_dbc", tb => tb.HasComment("Custom spell.dbc entries"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).ValueGeneratedNever();
            _ = entity.Property(e => e.CastingTimeIndex).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.EquippedItemClass).HasDefaultValueSql("'-1'");
            _ = entity.Property(e => e.RangeIndex).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.SpellName).HasMaxLength(100);
        });

        _ = modelBuilder.Entity<SpellEnchantProcDatum>(entity =>
        {
            _ = entity.HasKey(e => e.EnchantId).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_enchant_proc_data", tb => tb.HasComment("Spell enchant proc data"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.EnchantId)
                .ValueGeneratedNever()
                .HasColumnName("EnchantID");
        });

        _ = modelBuilder.Entity<SpellGroup>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_group", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        _ = modelBuilder.Entity<SpellGroupStackRule>(entity =>
        {
            _ = entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_group_stack_rules")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("group_id");
            _ = entity.Property(e => e.StackRule).HasColumnName("stack_rule");
        });

        _ = modelBuilder.Entity<SpellLearnSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_learn_spell", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.SpellId).HasColumnName("SpellID");
            _ = entity.Property(e => e.Active).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<SpellLinkedSpell>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("spell_linked_spell", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.SpellTrigger, e.SpellEffect, e.Type }, "trigger_effect_type").IsUnique();

            _ = entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            _ = entity.Property(e => e.SpellEffect).HasColumnName("spell_effect");
            _ = entity.Property(e => e.SpellTrigger).HasColumnName("spell_trigger");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<SpellLootTemplate>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
            _ = entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            _ = entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        _ = modelBuilder.Entity<SpellPetAura>(entity =>
        {
            _ = entity.HasKey(e => new { e.Spell, e.EffectId, e.Pet })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("spell_pet_auras")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Spell)
                .HasComment("dummy spell id")
                .HasColumnName("spell");
            _ = entity.Property(e => e.EffectId).HasColumnName("effectId");
            _ = entity.Property(e => e.Pet)
                .HasComment("pet id; 0 = all")
                .HasColumnName("pet");
            _ = entity.Property(e => e.Aura)
                .HasComment("pet aura id")
                .HasColumnName("aura");
        });

        _ = modelBuilder.Entity<SpellProc>(entity =>
        {
            _ = entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_proc")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpellId).ValueGeneratedNever();
        });

        _ = modelBuilder.Entity<SpellRank>(entity =>
        {
            _ = entity.HasKey(e => new { e.FirstSpellId, e.Rank })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_ranks", tb => tb.HasComment("Spell Rank Data"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.SpellId, "spell_id").IsUnique();

            _ = entity.Property(e => e.FirstSpellId).HasColumnName("first_spell_id");
            _ = entity.Property(e => e.Rank).HasColumnName("rank");
            _ = entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        _ = modelBuilder.Entity<SpellRequired>(entity =>
        {
            _ = entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_required", tb => tb.HasComment("Spell Additinal Data"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SpellId).HasColumnName("spell_id");
            _ = entity.Property(e => e.ReqSpell).HasColumnName("req_spell");
        });

        _ = modelBuilder.Entity<SpellScript>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("spell_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Command).HasColumnName("command");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Dataint).HasColumnName("dataint");
            _ = entity.Property(e => e.Datalong).HasColumnName("datalong");
            _ = entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            _ = entity.Property(e => e.Delay).HasColumnName("delay");
            _ = entity.Property(e => e.EffIndex).HasColumnName("effIndex");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.O).HasColumnName("o");
            _ = entity.Property(e => e.X).HasColumnName("x");
            _ = entity.Property(e => e.Y).HasColumnName("y");
            _ = entity.Property(e => e.Z).HasColumnName("z");
        });

        _ = modelBuilder.Entity<SpellScriptName>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("spell_script_names")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => new { e.SpellId, e.ScriptName }, "spell_id").IsUnique();

            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength();
            _ = entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        _ = modelBuilder.Entity<SpellTargetPosition>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.EffectIndex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("spell_target_position", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("ID");
            _ = entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        _ = modelBuilder.Entity<SpellThreat>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("spell_threat")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.ApPctMod)
                .HasComment("additional threat bonus from attack power")
                .HasColumnName("apPctMod");
            _ = entity.Property(e => e.FlatMod).HasColumnName("flatMod");
            _ = entity.Property(e => e.PctMod)
                .HasDefaultValueSql("'1'")
                .HasComment("threat multiplier for damage/healing")
                .HasColumnName("pctMod");
        });

        _ = modelBuilder.Entity<SpelldifficultyDbc>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("spelldifficulty_dbc")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Spellid0).HasColumnName("spellid0");
            _ = entity.Property(e => e.Spellid1).HasColumnName("spellid1");
            _ = entity.Property(e => e.Spellid2).HasColumnName("spellid2");
            _ = entity.Property(e => e.Spellid3).HasColumnName("spellid3");
        });

        _ = modelBuilder.Entity<Trainer>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("trainer")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).ValueGeneratedNever();
            _ = entity.Property(e => e.Greeting).HasColumnType("mediumtext");
            _ = entity.Property(e => e.Type).HasDefaultValueSql("'2'");
        });

        _ = modelBuilder.Entity<TrainerLocale>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("trainer_locale")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            _ = entity.Property(e => e.GreetingLang)
                .HasColumnType("mediumtext")
                .HasColumnName("Greeting_lang");
        });

        _ = modelBuilder.Entity<TrainerSpell>(entity =>
        {
            _ = entity.HasKey(e => new { e.TrainerId, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("trainer_spell")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<Transport>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("transports", tb => tb.HasComment("Transports"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Entry, "idx_entry").IsUnique();

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        _ = modelBuilder.Entity<TrinityString>(entity =>
        {
            _ = entity.HasKey(e => e.Entry).HasName("PRIMARY");

            _ = entity
                .ToTable("trinity_string")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            _ = entity.Property(e => e.Content[0])
                .HasColumnType("mediumtext")
                .HasColumnName("content_default");
            _ = entity.Property(e => e.Content[1])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc1");
            _ = entity.Property(e => e.Content[2])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc2");
            _ = entity.Property(e => e.Content[3])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc3");
            _ = entity.Property(e => e.Content[4])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc4");
            _ = entity.Property(e => e.Content[5])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc5");
            _ = entity.Property(e => e.Content[6])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc6");
            _ = entity.Property(e => e.Content[7])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc7");
            _ = entity.Property(e => e.Content[8])
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc8");
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

        _ = modelBuilder.Entity<VehicleAccessory>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.SeatId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("vehicle_accessory")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid).HasColumnName("guid");
            _ = entity.Property(e => e.SeatId).HasColumnName("seat_id");
            _ = entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            _ = entity.Property(e => e.Description)
                .HasColumnType("mediumtext")
                .HasColumnName("description");
            _ = entity.Property(e => e.Minion).HasColumnName("minion");
            _ = entity.Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            _ = entity.Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        _ = modelBuilder.Entity<VehicleSeatAddon>(entity =>
        {
            _ = entity.HasKey(e => e.SeatEntry).HasName("PRIMARY");

            _ = entity
                .ToTable("vehicle_seat_addon")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.SeatEntry)
                .ValueGeneratedNever()
                .HasComment("VehicleSeatEntry.dbc identifier");
            _ = entity.Property(e => e.ExitParamO).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.ExitParamValue).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.ExitParamX).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.ExitParamY).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.ExitParamZ).HasDefaultValueSql("'0'");
            _ = entity.Property(e => e.SeatOrientation)
                .HasDefaultValueSql("'0'")
                .HasComment("Seat Orientation override value");
        });

        _ = modelBuilder.Entity<VehicleTemplate>(entity =>
        {
            _ = entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            _ = entity
                .ToTable("vehicle_template")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CreatureId)
                .ValueGeneratedNever()
                .HasColumnName("creatureId");
            _ = entity.Property(e => e.DespawnDelayMs).HasColumnName("despawnDelayMs");
        });

        _ = modelBuilder.Entity<VehicleTemplateAccessory>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.SeatId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("vehicle_template_accessory")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.SeatId).HasColumnName("seat_id");
            _ = entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            _ = entity.Property(e => e.Description)
                .HasColumnType("mediumtext")
                .HasColumnName("description");
            _ = entity.Property(e => e.Minion).HasColumnName("minion");
            _ = entity.Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            _ = entity.Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        _ = modelBuilder.Entity<Version>(entity =>
        {
            _ = entity.HasKey(e => e.CoreVersion).HasName("PRIMARY");

            _ = entity
                .ToTable("version", tb => tb.HasComment("Version Notes"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.CoreVersion)
                .HasDefaultValueSql("''")
                .HasComment("Core revision dumped at startup.")
                .HasColumnName("core_version");
            _ = entity.Property(e => e.CacheId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("cache_id");
            _ = entity.Property(e => e.CoreRevision)
                .HasMaxLength(120)
                .HasColumnName("core_revision");
            _ = entity.Property(e => e.DbVersion)
                .HasMaxLength(120)
                .HasComment("Version of world DB.")
                .HasColumnName("db_version");
        });

        _ = modelBuilder.Entity<VwConditionsWithLabel>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToView("vw_conditions_with_labels");

            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.ConditionTypeOrReference)
                .HasMaxLength(34)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            _ = entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.SourceTypeOrReferenceId)
                .HasMaxLength(49)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        _ = modelBuilder.Entity<VwDisablesWithLabel>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToView("vw_disables_with_labels");

            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Flags).HasColumnName("flags");
            _ = entity.Property(e => e.Params0)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_0")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.Params1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_1")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.SourceType)
                .HasMaxLength(33)
                .HasDefaultValueSql("''")
                .HasColumnName("sourceType")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        _ = modelBuilder.Entity<VwSmartScriptsWithLabel>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToView("vw_smart_scripts_with_labels");

            _ = entity.Property(e => e.ActionParam1).HasColumnName("action_param1");
            _ = entity.Property(e => e.ActionParam2).HasColumnName("action_param2");
            _ = entity.Property(e => e.ActionParam3).HasColumnName("action_param3");
            _ = entity.Property(e => e.ActionParam4).HasColumnName("action_param4");
            _ = entity.Property(e => e.ActionParam5).HasColumnName("action_param5");
            _ = entity.Property(e => e.ActionParam6).HasColumnName("action_param6");
            _ = entity.Property(e => e.ActionType)
                .HasMaxLength(47)
                .HasDefaultValueSql("''")
                .HasColumnName("action_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            _ = entity.Property(e => e.Comment)
                .HasComment("Event Comment")
                .HasColumnType("mediumtext")
                .HasColumnName("comment")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.Entryorguid).HasColumnName("entryorguid");
            _ = entity.Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            _ = entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            _ = entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            _ = entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            _ = entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            _ = entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            _ = entity.Property(e => e.EventParam5).HasColumnName("event_param5");
            _ = entity.Property(e => e.EventPhaseMask).HasColumnName("event_phase_mask");
            _ = entity.Property(e => e.EventType)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .HasColumnName("event_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Link).HasColumnName("link");
            _ = entity.Property(e => e.SourceType).HasColumnName("source_type");
            _ = entity.Property(e => e.TargetO).HasColumnName("target_o");
            _ = entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            _ = entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            _ = entity.Property(e => e.TargetParam3).HasColumnName("target_param3");
            _ = entity.Property(e => e.TargetParam4).HasColumnName("target_param4");
            _ = entity.Property(e => e.TargetType)
                .HasMaxLength(41)
                .HasDefaultValueSql("''")
                .HasColumnName("target_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            _ = entity.Property(e => e.TargetX).HasColumnName("target_x");
            _ = entity.Property(e => e.TargetY).HasColumnName("target_y");
            _ = entity.Property(e => e.TargetZ).HasColumnName("target_z");
        });

        _ = modelBuilder.Entity<WardenCheck>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("warden_checks")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Address).HasColumnName("address");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .HasColumnName("comment");
            _ = entity.Property(e => e.Data)
                .HasMaxLength(24)
                .IsFixedLength()
                .HasColumnName("data");
            _ = entity.Property(e => e.Length).HasColumnName("length");
            _ = entity.Property(e => e.Result)
                .HasMaxLength(24)
                .HasColumnName("result");
            _ = entity.Property(e => e.Str)
                .HasMaxLength(170)
                .HasColumnName("str");
            _ = entity.Property(e => e.Type).HasColumnName("type");
        });

        _ = modelBuilder.Entity<Waypoint>(entity =>
        {
            _ = entity.HasKey(e => new { e.Entry, e.Pointid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("waypoints", tb => tb.HasComment("Creature waypoints"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Entry).HasColumnName("entry");
            _ = entity.Property(e => e.Pointid).HasColumnName("pointid");
            _ = entity.Property(e => e.Delay).HasColumnName("delay");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PointComment)
                .HasColumnType("mediumtext")
                .HasColumnName("point_comment");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        _ = modelBuilder.Entity<WaypointDatum>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Point })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("waypoint_data")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Creature GUID")
                .HasColumnName("id");
            _ = entity.Property(e => e.Point).HasColumnName("point");
            _ = entity.Property(e => e.Action).HasColumnName("action");
            _ = entity.Property(e => e.ActionChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("action_chance");
            _ = entity.Property(e => e.Delay).HasColumnName("delay");
            _ = entity.Property(e => e.MoveType).HasColumnName("move_type");
            _ = entity.Property(e => e.Orientation).HasColumnName("orientation");
            _ = entity.Property(e => e.PositionX).HasColumnName("position_x");
            _ = entity.Property(e => e.PositionY).HasColumnName("position_y");
            _ = entity.Property(e => e.PositionZ).HasColumnName("position_z");
            _ = entity.Property(e => e.Wpguid).HasColumnName("wpguid");
        });

        _ = modelBuilder.Entity<WaypointScript>(entity =>
        {
            _ = entity.HasKey(e => e.Guid).HasName("PRIMARY");

            _ = entity
                .ToTable("waypoint_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            _ = entity.Property(e => e.Command).HasColumnName("command");
            _ = entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            _ = entity.Property(e => e.Dataint).HasColumnName("dataint");
            _ = entity.Property(e => e.Datalong).HasColumnName("datalong");
            _ = entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            _ = entity.Property(e => e.Delay).HasColumnName("delay");
            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.O).HasColumnName("o");
            _ = entity.Property(e => e.X).HasColumnName("x");
            _ = entity.Property(e => e.Y).HasColumnName("y");
            _ = entity.Property(e => e.Z).HasColumnName("z");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}