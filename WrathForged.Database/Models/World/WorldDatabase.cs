using System;
using System.Collections.Generic;
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
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AccessRequirement>(entity =>
        {
            entity.HasKey(e => new { e.MapId, e.Difficulty })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("access_requirement", tb => tb.HasComment("Access Requirements"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MapId).HasColumnName("mapId");
            entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.CompletedAchievement).HasColumnName("completed_achievement");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Item2).HasColumnName("item2");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.LevelMax).HasColumnName("level_max");
            entity.Property(e => e.LevelMin).HasColumnName("level_min");
            entity.Property(e => e.QuestDoneA).HasColumnName("quest_done_A");
            entity.Property(e => e.QuestDoneH).HasColumnName("quest_done_H");
            entity.Property(e => e.QuestFailedText)
                .HasColumnType("mediumtext")
                .HasColumnName("quest_failed_text");
        });

        modelBuilder.Entity<AchievementCriteriaDatum>(entity =>
        {
            entity.HasKey(e => new { e.CriteriaId, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("achievement_criteria_data", tb => tb.HasComment("Achievment system"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CriteriaId).HasColumnName("criteria_id");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Value1).HasColumnName("value1");
            entity.Property(e => e.Value2).HasColumnName("value2");
        });

        modelBuilder.Entity<AchievementDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement_dbc")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.MapId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("mapID");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.RefAchievement).HasColumnName("refAchievement");
            entity.Property(e => e.RequiredFaction)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("requiredFaction");
        });

        modelBuilder.Entity<AchievementReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement_reward", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Body).HasColumnType("mediumtext");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.MailTemplateId).HasColumnName("MailTemplateID");
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<AchievementRewardLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("achievement_reward_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Body).HasColumnType("mediumtext");
            entity.Property(e => e.Subject).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areatrigger_involvedrelation", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<AreatriggerScript>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("areatrigger_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength();
        });

        modelBuilder.Entity<AreatriggerTavern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areatrigger_tavern", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
        });

        modelBuilder.Entity<AreatriggerTeleport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areatrigger_teleport", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "name").HasAnnotation("MySql:FullTextIndex", true);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
            entity.Property(e => e.TargetMap).HasColumnName("target_map");
            entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");
            entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");
            entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");
            entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
        });

        modelBuilder.Entity<BattlefieldTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("battlefield_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<BattlegroundTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("battleground_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(32)
                .IsFixedLength();
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Weight).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<BattlemasterEntry>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("battlemaster_entry")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Entry of a creature")
                .HasColumnName("entry");
            entity.Property(e => e.BgTemplate)
                .HasComment("Battleground template id")
                .HasColumnName("bg_template");
        });

        modelBuilder.Entity<BroadcastText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("broadcast_text")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmoteId1).HasColumnName("EmoteID1");
            entity.Property(e => e.EmoteId2).HasColumnName("EmoteID2");
            entity.Property(e => e.EmoteId3).HasColumnName("EmoteID3");
            entity.Property(e => e.EmotesId).HasColumnName("EmotesID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.SoundEntriesId).HasColumnName("SoundEntriesID");
        });

        modelBuilder.Entity<BroadcastTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("broadcast_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Text).HasColumnType("mediumtext");
            entity.Property(e => e.Text1).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<Command>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity
                .ToTable("command", tb => tb.HasComment("Chat System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Help).HasColumnName("help");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.HasKey(e => new { e.SourceTypeOrReferenceId, e.SourceGroup, e.SourceEntry, e.SourceId, e.ElseGroup, e.ConditionTypeOrReference, e.ConditionTarget, e.ConditionValue1, e.ConditionValue2, e.ConditionValue3 })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity
                .ToTable("conditions", tb => tb.HasComment("Condition System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<Creature>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("creature", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Id, "idx_id");

            entity.HasIndex(e => e.Map, "idx_map");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.AreaId)
                .HasComment("Area Identifier")
                .HasColumnName("areaId");
            entity.Property(e => e.Curhealth)
                .HasDefaultValueSql("'1'")
                .HasColumnName("curhealth");
            entity.Property(e => e.Curmana).HasColumnName("curmana");
            entity.Property(e => e.Currentwaypoint).HasColumnName("currentwaypoint");
            entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            entity.Property(e => e.Id)
                .HasComment("Creature Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PhaseMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("phaseMask");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SpawnMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spawnMask");
            entity.Property(e => e.Spawntimesecs)
                .HasDefaultValueSql("'120'")
                .HasColumnName("spawntimesecs");
            entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            entity.Property(e => e.VerifiedBuild).HasDefaultValueSql("'0'");
            entity.Property(e => e.WanderDistance).HasColumnName("wander_distance");
            entity.Property(e => e.ZoneId)
                .HasComment("Zone Identifier")
                .HasColumnName("zoneId");
        });

        modelBuilder.Entity<CreatureAddon>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("creature_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            entity.Property(e => e.Auras)
                .HasColumnType("mediumtext")
                .HasColumnName("auras");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Mount).HasColumnName("mount");
            entity.Property(e => e.MountCreatureId).HasColumnName("MountCreatureID");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.PvPflags).HasColumnName("PvPFlags");
            entity.Property(e => e.SheathState).HasDefaultValueSql("'1'");
            entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        modelBuilder.Entity<CreatureClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Level, e.Class })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_classlevelstats")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Attackpower).HasColumnName("attackpower");
            entity.Property(e => e.Basearmor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basearmor");
            entity.Property(e => e.Basehp0)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp0");
            entity.Property(e => e.Basehp1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp1");
            entity.Property(e => e.Basehp2)
                .HasDefaultValueSql("'1'")
                .HasColumnName("basehp2");
            entity.Property(e => e.Basemana).HasColumnName("basemana");
            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.DamageBase).HasColumnName("damage_base");
            entity.Property(e => e.DamageExp1).HasColumnName("damage_exp1");
            entity.Property(e => e.DamageExp2).HasColumnName("damage_exp2");
            entity.Property(e => e.Rangedattackpower).HasColumnName("rangedattackpower");
        });

        modelBuilder.Entity<CreatureDefaultTrainer>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity
                .ToTable("creature_default_trainer")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CreatureEquipTemplate>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_equip_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ID");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID1");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID3");
        });

        modelBuilder.Entity<CreatureFormation>(entity =>
        {
            entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            entity
                .ToTable("creature_formations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MemberGuid)
                .ValueGeneratedNever()
                .HasColumnName("memberGUID");
            entity.Property(e => e.Angle)
                .HasColumnType("float unsigned")
                .HasColumnName("angle");
            entity.Property(e => e.Dist)
                .HasColumnType("float unsigned")
                .HasColumnName("dist");
            entity.Property(e => e.GroupAi).HasColumnName("groupAI");
            entity.Property(e => e.LeaderGuid).HasColumnName("leaderGUID");
            entity.Property(e => e.Point1).HasColumnName("point_1");
            entity.Property(e => e.Point2).HasColumnName("point_2");
        });

        modelBuilder.Entity<CreatureLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<CreatureModelInfo>(entity =>
        {
            entity.HasKey(e => e.DisplayId).HasName("PRIMARY");

            entity
                .ToTable("creature_model_info", tb => tb.HasComment("Creature System (Model related info)"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.DisplayId)
                .ValueGeneratedNever()
                .HasColumnName("DisplayID");
            entity.Property(e => e.DisplayIdOtherGender).HasColumnName("DisplayID_Other_Gender");
            entity.Property(e => e.Gender).HasDefaultValueSql("'2'");
        });

        modelBuilder.Entity<CreatureMovementInfo>(entity =>
        {
            entity.HasKey(e => e.MovementId).HasName("PRIMARY");

            entity
                .ToTable("creature_movement_info")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MovementId)
                .ValueGeneratedNever()
                .HasComment("creature_template.movementId value")
                .HasColumnName("MovementID");
            entity.Property(e => e.RunSpeed).HasColumnType("float unsigned");
            entity.Property(e => e.WalkSpeed).HasColumnType("float unsigned");
        });

        modelBuilder.Entity<CreatureMovementOverride>(entity =>
        {
            entity.HasKey(e => e.SpawnId).HasName("PRIMARY");

            entity
                .ToTable("creature_movement_override")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpawnId).ValueGeneratedNever();
            entity.Property(e => e.InteractionPauseTimer).HasComment("Time (in milliseconds) during which creature will not move after interaction with player");
        });

        modelBuilder.Entity<CreatureOnkillReputation>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity
                .ToTable("creature_onkill_reputation", tb => tb.HasComment("Creature OnKill Reputation gain"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId)
                .ValueGeneratedNever()
                .HasComment("Creature Identifier")
                .HasColumnName("creature_id");
        });

        modelBuilder.Entity<CreatureQuestender>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_questender", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<CreatureQuestitem>(entity =>
        {
            entity.HasKey(e => new { e.CreatureEntry, e.Idx })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_questitem")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<CreatureQueststarter>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_queststarter", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<CreatureSummonGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creature_summon_groups")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.SummonTime).HasColumnName("summonTime");
            entity.Property(e => e.SummonType).HasColumnName("summonType");
            entity.Property(e => e.SummonerId).HasColumnName("summonerId");
            entity.Property(e => e.SummonerType).HasColumnName("summonerType");
        });

        modelBuilder.Entity<CreatureTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("creature_template", tb => tb.HasComment("Creature System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "idx_name");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            entity.Property(e => e.ArmorModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.BaseVariance).HasDefaultValueSql("'1'");
            entity.Property(e => e.DamageModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.DifficultyEntry1).HasColumnName("difficulty_entry_1");
            entity.Property(e => e.DifficultyEntry2).HasColumnName("difficulty_entry_2");
            entity.Property(e => e.DifficultyEntry3).HasColumnName("difficulty_entry_3");
            entity.Property(e => e.Dmgschool).HasColumnName("dmgschool");
            entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            entity.Property(e => e.Exp).HasColumnName("exp");
            entity.Property(e => e.ExperienceModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Family).HasColumnName("family");
            entity.Property(e => e.FlagsExtra).HasColumnName("flags_extra");
            entity.Property(e => e.GossipMenuId).HasColumnName("gossip_menu_id");
            entity.Property(e => e.HealthModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.HoverHeight).HasDefaultValueSql("'1'");
            entity.Property(e => e.IconName)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Lootid).HasColumnName("lootid");
            entity.Property(e => e.ManaModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            entity.Property(e => e.Maxlevel)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxlevel");
            entity.Property(e => e.MechanicImmuneMask).HasColumnName("mechanic_immune_mask");
            entity.Property(e => e.Mingold).HasColumnName("mingold");
            entity.Property(e => e.Minlevel)
                .HasDefaultValueSql("'1'")
                .HasColumnName("minlevel");
            entity.Property(e => e.Modelid1).HasColumnName("modelid1");
            entity.Property(e => e.Modelid2).HasColumnName("modelid2");
            entity.Property(e => e.Modelid3).HasColumnName("modelid3");
            entity.Property(e => e.Modelid4).HasColumnName("modelid4");
            entity.Property(e => e.MovementId).HasColumnName("movementId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            entity.Property(e => e.Pickpocketloot).HasColumnName("pickpocketloot");
            entity.Property(e => e.RangeVariance).HasDefaultValueSql("'1'");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.RegenHealth).HasDefaultValueSql("'1'");
            entity.Property(e => e.Scale)
                .HasDefaultValueSql("'1'")
                .HasColumnName("scale");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Skinloot).HasColumnName("skinloot");
            entity.Property(e => e.SpeedRun)
                .HasDefaultValueSql("'1.14286'")
                .HasComment("Result of 8.0/7.0, most common value")
                .HasColumnName("speed_run");
            entity.Property(e => e.SpeedWalk)
                .HasDefaultValueSql("'1'")
                .HasComment("Result of 2.5/2.5, most common value")
                .HasColumnName("speed_walk");
            entity.Property(e => e.SpellSchoolImmuneMask).HasColumnName("spell_school_immune_mask");
            entity.Property(e => e.Subname)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("subname");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.TypeFlags).HasColumnName("type_flags");
            entity.Property(e => e.UnitClass).HasColumnName("unit_class");
            entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            entity.Property(e => e.UnitFlags2).HasColumnName("unit_flags2");
        });

        modelBuilder.Entity<CreatureTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("creature_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.Auras)
                .HasColumnType("mediumtext")
                .HasColumnName("auras");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Mount).HasColumnName("mount");
            entity.Property(e => e.MountCreatureId).HasColumnName("MountCreatureID");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.PvPflags).HasColumnName("PvPFlags");
            entity.Property(e => e.SheathState).HasDefaultValueSql("'1'");
            entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        modelBuilder.Entity<CreatureTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
            entity.Property(e => e.Title).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<CreatureTemplateMovement>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity
                .ToTable("creature_template_movement")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).ValueGeneratedNever();
            entity.Property(e => e.InteractionPauseTimer).HasComment("Time (in milliseconds) during which creature will not move after interaction with player");
        });

        modelBuilder.Entity<CreatureTemplateResistance>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.School })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_template_resistance")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        modelBuilder.Entity<CreatureTemplateSpell>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.Index })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("creature_template_spell")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        modelBuilder.Entity<CreatureText>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("creature_text")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Probability).HasColumnType("float unsigned");
        });

        modelBuilder.Entity<CreatureTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("creature_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Text).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<Disable>(entity =>
        {
            entity.HasKey(e => new { e.SourceType, e.Entry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("disables")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SourceType).HasColumnName("sourceType");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Params0)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_0");
            entity.Property(e => e.Params1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_1");
        });

        modelBuilder.Entity<DisenchantLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("disenchant_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<EventScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<ExplorationBasexp>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity
                .ToTable("exploration_basexp", tb => tb.HasComment("Exploration System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basexp).HasColumnName("basexp");
        });

        modelBuilder.Entity<FishingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("fishing_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<GameEvent>(entity =>
        {
            entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            entity
                .ToTable("game_event")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Announce)
                .HasDefaultValueSql("'2'")
                .HasComment("0 dont announce, 1 announce, 2 value from config")
                .HasColumnName("announce");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Description of the event displayed in console")
                .HasColumnName("description");
            entity.Property(e => e.EndTime)
                .HasComment("Absolute end date, the event will never start after")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            entity.Property(e => e.Holiday)
                .HasComment("Client side holiday id")
                .HasColumnName("holiday");
            entity.Property(e => e.HolidayStage).HasColumnName("holidayStage");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'2592000'")
                .HasComment("Length in minutes of the event")
                .HasColumnName("length");
            entity.Property(e => e.Occurence)
                .HasDefaultValueSql("'5184000'")
                .HasComment("Delay in minutes between occurences of the event")
                .HasColumnName("occurence");
            entity.Property(e => e.StartTime)
                .HasComment("Absolute start date, the event will never start before")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
            entity.Property(e => e.WorldEvent)
                .HasComment("0 if normal event, 1 if world event")
                .HasColumnName("world_event");
        });

        modelBuilder.Entity<GameEventArenaSeason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_event_arena_seasons")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Season, e.EventEntry }, "season").IsUnique();

            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Season)
                .HasComment("Arena season number")
                .HasColumnName("season");
        });

        modelBuilder.Entity<GameEventBattlegroundHoliday>(entity =>
        {
            entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            entity
                .ToTable("game_event_battleground_holiday")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.EventEntry).HasComment("game_event EventEntry identifier");
            entity.Property(e => e.BattlegroundId).HasColumnName("BattlegroundID");
        });

        modelBuilder.Entity<GameEventCondition>(entity =>
        {
            entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_condition")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DoneWorldStateField).HasColumnName("done_world_state_field");
            entity.Property(e => e.MaxWorldStateField).HasColumnName("max_world_state_field");
            entity.Property(e => e.ReqNum)
                .HasDefaultValueSql("'0'")
                .HasColumnName("req_num");
        });

        modelBuilder.Entity<GameEventCreature>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_creature")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventCreatureQuest>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_creature_quest")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasColumnName("quest");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventGameobject>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_gameobject")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventGameobjectQuest>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("game_event_gameobject_quest")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasColumnName("quest");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventModelEquip>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("game_event_model_equip")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
        });

        modelBuilder.Entity<GameEventNpcVendor>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_npc_vendor")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Slot, "slot");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<GameEventNpcflag>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_npcflag")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
        });

        modelBuilder.Entity<GameEventPool>(entity =>
        {
            entity.HasKey(e => e.PoolEntry).HasName("PRIMARY");

            entity
                .ToTable("game_event_pool")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.PoolEntry)
                .ValueGeneratedNever()
                .HasComment("Id of the pool")
                .HasColumnName("pool_entry");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventPrerequisite>(entity =>
        {
            entity.HasKey(e => new { e.EventEntry, e.PrerequisiteEvent })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_prerequisite")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.PrerequisiteEvent).HasColumnName("prerequisite_event");
        });

        modelBuilder.Entity<GameEventQuestCondition>(entity =>
        {
            entity.HasKey(e => e.Quest).HasName("PRIMARY");

            entity
                .ToTable("game_event_quest_condition")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Quest)
                .ValueGeneratedNever()
                .HasColumnName("quest");
            entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Num)
                .HasDefaultValueSql("'0'")
                .HasColumnName("num");
        });

        modelBuilder.Entity<GameEventSeasonalQuestrelation>(entity =>
        {
            entity.HasKey(e => new { e.QuestId, e.EventEntry })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("game_event_seasonal_questrelation", tb => tb.HasComment("Player System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.QuestId, "idx_quest");

            entity.Property(e => e.QuestId)
                .HasComment("Quest Identifier")
                .HasColumnName("questId");
            entity.Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameTele>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("game_tele", tb => tb.HasComment("Tele Command"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<GameWeather>(entity =>
        {
            entity.HasKey(e => e.Zone).HasName("PRIMARY");

            entity
                .ToTable("game_weather", tb => tb.HasComment("Weather System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Zone)
                .ValueGeneratedNever()
                .HasColumnName("zone");
            entity.Property(e => e.FallRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_rain_chance");
            entity.Property(e => e.FallSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_snow_chance");
            entity.Property(e => e.FallStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_storm_chance");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SpringRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_rain_chance");
            entity.Property(e => e.SpringSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_snow_chance");
            entity.Property(e => e.SpringStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_storm_chance");
            entity.Property(e => e.SummerRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_rain_chance");
            entity.Property(e => e.SummerSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_snow_chance");
            entity.Property(e => e.SummerStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_storm_chance");
            entity.Property(e => e.WinterRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_rain_chance");
            entity.Property(e => e.WinterSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_snow_chance");
            entity.Property(e => e.WinterStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_storm_chance");
        });

        modelBuilder.Entity<Gameobject>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("gameobject", tb => tb.HasComment("Gameobject System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Animprogress).HasColumnName("animprogress");
            entity.Property(e => e.AreaId)
                .HasComment("Area Identifier")
                .HasColumnName("areaId");
            entity.Property(e => e.Id)
                .HasComment("Gameobject Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PhaseMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("phaseMask");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Rotation0).HasColumnName("rotation0");
            entity.Property(e => e.Rotation1).HasColumnName("rotation1");
            entity.Property(e => e.Rotation2).HasColumnName("rotation2");
            entity.Property(e => e.Rotation3).HasColumnName("rotation3");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SpawnMask)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spawnMask");
            entity.Property(e => e.Spawntimesecs).HasColumnName("spawntimesecs");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.ZoneId)
                .HasComment("Zone Identifier")
                .HasColumnName("zoneId");
        });

        modelBuilder.Entity<GameobjectAddon>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("gameobject_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            entity.Property(e => e.InvisibilityType).HasColumnName("invisibilityType");
            entity.Property(e => e.InvisibilityValue).HasColumnName("invisibilityValue");
            entity.Property(e => e.ParentRotation0).HasColumnName("parent_rotation0");
            entity.Property(e => e.ParentRotation1).HasColumnName("parent_rotation1");
            entity.Property(e => e.ParentRotation2).HasColumnName("parent_rotation2");
            entity.Property(e => e.ParentRotation3)
                .HasDefaultValueSql("'1'")
                .HasColumnName("parent_rotation3");
        });

        modelBuilder.Entity<GameobjectLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gameobject_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<GameobjectOverride>(entity =>
        {
            entity.HasKey(e => e.SpawnId).HasName("PRIMARY");

            entity
                .ToTable("gameobject_overrides")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpawnId)
                .ValueGeneratedNever()
                .HasColumnName("spawnId");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
        });

        modelBuilder.Entity<GameobjectQuestender>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gameobject_questender")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<GameobjectQuestitem>(entity =>
        {
            entity.HasKey(e => new { e.GameObjectEntry, e.Idx })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gameobject_questitem")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<GameobjectQueststarter>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gameobject_queststarter")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<GameobjectTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("gameobject_template", tb => tb.HasComment("Gameobject System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "idx_name");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            entity.Property(e => e.CastBarCaption)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("castBarCaption");
            entity.Property(e => e.DisplayId).HasColumnName("displayId");
            entity.Property(e => e.IconName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Size)
                .HasDefaultValueSql("'1'")
                .HasColumnName("size");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Unk1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("unk1");
        });

        modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("gameobject_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.Artkit0).HasColumnName("artkit0");
            entity.Property(e => e.Artkit1).HasColumnName("artkit1");
            entity.Property(e => e.Artkit2).HasColumnName("artkit2");
            entity.Property(e => e.Artkit3).HasColumnName("artkit3");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            entity.Property(e => e.Mingold).HasColumnName("mingold");
        });

        modelBuilder.Entity<GameobjectTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gameobject_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.CastBarCaption)
                .HasColumnType("mediumtext")
                .HasColumnName("castBarCaption");
            entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
        });

        modelBuilder.Entity<GossipMenu>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.TextId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gossip_menu")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.TextId).HasColumnName("TextID");
        });

        modelBuilder.Entity<GossipMenuOption>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.OptionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("gossip_menu_option")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.OptionId).HasColumnName("OptionID");
            entity.Property(e => e.ActionMenuId).HasColumnName("ActionMenuID");
            entity.Property(e => e.ActionPoiId).HasColumnName("ActionPoiID");
            entity.Property(e => e.BoxBroadcastTextId).HasColumnName("BoxBroadcastTextID");
            entity.Property(e => e.BoxText).HasColumnType("mediumtext");
            entity.Property(e => e.OptionBroadcastTextId).HasColumnName("OptionBroadcastTextID");
            entity.Property(e => e.OptionText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<GossipMenuOptionLocale>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.OptionId, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("gossip_menu_option_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.OptionId).HasColumnName("OptionID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.BoxText).HasColumnType("mediumtext");
            entity.Property(e => e.OptionText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<GraveyardZone>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GhostZone })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("graveyard_zone", tb => tb.HasComment("Trigger System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<HolidayDate>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.DateId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("holiday_dates")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateId).HasColumnName("date_id");
            entity.Property(e => e.DateValue).HasColumnName("date_value");
            entity.Property(e => e.HolidayDuration).HasColumnName("holiday_duration");
        });

        modelBuilder.Entity<InstanceEncounter>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("instance_encounters")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Unique entry from DungeonEncounter.dbc")
                .HasColumnName("entry");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.CreditEntry).HasColumnName("creditEntry");
            entity.Property(e => e.CreditType).HasColumnName("creditType");
            entity.Property(e => e.LastEncounterDungeon)
                .HasComment("If not 0, LfgDungeon.dbc entry for the instance it is last encounter in")
                .HasColumnName("lastEncounterDungeon");
        });

        modelBuilder.Entity<InstanceSpawnGroup>(entity =>
        {
            entity.HasKey(e => new { e.InstanceMapId, e.BossStateId, e.SpawnGroupId, e.BossStates })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("instance_spawn_groups")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.InstanceMapId).HasColumnName("instanceMapId");
            entity.Property(e => e.BossStateId).HasColumnName("bossStateId");
            entity.Property(e => e.SpawnGroupId).HasColumnName("spawnGroupId");
            entity.Property(e => e.BossStates).HasColumnName("bossStates");
            entity.Property(e => e.Flags).HasColumnName("flags");
        });

        modelBuilder.Entity<InstanceTemplate>(entity =>
        {
            entity.HasKey(e => e.Map).HasName("PRIMARY");

            entity
                .ToTable("instance_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Map)
                .ValueGeneratedNever()
                .HasColumnName("map");
            entity.Property(e => e.AllowMount).HasColumnName("allowMount");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Script)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script");
        });

        modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Ench })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("item_enchantment_template", tb => tb.HasComment("Item Random Enchantment System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Ench).HasColumnName("ench");
            entity.Property(e => e.Chance)
                .HasColumnType("float unsigned")
                .HasColumnName("chance");
        });

        modelBuilder.Entity<ItemLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("item_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<ItemSetName>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("item_set_names")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ItemSetNamesLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("item_set_names_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<ItemTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("item_template", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "idx_name");

            entity.HasIndex(e => e.Class, "items_index");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.AllowableClass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AllowableRace).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AmmoType).HasColumnName("ammo_type");
            entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.Block).HasColumnName("block");
            entity.Property(e => e.Bonding).HasColumnName("bonding");
            entity.Property(e => e.BuyCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Delay)
                .HasDefaultValueSql("'1000'")
                .HasColumnName("delay");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DisenchantId).HasColumnName("DisenchantID");
            entity.Property(e => e.Displayid).HasColumnName("displayid");
            entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");
            entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");
            entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");
            entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");
            entity.Property(e => e.DmgType1).HasColumnName("dmg_type1");
            entity.Property(e => e.DmgType2).HasColumnName("dmg_type2");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FireRes).HasColumnName("fire_res");
            entity.Property(e => e.FlagsCustom).HasColumnName("flagsCustom");
            entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            entity.Property(e => e.Itemset).HasColumnName("itemset");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.Lockid).HasColumnName("lockid");
            entity.Property(e => e.MaxMoneyLoot).HasColumnName("maxMoneyLoot");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.MinMoneyLoot).HasColumnName("minMoneyLoot");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            entity.Property(e => e.RequiredDisenchantSkill).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Requiredhonorrank).HasColumnName("requiredhonorrank");
            entity.Property(e => e.Requiredspell).HasColumnName("requiredspell");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            entity.Property(e => e.Sheath).HasColumnName("sheath");
            entity.Property(e => e.SocketBonus).HasColumnName("socketBonus");
            entity.Property(e => e.SocketColor1).HasColumnName("socketColor_1");
            entity.Property(e => e.SocketColor2).HasColumnName("socketColor_2");
            entity.Property(e => e.SocketColor3).HasColumnName("socketColor_3");
            entity.Property(e => e.SocketContent1).HasColumnName("socketContent_1");
            entity.Property(e => e.SocketContent2).HasColumnName("socketContent_2");
            entity.Property(e => e.SocketContent3).HasColumnName("socketContent_3");
            entity.Property(e => e.SoundOverrideSubclass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Spellcategory1).HasColumnName("spellcategory_1");
            entity.Property(e => e.Spellcategory2).HasColumnName("spellcategory_2");
            entity.Property(e => e.Spellcategory3).HasColumnName("spellcategory_3");
            entity.Property(e => e.Spellcategory4).HasColumnName("spellcategory_4");
            entity.Property(e => e.Spellcategory5).HasColumnName("spellcategory_5");
            entity.Property(e => e.Spellcategorycooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_1");
            entity.Property(e => e.Spellcategorycooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_2");
            entity.Property(e => e.Spellcategorycooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_3");
            entity.Property(e => e.Spellcategorycooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_4");
            entity.Property(e => e.Spellcategorycooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_5");
            entity.Property(e => e.Spellcharges1).HasColumnName("spellcharges_1");
            entity.Property(e => e.Spellcharges2).HasColumnName("spellcharges_2");
            entity.Property(e => e.Spellcharges3).HasColumnName("spellcharges_3");
            entity.Property(e => e.Spellcharges4).HasColumnName("spellcharges_4");
            entity.Property(e => e.Spellcharges5).HasColumnName("spellcharges_5");
            entity.Property(e => e.Spellcooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_1");
            entity.Property(e => e.Spellcooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_2");
            entity.Property(e => e.Spellcooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_3");
            entity.Property(e => e.Spellcooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_4");
            entity.Property(e => e.Spellcooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_5");
            entity.Property(e => e.Spellid1).HasColumnName("spellid_1");
            entity.Property(e => e.Spellid2).HasColumnName("spellid_2");
            entity.Property(e => e.Spellid3).HasColumnName("spellid_3");
            entity.Property(e => e.Spellid4).HasColumnName("spellid_4");
            entity.Property(e => e.Spellid5).HasColumnName("spellid_5");
            entity.Property(e => e.SpellppmRate1).HasColumnName("spellppmRate_1");
            entity.Property(e => e.SpellppmRate2).HasColumnName("spellppmRate_2");
            entity.Property(e => e.SpellppmRate3).HasColumnName("spellppmRate_3");
            entity.Property(e => e.SpellppmRate4).HasColumnName("spellppmRate_4");
            entity.Property(e => e.SpellppmRate5).HasColumnName("spellppmRate_5");
            entity.Property(e => e.Spelltrigger1).HasColumnName("spelltrigger_1");
            entity.Property(e => e.Spelltrigger2).HasColumnName("spelltrigger_2");
            entity.Property(e => e.Spelltrigger3).HasColumnName("spelltrigger_3");
            entity.Property(e => e.Spelltrigger4).HasColumnName("spelltrigger_4");
            entity.Property(e => e.Spelltrigger5).HasColumnName("spelltrigger_5");
            entity.Property(e => e.Stackable)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackable");
            entity.Property(e => e.Startquest).HasColumnName("startquest");
            entity.Property(e => e.StatType1).HasColumnName("stat_type1");
            entity.Property(e => e.StatType10).HasColumnName("stat_type10");
            entity.Property(e => e.StatType2).HasColumnName("stat_type2");
            entity.Property(e => e.StatType3).HasColumnName("stat_type3");
            entity.Property(e => e.StatType4).HasColumnName("stat_type4");
            entity.Property(e => e.StatType5).HasColumnName("stat_type5");
            entity.Property(e => e.StatType6).HasColumnName("stat_type6");
            entity.Property(e => e.StatType7).HasColumnName("stat_type7");
            entity.Property(e => e.StatType8).HasColumnName("stat_type8");
            entity.Property(e => e.StatType9).HasColumnName("stat_type9");
            entity.Property(e => e.StatValue1).HasColumnName("stat_value1");
            entity.Property(e => e.StatValue10).HasColumnName("stat_value10");
            entity.Property(e => e.StatValue2).HasColumnName("stat_value2");
            entity.Property(e => e.StatValue3).HasColumnName("stat_value3");
            entity.Property(e => e.StatValue4).HasColumnName("stat_value4");
            entity.Property(e => e.StatValue5).HasColumnName("stat_value5");
            entity.Property(e => e.StatValue6).HasColumnName("stat_value6");
            entity.Property(e => e.StatValue7).HasColumnName("stat_value7");
            entity.Property(e => e.StatValue8).HasColumnName("stat_value8");
            entity.Property(e => e.StatValue9).HasColumnName("stat_value9");
            entity.Property(e => e.Subclass).HasColumnName("subclass");
        });

        modelBuilder.Entity<ItemTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("item_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Description).HasColumnType("mediumtext");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<LfgDungeonReward>(entity =>
        {
            entity.HasKey(e => new { e.DungeonId, e.MaxLevel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("lfg_dungeon_rewards")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.DungeonId)
                .HasComment("Dungeon entry from dbc")
                .HasColumnName("dungeonId");
            entity.Property(e => e.MaxLevel)
                .HasComment("Max level at which this reward is rewarded")
                .HasColumnName("maxLevel");
            entity.Property(e => e.FirstQuestId)
                .HasComment("Quest id with rewards for first dungeon this day")
                .HasColumnName("firstQuestId");
            entity.Property(e => e.OtherQuestId)
                .HasComment("Quest id with rewards for Nth dungeon this day")
                .HasColumnName("otherQuestId");
        });

        modelBuilder.Entity<LfgDungeonTemplate>(entity =>
        {
            entity.HasKey(e => e.DungeonId).HasName("PRIMARY");

            entity
                .ToTable("lfg_dungeon_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.DungeonId)
                .ValueGeneratedNever()
                .HasComment("Unique id from LFGDungeons.dbc")
                .HasColumnName("dungeonId");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<LinkedRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.LinkType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("linked_respawn", tb => tb.HasComment("Creature Respawn Link System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .HasComment("dependent creature")
                .HasColumnName("guid");
            entity.Property(e => e.LinkType).HasColumnName("linkType");
            entity.Property(e => e.LinkedGuid)
                .HasComment("master creature")
                .HasColumnName("linkedGuid");
        });

        modelBuilder.Entity<MailLevelReward>(entity =>
        {
            entity.HasKey(e => new { e.Level, e.RaceMask })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("mail_level_reward", tb => tb.HasComment("Mail System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.MailTemplateId).HasColumnName("mailTemplateId");
            entity.Property(e => e.SenderEntry).HasColumnName("senderEntry");
        });

        modelBuilder.Entity<MailLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("mail_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<MillingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("milling_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<NpcSpellclickSpell>(entity =>
        {
            entity.HasKey(e => new { e.NpcEntry, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("npc_spellclick_spells")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.NpcEntry)
                .HasComment("reference to creature_template")
                .HasColumnName("npc_entry");
            entity.Property(e => e.SpellId)
                .HasComment("spell which should be casted ")
                .HasColumnName("spell_id");
            entity.Property(e => e.CastFlags)
                .HasComment("first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit")
                .HasColumnName("cast_flags");
            entity.Property(e => e.UserType)
                .HasComment("relation with summoner: 0-no 1-friendly 2-raid 3-party player can click")
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<NpcText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("npc_text")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BroadcastTextId0).HasColumnName("BroadcastTextID0");
            entity.Property(e => e.BroadcastTextId1).HasColumnName("BroadcastTextID1");
            entity.Property(e => e.BroadcastTextId2).HasColumnName("BroadcastTextID2");
            entity.Property(e => e.BroadcastTextId3).HasColumnName("BroadcastTextID3");
            entity.Property(e => e.BroadcastTextId4).HasColumnName("BroadcastTextID4");
            entity.Property(e => e.BroadcastTextId5).HasColumnName("BroadcastTextID5");
            entity.Property(e => e.BroadcastTextId6).HasColumnName("BroadcastTextID6");
            entity.Property(e => e.BroadcastTextId7).HasColumnName("BroadcastTextID7");
            entity.Property(e => e.Emote00).HasColumnName("Emote0_0");
            entity.Property(e => e.Emote01).HasColumnName("Emote0_1");
            entity.Property(e => e.Emote02).HasColumnName("Emote0_2");
            entity.Property(e => e.Emote10).HasColumnName("Emote1_0");
            entity.Property(e => e.Emote11).HasColumnName("Emote1_1");
            entity.Property(e => e.Emote12).HasColumnName("Emote1_2");
            entity.Property(e => e.Emote20).HasColumnName("Emote2_0");
            entity.Property(e => e.Emote21).HasColumnName("Emote2_1");
            entity.Property(e => e.Emote22).HasColumnName("Emote2_2");
            entity.Property(e => e.Emote30).HasColumnName("Emote3_0");
            entity.Property(e => e.Emote31).HasColumnName("Emote3_1");
            entity.Property(e => e.Emote32).HasColumnName("Emote3_2");
            entity.Property(e => e.Emote40).HasColumnName("Emote4_0");
            entity.Property(e => e.Emote41).HasColumnName("Emote4_1");
            entity.Property(e => e.Emote42).HasColumnName("Emote4_2");
            entity.Property(e => e.Emote50).HasColumnName("Emote5_0");
            entity.Property(e => e.Emote51).HasColumnName("Emote5_1");
            entity.Property(e => e.Emote52).HasColumnName("Emote5_2");
            entity.Property(e => e.Emote60).HasColumnName("Emote6_0");
            entity.Property(e => e.Emote61).HasColumnName("Emote6_1");
            entity.Property(e => e.Emote62).HasColumnName("Emote6_2");
            entity.Property(e => e.Emote70).HasColumnName("Emote7_0");
            entity.Property(e => e.Emote71).HasColumnName("Emote7_1");
            entity.Property(e => e.Emote72).HasColumnName("Emote7_2");
            entity.Property(e => e.EmoteDelay00).HasColumnName("EmoteDelay0_0");
            entity.Property(e => e.EmoteDelay01).HasColumnName("EmoteDelay0_1");
            entity.Property(e => e.EmoteDelay02).HasColumnName("EmoteDelay0_2");
            entity.Property(e => e.EmoteDelay10).HasColumnName("EmoteDelay1_0");
            entity.Property(e => e.EmoteDelay11).HasColumnName("EmoteDelay1_1");
            entity.Property(e => e.EmoteDelay12).HasColumnName("EmoteDelay1_2");
            entity.Property(e => e.EmoteDelay20).HasColumnName("EmoteDelay2_0");
            entity.Property(e => e.EmoteDelay21).HasColumnName("EmoteDelay2_1");
            entity.Property(e => e.EmoteDelay22).HasColumnName("EmoteDelay2_2");
            entity.Property(e => e.EmoteDelay30).HasColumnName("EmoteDelay3_0");
            entity.Property(e => e.EmoteDelay31).HasColumnName("EmoteDelay3_1");
            entity.Property(e => e.EmoteDelay32).HasColumnName("EmoteDelay3_2");
            entity.Property(e => e.EmoteDelay40).HasColumnName("EmoteDelay4_0");
            entity.Property(e => e.EmoteDelay41).HasColumnName("EmoteDelay4_1");
            entity.Property(e => e.EmoteDelay42).HasColumnName("EmoteDelay4_2");
            entity.Property(e => e.EmoteDelay50).HasColumnName("EmoteDelay5_0");
            entity.Property(e => e.EmoteDelay51).HasColumnName("EmoteDelay5_1");
            entity.Property(e => e.EmoteDelay52).HasColumnName("EmoteDelay5_2");
            entity.Property(e => e.EmoteDelay60).HasColumnName("EmoteDelay6_0");
            entity.Property(e => e.EmoteDelay61).HasColumnName("EmoteDelay6_1");
            entity.Property(e => e.EmoteDelay62).HasColumnName("EmoteDelay6_2");
            entity.Property(e => e.EmoteDelay70).HasColumnName("EmoteDelay7_0");
            entity.Property(e => e.EmoteDelay71).HasColumnName("EmoteDelay7_1");
            entity.Property(e => e.EmoteDelay72).HasColumnName("EmoteDelay7_2");
            entity.Property(e => e.Lang0).HasColumnName("lang0");
            entity.Property(e => e.Lang1).HasColumnName("lang1");
            entity.Property(e => e.Lang2).HasColumnName("lang2");
            entity.Property(e => e.Lang3).HasColumnName("lang3");
            entity.Property(e => e.Lang4).HasColumnName("lang4");
            entity.Property(e => e.Lang5).HasColumnName("lang5");
            entity.Property(e => e.Lang6).HasColumnName("lang6");
            entity.Property(e => e.Lang7).HasColumnName("lang7");
            entity.Property(e => e.Text00).HasColumnName("text0_0");
            entity.Property(e => e.Text01).HasColumnName("text0_1");
            entity.Property(e => e.Text10).HasColumnName("text1_0");
            entity.Property(e => e.Text11).HasColumnName("text1_1");
            entity.Property(e => e.Text20).HasColumnName("text2_0");
            entity.Property(e => e.Text21).HasColumnName("text2_1");
            entity.Property(e => e.Text30).HasColumnName("text3_0");
            entity.Property(e => e.Text31).HasColumnName("text3_1");
            entity.Property(e => e.Text40).HasColumnName("text4_0");
            entity.Property(e => e.Text41).HasColumnName("text4_1");
            entity.Property(e => e.Text50).HasColumnName("text5_0");
            entity.Property(e => e.Text51).HasColumnName("text5_1");
            entity.Property(e => e.Text60).HasColumnName("text6_0");
            entity.Property(e => e.Text61).HasColumnName("text6_1");
            entity.Property(e => e.Text70).HasColumnName("text7_0");
            entity.Property(e => e.Text71).HasColumnName("text7_1");
        });

        modelBuilder.Entity<NpcTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("npc_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Text00).HasColumnName("Text0_0");
            entity.Property(e => e.Text01).HasColumnName("Text0_1");
            entity.Property(e => e.Text10).HasColumnName("Text1_0");
            entity.Property(e => e.Text11).HasColumnName("Text1_1");
            entity.Property(e => e.Text20).HasColumnName("Text2_0");
            entity.Property(e => e.Text21).HasColumnName("Text2_1");
            entity.Property(e => e.Text30).HasColumnName("Text3_0");
            entity.Property(e => e.Text31).HasColumnName("Text3_1");
            entity.Property(e => e.Text40).HasColumnName("Text4_0");
            entity.Property(e => e.Text41).HasColumnName("Text4_1");
            entity.Property(e => e.Text50).HasColumnName("Text5_0");
            entity.Property(e => e.Text51).HasColumnName("Text5_1");
            entity.Property(e => e.Text60).HasColumnName("Text6_0");
            entity.Property(e => e.Text61).HasColumnName("Text6_1");
            entity.Property(e => e.Text70).HasColumnName("Text7_0");
            entity.Property(e => e.Text71).HasColumnName("Text7_1");
        });

        modelBuilder.Entity<NpcVendor>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item, e.ExtendedCost })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("npc_vendor", tb => tb.HasComment("Npc System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Slot, "slot");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<OutdoorpvpTemplate>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PRIMARY");

            entity
                .ToTable("outdoorpvp_template", tb => tb.HasComment("OutdoorPvP Templates"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<PageText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("page_text", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NextPageId).HasColumnName("NextPageID");
        });

        modelBuilder.Entity<PageTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("page_text_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Text).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<PetLevelstat>(entity =>
        {
            entity.HasKey(e => new { e.CreatureEntry, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("pet_levelstats", tb => tb.HasComment("Stores pet levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureEntry).HasColumnName("creature_entry");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agi).HasColumnName("agi");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.Hp).HasColumnName("hp");
            entity.Property(e => e.Inte).HasColumnName("inte");
            entity.Property(e => e.Mana).HasColumnName("mana");
            entity.Property(e => e.MaxDmg).HasColumnName("max_dmg");
            entity.Property(e => e.MinDmg).HasColumnName("min_dmg");
            entity.Property(e => e.Spi).HasColumnName("spi");
            entity.Property(e => e.Sta).HasColumnName("sta");
            entity.Property(e => e.Str).HasColumnName("str");
        });

        modelBuilder.Entity<PetNameGeneration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pet_name_generation")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Half).HasColumnName("half");
            entity.Property(e => e.Word)
                .HasColumnType("text")
                .HasColumnName("word");
        });

        modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("pickpocketing_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PlayerClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_classlevelstats", tb => tb.HasComment("Stores levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basehp).HasColumnName("basehp");
            entity.Property(e => e.Basemana).HasColumnName("basemana");
        });

        modelBuilder.Entity<PlayerFactionchangeAchievement>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_achievement")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeItem>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_items")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity.Property(e => e.CommentA)
                .HasColumnType("mediumtext")
                .HasColumnName("commentA");
            entity.Property(e => e.CommentH)
                .HasColumnType("mediumtext")
                .HasColumnName("commentH");
            entity.Property(e => e.RaceA).HasColumnName("race_A");
            entity.Property(e => e.RaceH).HasColumnName("race_H");
        });

        modelBuilder.Entity<PlayerFactionchangeQuest>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_quests")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AllianceId, "alliance_uniq").IsUnique();

            entity.HasIndex(e => e.HordeId, "horde_uniq").IsUnique();

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeReputation>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_reputations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeSpell>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_spells")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeTitle>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_factionchange_titles")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerLevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("player_levelstats", tb => tb.HasComment("Stores levels stats."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agi).HasColumnName("agi");
            entity.Property(e => e.Inte).HasColumnName("inte");
            entity.Property(e => e.Spi).HasColumnName("spi");
            entity.Property(e => e.Sta).HasColumnName("sta");
            entity.Property(e => e.Str).HasColumnName("str");
        });

        modelBuilder.Entity<PlayerTotemModel>(entity =>
        {
            entity.HasKey(e => new { e.TotemSlot, e.RaceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("player_totem_model")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<PlayerXpForLevel>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity
                .ToTable("player_xp_for_level")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<Playercreateinfo>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("playercreateinfo")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Zone).HasColumnName("zone");
        });

        modelBuilder.Entity<PlayercreateinfoAction>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Button })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("playercreateinfo_action")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Button).HasColumnName("button");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<PlayercreateinfoCastSpell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("playercreateinfo_cast_spell")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.ClassMask).HasColumnName("classMask");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.Spell).HasColumnName("spell");
        });

        modelBuilder.Entity<PlayercreateinfoItem>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Itemid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("playercreateinfo_item")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("amount");
        });

        modelBuilder.Entity<PlayercreateinfoSkill>(entity =>
        {
            entity.HasKey(e => new { e.RaceMask, e.ClassMask, e.Skill })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("playercreateinfo_skills")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.ClassMask).HasColumnName("classMask");
            entity.Property(e => e.Skill).HasColumnName("skill");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.Rank).HasColumnName("rank");
        });

        modelBuilder.Entity<PlayercreateinfoSpellCustom>(entity =>
        {
            entity.HasKey(e => new { e.Racemask, e.Classmask, e.Spell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("playercreateinfo_spell_custom")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Racemask).HasColumnName("racemask");
            entity.Property(e => e.Classmask).HasColumnName("classmask");
            entity.Property(e => e.Note).HasMaxLength(255);
        });

        modelBuilder.Entity<PointsOfInterest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("points_of_interest")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<PointsOfInterestLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("points_of_interest_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<PoolMember>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.SpawnId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("pool_members")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.SpawnId).HasColumnName("spawnId");
            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.PoolSpawnId).HasColumnName("poolSpawnId");
        });

        modelBuilder.Entity<PoolTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("pool_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Pool entry")
                .HasColumnName("entry");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.MaxLimit)
                .HasComment("Max number of objects (0) is no limit")
                .HasColumnName("max_limit");
        });

        modelBuilder.Entity<ProspectingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("prospecting_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<QuestDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("quest_details")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<QuestGreeting>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Type })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("quest_greeting")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Greeting).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestGreetingLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Type, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("quest_greeting_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.Greeting).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestMailSender>(entity =>
        {
            entity.HasKey(e => e.QuestId).HasName("PRIMARY");

            entity
                .ToTable("quest_mail_sender")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.QuestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<QuestOfferReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("quest_offer_reward")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.RewardText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestOfferRewardLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("quest_offer_reward_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.RewardText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestPoi>(entity =>
        {
            entity.HasKey(e => new { e.QuestId, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("quest_poi")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.QuestId, e.Id }, "idx");

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        modelBuilder.Entity<QuestPoiPoint>(entity =>
        {
            entity.HasKey(e => new { e.QuestId, e.Idx1, e.Idx2 })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("quest_poi_points")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.QuestId, e.Idx1 }, "questId_id");

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
        });

        modelBuilder.Entity<QuestPoolMember>(entity =>
        {
            entity.HasKey(e => e.QuestId).HasName("PRIMARY");

            entity
                .ToTable("quest_pool_members")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.QuestId)
                .ValueGeneratedNever()
                .HasColumnName("questId");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.PoolId).HasColumnName("poolId");
            entity.Property(e => e.PoolIndex)
                .HasComment("Multiple quests with the same index will always spawn together!")
                .HasColumnName("poolIndex");
        });

        modelBuilder.Entity<QuestPoolTemplate>(entity =>
        {
            entity.HasKey(e => e.PoolId).HasName("PRIMARY");

            entity
                .ToTable("quest_pool_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.PoolId)
                .ValueGeneratedNever()
                .HasColumnName("poolId");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.NumActive)
                .HasComment("Number of indices to have active at any time")
                .HasColumnName("numActive");
        });

        modelBuilder.Entity<QuestRequestItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("quest_request_items")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CompletionText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestRequestItemsLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("quest_request_items_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.CompletionText).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<QuestTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("quest_template", tb => tb.HasComment("Quest System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaDescription).HasColumnType("mediumtext");
            entity.Property(e => e.LogDescription).HasColumnType("mediumtext");
            entity.Property(e => e.LogTitle).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText1).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText2).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText3).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText4).HasColumnType("mediumtext");
            entity.Property(e => e.Poicontinent).HasColumnName("POIContinent");
            entity.Property(e => e.Poipriority).HasColumnName("POIPriority");
            entity.Property(e => e.Poix).HasColumnName("POIx");
            entity.Property(e => e.Poiy).HasColumnName("POIy");
            entity.Property(e => e.QuestCompletionLog).HasColumnType("mediumtext");
            entity.Property(e => e.QuestDescription).HasColumnType("mediumtext");
            entity.Property(e => e.QuestInfoId).HasColumnName("QuestInfoID");
            entity.Property(e => e.QuestLevel).HasDefaultValueSql("'1'");
            entity.Property(e => e.QuestSortId).HasColumnName("QuestSortID");
            entity.Property(e => e.QuestType).HasDefaultValueSql("'2'");
            entity.Property(e => e.RewardChoiceItemId1).HasColumnName("RewardChoiceItemID1");
            entity.Property(e => e.RewardChoiceItemId2).HasColumnName("RewardChoiceItemID2");
            entity.Property(e => e.RewardChoiceItemId3).HasColumnName("RewardChoiceItemID3");
            entity.Property(e => e.RewardChoiceItemId4).HasColumnName("RewardChoiceItemID4");
            entity.Property(e => e.RewardChoiceItemId5).HasColumnName("RewardChoiceItemID5");
            entity.Property(e => e.RewardChoiceItemId6).HasColumnName("RewardChoiceItemID6");
            entity.Property(e => e.RewardFactionId1)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID1");
            entity.Property(e => e.RewardFactionId2)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID2");
            entity.Property(e => e.RewardFactionId3)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID3");
            entity.Property(e => e.RewardFactionId4)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID4");
            entity.Property(e => e.RewardFactionId5)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID5");
            entity.Property(e => e.RewardXpdifficulty).HasColumnName("RewardXPDifficulty");
        });

        modelBuilder.Entity<QuestTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("quest_template_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NextQuestId).HasColumnName("NextQuestID");
            entity.Property(e => e.PrevQuestId).HasColumnName("PrevQuestID");
            entity.Property(e => e.RequiredSkillId).HasColumnName("RequiredSkillID");
            entity.Property(e => e.RewardMailTemplateId).HasColumnName("RewardMailTemplateID");
            entity.Property(e => e.SourceSpellId).HasColumnName("SourceSpellID");
        });

        modelBuilder.Entity<QuestTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("quest_template_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.CompletedText).HasColumnType("mediumtext");
            entity.Property(e => e.Details).HasColumnType("mediumtext");
            entity.Property(e => e.EndText).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText1).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText2).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText3).HasColumnType("mediumtext");
            entity.Property(e => e.ObjectiveText4).HasColumnType("mediumtext");
            entity.Property(e => e.Objectives).HasColumnType("mediumtext");
            entity.Property(e => e.Title).HasColumnType("mediumtext");
        });

        modelBuilder.Entity<ReferenceLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("reference_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<ReputationRewardRate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity
                .ToTable("reputation_reward_rate")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Faction)
                .ValueGeneratedNever()
                .HasColumnName("faction");
            entity.Property(e => e.CreatureRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("creature_rate");
            entity.Property(e => e.QuestDailyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_daily_rate");
            entity.Property(e => e.QuestMonthlyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_monthly_rate");
            entity.Property(e => e.QuestRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_rate");
            entity.Property(e => e.QuestRepeatableRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_repeatable_rate");
            entity.Property(e => e.QuestWeeklyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_weekly_rate");
            entity.Property(e => e.SpellRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spell_rate");
        });

        modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity
                .ToTable("reputation_spillover_template", tb => tb.HasComment("Reputation spillover reputation gain"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Faction)
                .ValueGeneratedNever()
                .HasComment("faction entry")
                .HasColumnName("faction");
            entity.Property(e => e.Faction1)
                .HasComment("faction to give spillover for")
                .HasColumnName("faction1");
            entity.Property(e => e.Faction2).HasColumnName("faction2");
            entity.Property(e => e.Faction3).HasColumnName("faction3");
            entity.Property(e => e.Faction4).HasColumnName("faction4");
            entity.Property(e => e.Rank1)
                .HasComment("max rank,above this will not give any spillover")
                .HasColumnName("rank_1");
            entity.Property(e => e.Rank2).HasColumnName("rank_2");
            entity.Property(e => e.Rank3).HasColumnName("rank_3");
            entity.Property(e => e.Rank4).HasColumnName("rank_4");
            entity.Property(e => e.Rate1)
                .HasComment("the given rep points * rate")
                .HasColumnName("rate_1");
            entity.Property(e => e.Rate2).HasColumnName("rate_2");
            entity.Property(e => e.Rate3).HasColumnName("rate_3");
            entity.Property(e => e.Rate4).HasColumnName("rate_4");
        });

        modelBuilder.Entity<ScriptSplineChainMetum>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("script_spline_chain_meta")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ChainId).HasColumnName("chainId");
            entity.Property(e => e.SplineId).HasColumnName("splineId");
            entity.Property(e => e.ExpectedDuration).HasColumnName("expectedDuration");
            entity.Property(e => e.MsUntilNext).HasColumnName("msUntilNext");
            entity.Property(e => e.Velocity)
                .HasDefaultValueSql("'0'")
                .HasColumnType("float unsigned")
                .HasColumnName("velocity");
        });

        modelBuilder.Entity<ScriptSplineChainWaypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId, e.WpId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("script_spline_chain_waypoints")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ChainId).HasColumnName("chainId");
            entity.Property(e => e.SplineId).HasColumnName("splineId");
            entity.Property(e => e.WpId).HasColumnName("wpId");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<ScriptWaypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Pointid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("script_waypoint", tb => tb.HasComment("Script Creature waypoints"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .HasComment("creature_template entry")
                .HasColumnName("entry");
            entity.Property(e => e.Pointid).HasColumnName("pointid");
            entity.Property(e => e.LocationX).HasColumnName("location_x");
            entity.Property(e => e.LocationY).HasColumnName("location_y");
            entity.Property(e => e.LocationZ).HasColumnName("location_z");
            entity.Property(e => e.PointComment)
                .HasColumnType("mediumtext")
                .HasColumnName("point_comment");
            entity.Property(e => e.Waittime)
                .HasComment("waittime in millisecs")
                .HasColumnName("waittime");
        });

        modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("skill_discovery_template", tb => tb.HasComment("Skill Discovery System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpellId)
                .HasComment("SpellId of the discoverable spell")
                .HasColumnName("spellId");
            entity.Property(e => e.ReqSpell)
                .HasComment("spell requirement")
                .HasColumnName("reqSpell");
            entity.Property(e => e.Chance)
                .HasComment("chance to discover")
                .HasColumnName("chance");
            entity.Property(e => e.ReqSkillValue)
                .HasComment("skill points requirement")
                .HasColumnName("reqSkillValue");
        });

        modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity
                .ToTable("skill_extra_item_template", tb => tb.HasComment("Skill Specialization System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpellId)
                .ValueGeneratedNever()
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            entity.Property(e => e.AdditionalCreateChance)
                .HasComment("chance to create add")
                .HasColumnName("additionalCreateChance");
            entity.Property(e => e.AdditionalMaxNum)
                .HasComment("max num of adds")
                .HasColumnName("additionalMaxNum");
            entity.Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("skill_fishing_base_level", tb => tb.HasComment("Fishing system"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("Area identifier")
                .HasColumnName("entry");
            entity.Property(e => e.Skill)
                .HasComment("Base skill level requirement")
                .HasColumnName("skill");
        });

        modelBuilder.Entity<SkillPerfectItemTemplate>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity
                .ToTable("skill_perfect_item_template", tb => tb.HasComment("Crafting Perfection System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpellId)
                .ValueGeneratedNever()
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            entity.Property(e => e.PerfectCreateChance)
                .HasComment("chance to create the perfect item instead")
                .HasColumnName("perfectCreateChance");
            entity.Property(e => e.PerfectItemType)
                .HasComment("perfect item type to create instead")
                .HasColumnName("perfectItemType");
            entity.Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        modelBuilder.Entity<SkinningLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("skinning_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SmartScript>(entity =>
        {
            entity.HasKey(e => new { e.Entryorguid, e.SourceType, e.Id, e.Link })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("smart_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entryorguid).HasColumnName("entryorguid");
            entity.Property(e => e.SourceType).HasColumnName("source_type");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.ActionParam1).HasColumnName("action_param1");
            entity.Property(e => e.ActionParam2).HasColumnName("action_param2");
            entity.Property(e => e.ActionParam3).HasColumnName("action_param3");
            entity.Property(e => e.ActionParam4).HasColumnName("action_param4");
            entity.Property(e => e.ActionParam5).HasColumnName("action_param5");
            entity.Property(e => e.ActionParam6).HasColumnName("action_param6");
            entity.Property(e => e.ActionType).HasColumnName("action_type");
            entity.Property(e => e.Comment)
                .HasComment("Event Comment")
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            entity.Property(e => e.EventParam5).HasColumnName("event_param5");
            entity.Property(e => e.EventPhaseMask).HasColumnName("event_phase_mask");
            entity.Property(e => e.EventType).HasColumnName("event_type");
            entity.Property(e => e.TargetO).HasColumnName("target_o");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetParam3).HasColumnName("target_param3");
            entity.Property(e => e.TargetParam4).HasColumnName("target_param4");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.TargetX).HasColumnName("target_x");
            entity.Property(e => e.TargetY).HasColumnName("target_y");
            entity.Property(e => e.TargetZ).HasColumnName("target_z");
        });

        modelBuilder.Entity<SpawnGroup>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.SpawnType, e.SpawnId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("spawn_group")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.SpawnType).HasColumnName("spawnType");
            entity.Property(e => e.SpawnId).HasColumnName("spawnId");
        });

        modelBuilder.Entity<SpawnGroupTemplate>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity
                .ToTable("spawn_group_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("groupId");
            entity.Property(e => e.GroupFlags).HasColumnName("groupFlags");
            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .HasColumnName("groupName");
        });

        modelBuilder.Entity<SpellArea>(entity =>
        {
            entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.AuraSpell, e.Racemask, e.Gender })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity
                .ToTable("spell_area")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.QuestStart).HasColumnName("quest_start");
            entity.Property(e => e.AuraSpell).HasColumnName("aura_spell");
            entity.Property(e => e.Racemask).HasColumnName("racemask");
            entity.Property(e => e.Gender)
                .HasDefaultValueSql("'2'")
                .HasColumnName("gender");
            entity.Property(e => e.Autocast).HasColumnName("autocast");
            entity.Property(e => e.QuestEnd).HasColumnName("quest_end");
            entity.Property(e => e.QuestEndStatus)
                .HasDefaultValueSql("'11'")
                .HasColumnName("quest_end_status");
            entity.Property(e => e.QuestStartStatus)
                .HasDefaultValueSql("'64'")
                .HasColumnName("quest_start_status");
        });

        modelBuilder.Entity<SpellBonusDatum>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("spell_bonus_data")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.ApBonus).HasColumnName("ap_bonus");
            entity.Property(e => e.ApDotBonus).HasColumnName("ap_dot_bonus");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.DirectBonus).HasColumnName("direct_bonus");
            entity.Property(e => e.DotBonus).HasColumnName("dot_bonus");
        });

        modelBuilder.Entity<SpellCustomAttr>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("spell_custom_attr", tb => tb.HasComment("SpellInfo custom attributes"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasComment("spell id")
                .HasColumnName("entry");
            entity.Property(e => e.Attributes)
                .HasComment("SpellCustomAttributes")
                .HasColumnName("attributes");
        });

        modelBuilder.Entity<SpellDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spell_dbc", tb => tb.HasComment("Custom spell.dbc entries"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CastingTimeIndex).HasDefaultValueSql("'1'");
            entity.Property(e => e.EquippedItemClass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.RangeIndex).HasDefaultValueSql("'1'");
            entity.Property(e => e.SpellName).HasMaxLength(100);
        });

        modelBuilder.Entity<SpellEnchantProcDatum>(entity =>
        {
            entity.HasKey(e => e.EnchantId).HasName("PRIMARY");

            entity
                .ToTable("spell_enchant_proc_data", tb => tb.HasComment("Spell enchant proc data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.EnchantId)
                .ValueGeneratedNever()
                .HasColumnName("EnchantID");
        });

        modelBuilder.Entity<SpellGroup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_group", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        modelBuilder.Entity<SpellGroupStackRule>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity
                .ToTable("spell_group_stack_rules")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("group_id");
            entity.Property(e => e.StackRule).HasColumnName("stack_rule");
        });

        modelBuilder.Entity<SpellLearnSpell>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_learn_spell", tb => tb.HasComment("Item System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SpellLinkedSpell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("spell_linked_spell", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.SpellTrigger, e.SpellEffect, e.Type }, "trigger_effect_type").IsUnique();

            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.SpellEffect).HasColumnName("spell_effect");
            entity.Property(e => e.SpellTrigger).HasColumnName("spell_trigger");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<SpellLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_loot_template", tb => tb.HasComment("Loot System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SpellPetAura>(entity =>
        {
            entity.HasKey(e => new { e.Spell, e.EffectId, e.Pet })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("spell_pet_auras")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Spell)
                .HasComment("dummy spell id")
                .HasColumnName("spell");
            entity.Property(e => e.EffectId).HasColumnName("effectId");
            entity.Property(e => e.Pet)
                .HasComment("pet id; 0 = all")
                .HasColumnName("pet");
            entity.Property(e => e.Aura)
                .HasComment("pet aura id")
                .HasColumnName("aura");
        });

        modelBuilder.Entity<SpellProc>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity
                .ToTable("spell_proc")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpellId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SpellRank>(entity =>
        {
            entity.HasKey(e => new { e.FirstSpellId, e.Rank })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_ranks", tb => tb.HasComment("Spell Rank Data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.SpellId, "spell_id").IsUnique();

            entity.Property(e => e.FirstSpellId).HasColumnName("first_spell_id");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        modelBuilder.Entity<SpellRequired>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_required", tb => tb.HasComment("Spell Additinal Data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.ReqSpell).HasColumnName("req_spell");
        });

        modelBuilder.Entity<SpellScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("spell_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.EffIndex).HasColumnName("effIndex");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<SpellScriptName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("spell_script_names")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.SpellId, e.ScriptName }, "spell_id").IsUnique();

            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength();
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        modelBuilder.Entity<SpellTargetPosition>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EffectIndex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("spell_target_position", tb => tb.HasComment("Spell System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        modelBuilder.Entity<SpellThreat>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("spell_threat")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.ApPctMod)
                .HasComment("additional threat bonus from attack power")
                .HasColumnName("apPctMod");
            entity.Property(e => e.FlatMod).HasColumnName("flatMod");
            entity.Property(e => e.PctMod)
                .HasDefaultValueSql("'1'")
                .HasComment("threat multiplier for damage/healing")
                .HasColumnName("pctMod");
        });

        modelBuilder.Entity<SpelldifficultyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spelldifficulty_dbc")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Spellid0).HasColumnName("spellid0");
            entity.Property(e => e.Spellid1).HasColumnName("spellid1");
            entity.Property(e => e.Spellid2).HasColumnName("spellid2");
            entity.Property(e => e.Spellid3).HasColumnName("spellid3");
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("trainer")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Greeting).HasColumnType("mediumtext");
            entity.Property(e => e.Type).HasDefaultValueSql("'2'");
        });

        modelBuilder.Entity<TrainerLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("trainer_locale")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Locale)
                .HasMaxLength(4)
                .HasColumnName("locale");
            entity.Property(e => e.GreetingLang)
                .HasColumnType("mediumtext")
                .HasColumnName("Greeting_lang");
        });

        modelBuilder.Entity<TrainerSpell>(entity =>
        {
            entity.HasKey(e => new { e.TrainerId, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("trainer_spell")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("transports", tb => tb.HasComment("Transports"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Entry, "idx_entry").IsUnique();

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Name)
                .HasColumnType("mediumtext")
                .HasColumnName("name");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<TrinityString>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity
                .ToTable("trinity_string")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry)
                .ValueGeneratedNever()
                .HasColumnName("entry");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("mediumtext")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("mediumtext")
                .HasColumnName("content_loc8");
        });

        modelBuilder.Entity<Update>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity
                .ToTable("updates", tb => tb.HasComment("List of all applied updates in this database."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            entity.Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<UpdatesInclude>(entity =>
        {
            entity.HasKey(e => e.Path).HasName("PRIMARY");

            entity
                .ToTable("updates_include", tb => tb.HasComment("List of directories where we want to include sql updates."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
        });

        modelBuilder.Entity<VehicleAccessory>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.SeatId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("vehicle_accessory")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            entity.Property(e => e.Description)
                .HasColumnType("mediumtext")
                .HasColumnName("description");
            entity.Property(e => e.Minion).HasColumnName("minion");
            entity.Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            entity.Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        modelBuilder.Entity<VehicleSeatAddon>(entity =>
        {
            entity.HasKey(e => e.SeatEntry).HasName("PRIMARY");

            entity
                .ToTable("vehicle_seat_addon")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.SeatEntry)
                .ValueGeneratedNever()
                .HasComment("VehicleSeatEntry.dbc identifier");
            entity.Property(e => e.ExitParamO).HasDefaultValueSql("'0'");
            entity.Property(e => e.ExitParamValue).HasDefaultValueSql("'0'");
            entity.Property(e => e.ExitParamX).HasDefaultValueSql("'0'");
            entity.Property(e => e.ExitParamY).HasDefaultValueSql("'0'");
            entity.Property(e => e.ExitParamZ).HasDefaultValueSql("'0'");
            entity.Property(e => e.SeatOrientation)
                .HasDefaultValueSql("'0'")
                .HasComment("Seat Orientation override value");
        });

        modelBuilder.Entity<VehicleTemplate>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity
                .ToTable("vehicle_template")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CreatureId)
                .ValueGeneratedNever()
                .HasColumnName("creatureId");
            entity.Property(e => e.DespawnDelayMs).HasColumnName("despawnDelayMs");
        });

        modelBuilder.Entity<VehicleTemplateAccessory>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.SeatId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("vehicle_template_accessory")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            entity.Property(e => e.Description)
                .HasColumnType("mediumtext")
                .HasColumnName("description");
            entity.Property(e => e.Minion).HasColumnName("minion");
            entity.Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            entity.Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.CoreVersion).HasName("PRIMARY");

            entity
                .ToTable("version", tb => tb.HasComment("Version Notes"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.CoreVersion)
                .HasDefaultValueSql("''")
                .HasComment("Core revision dumped at startup.")
                .HasColumnName("core_version");
            entity.Property(e => e.CacheId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("cache_id");
            entity.Property(e => e.CoreRevision)
                .HasMaxLength(120)
                .HasColumnName("core_revision");
            entity.Property(e => e.DbVersion)
                .HasMaxLength(120)
                .HasComment("Version of world DB.")
                .HasColumnName("db_version");
        });

        modelBuilder.Entity<VwConditionsWithLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_conditions_with_labels");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.ConditionTypeOrReference)
                .HasMaxLength(34)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.SourceTypeOrReferenceId)
                .HasMaxLength(49)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<VwDisablesWithLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_disables_with_labels");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Params0)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_0")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Params1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_1")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.SourceType)
                .HasMaxLength(33)
                .HasDefaultValueSql("''")
                .HasColumnName("sourceType")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<VwSmartScriptsWithLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_smart_scripts_with_labels");

            entity.Property(e => e.ActionParam1).HasColumnName("action_param1");
            entity.Property(e => e.ActionParam2).HasColumnName("action_param2");
            entity.Property(e => e.ActionParam3).HasColumnName("action_param3");
            entity.Property(e => e.ActionParam4).HasColumnName("action_param4");
            entity.Property(e => e.ActionParam5).HasColumnName("action_param5");
            entity.Property(e => e.ActionParam6).HasColumnName("action_param6");
            entity.Property(e => e.ActionType)
                .HasMaxLength(47)
                .HasDefaultValueSql("''")
                .HasColumnName("action_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Comment)
                .HasComment("Event Comment")
                .HasColumnType("mediumtext")
                .HasColumnName("comment")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Entryorguid).HasColumnName("entryorguid");
            entity.Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            entity.Property(e => e.EventParam5).HasColumnName("event_param5");
            entity.Property(e => e.EventPhaseMask).HasColumnName("event_phase_mask");
            entity.Property(e => e.EventType)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .HasColumnName("event_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.SourceType).HasColumnName("source_type");
            entity.Property(e => e.TargetO).HasColumnName("target_o");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetParam3).HasColumnName("target_param3");
            entity.Property(e => e.TargetParam4).HasColumnName("target_param4");
            entity.Property(e => e.TargetType)
                .HasMaxLength(41)
                .HasDefaultValueSql("''")
                .HasColumnName("target_type")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TargetX).HasColumnName("target_x");
            entity.Property(e => e.TargetY).HasColumnName("target_y");
            entity.Property(e => e.TargetZ).HasColumnName("target_z");
        });

        modelBuilder.Entity<WardenCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("warden_checks")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .HasColumnName("comment");
            entity.Property(e => e.Data)
                .HasMaxLength(24)
                .IsFixedLength()
                .HasColumnName("data");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Result)
                .HasMaxLength(24)
                .HasColumnName("result");
            entity.Property(e => e.Str)
                .HasMaxLength(170)
                .HasColumnName("str");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Waypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Pointid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("waypoints", tb => tb.HasComment("Creature waypoints"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Pointid).HasColumnName("pointid");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PointComment)
                .HasColumnType("mediumtext")
                .HasColumnName("point_comment");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<WaypointDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Point })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("waypoint_data")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Creature GUID")
                .HasColumnName("id");
            entity.Property(e => e.Point).HasColumnName("point");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ActionChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("action_chance");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.MoveType).HasColumnName("move_type");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Wpguid).HasColumnName("wpguid");
        });

        modelBuilder.Entity<WaypointScript>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity
                .ToTable("waypoint_scripts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");
            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
