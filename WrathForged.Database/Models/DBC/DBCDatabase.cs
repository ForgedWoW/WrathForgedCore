// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WrathForged.Database.Models.DBC;

namespace WrathForged.Database.Models.DBC;

public partial class DBCDatabase : DbContext
{
    public DBCDatabase()
    {
    }

    public DBCDatabase(DbContextOptions<DBCDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Achievement> Achievements { get; set; }

    public virtual DbSet<AchievementCategory> AchievementCategories { get; set; }

    public virtual DbSet<AchievementCriterion> AchievementCriteria { get; set; }

    public virtual DbSet<Animationdatum> Animationdata { get; set; }

    public virtual DbSet<Areagroup> Areagroups { get; set; }

    public virtual DbSet<Areapoi> Areapois { get; set; }

    public virtual DbSet<Areatable> Areatables { get; set; }

    public virtual DbSet<Areatrigger> Areatriggers { get; set; }

    public virtual DbSet<Attackanimkit> Attackanimkits { get; set; }

    public virtual DbSet<Attackanimtype> Attackanimtypes { get; set; }

    public virtual DbSet<Auctionhouse> Auctionhouses { get; set; }

    public virtual DbSet<Bankbagslotprice> Bankbagslotprices { get; set; }

    public virtual DbSet<Bannedaddon> Bannedaddons { get; set; }

    public virtual DbSet<Barbershopstyle> Barbershopstyles { get; set; }

    public virtual DbSet<Battlemasterlist> Battlemasterlists { get; set; }

    public virtual DbSet<Camerashake> Camerashakes { get; set; }

    public virtual DbSet<CfgCategory> CfgCategories { get; set; }

    public virtual DbSet<Characterfacialhairstyle> Characterfacialhairstyles { get; set; }

    public virtual DbSet<Charbaseinfo> Charbaseinfos { get; set; }

    public virtual DbSet<Charhairgeoset> Charhairgeosets { get; set; }

    public virtual DbSet<Charhairtexture> Charhairtextures { get; set; }

    public virtual DbSet<Charsection> Charsections { get; set; }

    public virtual DbSet<Charstartoutfit> Charstartoutfits { get; set; }

    public virtual DbSet<Chartitle> Chartitles { get; set; }

    public virtual DbSet<Chatchannel> Chatchannels { get; set; }

    public virtual DbSet<Chatprofanity> Chatprofanities { get; set; }

    public virtual DbSet<Chrclass> Chrclasses { get; set; }

    public virtual DbSet<Chrrace> Chrraces { get; set; }

    public virtual DbSet<Cinematiccamera> Cinematiccameras { get; set; }

    public virtual DbSet<Cinematicsequence> Cinematicsequences { get; set; }

    public virtual DbSet<Creaturedisplayinfo> Creaturedisplayinfos { get; set; }

    public virtual DbSet<Creaturedisplayinfoextra> Creaturedisplayinfoextras { get; set; }

    public virtual DbSet<Creaturefamily> Creaturefamilies { get; set; }

    public virtual DbSet<Creaturemodeldatum> Creaturemodeldata { get; set; }

    public virtual DbSet<Creaturemovementinfo> Creaturemovementinfos { get; set; }

    public virtual DbSet<Creaturesounddatum> Creaturesounddata { get; set; }

    public virtual DbSet<Creaturespelldatum> Creaturespelldata { get; set; }

    public virtual DbSet<Creaturetype> Creaturetypes { get; set; }

    public virtual DbSet<Currencycategory> Currencycategories { get; set; }

    public virtual DbSet<Currencytype> Currencytypes { get; set; }

    public virtual DbSet<Dancemove> Dancemoves { get; set; }

    public virtual DbSet<Deaththudlookup> Deaththudlookups { get; set; }

    public virtual DbSet<Declinedword> Declinedwords { get; set; }

    public virtual DbSet<Declinedwordcase> Declinedwordcases { get; set; }

    public virtual DbSet<Destructiblemodeldatum> Destructiblemodeldata { get; set; }

    public virtual DbSet<Dungeonencounter> Dungeonencounters { get; set; }

    public virtual DbSet<Dungeonmap> Dungeonmaps { get; set; }

    public virtual DbSet<Dungeonmapchunk> Dungeonmapchunks { get; set; }

    public virtual DbSet<Durabilitycost> Durabilitycosts { get; set; }

    public virtual DbSet<Durabilityquality> Durabilityqualities { get; set; }

    public virtual DbSet<Emote> Emotes { get; set; }

    public virtual DbSet<Emotestext> Emotestexts { get; set; }

    public virtual DbSet<Emotestextdatum> Emotestextdata { get; set; }

    public virtual DbSet<Emotestextsound> Emotestextsounds { get; set; }

    public virtual DbSet<Environmentaldamage> Environmentaldamages { get; set; }

    public virtual DbSet<Exhaustion> Exhaustions { get; set; }

    public virtual DbSet<Faction> Factions { get; set; }

    public virtual DbSet<Factiongroup> Factiongroups { get; set; }

    public virtual DbSet<Factiontemplate> Factiontemplates { get; set; }

    public virtual DbSet<Filedatum> Filedata { get; set; }

    public virtual DbSet<Footprinttexture> Footprinttextures { get; set; }

    public virtual DbSet<Footstepterrainlookup> Footstepterrainlookups { get; set; }

    public virtual DbSet<Gameobjectartkit> Gameobjectartkits { get; set; }

    public virtual DbSet<Gameobjectdisplayinfo> Gameobjectdisplayinfos { get; set; }

    public virtual DbSet<Gametable> Gametables { get; set; }

    public virtual DbSet<Gametip> Gametips { get; set; }

    public virtual DbSet<Gemproperty> Gemproperties { get; set; }

    public virtual DbSet<Glyphproperty> Glyphproperties { get; set; }

    public virtual DbSet<Glyphslot> Glyphslots { get; set; }

    public virtual DbSet<Gmsurveyanswer> Gmsurveyanswers { get; set; }

    public virtual DbSet<Gmsurveycurrentsurvey> Gmsurveycurrentsurveys { get; set; }

    public virtual DbSet<Gmsurveyquestion> Gmsurveyquestions { get; set; }

    public virtual DbSet<Gmsurveysurvey> Gmsurveysurveys { get; set; }

    public virtual DbSet<Gmticketcategory> Gmticketcategories { get; set; }

    public virtual DbSet<Groundeffectdoodad> Groundeffectdoodads { get; set; }

    public virtual DbSet<Groundeffecttexture> Groundeffecttextures { get; set; }

    public virtual DbSet<Gtbarbershopcostbase> Gtbarbershopcostbases { get; set; }

    public virtual DbSet<Gtchancetomeleecrit> Gtchancetomeleecrits { get; set; }

    public virtual DbSet<Gtchancetomeleecritbase> Gtchancetomeleecritbases { get; set; }

    public virtual DbSet<Gtchancetospellcrit> Gtchancetospellcrits { get; set; }

    public virtual DbSet<Gtchancetospellcritbase> Gtchancetospellcritbases { get; set; }

    public virtual DbSet<Gtcombatrating> Gtcombatratings { get; set; }

    public virtual DbSet<Gtnpcmanacostscaler> Gtnpcmanacostscalers { get; set; }

    public virtual DbSet<Gtoctclasscombatratingscalar> Gtoctclasscombatratingscalars { get; set; }

    public virtual DbSet<Gtoctregenhp> Gtoctregenhps { get; set; }

    public virtual DbSet<Gtoctregenmp> Gtoctregenmps { get; set; }

    public virtual DbSet<Gtregenhpperspt> Gtregenhpperspts { get; set; }

    public virtual DbSet<Gtregenmpperspt> Gtregenmpperspts { get; set; }

    public virtual DbSet<Helmetgeosetvisdatum> Helmetgeosetvisdata { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<Holidaydescription> Holidaydescriptions { get; set; }

    public virtual DbSet<Holidayname> Holidaynames { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Itembagfamily> Itembagfamilies { get; set; }

    public virtual DbSet<Itemclass> Itemclasses { get; set; }

    public virtual DbSet<Itemcondextcost> Itemcondextcosts { get; set; }

    public virtual DbSet<Itemdisplayinfo> Itemdisplayinfos { get; set; }

    public virtual DbSet<Itemextendedcost> Itemextendedcosts { get; set; }

    public virtual DbSet<Itemgroupsound> Itemgroupsounds { get; set; }

    public virtual DbSet<Itemlimitcategory> Itemlimitcategories { get; set; }

    public virtual DbSet<Itempetfood> Itempetfoods { get; set; }

    public virtual DbSet<Itempurchasegroup> Itempurchasegroups { get; set; }

    public virtual DbSet<Itemrandomproperty> Itemrandomproperties { get; set; }

    public virtual DbSet<Itemrandomsuffix> Itemrandomsuffixes { get; set; }

    public virtual DbSet<Itemset> Itemsets { get; set; }

    public virtual DbSet<Itemsubclass> Itemsubclasses { get; set; }

    public virtual DbSet<Itemsubclassmask> Itemsubclassmasks { get; set; }

    public virtual DbSet<Itemvisual> Itemvisuals { get; set; }

    public virtual DbSet<Itemvisualeffect> Itemvisualeffects { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Languageword> Languagewords { get; set; }

    public virtual DbSet<Lfgdungeon> Lfgdungeons { get; set; }

    public virtual DbSet<Lfgdungeonexpansion> Lfgdungeonexpansions { get; set; }

    public virtual DbSet<Lfgdungeongroup> Lfgdungeongroups { get; set; }

    public virtual DbSet<Light> Lights { get; set; }

    public virtual DbSet<Lightfloatband> Lightfloatbands { get; set; }

    public virtual DbSet<Lightintband> Lightintbands { get; set; }

    public virtual DbSet<Lightparam> Lightparams { get; set; }

    public virtual DbSet<Lightskybox> Lightskyboxes { get; set; }

    public virtual DbSet<Liquidmaterial> Liquidmaterials { get; set; }

    public virtual DbSet<Liquidtype> Liquidtypes { get; set; }

    public virtual DbSet<Loadingscreen> Loadingscreens { get; set; }

    public virtual DbSet<Loadingscreentaxispline> Loadingscreentaxisplines { get; set; }

    public virtual DbSet<Lock> Locks { get; set; }

    public virtual DbSet<Locktype> Locktypes { get; set; }

    public virtual DbSet<Mailtemplate> Mailtemplates { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Mapdifficulty> Mapdifficulties { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Moviefiledatum> Moviefiledata { get; set; }

    public virtual DbSet<Movievariation> Movievariations { get; set; }

    public virtual DbSet<Namegen> Namegens { get; set; }

    public virtual DbSet<Namesprofanity> Namesprofanities { get; set; }

    public virtual DbSet<Namesreserved> Namesreserveds { get; set; }

    public virtual DbSet<Npcsound> Npcsounds { get; set; }

    public virtual DbSet<Objecteffect> Objecteffects { get; set; }

    public virtual DbSet<Objecteffectgroup> Objecteffectgroups { get; set; }

    public virtual DbSet<Objecteffectmodifier> Objecteffectmodifiers { get; set; }

    public virtual DbSet<Objecteffectpackage> Objecteffectpackages { get; set; }

    public virtual DbSet<Objecteffectpackageelem> Objecteffectpackageelems { get; set; }

    public virtual DbSet<Overridespelldatum> Overridespelldata { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Pagetextmaterial> Pagetextmaterials { get; set; }

    public virtual DbSet<Paperdollitemframe> Paperdollitemframes { get; set; }

    public virtual DbSet<Particlecolor> Particlecolors { get; set; }

    public virtual DbSet<Petitiontype> Petitiontypes { get; set; }

    public virtual DbSet<Petpersonality> Petpersonalities { get; set; }

    public virtual DbSet<Powerdisplay> Powerdisplays { get; set; }

    public virtual DbSet<Pvpdifficulty> Pvpdifficulties { get; set; }

    public virtual DbSet<Questfactionreward> Questfactionrewards { get; set; }

    public virtual DbSet<Questinfo> Questinfos { get; set; }

    public virtual DbSet<Questsort> Questsorts { get; set; }

    public virtual DbSet<Questxp> Questxps { get; set; }

    public virtual DbSet<Randproppoint> Randproppoints { get; set; }

    public virtual DbSet<Resistance> Resistances { get; set; }

    public virtual DbSet<Scalingstatdistribution> Scalingstatdistributions { get; set; }

    public virtual DbSet<Scalingstatvalue> Scalingstatvalues { get; set; }

    public virtual DbSet<Screeneffect> Screeneffects { get; set; }

    public virtual DbSet<Servermessage> Servermessages { get; set; }

    public virtual DbSet<Sheathesoundlookup> Sheathesoundlookups { get; set; }

    public virtual DbSet<Skillcostsdatum> Skillcostsdata { get; set; }

    public virtual DbSet<Skillline> Skilllines { get; set; }

    public virtual DbSet<Skilllineability> Skilllineabilities { get; set; }

    public virtual DbSet<Skilllinecategory> Skilllinecategories { get; set; }

    public virtual DbSet<Skillraceclassinfo> Skillraceclassinfos { get; set; }

    public virtual DbSet<Skilltier> Skilltiers { get; set; }

    public virtual DbSet<Soundambience> Soundambiences { get; set; }

    public virtual DbSet<Soundemitter> Soundemitters { get; set; }

    public virtual DbSet<Soundentriesadvanced> Soundentriesadvanceds { get; set; }

    public virtual DbSet<Soundentry> Soundentries { get; set; }

    public virtual DbSet<Soundfilter> Soundfilters { get; set; }

    public virtual DbSet<Soundfilterelem> Soundfilterelems { get; set; }

    public virtual DbSet<Soundproviderpreference> Soundproviderpreferences { get; set; }

    public virtual DbSet<Soundsamplepreference> Soundsamplepreferences { get; set; }

    public virtual DbSet<Soundwatertype> Soundwatertypes { get; set; }

    public virtual DbSet<Spammessage> Spammessages { get; set; }

    public virtual DbSet<Spell> Spells { get; set; }

    public virtual DbSet<Spellcasttime> Spellcasttimes { get; set; }

    public virtual DbSet<Spellcategory> Spellcategories { get; set; }

    public virtual DbSet<Spellchaineffect> Spellchaineffects { get; set; }

    public virtual DbSet<Spelldescriptionvariable> Spelldescriptionvariables { get; set; }

    public virtual DbSet<Spelldifficulty> Spelldifficulties { get; set; }

    public virtual DbSet<Spelldispeltype> Spelldispeltypes { get; set; }

    public virtual DbSet<Spellduration> Spelldurations { get; set; }

    public virtual DbSet<Spelleffectcamerashake> Spelleffectcamerashakes { get; set; }

    public virtual DbSet<Spellfocusobject> Spellfocusobjects { get; set; }

    public virtual DbSet<Spellicon> Spellicons { get; set; }

    public virtual DbSet<Spellitemenchantment> Spellitemenchantments { get; set; }

    public virtual DbSet<Spellitemenchantmentcondition> Spellitemenchantmentconditions { get; set; }

    public virtual DbSet<Spellmechanic> Spellmechanics { get; set; }

    public virtual DbSet<Spellmissile> Spellmissiles { get; set; }

    public virtual DbSet<Spellmissilemotion> Spellmissilemotions { get; set; }

    public virtual DbSet<Spellradius> Spellradii { get; set; }

    public virtual DbSet<Spellrange> Spellranges { get; set; }

    public virtual DbSet<Spellrunecost> Spellrunecosts { get; set; }

    public virtual DbSet<Spellshapeshiftform> Spellshapeshiftforms { get; set; }

    public virtual DbSet<Spellvisual> Spellvisuals { get; set; }

    public virtual DbSet<Spellvisualeffectname> Spellvisualeffectnames { get; set; }

    public virtual DbSet<Spellvisualkit> Spellvisualkits { get; set; }

    public virtual DbSet<Spellvisualkitareamodel> Spellvisualkitareamodels { get; set; }

    public virtual DbSet<Spellvisualkitmodelattach> Spellvisualkitmodelattaches { get; set; }

    public virtual DbSet<Spellvisualprecasttransition> Spellvisualprecasttransitions { get; set; }

    public virtual DbSet<Stableslotprice> Stableslotprices { get; set; }

    public virtual DbSet<StartupString> StartupStrings { get; set; }

    public virtual DbSet<Stationery> Stationeries { get; set; }

    public virtual DbSet<Stringlookup> Stringlookups { get; set; }

    public virtual DbSet<Summonproperty> Summonproperties { get; set; }

    public virtual DbSet<Talent> Talents { get; set; }

    public virtual DbSet<Talenttab> Talenttabs { get; set; }

    public virtual DbSet<Taxinode> Taxinodes { get; set; }

    public virtual DbSet<Taxipath> Taxipaths { get; set; }

    public virtual DbSet<Taxipathnode> Taxipathnodes { get; set; }

    public virtual DbSet<Teamcontributionpoint> Teamcontributionpoints { get; set; }

    public virtual DbSet<Terraintype> Terraintypes { get; set; }

    public virtual DbSet<Terraintypesound> Terraintypesounds { get; set; }

    public virtual DbSet<Totemcategory> Totemcategories { get; set; }

    public virtual DbSet<Transportanimation> Transportanimations { get; set; }

    public virtual DbSet<Transportphysic> Transportphysics { get; set; }

    public virtual DbSet<Transportrotation> Transportrotations { get; set; }

    public virtual DbSet<Uisoundlookup> Uisoundlookups { get; set; }

    public virtual DbSet<Unitblood> Unitbloods { get; set; }

    public virtual DbSet<Unitbloodlevel> Unitbloodlevels { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Vehicleseat> Vehicleseats { get; set; }

    public virtual DbSet<Vehicleuiindicator> Vehicleuiindicators { get; set; }

    public virtual DbSet<Vehicleuiindseat> Vehicleuiindseats { get; set; }

    public virtual DbSet<Videohardware> Videohardwares { get; set; }

    public virtual DbSet<Vocaluisound> Vocaluisounds { get; set; }

    public virtual DbSet<Weaponimpactsound> Weaponimpactsounds { get; set; }

    public virtual DbSet<Weaponswingsounds2> Weaponswingsounds2s { get; set; }

    public virtual DbSet<Weather> Weathers { get; set; }

    public virtual DbSet<Wmoareatable> Wmoareatables { get; set; }

    public virtual DbSet<Worldmaparea> Worldmapareas { get; set; }

    public virtual DbSet<Worldmapcontinent> Worldmapcontinents { get; set; }

    public virtual DbSet<Worldmapoverlay> Worldmapoverlays { get; set; }

    public virtual DbSet<Worldmaptransform> Worldmaptransforms { get; set; }

    public virtual DbSet<Worldsafeloc> Worldsafelocs { get; set; }

    public virtual DbSet<Worldstateui> Worldstateuis { get; set; }

    public virtual DbSet<Worldstatezonesound> Worldstatezonesounds { get; set; }

    public virtual DbSet<WowerrorString> WowerrorStrings { get; set; }

    public virtual DbSet<Zoneintromusictable> Zoneintromusictables { get; set; }

    public virtual DbSet<Zonemusic> Zonemusics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Achievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Category, "Category");

            entity.HasIndex(e => e.IconId, "IconID");

            entity.HasIndex(e => e.InstanceId, "Instance_Id");

            entity.HasIndex(e => e.SharesCriteria, "Shares_Criteria");

            entity.HasIndex(e => e.Supercedes, "Supercedes");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.IconId).HasColumnName("IconID");
            entity.Property(e => e.InstanceId).HasColumnName("Instance_Id");
            entity.Property(e => e.MinimumCriteria).HasColumnName("Minimum_Criteria");
            entity.Property(e => e.RewardLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_deDE");
            entity.Property(e => e.RewardLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_enCN");
            entity.Property(e => e.RewardLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_enGB");
            entity.Property(e => e.RewardLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_enTW");
            entity.Property(e => e.RewardLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_enUS");
            entity.Property(e => e.RewardLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_esES");
            entity.Property(e => e.RewardLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_esMX");
            entity.Property(e => e.RewardLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_frFR");
            entity.Property(e => e.RewardLangItIt)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_itIT");
            entity.Property(e => e.RewardLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_koKR");
            entity.Property(e => e.RewardLangMask).HasColumnName("Reward_Lang_Mask");
            entity.Property(e => e.RewardLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_ptBR");
            entity.Property(e => e.RewardLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_ptPT");
            entity.Property(e => e.RewardLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_ruRU");
            entity.Property(e => e.RewardLangUnk)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_Unk");
            entity.Property(e => e.RewardLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_zhCN");
            entity.Property(e => e.RewardLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Reward_Lang_zhTW");
            entity.Property(e => e.SharesCriteria).HasColumnName("Shares_Criteria");
            entity.Property(e => e.TitleLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_deDE");
            entity.Property(e => e.TitleLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_enCN");
            entity.Property(e => e.TitleLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_enGB");
            entity.Property(e => e.TitleLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_enTW");
            entity.Property(e => e.TitleLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_enUS");
            entity.Property(e => e.TitleLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_esES");
            entity.Property(e => e.TitleLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_esMX");
            entity.Property(e => e.TitleLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_frFR");
            entity.Property(e => e.TitleLangItIt)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_itIT");
            entity.Property(e => e.TitleLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_koKR");
            entity.Property(e => e.TitleLangMask).HasColumnName("Title_Lang_Mask");
            entity.Property(e => e.TitleLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_ptBR");
            entity.Property(e => e.TitleLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_ptPT");
            entity.Property(e => e.TitleLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_ruRU");
            entity.Property(e => e.TitleLangUnk)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_Unk");
            entity.Property(e => e.TitleLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_zhCN");
            entity.Property(e => e.TitleLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Title_Lang_zhTW");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Achievements)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("achievement_ibfk_13");

            entity.HasOne(d => d.Icon).WithMany(p => p.Achievements)
                .HasForeignKey(d => d.IconId)
                .HasConstraintName("achievement_ibfk_14");

            entity.HasOne(d => d.Instance).WithMany(p => p.Achievements)
                .HasForeignKey(d => d.InstanceId)
                .HasConstraintName("achievement_ibfk_1");

            entity.HasOne(d => d.SharesCriteriaNavigation).WithMany(p => p.InverseSharesCriteriaNavigation)
                .HasForeignKey(d => d.SharesCriteria)
                .HasConstraintName("achievement_ibfk_10");

            entity.HasOne(d => d.SupercedesNavigation).WithMany(p => p.InverseSupercedesNavigation)
                .HasForeignKey(d => d.Supercedes)
                .HasConstraintName("achievement_ibfk_12");
        });

        modelBuilder.Entity<AchievementCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement_category")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Parent, "Parent");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation)
                .HasForeignKey(d => d.Parent)
                .HasConstraintName("achievement_category_ibfk_1");
        });

        modelBuilder.Entity<AchievementCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("achievement_criteria")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AchievementId, "Achievement_Id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AchievementId).HasColumnName("Achievement_Id");
            entity.Property(e => e.AssetId).HasColumnName("Asset_Id");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.FailAsset).HasColumnName("Fail_Asset");
            entity.Property(e => e.FailEvent).HasColumnName("Fail_Event");
            entity.Property(e => e.StartAsset).HasColumnName("Start_Asset");
            entity.Property(e => e.StartEvent).HasColumnName("Start_Event");
            entity.Property(e => e.TimerAssetId).HasColumnName("Timer_Asset_Id");
            entity.Property(e => e.TimerStartEvent).HasColumnName("Timer_Start_Event");
            entity.Property(e => e.TimerTime).HasColumnName("Timer_Time");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");

            entity.HasOne(d => d.Achievement).WithMany(p => p.AchievementCriteria)
                .HasForeignKey(d => d.AchievementId)
                .HasConstraintName("achievement_criteria_ibfk_1");
        });

        modelBuilder.Entity<Animationdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("animationdata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BehaviorId).HasColumnName("BehaviorID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Areagroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areagroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId1, "AreaID_1");

            entity.HasIndex(e => e.AreaId2, "AreaID_2");

            entity.HasIndex(e => e.AreaId3, "AreaID_3");

            entity.HasIndex(e => e.AreaId4, "AreaID_4");

            entity.HasIndex(e => e.AreaId5, "AreaID_5");

            entity.HasIndex(e => e.AreaId6, "AreaID_6");

            entity.HasIndex(e => e.NextAreaId, "NextAreaID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId1).HasColumnName("AreaID_1");
            entity.Property(e => e.AreaId2).HasColumnName("AreaID_2");
            entity.Property(e => e.AreaId3).HasColumnName("AreaID_3");
            entity.Property(e => e.AreaId4).HasColumnName("AreaID_4");
            entity.Property(e => e.AreaId5).HasColumnName("AreaID_5");
            entity.Property(e => e.AreaId6).HasColumnName("AreaID_6");
            entity.Property(e => e.NextAreaId).HasColumnName("NextAreaID");

            entity.HasOne(d => d.AreaId1Navigation).WithMany(p => p.AreagroupAreaId1Navigations)
                .HasForeignKey(d => d.AreaId1)
                .HasConstraintName("areagroup_ibfk_1");

            entity.HasOne(d => d.AreaId2Navigation).WithMany(p => p.AreagroupAreaId2Navigations)
                .HasForeignKey(d => d.AreaId2)
                .HasConstraintName("areagroup_ibfk_16");

            entity.HasOne(d => d.AreaId3Navigation).WithMany(p => p.AreagroupAreaId3Navigations)
                .HasForeignKey(d => d.AreaId3)
                .HasConstraintName("areagroup_ibfk_10");

            entity.HasOne(d => d.AreaId4Navigation).WithMany(p => p.AreagroupAreaId4Navigations)
                .HasForeignKey(d => d.AreaId4)
                .HasConstraintName("areagroup_ibfk_11");

            entity.HasOne(d => d.AreaId5Navigation).WithMany(p => p.AreagroupAreaId5Navigations)
                .HasForeignKey(d => d.AreaId5)
                .HasConstraintName("areagroup_ibfk_12");

            entity.HasOne(d => d.AreaId6Navigation).WithMany(p => p.AreagroupAreaId6Navigations)
                .HasForeignKey(d => d.AreaId6)
                .HasConstraintName("areagroup_ibfk_13");

            entity.HasOne(d => d.NextArea).WithMany(p => p.InverseNextArea)
                .HasForeignKey(d => d.NextAreaId)
                .HasConstraintName("areagroup_ibfk_14");
        });

        modelBuilder.Entity<Areapoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areapoi")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId, "AreaID");

            entity.HasIndex(e => e.FactionId, "FactionID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.Icon1).HasColumnName("Icon_1");
            entity.Property(e => e.Icon2).HasColumnName("Icon_2");
            entity.Property(e => e.Icon3).HasColumnName("Icon_3");
            entity.Property(e => e.Icon4).HasColumnName("Icon_4");
            entity.Property(e => e.Icon5).HasColumnName("Icon_5");
            entity.Property(e => e.Icon6).HasColumnName("Icon_6");
            entity.Property(e => e.Icon7).HasColumnName("Icon_7");
            entity.Property(e => e.Icon8).HasColumnName("Icon_8");
            entity.Property(e => e.Icon9).HasColumnName("Icon_9");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.WorldStateId).HasColumnName("WorldStateID");

            entity.HasOne(d => d.Area).WithMany(p => p.Areapois)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("areapoi_ibfk_2");

            entity.HasOne(d => d.Faction).WithMany(p => p.Areapois)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("areapoi_ibfk_1");
        });

        modelBuilder.Entity<Areatable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areatable")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AmbienceId, "AmbienceID");

            entity.HasIndex(e => e.ContinentId, "ContinentID");

            entity.HasIndex(e => e.IntroSound, "IntroSound");

            entity.HasIndex(e => e.Lightid, "Lightid");

            entity.HasIndex(e => e.LiquidTypeId1, "LiquidTypeID_1");

            entity.HasIndex(e => e.LiquidTypeId2, "LiquidTypeID_2");

            entity.HasIndex(e => e.LiquidTypeId3, "LiquidTypeID_3");

            entity.HasIndex(e => e.LiquidTypeId4, "LiquidTypeID_4");

            entity.HasIndex(e => e.ParentAreaId, "ParentAreaID");

            entity.HasIndex(e => e.SoundProviderPref, "SoundProviderPref");

            entity.HasIndex(e => e.SoundProviderPrefUnderwater, "SoundProviderPrefUnderwater");

            entity.HasIndex(e => e.ZoneMusic, "ZoneMusic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AmbienceId).HasColumnName("AmbienceID");
            entity.Property(e => e.AmbientMultiplier).HasColumnName("Ambient_Multiplier");
            entity.Property(e => e.AreaNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_deDE");
            entity.Property(e => e.AreaNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enCN");
            entity.Property(e => e.AreaNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enGB");
            entity.Property(e => e.AreaNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enTW");
            entity.Property(e => e.AreaNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enUS");
            entity.Property(e => e.AreaNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esES");
            entity.Property(e => e.AreaNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esMX");
            entity.Property(e => e.AreaNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_frFR");
            entity.Property(e => e.AreaNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_itIT");
            entity.Property(e => e.AreaNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_koKR");
            entity.Property(e => e.AreaNameLangMask).HasColumnName("AreaName_Lang_Mask");
            entity.Property(e => e.AreaNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptBR");
            entity.Property(e => e.AreaNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptPT");
            entity.Property(e => e.AreaNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ruRU");
            entity.Property(e => e.AreaNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_Unk");
            entity.Property(e => e.AreaNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhCN");
            entity.Property(e => e.AreaNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhTW");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.LiquidTypeId1).HasColumnName("LiquidTypeID_1");
            entity.Property(e => e.LiquidTypeId2).HasColumnName("LiquidTypeID_2");
            entity.Property(e => e.LiquidTypeId3).HasColumnName("LiquidTypeID_3");
            entity.Property(e => e.LiquidTypeId4).HasColumnName("LiquidTypeID_4");
            entity.Property(e => e.ParentAreaId).HasColumnName("ParentAreaID");

            entity.HasOne(d => d.Ambience).WithMany(p => p.Areatables)
                .HasForeignKey(d => d.AmbienceId)
                .HasConstraintName("areatable_ibfk_17");

            entity.HasOne(d => d.Continent).WithMany(p => p.Areatables)
                .HasForeignKey(d => d.ContinentId)
                .HasConstraintName("areatable_ibfk_1");

            entity.HasOne(d => d.IntroSoundNavigation).WithMany(p => p.Areatables)
                .HasForeignKey(d => d.IntroSound)
                .HasConstraintName("areatable_ibfk_19");

            entity.HasOne(d => d.Light).WithMany(p => p.Areatables)
                .HasForeignKey(d => d.Lightid)
                .HasConstraintName("areatable_ibfk_12");

            entity.HasOne(d => d.LiquidTypeId1Navigation).WithMany(p => p.AreatableLiquidTypeId1Navigations)
                .HasForeignKey(d => d.LiquidTypeId1)
                .HasConstraintName("areatable_ibfk_20");

            entity.HasOne(d => d.LiquidTypeId2Navigation).WithMany(p => p.AreatableLiquidTypeId2Navigations)
                .HasForeignKey(d => d.LiquidTypeId2)
                .HasConstraintName("areatable_ibfk_21");

            entity.HasOne(d => d.LiquidTypeId3Navigation).WithMany(p => p.AreatableLiquidTypeId3Navigations)
                .HasForeignKey(d => d.LiquidTypeId3)
                .HasConstraintName("areatable_ibfk_10");

            entity.HasOne(d => d.LiquidTypeId4Navigation).WithMany(p => p.AreatableLiquidTypeId4Navigations)
                .HasForeignKey(d => d.LiquidTypeId4)
                .HasConstraintName("areatable_ibfk_11");

            entity.HasOne(d => d.ParentArea).WithMany(p => p.InverseParentArea)
                .HasForeignKey(d => d.ParentAreaId)
                .HasConstraintName("areatable_ibfk_14");

            entity.HasOne(d => d.SoundProviderPrefNavigation).WithMany(p => p.AreatableSoundProviderPrefNavigations)
                .HasForeignKey(d => d.SoundProviderPref)
                .HasConstraintName("areatable_ibfk_15");

            entity.HasOne(d => d.SoundProviderPrefUnderwaterNavigation).WithMany(p => p.AreatableSoundProviderPrefUnderwaterNavigations)
                .HasForeignKey(d => d.SoundProviderPrefUnderwater)
                .HasConstraintName("areatable_ibfk_16");

            entity.HasOne(d => d.ZoneMusicNavigation).WithMany(p => p.Areatables)
                .HasForeignKey(d => d.ZoneMusic)
                .HasConstraintName("areatable_ibfk_18");
        });

        modelBuilder.Entity<Areatrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("areatrigger")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ContinentId, "ContinentID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BoxHeight).HasColumnName("Box_Height");
            entity.Property(e => e.BoxLength).HasColumnName("Box_Length");
            entity.Property(e => e.BoxWidth).HasColumnName("Box_Width");
            entity.Property(e => e.BoxYaw).HasColumnName("Box_Yaw");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");

            entity.HasOne(d => d.Continent).WithMany(p => p.Areatriggers)
                .HasForeignKey(d => d.ContinentId)
                .HasConstraintName("areatrigger_ibfk_1");
        });

        modelBuilder.Entity<Attackanimkit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attackanimkits")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Animation, "Animation");

            entity.HasIndex(e => e.Type, "Type");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.HasOne(d => d.AnimationNavigation).WithMany(p => p.Attackanimkits)
                .HasForeignKey(d => d.Animation)
                .HasConstraintName("attackanimkits_ibfk_1");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Attackanimkits)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("attackanimkits_ibfk_2");
        });

        modelBuilder.Entity<Attackanimtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attackanimtypes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Auctionhouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("auctionhouse")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FactionId, "FactionID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.Faction).WithMany(p => p.Auctionhouses)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("auctionhouse_ibfk_1");
        });

        modelBuilder.Entity<Bankbagslotprice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bankbagslotprices")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Bannedaddon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("bannedaddons")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameMd51).HasColumnName("NameMD5__1");
            entity.Property(e => e.NameMd52).HasColumnName("NameMD5__2");
            entity.Property(e => e.NameMd53).HasColumnName("NameMD5__3");
            entity.Property(e => e.NameMd54).HasColumnName("NameMD5__4");
            entity.Property(e => e.VersionMd51).HasColumnName("VersionMD5__1");
            entity.Property(e => e.VersionMd52).HasColumnName("VersionMD5__2");
            entity.Property(e => e.VersionMd53).HasColumnName("VersionMD5__3");
            entity.Property(e => e.VersionMd54).HasColumnName("VersionMD5__4");
        });

        modelBuilder.Entity<Barbershopstyle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("barbershopstyle")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CostModifier).HasColumnName("Cost_Modifier");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.DisplayNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_deDE");
            entity.Property(e => e.DisplayNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enCN");
            entity.Property(e => e.DisplayNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enGB");
            entity.Property(e => e.DisplayNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enTW");
            entity.Property(e => e.DisplayNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enUS");
            entity.Property(e => e.DisplayNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esES");
            entity.Property(e => e.DisplayNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esMX");
            entity.Property(e => e.DisplayNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_frFR");
            entity.Property(e => e.DisplayNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_itIT");
            entity.Property(e => e.DisplayNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity.Property(e => e.DisplayNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptBR");
            entity.Property(e => e.DisplayNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptPT");
            entity.Property(e => e.DisplayNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ruRU");
            entity.Property(e => e.DisplayNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_Unk");
            entity.Property(e => e.DisplayNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhCN");
            entity.Property(e => e.DisplayNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhTW");
        });

        modelBuilder.Entity<Battlemasterlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("battlemasterlist")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId1, "MapID_1");

            entity.HasIndex(e => e.MapId2, "MapID_2");

            entity.HasIndex(e => e.MapId3, "MapID_3");

            entity.HasIndex(e => e.MapId4, "MapID_4");

            entity.HasIndex(e => e.MapId5, "MapID_5");

            entity.HasIndex(e => e.MapId6, "MapID_6");

            entity.HasIndex(e => e.MapId7, "MapID_7");

            entity.HasIndex(e => e.MapId8, "MapID_8");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId1).HasColumnName("MapID_1");
            entity.Property(e => e.MapId2).HasColumnName("MapID_2");
            entity.Property(e => e.MapId3).HasColumnName("MapID_3");
            entity.Property(e => e.MapId4).HasColumnName("MapID_4");
            entity.Property(e => e.MapId5).HasColumnName("MapID_5");
            entity.Property(e => e.MapId6).HasColumnName("MapID_6");
            entity.Property(e => e.MapId7).HasColumnName("MapID_7");
            entity.Property(e => e.MapId8).HasColumnName("MapID_8");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.MapId1Navigation).WithMany(p => p.BattlemasterlistMapId1Navigations)
                .HasForeignKey(d => d.MapId1)
                .HasConstraintName("battlemasterlist_ibfk_1");

            entity.HasOne(d => d.MapId2Navigation).WithMany(p => p.BattlemasterlistMapId2Navigations)
                .HasForeignKey(d => d.MapId2)
                .HasConstraintName("battlemasterlist_ibfk_10");

            entity.HasOne(d => d.MapId3Navigation).WithMany(p => p.BattlemasterlistMapId3Navigations)
                .HasForeignKey(d => d.MapId3)
                .HasConstraintName("battlemasterlist_ibfk_11");

            entity.HasOne(d => d.MapId4Navigation).WithMany(p => p.BattlemasterlistMapId4Navigations)
                .HasForeignKey(d => d.MapId4)
                .HasConstraintName("battlemasterlist_ibfk_12");

            entity.HasOne(d => d.MapId5Navigation).WithMany(p => p.BattlemasterlistMapId5Navigations)
                .HasForeignKey(d => d.MapId5)
                .HasConstraintName("battlemasterlist_ibfk_13");

            entity.HasOne(d => d.MapId6Navigation).WithMany(p => p.BattlemasterlistMapId6Navigations)
                .HasForeignKey(d => d.MapId6)
                .HasConstraintName("battlemasterlist_ibfk_14");

            entity.HasOne(d => d.MapId7Navigation).WithMany(p => p.BattlemasterlistMapId7Navigations)
                .HasForeignKey(d => d.MapId7)
                .HasConstraintName("battlemasterlist_ibfk_15");

            entity.HasOne(d => d.MapId8Navigation).WithMany(p => p.BattlemasterlistMapId8Navigations)
                .HasForeignKey(d => d.MapId8)
                .HasConstraintName("battlemasterlist_ibfk_16");
        });

        modelBuilder.Entity<Camerashake>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("camerashakes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<CfgCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cfg_categories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Characterfacialhairstyle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("characterfacialhairstyles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Geoset1).HasColumnName("Geoset_1");
            entity.Property(e => e.Geoset2).HasColumnName("Geoset_2");
            entity.Property(e => e.Geoset3).HasColumnName("Geoset_3");
            entity.Property(e => e.Geoset4).HasColumnName("Geoset_4");
            entity.Property(e => e.Geoset5).HasColumnName("Geoset_5");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");
            entity.Property(e => e.VariationId).HasColumnName("VariationID");
        });

        modelBuilder.Entity<Charbaseinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charbaseinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ClassId, "ClassID");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");

            entity.HasOne(d => d.Class).WithMany(p => p.Charbaseinfos)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("charbaseinfo_ibfk_2");

            entity.HasOne(d => d.Race).WithMany(p => p.Charbaseinfos)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("charbaseinfo_ibfk_1");
        });

        modelBuilder.Entity<Charhairgeoset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charhairgeosets")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GeosetId).HasColumnName("GeosetID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");
            entity.Property(e => e.VariationId).HasColumnName("VariationID");

            entity.HasOne(d => d.Race).WithMany(p => p.Charhairgeosets)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("charhairgeosets_ibfk_1");
        });

        modelBuilder.Entity<Charhairtexture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charhairtextures")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Race, "Race");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Field041).HasColumnName("Field04_1");
            entity.Property(e => e.Field042).HasColumnName("Field04_2");
            entity.Property(e => e.Field043).HasColumnName("Field04_3");
            entity.Property(e => e.Field044).HasColumnName("Field04_4");

            entity.HasOne(d => d.RaceNavigation).WithMany(p => p.Charhairtextures)
                .HasForeignKey(d => d.Race)
                .HasConstraintName("charhairtextures_ibfk_1");
        });

        modelBuilder.Entity<Charsection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charsections")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");
            entity.Property(e => e.TextureName1)
                .HasColumnType("text")
                .HasColumnName("TextureName_1");
            entity.Property(e => e.TextureName2)
                .HasColumnType("text")
                .HasColumnName("TextureName_2");
            entity.Property(e => e.TextureName3)
                .HasColumnType("text")
                .HasColumnName("TextureName_3");

            entity.HasOne(d => d.Race).WithMany(p => p.Charsections)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("charsections_ibfk_1");
        });

        modelBuilder.Entity<Charstartoutfit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("charstartoutfit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ClassId, "ClassID");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DisplayItemId1).HasColumnName("DisplayItemID_1");
            entity.Property(e => e.DisplayItemId10).HasColumnName("DisplayItemID_10");
            entity.Property(e => e.DisplayItemId11).HasColumnName("DisplayItemID_11");
            entity.Property(e => e.DisplayItemId12).HasColumnName("DisplayItemID_12");
            entity.Property(e => e.DisplayItemId13).HasColumnName("DisplayItemID_13");
            entity.Property(e => e.DisplayItemId14).HasColumnName("DisplayItemID_14");
            entity.Property(e => e.DisplayItemId15).HasColumnName("DisplayItemID_15");
            entity.Property(e => e.DisplayItemId16).HasColumnName("DisplayItemID_16");
            entity.Property(e => e.DisplayItemId17).HasColumnName("DisplayItemID_17");
            entity.Property(e => e.DisplayItemId18).HasColumnName("DisplayItemID_18");
            entity.Property(e => e.DisplayItemId19).HasColumnName("DisplayItemID_19");
            entity.Property(e => e.DisplayItemId2).HasColumnName("DisplayItemID_2");
            entity.Property(e => e.DisplayItemId20).HasColumnName("DisplayItemID_20");
            entity.Property(e => e.DisplayItemId21).HasColumnName("DisplayItemID_21");
            entity.Property(e => e.DisplayItemId22).HasColumnName("DisplayItemID_22");
            entity.Property(e => e.DisplayItemId23).HasColumnName("DisplayItemID_23");
            entity.Property(e => e.DisplayItemId24).HasColumnName("DisplayItemID_24");
            entity.Property(e => e.DisplayItemId3).HasColumnName("DisplayItemID_3");
            entity.Property(e => e.DisplayItemId4).HasColumnName("DisplayItemID_4");
            entity.Property(e => e.DisplayItemId5).HasColumnName("DisplayItemID_5");
            entity.Property(e => e.DisplayItemId6).HasColumnName("DisplayItemID_6");
            entity.Property(e => e.DisplayItemId7).HasColumnName("DisplayItemID_7");
            entity.Property(e => e.DisplayItemId8).HasColumnName("DisplayItemID_8");
            entity.Property(e => e.DisplayItemId9).HasColumnName("DisplayItemID_9");
            entity.Property(e => e.InventoryType1).HasColumnName("InventoryType_1");
            entity.Property(e => e.InventoryType10).HasColumnName("InventoryType_10");
            entity.Property(e => e.InventoryType11).HasColumnName("InventoryType_11");
            entity.Property(e => e.InventoryType12).HasColumnName("InventoryType_12");
            entity.Property(e => e.InventoryType13).HasColumnName("InventoryType_13");
            entity.Property(e => e.InventoryType14).HasColumnName("InventoryType_14");
            entity.Property(e => e.InventoryType15).HasColumnName("InventoryType_15");
            entity.Property(e => e.InventoryType16).HasColumnName("InventoryType_16");
            entity.Property(e => e.InventoryType17).HasColumnName("InventoryType_17");
            entity.Property(e => e.InventoryType18).HasColumnName("InventoryType_18");
            entity.Property(e => e.InventoryType19).HasColumnName("InventoryType_19");
            entity.Property(e => e.InventoryType2).HasColumnName("InventoryType_2");
            entity.Property(e => e.InventoryType20).HasColumnName("InventoryType_20");
            entity.Property(e => e.InventoryType21).HasColumnName("InventoryType_21");
            entity.Property(e => e.InventoryType22).HasColumnName("InventoryType_22");
            entity.Property(e => e.InventoryType23).HasColumnName("InventoryType_23");
            entity.Property(e => e.InventoryType24).HasColumnName("InventoryType_24");
            entity.Property(e => e.InventoryType3).HasColumnName("InventoryType_3");
            entity.Property(e => e.InventoryType4).HasColumnName("InventoryType_4");
            entity.Property(e => e.InventoryType5).HasColumnName("InventoryType_5");
            entity.Property(e => e.InventoryType6).HasColumnName("InventoryType_6");
            entity.Property(e => e.InventoryType7).HasColumnName("InventoryType_7");
            entity.Property(e => e.InventoryType8).HasColumnName("InventoryType_8");
            entity.Property(e => e.InventoryType9).HasColumnName("InventoryType_9");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId10).HasColumnName("ItemID_10");
            entity.Property(e => e.ItemId11).HasColumnName("ItemID_11");
            entity.Property(e => e.ItemId12).HasColumnName("ItemID_12");
            entity.Property(e => e.ItemId13).HasColumnName("ItemID_13");
            entity.Property(e => e.ItemId14).HasColumnName("ItemID_14");
            entity.Property(e => e.ItemId15).HasColumnName("ItemID_15");
            entity.Property(e => e.ItemId16).HasColumnName("ItemID_16");
            entity.Property(e => e.ItemId17).HasColumnName("ItemID_17");
            entity.Property(e => e.ItemId18).HasColumnName("ItemID_18");
            entity.Property(e => e.ItemId19).HasColumnName("ItemID_19");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId20).HasColumnName("ItemID_20");
            entity.Property(e => e.ItemId21).HasColumnName("ItemID_21");
            entity.Property(e => e.ItemId22).HasColumnName("ItemID_22");
            entity.Property(e => e.ItemId23).HasColumnName("ItemID_23");
            entity.Property(e => e.ItemId24).HasColumnName("ItemID_24");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
            entity.Property(e => e.ItemId6).HasColumnName("ItemID_6");
            entity.Property(e => e.ItemId7).HasColumnName("ItemID_7");
            entity.Property(e => e.ItemId8).HasColumnName("ItemID_8");
            entity.Property(e => e.ItemId9).HasColumnName("ItemID_9");
            entity.Property(e => e.OutfitId).HasColumnName("OutfitID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");

            entity.HasOne(d => d.Class).WithMany(p => p.Charstartoutfits)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("charstartoutfit_ibfk_2");

            entity.HasOne(d => d.Race).WithMany(p => p.Charstartoutfits)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("charstartoutfit_ibfk_1");
        });

        modelBuilder.Entity<Chartitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("chartitles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ConditionId).HasColumnName("Condition_ID");
            entity.Property(e => e.MaskId).HasColumnName("Mask_ID");
            entity.Property(e => e.Name1LangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_deDE");
            entity.Property(e => e.Name1LangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_enCN");
            entity.Property(e => e.Name1LangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_enGB");
            entity.Property(e => e.Name1LangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_enTW");
            entity.Property(e => e.Name1LangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_enUS");
            entity.Property(e => e.Name1LangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_esES");
            entity.Property(e => e.Name1LangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_esMX");
            entity.Property(e => e.Name1LangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_frFR");
            entity.Property(e => e.Name1LangItIt)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_itIT");
            entity.Property(e => e.Name1LangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_koKR");
            entity.Property(e => e.Name1LangMask).HasColumnName("Name1_Lang_Mask");
            entity.Property(e => e.Name1LangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_ptBR");
            entity.Property(e => e.Name1LangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_ptPT");
            entity.Property(e => e.Name1LangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_ruRU");
            entity.Property(e => e.Name1LangUnk)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_Unk");
            entity.Property(e => e.Name1LangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_zhCN");
            entity.Property(e => e.Name1LangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name1_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Chatchannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("chatchannels")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FactionGroup, "FactionGroup");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.ShortcutLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_deDE");
            entity.Property(e => e.ShortcutLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_enCN");
            entity.Property(e => e.ShortcutLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_enGB");
            entity.Property(e => e.ShortcutLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_enTW");
            entity.Property(e => e.ShortcutLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_enUS");
            entity.Property(e => e.ShortcutLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_esES");
            entity.Property(e => e.ShortcutLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_esMX");
            entity.Property(e => e.ShortcutLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_frFR");
            entity.Property(e => e.ShortcutLangItIt)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_itIT");
            entity.Property(e => e.ShortcutLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_koKR");
            entity.Property(e => e.ShortcutLangMask).HasColumnName("Shortcut_Lang_Mask");
            entity.Property(e => e.ShortcutLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_ptBR");
            entity.Property(e => e.ShortcutLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_ptPT");
            entity.Property(e => e.ShortcutLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_ruRU");
            entity.Property(e => e.ShortcutLangUnk)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_Unk");
            entity.Property(e => e.ShortcutLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_zhCN");
            entity.Property(e => e.ShortcutLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Shortcut_Lang_zhTW");

            entity.HasOne(d => d.FactionGroupNavigation).WithMany(p => p.Chatchannels)
                .HasForeignKey(d => d.FactionGroup)
                .HasConstraintName("chatchannels_ibfk_1");
        });

        modelBuilder.Entity<Chatprofanity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("chatprofanity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<Chrclass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("chrclasses")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CinematicSequenceId, "CinematicSequenceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CinematicSequenceId).HasColumnName("CinematicSequenceID");
            entity.Property(e => e.Filename).HasColumnType("text");
            entity.Property(e => e.NameFemaleLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_deDE");
            entity.Property(e => e.NameFemaleLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enCN");
            entity.Property(e => e.NameFemaleLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enGB");
            entity.Property(e => e.NameFemaleLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enTW");
            entity.Property(e => e.NameFemaleLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enUS");
            entity.Property(e => e.NameFemaleLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_esES");
            entity.Property(e => e.NameFemaleLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_esMX");
            entity.Property(e => e.NameFemaleLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_frFR");
            entity.Property(e => e.NameFemaleLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_itIT");
            entity.Property(e => e.NameFemaleLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_koKR");
            entity.Property(e => e.NameFemaleLangMask).HasColumnName("Name_Female_Lang_Mask");
            entity.Property(e => e.NameFemaleLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ptBR");
            entity.Property(e => e.NameFemaleLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ptPT");
            entity.Property(e => e.NameFemaleLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ruRU");
            entity.Property(e => e.NameFemaleLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_Unk");
            entity.Property(e => e.NameFemaleLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_zhCN");
            entity.Property(e => e.NameFemaleLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.NameMaleLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_deDE");
            entity.Property(e => e.NameMaleLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enCN");
            entity.Property(e => e.NameMaleLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enGB");
            entity.Property(e => e.NameMaleLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enTW");
            entity.Property(e => e.NameMaleLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enUS");
            entity.Property(e => e.NameMaleLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_esES");
            entity.Property(e => e.NameMaleLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_esMX");
            entity.Property(e => e.NameMaleLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_frFR");
            entity.Property(e => e.NameMaleLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_itIT");
            entity.Property(e => e.NameMaleLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_koKR");
            entity.Property(e => e.NameMaleLangMask).HasColumnName("Name_Male_Lang_Mask");
            entity.Property(e => e.NameMaleLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ptBR");
            entity.Property(e => e.NameMaleLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ptPT");
            entity.Property(e => e.NameMaleLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ruRU");
            entity.Property(e => e.NameMaleLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_Unk");
            entity.Property(e => e.NameMaleLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_zhCN");
            entity.Property(e => e.NameMaleLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_zhTW");
            entity.Property(e => e.RequiredExpansion).HasColumnName("Required_Expansion");

            entity.HasOne(d => d.CinematicSequence).WithMany(p => p.Chrclasses)
                .HasForeignKey(d => d.CinematicSequenceId)
                .HasConstraintName("chrclasses_ibfk_1");
        });

        modelBuilder.Entity<Chrrace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("chrraces")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CinematicSequenceId, "CinematicSequenceID");

            entity.HasIndex(e => e.CreatureType, "CreatureType");

            entity.HasIndex(e => e.ExplorationSoundId, "ExplorationSoundID");

            entity.HasIndex(e => e.FactionId, "FactionID");

            entity.HasIndex(e => e.FemaleDisplayId, "FemaleDisplayId");

            entity.HasIndex(e => e.MaleDisplayId, "MaleDisplayId");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CinematicSequenceId).HasColumnName("CinematicSequenceID");
            entity.Property(e => e.ClientFilestring).HasColumnType("text");
            entity.Property(e => e.ClientPrefix).HasColumnType("text");
            entity.Property(e => e.ExplorationSoundId).HasColumnName("ExplorationSoundID");
            entity.Property(e => e.FacialHairCustomization1)
                .HasColumnType("text")
                .HasColumnName("FacialHairCustomization_1");
            entity.Property(e => e.FacialHairCustomization2)
                .HasColumnType("text")
                .HasColumnName("FacialHairCustomization_2");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.HairCustomization).HasColumnType("text");
            entity.Property(e => e.NameFemaleLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_deDE");
            entity.Property(e => e.NameFemaleLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enCN");
            entity.Property(e => e.NameFemaleLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enGB");
            entity.Property(e => e.NameFemaleLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enTW");
            entity.Property(e => e.NameFemaleLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_enUS");
            entity.Property(e => e.NameFemaleLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_esES");
            entity.Property(e => e.NameFemaleLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_esMX");
            entity.Property(e => e.NameFemaleLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_frFR");
            entity.Property(e => e.NameFemaleLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_itIT");
            entity.Property(e => e.NameFemaleLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_koKR");
            entity.Property(e => e.NameFemaleLangMask).HasColumnName("Name_Female_Lang_Mask");
            entity.Property(e => e.NameFemaleLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ptBR");
            entity.Property(e => e.NameFemaleLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ptPT");
            entity.Property(e => e.NameFemaleLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_ruRU");
            entity.Property(e => e.NameFemaleLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_Unk");
            entity.Property(e => e.NameFemaleLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_zhCN");
            entity.Property(e => e.NameFemaleLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Female_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.NameMaleLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_deDE");
            entity.Property(e => e.NameMaleLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enCN");
            entity.Property(e => e.NameMaleLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enGB");
            entity.Property(e => e.NameMaleLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enTW");
            entity.Property(e => e.NameMaleLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_enUS");
            entity.Property(e => e.NameMaleLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_esES");
            entity.Property(e => e.NameMaleLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_esMX");
            entity.Property(e => e.NameMaleLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_frFR");
            entity.Property(e => e.NameMaleLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_itIT");
            entity.Property(e => e.NameMaleLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_koKR");
            entity.Property(e => e.NameMaleLangMask).HasColumnName("Name_Male_Lang_Mask");
            entity.Property(e => e.NameMaleLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ptBR");
            entity.Property(e => e.NameMaleLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ptPT");
            entity.Property(e => e.NameMaleLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_ruRU");
            entity.Property(e => e.NameMaleLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_Unk");
            entity.Property(e => e.NameMaleLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_zhCN");
            entity.Property(e => e.NameMaleLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Male_Lang_zhTW");
            entity.Property(e => e.RequiredExpansion).HasColumnName("Required_Expansion");
            entity.Property(e => e.ResSicknessSpellId).HasColumnName("ResSicknessSpellID");
            entity.Property(e => e.SplashSoundId).HasColumnName("SplashSoundID");

            entity.HasOne(d => d.CinematicSequence).WithMany(p => p.Chrraces)
                .HasForeignKey(d => d.CinematicSequenceId)
                .HasConstraintName("chrraces_ibfk_12");

            entity.HasOne(d => d.CreatureTypeNavigation).WithMany(p => p.Chrraces)
                .HasForeignKey(d => d.CreatureType)
                .HasConstraintName("chrraces_ibfk_11");

            entity.HasOne(d => d.ExplorationSound).WithMany(p => p.Chrraces)
                .HasForeignKey(d => d.ExplorationSoundId)
                .HasConstraintName("chrraces_ibfk_14");

            entity.HasOne(d => d.Faction).WithMany(p => p.Chrraces)
                .HasForeignKey(d => d.FactionId)
                .HasConstraintName("chrraces_ibfk_1");

            entity.HasOne(d => d.FemaleDisplay).WithMany(p => p.ChrraceFemaleDisplays)
                .HasForeignKey(d => d.FemaleDisplayId)
                .HasConstraintName("chrraces_ibfk_10");

            entity.HasOne(d => d.MaleDisplay).WithMany(p => p.ChrraceMaleDisplays)
                .HasForeignKey(d => d.MaleDisplayId)
                .HasConstraintName("chrraces_ibfk_15");
        });

        modelBuilder.Entity<Cinematiccamera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cinematiccamera")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Model).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Sound).WithMany(p => p.Cinematiccameras)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("cinematiccamera_ibfk_1");
        });

        modelBuilder.Entity<Cinematicsequence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cinematicsequences")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Camera1, "Camera_1");

            entity.HasIndex(e => e.Camera2, "Camera_2");

            entity.HasIndex(e => e.Camera3, "Camera_3");

            entity.HasIndex(e => e.Camera4, "Camera_4");

            entity.HasIndex(e => e.Camera5, "Camera_5");

            entity.HasIndex(e => e.Camera6, "Camera_6");

            entity.HasIndex(e => e.Camera7, "Camera_7");

            entity.HasIndex(e => e.Camera8, "Camera_8");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Camera1).HasColumnName("Camera_1");
            entity.Property(e => e.Camera2).HasColumnName("Camera_2");
            entity.Property(e => e.Camera3).HasColumnName("Camera_3");
            entity.Property(e => e.Camera4).HasColumnName("Camera_4");
            entity.Property(e => e.Camera5).HasColumnName("Camera_5");
            entity.Property(e => e.Camera6).HasColumnName("Camera_6");
            entity.Property(e => e.Camera7).HasColumnName("Camera_7");
            entity.Property(e => e.Camera8).HasColumnName("Camera_8");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Camera1Navigation).WithMany(p => p.CinematicsequenceCamera1Navigations)
                .HasForeignKey(d => d.Camera1)
                .HasConstraintName("cinematicsequences_ibfk_11");

            entity.HasOne(d => d.Camera2Navigation).WithMany(p => p.CinematicsequenceCamera2Navigations)
                .HasForeignKey(d => d.Camera2)
                .HasConstraintName("cinematicsequences_ibfk_12");

            entity.HasOne(d => d.Camera3Navigation).WithMany(p => p.CinematicsequenceCamera3Navigations)
                .HasForeignKey(d => d.Camera3)
                .HasConstraintName("cinematicsequences_ibfk_13");

            entity.HasOne(d => d.Camera4Navigation).WithMany(p => p.CinematicsequenceCamera4Navigations)
                .HasForeignKey(d => d.Camera4)
                .HasConstraintName("cinematicsequences_ibfk_14");

            entity.HasOne(d => d.Camera5Navigation).WithMany(p => p.CinematicsequenceCamera5Navigations)
                .HasForeignKey(d => d.Camera5)
                .HasConstraintName("cinematicsequences_ibfk_15");

            entity.HasOne(d => d.Camera6Navigation).WithMany(p => p.CinematicsequenceCamera6Navigations)
                .HasForeignKey(d => d.Camera6)
                .HasConstraintName("cinematicsequences_ibfk_16");

            entity.HasOne(d => d.Camera7Navigation).WithMany(p => p.CinematicsequenceCamera7Navigations)
                .HasForeignKey(d => d.Camera7)
                .HasConstraintName("cinematicsequences_ibfk_17");

            entity.HasOne(d => d.Camera8Navigation).WithMany(p => p.CinematicsequenceCamera8Navigations)
                .HasForeignKey(d => d.Camera8)
                .HasConstraintName("cinematicsequences_ibfk_18");

            entity.HasOne(d => d.Sound).WithMany(p => p.Cinematicsequences)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("cinematicsequences_ibfk_1");
        });

        modelBuilder.Entity<Creaturedisplayinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturedisplayinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BloodId, "BloodID");

            entity.HasIndex(e => e.BloodLevel, "BloodLevel");

            entity.HasIndex(e => e.ExtendedDisplayInfoId, "ExtendedDisplayInfoID");

            entity.HasIndex(e => e.ModelId, "ModelID");

            entity.HasIndex(e => e.NpcsoundId, "NPCSoundID");

            entity.HasIndex(e => e.ObjectEffectPackageId, "ObjectEffectPackageID");

            entity.HasIndex(e => e.ParticleColorId, "ParticleColorID");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BloodId).HasColumnName("BloodID");
            entity.Property(e => e.ExtendedDisplayInfoId).HasColumnName("ExtendedDisplayInfoID");
            entity.Property(e => e.ModelId).HasColumnName("ModelID");
            entity.Property(e => e.NpcsoundId).HasColumnName("NPCSoundID");
            entity.Property(e => e.ObjectEffectPackageId).HasColumnName("ObjectEffectPackageID");
            entity.Property(e => e.ParticleColorId).HasColumnName("ParticleColorID");
            entity.Property(e => e.PortraitTextureName).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.TextureVariation1)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_1");
            entity.Property(e => e.TextureVariation2)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_2");
            entity.Property(e => e.TextureVariation3)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_3");

            entity.HasOne(d => d.Blood).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.BloodId)
                .HasConstraintName("creaturedisplayinfo_ibfk_13");

            entity.HasOne(d => d.BloodLevelNavigation).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.BloodLevel)
                .HasConstraintName("creaturedisplayinfo_ibfk_12");

            entity.HasOne(d => d.ExtendedDisplayInfo).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.ExtendedDisplayInfoId)
                .HasConstraintName("creaturedisplayinfo_ibfk_11");

            entity.HasOne(d => d.Model).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("creaturedisplayinfo_ibfk_1");

            entity.HasOne(d => d.Npcsound).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.NpcsoundId)
                .HasConstraintName("creaturedisplayinfo_ibfk_14");

            entity.HasOne(d => d.ObjectEffectPackage).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.ObjectEffectPackageId)
                .HasConstraintName("creaturedisplayinfo_ibfk_16");

            entity.HasOne(d => d.ParticleColor).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.ParticleColorId)
                .HasConstraintName("creaturedisplayinfo_ibfk_15");

            entity.HasOne(d => d.Sound).WithMany(p => p.Creaturedisplayinfos)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("creaturedisplayinfo_ibfk_10");
        });

        modelBuilder.Entity<Creaturedisplayinfoextra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturedisplayinfoextra")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DisplayRaceId, "DisplayRaceID");

            entity.HasIndex(e => e.NpcitemDisplay1, "NPCItemDisplay_1");

            entity.HasIndex(e => e.NpcitemDisplay10, "NPCItemDisplay_10");

            entity.HasIndex(e => e.NpcitemDisplay11, "NPCItemDisplay_11");

            entity.HasIndex(e => e.NpcitemDisplay2, "NPCItemDisplay_2");

            entity.HasIndex(e => e.NpcitemDisplay3, "NPCItemDisplay_3");

            entity.HasIndex(e => e.NpcitemDisplay4, "NPCItemDisplay_4");

            entity.HasIndex(e => e.NpcitemDisplay5, "NPCItemDisplay_5");

            entity.HasIndex(e => e.NpcitemDisplay6, "NPCItemDisplay_6");

            entity.HasIndex(e => e.NpcitemDisplay7, "NPCItemDisplay_7");

            entity.HasIndex(e => e.NpcitemDisplay8, "NPCItemDisplay_8");

            entity.HasIndex(e => e.NpcitemDisplay9, "NPCItemDisplay_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BakeName).HasColumnType("text");
            entity.Property(e => e.DisplayRaceId).HasColumnName("DisplayRaceID");
            entity.Property(e => e.DisplaySexId).HasColumnName("DisplaySexID");
            entity.Property(e => e.FaceId).HasColumnName("FaceID");
            entity.Property(e => e.FacialHairId).HasColumnName("FacialHairID");
            entity.Property(e => e.HairColorId).HasColumnName("HairColorID");
            entity.Property(e => e.HairStyleId).HasColumnName("HairStyleID");
            entity.Property(e => e.NpcitemDisplay1).HasColumnName("NPCItemDisplay_1");
            entity.Property(e => e.NpcitemDisplay10).HasColumnName("NPCItemDisplay_10");
            entity.Property(e => e.NpcitemDisplay11).HasColumnName("NPCItemDisplay_11");
            entity.Property(e => e.NpcitemDisplay2).HasColumnName("NPCItemDisplay_2");
            entity.Property(e => e.NpcitemDisplay3).HasColumnName("NPCItemDisplay_3");
            entity.Property(e => e.NpcitemDisplay4).HasColumnName("NPCItemDisplay_4");
            entity.Property(e => e.NpcitemDisplay5).HasColumnName("NPCItemDisplay_5");
            entity.Property(e => e.NpcitemDisplay6).HasColumnName("NPCItemDisplay_6");
            entity.Property(e => e.NpcitemDisplay7).HasColumnName("NPCItemDisplay_7");
            entity.Property(e => e.NpcitemDisplay8).HasColumnName("NPCItemDisplay_8");
            entity.Property(e => e.NpcitemDisplay9).HasColumnName("NPCItemDisplay_9");
            entity.Property(e => e.SkinId).HasColumnName("SkinID");

            entity.HasOne(d => d.DisplayRace).WithMany(p => p.Creaturedisplayinfoextras)
                .HasForeignKey(d => d.DisplayRaceId)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_1");

            entity.HasOne(d => d.NpcitemDisplay1Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay1Navigations)
                .HasForeignKey(d => d.NpcitemDisplay1)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_14");

            entity.HasOne(d => d.NpcitemDisplay10Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay10Navigations)
                .HasForeignKey(d => d.NpcitemDisplay10)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_11");

            entity.HasOne(d => d.NpcitemDisplay11Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay11Navigations)
                .HasForeignKey(d => d.NpcitemDisplay11)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_12");

            entity.HasOne(d => d.NpcitemDisplay2Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay2Navigations)
                .HasForeignKey(d => d.NpcitemDisplay2)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_15");

            entity.HasOne(d => d.NpcitemDisplay3Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay3Navigations)
                .HasForeignKey(d => d.NpcitemDisplay3)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_16");

            entity.HasOne(d => d.NpcitemDisplay4Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay4Navigations)
                .HasForeignKey(d => d.NpcitemDisplay4)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_17");

            entity.HasOne(d => d.NpcitemDisplay5Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay5Navigations)
                .HasForeignKey(d => d.NpcitemDisplay5)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_18");

            entity.HasOne(d => d.NpcitemDisplay6Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay6Navigations)
                .HasForeignKey(d => d.NpcitemDisplay6)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_19");

            entity.HasOne(d => d.NpcitemDisplay7Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay7Navigations)
                .HasForeignKey(d => d.NpcitemDisplay7)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_20");

            entity.HasOne(d => d.NpcitemDisplay8Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay8Navigations)
                .HasForeignKey(d => d.NpcitemDisplay8)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_21");

            entity.HasOne(d => d.NpcitemDisplay9Navigation).WithMany(p => p.CreaturedisplayinfoextraNpcitemDisplay9Navigations)
                .HasForeignKey(d => d.NpcitemDisplay9)
                .HasConstraintName("creaturedisplayinfoextra_ibfk_10");
        });

        modelBuilder.Entity<Creaturefamily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturefamily")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SkillLine1, "SkillLine_1");

            entity.HasIndex(e => e.SkillLine2, "SkillLine_2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryEnumId).HasColumnName("CategoryEnumID");
            entity.Property(e => e.IconFile).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SkillLine1).HasColumnName("SkillLine_1");
            entity.Property(e => e.SkillLine2).HasColumnName("SkillLine_2");

            entity.HasOne(d => d.SkillLine1Navigation).WithMany(p => p.CreaturefamilySkillLine1Navigations)
                .HasForeignKey(d => d.SkillLine1)
                .HasConstraintName("creaturefamily_ibfk_1");

            entity.HasOne(d => d.SkillLine2Navigation).WithMany(p => p.CreaturefamilySkillLine2Navigations)
                .HasForeignKey(d => d.SkillLine2)
                .HasConstraintName("creaturefamily_ibfk_2");
        });

        modelBuilder.Entity<Creaturemodeldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturemodeldata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BloodId, "BloodID");

            entity.HasIndex(e => e.DeathThudShakeSize, "DeathThudShakeSize");

            entity.HasIndex(e => e.FootprintTextureId, "FootprintTextureID");

            entity.HasIndex(e => e.FootstepShakeSize, "FootstepShakeSize");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BloodId).HasColumnName("BloodID");
            entity.Property(e => e.FoleyMaterialId).HasColumnName("FoleyMaterialID");
            entity.Property(e => e.FootprintTextureId).HasColumnName("FootprintTextureID");
            entity.Property(e => e.ModelName).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Blood).WithMany(p => p.Creaturemodeldata)
                .HasForeignKey(d => d.BloodId)
                .HasConstraintName("creaturemodeldata_ibfk_1");

            entity.HasOne(d => d.DeathThudShakeSizeNavigation).WithMany(p => p.CreaturemodeldatumDeathThudShakeSizeNavigations)
                .HasForeignKey(d => d.DeathThudShakeSize)
                .HasConstraintName("creaturemodeldata_ibfk_14");

            entity.HasOne(d => d.FootprintTexture).WithMany(p => p.Creaturemodeldata)
                .HasForeignKey(d => d.FootprintTextureId)
                .HasConstraintName("creaturemodeldata_ibfk_12");

            entity.HasOne(d => d.FootstepShakeSizeNavigation).WithMany(p => p.CreaturemodeldatumFootstepShakeSizeNavigations)
                .HasForeignKey(d => d.FootstepShakeSize)
                .HasConstraintName("creaturemodeldata_ibfk_13");

            entity.HasOne(d => d.Sound).WithMany(p => p.Creaturemodeldata)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("creaturemodeldata_ibfk_10");
        });

        modelBuilder.Entity<Creaturemovementinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturemovementinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Creaturesounddatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturesounddata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BirthSoundId, "BirthSoundID");

            entity.HasIndex(e => e.LoopSoundId, "LoopSoundID");

            entity.HasIndex(e => e.NpcsoundId, "NPCSoundID");

            entity.HasIndex(e => e.SoundAggroId, "SoundAggroID");

            entity.HasIndex(e => e.SoundAlertId, "SoundAlertID");

            entity.HasIndex(e => e.SoundDeathId, "SoundDeathID");

            entity.HasIndex(e => e.SoundExertionCriticalId, "SoundExertionCriticalID");

            entity.HasIndex(e => e.SoundExertionId, "SoundExertionID");

            entity.HasIndex(e => e.SoundFidget1, "SoundFidget_1");

            entity.HasIndex(e => e.SoundFidget2, "SoundFidget_2");

            entity.HasIndex(e => e.SoundFidget3, "SoundFidget_3");

            entity.HasIndex(e => e.SoundFidget4, "SoundFidget_4");

            entity.HasIndex(e => e.SoundFidget5, "SoundFidget_5");

            entity.HasIndex(e => e.SoundFootstepId, "SoundFootstepID");

            entity.HasIndex(e => e.SoundInjuryCriticalId, "SoundInjuryCriticalID");

            entity.HasIndex(e => e.SoundInjuryCrushingBlowId, "SoundInjuryCrushingBlowID");

            entity.HasIndex(e => e.SoundInjuryId, "SoundInjuryID");

            entity.HasIndex(e => e.SoundJumpEndId, "SoundJumpEndID");

            entity.HasIndex(e => e.SoundJumpStartId, "SoundJumpStartID");

            entity.HasIndex(e => e.SoundPetAttackId, "SoundPetAttackID");

            entity.HasIndex(e => e.SoundPetDismissId, "SoundPetDismissID");

            entity.HasIndex(e => e.SoundPetOrderId, "SoundPetOrderID");

            entity.HasIndex(e => e.SoundStandId, "SoundStandID");

            entity.HasIndex(e => e.SoundStunId, "SoundStunID");

            entity.HasIndex(e => e.SoundWingFlapId, "SoundWingFlapID");

            entity.HasIndex(e => e.SoundWingGlideId, "SoundWingGlideID");

            entity.HasIndex(e => e.SpellCastDirectedSoundId, "SpellCastDirectedSoundID");

            entity.HasIndex(e => e.SubmergeSoundId, "SubmergeSoundID");

            entity.HasIndex(e => e.SubmergedSoundId, "SubmergedSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BirthSoundId).HasColumnName("BirthSoundID");
            entity.Property(e => e.CreatureSoundDataIdpet).HasColumnName("CreatureSoundDataIDPet");
            entity.Property(e => e.CustomAttack1).HasColumnName("CustomAttack_1");
            entity.Property(e => e.CustomAttack2).HasColumnName("CustomAttack_2");
            entity.Property(e => e.CustomAttack3).HasColumnName("CustomAttack_3");
            entity.Property(e => e.CustomAttack4).HasColumnName("CustomAttack_4");
            entity.Property(e => e.LoopSoundId).HasColumnName("LoopSoundID");
            entity.Property(e => e.NpcsoundId).HasColumnName("NPCSoundID");
            entity.Property(e => e.SoundAggroId).HasColumnName("SoundAggroID");
            entity.Property(e => e.SoundAlertId).HasColumnName("SoundAlertID");
            entity.Property(e => e.SoundDeathId).HasColumnName("SoundDeathID");
            entity.Property(e => e.SoundExertionCriticalId).HasColumnName("SoundExertionCriticalID");
            entity.Property(e => e.SoundExertionId).HasColumnName("SoundExertionID");
            entity.Property(e => e.SoundFidget1).HasColumnName("SoundFidget_1");
            entity.Property(e => e.SoundFidget2).HasColumnName("SoundFidget_2");
            entity.Property(e => e.SoundFidget3).HasColumnName("SoundFidget_3");
            entity.Property(e => e.SoundFidget4).HasColumnName("SoundFidget_4");
            entity.Property(e => e.SoundFidget5).HasColumnName("SoundFidget_5");
            entity.Property(e => e.SoundFootstepId).HasColumnName("SoundFootstepID");
            entity.Property(e => e.SoundInjuryCriticalId).HasColumnName("SoundInjuryCriticalID");
            entity.Property(e => e.SoundInjuryCrushingBlowId).HasColumnName("SoundInjuryCrushingBlowID");
            entity.Property(e => e.SoundInjuryId).HasColumnName("SoundInjuryID");
            entity.Property(e => e.SoundJumpEndId).HasColumnName("SoundJumpEndID");
            entity.Property(e => e.SoundJumpStartId).HasColumnName("SoundJumpStartID");
            entity.Property(e => e.SoundPetAttackId).HasColumnName("SoundPetAttackID");
            entity.Property(e => e.SoundPetDismissId).HasColumnName("SoundPetDismissID");
            entity.Property(e => e.SoundPetOrderId).HasColumnName("SoundPetOrderID");
            entity.Property(e => e.SoundStandId).HasColumnName("SoundStandID");
            entity.Property(e => e.SoundStunId).HasColumnName("SoundStunID");
            entity.Property(e => e.SoundWingFlapId).HasColumnName("SoundWingFlapID");
            entity.Property(e => e.SoundWingGlideId).HasColumnName("SoundWingGlideID");
            entity.Property(e => e.SpellCastDirectedSoundId).HasColumnName("SpellCastDirectedSoundID");
            entity.Property(e => e.SubmergeSoundId).HasColumnName("SubmergeSoundID");
            entity.Property(e => e.SubmergedSoundId).HasColumnName("SubmergedSoundID");

            entity.HasOne(d => d.BirthSound).WithMany(p => p.CreaturesounddatumBirthSounds)
                .HasForeignKey(d => d.BirthSoundId)
                .HasConstraintName("creaturesounddata_ibfk_113");

            entity.HasOne(d => d.LoopSound).WithMany(p => p.CreaturesounddatumLoopSounds)
                .HasForeignKey(d => d.LoopSoundId)
                .HasConstraintName("creaturesounddata_ibfk_107");

            entity.HasOne(d => d.Npcsound).WithMany(p => p.CreaturesounddatumNpcsounds)
                .HasForeignKey(d => d.NpcsoundId)
                .HasConstraintName("creaturesounddata_ibfk_106");

            entity.HasOne(d => d.SoundAggro).WithMany(p => p.CreaturesounddatumSoundAggros)
                .HasForeignKey(d => d.SoundAggroId)
                .HasConstraintName("creaturesounddata_ibfk_10");

            entity.HasOne(d => d.SoundAlert).WithMany(p => p.CreaturesounddatumSoundAlerts)
                .HasForeignKey(d => d.SoundAlertId)
                .HasConstraintName("creaturesounddata_ibfk_100");

            entity.HasOne(d => d.SoundDeath).WithMany(p => p.CreaturesounddatumSoundDeaths)
                .HasForeignKey(d => d.SoundDeathId)
                .HasConstraintName("creaturesounddata_ibfk_35");

            entity.HasOne(d => d.SoundExertionCritical).WithMany(p => p.CreaturesounddatumSoundExertionCriticals)
                .HasForeignKey(d => d.SoundExertionCriticalId)
                .HasConstraintName("creaturesounddata_ibfk_2");

            entity.HasOne(d => d.SoundExertion).WithMany(p => p.CreaturesounddatumSoundExertions)
                .HasForeignKey(d => d.SoundExertionId)
                .HasConstraintName("creaturesounddata_ibfk_1");

            entity.HasOne(d => d.SoundFidget1Navigation).WithMany(p => p.CreaturesounddatumSoundFidget1Navigations)
                .HasForeignKey(d => d.SoundFidget1)
                .HasConstraintName("creaturesounddata_ibfk_101");

            entity.HasOne(d => d.SoundFidget2Navigation).WithMany(p => p.CreaturesounddatumSoundFidget2Navigations)
                .HasForeignKey(d => d.SoundFidget2)
                .HasConstraintName("creaturesounddata_ibfk_102");

            entity.HasOne(d => d.SoundFidget3Navigation).WithMany(p => p.CreaturesounddatumSoundFidget3Navigations)
                .HasForeignKey(d => d.SoundFidget3)
                .HasConstraintName("creaturesounddata_ibfk_103");

            entity.HasOne(d => d.SoundFidget4Navigation).WithMany(p => p.CreaturesounddatumSoundFidget4Navigations)
                .HasForeignKey(d => d.SoundFidget4)
                .HasConstraintName("creaturesounddata_ibfk_104");

            entity.HasOne(d => d.SoundFidget5Navigation).WithMany(p => p.CreaturesounddatumSoundFidget5Navigations)
                .HasForeignKey(d => d.SoundFidget5)
                .HasConstraintName("creaturesounddata_ibfk_105");

            entity.HasOne(d => d.SoundFootstep).WithMany(p => p.CreaturesounddatumSoundFootsteps)
                .HasForeignKey(d => d.SoundFootstepId)
                .HasConstraintName("creaturesounddata_ibfk_38");

            entity.HasOne(d => d.SoundInjuryCritical).WithMany(p => p.CreaturesounddatumSoundInjuryCriticals)
                .HasForeignKey(d => d.SoundInjuryCriticalId)
                .HasConstraintName("creaturesounddata_ibfk_33");

            entity.HasOne(d => d.SoundInjuryCrushingBlow).WithMany(p => p.CreaturesounddatumSoundInjuryCrushingBlows)
                .HasForeignKey(d => d.SoundInjuryCrushingBlowId)
                .HasConstraintName("creaturesounddata_ibfk_34");

            entity.HasOne(d => d.SoundInjury).WithMany(p => p.CreaturesounddatumSoundInjuries)
                .HasForeignKey(d => d.SoundInjuryId)
                .HasConstraintName("creaturesounddata_ibfk_3");

            entity.HasOne(d => d.SoundJumpEnd).WithMany(p => p.CreaturesounddatumSoundJumpEnds)
                .HasForeignKey(d => d.SoundJumpEndId)
                .HasConstraintName("creaturesounddata_ibfk_109");

            entity.HasOne(d => d.SoundJumpStart).WithMany(p => p.CreaturesounddatumSoundJumpStarts)
                .HasForeignKey(d => d.SoundJumpStartId)
                .HasConstraintName("creaturesounddata_ibfk_108");

            entity.HasOne(d => d.SoundPetAttack).WithMany(p => p.CreaturesounddatumSoundPetAttacks)
                .HasForeignKey(d => d.SoundPetAttackId)
                .HasConstraintName("creaturesounddata_ibfk_110");

            entity.HasOne(d => d.SoundPetDismiss).WithMany(p => p.CreaturesounddatumSoundPetDismisses)
                .HasForeignKey(d => d.SoundPetDismissId)
                .HasConstraintName("creaturesounddata_ibfk_112");

            entity.HasOne(d => d.SoundPetOrder).WithMany(p => p.CreaturesounddatumSoundPetOrders)
                .HasForeignKey(d => d.SoundPetOrderId)
                .HasConstraintName("creaturesounddata_ibfk_111");

            entity.HasOne(d => d.SoundStand).WithMany(p => p.CreaturesounddatumSoundStands)
                .HasForeignKey(d => d.SoundStandId)
                .HasConstraintName("creaturesounddata_ibfk_37");

            entity.HasOne(d => d.SoundStun).WithMany(p => p.CreaturesounddatumSoundStuns)
                .HasForeignKey(d => d.SoundStunId)
                .HasConstraintName("creaturesounddata_ibfk_36");

            entity.HasOne(d => d.SoundWingFlap).WithMany(p => p.CreaturesounddatumSoundWingFlaps)
                .HasForeignKey(d => d.SoundWingFlapId)
                .HasConstraintName("creaturesounddata_ibfk_11");

            entity.HasOne(d => d.SoundWingGlide).WithMany(p => p.CreaturesounddatumSoundWingGlides)
                .HasForeignKey(d => d.SoundWingGlideId)
                .HasConstraintName("creaturesounddata_ibfk_12");

            entity.HasOne(d => d.SpellCastDirectedSound).WithMany(p => p.CreaturesounddatumSpellCastDirectedSounds)
                .HasForeignKey(d => d.SpellCastDirectedSoundId)
                .HasConstraintName("creaturesounddata_ibfk_114");

            entity.HasOne(d => d.SubmergeSound).WithMany(p => p.CreaturesounddatumSubmergeSounds)
                .HasForeignKey(d => d.SubmergeSoundId)
                .HasConstraintName("creaturesounddata_ibfk_115");

            entity.HasOne(d => d.SubmergedSound).WithMany(p => p.CreaturesounddatumSubmergedSounds)
                .HasForeignKey(d => d.SubmergedSoundId)
                .HasConstraintName("creaturesounddata_ibfk_116");
        });

        modelBuilder.Entity<Creaturespelldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturespelldata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Spells1, "Spells_1");

            entity.HasIndex(e => e.Spells2, "Spells_2");

            entity.HasIndex(e => e.Spells3, "Spells_3");

            entity.HasIndex(e => e.Spells4, "Spells_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Availability1).HasColumnName("Availability_1");
            entity.Property(e => e.Availability2).HasColumnName("Availability_2");
            entity.Property(e => e.Availability3).HasColumnName("Availability_3");
            entity.Property(e => e.Availability4).HasColumnName("Availability_4");
            entity.Property(e => e.Spells1).HasColumnName("Spells_1");
            entity.Property(e => e.Spells2).HasColumnName("Spells_2");
            entity.Property(e => e.Spells3).HasColumnName("Spells_3");
            entity.Property(e => e.Spells4).HasColumnName("Spells_4");

            entity.HasOne(d => d.Spells1Navigation).WithMany(p => p.CreaturespelldatumSpells1Navigations)
                .HasForeignKey(d => d.Spells1)
                .HasConstraintName("creaturespelldata_ibfk_1");

            entity.HasOne(d => d.Spells2Navigation).WithMany(p => p.CreaturespelldatumSpells2Navigations)
                .HasForeignKey(d => d.Spells2)
                .HasConstraintName("creaturespelldata_ibfk_10");

            entity.HasOne(d => d.Spells3Navigation).WithMany(p => p.CreaturespelldatumSpells3Navigations)
                .HasForeignKey(d => d.Spells3)
                .HasConstraintName("creaturespelldata_ibfk_11");

            entity.HasOne(d => d.Spells4Navigation).WithMany(p => p.CreaturespelldatumSpells4Navigations)
                .HasForeignKey(d => d.Spells4)
                .HasConstraintName("creaturespelldata_ibfk_12");
        });

        modelBuilder.Entity<Creaturetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("creaturetype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Currencycategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("currencycategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Currencytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("currencytypes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<Dancemove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dancemoves")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.InternalName)
                .HasColumnType("text")
                .HasColumnName("Internal_Name");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Deaththudlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("deaththudlookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundEntryId, "SoundEntryID");

            entity.HasIndex(e => e.SoundEntryIdwater, "SoundEntryIDWater");

            entity.HasIndex(e => e.TerraintypeSoundId, "TerraintypeSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SoundEntryId).HasColumnName("SoundEntryID");
            entity.Property(e => e.SoundEntryIdwater).HasColumnName("SoundEntryIDWater");
            entity.Property(e => e.TerraintypeSoundId).HasColumnName("TerraintypeSoundID");

            entity.HasOne(d => d.SoundEntry).WithMany(p => p.DeaththudlookupSoundEntries)
                .HasForeignKey(d => d.SoundEntryId)
                .HasConstraintName("deaththudlookups_ibfk_11");

            entity.HasOne(d => d.SoundEntryIdwaterNavigation).WithMany(p => p.DeaththudlookupSoundEntryIdwaterNavigations)
                .HasForeignKey(d => d.SoundEntryIdwater)
                .HasConstraintName("deaththudlookups_ibfk_12");

            entity.HasOne(d => d.TerraintypeSound).WithMany(p => p.Deaththudlookups)
                .HasForeignKey(d => d.TerraintypeSoundId)
                .HasConstraintName("deaththudlookups_ibfk_1");
        });

        modelBuilder.Entity<Declinedword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("declinedword")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Word).HasColumnType("text");
        });

        modelBuilder.Entity<Declinedwordcase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("declinedwordcases")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DeclinedWordId, "DeclinedWordID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DeclinedWord).HasColumnType("text");
            entity.Property(e => e.DeclinedWordId).HasColumnName("DeclinedWordID");

            entity.HasOne(d => d.DeclinedWordNavigation).WithMany(p => p.Declinedwordcases)
                .HasForeignKey(d => d.DeclinedWordId)
                .HasConstraintName("declinedwordcases_ibfk_1");
        });

        modelBuilder.Entity<Destructiblemodeldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("destructiblemodeldata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Dungeonencounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dungeonencounter")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Difficulty, "Difficulty");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");

            entity.HasOne(d => d.DifficultyNavigation).WithMany(p => p.Dungeonencounters)
                .HasForeignKey(d => d.Difficulty)
                .HasConstraintName("dungeonencounter_ibfk_2");

            entity.HasOne(d => d.Map).WithMany(p => p.Dungeonencounters)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("dungeonencounter_ibfk_1");
        });

        modelBuilder.Entity<Dungeonmap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dungeonmap")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.HasIndex(e => e.ParentWorldMapId, "ParentWorldMapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.ParentWorldMapId).HasColumnName("ParentWorldMapID");

            entity.HasOne(d => d.Map).WithMany(p => p.Dungeonmaps)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("dungeonmap_ibfk_1");

            entity.HasOne(d => d.ParentWorldMap).WithMany(p => p.Dungeonmaps)
                .HasForeignKey(d => d.ParentWorldMapId)
                .HasConstraintName("dungeonmap_ibfk_2");
        });

        modelBuilder.Entity<Dungeonmapchunk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dungeonmapchunk")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DungeonMapId, "DungeonMapID");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.HasIndex(e => e.WmoGroupId, "WmoGroupID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DungeonMapId).HasColumnName("DungeonMapID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.WmoGroupId).HasColumnName("WmoGroupID");

            entity.HasOne(d => d.DungeonMap).WithMany(p => p.Dungeonmapchunks)
                .HasForeignKey(d => d.DungeonMapId)
                .HasConstraintName("dungeonmapchunk_ibfk_3");

            entity.HasOne(d => d.Map).WithMany(p => p.Dungeonmapchunks)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("dungeonmapchunk_ibfk_1");
        });

        modelBuilder.Entity<Durabilitycost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("durabilitycosts")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArmorSubClassCost1).HasColumnName("ArmorSubClassCost_1");
            entity.Property(e => e.ArmorSubClassCost2).HasColumnName("ArmorSubClassCost_2");
            entity.Property(e => e.ArmorSubClassCost3).HasColumnName("ArmorSubClassCost_3");
            entity.Property(e => e.ArmorSubClassCost4).HasColumnName("ArmorSubClassCost_4");
            entity.Property(e => e.ArmorSubClassCost5).HasColumnName("ArmorSubClassCost_5");
            entity.Property(e => e.ArmorSubClassCost6).HasColumnName("ArmorSubClassCost_6");
            entity.Property(e => e.ArmorSubClassCost7).HasColumnName("ArmorSubClassCost_7");
            entity.Property(e => e.ArmorSubClassCost8).HasColumnName("ArmorSubClassCost_8");
            entity.Property(e => e.WeaponSubClassCost1).HasColumnName("WeaponSubClassCost_1");
            entity.Property(e => e.WeaponSubClassCost10).HasColumnName("WeaponSubClassCost_10");
            entity.Property(e => e.WeaponSubClassCost11).HasColumnName("WeaponSubClassCost_11");
            entity.Property(e => e.WeaponSubClassCost12).HasColumnName("WeaponSubClassCost_12");
            entity.Property(e => e.WeaponSubClassCost13).HasColumnName("WeaponSubClassCost_13");
            entity.Property(e => e.WeaponSubClassCost14).HasColumnName("WeaponSubClassCost_14");
            entity.Property(e => e.WeaponSubClassCost15).HasColumnName("WeaponSubClassCost_15");
            entity.Property(e => e.WeaponSubClassCost16).HasColumnName("WeaponSubClassCost_16");
            entity.Property(e => e.WeaponSubClassCost17).HasColumnName("WeaponSubClassCost_17");
            entity.Property(e => e.WeaponSubClassCost18).HasColumnName("WeaponSubClassCost_18");
            entity.Property(e => e.WeaponSubClassCost19).HasColumnName("WeaponSubClassCost_19");
            entity.Property(e => e.WeaponSubClassCost2).HasColumnName("WeaponSubClassCost_2");
            entity.Property(e => e.WeaponSubClassCost20).HasColumnName("WeaponSubClassCost_20");
            entity.Property(e => e.WeaponSubClassCost21).HasColumnName("WeaponSubClassCost_21");
            entity.Property(e => e.WeaponSubClassCost3).HasColumnName("WeaponSubClassCost_3");
            entity.Property(e => e.WeaponSubClassCost4).HasColumnName("WeaponSubClassCost_4");
            entity.Property(e => e.WeaponSubClassCost5).HasColumnName("WeaponSubClassCost_5");
            entity.Property(e => e.WeaponSubClassCost6).HasColumnName("WeaponSubClassCost_6");
            entity.Property(e => e.WeaponSubClassCost7).HasColumnName("WeaponSubClassCost_7");
            entity.Property(e => e.WeaponSubClassCost8).HasColumnName("WeaponSubClassCost_8");
            entity.Property(e => e.WeaponSubClassCost9).HasColumnName("WeaponSubClassCost_9");
        });

        modelBuilder.Entity<Durabilityquality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("durabilityquality")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Emote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("emotes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AnimId, "AnimID");

            entity.HasIndex(e => e.EventSoundId, "EventSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AnimId).HasColumnName("AnimID");
            entity.Property(e => e.EmoteSlashCommand).HasColumnType("text");
            entity.Property(e => e.EventSoundId).HasColumnName("EventSoundID");

            entity.HasOne(d => d.Anim).WithMany(p => p.Emotes)
                .HasForeignKey(d => d.AnimId)
                .HasConstraintName("emotes_ibfk_1");

            entity.HasOne(d => d.EventSound).WithMany(p => p.Emotes)
                .HasForeignKey(d => d.EventSoundId)
                .HasConstraintName("emotes_ibfk_2");
        });

        modelBuilder.Entity<Emotestext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("emotestext")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.EmoteId, "EmoteID");

            entity.HasIndex(e => e.EmoteText1, "EmoteText_1");

            entity.HasIndex(e => e.EmoteText10, "EmoteText_10");

            entity.HasIndex(e => e.EmoteText11, "EmoteText_11");

            entity.HasIndex(e => e.EmoteText12, "EmoteText_12");

            entity.HasIndex(e => e.EmoteText13, "EmoteText_13");

            entity.HasIndex(e => e.EmoteText14, "EmoteText_14");

            entity.HasIndex(e => e.EmoteText15, "EmoteText_15");

            entity.HasIndex(e => e.EmoteText16, "EmoteText_16");

            entity.HasIndex(e => e.EmoteText2, "EmoteText_2");

            entity.HasIndex(e => e.EmoteText3, "EmoteText_3");

            entity.HasIndex(e => e.EmoteText4, "EmoteText_4");

            entity.HasIndex(e => e.EmoteText5, "EmoteText_5");

            entity.HasIndex(e => e.EmoteText6, "EmoteText_6");

            entity.HasIndex(e => e.EmoteText7, "EmoteText_7");

            entity.HasIndex(e => e.EmoteText8, "EmoteText_8");

            entity.HasIndex(e => e.EmoteText9, "EmoteText_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmoteId).HasColumnName("EmoteID");
            entity.Property(e => e.EmoteText1).HasColumnName("EmoteText_1");
            entity.Property(e => e.EmoteText10).HasColumnName("EmoteText_10");
            entity.Property(e => e.EmoteText11).HasColumnName("EmoteText_11");
            entity.Property(e => e.EmoteText12).HasColumnName("EmoteText_12");
            entity.Property(e => e.EmoteText13).HasColumnName("EmoteText_13");
            entity.Property(e => e.EmoteText14).HasColumnName("EmoteText_14");
            entity.Property(e => e.EmoteText15).HasColumnName("EmoteText_15");
            entity.Property(e => e.EmoteText16).HasColumnName("EmoteText_16");
            entity.Property(e => e.EmoteText2).HasColumnName("EmoteText_2");
            entity.Property(e => e.EmoteText3).HasColumnName("EmoteText_3");
            entity.Property(e => e.EmoteText4).HasColumnName("EmoteText_4");
            entity.Property(e => e.EmoteText5).HasColumnName("EmoteText_5");
            entity.Property(e => e.EmoteText6).HasColumnName("EmoteText_6");
            entity.Property(e => e.EmoteText7).HasColumnName("EmoteText_7");
            entity.Property(e => e.EmoteText8).HasColumnName("EmoteText_8");
            entity.Property(e => e.EmoteText9).HasColumnName("EmoteText_9");
            entity.Property(e => e.Name).HasColumnType("text");

            entity.HasOne(d => d.Emote).WithMany(p => p.Emotestexts)
                .HasForeignKey(d => d.EmoteId)
                .HasConstraintName("emotestext_ibfk_1");

            entity.HasOne(d => d.EmoteText1Navigation).WithMany(p => p.EmotestextEmoteText1Navigations)
                .HasForeignKey(d => d.EmoteText1)
                .HasConstraintName("emotestext_ibfk_2");

            entity.HasOne(d => d.EmoteText10Navigation).WithMany(p => p.EmotestextEmoteText10Navigations)
                .HasForeignKey(d => d.EmoteText10)
                .HasConstraintName("emotestext_ibfk_11");

            entity.HasOne(d => d.EmoteText11Navigation).WithMany(p => p.EmotestextEmoteText11Navigations)
                .HasForeignKey(d => d.EmoteText11)
                .HasConstraintName("emotestext_ibfk_12");

            entity.HasOne(d => d.EmoteText12Navigation).WithMany(p => p.EmotestextEmoteText12Navigations)
                .HasForeignKey(d => d.EmoteText12)
                .HasConstraintName("emotestext_ibfk_13");

            entity.HasOne(d => d.EmoteText13Navigation).WithMany(p => p.EmotestextEmoteText13Navigations)
                .HasForeignKey(d => d.EmoteText13)
                .HasConstraintName("emotestext_ibfk_14");

            entity.HasOne(d => d.EmoteText14Navigation).WithMany(p => p.EmotestextEmoteText14Navigations)
                .HasForeignKey(d => d.EmoteText14)
                .HasConstraintName("emotestext_ibfk_15");

            entity.HasOne(d => d.EmoteText15Navigation).WithMany(p => p.EmotestextEmoteText15Navigations)
                .HasForeignKey(d => d.EmoteText15)
                .HasConstraintName("emotestext_ibfk_16");

            entity.HasOne(d => d.EmoteText16Navigation).WithMany(p => p.EmotestextEmoteText16Navigations)
                .HasForeignKey(d => d.EmoteText16)
                .HasConstraintName("emotestext_ibfk_17");

            entity.HasOne(d => d.EmoteText2Navigation).WithMany(p => p.EmotestextEmoteText2Navigations)
                .HasForeignKey(d => d.EmoteText2)
                .HasConstraintName("emotestext_ibfk_3");

            entity.HasOne(d => d.EmoteText3Navigation).WithMany(p => p.EmotestextEmoteText3Navigations)
                .HasForeignKey(d => d.EmoteText3)
                .HasConstraintName("emotestext_ibfk_4");

            entity.HasOne(d => d.EmoteText4Navigation).WithMany(p => p.EmotestextEmoteText4Navigations)
                .HasForeignKey(d => d.EmoteText4)
                .HasConstraintName("emotestext_ibfk_5");

            entity.HasOne(d => d.EmoteText5Navigation).WithMany(p => p.EmotestextEmoteText5Navigations)
                .HasForeignKey(d => d.EmoteText5)
                .HasConstraintName("emotestext_ibfk_6");

            entity.HasOne(d => d.EmoteText6Navigation).WithMany(p => p.EmotestextEmoteText6Navigations)
                .HasForeignKey(d => d.EmoteText6)
                .HasConstraintName("emotestext_ibfk_7");

            entity.HasOne(d => d.EmoteText7Navigation).WithMany(p => p.EmotestextEmoteText7Navigations)
                .HasForeignKey(d => d.EmoteText7)
                .HasConstraintName("emotestext_ibfk_8");

            entity.HasOne(d => d.EmoteText8Navigation).WithMany(p => p.EmotestextEmoteText8Navigations)
                .HasForeignKey(d => d.EmoteText8)
                .HasConstraintName("emotestext_ibfk_9");

            entity.HasOne(d => d.EmoteText9Navigation).WithMany(p => p.EmotestextEmoteText9Navigations)
                .HasForeignKey(d => d.EmoteText9)
                .HasConstraintName("emotestext_ibfk_10");
        });

        modelBuilder.Entity<Emotestextdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("emotestextdata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TextLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_deDE");
            entity.Property(e => e.TextLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enCN");
            entity.Property(e => e.TextLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enGB");
            entity.Property(e => e.TextLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enTW");
            entity.Property(e => e.TextLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enUS");
            entity.Property(e => e.TextLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esES");
            entity.Property(e => e.TextLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esMX");
            entity.Property(e => e.TextLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_frFR");
            entity.Property(e => e.TextLangItIt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_itIT");
            entity.Property(e => e.TextLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_koKR");
            entity.Property(e => e.TextLangMask).HasColumnName("Text_Lang_Mask");
            entity.Property(e => e.TextLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptBR");
            entity.Property(e => e.TextLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptPT");
            entity.Property(e => e.TextLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ruRU");
            entity.Property(e => e.TextLangUnk)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_Unk");
            entity.Property(e => e.TextLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhCN");
            entity.Property(e => e.TextLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhTW");
        });

        modelBuilder.Entity<Emotestextsound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("emotestextsound")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.EmotesTextId, "EmotesTextID");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmotesTextId).HasColumnName("EmotesTextID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.EmotesText).WithMany(p => p.Emotestextsounds)
                .HasForeignKey(d => d.EmotesTextId)
                .HasConstraintName("emotestextsound_ibfk_1");

            entity.HasOne(d => d.Race).WithMany(p => p.Emotestextsounds)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("emotestextsound_ibfk_2");

            entity.HasOne(d => d.Sound).WithMany(p => p.Emotestextsounds)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("emotestextsound_ibfk_3");
        });

        modelBuilder.Entity<Environmentaldamage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("environmentaldamage")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.VisualkitId, "VisualkitID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EnumId).HasColumnName("EnumID");
            entity.Property(e => e.VisualkitId).HasColumnName("VisualkitID");

            entity.HasOne(d => d.Visualkit).WithMany(p => p.Environmentaldamages)
                .HasForeignKey(d => d.VisualkitId)
                .HasConstraintName("environmentaldamage_ibfk_1");
        });

        modelBuilder.Entity<Exhaustion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("exhaustion")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Faction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("faction")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ParentFactionId, "ParentFactionID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.ParentFactionCap1).HasColumnName("ParentFactionCap_1");
            entity.Property(e => e.ParentFactionCap2).HasColumnName("ParentFactionCap_2");
            entity.Property(e => e.ParentFactionId).HasColumnName("ParentFactionID");
            entity.Property(e => e.ParentFactionMod1).HasColumnName("ParentFactionMod_1");
            entity.Property(e => e.ParentFactionMod2).HasColumnName("ParentFactionMod_2");
            entity.Property(e => e.ReputationBase1).HasColumnName("ReputationBase_1");
            entity.Property(e => e.ReputationBase2).HasColumnName("ReputationBase_2");
            entity.Property(e => e.ReputationBase3).HasColumnName("ReputationBase_3");
            entity.Property(e => e.ReputationBase4).HasColumnName("ReputationBase_4");
            entity.Property(e => e.ReputationClassMask1).HasColumnName("ReputationClassMask_1");
            entity.Property(e => e.ReputationClassMask2).HasColumnName("ReputationClassMask_2");
            entity.Property(e => e.ReputationClassMask3).HasColumnName("ReputationClassMask_3");
            entity.Property(e => e.ReputationClassMask4).HasColumnName("ReputationClassMask_4");
            entity.Property(e => e.ReputationFlags1).HasColumnName("ReputationFlags_1");
            entity.Property(e => e.ReputationFlags2).HasColumnName("ReputationFlags_2");
            entity.Property(e => e.ReputationFlags3).HasColumnName("ReputationFlags_3");
            entity.Property(e => e.ReputationFlags4).HasColumnName("ReputationFlags_4");
            entity.Property(e => e.ReputationRaceMask1).HasColumnName("ReputationRaceMask_1");
            entity.Property(e => e.ReputationRaceMask2).HasColumnName("ReputationRaceMask_2");
            entity.Property(e => e.ReputationRaceMask3).HasColumnName("ReputationRaceMask_3");
            entity.Property(e => e.ReputationRaceMask4).HasColumnName("ReputationRaceMask_4");

            entity.HasOne(d => d.ParentFaction).WithMany(p => p.InverseParentFaction)
                .HasForeignKey(d => d.ParentFactionId)
                .HasConstraintName("faction_ibfk_1");
        });

        modelBuilder.Entity<Factiongroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("factiongroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.InternalName).HasColumnType("text");
            entity.Property(e => e.MaskId).HasColumnName("MaskID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Factiontemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("factiontemplate")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Enemies1, "Enemies_1");

            entity.HasIndex(e => e.Enemies2, "Enemies_2");

            entity.HasIndex(e => e.Enemies3, "Enemies_3");

            entity.HasIndex(e => e.Enemies4, "Enemies_4");

            entity.HasIndex(e => e.Faction, "Faction");

            entity.HasIndex(e => e.Friend1, "Friend_1");

            entity.HasIndex(e => e.Friend2, "Friend_2");

            entity.HasIndex(e => e.Friend3, "Friend_3");

            entity.HasIndex(e => e.Friend4, "Friend_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Enemies1).HasColumnName("Enemies_1");
            entity.Property(e => e.Enemies2).HasColumnName("Enemies_2");
            entity.Property(e => e.Enemies3).HasColumnName("Enemies_3");
            entity.Property(e => e.Enemies4).HasColumnName("Enemies_4");
            entity.Property(e => e.Friend1).HasColumnName("Friend_1");
            entity.Property(e => e.Friend2).HasColumnName("Friend_2");
            entity.Property(e => e.Friend3).HasColumnName("Friend_3");
            entity.Property(e => e.Friend4).HasColumnName("Friend_4");

            entity.HasOne(d => d.Enemies1Navigation).WithMany(p => p.FactiontemplateEnemies1Navigations)
                .HasForeignKey(d => d.Enemies1)
                .HasConstraintName("factiontemplate_ibfk_2");

            entity.HasOne(d => d.Enemies2Navigation).WithMany(p => p.FactiontemplateEnemies2Navigations)
                .HasForeignKey(d => d.Enemies2)
                .HasConstraintName("factiontemplate_ibfk_3");

            entity.HasOne(d => d.Enemies3Navigation).WithMany(p => p.FactiontemplateEnemies3Navigations)
                .HasForeignKey(d => d.Enemies3)
                .HasConstraintName("factiontemplate_ibfk_4");

            entity.HasOne(d => d.Enemies4Navigation).WithMany(p => p.FactiontemplateEnemies4Navigations)
                .HasForeignKey(d => d.Enemies4)
                .HasConstraintName("factiontemplate_ibfk_5");

            entity.HasOne(d => d.FactionNavigation).WithMany(p => p.FactiontemplateFactionNavigations)
                .HasForeignKey(d => d.Faction)
                .HasConstraintName("factiontemplate_ibfk_1");

            entity.HasOne(d => d.Friend1Navigation).WithMany(p => p.FactiontemplateFriend1Navigations)
                .HasForeignKey(d => d.Friend1)
                .HasConstraintName("factiontemplate_ibfk_6");

            entity.HasOne(d => d.Friend2Navigation).WithMany(p => p.FactiontemplateFriend2Navigations)
                .HasForeignKey(d => d.Friend2)
                .HasConstraintName("factiontemplate_ibfk_7");

            entity.HasOne(d => d.Friend3Navigation).WithMany(p => p.FactiontemplateFriend3Navigations)
                .HasForeignKey(d => d.Friend3)
                .HasConstraintName("factiontemplate_ibfk_8");

            entity.HasOne(d => d.Friend4Navigation).WithMany(p => p.FactiontemplateFriend4Navigations)
                .HasForeignKey(d => d.Friend4)
                .HasConstraintName("factiontemplate_ibfk_9");
        });

        modelBuilder.Entity<Filedatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("filedata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Filename).HasColumnType("text");
            entity.Property(e => e.Filepath).HasColumnType("text");
        });

        modelBuilder.Entity<Footprinttexture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("footprinttextures")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FootstepFilename).HasColumnType("text");
        });

        modelBuilder.Entity<Footstepterrainlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("footstepterrainlookup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatureFootstepId, "CreatureFootstepID");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.HasIndex(e => e.SoundIdsplash, "SoundIDSplash");

            entity.HasIndex(e => e.TerrainSoundId, "TerrainSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatureFootstepId).HasColumnName("CreatureFootstepID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.SoundIdsplash).HasColumnName("SoundIDSplash");
            entity.Property(e => e.TerrainSoundId).HasColumnName("TerrainSoundID");

            entity.HasOne(d => d.CreatureFootstep).WithMany(p => p.Footstepterrainlookups)
                .HasForeignKey(d => d.CreatureFootstepId)
                .HasConstraintName("footstepterrainlookup_ibfk_1");

            entity.HasOne(d => d.Sound).WithMany(p => p.FootstepterrainlookupSounds)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("footstepterrainlookup_ibfk_3");

            entity.HasOne(d => d.SoundIdsplashNavigation).WithMany(p => p.FootstepterrainlookupSoundIdsplashNavigations)
                .HasForeignKey(d => d.SoundIdsplash)
                .HasConstraintName("footstepterrainlookup_ibfk_4");

            entity.HasOne(d => d.TerrainSound).WithMany(p => p.Footstepterrainlookups)
                .HasForeignKey(d => d.TerrainSoundId)
                .HasConstraintName("footstepterrainlookup_ibfk_2");
        });

        modelBuilder.Entity<Gameobjectartkit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gameobjectartkit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttachModel1)
                .HasColumnType("text")
                .HasColumnName("AttachModel_1");
            entity.Property(e => e.AttachModel2)
                .HasColumnType("text")
                .HasColumnName("AttachModel_2");
            entity.Property(e => e.AttachModel3)
                .HasColumnType("text")
                .HasColumnName("AttachModel_3");
            entity.Property(e => e.AttachModel4)
                .HasColumnType("text")
                .HasColumnName("AttachModel_4");
            entity.Property(e => e.TextureVariation1)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_1");
            entity.Property(e => e.TextureVariation2)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_2");
            entity.Property(e => e.TextureVariation3)
                .HasColumnType("text")
                .HasColumnName("TextureVariation_3");
        });

        modelBuilder.Entity<Gameobjectdisplayinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gameobjectdisplayinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ObjectEffectPackageId, "ObjectEffectPackageID");

            entity.HasIndex(e => e.Sound1, "Sound_1");

            entity.HasIndex(e => e.Sound10, "Sound_10");

            entity.HasIndex(e => e.Sound2, "Sound_2");

            entity.HasIndex(e => e.Sound3, "Sound_3");

            entity.HasIndex(e => e.Sound4, "Sound_4");

            entity.HasIndex(e => e.Sound5, "Sound_5");

            entity.HasIndex(e => e.Sound6, "Sound_6");

            entity.HasIndex(e => e.Sound7, "Sound_7");

            entity.HasIndex(e => e.Sound8, "Sound_8");

            entity.HasIndex(e => e.Sound9, "Sound_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ModelName).HasColumnType("text");
            entity.Property(e => e.ObjectEffectPackageId).HasColumnName("ObjectEffectPackageID");
            entity.Property(e => e.Sound1).HasColumnName("Sound_1");
            entity.Property(e => e.Sound10).HasColumnName("Sound_10");
            entity.Property(e => e.Sound2).HasColumnName("Sound_2");
            entity.Property(e => e.Sound3).HasColumnName("Sound_3");
            entity.Property(e => e.Sound4).HasColumnName("Sound_4");
            entity.Property(e => e.Sound5).HasColumnName("Sound_5");
            entity.Property(e => e.Sound6).HasColumnName("Sound_6");
            entity.Property(e => e.Sound7).HasColumnName("Sound_7");
            entity.Property(e => e.Sound8).HasColumnName("Sound_8");
            entity.Property(e => e.Sound9).HasColumnName("Sound_9");

            entity.HasOne(d => d.ObjectEffectPackage).WithMany(p => p.Gameobjectdisplayinfos)
                .HasForeignKey(d => d.ObjectEffectPackageId)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_11");

            entity.HasOne(d => d.Sound1Navigation).WithMany(p => p.GameobjectdisplayinfoSound1Navigations)
                .HasForeignKey(d => d.Sound1)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_1");

            entity.HasOne(d => d.Sound10Navigation).WithMany(p => p.GameobjectdisplayinfoSound10Navigations)
                .HasForeignKey(d => d.Sound10)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_10");

            entity.HasOne(d => d.Sound2Navigation).WithMany(p => p.GameobjectdisplayinfoSound2Navigations)
                .HasForeignKey(d => d.Sound2)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_2");

            entity.HasOne(d => d.Sound3Navigation).WithMany(p => p.GameobjectdisplayinfoSound3Navigations)
                .HasForeignKey(d => d.Sound3)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_3");

            entity.HasOne(d => d.Sound4Navigation).WithMany(p => p.GameobjectdisplayinfoSound4Navigations)
                .HasForeignKey(d => d.Sound4)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_4");

            entity.HasOne(d => d.Sound5Navigation).WithMany(p => p.GameobjectdisplayinfoSound5Navigations)
                .HasForeignKey(d => d.Sound5)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_5");

            entity.HasOne(d => d.Sound6Navigation).WithMany(p => p.GameobjectdisplayinfoSound6Navigations)
                .HasForeignKey(d => d.Sound6)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_6");

            entity.HasOne(d => d.Sound7Navigation).WithMany(p => p.GameobjectdisplayinfoSound7Navigations)
                .HasForeignKey(d => d.Sound7)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_7");

            entity.HasOne(d => d.Sound8Navigation).WithMany(p => p.GameobjectdisplayinfoSound8Navigations)
                .HasForeignKey(d => d.Sound8)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_8");

            entity.HasOne(d => d.Sound9Navigation).WithMany(p => p.GameobjectdisplayinfoSound9Navigations)
                .HasForeignKey(d => d.Sound9)
                .HasConstraintName("gameobjectdisplayinfo_ibfk_9");
        });

        modelBuilder.Entity<Gametable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gametables")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Gametip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gametips")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TextLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_deDE");
            entity.Property(e => e.TextLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enCN");
            entity.Property(e => e.TextLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enGB");
            entity.Property(e => e.TextLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enTW");
            entity.Property(e => e.TextLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enUS");
            entity.Property(e => e.TextLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esES");
            entity.Property(e => e.TextLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esMX");
            entity.Property(e => e.TextLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_frFR");
            entity.Property(e => e.TextLangItIt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_itIT");
            entity.Property(e => e.TextLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_koKR");
            entity.Property(e => e.TextLangMask).HasColumnName("Text_Lang_Mask");
            entity.Property(e => e.TextLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptBR");
            entity.Property(e => e.TextLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptPT");
            entity.Property(e => e.TextLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ruRU");
            entity.Property(e => e.TextLangUnk)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_Unk");
            entity.Property(e => e.TextLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhCN");
            entity.Property(e => e.TextLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhTW");
        });

        modelBuilder.Entity<Gemproperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gemproperties")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.EnchantId, "Enchant_Id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EnchantId).HasColumnName("Enchant_Id");
            entity.Property(e => e.MaxcountInv).HasColumnName("Maxcount_Inv");
            entity.Property(e => e.MaxcountItem).HasColumnName("Maxcount_Item");

            entity.HasOne(d => d.Enchant).WithMany(p => p.Gemproperties)
                .HasForeignKey(d => d.EnchantId)
                .HasConstraintName("gemproperties_ibfk_1");
        });

        modelBuilder.Entity<Glyphproperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("glyphproperties")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SpellId, "SpellID");

            entity.HasIndex(e => e.SpellIconId, "SpellIconID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");

            entity.HasOne(d => d.SpellIcon).WithMany(p => p.Glyphproperties)
                .HasForeignKey(d => d.SpellIconId)
                .HasConstraintName("glyphproperties_ibfk_2");

            entity.HasOne(d => d.Spell).WithMany(p => p.Glyphproperties)
                .HasForeignKey(d => d.SpellId)
                .HasConstraintName("glyphproperties_ibfk_1");
        });

        modelBuilder.Entity<Glyphslot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("glyphslot")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gmsurveyanswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gmsurveyanswers")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GmsurveyQuestionId, "GMSurveyQuestionID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AnswerLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_deDE");
            entity.Property(e => e.AnswerLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_enCN");
            entity.Property(e => e.AnswerLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_enGB");
            entity.Property(e => e.AnswerLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_enTW");
            entity.Property(e => e.AnswerLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_enUS");
            entity.Property(e => e.AnswerLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_esES");
            entity.Property(e => e.AnswerLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_esMX");
            entity.Property(e => e.AnswerLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_frFR");
            entity.Property(e => e.AnswerLangItIt)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_itIT");
            entity.Property(e => e.AnswerLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_koKR");
            entity.Property(e => e.AnswerLangMask).HasColumnName("Answer_Lang_Mask");
            entity.Property(e => e.AnswerLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_ptBR");
            entity.Property(e => e.AnswerLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_ptPT");
            entity.Property(e => e.AnswerLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_ruRU");
            entity.Property(e => e.AnswerLangUnk)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_Unk");
            entity.Property(e => e.AnswerLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_zhCN");
            entity.Property(e => e.AnswerLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Answer_Lang_zhTW");
            entity.Property(e => e.GmsurveyQuestionId).HasColumnName("GMSurveyQuestionID");
            entity.Property(e => e.SortIndex).HasColumnName("Sort_Index");

            entity.HasOne(d => d.GmsurveyQuestion).WithMany(p => p.Gmsurveyanswers)
                .HasForeignKey(d => d.GmsurveyQuestionId)
                .HasConstraintName("gmsurveyanswers_ibfk_1");
        });

        modelBuilder.Entity<Gmsurveycurrentsurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gmsurveycurrentsurvey")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GmsurveyId, "GMSURVEY_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GmsurveyId).HasColumnName("GMSURVEY_ID");

            entity.HasOne(d => d.Gmsurvey).WithMany(p => p.Gmsurveycurrentsurveys)
                .HasForeignKey(d => d.GmsurveyId)
                .HasConstraintName("gmsurveycurrentsurvey_ibfk_1");
        });

        modelBuilder.Entity<Gmsurveyquestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gmsurveyquestions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.QuestionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_deDE");
            entity.Property(e => e.QuestionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_enCN");
            entity.Property(e => e.QuestionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_enGB");
            entity.Property(e => e.QuestionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_enTW");
            entity.Property(e => e.QuestionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_enUS");
            entity.Property(e => e.QuestionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_esES");
            entity.Property(e => e.QuestionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_esMX");
            entity.Property(e => e.QuestionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_frFR");
            entity.Property(e => e.QuestionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_itIT");
            entity.Property(e => e.QuestionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_koKR");
            entity.Property(e => e.QuestionLangMask).HasColumnName("Question_Lang_Mask");
            entity.Property(e => e.QuestionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_ptBR");
            entity.Property(e => e.QuestionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_ptPT");
            entity.Property(e => e.QuestionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_ruRU");
            entity.Property(e => e.QuestionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_Unk");
            entity.Property(e => e.QuestionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_zhCN");
            entity.Property(e => e.QuestionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Question_Lang_zhTW");
        });

        modelBuilder.Entity<Gmsurveysurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gmsurveysurveys")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Q1, "Q_1");

            entity.HasIndex(e => e.Q10, "Q_10");

            entity.HasIndex(e => e.Q2, "Q_2");

            entity.HasIndex(e => e.Q3, "Q_3");

            entity.HasIndex(e => e.Q4, "Q_4");

            entity.HasIndex(e => e.Q5, "Q_5");

            entity.HasIndex(e => e.Q6, "Q_6");

            entity.HasIndex(e => e.Q7, "Q_7");

            entity.HasIndex(e => e.Q8, "Q_8");

            entity.HasIndex(e => e.Q9, "Q_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Q1).HasColumnName("Q_1");
            entity.Property(e => e.Q10).HasColumnName("Q_10");
            entity.Property(e => e.Q2).HasColumnName("Q_2");
            entity.Property(e => e.Q3).HasColumnName("Q_3");
            entity.Property(e => e.Q4).HasColumnName("Q_4");
            entity.Property(e => e.Q5).HasColumnName("Q_5");
            entity.Property(e => e.Q6).HasColumnName("Q_6");
            entity.Property(e => e.Q7).HasColumnName("Q_7");
            entity.Property(e => e.Q8).HasColumnName("Q_8");
            entity.Property(e => e.Q9).HasColumnName("Q_9");

            entity.HasOne(d => d.Q1Navigation).WithMany(p => p.GmsurveysurveyQ1Navigations)
                .HasForeignKey(d => d.Q1)
                .HasConstraintName("gmsurveysurveys_ibfk_1");

            entity.HasOne(d => d.Q10Navigation).WithMany(p => p.GmsurveysurveyQ10Navigations)
                .HasForeignKey(d => d.Q10)
                .HasConstraintName("gmsurveysurveys_ibfk_10");

            entity.HasOne(d => d.Q2Navigation).WithMany(p => p.GmsurveysurveyQ2Navigations)
                .HasForeignKey(d => d.Q2)
                .HasConstraintName("gmsurveysurveys_ibfk_2");

            entity.HasOne(d => d.Q3Navigation).WithMany(p => p.GmsurveysurveyQ3Navigations)
                .HasForeignKey(d => d.Q3)
                .HasConstraintName("gmsurveysurveys_ibfk_3");

            entity.HasOne(d => d.Q4Navigation).WithMany(p => p.GmsurveysurveyQ4Navigations)
                .HasForeignKey(d => d.Q4)
                .HasConstraintName("gmsurveysurveys_ibfk_4");

            entity.HasOne(d => d.Q5Navigation).WithMany(p => p.GmsurveysurveyQ5Navigations)
                .HasForeignKey(d => d.Q5)
                .HasConstraintName("gmsurveysurveys_ibfk_5");

            entity.HasOne(d => d.Q6Navigation).WithMany(p => p.GmsurveysurveyQ6Navigations)
                .HasForeignKey(d => d.Q6)
                .HasConstraintName("gmsurveysurveys_ibfk_6");

            entity.HasOne(d => d.Q7Navigation).WithMany(p => p.GmsurveysurveyQ7Navigations)
                .HasForeignKey(d => d.Q7)
                .HasConstraintName("gmsurveysurveys_ibfk_7");

            entity.HasOne(d => d.Q8Navigation).WithMany(p => p.GmsurveysurveyQ8Navigations)
                .HasForeignKey(d => d.Q8)
                .HasConstraintName("gmsurveysurveys_ibfk_8");

            entity.HasOne(d => d.Q9Navigation).WithMany(p => p.GmsurveysurveyQ9Navigations)
                .HasForeignKey(d => d.Q9)
                .HasConstraintName("gmsurveysurveys_ibfk_9");
        });

        modelBuilder.Entity<Gmticketcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gmticketcategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_deDE");
            entity.Property(e => e.CategoryLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_enCN");
            entity.Property(e => e.CategoryLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_enGB");
            entity.Property(e => e.CategoryLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_enTW");
            entity.Property(e => e.CategoryLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_enUS");
            entity.Property(e => e.CategoryLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_esES");
            entity.Property(e => e.CategoryLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_esMX");
            entity.Property(e => e.CategoryLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_frFR");
            entity.Property(e => e.CategoryLangItIt)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_itIT");
            entity.Property(e => e.CategoryLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_koKR");
            entity.Property(e => e.CategoryLangMask).HasColumnName("Category_Lang_Mask");
            entity.Property(e => e.CategoryLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_ptBR");
            entity.Property(e => e.CategoryLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_ptPT");
            entity.Property(e => e.CategoryLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_ruRU");
            entity.Property(e => e.CategoryLangUnk)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_Unk");
            entity.Property(e => e.CategoryLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_zhCN");
            entity.Property(e => e.CategoryLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Category_Lang_zhTW");
        });

        modelBuilder.Entity<Groundeffectdoodad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("groundeffectdoodad")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Doodadpath).HasColumnType("text");
        });

        modelBuilder.Entity<Groundeffecttexture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("groundeffecttexture")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DoodadId1, "DoodadId_1");

            entity.HasIndex(e => e.DoodadId2, "DoodadId_2");

            entity.HasIndex(e => e.DoodadId3, "DoodadId_3");

            entity.HasIndex(e => e.DoodadId4, "DoodadId_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DoodadId1).HasColumnName("DoodadId_1");
            entity.Property(e => e.DoodadId2).HasColumnName("DoodadId_2");
            entity.Property(e => e.DoodadId3).HasColumnName("DoodadId_3");
            entity.Property(e => e.DoodadId4).HasColumnName("DoodadId_4");
            entity.Property(e => e.DoodadWeight1).HasColumnName("DoodadWeight_1");
            entity.Property(e => e.DoodadWeight2).HasColumnName("DoodadWeight_2");
            entity.Property(e => e.DoodadWeight3).HasColumnName("DoodadWeight_3");
            entity.Property(e => e.DoodadWeight4).HasColumnName("DoodadWeight_4");

            entity.HasOne(d => d.DoodadId1Navigation).WithMany(p => p.GroundeffecttextureDoodadId1Navigations)
                .HasForeignKey(d => d.DoodadId1)
                .HasConstraintName("groundeffecttexture_ibfk_1");

            entity.HasOne(d => d.DoodadId2Navigation).WithMany(p => p.GroundeffecttextureDoodadId2Navigations)
                .HasForeignKey(d => d.DoodadId2)
                .HasConstraintName("groundeffecttexture_ibfk_2");

            entity.HasOne(d => d.DoodadId3Navigation).WithMany(p => p.GroundeffecttextureDoodadId3Navigations)
                .HasForeignKey(d => d.DoodadId3)
                .HasConstraintName("groundeffecttexture_ibfk_3");

            entity.HasOne(d => d.DoodadId4Navigation).WithMany(p => p.GroundeffecttextureDoodadId4Navigations)
                .HasForeignKey(d => d.DoodadId4)
                .HasConstraintName("groundeffecttexture_ibfk_4");
        });

        modelBuilder.Entity<Gtbarbershopcostbase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtbarbershopcostbase")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtchancetomeleecrit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtchancetomeleecrit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtchancetomeleecritbase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtchancetomeleecritbase")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtchancetospellcrit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtchancetospellcrit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtchancetospellcritbase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtchancetospellcritbase")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtcombatrating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtcombatratings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtnpcmanacostscaler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtnpcmanacostscaler")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtoctclasscombatratingscalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtoctclasscombatratingscalar")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtoctregenhp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtoctregenhp")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtoctregenmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtoctregenmp")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtregenhpperspt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtregenhpperspt")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Gtregenmpperspt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gtregenmpperspt")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Helmetgeosetvisdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("helmetgeosetvisdata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.HideGeoset1).HasColumnName("HideGeoset_1");
            entity.Property(e => e.HideGeoset2).HasColumnName("HideGeoset_2");
            entity.Property(e => e.HideGeoset3).HasColumnName("HideGeoset_3");
            entity.Property(e => e.HideGeoset4).HasColumnName("HideGeoset_4");
            entity.Property(e => e.HideGeoset5).HasColumnName("HideGeoset_5");
            entity.Property(e => e.HideGeoset6).HasColumnName("HideGeoset_6");
            entity.Property(e => e.HideGeoset7).HasColumnName("HideGeoset_7");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("holidays")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.HolidayDescriptionId, "HolidayDescriptionID");

            entity.HasIndex(e => e.HolidayNameId, "HolidayNameID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CalendarFlags1).HasColumnName("CalendarFlags_1");
            entity.Property(e => e.CalendarFlags10).HasColumnName("CalendarFlags_10");
            entity.Property(e => e.CalendarFlags2).HasColumnName("CalendarFlags_2");
            entity.Property(e => e.CalendarFlags3).HasColumnName("CalendarFlags_3");
            entity.Property(e => e.CalendarFlags4).HasColumnName("CalendarFlags_4");
            entity.Property(e => e.CalendarFlags5).HasColumnName("CalendarFlags_5");
            entity.Property(e => e.CalendarFlags6).HasColumnName("CalendarFlags_6");
            entity.Property(e => e.CalendarFlags7).HasColumnName("CalendarFlags_7");
            entity.Property(e => e.CalendarFlags8).HasColumnName("CalendarFlags_8");
            entity.Property(e => e.CalendarFlags9).HasColumnName("CalendarFlags_9");
            entity.Property(e => e.Date1).HasColumnName("Date_1");
            entity.Property(e => e.Date10).HasColumnName("Date_10");
            entity.Property(e => e.Date11).HasColumnName("Date_11");
            entity.Property(e => e.Date12).HasColumnName("Date_12");
            entity.Property(e => e.Date13).HasColumnName("Date_13");
            entity.Property(e => e.Date14).HasColumnName("Date_14");
            entity.Property(e => e.Date15).HasColumnName("Date_15");
            entity.Property(e => e.Date16).HasColumnName("Date_16");
            entity.Property(e => e.Date17).HasColumnName("Date_17");
            entity.Property(e => e.Date18).HasColumnName("Date_18");
            entity.Property(e => e.Date19).HasColumnName("Date_19");
            entity.Property(e => e.Date2).HasColumnName("Date_2");
            entity.Property(e => e.Date20).HasColumnName("Date_20");
            entity.Property(e => e.Date21).HasColumnName("Date_21");
            entity.Property(e => e.Date22).HasColumnName("Date_22");
            entity.Property(e => e.Date23).HasColumnName("Date_23");
            entity.Property(e => e.Date24).HasColumnName("Date_24");
            entity.Property(e => e.Date25).HasColumnName("Date_25");
            entity.Property(e => e.Date26).HasColumnName("Date_26");
            entity.Property(e => e.Date3).HasColumnName("Date_3");
            entity.Property(e => e.Date4).HasColumnName("Date_4");
            entity.Property(e => e.Date5).HasColumnName("Date_5");
            entity.Property(e => e.Date6).HasColumnName("Date_6");
            entity.Property(e => e.Date7).HasColumnName("Date_7");
            entity.Property(e => e.Date8).HasColumnName("Date_8");
            entity.Property(e => e.Date9).HasColumnName("Date_9");
            entity.Property(e => e.Duration1).HasColumnName("Duration_1");
            entity.Property(e => e.Duration10).HasColumnName("Duration_10");
            entity.Property(e => e.Duration2).HasColumnName("Duration_2");
            entity.Property(e => e.Duration3).HasColumnName("Duration_3");
            entity.Property(e => e.Duration4).HasColumnName("Duration_4");
            entity.Property(e => e.Duration5).HasColumnName("Duration_5");
            entity.Property(e => e.Duration6).HasColumnName("Duration_6");
            entity.Property(e => e.Duration7).HasColumnName("Duration_7");
            entity.Property(e => e.Duration8).HasColumnName("Duration_8");
            entity.Property(e => e.Duration9).HasColumnName("Duration_9");
            entity.Property(e => e.HolidayDescriptionId).HasColumnName("HolidayDescriptionID");
            entity.Property(e => e.HolidayNameId).HasColumnName("HolidayNameID");
            entity.Property(e => e.TextureFilename).HasColumnType("text");

            entity.HasOne(d => d.HolidayDescription).WithMany(p => p.Holidays)
                .HasForeignKey(d => d.HolidayDescriptionId)
                .HasConstraintName("holidays_ibfk_2");

            entity.HasOne(d => d.HolidayName).WithMany(p => p.Holidays)
                .HasForeignKey(d => d.HolidayNameId)
                .HasConstraintName("holidays_ibfk_1");
        });

        modelBuilder.Entity<Holidaydescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("holidaydescriptions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
        });

        modelBuilder.Entity<Holidayname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("holidaynames")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("item")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ClassId, "ClassID");

            entity.HasIndex(e => e.DisplayInfoId, "DisplayInfoID");

            entity.HasIndex(e => e.Material, "Material");

            entity.HasIndex(e => e.SubclassId, "SubclassID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DisplayInfoId).HasColumnName("DisplayInfoID");
            entity.Property(e => e.SoundOverrideSubclassid).HasColumnName("Sound_Override_Subclassid");
            entity.Property(e => e.SubclassId).HasColumnName("SubclassID");

            entity.HasOne(d => d.Class).WithMany(p => p.Items)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("item_ibfk_1");

            entity.HasOne(d => d.DisplayInfo).WithMany(p => p.Items)
                .HasForeignKey(d => d.DisplayInfoId)
                .HasConstraintName("item_ibfk_4");

            entity.HasOne(d => d.MaterialNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.Material)
                .HasConstraintName("item_ibfk_3");

            entity.HasOne(d => d.Subclass).WithMany(p => p.Items)
                .HasForeignKey(d => d.SubclassId)
                .HasConstraintName("item_ibfk_2");
        });

        modelBuilder.Entity<Itembagfamily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itembagfamily")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Itemclass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemclass")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_deDE");
            entity.Property(e => e.ClassNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_enCN");
            entity.Property(e => e.ClassNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_enGB");
            entity.Property(e => e.ClassNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_enTW");
            entity.Property(e => e.ClassNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_enUS");
            entity.Property(e => e.ClassNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_esES");
            entity.Property(e => e.ClassNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_esMX");
            entity.Property(e => e.ClassNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_frFR");
            entity.Property(e => e.ClassNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_itIT");
            entity.Property(e => e.ClassNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_koKR");
            entity.Property(e => e.ClassNameLangMask).HasColumnName("ClassName_Lang_Mask");
            entity.Property(e => e.ClassNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_ptBR");
            entity.Property(e => e.ClassNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_ptPT");
            entity.Property(e => e.ClassNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_ruRU");
            entity.Property(e => e.ClassNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_Unk");
            entity.Property(e => e.ClassNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_zhCN");
            entity.Property(e => e.ClassNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("ClassName_Lang_zhTW");
            entity.Property(e => e.SubclassMapId).HasColumnName("SubclassMapID");
        });

        modelBuilder.Entity<Itemcondextcost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemcondextcosts")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Itemdisplayinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemdisplayinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GroupSoundIndex, "GroupSoundIndex");

            entity.HasIndex(e => e.HelmetGeosetVis1, "HelmetGeosetVis_1");

            entity.HasIndex(e => e.HelmetGeosetVis2, "HelmetGeosetVis_2");

            entity.HasIndex(e => e.ItemVisual, "ItemVisual");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GeosetGroup1).HasColumnName("GeosetGroup_1");
            entity.Property(e => e.GeosetGroup2).HasColumnName("GeosetGroup_2");
            entity.Property(e => e.GeosetGroup3).HasColumnName("GeosetGroup_3");
            entity.Property(e => e.HelmetGeosetVis1).HasColumnName("HelmetGeosetVis_1");
            entity.Property(e => e.HelmetGeosetVis2).HasColumnName("HelmetGeosetVis_2");
            entity.Property(e => e.InventoryIcon1)
                .HasColumnType("text")
                .HasColumnName("InventoryIcon_1");
            entity.Property(e => e.InventoryIcon2)
                .HasColumnType("text")
                .HasColumnName("InventoryIcon_2");
            entity.Property(e => e.ModelName1)
                .HasColumnType("text")
                .HasColumnName("ModelName_1");
            entity.Property(e => e.ModelName2)
                .HasColumnType("text")
                .HasColumnName("ModelName_2");
            entity.Property(e => e.ModelTexture1)
                .HasColumnType("text")
                .HasColumnName("ModelTexture_1");
            entity.Property(e => e.ModelTexture2)
                .HasColumnType("text")
                .HasColumnName("ModelTexture_2");
            entity.Property(e => e.ParticleColorId).HasColumnName("ParticleColorID");
            entity.Property(e => e.SpellVisualId).HasColumnName("SpellVisualID");
            entity.Property(e => e.Texture1)
                .HasColumnType("text")
                .HasColumnName("Texture_1");
            entity.Property(e => e.Texture2)
                .HasColumnType("text")
                .HasColumnName("Texture_2");
            entity.Property(e => e.Texture3)
                .HasColumnType("text")
                .HasColumnName("Texture_3");
            entity.Property(e => e.Texture4)
                .HasColumnType("text")
                .HasColumnName("Texture_4");
            entity.Property(e => e.Texture5)
                .HasColumnType("text")
                .HasColumnName("Texture_5");
            entity.Property(e => e.Texture6)
                .HasColumnType("text")
                .HasColumnName("Texture_6");
            entity.Property(e => e.Texture7)
                .HasColumnType("text")
                .HasColumnName("Texture_7");
            entity.Property(e => e.Texture8)
                .HasColumnType("text")
                .HasColumnName("Texture_8");

            entity.HasOne(d => d.GroupSoundIndexNavigation).WithMany(p => p.Itemdisplayinfos)
                .HasForeignKey(d => d.GroupSoundIndex)
                .HasConstraintName("itemdisplayinfo_ibfk_1");

            entity.HasOne(d => d.HelmetGeosetVis1Navigation).WithMany(p => p.ItemdisplayinfoHelmetGeosetVis1Navigations)
                .HasForeignKey(d => d.HelmetGeosetVis1)
                .HasConstraintName("itemdisplayinfo_ibfk_2");

            entity.HasOne(d => d.HelmetGeosetVis2Navigation).WithMany(p => p.ItemdisplayinfoHelmetGeosetVis2Navigations)
                .HasForeignKey(d => d.HelmetGeosetVis2)
                .HasConstraintName("itemdisplayinfo_ibfk_3");

            entity.HasOne(d => d.ItemVisualNavigation).WithMany(p => p.Itemdisplayinfos)
                .HasForeignKey(d => d.ItemVisual)
                .HasConstraintName("itemdisplayinfo_ibfk_4");
        });

        modelBuilder.Entity<Itemextendedcost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemextendedcost")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemPurchaseGroup, "ItemPurchaseGroup");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemCount1).HasColumnName("ItemCount_1");
            entity.Property(e => e.ItemCount2).HasColumnName("ItemCount_2");
            entity.Property(e => e.ItemCount3).HasColumnName("ItemCount_3");
            entity.Property(e => e.ItemCount4).HasColumnName("ItemCount_4");
            entity.Property(e => e.ItemCount5).HasColumnName("ItemCount_5");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");

            entity.HasOne(d => d.ItemPurchaseGroupNavigation).WithMany(p => p.Itemextendedcosts)
                .HasForeignKey(d => d.ItemPurchaseGroup)
                .HasConstraintName("itemextendedcost_ibfk_1");
        });

        modelBuilder.Entity<Itemgroupsound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemgroupsounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Sound1, "Sound_1");

            entity.HasIndex(e => e.Sound2, "Sound_2");

            entity.HasIndex(e => e.Sound3, "Sound_3");

            entity.HasIndex(e => e.Sound4, "Sound_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Sound1).HasColumnName("Sound_1");
            entity.Property(e => e.Sound2).HasColumnName("Sound_2");
            entity.Property(e => e.Sound3).HasColumnName("Sound_3");
            entity.Property(e => e.Sound4).HasColumnName("Sound_4");

            entity.HasOne(d => d.Sound1Navigation).WithMany(p => p.ItemgroupsoundSound1Navigations)
                .HasForeignKey(d => d.Sound1)
                .HasConstraintName("itemgroupsounds_ibfk_1");

            entity.HasOne(d => d.Sound2Navigation).WithMany(p => p.ItemgroupsoundSound2Navigations)
                .HasForeignKey(d => d.Sound2)
                .HasConstraintName("itemgroupsounds_ibfk_2");

            entity.HasOne(d => d.Sound3Navigation).WithMany(p => p.ItemgroupsoundSound3Navigations)
                .HasForeignKey(d => d.Sound3)
                .HasConstraintName("itemgroupsounds_ibfk_3");

            entity.HasOne(d => d.Sound4Navigation).WithMany(p => p.ItemgroupsoundSound4Navigations)
                .HasForeignKey(d => d.Sound4)
                .HasConstraintName("itemgroupsounds_ibfk_4");
        });

        modelBuilder.Entity<Itemlimitcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemlimitcategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Itempetfood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itempetfood")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Itempurchasegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itempurchasegroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemId1, "ItemID_1");

            entity.HasIndex(e => e.ItemId2, "ItemID_2");

            entity.HasIndex(e => e.ItemId3, "ItemID_3");

            entity.HasIndex(e => e.ItemId4, "ItemID_4");

            entity.HasIndex(e => e.ItemId5, "ItemID_5");

            entity.HasIndex(e => e.ItemId6, "ItemID_6");

            entity.HasIndex(e => e.ItemId7, "ItemID_7");

            entity.HasIndex(e => e.ItemId8, "ItemID_8");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
            entity.Property(e => e.ItemId6).HasColumnName("ItemID_6");
            entity.Property(e => e.ItemId7).HasColumnName("ItemID_7");
            entity.Property(e => e.ItemId8).HasColumnName("ItemID_8");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.ItemId1Navigation).WithMany(p => p.ItempurchasegroupItemId1Navigations)
                .HasForeignKey(d => d.ItemId1)
                .HasConstraintName("itempurchasegroup_ibfk_1");

            entity.HasOne(d => d.ItemId2Navigation).WithMany(p => p.ItempurchasegroupItemId2Navigations)
                .HasForeignKey(d => d.ItemId2)
                .HasConstraintName("itempurchasegroup_ibfk_2");

            entity.HasOne(d => d.ItemId3Navigation).WithMany(p => p.ItempurchasegroupItemId3Navigations)
                .HasForeignKey(d => d.ItemId3)
                .HasConstraintName("itempurchasegroup_ibfk_3");

            entity.HasOne(d => d.ItemId4Navigation).WithMany(p => p.ItempurchasegroupItemId4Navigations)
                .HasForeignKey(d => d.ItemId4)
                .HasConstraintName("itempurchasegroup_ibfk_4");

            entity.HasOne(d => d.ItemId5Navigation).WithMany(p => p.ItempurchasegroupItemId5Navigations)
                .HasForeignKey(d => d.ItemId5)
                .HasConstraintName("itempurchasegroup_ibfk_5");

            entity.HasOne(d => d.ItemId6Navigation).WithMany(p => p.ItempurchasegroupItemId6Navigations)
                .HasForeignKey(d => d.ItemId6)
                .HasConstraintName("itempurchasegroup_ibfk_6");

            entity.HasOne(d => d.ItemId7Navigation).WithMany(p => p.ItempurchasegroupItemId7Navigations)
                .HasForeignKey(d => d.ItemId7)
                .HasConstraintName("itempurchasegroup_ibfk_7");

            entity.HasOne(d => d.ItemId8Navigation).WithMany(p => p.ItempurchasegroupItemId8Navigations)
                .HasForeignKey(d => d.ItemId8)
                .HasConstraintName("itempurchasegroup_ibfk_8");
        });

        modelBuilder.Entity<Itemrandomproperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemrandomproperties")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Enchantment1, "Enchantment_1");

            entity.HasIndex(e => e.Enchantment2, "Enchantment_2");

            entity.HasIndex(e => e.Enchantment3, "Enchantment_3");

            entity.HasIndex(e => e.Enchantment4, "Enchantment_4");

            entity.HasIndex(e => e.Enchantment5, "Enchantment_5");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Enchantment1).HasColumnName("Enchantment_1");
            entity.Property(e => e.Enchantment2).HasColumnName("Enchantment_2");
            entity.Property(e => e.Enchantment3).HasColumnName("Enchantment_3");
            entity.Property(e => e.Enchantment4).HasColumnName("Enchantment_4");
            entity.Property(e => e.Enchantment5).HasColumnName("Enchantment_5");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.Enchantment1Navigation).WithMany(p => p.ItemrandompropertyEnchantment1Navigations)
                .HasForeignKey(d => d.Enchantment1)
                .HasConstraintName("itemrandomproperties_ibfk_1");

            entity.HasOne(d => d.Enchantment2Navigation).WithMany(p => p.ItemrandompropertyEnchantment2Navigations)
                .HasForeignKey(d => d.Enchantment2)
                .HasConstraintName("itemrandomproperties_ibfk_2");

            entity.HasOne(d => d.Enchantment3Navigation).WithMany(p => p.ItemrandompropertyEnchantment3Navigations)
                .HasForeignKey(d => d.Enchantment3)
                .HasConstraintName("itemrandomproperties_ibfk_3");

            entity.HasOne(d => d.Enchantment4Navigation).WithMany(p => p.ItemrandompropertyEnchantment4Navigations)
                .HasForeignKey(d => d.Enchantment4)
                .HasConstraintName("itemrandomproperties_ibfk_4");

            entity.HasOne(d => d.Enchantment5Navigation).WithMany(p => p.ItemrandompropertyEnchantment5Navigations)
                .HasForeignKey(d => d.Enchantment5)
                .HasConstraintName("itemrandomproperties_ibfk_5");
        });

        modelBuilder.Entity<Itemrandomsuffix>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemrandomsuffix")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Enchantment1, "Enchantment_1");

            entity.HasIndex(e => e.Enchantment2, "Enchantment_2");

            entity.HasIndex(e => e.Enchantment3, "Enchantment_3");

            entity.HasIndex(e => e.Enchantment4, "Enchantment_4");

            entity.HasIndex(e => e.Enchantment5, "Enchantment_5");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AllocationPct1).HasColumnName("AllocationPct_1");
            entity.Property(e => e.AllocationPct2).HasColumnName("AllocationPct_2");
            entity.Property(e => e.AllocationPct3).HasColumnName("AllocationPct_3");
            entity.Property(e => e.AllocationPct4).HasColumnName("AllocationPct_4");
            entity.Property(e => e.AllocationPct5).HasColumnName("AllocationPct_5");
            entity.Property(e => e.Enchantment1).HasColumnName("Enchantment_1");
            entity.Property(e => e.Enchantment2).HasColumnName("Enchantment_2");
            entity.Property(e => e.Enchantment3).HasColumnName("Enchantment_3");
            entity.Property(e => e.Enchantment4).HasColumnName("Enchantment_4");
            entity.Property(e => e.Enchantment5).HasColumnName("Enchantment_5");
            entity.Property(e => e.InternalName).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.Enchantment1Navigation).WithMany(p => p.ItemrandomsuffixEnchantment1Navigations)
                .HasForeignKey(d => d.Enchantment1)
                .HasConstraintName("itemrandomsuffix_ibfk_1");

            entity.HasOne(d => d.Enchantment2Navigation).WithMany(p => p.ItemrandomsuffixEnchantment2Navigations)
                .HasForeignKey(d => d.Enchantment2)
                .HasConstraintName("itemrandomsuffix_ibfk_2");

            entity.HasOne(d => d.Enchantment3Navigation).WithMany(p => p.ItemrandomsuffixEnchantment3Navigations)
                .HasForeignKey(d => d.Enchantment3)
                .HasConstraintName("itemrandomsuffix_ibfk_3");

            entity.HasOne(d => d.Enchantment4Navigation).WithMany(p => p.ItemrandomsuffixEnchantment4Navigations)
                .HasForeignKey(d => d.Enchantment4)
                .HasConstraintName("itemrandomsuffix_ibfk_4");

            entity.HasOne(d => d.Enchantment5Navigation).WithMany(p => p.ItemrandomsuffixEnchantment5Navigations)
                .HasForeignKey(d => d.Enchantment5)
                .HasConstraintName("itemrandomsuffix_ibfk_5");
        });

        modelBuilder.Entity<Itemset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemset")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemId1, "ItemID_1");

            entity.HasIndex(e => e.ItemId10, "ItemID_10");

            entity.HasIndex(e => e.ItemId11, "ItemID_11");

            entity.HasIndex(e => e.ItemId12, "ItemID_12");

            entity.HasIndex(e => e.ItemId13, "ItemID_13");

            entity.HasIndex(e => e.ItemId14, "ItemID_14");

            entity.HasIndex(e => e.ItemId15, "ItemID_15");

            entity.HasIndex(e => e.ItemId16, "ItemID_16");

            entity.HasIndex(e => e.ItemId17, "ItemID_17");

            entity.HasIndex(e => e.ItemId2, "ItemID_2");

            entity.HasIndex(e => e.ItemId3, "ItemID_3");

            entity.HasIndex(e => e.ItemId4, "ItemID_4");

            entity.HasIndex(e => e.ItemId5, "ItemID_5");

            entity.HasIndex(e => e.ItemId6, "ItemID_6");

            entity.HasIndex(e => e.ItemId7, "ItemID_7");

            entity.HasIndex(e => e.ItemId8, "ItemID_8");

            entity.HasIndex(e => e.ItemId9, "ItemID_9");

            entity.HasIndex(e => e.RequiredSkill, "RequiredSkill");

            entity.HasIndex(e => e.SetSpellId1, "SetSpellID_1");

            entity.HasIndex(e => e.SetSpellId2, "SetSpellID_2");

            entity.HasIndex(e => e.SetSpellId3, "SetSpellID_3");

            entity.HasIndex(e => e.SetSpellId4, "SetSpellID_4");

            entity.HasIndex(e => e.SetSpellId5, "SetSpellID_5");

            entity.HasIndex(e => e.SetSpellId6, "SetSpellID_6");

            entity.HasIndex(e => e.SetSpellId7, "SetSpellID_7");

            entity.HasIndex(e => e.SetSpellId8, "SetSpellID_8");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId10).HasColumnName("ItemID_10");
            entity.Property(e => e.ItemId11).HasColumnName("ItemID_11");
            entity.Property(e => e.ItemId12).HasColumnName("ItemID_12");
            entity.Property(e => e.ItemId13).HasColumnName("ItemID_13");
            entity.Property(e => e.ItemId14).HasColumnName("ItemID_14");
            entity.Property(e => e.ItemId15).HasColumnName("ItemID_15");
            entity.Property(e => e.ItemId16).HasColumnName("ItemID_16");
            entity.Property(e => e.ItemId17).HasColumnName("ItemID_17");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
            entity.Property(e => e.ItemId6).HasColumnName("ItemID_6");
            entity.Property(e => e.ItemId7).HasColumnName("ItemID_7");
            entity.Property(e => e.ItemId8).HasColumnName("ItemID_8");
            entity.Property(e => e.ItemId9).HasColumnName("ItemID_9");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SetSpellId1).HasColumnName("SetSpellID_1");
            entity.Property(e => e.SetSpellId2).HasColumnName("SetSpellID_2");
            entity.Property(e => e.SetSpellId3).HasColumnName("SetSpellID_3");
            entity.Property(e => e.SetSpellId4).HasColumnName("SetSpellID_4");
            entity.Property(e => e.SetSpellId5).HasColumnName("SetSpellID_5");
            entity.Property(e => e.SetSpellId6).HasColumnName("SetSpellID_6");
            entity.Property(e => e.SetSpellId7).HasColumnName("SetSpellID_7");
            entity.Property(e => e.SetSpellId8).HasColumnName("SetSpellID_8");
            entity.Property(e => e.SetThreshold1).HasColumnName("SetThreshold_1");
            entity.Property(e => e.SetThreshold2).HasColumnName("SetThreshold_2");
            entity.Property(e => e.SetThreshold3).HasColumnName("SetThreshold_3");
            entity.Property(e => e.SetThreshold4).HasColumnName("SetThreshold_4");
            entity.Property(e => e.SetThreshold5).HasColumnName("SetThreshold_5");
            entity.Property(e => e.SetThreshold6).HasColumnName("SetThreshold_6");
            entity.Property(e => e.SetThreshold7).HasColumnName("SetThreshold_7");
            entity.Property(e => e.SetThreshold8).HasColumnName("SetThreshold_8");

            entity.HasOne(d => d.ItemId1Navigation).WithMany(p => p.ItemsetItemId1Navigations)
                .HasForeignKey(d => d.ItemId1)
                .HasConstraintName("itemset_ibfk_1");

            entity.HasOne(d => d.ItemId10Navigation).WithMany(p => p.ItemsetItemId10Navigations)
                .HasForeignKey(d => d.ItemId10)
                .HasConstraintName("itemset_ibfk_10");

            entity.HasOne(d => d.ItemId11Navigation).WithMany(p => p.ItemsetItemId11Navigations)
                .HasForeignKey(d => d.ItemId11)
                .HasConstraintName("itemset_ibfk_11");

            entity.HasOne(d => d.ItemId12Navigation).WithMany(p => p.ItemsetItemId12Navigations)
                .HasForeignKey(d => d.ItemId12)
                .HasConstraintName("itemset_ibfk_12");

            entity.HasOne(d => d.ItemId13Navigation).WithMany(p => p.ItemsetItemId13Navigations)
                .HasForeignKey(d => d.ItemId13)
                .HasConstraintName("itemset_ibfk_13");

            entity.HasOne(d => d.ItemId14Navigation).WithMany(p => p.ItemsetItemId14Navigations)
                .HasForeignKey(d => d.ItemId14)
                .HasConstraintName("itemset_ibfk_14");

            entity.HasOne(d => d.ItemId15Navigation).WithMany(p => p.ItemsetItemId15Navigations)
                .HasForeignKey(d => d.ItemId15)
                .HasConstraintName("itemset_ibfk_15");

            entity.HasOne(d => d.ItemId16Navigation).WithMany(p => p.ItemsetItemId16Navigations)
                .HasForeignKey(d => d.ItemId16)
                .HasConstraintName("itemset_ibfk_16");

            entity.HasOne(d => d.ItemId17Navigation).WithMany(p => p.ItemsetItemId17Navigations)
                .HasForeignKey(d => d.ItemId17)
                .HasConstraintName("itemset_ibfk_17");

            entity.HasOne(d => d.ItemId2Navigation).WithMany(p => p.ItemsetItemId2Navigations)
                .HasForeignKey(d => d.ItemId2)
                .HasConstraintName("itemset_ibfk_2");

            entity.HasOne(d => d.ItemId3Navigation).WithMany(p => p.ItemsetItemId3Navigations)
                .HasForeignKey(d => d.ItemId3)
                .HasConstraintName("itemset_ibfk_3");

            entity.HasOne(d => d.ItemId4Navigation).WithMany(p => p.ItemsetItemId4Navigations)
                .HasForeignKey(d => d.ItemId4)
                .HasConstraintName("itemset_ibfk_4");

            entity.HasOne(d => d.ItemId5Navigation).WithMany(p => p.ItemsetItemId5Navigations)
                .HasForeignKey(d => d.ItemId5)
                .HasConstraintName("itemset_ibfk_5");

            entity.HasOne(d => d.ItemId6Navigation).WithMany(p => p.ItemsetItemId6Navigations)
                .HasForeignKey(d => d.ItemId6)
                .HasConstraintName("itemset_ibfk_6");

            entity.HasOne(d => d.ItemId7Navigation).WithMany(p => p.ItemsetItemId7Navigations)
                .HasForeignKey(d => d.ItemId7)
                .HasConstraintName("itemset_ibfk_7");

            entity.HasOne(d => d.ItemId8Navigation).WithMany(p => p.ItemsetItemId8Navigations)
                .HasForeignKey(d => d.ItemId8)
                .HasConstraintName("itemset_ibfk_8");

            entity.HasOne(d => d.ItemId9Navigation).WithMany(p => p.ItemsetItemId9Navigations)
                .HasForeignKey(d => d.ItemId9)
                .HasConstraintName("itemset_ibfk_9");

            entity.HasOne(d => d.RequiredSkillNavigation).WithMany(p => p.Itemsets)
                .HasForeignKey(d => d.RequiredSkill)
                .HasConstraintName("itemset_ibfk_26");

            entity.HasOne(d => d.SetSpellId1Navigation).WithMany(p => p.ItemsetSetSpellId1Navigations)
                .HasForeignKey(d => d.SetSpellId1)
                .HasConstraintName("itemset_ibfk_18");

            entity.HasOne(d => d.SetSpellId2Navigation).WithMany(p => p.ItemsetSetSpellId2Navigations)
                .HasForeignKey(d => d.SetSpellId2)
                .HasConstraintName("itemset_ibfk_19");

            entity.HasOne(d => d.SetSpellId3Navigation).WithMany(p => p.ItemsetSetSpellId3Navigations)
                .HasForeignKey(d => d.SetSpellId3)
                .HasConstraintName("itemset_ibfk_20");

            entity.HasOne(d => d.SetSpellId4Navigation).WithMany(p => p.ItemsetSetSpellId4Navigations)
                .HasForeignKey(d => d.SetSpellId4)
                .HasConstraintName("itemset_ibfk_21");

            entity.HasOne(d => d.SetSpellId5Navigation).WithMany(p => p.ItemsetSetSpellId5Navigations)
                .HasForeignKey(d => d.SetSpellId5)
                .HasConstraintName("itemset_ibfk_22");

            entity.HasOne(d => d.SetSpellId6Navigation).WithMany(p => p.ItemsetSetSpellId6Navigations)
                .HasForeignKey(d => d.SetSpellId6)
                .HasConstraintName("itemset_ibfk_23");

            entity.HasOne(d => d.SetSpellId7Navigation).WithMany(p => p.ItemsetSetSpellId7Navigations)
                .HasForeignKey(d => d.SetSpellId7)
                .HasConstraintName("itemset_ibfk_24");

            entity.HasOne(d => d.SetSpellId8Navigation).WithMany(p => p.ItemsetSetSpellId8Navigations)
                .HasForeignKey(d => d.SetSpellId8)
                .HasConstraintName("itemset_ibfk_25");
        });

        modelBuilder.Entity<Itemsubclass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemsubclass")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DisplayNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_deDE");
            entity.Property(e => e.DisplayNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enCN");
            entity.Property(e => e.DisplayNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enGB");
            entity.Property(e => e.DisplayNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enTW");
            entity.Property(e => e.DisplayNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enUS");
            entity.Property(e => e.DisplayNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esES");
            entity.Property(e => e.DisplayNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esMX");
            entity.Property(e => e.DisplayNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_frFR");
            entity.Property(e => e.DisplayNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_itIT");
            entity.Property(e => e.DisplayNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity.Property(e => e.DisplayNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptBR");
            entity.Property(e => e.DisplayNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptPT");
            entity.Property(e => e.DisplayNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ruRU");
            entity.Property(e => e.DisplayNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_Unk");
            entity.Property(e => e.DisplayNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhCN");
            entity.Property(e => e.DisplayNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhTW");
            entity.Property(e => e.SubClassId).HasColumnName("SubClassID");
            entity.Property(e => e.VerboseNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_deDE");
            entity.Property(e => e.VerboseNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_enCN");
            entity.Property(e => e.VerboseNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_enGB");
            entity.Property(e => e.VerboseNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_enTW");
            entity.Property(e => e.VerboseNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_enUS");
            entity.Property(e => e.VerboseNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_esES");
            entity.Property(e => e.VerboseNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_esMX");
            entity.Property(e => e.VerboseNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_frFR");
            entity.Property(e => e.VerboseNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_itIT");
            entity.Property(e => e.VerboseNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_koKR");
            entity.Property(e => e.VerboseNameLangMask).HasColumnName("VerboseName_Lang_Mask");
            entity.Property(e => e.VerboseNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_ptBR");
            entity.Property(e => e.VerboseNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_ptPT");
            entity.Property(e => e.VerboseNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_ruRU");
            entity.Property(e => e.VerboseNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_Unk");
            entity.Property(e => e.VerboseNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_zhCN");
            entity.Property(e => e.VerboseNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("VerboseName_Lang_zhTW");
        });

        modelBuilder.Entity<Itemsubclassmask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemsubclassmask")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Itemvisual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemvisuals")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Slot1, "Slot_1");

            entity.HasIndex(e => e.Slot2, "Slot_2");

            entity.HasIndex(e => e.Slot3, "Slot_3");

            entity.HasIndex(e => e.Slot4, "Slot_4");

            entity.HasIndex(e => e.Slot5, "Slot_5");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Slot1).HasColumnName("Slot_1");
            entity.Property(e => e.Slot2).HasColumnName("Slot_2");
            entity.Property(e => e.Slot3).HasColumnName("Slot_3");
            entity.Property(e => e.Slot4).HasColumnName("Slot_4");
            entity.Property(e => e.Slot5).HasColumnName("Slot_5");

            entity.HasOne(d => d.Slot1Navigation).WithMany(p => p.ItemvisualSlot1Navigations)
                .HasForeignKey(d => d.Slot1)
                .HasConstraintName("itemvisuals_ibfk_1");

            entity.HasOne(d => d.Slot2Navigation).WithMany(p => p.ItemvisualSlot2Navigations)
                .HasForeignKey(d => d.Slot2)
                .HasConstraintName("itemvisuals_ibfk_2");

            entity.HasOne(d => d.Slot3Navigation).WithMany(p => p.ItemvisualSlot3Navigations)
                .HasForeignKey(d => d.Slot3)
                .HasConstraintName("itemvisuals_ibfk_3");

            entity.HasOne(d => d.Slot4Navigation).WithMany(p => p.ItemvisualSlot4Navigations)
                .HasForeignKey(d => d.Slot4)
                .HasConstraintName("itemvisuals_ibfk_4");

            entity.HasOne(d => d.Slot5Navigation).WithMany(p => p.ItemvisualSlot5Navigations)
                .HasForeignKey(d => d.Slot5)
                .HasConstraintName("itemvisuals_ibfk_5");
        });

        modelBuilder.Entity<Itemvisualeffect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("itemvisualeffects")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Model).HasColumnType("text");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("languages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Languageword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("languagewords")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.LanguageId, "LanguageID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.Word).HasColumnType("text");

            entity.HasOne(d => d.Language).WithMany(p => p.Languagewords)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("languagewords_ibfk_1");
        });

        modelBuilder.Entity<Lfgdungeon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lfgdungeons")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Faction, "Faction");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.OrderIndex).HasColumnName("Order_Index");
            entity.Property(e => e.TargetLevel).HasColumnName("Target_Level");
            entity.Property(e => e.TargetLevelMax).HasColumnName("Target_Level_Max");
            entity.Property(e => e.TargetLevelMin).HasColumnName("Target_Level_Min");
            entity.Property(e => e.TextureFilename).HasColumnType("text");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.FactionNavigation).WithMany(p => p.Lfgdungeons)
                .HasForeignKey(d => d.Faction)
                .HasConstraintName("lfgdungeons_ibfk_2");

            entity.HasOne(d => d.Map).WithMany(p => p.Lfgdungeons)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("lfgdungeons_ibfk_1");
        });

        modelBuilder.Entity<Lfgdungeonexpansion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lfgdungeonexpansion")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.LfgId, "Lfg_Id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ExpansionLevel).HasColumnName("Expansion_Level");
            entity.Property(e => e.HardLevelMax).HasColumnName("Hard_Level_Max");
            entity.Property(e => e.HardLevelMin).HasColumnName("Hard_Level_Min");
            entity.Property(e => e.LfgId).HasColumnName("Lfg_Id");
            entity.Property(e => e.RandomId).HasColumnName("Random_Id");
            entity.Property(e => e.TargetLevelMax).HasColumnName("Target_Level_Max");
            entity.Property(e => e.TargetLevelMin).HasColumnName("Target_Level_Min");

            entity.HasOne(d => d.Lfg).WithMany(p => p.Lfgdungeonexpansions)
                .HasForeignKey(d => d.LfgId)
                .HasConstraintName("lfgdungeonexpansion_ibfk_1");
        });

        modelBuilder.Entity<Lfgdungeongroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lfgdungeongroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.OrderIndex).HasColumnName("Order_Index");
            entity.Property(e => e.ParentGroupId).HasColumnName("Parent_Group_Id");
        });

        modelBuilder.Entity<Light>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("light")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.LightParamsId1).HasColumnName("LightParamsID_1");
            entity.Property(e => e.LightParamsId2).HasColumnName("LightParamsID_2");
            entity.Property(e => e.LightParamsId3).HasColumnName("LightParamsID_3");
            entity.Property(e => e.LightParamsId4).HasColumnName("LightParamsID_4");
            entity.Property(e => e.LightParamsId5).HasColumnName("LightParamsID_5");
            entity.Property(e => e.LightParamsId6).HasColumnName("LightParamsID_6");
            entity.Property(e => e.LightParamsId7).HasColumnName("LightParamsID_7");
            entity.Property(e => e.LightParamsId8).HasColumnName("LightParamsID_8");
        });

        modelBuilder.Entity<Lightfloatband>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lightfloatband")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data1).HasColumnName("Data_1");
            entity.Property(e => e.Data10).HasColumnName("Data_10");
            entity.Property(e => e.Data11).HasColumnName("Data_11");
            entity.Property(e => e.Data12).HasColumnName("Data_12");
            entity.Property(e => e.Data13).HasColumnName("Data_13");
            entity.Property(e => e.Data14).HasColumnName("Data_14");
            entity.Property(e => e.Data15).HasColumnName("Data_15");
            entity.Property(e => e.Data16).HasColumnName("Data_16");
            entity.Property(e => e.Data2).HasColumnName("Data_2");
            entity.Property(e => e.Data3).HasColumnName("Data_3");
            entity.Property(e => e.Data4).HasColumnName("Data_4");
            entity.Property(e => e.Data5).HasColumnName("Data_5");
            entity.Property(e => e.Data6).HasColumnName("Data_6");
            entity.Property(e => e.Data7).HasColumnName("Data_7");
            entity.Property(e => e.Data8).HasColumnName("Data_8");
            entity.Property(e => e.Data9).HasColumnName("Data_9");
            entity.Property(e => e.Time1).HasColumnName("Time_1");
            entity.Property(e => e.Time10).HasColumnName("Time_10");
            entity.Property(e => e.Time11).HasColumnName("Time_11");
            entity.Property(e => e.Time12).HasColumnName("Time_12");
            entity.Property(e => e.Time13).HasColumnName("Time_13");
            entity.Property(e => e.Time14).HasColumnName("Time_14");
            entity.Property(e => e.Time15).HasColumnName("Time_15");
            entity.Property(e => e.Time16).HasColumnName("Time_16");
            entity.Property(e => e.Time2).HasColumnName("Time_2");
            entity.Property(e => e.Time3).HasColumnName("Time_3");
            entity.Property(e => e.Time4).HasColumnName("Time_4");
            entity.Property(e => e.Time5).HasColumnName("Time_5");
            entity.Property(e => e.Time6).HasColumnName("Time_6");
            entity.Property(e => e.Time7).HasColumnName("Time_7");
            entity.Property(e => e.Time8).HasColumnName("Time_8");
            entity.Property(e => e.Time9).HasColumnName("Time_9");
        });

        modelBuilder.Entity<Lightintband>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lightintband")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data1).HasColumnName("Data_1");
            entity.Property(e => e.Data10).HasColumnName("Data_10");
            entity.Property(e => e.Data11).HasColumnName("Data_11");
            entity.Property(e => e.Data12).HasColumnName("Data_12");
            entity.Property(e => e.Data13).HasColumnName("Data_13");
            entity.Property(e => e.Data14).HasColumnName("Data_14");
            entity.Property(e => e.Data15).HasColumnName("Data_15");
            entity.Property(e => e.Data16).HasColumnName("Data_16");
            entity.Property(e => e.Data2).HasColumnName("Data_2");
            entity.Property(e => e.Data3).HasColumnName("Data_3");
            entity.Property(e => e.Data4).HasColumnName("Data_4");
            entity.Property(e => e.Data5).HasColumnName("Data_5");
            entity.Property(e => e.Data6).HasColumnName("Data_6");
            entity.Property(e => e.Data7).HasColumnName("Data_7");
            entity.Property(e => e.Data8).HasColumnName("Data_8");
            entity.Property(e => e.Data9).HasColumnName("Data_9");
            entity.Property(e => e.Time1).HasColumnName("Time_1");
            entity.Property(e => e.Time10).HasColumnName("Time_10");
            entity.Property(e => e.Time11).HasColumnName("Time_11");
            entity.Property(e => e.Time12).HasColumnName("Time_12");
            entity.Property(e => e.Time13).HasColumnName("Time_13");
            entity.Property(e => e.Time14).HasColumnName("Time_14");
            entity.Property(e => e.Time15).HasColumnName("Time_15");
            entity.Property(e => e.Time16).HasColumnName("Time_16");
            entity.Property(e => e.Time2).HasColumnName("Time_2");
            entity.Property(e => e.Time3).HasColumnName("Time_3");
            entity.Property(e => e.Time4).HasColumnName("Time_4");
            entity.Property(e => e.Time5).HasColumnName("Time_5");
            entity.Property(e => e.Time6).HasColumnName("Time_6");
            entity.Property(e => e.Time7).HasColumnName("Time_7");
            entity.Property(e => e.Time8).HasColumnName("Time_8");
            entity.Property(e => e.Time9).HasColumnName("Time_9");
        });

        modelBuilder.Entity<Lightparam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lightparams")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.LightSkyboxId, "LightSkyboxID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CloudTypeId).HasColumnName("CloudTypeID");
            entity.Property(e => e.LightSkyboxId).HasColumnName("LightSkyboxID");

            entity.HasOne(d => d.LightSkybox).WithMany(p => p.Lightparams)
                .HasForeignKey(d => d.LightSkyboxId)
                .HasConstraintName("lightparams_ibfk_1");
        });

        modelBuilder.Entity<Lightskybox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lightskybox")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Liquidmaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("liquidmaterial")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Lvf).HasColumnName("LVF");
        });

        modelBuilder.Entity<Liquidtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("liquidtype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Color1).HasColumnName("Color_1");
            entity.Property(e => e.Color2).HasColumnName("Color_2");
            entity.Property(e => e.Float1).HasColumnName("Float_1");
            entity.Property(e => e.Float10).HasColumnName("Float_10");
            entity.Property(e => e.Float11).HasColumnName("Float_11");
            entity.Property(e => e.Float12).HasColumnName("Float_12");
            entity.Property(e => e.Float13).HasColumnName("Float_13");
            entity.Property(e => e.Float14).HasColumnName("Float_14");
            entity.Property(e => e.Float15).HasColumnName("Float_15");
            entity.Property(e => e.Float16).HasColumnName("Float_16");
            entity.Property(e => e.Float17).HasColumnName("Float_17");
            entity.Property(e => e.Float18).HasColumnName("Float_18");
            entity.Property(e => e.Float2).HasColumnName("Float_2");
            entity.Property(e => e.Float3).HasColumnName("Float_3");
            entity.Property(e => e.Float4).HasColumnName("Float_4");
            entity.Property(e => e.Float5).HasColumnName("Float_5");
            entity.Property(e => e.Float6).HasColumnName("Float_6");
            entity.Property(e => e.Float7).HasColumnName("Float_7");
            entity.Property(e => e.Float8).HasColumnName("Float_8");
            entity.Property(e => e.Float9).HasColumnName("Float_9");
            entity.Property(e => e.Int1).HasColumnName("Int_1");
            entity.Property(e => e.Int2).HasColumnName("Int_2");
            entity.Property(e => e.Int3).HasColumnName("Int_3");
            entity.Property(e => e.Int4).HasColumnName("Int_4");
            entity.Property(e => e.LightId).HasColumnName("LightID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
            entity.Property(e => e.Texture1)
                .HasColumnType("text")
                .HasColumnName("Texture_1");
            entity.Property(e => e.Texture2)
                .HasColumnType("text")
                .HasColumnName("Texture_2");
            entity.Property(e => e.Texture3)
                .HasColumnType("text")
                .HasColumnName("Texture_3");
            entity.Property(e => e.Texture4)
                .HasColumnType("text")
                .HasColumnName("Texture_4");
            entity.Property(e => e.Texture5)
                .HasColumnType("text")
                .HasColumnName("Texture_5");
            entity.Property(e => e.Texture6)
                .HasColumnType("text")
                .HasColumnName("Texture_6");
        });

        modelBuilder.Entity<Loadingscreen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("loadingscreens")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FileName).HasColumnType("text");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Loadingscreentaxispline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("loadingscreentaxisplines")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PathId, "PathID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Locx1).HasColumnName("Locx_1");
            entity.Property(e => e.Locx2).HasColumnName("Locx_2");
            entity.Property(e => e.Locx3).HasColumnName("Locx_3");
            entity.Property(e => e.Locx4).HasColumnName("Locx_4");
            entity.Property(e => e.Locx5).HasColumnName("Locx_5");
            entity.Property(e => e.Locx6).HasColumnName("Locx_6");
            entity.Property(e => e.Locx7).HasColumnName("Locx_7");
            entity.Property(e => e.Locx8).HasColumnName("Locx_8");
            entity.Property(e => e.Locy1).HasColumnName("Locy_1");
            entity.Property(e => e.Locy2).HasColumnName("Locy_2");
            entity.Property(e => e.Locy3).HasColumnName("Locy_3");
            entity.Property(e => e.Locy4).HasColumnName("Locy_4");
            entity.Property(e => e.Locy5).HasColumnName("Locy_5");
            entity.Property(e => e.Locy6).HasColumnName("Locy_6");
            entity.Property(e => e.Locy7).HasColumnName("Locy_7");
            entity.Property(e => e.Locy8).HasColumnName("Locy_8");
            entity.Property(e => e.PathId).HasColumnName("PathID");

            entity.HasOne(d => d.Path).WithMany(p => p.Loadingscreentaxisplines)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("loadingscreentaxisplines_ibfk_1");
        });

        modelBuilder.Entity<Lock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lock")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Type1, "Type_1");

            entity.HasIndex(e => e.Type2, "Type_2");

            entity.HasIndex(e => e.Type3, "Type_3");

            entity.HasIndex(e => e.Type4, "Type_4");

            entity.HasIndex(e => e.Type5, "Type_5");

            entity.HasIndex(e => e.Type6, "Type_6");

            entity.HasIndex(e => e.Type7, "Type_7");

            entity.HasIndex(e => e.Type8, "Type_8");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Action1).HasColumnName("Action_1");
            entity.Property(e => e.Action2).HasColumnName("Action_2");
            entity.Property(e => e.Action3).HasColumnName("Action_3");
            entity.Property(e => e.Action4).HasColumnName("Action_4");
            entity.Property(e => e.Action5).HasColumnName("Action_5");
            entity.Property(e => e.Action6).HasColumnName("Action_6");
            entity.Property(e => e.Action7).HasColumnName("Action_7");
            entity.Property(e => e.Action8).HasColumnName("Action_8");
            entity.Property(e => e.Index1).HasColumnName("Index_1");
            entity.Property(e => e.Index2).HasColumnName("Index_2");
            entity.Property(e => e.Index3).HasColumnName("Index_3");
            entity.Property(e => e.Index4).HasColumnName("Index_4");
            entity.Property(e => e.Index5).HasColumnName("Index_5");
            entity.Property(e => e.Index6).HasColumnName("Index_6");
            entity.Property(e => e.Index7).HasColumnName("Index_7");
            entity.Property(e => e.Index8).HasColumnName("Index_8");
            entity.Property(e => e.Skill1).HasColumnName("Skill_1");
            entity.Property(e => e.Skill2).HasColumnName("Skill_2");
            entity.Property(e => e.Skill3).HasColumnName("Skill_3");
            entity.Property(e => e.Skill4).HasColumnName("Skill_4");
            entity.Property(e => e.Skill5).HasColumnName("Skill_5");
            entity.Property(e => e.Skill6).HasColumnName("Skill_6");
            entity.Property(e => e.Skill7).HasColumnName("Skill_7");
            entity.Property(e => e.Skill8).HasColumnName("Skill_8");
            entity.Property(e => e.Type1).HasColumnName("Type_1");
            entity.Property(e => e.Type2).HasColumnName("Type_2");
            entity.Property(e => e.Type3).HasColumnName("Type_3");
            entity.Property(e => e.Type4).HasColumnName("Type_4");
            entity.Property(e => e.Type5).HasColumnName("Type_5");
            entity.Property(e => e.Type6).HasColumnName("Type_6");
            entity.Property(e => e.Type7).HasColumnName("Type_7");
            entity.Property(e => e.Type8).HasColumnName("Type_8");

            entity.HasOne(d => d.Type1Navigation).WithMany(p => p.LockType1Navigations)
                .HasForeignKey(d => d.Type1)
                .HasConstraintName("lock_ibfk_1");

            entity.HasOne(d => d.Type2Navigation).WithMany(p => p.LockType2Navigations)
                .HasForeignKey(d => d.Type2)
                .HasConstraintName("lock_ibfk_2");

            entity.HasOne(d => d.Type3Navigation).WithMany(p => p.LockType3Navigations)
                .HasForeignKey(d => d.Type3)
                .HasConstraintName("lock_ibfk_3");

            entity.HasOne(d => d.Type4Navigation).WithMany(p => p.LockType4Navigations)
                .HasForeignKey(d => d.Type4)
                .HasConstraintName("lock_ibfk_4");

            entity.HasOne(d => d.Type5Navigation).WithMany(p => p.LockType5Navigations)
                .HasForeignKey(d => d.Type5)
                .HasConstraintName("lock_ibfk_5");

            entity.HasOne(d => d.Type6Navigation).WithMany(p => p.LockType6Navigations)
                .HasForeignKey(d => d.Type6)
                .HasConstraintName("lock_ibfk_6");

            entity.HasOne(d => d.Type7Navigation).WithMany(p => p.LockType7Navigations)
                .HasForeignKey(d => d.Type7)
                .HasConstraintName("lock_ibfk_7");

            entity.HasOne(d => d.Type8Navigation).WithMany(p => p.LockType8Navigations)
                .HasForeignKey(d => d.Type8)
                .HasConstraintName("lock_ibfk_8");
        });

        modelBuilder.Entity<Locktype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("locktype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CursorName).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.ResourceNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_deDE");
            entity.Property(e => e.ResourceNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_enCN");
            entity.Property(e => e.ResourceNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_enGB");
            entity.Property(e => e.ResourceNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_enTW");
            entity.Property(e => e.ResourceNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_enUS");
            entity.Property(e => e.ResourceNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_esES");
            entity.Property(e => e.ResourceNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_esMX");
            entity.Property(e => e.ResourceNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_frFR");
            entity.Property(e => e.ResourceNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_itIT");
            entity.Property(e => e.ResourceNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_koKR");
            entity.Property(e => e.ResourceNameLangMask).HasColumnName("ResourceName_Lang_Mask");
            entity.Property(e => e.ResourceNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_ptBR");
            entity.Property(e => e.ResourceNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_ptPT");
            entity.Property(e => e.ResourceNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_ruRU");
            entity.Property(e => e.ResourceNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_Unk");
            entity.Property(e => e.ResourceNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_zhCN");
            entity.Property(e => e.ResourceNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("ResourceName_Lang_zhTW");
            entity.Property(e => e.VerbLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_deDE");
            entity.Property(e => e.VerbLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_enCN");
            entity.Property(e => e.VerbLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_enGB");
            entity.Property(e => e.VerbLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_enTW");
            entity.Property(e => e.VerbLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_enUS");
            entity.Property(e => e.VerbLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_esES");
            entity.Property(e => e.VerbLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_esMX");
            entity.Property(e => e.VerbLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_frFR");
            entity.Property(e => e.VerbLangItIt)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_itIT");
            entity.Property(e => e.VerbLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_koKR");
            entity.Property(e => e.VerbLangMask).HasColumnName("Verb_Lang_Mask");
            entity.Property(e => e.VerbLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_ptBR");
            entity.Property(e => e.VerbLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_ptPT");
            entity.Property(e => e.VerbLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_ruRU");
            entity.Property(e => e.VerbLangUnk)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_Unk");
            entity.Property(e => e.VerbLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_zhCN");
            entity.Property(e => e.VerbLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Verb_Lang_zhTW");
        });

        modelBuilder.Entity<Mailtemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mailtemplate")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BodyLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_deDE");
            entity.Property(e => e.BodyLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_enCN");
            entity.Property(e => e.BodyLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_enGB");
            entity.Property(e => e.BodyLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_enTW");
            entity.Property(e => e.BodyLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_enUS");
            entity.Property(e => e.BodyLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_esES");
            entity.Property(e => e.BodyLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_esMX");
            entity.Property(e => e.BodyLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_frFR");
            entity.Property(e => e.BodyLangItIt)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_itIT");
            entity.Property(e => e.BodyLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_koKR");
            entity.Property(e => e.BodyLangMask).HasColumnName("Body_Lang_Mask");
            entity.Property(e => e.BodyLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_ptBR");
            entity.Property(e => e.BodyLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_ptPT");
            entity.Property(e => e.BodyLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_ruRU");
            entity.Property(e => e.BodyLangUnk)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_Unk");
            entity.Property(e => e.BodyLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_zhCN");
            entity.Property(e => e.BodyLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Body_Lang_zhTW");
            entity.Property(e => e.SubjectLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_deDE");
            entity.Property(e => e.SubjectLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_enCN");
            entity.Property(e => e.SubjectLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_enGB");
            entity.Property(e => e.SubjectLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_enTW");
            entity.Property(e => e.SubjectLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_enUS");
            entity.Property(e => e.SubjectLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_esES");
            entity.Property(e => e.SubjectLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_esMX");
            entity.Property(e => e.SubjectLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_frFR");
            entity.Property(e => e.SubjectLangItIt)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_itIT");
            entity.Property(e => e.SubjectLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_koKR");
            entity.Property(e => e.SubjectLangMask).HasColumnName("Subject_Lang_Mask");
            entity.Property(e => e.SubjectLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_ptBR");
            entity.Property(e => e.SubjectLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_ptPT");
            entity.Property(e => e.SubjectLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_ruRU");
            entity.Property(e => e.SubjectLangUnk)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_Unk");
            entity.Property(e => e.SubjectLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_zhCN");
            entity.Property(e => e.SubjectLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Subject_Lang_zhTW");
        });

        modelBuilder.Entity<Map>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("map")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaTableId, "AreaTableID");

            entity.HasIndex(e => e.CorpseMapId, "CorpseMapID");

            entity.HasIndex(e => e.LoadingScreenId, "LoadingScreenID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaTableId).HasColumnName("AreaTableID");
            entity.Property(e => e.CorpseMapId).HasColumnName("CorpseMapID");
            entity.Property(e => e.Directory).HasColumnType("text");
            entity.Property(e => e.ExpansionId).HasColumnName("ExpansionID");
            entity.Property(e => e.LoadingScreenId).HasColumnName("LoadingScreenID");
            entity.Property(e => e.MapDescription0LangDeDe)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_deDE");
            entity.Property(e => e.MapDescription0LangEnCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enCN");
            entity.Property(e => e.MapDescription0LangEnGb)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enGB");
            entity.Property(e => e.MapDescription0LangEnTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enTW");
            entity.Property(e => e.MapDescription0LangEnUs)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enUS");
            entity.Property(e => e.MapDescription0LangEsEs)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_esES");
            entity.Property(e => e.MapDescription0LangEsMx)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_esMX");
            entity.Property(e => e.MapDescription0LangFrFr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_frFR");
            entity.Property(e => e.MapDescription0LangItIt)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_itIT");
            entity.Property(e => e.MapDescription0LangKoKr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_koKR");
            entity.Property(e => e.MapDescription0LangMask).HasColumnName("MapDescription0_Lang_Mask");
            entity.Property(e => e.MapDescription0LangPtBr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ptBR");
            entity.Property(e => e.MapDescription0LangPtPt)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ptPT");
            entity.Property(e => e.MapDescription0LangRuRu)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ruRU");
            entity.Property(e => e.MapDescription0LangUnk)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_Unk");
            entity.Property(e => e.MapDescription0LangZhCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_zhCN");
            entity.Property(e => e.MapDescription0LangZhTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_zhTW");
            entity.Property(e => e.MapDescription1LangDeDe)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_deDE");
            entity.Property(e => e.MapDescription1LangEnCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enCN");
            entity.Property(e => e.MapDescription1LangEnGb)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enGB");
            entity.Property(e => e.MapDescription1LangEnTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enTW");
            entity.Property(e => e.MapDescription1LangEnUs)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enUS");
            entity.Property(e => e.MapDescription1LangEsEs)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_esES");
            entity.Property(e => e.MapDescription1LangEsMx)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_esMX");
            entity.Property(e => e.MapDescription1LangFrFr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_frFR");
            entity.Property(e => e.MapDescription1LangItIt)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_itIT");
            entity.Property(e => e.MapDescription1LangKoKr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_koKR");
            entity.Property(e => e.MapDescription1LangMask).HasColumnName("MapDescription1_Lang_Mask");
            entity.Property(e => e.MapDescription1LangPtBr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ptBR");
            entity.Property(e => e.MapDescription1LangPtPt)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ptPT");
            entity.Property(e => e.MapDescription1LangRuRu)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ruRU");
            entity.Property(e => e.MapDescription1LangUnk)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_Unk");
            entity.Property(e => e.MapDescription1LangZhCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_zhCN");
            entity.Property(e => e.MapDescription1LangZhTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_zhTW");
            entity.Property(e => e.MapNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_deDE");
            entity.Property(e => e.MapNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_enCN");
            entity.Property(e => e.MapNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_enGB");
            entity.Property(e => e.MapNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_enTW");
            entity.Property(e => e.MapNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_enUS");
            entity.Property(e => e.MapNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_esES");
            entity.Property(e => e.MapNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_esMX");
            entity.Property(e => e.MapNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_frFR");
            entity.Property(e => e.MapNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_itIT");
            entity.Property(e => e.MapNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_koKR");
            entity.Property(e => e.MapNameLangMask).HasColumnName("MapName_Lang_Mask");
            entity.Property(e => e.MapNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_ptBR");
            entity.Property(e => e.MapNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_ptPT");
            entity.Property(e => e.MapNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_ruRU");
            entity.Property(e => e.MapNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_Unk");
            entity.Property(e => e.MapNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_zhCN");
            entity.Property(e => e.MapNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("MapName_Lang_zhTW");
            entity.Property(e => e.Pvp).HasColumnName("PVP");

            entity.HasOne(d => d.AreaTable).WithMany(p => p.Maps)
                .HasForeignKey(d => d.AreaTableId)
                .HasConstraintName("map_ibfk_1");

            entity.HasOne(d => d.CorpseMap).WithMany(p => p.InverseCorpseMap)
                .HasForeignKey(d => d.CorpseMapId)
                .HasConstraintName("map_ibfk_3");

            entity.HasOne(d => d.LoadingScreen).WithMany(p => p.Maps)
                .HasForeignKey(d => d.LoadingScreenId)
                .HasConstraintName("map_ibfk_2");
        });

        modelBuilder.Entity<Mapdifficulty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mapdifficulty")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Difficultystring).HasColumnType("text");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.MessageLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_deDE");
            entity.Property(e => e.MessageLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enCN");
            entity.Property(e => e.MessageLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enGB");
            entity.Property(e => e.MessageLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enTW");
            entity.Property(e => e.MessageLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enUS");
            entity.Property(e => e.MessageLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_esES");
            entity.Property(e => e.MessageLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_esMX");
            entity.Property(e => e.MessageLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_frFR");
            entity.Property(e => e.MessageLangItIt)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_itIT");
            entity.Property(e => e.MessageLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_koKR");
            entity.Property(e => e.MessageLangMask).HasColumnName("Message_Lang_Mask");
            entity.Property(e => e.MessageLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ptBR");
            entity.Property(e => e.MessageLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ptPT");
            entity.Property(e => e.MessageLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ruRU");
            entity.Property(e => e.MessageLangUnk)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_Unk");
            entity.Property(e => e.MessageLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_zhCN");
            entity.Property(e => e.MessageLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_zhTW");

            entity.HasOne(d => d.Map).WithMany(p => p.Mapdifficulties)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("mapdifficulty_ibfk_1");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("material")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FoleySoundId, "FoleySoundID");

            entity.HasIndex(e => e.SheatheSoundId, "SheatheSoundID");

            entity.HasIndex(e => e.UnsheatheSoundId, "UnsheatheSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FoleySoundId).HasColumnName("FoleySoundID");
            entity.Property(e => e.SheatheSoundId).HasColumnName("SheatheSoundID");
            entity.Property(e => e.UnsheatheSoundId).HasColumnName("UnsheatheSoundID");

            entity.HasOne(d => d.FoleySound).WithMany(p => p.MaterialFoleySounds)
                .HasForeignKey(d => d.FoleySoundId)
                .HasConstraintName("material_ibfk_1");

            entity.HasOne(d => d.SheatheSound).WithMany(p => p.MaterialSheatheSounds)
                .HasForeignKey(d => d.SheatheSoundId)
                .HasConstraintName("material_ibfk_2");

            entity.HasOne(d => d.UnsheatheSound).WithMany(p => p.MaterialUnsheatheSounds)
                .HasForeignKey(d => d.UnsheatheSoundId)
                .HasConstraintName("material_ibfk_3");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("movie")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Filename).HasColumnType("text");
        });

        modelBuilder.Entity<Moviefiledatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("moviefiledata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Movievariation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("movievariation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FileDataId).HasColumnName("FileDataID");
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
        });

        modelBuilder.Entity<Namegen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("namegen")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");

            entity.HasOne(d => d.Race).WithMany(p => p.Namegens)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("namegen_ibfk_1");
        });

        modelBuilder.Entity<Namesprofanity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("namesprofanity")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Namesreserved>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("namesreserved")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Npcsound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("npcsounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId1, "SoundID_1");

            entity.HasIndex(e => e.SoundId2, "SoundID_2");

            entity.HasIndex(e => e.SoundId3, "SoundID_3");

            entity.HasIndex(e => e.SoundId4, "SoundID_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SoundId1).HasColumnName("SoundID_1");
            entity.Property(e => e.SoundId2).HasColumnName("SoundID_2");
            entity.Property(e => e.SoundId3).HasColumnName("SoundID_3");
            entity.Property(e => e.SoundId4).HasColumnName("SoundID_4");

            entity.HasOne(d => d.SoundId1Navigation).WithMany(p => p.NpcsoundSoundId1Navigations)
                .HasForeignKey(d => d.SoundId1)
                .HasConstraintName("npcsounds_ibfk_1");

            entity.HasOne(d => d.SoundId2Navigation).WithMany(p => p.NpcsoundSoundId2Navigations)
                .HasForeignKey(d => d.SoundId2)
                .HasConstraintName("npcsounds_ibfk_2");

            entity.HasOne(d => d.SoundId3Navigation).WithMany(p => p.NpcsoundSoundId3Navigations)
                .HasForeignKey(d => d.SoundId3)
                .HasConstraintName("npcsounds_ibfk_3");

            entity.HasOne(d => d.SoundId4Navigation).WithMany(p => p.NpcsoundSoundId4Navigations)
                .HasForeignKey(d => d.SoundId4)
                .HasConstraintName("npcsounds_ibfk_4");
        });

        modelBuilder.Entity<Objecteffect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objecteffect")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ObjectEffectGroupId, "ObjectEffectGroupID");

            entity.HasIndex(e => e.ObjectEffectModifierId, "ObjectEffectModifierID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EffectRecId).HasColumnName("EffectRecID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.ObjectEffectGroupId).HasColumnName("ObjectEffectGroupID");
            entity.Property(e => e.ObjectEffectModifierId).HasColumnName("ObjectEffectModifierID");

            entity.HasOne(d => d.ObjectEffectGroup).WithMany(p => p.Objecteffects)
                .HasForeignKey(d => d.ObjectEffectGroupId)
                .HasConstraintName("objecteffect_ibfk_1");

            entity.HasOne(d => d.ObjectEffectModifier).WithMany(p => p.Objecteffects)
                .HasForeignKey(d => d.ObjectEffectModifierId)
                .HasConstraintName("objecteffect_ibfk_2");
        });

        modelBuilder.Entity<Objecteffectgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objecteffectgroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Objecteffectmodifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objecteffectmodifier")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Param1).HasColumnName("Param_1");
            entity.Property(e => e.Param2).HasColumnName("Param_2");
            entity.Property(e => e.Param3).HasColumnName("Param_3");
            entity.Property(e => e.Param4).HasColumnName("Param_4");
        });

        modelBuilder.Entity<Objecteffectpackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objecteffectpackage")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Objecteffectpackageelem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("objecteffectpackageelem")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ObjectEffectGroupId, "ObjectEffectGroupID");

            entity.HasIndex(e => e.ObjectEffectPackageId, "ObjectEffectPackageID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ObjectEffectGroupId).HasColumnName("ObjectEffectGroupID");
            entity.Property(e => e.ObjectEffectPackageId).HasColumnName("ObjectEffectPackageID");

            entity.HasOne(d => d.ObjectEffectGroup).WithMany(p => p.Objecteffectpackageelems)
                .HasForeignKey(d => d.ObjectEffectGroupId)
                .HasConstraintName("objecteffectpackageelem_ibfk_1");

            entity.HasOne(d => d.ObjectEffectPackage).WithMany(p => p.Objecteffectpackageelems)
                .HasForeignKey(d => d.ObjectEffectPackageId)
                .HasConstraintName("objecteffectpackageelem_ibfk_2");
        });

        modelBuilder.Entity<Overridespelldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("overridespelldata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Spells1, "Spells_1");

            entity.HasIndex(e => e.Spells10, "Spells_10");

            entity.HasIndex(e => e.Spells2, "Spells_2");

            entity.HasIndex(e => e.Spells3, "Spells_3");

            entity.HasIndex(e => e.Spells4, "Spells_4");

            entity.HasIndex(e => e.Spells5, "Spells_5");

            entity.HasIndex(e => e.Spells6, "Spells_6");

            entity.HasIndex(e => e.Spells7, "Spells_7");

            entity.HasIndex(e => e.Spells8, "Spells_8");

            entity.HasIndex(e => e.Spells9, "Spells_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Spells1).HasColumnName("Spells_1");
            entity.Property(e => e.Spells10).HasColumnName("Spells_10");
            entity.Property(e => e.Spells2).HasColumnName("Spells_2");
            entity.Property(e => e.Spells3).HasColumnName("Spells_3");
            entity.Property(e => e.Spells4).HasColumnName("Spells_4");
            entity.Property(e => e.Spells5).HasColumnName("Spells_5");
            entity.Property(e => e.Spells6).HasColumnName("Spells_6");
            entity.Property(e => e.Spells7).HasColumnName("Spells_7");
            entity.Property(e => e.Spells8).HasColumnName("Spells_8");
            entity.Property(e => e.Spells9).HasColumnName("Spells_9");

            entity.HasOne(d => d.Spells1Navigation).WithMany(p => p.OverridespelldatumSpells1Navigations)
                .HasForeignKey(d => d.Spells1)
                .HasConstraintName("overridespelldata_ibfk_1");

            entity.HasOne(d => d.Spells10Navigation).WithMany(p => p.OverridespelldatumSpells10Navigations)
                .HasForeignKey(d => d.Spells10)
                .HasConstraintName("overridespelldata_ibfk_10");

            entity.HasOne(d => d.Spells2Navigation).WithMany(p => p.OverridespelldatumSpells2Navigations)
                .HasForeignKey(d => d.Spells2)
                .HasConstraintName("overridespelldata_ibfk_2");

            entity.HasOne(d => d.Spells3Navigation).WithMany(p => p.OverridespelldatumSpells3Navigations)
                .HasForeignKey(d => d.Spells3)
                .HasConstraintName("overridespelldata_ibfk_3");

            entity.HasOne(d => d.Spells4Navigation).WithMany(p => p.OverridespelldatumSpells4Navigations)
                .HasForeignKey(d => d.Spells4)
                .HasConstraintName("overridespelldata_ibfk_4");

            entity.HasOne(d => d.Spells5Navigation).WithMany(p => p.OverridespelldatumSpells5Navigations)
                .HasForeignKey(d => d.Spells5)
                .HasConstraintName("overridespelldata_ibfk_5");

            entity.HasOne(d => d.Spells6Navigation).WithMany(p => p.OverridespelldatumSpells6Navigations)
                .HasForeignKey(d => d.Spells6)
                .HasConstraintName("overridespelldata_ibfk_6");

            entity.HasOne(d => d.Spells7Navigation).WithMany(p => p.OverridespelldatumSpells7Navigations)
                .HasForeignKey(d => d.Spells7)
                .HasConstraintName("overridespelldata_ibfk_7");

            entity.HasOne(d => d.Spells8Navigation).WithMany(p => p.OverridespelldatumSpells8Navigations)
                .HasForeignKey(d => d.Spells8)
                .HasConstraintName("overridespelldata_ibfk_8");

            entity.HasOne(d => d.Spells9Navigation).WithMany(p => p.OverridespelldatumSpells9Navigations)
                .HasForeignKey(d => d.Spells9)
                .HasConstraintName("overridespelldata_ibfk_9");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("package")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Icon).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Pagetextmaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pagetextmaterial")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Paperdollitemframe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("paperdollitemframe")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemButtonName).HasColumnType("text");
            entity.Property(e => e.SlotIcon).HasColumnType("text");
        });

        modelBuilder.Entity<Particlecolor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("particlecolor")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.End1).HasColumnName("End_1");
            entity.Property(e => e.End2).HasColumnName("End_2");
            entity.Property(e => e.End3).HasColumnName("End_3");
            entity.Property(e => e.Mid1).HasColumnName("Mid_1");
            entity.Property(e => e.Mid2).HasColumnName("Mid_2");
            entity.Property(e => e.Mid3).HasColumnName("Mid_3");
            entity.Property(e => e.Start1).HasColumnName("Start_1");
            entity.Property(e => e.Start2).HasColumnName("Start_2");
            entity.Property(e => e.Start3).HasColumnName("Start_3");
        });

        modelBuilder.Entity<Petitiontype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("petitiontype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Petpersonality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("petpersonality")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.HappinessDamage1).HasColumnName("HappinessDamage_1");
            entity.Property(e => e.HappinessDamage2).HasColumnName("HappinessDamage_2");
            entity.Property(e => e.HappinessDamage3).HasColumnName("HappinessDamage_3");
            entity.Property(e => e.HappinessThreshold1).HasColumnName("HappinessThreshold_1");
            entity.Property(e => e.HappinessThreshold2).HasColumnName("HappinessThreshold_2");
            entity.Property(e => e.HappinessThreshold3).HasColumnName("HappinessThreshold_3");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Powerdisplay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("powerdisplay")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GlobalstringBaseTag).HasColumnType("text");
        });

        modelBuilder.Entity<Pvpdifficulty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pvpdifficulty")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");

            entity.HasOne(d => d.Map).WithMany(p => p.Pvpdifficulties)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("pvpdifficulty_ibfk_1");
        });

        modelBuilder.Entity<Questfactionreward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("questfactionreward")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Difficulty1).HasColumnName("Difficulty_1");
            entity.Property(e => e.Difficulty10).HasColumnName("Difficulty_10");
            entity.Property(e => e.Difficulty2).HasColumnName("Difficulty_2");
            entity.Property(e => e.Difficulty3).HasColumnName("Difficulty_3");
            entity.Property(e => e.Difficulty4).HasColumnName("Difficulty_4");
            entity.Property(e => e.Difficulty5).HasColumnName("Difficulty_5");
            entity.Property(e => e.Difficulty6).HasColumnName("Difficulty_6");
            entity.Property(e => e.Difficulty7).HasColumnName("Difficulty_7");
            entity.Property(e => e.Difficulty8).HasColumnName("Difficulty_8");
            entity.Property(e => e.Difficulty9).HasColumnName("Difficulty_9");
        });

        modelBuilder.Entity<Questinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("questinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.InfoNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_deDE");
            entity.Property(e => e.InfoNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_enCN");
            entity.Property(e => e.InfoNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_enGB");
            entity.Property(e => e.InfoNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_enTW");
            entity.Property(e => e.InfoNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_enUS");
            entity.Property(e => e.InfoNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_esES");
            entity.Property(e => e.InfoNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_esMX");
            entity.Property(e => e.InfoNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_frFR");
            entity.Property(e => e.InfoNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_itIT");
            entity.Property(e => e.InfoNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_koKR");
            entity.Property(e => e.InfoNameLangMask).HasColumnName("InfoName_Lang_Mask");
            entity.Property(e => e.InfoNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_ptBR");
            entity.Property(e => e.InfoNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_ptPT");
            entity.Property(e => e.InfoNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_ruRU");
            entity.Property(e => e.InfoNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_Unk");
            entity.Property(e => e.InfoNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_zhCN");
            entity.Property(e => e.InfoNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("InfoName_Lang_zhTW");
        });

        modelBuilder.Entity<Questsort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("questsort")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SortNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_deDE");
            entity.Property(e => e.SortNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_enCN");
            entity.Property(e => e.SortNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_enGB");
            entity.Property(e => e.SortNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_enTW");
            entity.Property(e => e.SortNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_enUS");
            entity.Property(e => e.SortNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_esES");
            entity.Property(e => e.SortNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_esMX");
            entity.Property(e => e.SortNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_frFR");
            entity.Property(e => e.SortNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_itIT");
            entity.Property(e => e.SortNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_koKR");
            entity.Property(e => e.SortNameLangMask).HasColumnName("SortName_Lang_Mask");
            entity.Property(e => e.SortNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_ptBR");
            entity.Property(e => e.SortNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_ptPT");
            entity.Property(e => e.SortNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_ruRU");
            entity.Property(e => e.SortNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_Unk");
            entity.Property(e => e.SortNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_zhCN");
            entity.Property(e => e.SortNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("SortName_Lang_zhTW");
        });

        modelBuilder.Entity<Questxp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("questxp")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Difficulty1).HasColumnName("Difficulty_1");
            entity.Property(e => e.Difficulty10).HasColumnName("Difficulty_10");
            entity.Property(e => e.Difficulty2).HasColumnName("Difficulty_2");
            entity.Property(e => e.Difficulty3).HasColumnName("Difficulty_3");
            entity.Property(e => e.Difficulty4).HasColumnName("Difficulty_4");
            entity.Property(e => e.Difficulty5).HasColumnName("Difficulty_5");
            entity.Property(e => e.Difficulty6).HasColumnName("Difficulty_6");
            entity.Property(e => e.Difficulty7).HasColumnName("Difficulty_7");
            entity.Property(e => e.Difficulty8).HasColumnName("Difficulty_8");
            entity.Property(e => e.Difficulty9).HasColumnName("Difficulty_9");
        });

        modelBuilder.Entity<Randproppoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("randproppoints")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Epic1).HasColumnName("Epic_1");
            entity.Property(e => e.Epic2).HasColumnName("Epic_2");
            entity.Property(e => e.Epic3).HasColumnName("Epic_3");
            entity.Property(e => e.Epic4).HasColumnName("Epic_4");
            entity.Property(e => e.Epic5).HasColumnName("Epic_5");
            entity.Property(e => e.Good1).HasColumnName("Good_1");
            entity.Property(e => e.Good2).HasColumnName("Good_2");
            entity.Property(e => e.Good3).HasColumnName("Good_3");
            entity.Property(e => e.Good4).HasColumnName("Good_4");
            entity.Property(e => e.Good5).HasColumnName("Good_5");
            entity.Property(e => e.Superior1).HasColumnName("Superior_1");
            entity.Property(e => e.Superior2).HasColumnName("Superior_2");
            entity.Property(e => e.Superior3).HasColumnName("Superior_3");
            entity.Property(e => e.Superior4).HasColumnName("Superior_4");
            entity.Property(e => e.Superior5).HasColumnName("Superior_5");
        });

        modelBuilder.Entity<Resistance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("resistances")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FizzleSoundId).HasColumnName("FizzleSoundID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Scalingstatdistribution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("scalingstatdistribution")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Bonus1).HasColumnName("Bonus_1");
            entity.Property(e => e.Bonus10).HasColumnName("Bonus_10");
            entity.Property(e => e.Bonus2).HasColumnName("Bonus_2");
            entity.Property(e => e.Bonus3).HasColumnName("Bonus_3");
            entity.Property(e => e.Bonus4).HasColumnName("Bonus_4");
            entity.Property(e => e.Bonus5).HasColumnName("Bonus_5");
            entity.Property(e => e.Bonus6).HasColumnName("Bonus_6");
            entity.Property(e => e.Bonus7).HasColumnName("Bonus_7");
            entity.Property(e => e.Bonus8).HasColumnName("Bonus_8");
            entity.Property(e => e.Bonus9).HasColumnName("Bonus_9");
            entity.Property(e => e.StatId1).HasColumnName("StatID_1");
            entity.Property(e => e.StatId10).HasColumnName("StatID_10");
            entity.Property(e => e.StatId2).HasColumnName("StatID_2");
            entity.Property(e => e.StatId3).HasColumnName("StatID_3");
            entity.Property(e => e.StatId4).HasColumnName("StatID_4");
            entity.Property(e => e.StatId5).HasColumnName("StatID_5");
            entity.Property(e => e.StatId6).HasColumnName("StatID_6");
            entity.Property(e => e.StatId7).HasColumnName("StatID_7");
            entity.Property(e => e.StatId8).HasColumnName("StatID_8");
            entity.Property(e => e.StatId9).HasColumnName("StatID_9");
        });

        modelBuilder.Entity<Scalingstatvalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("scalingstatvalues")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.RangedDps).HasColumnName("RangedDPS");
            entity.Property(e => e.SpellcasterDps1h).HasColumnName("SpellcasterDPS1H");
            entity.Property(e => e.SpellcasterDps2h).HasColumnName("SpellcasterDPS2H");
            entity.Property(e => e.WandDps).HasColumnName("WandDPS");
            entity.Property(e => e.WeaponDps1h).HasColumnName("WeaponDPS1H");
            entity.Property(e => e.WeaponDps2h).HasColumnName("WeaponDPS2H");
        });

        modelBuilder.Entity<Screeneffect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("screeneffect")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.LightParamsId).HasColumnName("LightParamsID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.Param1).HasColumnName("Param_1");
            entity.Property(e => e.Param2).HasColumnName("Param_2");
            entity.Property(e => e.Param3).HasColumnName("Param_3");
            entity.Property(e => e.Param4).HasColumnName("Param_4");
            entity.Property(e => e.SoundAmbienceId).HasColumnName("SoundAmbienceID");
            entity.Property(e => e.ZoneMusicId).HasColumnName("ZoneMusicID");
        });

        modelBuilder.Entity<Servermessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("servermessages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TextLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_deDE");
            entity.Property(e => e.TextLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enCN");
            entity.Property(e => e.TextLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enGB");
            entity.Property(e => e.TextLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enTW");
            entity.Property(e => e.TextLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_enUS");
            entity.Property(e => e.TextLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esES");
            entity.Property(e => e.TextLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_esMX");
            entity.Property(e => e.TextLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_frFR");
            entity.Property(e => e.TextLangItIt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_itIT");
            entity.Property(e => e.TextLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_koKR");
            entity.Property(e => e.TextLangMask).HasColumnName("Text_Lang_Mask");
            entity.Property(e => e.TextLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptBR");
            entity.Property(e => e.TextLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ptPT");
            entity.Property(e => e.TextLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_ruRU");
            entity.Property(e => e.TextLangUnk)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_Unk");
            entity.Property(e => e.TextLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhCN");
            entity.Property(e => e.TextLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Text_Lang_zhTW");
        });

        modelBuilder.Entity<Sheathesoundlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sheathesoundlookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemClass, "ItemClass");

            entity.HasIndex(e => e.ItemSubclass, "ItemSubclass");

            entity.HasIndex(e => e.SheathSoundId, "SheathSoundID");

            entity.HasIndex(e => e.UnsheathSoundId, "UnsheathSoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SheathSoundId).HasColumnName("SheathSoundID");
            entity.Property(e => e.UnsheathSoundId).HasColumnName("UnsheathSoundID");

            entity.HasOne(d => d.ItemClassNavigation).WithMany(p => p.SheathesoundlookupItemClassNavigations)
                .HasForeignKey(d => d.ItemClass)
                .HasConstraintName("sheathesoundlookups_ibfk_1");

            entity.HasOne(d => d.ItemSubclassNavigation).WithMany(p => p.SheathesoundlookupItemSubclassNavigations)
                .HasForeignKey(d => d.ItemSubclass)
                .HasConstraintName("sheathesoundlookups_ibfk_2");

            entity.HasOne(d => d.SheathSound).WithMany(p => p.SheathesoundlookupSheathSounds)
                .HasForeignKey(d => d.SheathSoundId)
                .HasConstraintName("sheathesoundlookups_ibfk_3");

            entity.HasOne(d => d.UnsheathSound).WithMany(p => p.SheathesoundlookupUnsheathSounds)
                .HasForeignKey(d => d.UnsheathSoundId)
                .HasConstraintName("sheathesoundlookups_ibfk_4");
        });

        modelBuilder.Entity<Skillcostsdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skillcostsdata")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cost1).HasColumnName("Cost_1");
            entity.Property(e => e.Cost2).HasColumnName("Cost_2");
            entity.Property(e => e.Cost3).HasColumnName("Cost_3");
            entity.Property(e => e.SkillCostsId).HasColumnName("SkillCostsID");
        });

        modelBuilder.Entity<Skillline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skillline")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CategoryId, "CategoryID");

            entity.HasIndex(e => e.SkillCostsId, "SkillCostsID");

            entity.HasIndex(e => e.SpellIconId, "SpellIconID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AlternateVerbLangDeDe)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_deDE");
            entity.Property(e => e.AlternateVerbLangEnCn)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_enCN");
            entity.Property(e => e.AlternateVerbLangEnGb)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_enGB");
            entity.Property(e => e.AlternateVerbLangEnTw)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_enTW");
            entity.Property(e => e.AlternateVerbLangEnUs)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_enUS");
            entity.Property(e => e.AlternateVerbLangEsEs)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_esES");
            entity.Property(e => e.AlternateVerbLangEsMx)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_esMX");
            entity.Property(e => e.AlternateVerbLangFrFr)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_frFR");
            entity.Property(e => e.AlternateVerbLangItIt)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_itIT");
            entity.Property(e => e.AlternateVerbLangKoKr)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_koKR");
            entity.Property(e => e.AlternateVerbLangMask).HasColumnName("AlternateVerb_Lang_Mask");
            entity.Property(e => e.AlternateVerbLangPtBr)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_ptBR");
            entity.Property(e => e.AlternateVerbLangPtPt)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_ptPT");
            entity.Property(e => e.AlternateVerbLangRuRu)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_ruRU");
            entity.Property(e => e.AlternateVerbLangUnk)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_Unk");
            entity.Property(e => e.AlternateVerbLangZhCn)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_zhCN");
            entity.Property(e => e.AlternateVerbLangZhTw)
                .HasColumnType("text")
                .HasColumnName("AlternateVerb_Lang_zhTW");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.DisplayNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_deDE");
            entity.Property(e => e.DisplayNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enCN");
            entity.Property(e => e.DisplayNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enGB");
            entity.Property(e => e.DisplayNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enTW");
            entity.Property(e => e.DisplayNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enUS");
            entity.Property(e => e.DisplayNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esES");
            entity.Property(e => e.DisplayNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esMX");
            entity.Property(e => e.DisplayNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_frFR");
            entity.Property(e => e.DisplayNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_itIT");
            entity.Property(e => e.DisplayNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity.Property(e => e.DisplayNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptBR");
            entity.Property(e => e.DisplayNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptPT");
            entity.Property(e => e.DisplayNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ruRU");
            entity.Property(e => e.DisplayNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_Unk");
            entity.Property(e => e.DisplayNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhCN");
            entity.Property(e => e.DisplayNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhTW");
            entity.Property(e => e.SkillCostsId).HasColumnName("SkillCostsID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");

            entity.HasOne(d => d.Category).WithMany(p => p.Skilllines)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("skillline_ibfk_1");

            entity.HasOne(d => d.SkillCosts).WithMany(p => p.Skilllines)
                .HasForeignKey(d => d.SkillCostsId)
                .HasConstraintName("skillline_ibfk_2");

            entity.HasOne(d => d.SpellIcon).WithMany(p => p.Skilllines)
                .HasForeignKey(d => d.SpellIconId)
                .HasConstraintName("skillline_ibfk_3");
        });

        modelBuilder.Entity<Skilllineability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skilllineability")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SkillLine, "SkillLine");

            entity.HasIndex(e => e.Spell, "Spell");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CharacterPoints1).HasColumnName("CharacterPoints_1");
            entity.Property(e => e.CharacterPoints2).HasColumnName("CharacterPoints_2");

            entity.HasOne(d => d.SkillLineNavigation).WithMany(p => p.Skilllineabilities)
                .HasForeignKey(d => d.SkillLine)
                .HasConstraintName("skilllineability_ibfk_1");

            entity.HasOne(d => d.SpellNavigation).WithMany(p => p.Skilllineabilities)
                .HasForeignKey(d => d.Spell)
                .HasConstraintName("skilllineability_ibfk_2");
        });

        modelBuilder.Entity<Skilllinecategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skilllinecategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Skillraceclassinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skillraceclassinfo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SkillCostIndex, "SkillCostIndex");

            entity.HasIndex(e => e.SkillId, "SkillID");

            entity.HasIndex(e => e.SkillTierId, "SkillTierID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillTierId).HasColumnName("SkillTierID");

            entity.HasOne(d => d.SkillCostIndexNavigation).WithMany(p => p.Skillraceclassinfos)
                .HasForeignKey(d => d.SkillCostIndex)
                .HasConstraintName("skillraceclassinfo_ibfk_3");

            entity.HasOne(d => d.Skill).WithMany(p => p.Skillraceclassinfos)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("skillraceclassinfo_ibfk_1");

            entity.HasOne(d => d.SkillTier).WithMany(p => p.Skillraceclassinfos)
                .HasForeignKey(d => d.SkillTierId)
                .HasConstraintName("skillraceclassinfo_ibfk_2");
        });

        modelBuilder.Entity<Skilltier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("skilltiers")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cost1).HasColumnName("Cost_1");
            entity.Property(e => e.Cost10).HasColumnName("Cost_10");
            entity.Property(e => e.Cost11).HasColumnName("Cost_11");
            entity.Property(e => e.Cost12).HasColumnName("Cost_12");
            entity.Property(e => e.Cost13).HasColumnName("Cost_13");
            entity.Property(e => e.Cost14).HasColumnName("Cost_14");
            entity.Property(e => e.Cost15).HasColumnName("Cost_15");
            entity.Property(e => e.Cost16).HasColumnName("Cost_16");
            entity.Property(e => e.Cost2).HasColumnName("Cost_2");
            entity.Property(e => e.Cost3).HasColumnName("Cost_3");
            entity.Property(e => e.Cost4).HasColumnName("Cost_4");
            entity.Property(e => e.Cost5).HasColumnName("Cost_5");
            entity.Property(e => e.Cost6).HasColumnName("Cost_6");
            entity.Property(e => e.Cost7).HasColumnName("Cost_7");
            entity.Property(e => e.Cost8).HasColumnName("Cost_8");
            entity.Property(e => e.Cost9).HasColumnName("Cost_9");
            entity.Property(e => e.Value1).HasColumnName("Value_1");
            entity.Property(e => e.Value10).HasColumnName("Value_10");
            entity.Property(e => e.Value11).HasColumnName("Value_11");
            entity.Property(e => e.Value12).HasColumnName("Value_12");
            entity.Property(e => e.Value13).HasColumnName("Value_13");
            entity.Property(e => e.Value14).HasColumnName("Value_14");
            entity.Property(e => e.Value15).HasColumnName("Value_15");
            entity.Property(e => e.Value16).HasColumnName("Value_16");
            entity.Property(e => e.Value2).HasColumnName("Value_2");
            entity.Property(e => e.Value3).HasColumnName("Value_3");
            entity.Property(e => e.Value4).HasColumnName("Value_4");
            entity.Property(e => e.Value5).HasColumnName("Value_5");
            entity.Property(e => e.Value6).HasColumnName("Value_6");
            entity.Property(e => e.Value7).HasColumnName("Value_7");
            entity.Property(e => e.Value8).HasColumnName("Value_8");
            entity.Property(e => e.Value9).HasColumnName("Value_9");
        });

        modelBuilder.Entity<Soundambience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundambience")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AmbienceId1, "AmbienceID_1");

            entity.HasIndex(e => e.AmbienceId2, "AmbienceID_2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AmbienceId1).HasColumnName("AmbienceID_1");
            entity.Property(e => e.AmbienceId2).HasColumnName("AmbienceID_2");

            entity.HasOne(d => d.AmbienceId1Navigation).WithMany(p => p.SoundambienceAmbienceId1Navigations)
                .HasForeignKey(d => d.AmbienceId1)
                .HasConstraintName("soundambience_ibfk_1");

            entity.HasOne(d => d.AmbienceId2Navigation).WithMany(p => p.SoundambienceAmbienceId2Navigations)
                .HasForeignKey(d => d.AmbienceId2)
                .HasConstraintName("soundambience_ibfk_2");
        });

        modelBuilder.Entity<Soundemitter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundemitters")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.HasIndex(e => e.SoundEntriesId, "SoundEntriesID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundEntriesId).HasColumnName("SoundEntriesID");

            entity.HasOne(d => d.Map).WithMany(p => p.Soundemitters)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("soundemitters_ibfk_2");

            entity.HasOne(d => d.SoundEntries).WithMany(p => p.Soundemitters)
                .HasForeignKey(d => d.SoundEntriesId)
                .HasConstraintName("soundemitters_ibfk_1");
        });

        modelBuilder.Entity<Soundentriesadvanced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundentriesadvanced")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundEntryId, "SoundEntryID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DuckToSfx).HasColumnName("DuckToSFX");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundEntryId).HasColumnName("SoundEntryID");

            entity.HasOne(d => d.SoundEntry).WithMany(p => p.Soundentriesadvanceds)
                .HasForeignKey(d => d.SoundEntryId)
                .HasConstraintName("soundentriesadvanced_ibfk_1");
        });

        modelBuilder.Entity<Soundentry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundentries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundEntriesAdvancedId, "SoundEntriesAdvancedID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DirectoryBase).HasColumnType("text");
            entity.Property(e => e.Eaxdef).HasColumnName("EAXDef");
            entity.Property(e => e.File1)
                .HasColumnType("text")
                .HasColumnName("File_1");
            entity.Property(e => e.File10)
                .HasColumnType("text")
                .HasColumnName("File_10");
            entity.Property(e => e.File2)
                .HasColumnType("text")
                .HasColumnName("File_2");
            entity.Property(e => e.File3)
                .HasColumnType("text")
                .HasColumnName("File_3");
            entity.Property(e => e.File4)
                .HasColumnType("text")
                .HasColumnName("File_4");
            entity.Property(e => e.File5)
                .HasColumnType("text")
                .HasColumnName("File_5");
            entity.Property(e => e.File6)
                .HasColumnType("text")
                .HasColumnName("File_6");
            entity.Property(e => e.File7)
                .HasColumnType("text")
                .HasColumnName("File_7");
            entity.Property(e => e.File8)
                .HasColumnType("text")
                .HasColumnName("File_8");
            entity.Property(e => e.File9)
                .HasColumnType("text")
                .HasColumnName("File_9");
            entity.Property(e => e.Freq1).HasColumnName("Freq_1");
            entity.Property(e => e.Freq10).HasColumnName("Freq_10");
            entity.Property(e => e.Freq2).HasColumnName("Freq_2");
            entity.Property(e => e.Freq3).HasColumnName("Freq_3");
            entity.Property(e => e.Freq4).HasColumnName("Freq_4");
            entity.Property(e => e.Freq5).HasColumnName("Freq_5");
            entity.Property(e => e.Freq6).HasColumnName("Freq_6");
            entity.Property(e => e.Freq7).HasColumnName("Freq_7");
            entity.Property(e => e.Freq8).HasColumnName("Freq_8");
            entity.Property(e => e.Freq9).HasColumnName("Freq_9");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundEntriesAdvancedId).HasColumnName("SoundEntriesAdvancedID");

            entity.HasOne(d => d.SoundEntriesAdvanced).WithMany(p => p.Soundentries)
                .HasForeignKey(d => d.SoundEntriesAdvancedId)
                .HasConstraintName("soundentries_ibfk_1");
        });

        modelBuilder.Entity<Soundfilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundfilter")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Soundfilterelem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundfilterelem")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Params1).HasColumnName("Params_1");
            entity.Property(e => e.Params2).HasColumnName("Params_2");
            entity.Property(e => e.Params3).HasColumnName("Params_3");
            entity.Property(e => e.Params4).HasColumnName("Params_4");
            entity.Property(e => e.Params5).HasColumnName("Params_5");
            entity.Property(e => e.Params6).HasColumnName("Params_6");
            entity.Property(e => e.Params7).HasColumnName("Params_7");
            entity.Property(e => e.Params8).HasColumnName("Params_8");
            entity.Property(e => e.Params9).HasColumnName("Params_9");
            entity.Property(e => e.SoundFilterId).HasColumnName("SoundFilterID");
        });

        modelBuilder.Entity<Soundproviderpreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundproviderpreferences")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Eax2airAbsorption).HasColumnName("EAX2AirAbsorption");
            entity.Property(e => e.Eax2decayHfratio).HasColumnName("EAX2DecayHFRatio");
            entity.Property(e => e.Eax2environmentDiffusion).HasColumnName("EAX2EnvironmentDiffusion");
            entity.Property(e => e.Eax2environmentSize).HasColumnName("EAX2EnvironmentSize");
            entity.Property(e => e.Eax2reflections).HasColumnName("EAX2Reflections");
            entity.Property(e => e.Eax2reflectionsDelay).HasColumnName("EAX2ReflectionsDelay");
            entity.Property(e => e.Eax2reverb).HasColumnName("EAX2Reverb");
            entity.Property(e => e.Eax2reverbDelay).HasColumnName("EAX2ReverbDelay");
            entity.Property(e => e.Eax2room).HasColumnName("EAX2Room");
            entity.Property(e => e.Eax2roomHf).HasColumnName("EAX2RoomHF");
            entity.Property(e => e.Eax2roomRolloff).HasColumnName("EAX2RoomRolloff");
            entity.Property(e => e.Eax3decayLfratio).HasColumnName("EAX3DecayLFRatio");
            entity.Property(e => e.Eax3echoDepth).HasColumnName("EAX3EchoDepth");
            entity.Property(e => e.Eax3echoTime).HasColumnName("EAX3EchoTime");
            entity.Property(e => e.Eax3hfreference).HasColumnName("EAX3HFReference");
            entity.Property(e => e.Eax3lfreference).HasColumnName("EAX3LFReference");
            entity.Property(e => e.Eax3modulationDepth).HasColumnName("EAX3ModulationDepth");
            entity.Property(e => e.Eax3modulationTime).HasColumnName("EAX3ModulationTime");
            entity.Property(e => e.Eax3roomLf).HasColumnName("EAX3RoomLF");
            entity.Property(e => e.EaxdecayTime).HasColumnName("EAXDecayTime");
            entity.Property(e => e.EaxenvironmentSelection).HasColumnName("EAXEnvironmentSelection");
        });

        modelBuilder.Entity<Soundsamplepreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundsamplepreferences")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Soundwatertype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("soundwatertype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.LiquidTypeId).HasColumnName("LiquidTypeID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Sound).WithMany(p => p.Soundwatertypes)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("soundwatertype_ibfk_1");
        });

        modelBuilder.Entity<Spammessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spammessages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<Spell>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spell")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ActiveIconId, "ActiveIconID");

            entity.HasIndex(e => e.CastingTimeIndex, "CastingTimeIndex");

            entity.HasIndex(e => e.Category, "Category");

            entity.HasIndex(e => e.DispelType, "DispelType");

            entity.HasIndex(e => e.DurationIndex, "DurationIndex");

            entity.HasIndex(e => e.EffectMechanic1, "EffectMechanic_1");

            entity.HasIndex(e => e.EffectMechanic2, "EffectMechanic_2");

            entity.HasIndex(e => e.EffectMechanic3, "EffectMechanic_3");

            entity.HasIndex(e => e.EffectRadiusIndex1, "EffectRadiusIndex_1");

            entity.HasIndex(e => e.EffectRadiusIndex2, "EffectRadiusIndex_2");

            entity.HasIndex(e => e.EffectRadiusIndex3, "EffectRadiusIndex_3");

            entity.HasIndex(e => e.Mechanic, "Mechanic");

            entity.HasIndex(e => e.PowerDisplayId, "PowerDisplayID");

            entity.HasIndex(e => e.RangeIndex, "RangeIndex");

            entity.HasIndex(e => e.Reagent1, "Reagent_1");

            entity.HasIndex(e => e.Reagent2, "Reagent_2");

            entity.HasIndex(e => e.Reagent3, "Reagent_3");

            entity.HasIndex(e => e.Reagent4, "Reagent_4");

            entity.HasIndex(e => e.Reagent5, "Reagent_5");

            entity.HasIndex(e => e.Reagent6, "Reagent_6");

            entity.HasIndex(e => e.Reagent7, "Reagent_7");

            entity.HasIndex(e => e.Reagent8, "Reagent_8");

            entity.HasIndex(e => e.RequiredAreasId, "RequiredAreasID");

            entity.HasIndex(e => e.RequiredTotemCategoryId1, "RequiredTotemCategoryID_1");

            entity.HasIndex(e => e.RequiredTotemCategoryId2, "RequiredTotemCategoryID_2");

            entity.HasIndex(e => e.RequiresSpellFocus, "RequiresSpellFocus");

            entity.HasIndex(e => e.RuneCostId, "RuneCostID");

            entity.HasIndex(e => e.SpellDescriptionVariableId, "SpellDescriptionVariableID");

            entity.HasIndex(e => e.SpellDifficultyId, "SpellDifficultyID");

            entity.HasIndex(e => e.SpellIconId, "SpellIconID");

            entity.HasIndex(e => e.SpellMissileId, "SpellMissileID");

            entity.HasIndex(e => e.SpellVisualId1, "SpellVisualID_1");

            entity.HasIndex(e => e.SpellVisualId2, "SpellVisualID_2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActiveIconId).HasColumnName("ActiveIconID");
            entity.Property(e => e.AuraDescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_deDE");
            entity.Property(e => e.AuraDescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_enCN");
            entity.Property(e => e.AuraDescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_enGB");
            entity.Property(e => e.AuraDescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_enTW");
            entity.Property(e => e.AuraDescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_enUS");
            entity.Property(e => e.AuraDescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_esES");
            entity.Property(e => e.AuraDescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_esMX");
            entity.Property(e => e.AuraDescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_frFR");
            entity.Property(e => e.AuraDescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_itIT");
            entity.Property(e => e.AuraDescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_koKR");
            entity.Property(e => e.AuraDescriptionLangMask).HasColumnName("AuraDescription_Lang_Mask");
            entity.Property(e => e.AuraDescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_ptBR");
            entity.Property(e => e.AuraDescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_ptPT");
            entity.Property(e => e.AuraDescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_ruRU");
            entity.Property(e => e.AuraDescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_Unk");
            entity.Property(e => e.AuraDescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_zhCN");
            entity.Property(e => e.AuraDescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("AuraDescription_Lang_zhTW");
            entity.Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity.Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity.Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity.Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity.Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity.Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity.Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity.Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity.Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity.Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity.Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity.Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity.Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity.Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity.Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity.Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.Effect1).HasColumnName("Effect_1");
            entity.Property(e => e.Effect2).HasColumnName("Effect_2");
            entity.Property(e => e.Effect3).HasColumnName("Effect_3");
            entity.Property(e => e.EffectAura1).HasColumnName("EffectAura_1");
            entity.Property(e => e.EffectAura2).HasColumnName("EffectAura_2");
            entity.Property(e => e.EffectAura3).HasColumnName("EffectAura_3");
            entity.Property(e => e.EffectAuraPeriod1).HasColumnName("EffectAuraPeriod_1");
            entity.Property(e => e.EffectAuraPeriod2).HasColumnName("EffectAuraPeriod_2");
            entity.Property(e => e.EffectAuraPeriod3).HasColumnName("EffectAuraPeriod_3");
            entity.Property(e => e.EffectBasePoints1).HasColumnName("EffectBasePoints_1");
            entity.Property(e => e.EffectBasePoints2).HasColumnName("EffectBasePoints_2");
            entity.Property(e => e.EffectBasePoints3).HasColumnName("EffectBasePoints_3");
            entity.Property(e => e.EffectChainAmplitude1).HasColumnName("EffectChainAmplitude_1");
            entity.Property(e => e.EffectChainAmplitude2).HasColumnName("EffectChainAmplitude_2");
            entity.Property(e => e.EffectChainAmplitude3).HasColumnName("EffectChainAmplitude_3");
            entity.Property(e => e.EffectChainTargets1).HasColumnName("EffectChainTargets_1");
            entity.Property(e => e.EffectChainTargets2).HasColumnName("EffectChainTargets_2");
            entity.Property(e => e.EffectChainTargets3).HasColumnName("EffectChainTargets_3");
            entity.Property(e => e.EffectDieSides1).HasColumnName("EffectDieSides_1");
            entity.Property(e => e.EffectDieSides2).HasColumnName("EffectDieSides_2");
            entity.Property(e => e.EffectDieSides3).HasColumnName("EffectDieSides_3");
            entity.Property(e => e.EffectItemType1).HasColumnName("EffectItemType_1");
            entity.Property(e => e.EffectItemType2).HasColumnName("EffectItemType_2");
            entity.Property(e => e.EffectItemType3).HasColumnName("EffectItemType_3");
            entity.Property(e => e.EffectMechanic1).HasColumnName("EffectMechanic_1");
            entity.Property(e => e.EffectMechanic2).HasColumnName("EffectMechanic_2");
            entity.Property(e => e.EffectMechanic3).HasColumnName("EffectMechanic_3");
            entity.Property(e => e.EffectMiscValue1).HasColumnName("EffectMiscValue_1");
            entity.Property(e => e.EffectMiscValue2).HasColumnName("EffectMiscValue_2");
            entity.Property(e => e.EffectMiscValue3).HasColumnName("EffectMiscValue_3");
            entity.Property(e => e.EffectMiscValueB1).HasColumnName("EffectMiscValueB_1");
            entity.Property(e => e.EffectMiscValueB2).HasColumnName("EffectMiscValueB_2");
            entity.Property(e => e.EffectMiscValueB3).HasColumnName("EffectMiscValueB_3");
            entity.Property(e => e.EffectMultipleValue1).HasColumnName("EffectMultipleValue_1");
            entity.Property(e => e.EffectMultipleValue2).HasColumnName("EffectMultipleValue_2");
            entity.Property(e => e.EffectMultipleValue3).HasColumnName("EffectMultipleValue_3");
            entity.Property(e => e.EffectPointsPerCombo1).HasColumnName("EffectPointsPerCombo_1");
            entity.Property(e => e.EffectPointsPerCombo2).HasColumnName("EffectPointsPerCombo_2");
            entity.Property(e => e.EffectPointsPerCombo3).HasColumnName("EffectPointsPerCombo_3");
            entity.Property(e => e.EffectRadiusIndex1).HasColumnName("EffectRadiusIndex_1");
            entity.Property(e => e.EffectRadiusIndex2).HasColumnName("EffectRadiusIndex_2");
            entity.Property(e => e.EffectRadiusIndex3).HasColumnName("EffectRadiusIndex_3");
            entity.Property(e => e.EffectRealPointsPerLevel1).HasColumnName("EffectRealPointsPerLevel_1");
            entity.Property(e => e.EffectRealPointsPerLevel2).HasColumnName("EffectRealPointsPerLevel_2");
            entity.Property(e => e.EffectRealPointsPerLevel3).HasColumnName("EffectRealPointsPerLevel_3");
            entity.Property(e => e.EffectSpellClassMaskA1).HasColumnName("EffectSpellClassMaskA_1");
            entity.Property(e => e.EffectSpellClassMaskA2).HasColumnName("EffectSpellClassMaskA_2");
            entity.Property(e => e.EffectSpellClassMaskA3).HasColumnName("EffectSpellClassMaskA_3");
            entity.Property(e => e.EffectSpellClassMaskB1).HasColumnName("EffectSpellClassMaskB_1");
            entity.Property(e => e.EffectSpellClassMaskB2).HasColumnName("EffectSpellClassMaskB_2");
            entity.Property(e => e.EffectSpellClassMaskB3).HasColumnName("EffectSpellClassMaskB_3");
            entity.Property(e => e.EffectSpellClassMaskC1).HasColumnName("EffectSpellClassMaskC_1");
            entity.Property(e => e.EffectSpellClassMaskC2).HasColumnName("EffectSpellClassMaskC_2");
            entity.Property(e => e.EffectSpellClassMaskC3).HasColumnName("EffectSpellClassMaskC_3");
            entity.Property(e => e.EffectTriggerSpell1).HasColumnName("EffectTriggerSpell_1");
            entity.Property(e => e.EffectTriggerSpell2).HasColumnName("EffectTriggerSpell_2");
            entity.Property(e => e.EffectTriggerSpell3).HasColumnName("EffectTriggerSpell_3");
            entity.Property(e => e.ImplicitTargetA1).HasColumnName("ImplicitTargetA_1");
            entity.Property(e => e.ImplicitTargetA2).HasColumnName("ImplicitTargetA_2");
            entity.Property(e => e.ImplicitTargetA3).HasColumnName("ImplicitTargetA_3");
            entity.Property(e => e.ImplicitTargetB1).HasColumnName("ImplicitTargetB_1");
            entity.Property(e => e.ImplicitTargetB2).HasColumnName("ImplicitTargetB_2");
            entity.Property(e => e.ImplicitTargetB3).HasColumnName("ImplicitTargetB_3");
            entity.Property(e => e.MinFactionId).HasColumnName("MinFactionID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.NameSubtextLangDeDe)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_deDE");
            entity.Property(e => e.NameSubtextLangEnCn)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_enCN");
            entity.Property(e => e.NameSubtextLangEnGb)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_enGB");
            entity.Property(e => e.NameSubtextLangEnTw)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_enTW");
            entity.Property(e => e.NameSubtextLangEnUs)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_enUS");
            entity.Property(e => e.NameSubtextLangEsEs)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_esES");
            entity.Property(e => e.NameSubtextLangEsMx)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_esMX");
            entity.Property(e => e.NameSubtextLangFrFr)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_frFR");
            entity.Property(e => e.NameSubtextLangItIt)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_itIT");
            entity.Property(e => e.NameSubtextLangKoKr)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_koKR");
            entity.Property(e => e.NameSubtextLangMask).HasColumnName("NameSubtext_Lang_Mask");
            entity.Property(e => e.NameSubtextLangPtBr)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_ptBR");
            entity.Property(e => e.NameSubtextLangPtPt)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_ptPT");
            entity.Property(e => e.NameSubtextLangRuRu)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_ruRU");
            entity.Property(e => e.NameSubtextLangUnk)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_Unk");
            entity.Property(e => e.NameSubtextLangZhCn)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_zhCN");
            entity.Property(e => e.NameSubtextLangZhTw)
                .HasColumnType("text")
                .HasColumnName("NameSubtext_Lang_zhTW");
            entity.Property(e => e.PowerDisplayId).HasColumnName("PowerDisplayID");
            entity.Property(e => e.Reagent1).HasColumnName("Reagent_1");
            entity.Property(e => e.Reagent2).HasColumnName("Reagent_2");
            entity.Property(e => e.Reagent3).HasColumnName("Reagent_3");
            entity.Property(e => e.Reagent4).HasColumnName("Reagent_4");
            entity.Property(e => e.Reagent5).HasColumnName("Reagent_5");
            entity.Property(e => e.Reagent6).HasColumnName("Reagent_6");
            entity.Property(e => e.Reagent7).HasColumnName("Reagent_7");
            entity.Property(e => e.Reagent8).HasColumnName("Reagent_8");
            entity.Property(e => e.ReagentCount1).HasColumnName("ReagentCount_1");
            entity.Property(e => e.ReagentCount2).HasColumnName("ReagentCount_2");
            entity.Property(e => e.ReagentCount3).HasColumnName("ReagentCount_3");
            entity.Property(e => e.ReagentCount4).HasColumnName("ReagentCount_4");
            entity.Property(e => e.ReagentCount5).HasColumnName("ReagentCount_5");
            entity.Property(e => e.ReagentCount6).HasColumnName("ReagentCount_6");
            entity.Property(e => e.ReagentCount7).HasColumnName("ReagentCount_7");
            entity.Property(e => e.ReagentCount8).HasColumnName("ReagentCount_8");
            entity.Property(e => e.RequiredAreasId).HasColumnName("RequiredAreasID");
            entity.Property(e => e.RequiredTotemCategoryId1).HasColumnName("RequiredTotemCategoryID_1");
            entity.Property(e => e.RequiredTotemCategoryId2).HasColumnName("RequiredTotemCategoryID_2");
            entity.Property(e => e.RuneCostId).HasColumnName("RuneCostID");
            entity.Property(e => e.SpellClassMask1).HasColumnName("SpellClassMask_1");
            entity.Property(e => e.SpellClassMask2).HasColumnName("SpellClassMask_2");
            entity.Property(e => e.SpellClassMask3).HasColumnName("SpellClassMask_3");
            entity.Property(e => e.SpellDescriptionVariableId).HasColumnName("SpellDescriptionVariableID");
            entity.Property(e => e.SpellDifficultyId).HasColumnName("SpellDifficultyID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
            entity.Property(e => e.SpellMissileId).HasColumnName("SpellMissileID");
            entity.Property(e => e.SpellVisualId1).HasColumnName("SpellVisualID_1");
            entity.Property(e => e.SpellVisualId2).HasColumnName("SpellVisualID_2");
            entity.Property(e => e.Totem1).HasColumnName("Totem_1");
            entity.Property(e => e.Totem2).HasColumnName("Totem_2");

            entity.HasOne(d => d.ActiveIcon).WithMany(p => p.SpellActiveIcons)
                .HasForeignKey(d => d.ActiveIconId)
                .HasConstraintName("spell_ibfk_27");

            entity.HasOne(d => d.CastingTimeIndexNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.CastingTimeIndex)
                .HasConstraintName("spell_ibfk_5");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("spell_ibfk_1");

            entity.HasOne(d => d.DispelTypeNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.DispelType)
                .HasConstraintName("spell_ibfk_2");

            entity.HasOne(d => d.DurationIndexNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.DurationIndex)
                .HasConstraintName("spell_ibfk_6");

            entity.HasOne(d => d.EffectMechanic1Navigation).WithMany(p => p.SpellEffectMechanic1Navigations)
                .HasForeignKey(d => d.EffectMechanic1)
                .HasConstraintName("spell_ibfk_8");

            entity.HasOne(d => d.EffectMechanic2Navigation).WithMany(p => p.SpellEffectMechanic2Navigations)
                .HasForeignKey(d => d.EffectMechanic2)
                .HasConstraintName("spell_ibfk_9");

            entity.HasOne(d => d.EffectMechanic3Navigation).WithMany(p => p.SpellEffectMechanic3Navigations)
                .HasForeignKey(d => d.EffectMechanic3)
                .HasConstraintName("spell_ibfk_10");

            entity.HasOne(d => d.EffectRadiusIndex1Navigation).WithMany(p => p.SpellEffectRadiusIndex1Navigations)
                .HasForeignKey(d => d.EffectRadiusIndex1)
                .HasConstraintName("spell_ibfk_11");

            entity.HasOne(d => d.EffectRadiusIndex2Navigation).WithMany(p => p.SpellEffectRadiusIndex2Navigations)
                .HasForeignKey(d => d.EffectRadiusIndex2)
                .HasConstraintName("spell_ibfk_12");

            entity.HasOne(d => d.EffectRadiusIndex3Navigation).WithMany(p => p.SpellEffectRadiusIndex3Navigations)
                .HasForeignKey(d => d.EffectRadiusIndex3)
                .HasConstraintName("spell_ibfk_13");

            entity.HasOne(d => d.MechanicNavigation).WithMany(p => p.SpellMechanicNavigations)
                .HasForeignKey(d => d.Mechanic)
                .HasConstraintName("spell_ibfk_3");

            entity.HasOne(d => d.PowerDisplay).WithMany(p => p.Spells)
                .HasForeignKey(d => d.PowerDisplayId)
                .HasConstraintName("spell_ibfk_33");

            entity.HasOne(d => d.RangeIndexNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.RangeIndex)
                .HasConstraintName("spell_ibfk_7");

            entity.HasOne(d => d.Reagent1Navigation).WithMany(p => p.SpellReagent1Navigations)
                .HasForeignKey(d => d.Reagent1)
                .HasConstraintName("spell_ibfk_16");

            entity.HasOne(d => d.Reagent2Navigation).WithMany(p => p.SpellReagent2Navigations)
                .HasForeignKey(d => d.Reagent2)
                .HasConstraintName("spell_ibfk_17");

            entity.HasOne(d => d.Reagent3Navigation).WithMany(p => p.SpellReagent3Navigations)
                .HasForeignKey(d => d.Reagent3)
                .HasConstraintName("spell_ibfk_18");

            entity.HasOne(d => d.Reagent4Navigation).WithMany(p => p.SpellReagent4Navigations)
                .HasForeignKey(d => d.Reagent4)
                .HasConstraintName("spell_ibfk_19");

            entity.HasOne(d => d.Reagent5Navigation).WithMany(p => p.SpellReagent5Navigations)
                .HasForeignKey(d => d.Reagent5)
                .HasConstraintName("spell_ibfk_20");

            entity.HasOne(d => d.Reagent6Navigation).WithMany(p => p.SpellReagent6Navigations)
                .HasForeignKey(d => d.Reagent6)
                .HasConstraintName("spell_ibfk_21");

            entity.HasOne(d => d.Reagent7Navigation).WithMany(p => p.SpellReagent7Navigations)
                .HasForeignKey(d => d.Reagent7)
                .HasConstraintName("spell_ibfk_22");

            entity.HasOne(d => d.Reagent8Navigation).WithMany(p => p.SpellReagent8Navigations)
                .HasForeignKey(d => d.Reagent8)
                .HasConstraintName("spell_ibfk_23");

            entity.HasOne(d => d.RequiredAreas).WithMany(p => p.Spells)
                .HasForeignKey(d => d.RequiredAreasId)
                .HasConstraintName("spell_ibfk_28");

            entity.HasOne(d => d.RequiredTotemCategoryId1Navigation).WithMany(p => p.SpellRequiredTotemCategoryId1Navigations)
                .HasForeignKey(d => d.RequiredTotemCategoryId1)
                .HasConstraintName("spell_ibfk_14");

            entity.HasOne(d => d.RequiredTotemCategoryId2Navigation).WithMany(p => p.SpellRequiredTotemCategoryId2Navigations)
                .HasForeignKey(d => d.RequiredTotemCategoryId2)
                .HasConstraintName("spell_ibfk_15");

            entity.HasOne(d => d.RequiresSpellFocusNavigation).WithMany(p => p.Spells)
                .HasForeignKey(d => d.RequiresSpellFocus)
                .HasConstraintName("spell_ibfk_4");

            entity.HasOne(d => d.RuneCost).WithMany(p => p.Spells)
                .HasForeignKey(d => d.RuneCostId)
                .HasConstraintName("spell_ibfk_29");

            entity.HasOne(d => d.SpellDescriptionVariable).WithMany(p => p.Spells)
                .HasForeignKey(d => d.SpellDescriptionVariableId)
                .HasConstraintName("spell_ibfk_31");

            entity.HasOne(d => d.SpellDifficulty).WithMany(p => p.Spells)
                .HasForeignKey(d => d.SpellDifficultyId)
                .HasConstraintName("spell_ibfk_32");

            entity.HasOne(d => d.SpellIcon).WithMany(p => p.SpellSpellIcons)
                .HasForeignKey(d => d.SpellIconId)
                .HasConstraintName("spell_ibfk_26");

            entity.HasOne(d => d.SpellMissile).WithMany(p => p.Spells)
                .HasForeignKey(d => d.SpellMissileId)
                .HasConstraintName("spell_ibfk_30");

            entity.HasOne(d => d.SpellVisualId1Navigation).WithMany(p => p.SpellSpellVisualId1Navigations)
                .HasForeignKey(d => d.SpellVisualId1)
                .HasConstraintName("spell_ibfk_24");

            entity.HasOne(d => d.SpellVisualId2Navigation).WithMany(p => p.SpellSpellVisualId2Navigations)
                .HasForeignKey(d => d.SpellVisualId2)
                .HasConstraintName("spell_ibfk_25");
        });

        modelBuilder.Entity<Spellcasttime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellcasttimes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spellcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellcategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spellchaineffect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellchaineffects")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Combo).HasColumnType("text");
            entity.Property(e => e.Texture).HasColumnType("text");
        });

        modelBuilder.Entity<Spelldescriptionvariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spelldescriptionvariables")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Variables).HasColumnType("text");
        });

        modelBuilder.Entity<Spelldifficulty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spelldifficulty")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DifficultySpellId1, "DifficultySpellID_1");

            entity.HasIndex(e => e.DifficultySpellId2, "DifficultySpellID_2");

            entity.HasIndex(e => e.DifficultySpellId3, "DifficultySpellID_3");

            entity.HasIndex(e => e.DifficultySpellId4, "DifficultySpellID_4");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DifficultySpellId1).HasColumnName("DifficultySpellID_1");
            entity.Property(e => e.DifficultySpellId2).HasColumnName("DifficultySpellID_2");
            entity.Property(e => e.DifficultySpellId3).HasColumnName("DifficultySpellID_3");
            entity.Property(e => e.DifficultySpellId4).HasColumnName("DifficultySpellID_4");

            entity.HasOne(d => d.DifficultySpellId1Navigation).WithMany(p => p.SpelldifficultyDifficultySpellId1Navigations)
                .HasForeignKey(d => d.DifficultySpellId1)
                .HasConstraintName("spelldifficulty_ibfk_1");

            entity.HasOne(d => d.DifficultySpellId2Navigation).WithMany(p => p.SpelldifficultyDifficultySpellId2Navigations)
                .HasForeignKey(d => d.DifficultySpellId2)
                .HasConstraintName("spelldifficulty_ibfk_2");

            entity.HasOne(d => d.DifficultySpellId3Navigation).WithMany(p => p.SpelldifficultyDifficultySpellId3Navigations)
                .HasForeignKey(d => d.DifficultySpellId3)
                .HasConstraintName("spelldifficulty_ibfk_3");

            entity.HasOne(d => d.DifficultySpellId4Navigation).WithMany(p => p.SpelldifficultyDifficultySpellId4Navigations)
                .HasForeignKey(d => d.DifficultySpellId4)
                .HasConstraintName("spelldifficulty_ibfk_4");
        });

        modelBuilder.Entity<Spelldispeltype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spelldispeltype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.InternalName).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Spellduration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellduration")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spelleffectcamerashake>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spelleffectcamerashakes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CameraShake1, "CameraShake_1");

            entity.HasIndex(e => e.CameraShake2, "CameraShake_2");

            entity.HasIndex(e => e.CameraShake3, "CameraShake_3");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CameraShake1).HasColumnName("CameraShake_1");
            entity.Property(e => e.CameraShake2).HasColumnName("CameraShake_2");
            entity.Property(e => e.CameraShake3).HasColumnName("CameraShake_3");

            entity.HasOne(d => d.CameraShake1Navigation).WithMany(p => p.SpelleffectcamerashakeCameraShake1Navigations)
                .HasForeignKey(d => d.CameraShake1)
                .HasConstraintName("spelleffectcamerashakes_ibfk_1");

            entity.HasOne(d => d.CameraShake2Navigation).WithMany(p => p.SpelleffectcamerashakeCameraShake2Navigations)
                .HasForeignKey(d => d.CameraShake2)
                .HasConstraintName("spelleffectcamerashakes_ibfk_2");

            entity.HasOne(d => d.CameraShake3Navigation).WithMany(p => p.SpelleffectcamerashakeCameraShake3Navigations)
                .HasForeignKey(d => d.CameraShake3)
                .HasConstraintName("spelleffectcamerashakes_ibfk_3");
        });

        modelBuilder.Entity<Spellfocusobject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellfocusobject")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Spellicon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellicon")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TextureFilename).HasColumnType("text");
        });

        modelBuilder.Entity<Spellitemenchantment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellitemenchantment")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ConditionId, "Condition_Id");

            entity.HasIndex(e => e.Effect1, "Effect_1");

            entity.HasIndex(e => e.Effect2, "Effect_2");

            entity.HasIndex(e => e.Effect3, "Effect_3");

            entity.HasIndex(e => e.ItemVisual, "ItemVisual");

            entity.HasIndex(e => e.RequiredSkillId, "RequiredSkillID");

            entity.HasIndex(e => e.SrcItemId, "Src_ItemID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ConditionId).HasColumnName("Condition_Id");
            entity.Property(e => e.Effect1).HasColumnName("Effect_1");
            entity.Property(e => e.Effect2).HasColumnName("Effect_2");
            entity.Property(e => e.Effect3).HasColumnName("Effect_3");
            entity.Property(e => e.EffectArg1).HasColumnName("EffectArg_1");
            entity.Property(e => e.EffectArg2).HasColumnName("EffectArg_2");
            entity.Property(e => e.EffectArg3).HasColumnName("EffectArg_3");
            entity.Property(e => e.EffectPointsMax1).HasColumnName("EffectPointsMax_1");
            entity.Property(e => e.EffectPointsMax2).HasColumnName("EffectPointsMax_2");
            entity.Property(e => e.EffectPointsMax3).HasColumnName("EffectPointsMax_3");
            entity.Property(e => e.EffectPointsMin1).HasColumnName("EffectPointsMin_1");
            entity.Property(e => e.EffectPointsMin2).HasColumnName("EffectPointsMin_2");
            entity.Property(e => e.EffectPointsMin3).HasColumnName("EffectPointsMin_3");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.RequiredSkillId).HasColumnName("RequiredSkillID");
            entity.Property(e => e.SrcItemId).HasColumnName("Src_ItemID");

            entity.HasOne(d => d.Condition).WithMany(p => p.Spellitemenchantments)
                .HasForeignKey(d => d.ConditionId)
                .HasConstraintName("spellitemenchantment_ibfk_6");

            entity.HasOne(d => d.Effect1Navigation).WithMany(p => p.SpellitemenchantmentEffect1Navigations)
                .HasForeignKey(d => d.Effect1)
                .HasConstraintName("spellitemenchantment_ibfk_1");

            entity.HasOne(d => d.Effect2Navigation).WithMany(p => p.SpellitemenchantmentEffect2Navigations)
                .HasForeignKey(d => d.Effect2)
                .HasConstraintName("spellitemenchantment_ibfk_2");

            entity.HasOne(d => d.Effect3Navigation).WithMany(p => p.SpellitemenchantmentEffect3Navigations)
                .HasForeignKey(d => d.Effect3)
                .HasConstraintName("spellitemenchantment_ibfk_3");

            entity.HasOne(d => d.ItemVisualNavigation).WithMany(p => p.Spellitemenchantments)
                .HasForeignKey(d => d.ItemVisual)
                .HasConstraintName("spellitemenchantment_ibfk_4");

            entity.HasOne(d => d.RequiredSkill).WithMany(p => p.Spellitemenchantments)
                .HasForeignKey(d => d.RequiredSkillId)
                .HasConstraintName("spellitemenchantment_ibfk_7");

            entity.HasOne(d => d.SrcItem).WithMany(p => p.Spellitemenchantments)
                .HasForeignKey(d => d.SrcItemId)
                .HasConstraintName("spellitemenchantment_ibfk_5");
        });

        modelBuilder.Entity<Spellitemenchantmentcondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellitemenchantmentcondition")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Logic1).HasColumnName("Logic_1");
            entity.Property(e => e.Logic2).HasColumnName("Logic_2");
            entity.Property(e => e.Logic3).HasColumnName("Logic_3");
            entity.Property(e => e.Logic4).HasColumnName("Logic_4");
            entity.Property(e => e.Logic5).HasColumnName("Logic_5");
            entity.Property(e => e.LtOperand1).HasColumnName("Lt_Operand_1");
            entity.Property(e => e.LtOperand2).HasColumnName("Lt_Operand_2");
            entity.Property(e => e.LtOperand3).HasColumnName("Lt_Operand_3");
            entity.Property(e => e.LtOperand4).HasColumnName("Lt_Operand_4");
            entity.Property(e => e.LtOperand5).HasColumnName("Lt_Operand_5");
            entity.Property(e => e.LtOperandType1).HasColumnName("Lt_OperandType_1");
            entity.Property(e => e.LtOperandType2).HasColumnName("Lt_OperandType_2");
            entity.Property(e => e.LtOperandType3).HasColumnName("Lt_OperandType_3");
            entity.Property(e => e.LtOperandType4).HasColumnName("Lt_OperandType_4");
            entity.Property(e => e.LtOperandType5).HasColumnName("Lt_OperandType_5");
            entity.Property(e => e.Operator1).HasColumnName("Operator_1");
            entity.Property(e => e.Operator2).HasColumnName("Operator_2");
            entity.Property(e => e.Operator3).HasColumnName("Operator_3");
            entity.Property(e => e.Operator4).HasColumnName("Operator_4");
            entity.Property(e => e.Operator5).HasColumnName("Operator_5");
            entity.Property(e => e.RtOperand1).HasColumnName("Rt_Operand_1");
            entity.Property(e => e.RtOperand2).HasColumnName("Rt_Operand_2");
            entity.Property(e => e.RtOperand3).HasColumnName("Rt_Operand_3");
            entity.Property(e => e.RtOperand4).HasColumnName("Rt_Operand_4");
            entity.Property(e => e.RtOperand5).HasColumnName("Rt_Operand_5");
            entity.Property(e => e.RtOperandType1).HasColumnName("Rt_OperandType_1");
            entity.Property(e => e.RtOperandType2).HasColumnName("Rt_OperandType_2");
            entity.Property(e => e.RtOperandType3).HasColumnName("Rt_OperandType_3");
            entity.Property(e => e.RtOperandType4).HasColumnName("Rt_OperandType_4");
            entity.Property(e => e.RtOperandType5).HasColumnName("Rt_OperandType_5");
        });

        modelBuilder.Entity<Spellmechanic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellmechanic")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.StateNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_deDE");
            entity.Property(e => e.StateNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_enCN");
            entity.Property(e => e.StateNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_enGB");
            entity.Property(e => e.StateNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_enTW");
            entity.Property(e => e.StateNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_enUS");
            entity.Property(e => e.StateNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_esES");
            entity.Property(e => e.StateNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_esMX");
            entity.Property(e => e.StateNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_frFR");
            entity.Property(e => e.StateNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_itIT");
            entity.Property(e => e.StateNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_koKR");
            entity.Property(e => e.StateNameLangMask).HasColumnName("StateName_Lang_Mask");
            entity.Property(e => e.StateNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_ptBR");
            entity.Property(e => e.StateNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_ptPT");
            entity.Property(e => e.StateNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_ruRU");
            entity.Property(e => e.StateNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_Unk");
            entity.Property(e => e.StateNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_zhCN");
            entity.Property(e => e.StateNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("StateName_Lang_zhTW");
        });

        modelBuilder.Entity<Spellmissile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellmissile")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spellmissilemotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellmissilemotion")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.ScriptBody).HasColumnType("text");
        });

        modelBuilder.Entity<Spellradius>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellradius")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spellrange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellrange")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DisplayNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_deDE");
            entity.Property(e => e.DisplayNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enCN");
            entity.Property(e => e.DisplayNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enGB");
            entity.Property(e => e.DisplayNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enTW");
            entity.Property(e => e.DisplayNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enUS");
            entity.Property(e => e.DisplayNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esES");
            entity.Property(e => e.DisplayNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esMX");
            entity.Property(e => e.DisplayNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_frFR");
            entity.Property(e => e.DisplayNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_itIT");
            entity.Property(e => e.DisplayNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity.Property(e => e.DisplayNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptBR");
            entity.Property(e => e.DisplayNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptPT");
            entity.Property(e => e.DisplayNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ruRU");
            entity.Property(e => e.DisplayNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_Unk");
            entity.Property(e => e.DisplayNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhCN");
            entity.Property(e => e.DisplayNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhTW");
            entity.Property(e => e.DisplayNameShortLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_deDE");
            entity.Property(e => e.DisplayNameShortLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enCN");
            entity.Property(e => e.DisplayNameShortLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enGB");
            entity.Property(e => e.DisplayNameShortLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enTW");
            entity.Property(e => e.DisplayNameShortLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enUS");
            entity.Property(e => e.DisplayNameShortLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_esES");
            entity.Property(e => e.DisplayNameShortLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_esMX");
            entity.Property(e => e.DisplayNameShortLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_frFR");
            entity.Property(e => e.DisplayNameShortLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_itIT");
            entity.Property(e => e.DisplayNameShortLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_koKR");
            entity.Property(e => e.DisplayNameShortLangMask).HasColumnName("DisplayNameShort_Lang_Mask");
            entity.Property(e => e.DisplayNameShortLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ptBR");
            entity.Property(e => e.DisplayNameShortLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ptPT");
            entity.Property(e => e.DisplayNameShortLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ruRU");
            entity.Property(e => e.DisplayNameShortLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_Unk");
            entity.Property(e => e.DisplayNameShortLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_zhCN");
            entity.Property(e => e.DisplayNameShortLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_zhTW");
            entity.Property(e => e.RangeMax1).HasColumnName("RangeMax_1");
            entity.Property(e => e.RangeMax2).HasColumnName("RangeMax_2");
            entity.Property(e => e.RangeMin1).HasColumnName("RangeMin_1");
            entity.Property(e => e.RangeMin2).HasColumnName("RangeMin_2");
        });

        modelBuilder.Entity<Spellrunecost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellrunecost")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Spellshapeshiftform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellshapeshiftform")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AttackIconId, "AttackIconID");

            entity.HasIndex(e => e.CreatureDisplayId1, "CreatureDisplayID_1");

            entity.HasIndex(e => e.CreatureDisplayId2, "CreatureDisplayID_2");

            entity.HasIndex(e => e.CreatureDisplayId3, "CreatureDisplayID_3");

            entity.HasIndex(e => e.CreatureDisplayId4, "CreatureDisplayID_4");

            entity.HasIndex(e => e.CreatureType, "CreatureType");

            entity.HasIndex(e => e.PresetSpellId1, "PresetSpellID_1");

            entity.HasIndex(e => e.PresetSpellId2, "PresetSpellID_2");

            entity.HasIndex(e => e.PresetSpellId3, "PresetSpellID_3");

            entity.HasIndex(e => e.PresetSpellId4, "PresetSpellID_4");

            entity.HasIndex(e => e.PresetSpellId5, "PresetSpellID_5");

            entity.HasIndex(e => e.PresetSpellId6, "PresetSpellID_6");

            entity.HasIndex(e => e.PresetSpellId7, "PresetSpellID_7");

            entity.HasIndex(e => e.PresetSpellId8, "PresetSpellID_8");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttackIconId).HasColumnName("AttackIconID");
            entity.Property(e => e.CreatureDisplayId1).HasColumnName("CreatureDisplayID_1");
            entity.Property(e => e.CreatureDisplayId2).HasColumnName("CreatureDisplayID_2");
            entity.Property(e => e.CreatureDisplayId3).HasColumnName("CreatureDisplayID_3");
            entity.Property(e => e.CreatureDisplayId4).HasColumnName("CreatureDisplayID_4");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.PresetSpellId1).HasColumnName("PresetSpellID_1");
            entity.Property(e => e.PresetSpellId2).HasColumnName("PresetSpellID_2");
            entity.Property(e => e.PresetSpellId3).HasColumnName("PresetSpellID_3");
            entity.Property(e => e.PresetSpellId4).HasColumnName("PresetSpellID_4");
            entity.Property(e => e.PresetSpellId5).HasColumnName("PresetSpellID_5");
            entity.Property(e => e.PresetSpellId6).HasColumnName("PresetSpellID_6");
            entity.Property(e => e.PresetSpellId7).HasColumnName("PresetSpellID_7");
            entity.Property(e => e.PresetSpellId8).HasColumnName("PresetSpellID_8");

            entity.HasOne(d => d.AttackIcon).WithMany(p => p.Spellshapeshiftforms)
                .HasForeignKey(d => d.AttackIconId)
                .HasConstraintName("spellshapeshiftform_ibfk_2");

            entity.HasOne(d => d.CreatureDisplayId1Navigation).WithMany(p => p.SpellshapeshiftformCreatureDisplayId1Navigations)
                .HasForeignKey(d => d.CreatureDisplayId1)
                .HasConstraintName("spellshapeshiftform_ibfk_3");

            entity.HasOne(d => d.CreatureDisplayId2Navigation).WithMany(p => p.SpellshapeshiftformCreatureDisplayId2Navigations)
                .HasForeignKey(d => d.CreatureDisplayId2)
                .HasConstraintName("spellshapeshiftform_ibfk_4");

            entity.HasOne(d => d.CreatureDisplayId3Navigation).WithMany(p => p.SpellshapeshiftformCreatureDisplayId3Navigations)
                .HasForeignKey(d => d.CreatureDisplayId3)
                .HasConstraintName("spellshapeshiftform_ibfk_5");

            entity.HasOne(d => d.CreatureDisplayId4Navigation).WithMany(p => p.SpellshapeshiftformCreatureDisplayId4Navigations)
                .HasForeignKey(d => d.CreatureDisplayId4)
                .HasConstraintName("spellshapeshiftform_ibfk_6");

            entity.HasOne(d => d.CreatureTypeNavigation).WithMany(p => p.Spellshapeshiftforms)
                .HasForeignKey(d => d.CreatureType)
                .HasConstraintName("spellshapeshiftform_ibfk_1");

            entity.HasOne(d => d.PresetSpellId1Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId1Navigations)
                .HasForeignKey(d => d.PresetSpellId1)
                .HasConstraintName("spellshapeshiftform_ibfk_7");

            entity.HasOne(d => d.PresetSpellId2Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId2Navigations)
                .HasForeignKey(d => d.PresetSpellId2)
                .HasConstraintName("spellshapeshiftform_ibfk_8");

            entity.HasOne(d => d.PresetSpellId3Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId3Navigations)
                .HasForeignKey(d => d.PresetSpellId3)
                .HasConstraintName("spellshapeshiftform_ibfk_9");

            entity.HasOne(d => d.PresetSpellId4Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId4Navigations)
                .HasForeignKey(d => d.PresetSpellId4)
                .HasConstraintName("spellshapeshiftform_ibfk_10");

            entity.HasOne(d => d.PresetSpellId5Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId5Navigations)
                .HasForeignKey(d => d.PresetSpellId5)
                .HasConstraintName("spellshapeshiftform_ibfk_11");

            entity.HasOne(d => d.PresetSpellId6Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId6Navigations)
                .HasForeignKey(d => d.PresetSpellId6)
                .HasConstraintName("spellshapeshiftform_ibfk_12");

            entity.HasOne(d => d.PresetSpellId7Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId7Navigations)
                .HasForeignKey(d => d.PresetSpellId7)
                .HasConstraintName("spellshapeshiftform_ibfk_13");

            entity.HasOne(d => d.PresetSpellId8Navigation).WithMany(p => p.SpellshapeshiftformPresetSpellId8Navigations)
                .HasForeignKey(d => d.PresetSpellId8)
                .HasConstraintName("spellshapeshiftform_ibfk_14");
        });

        modelBuilder.Entity<Spellvisual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisual")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AnimEventSoundId, "AnimEventSoundID");

            entity.HasIndex(e => e.CastKit, "CastKit");

            entity.HasIndex(e => e.CasterImpactKit, "CasterImpactKit");

            entity.HasIndex(e => e.ChannelKit, "ChannelKit");

            entity.HasIndex(e => e.ImpactAreaKit, "ImpactAreaKit");

            entity.HasIndex(e => e.ImpactKit, "ImpactKit");

            entity.HasIndex(e => e.InstantAreaKit, "InstantAreaKit");

            entity.HasIndex(e => e.MissileModel, "MissileModel");

            entity.HasIndex(e => e.MissileSound, "MissileSound");

            entity.HasIndex(e => e.MissileTargetingKit, "MissileTargetingKit");

            entity.HasIndex(e => e.PersistentAreaKit, "PersistentAreaKit");

            entity.HasIndex(e => e.PrecastKit, "PrecastKit");

            entity.HasIndex(e => e.StateDoneKit, "StateDoneKit");

            entity.HasIndex(e => e.StateKit, "StateKit");

            entity.HasIndex(e => e.TargetImpactKit, "TargetImpactKit");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AnimEventSoundId).HasColumnName("AnimEventSoundID");

            entity.HasOne(d => d.AnimEventSound).WithMany(p => p.SpellvisualAnimEventSounds)
                .HasForeignKey(d => d.AnimEventSoundId)
                .HasConstraintName("spellvisual_ibfk_9");

            entity.HasOne(d => d.CastKitNavigation).WithMany(p => p.SpellvisualCastKitNavigations)
                .HasForeignKey(d => d.CastKit)
                .HasConstraintName("spellvisual_ibfk_2");

            entity.HasOne(d => d.CasterImpactKitNavigation).WithMany(p => p.SpellvisualCasterImpactKitNavigations)
                .HasForeignKey(d => d.CasterImpactKit)
                .HasConstraintName("spellvisual_ibfk_10");

            entity.HasOne(d => d.ChannelKitNavigation).WithMany(p => p.SpellvisualChannelKitNavigations)
                .HasForeignKey(d => d.ChannelKit)
                .HasConstraintName("spellvisual_ibfk_6");

            entity.HasOne(d => d.ImpactAreaKitNavigation).WithMany(p => p.SpellvisualImpactAreaKitNavigations)
                .HasForeignKey(d => d.ImpactAreaKit)
                .HasConstraintName("spellvisual_ibfk_14");

            entity.HasOne(d => d.ImpactKitNavigation).WithMany(p => p.SpellvisualImpactKitNavigations)
                .HasForeignKey(d => d.ImpactKit)
                .HasConstraintName("spellvisual_ibfk_3");

            entity.HasOne(d => d.InstantAreaKitNavigation).WithMany(p => p.SpellvisualInstantAreaKitNavigations)
                .HasForeignKey(d => d.InstantAreaKit)
                .HasConstraintName("spellvisual_ibfk_13");

            entity.HasOne(d => d.MissileModelNavigation).WithMany(p => p.Spellvisuals)
                .HasForeignKey(d => d.MissileModel)
                .HasConstraintName("spellvisual_ibfk_7");

            entity.HasOne(d => d.MissileSoundNavigation).WithMany(p => p.SpellvisualMissileSoundNavigations)
                .HasForeignKey(d => d.MissileSound)
                .HasConstraintName("spellvisual_ibfk_8");

            entity.HasOne(d => d.MissileTargetingKitNavigation).WithMany(p => p.SpellvisualMissileTargetingKitNavigations)
                .HasForeignKey(d => d.MissileTargetingKit)
                .HasConstraintName("spellvisual_ibfk_12");

            entity.HasOne(d => d.PersistentAreaKitNavigation).WithMany(p => p.SpellvisualPersistentAreaKitNavigations)
                .HasForeignKey(d => d.PersistentAreaKit)
                .HasConstraintName("spellvisual_ibfk_15");

            entity.HasOne(d => d.PrecastKitNavigation).WithMany(p => p.SpellvisualPrecastKitNavigations)
                .HasForeignKey(d => d.PrecastKit)
                .HasConstraintName("spellvisual_ibfk_1");

            entity.HasOne(d => d.StateDoneKitNavigation).WithMany(p => p.SpellvisualStateDoneKitNavigations)
                .HasForeignKey(d => d.StateDoneKit)
                .HasConstraintName("spellvisual_ibfk_5");

            entity.HasOne(d => d.StateKitNavigation).WithMany(p => p.SpellvisualStateKitNavigations)
                .HasForeignKey(d => d.StateKit)
                .HasConstraintName("spellvisual_ibfk_4");

            entity.HasOne(d => d.TargetImpactKitNavigation).WithMany(p => p.SpellvisualTargetImpactKitNavigations)
                .HasForeignKey(d => d.TargetImpactKit)
                .HasConstraintName("spellvisual_ibfk_11");
        });

        modelBuilder.Entity<Spellvisualeffectname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisualeffectname")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FileName).HasColumnType("text");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Spellvisualkit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisualkit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AnimId, "AnimID");

            entity.HasIndex(e => e.BaseEffect, "BaseEffect");

            entity.HasIndex(e => e.BreathEffect, "BreathEffect");

            entity.HasIndex(e => e.ChestEffect, "ChestEffect");

            entity.HasIndex(e => e.HeadEffect, "HeadEffect");

            entity.HasIndex(e => e.LeftHandEffect, "LeftHandEffect");

            entity.HasIndex(e => e.LeftWeaponEffect, "LeftWeaponEffect");

            entity.HasIndex(e => e.RightHandEffect, "RightHandEffect");

            entity.HasIndex(e => e.RightWeaponEffect, "RightWeaponEffect");

            entity.HasIndex(e => e.ShakeId, "ShakeID");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.HasIndex(e => e.SpecialEffect1, "SpecialEffect_1");

            entity.HasIndex(e => e.SpecialEffect2, "SpecialEffect_2");

            entity.HasIndex(e => e.SpecialEffect3, "SpecialEffect_3");

            entity.HasIndex(e => e.StartAnimId, "StartAnimID");

            entity.HasIndex(e => e.WorldEffect, "WorldEffect");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AnimId).HasColumnName("AnimID");
            entity.Property(e => e.CharParamOne1).HasColumnName("CharParamOne_1");
            entity.Property(e => e.CharParamOne2).HasColumnName("CharParamOne_2");
            entity.Property(e => e.CharParamOne3).HasColumnName("CharParamOne_3");
            entity.Property(e => e.CharParamOne4).HasColumnName("CharParamOne_4");
            entity.Property(e => e.CharParamThree1).HasColumnName("CharParamThree_1");
            entity.Property(e => e.CharParamThree2).HasColumnName("CharParamThree_2");
            entity.Property(e => e.CharParamThree3).HasColumnName("CharParamThree_3");
            entity.Property(e => e.CharParamThree4).HasColumnName("CharParamThree_4");
            entity.Property(e => e.CharParamTwo1).HasColumnName("CharParamTwo_1");
            entity.Property(e => e.CharParamTwo2).HasColumnName("CharParamTwo_2");
            entity.Property(e => e.CharParamTwo3).HasColumnName("CharParamTwo_3");
            entity.Property(e => e.CharParamTwo4).HasColumnName("CharParamTwo_4");
            entity.Property(e => e.CharParamZero1).HasColumnName("CharParamZero_1");
            entity.Property(e => e.CharParamZero2).HasColumnName("CharParamZero_2");
            entity.Property(e => e.CharParamZero3).HasColumnName("CharParamZero_3");
            entity.Property(e => e.CharParamZero4).HasColumnName("CharParamZero_4");
            entity.Property(e => e.CharProc1).HasColumnName("CharProc_1");
            entity.Property(e => e.CharProc2).HasColumnName("CharProc_2");
            entity.Property(e => e.CharProc3).HasColumnName("CharProc_3");
            entity.Property(e => e.CharProc4).HasColumnName("CharProc_4");
            entity.Property(e => e.ShakeId).HasColumnName("ShakeID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.SpecialEffect1).HasColumnName("SpecialEffect_1");
            entity.Property(e => e.SpecialEffect2).HasColumnName("SpecialEffect_2");
            entity.Property(e => e.SpecialEffect3).HasColumnName("SpecialEffect_3");
            entity.Property(e => e.StartAnimId).HasColumnName("StartAnimID");

            entity.HasOne(d => d.Anim).WithMany(p => p.SpellvisualkitAnims)
                .HasForeignKey(d => d.AnimId)
                .HasConstraintName("spellvisualkit_ibfk_2");

            entity.HasOne(d => d.BaseEffectNavigation).WithMany(p => p.SpellvisualkitBaseEffectNavigations)
                .HasForeignKey(d => d.BaseEffect)
                .HasConstraintName("spellvisualkit_ibfk_5");

            entity.HasOne(d => d.BreathEffectNavigation).WithMany(p => p.SpellvisualkitBreathEffectNavigations)
                .HasForeignKey(d => d.BreathEffect)
                .HasConstraintName("spellvisualkit_ibfk_8");

            entity.HasOne(d => d.ChestEffectNavigation).WithMany(p => p.SpellvisualkitChestEffectNavigations)
                .HasForeignKey(d => d.ChestEffect)
                .HasConstraintName("spellvisualkit_ibfk_4");

            entity.HasOne(d => d.HeadEffectNavigation).WithMany(p => p.SpellvisualkitHeadEffectNavigations)
                .HasForeignKey(d => d.HeadEffect)
                .HasConstraintName("spellvisualkit_ibfk_3");

            entity.HasOne(d => d.LeftHandEffectNavigation).WithMany(p => p.SpellvisualkitLeftHandEffectNavigations)
                .HasForeignKey(d => d.LeftHandEffect)
                .HasConstraintName("spellvisualkit_ibfk_6");

            entity.HasOne(d => d.LeftWeaponEffectNavigation).WithMany(p => p.SpellvisualkitLeftWeaponEffectNavigations)
                .HasForeignKey(d => d.LeftWeaponEffect)
                .HasConstraintName("spellvisualkit_ibfk_9");

            entity.HasOne(d => d.RightHandEffectNavigation).WithMany(p => p.SpellvisualkitRightHandEffectNavigations)
                .HasForeignKey(d => d.RightHandEffect)
                .HasConstraintName("spellvisualkit_ibfk_7");

            entity.HasOne(d => d.RightWeaponEffectNavigation).WithMany(p => p.SpellvisualkitRightWeaponEffectNavigations)
                .HasForeignKey(d => d.RightWeaponEffect)
                .HasConstraintName("spellvisualkit_ibfk_10");

            entity.HasOne(d => d.Shake).WithMany(p => p.Spellvisualkits)
                .HasForeignKey(d => d.ShakeId)
                .HasConstraintName("spellvisualkit_ibfk_16");

            entity.HasOne(d => d.Sound).WithMany(p => p.Spellvisualkits)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("spellvisualkit_ibfk_15");

            entity.HasOne(d => d.SpecialEffect1Navigation).WithMany(p => p.SpellvisualkitSpecialEffect1Navigations)
                .HasForeignKey(d => d.SpecialEffect1)
                .HasConstraintName("spellvisualkit_ibfk_11");

            entity.HasOne(d => d.SpecialEffect2Navigation).WithMany(p => p.SpellvisualkitSpecialEffect2Navigations)
                .HasForeignKey(d => d.SpecialEffect2)
                .HasConstraintName("spellvisualkit_ibfk_12");

            entity.HasOne(d => d.SpecialEffect3Navigation).WithMany(p => p.SpellvisualkitSpecialEffect3Navigations)
                .HasForeignKey(d => d.SpecialEffect3)
                .HasConstraintName("spellvisualkit_ibfk_13");

            entity.HasOne(d => d.StartAnim).WithMany(p => p.SpellvisualkitStartAnims)
                .HasForeignKey(d => d.StartAnimId)
                .HasConstraintName("spellvisualkit_ibfk_1");

            entity.HasOne(d => d.WorldEffectNavigation).WithMany(p => p.SpellvisualkitWorldEffectNavigations)
                .HasForeignKey(d => d.WorldEffect)
                .HasConstraintName("spellvisualkit_ibfk_14");
        });

        modelBuilder.Entity<Spellvisualkitareamodel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisualkitareamodel")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EnumId).HasColumnName("EnumID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Spellvisualkitmodelattach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisualkitmodelattach")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ParentSpellVisualKitId, "ParentSpellVisualKitID");

            entity.HasIndex(e => e.SpellVisualEffectNameId, "SpellVisualEffectNameID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.ParentSpellVisualKitId).HasColumnName("ParentSpellVisualKitID");
            entity.Property(e => e.SpellVisualEffectNameId).HasColumnName("SpellVisualEffectNameID");

            entity.HasOne(d => d.ParentSpellVisualKit).WithMany(p => p.Spellvisualkitmodelattaches)
                .HasForeignKey(d => d.ParentSpellVisualKitId)
                .HasConstraintName("spellvisualkitmodelattach_ibfk_1");

            entity.HasOne(d => d.SpellVisualEffectName).WithMany(p => p.Spellvisualkitmodelattaches)
                .HasForeignKey(d => d.SpellVisualEffectNameId)
                .HasConstraintName("spellvisualkitmodelattach_ibfk_2");
        });

        modelBuilder.Entity<Spellvisualprecasttransition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("spellvisualprecasttransitions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.HoldAnimation).HasColumnType("text");
            entity.Property(e => e.LoadAnimation).HasColumnType("text");
        });

        modelBuilder.Entity<Stableslotprice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stableslotprices")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<StartupString>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("startup_strings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MessageLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_deDE");
            entity.Property(e => e.MessageLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enCN");
            entity.Property(e => e.MessageLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enGB");
            entity.Property(e => e.MessageLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enTW");
            entity.Property(e => e.MessageLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_enUS");
            entity.Property(e => e.MessageLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_esES");
            entity.Property(e => e.MessageLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_esMX");
            entity.Property(e => e.MessageLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_frFR");
            entity.Property(e => e.MessageLangItIt)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_itIT");
            entity.Property(e => e.MessageLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_koKR");
            entity.Property(e => e.MessageLangMask).HasColumnName("Message_Lang_Mask");
            entity.Property(e => e.MessageLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ptBR");
            entity.Property(e => e.MessageLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ptPT");
            entity.Property(e => e.MessageLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_ruRU");
            entity.Property(e => e.MessageLangUnk)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_Unk");
            entity.Property(e => e.MessageLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_zhCN");
            entity.Property(e => e.MessageLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Message_Lang_zhTW");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Stationery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stationery")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ItemId, "ItemID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Texture).HasColumnType("text");

            entity.HasOne(d => d.Item).WithMany(p => p.Stationeries)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("stationery_ibfk_1");
        });

        modelBuilder.Entity<Stringlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stringlookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.String).HasColumnType("text");
        });

        modelBuilder.Entity<Summonproperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("summonproperties")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Talent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("talent")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.RequiredSpellId, "RequiredSpellID");

            entity.HasIndex(e => e.SpellRank1, "SpellRank_1");

            entity.HasIndex(e => e.SpellRank2, "SpellRank_2");

            entity.HasIndex(e => e.SpellRank3, "SpellRank_3");

            entity.HasIndex(e => e.SpellRank4, "SpellRank_4");

            entity.HasIndex(e => e.SpellRank5, "SpellRank_5");

            entity.HasIndex(e => e.SpellRank6, "SpellRank_6");

            entity.HasIndex(e => e.SpellRank7, "SpellRank_7");

            entity.HasIndex(e => e.SpellRank8, "SpellRank_8");

            entity.HasIndex(e => e.SpellRank9, "SpellRank_9");

            entity.HasIndex(e => e.TabId, "TabID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryMask1).HasColumnName("CategoryMask_1");
            entity.Property(e => e.CategoryMask2).HasColumnName("CategoryMask_2");
            entity.Property(e => e.PrereqRank1).HasColumnName("PrereqRank_1");
            entity.Property(e => e.PrereqRank2).HasColumnName("PrereqRank_2");
            entity.Property(e => e.PrereqRank3).HasColumnName("PrereqRank_3");
            entity.Property(e => e.PrereqTalent1).HasColumnName("PrereqTalent_1");
            entity.Property(e => e.PrereqTalent2).HasColumnName("PrereqTalent_2");
            entity.Property(e => e.PrereqTalent3).HasColumnName("PrereqTalent_3");
            entity.Property(e => e.RequiredSpellId).HasColumnName("RequiredSpellID");
            entity.Property(e => e.SpellRank1).HasColumnName("SpellRank_1");
            entity.Property(e => e.SpellRank2).HasColumnName("SpellRank_2");
            entity.Property(e => e.SpellRank3).HasColumnName("SpellRank_3");
            entity.Property(e => e.SpellRank4).HasColumnName("SpellRank_4");
            entity.Property(e => e.SpellRank5).HasColumnName("SpellRank_5");
            entity.Property(e => e.SpellRank6).HasColumnName("SpellRank_6");
            entity.Property(e => e.SpellRank7).HasColumnName("SpellRank_7");
            entity.Property(e => e.SpellRank8).HasColumnName("SpellRank_8");
            entity.Property(e => e.SpellRank9).HasColumnName("SpellRank_9");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TierId).HasColumnName("TierID");

            entity.HasOne(d => d.RequiredSpell).WithMany(p => p.TalentRequiredSpells)
                .HasForeignKey(d => d.RequiredSpellId)
                .HasConstraintName("talent_ibfk_11");

            entity.HasOne(d => d.SpellRank1Navigation).WithMany(p => p.TalentSpellRank1Navigations)
                .HasForeignKey(d => d.SpellRank1)
                .HasConstraintName("talent_ibfk_2");

            entity.HasOne(d => d.SpellRank2Navigation).WithMany(p => p.TalentSpellRank2Navigations)
                .HasForeignKey(d => d.SpellRank2)
                .HasConstraintName("talent_ibfk_3");

            entity.HasOne(d => d.SpellRank3Navigation).WithMany(p => p.TalentSpellRank3Navigations)
                .HasForeignKey(d => d.SpellRank3)
                .HasConstraintName("talent_ibfk_4");

            entity.HasOne(d => d.SpellRank4Navigation).WithMany(p => p.TalentSpellRank4Navigations)
                .HasForeignKey(d => d.SpellRank4)
                .HasConstraintName("talent_ibfk_5");

            entity.HasOne(d => d.SpellRank5Navigation).WithMany(p => p.TalentSpellRank5Navigations)
                .HasForeignKey(d => d.SpellRank5)
                .HasConstraintName("talent_ibfk_6");

            entity.HasOne(d => d.SpellRank6Navigation).WithMany(p => p.TalentSpellRank6Navigations)
                .HasForeignKey(d => d.SpellRank6)
                .HasConstraintName("talent_ibfk_7");

            entity.HasOne(d => d.SpellRank7Navigation).WithMany(p => p.TalentSpellRank7Navigations)
                .HasForeignKey(d => d.SpellRank7)
                .HasConstraintName("talent_ibfk_8");

            entity.HasOne(d => d.SpellRank8Navigation).WithMany(p => p.TalentSpellRank8Navigations)
                .HasForeignKey(d => d.SpellRank8)
                .HasConstraintName("talent_ibfk_9");

            entity.HasOne(d => d.SpellRank9Navigation).WithMany(p => p.TalentSpellRank9Navigations)
                .HasForeignKey(d => d.SpellRank9)
                .HasConstraintName("talent_ibfk_10");

            entity.HasOne(d => d.Tab).WithMany(p => p.Talents)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("talent_ibfk_1");
        });

        modelBuilder.Entity<Talenttab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("talenttab")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SpellIconId, "SpellIconID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BackgroundFile).HasColumnType("text");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");

            entity.HasOne(d => d.SpellIcon).WithMany(p => p.Talenttabs)
                .HasForeignKey(d => d.SpellIconId)
                .HasConstraintName("talenttab_ibfk_1");
        });

        modelBuilder.Entity<Taxinode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("taxinodes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ContinentId, "ContinentID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.MountCreatureId1).HasColumnName("MountCreatureID_1");
            entity.Property(e => e.MountCreatureId2).HasColumnName("MountCreatureID_2");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");

            entity.HasOne(d => d.Continent).WithMany(p => p.Taxinodes)
                .HasForeignKey(d => d.ContinentId)
                .HasConstraintName("taxinodes_ibfk_1");
        });

        modelBuilder.Entity<Taxipath>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("taxipath")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FromTaxiNode, "FromTaxiNode");

            entity.HasIndex(e => e.ToTaxiNode, "ToTaxiNode");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.HasOne(d => d.FromTaxiNodeNavigation).WithMany(p => p.TaxipathFromTaxiNodeNavigations)
                .HasForeignKey(d => d.FromTaxiNode)
                .HasConstraintName("taxipath_ibfk_1");

            entity.HasOne(d => d.ToTaxiNodeNavigation).WithMany(p => p.TaxipathToTaxiNodeNavigations)
                .HasForeignKey(d => d.ToTaxiNode)
                .HasConstraintName("taxipath_ibfk_2");
        });

        modelBuilder.Entity<Taxipathnode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("taxipathnode")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ContinentId, "ContinentID");

            entity.HasIndex(e => e.PathId, "PathID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArrivalEventId).HasColumnName("ArrivalEventID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.DepartureEventId).HasColumnName("DepartureEventID");
            entity.Property(e => e.PathId).HasColumnName("PathID");

            entity.HasOne(d => d.Continent).WithMany(p => p.Taxipathnodes)
                .HasForeignKey(d => d.ContinentId)
                .HasConstraintName("taxipathnode_ibfk_2");

            entity.HasOne(d => d.Path).WithMany(p => p.Taxipathnodes)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("taxipathnode_ibfk_1");
        });

        modelBuilder.Entity<Teamcontributionpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("teamcontributionpoints")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Terraintype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("terraintype")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FootstepSprayRun, "FootstepSprayRun");

            entity.HasIndex(e => e.FootstepSprayWalk, "FootstepSprayWalk");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.TerrainDesc).HasColumnType("text");
            entity.Property(e => e.TerrainId).HasColumnName("TerrainID");

            entity.HasOne(d => d.FootstepSprayRunNavigation).WithMany(p => p.TerraintypeFootstepSprayRunNavigations)
                .HasForeignKey(d => d.FootstepSprayRun)
                .HasConstraintName("terraintype_ibfk_1");

            entity.HasOne(d => d.FootstepSprayWalkNavigation).WithMany(p => p.TerraintypeFootstepSprayWalkNavigations)
                .HasForeignKey(d => d.FootstepSprayWalk)
                .HasConstraintName("terraintype_ibfk_2");

            entity.HasOne(d => d.Sound).WithMany(p => p.Terraintypes)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("terraintype_ibfk_3");
        });

        modelBuilder.Entity<Terraintypesound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("terraintypesounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Totemcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("totemcategory")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Transportanimation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("transportanimation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SequenceId, "SequenceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SequenceId).HasColumnName("SequenceID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");

            entity.HasOne(d => d.Sequence).WithMany(p => p.Transportanimations)
                .HasForeignKey(d => d.SequenceId)
                .HasConstraintName("transportanimation_ibfk_1");
        });

        modelBuilder.Entity<Transportphysic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("transportphysics")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Transportrotation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("transportrotation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.GameObjectsId).HasColumnName("GameObjectsID");
        });

        modelBuilder.Entity<Uisoundlookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("uisoundlookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Sound).WithMany(p => p.Uisoundlookups)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("uisoundlookups_ibfk_1");
        });

        modelBuilder.Entity<Unitblood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("unitblood")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CombatBloodSpurtBack1).HasColumnName("CombatBloodSpurtBack_1");
            entity.Property(e => e.CombatBloodSpurtBack2).HasColumnName("CombatBloodSpurtBack_2");
            entity.Property(e => e.CombatBloodSpurtFront1).HasColumnName("CombatBloodSpurtFront_1");
            entity.Property(e => e.CombatBloodSpurtFront2).HasColumnName("CombatBloodSpurtFront_2");
            entity.Property(e => e.GroundBlood1)
                .HasColumnType("text")
                .HasColumnName("GroundBlood_1");
            entity.Property(e => e.GroundBlood2)
                .HasColumnType("text")
                .HasColumnName("GroundBlood_2");
            entity.Property(e => e.GroundBlood3)
                .HasColumnType("text")
                .HasColumnName("GroundBlood_3");
            entity.Property(e => e.GroundBlood4)
                .HasColumnType("text")
                .HasColumnName("GroundBlood_4");
            entity.Property(e => e.GroundBlood5)
                .HasColumnType("text")
                .HasColumnName("GroundBlood_5");
        });

        modelBuilder.Entity<Unitbloodlevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("unitbloodlevels")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Violencelevel1).HasColumnName("Violencelevel_1");
            entity.Property(e => e.Violencelevel2).HasColumnName("Violencelevel_2");
            entity.Property(e => e.Violencelevel3).HasColumnName("Violencelevel_3");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vehicle")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PowerDisplayId1, "PowerDisplayID_1");

            entity.HasIndex(e => e.PowerDisplayId2, "PowerDisplayID_2");

            entity.HasIndex(e => e.PowerDisplayId3, "PowerDisplayID_3");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MsslTrgtArcTexture).HasColumnType("text");
            entity.Property(e => e.MsslTrgtImpactModel1)
                .HasColumnType("text")
                .HasColumnName("MsslTrgtImpactModel_1");
            entity.Property(e => e.MsslTrgtImpactModel2)
                .HasColumnType("text")
                .HasColumnName("MsslTrgtImpactModel_2");
            entity.Property(e => e.MsslTrgtImpactRadius1).HasColumnName("MsslTrgtImpactRadius_1");
            entity.Property(e => e.MsslTrgtImpactRadius2).HasColumnName("MsslTrgtImpactRadius_2");
            entity.Property(e => e.MsslTrgtImpactTexture).HasColumnType("text");
            entity.Property(e => e.PowerDisplayId1).HasColumnName("PowerDisplayID_1");
            entity.Property(e => e.PowerDisplayId2).HasColumnName("PowerDisplayID_2");
            entity.Property(e => e.PowerDisplayId3).HasColumnName("PowerDisplayID_3");
            entity.Property(e => e.SeatId1).HasColumnName("SeatID_1");
            entity.Property(e => e.SeatId2).HasColumnName("SeatID_2");
            entity.Property(e => e.SeatId3).HasColumnName("SeatID_3");
            entity.Property(e => e.SeatId4).HasColumnName("SeatID_4");
            entity.Property(e => e.SeatId5).HasColumnName("SeatID_5");
            entity.Property(e => e.SeatId6).HasColumnName("SeatID_6");
            entity.Property(e => e.SeatId7).HasColumnName("SeatID_7");
            entity.Property(e => e.SeatId8).HasColumnName("SeatID_8");
            entity.Property(e => e.VehicleUiindicatorId).HasColumnName("VehicleUIIndicatorID");

            entity.HasOne(d => d.PowerDisplayId1Navigation).WithMany(p => p.VehiclePowerDisplayId1Navigations)
                .HasForeignKey(d => d.PowerDisplayId1)
                .HasConstraintName("vehicle_ibfk_1");

            entity.HasOne(d => d.PowerDisplayId2Navigation).WithMany(p => p.VehiclePowerDisplayId2Navigations)
                .HasForeignKey(d => d.PowerDisplayId2)
                .HasConstraintName("vehicle_ibfk_2");

            entity.HasOne(d => d.PowerDisplayId3Navigation).WithMany(p => p.VehiclePowerDisplayId3Navigations)
                .HasForeignKey(d => d.PowerDisplayId3)
                .HasConstraintName("vehicle_ibfk_3");
        });

        modelBuilder.Entity<Vehicleseat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vehicleseat")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.EnterUisoundId).HasColumnName("EnterUISoundID");
            entity.Property(e => e.ExitUisoundId).HasColumnName("ExitUISoundID");
            entity.Property(e => e.PassengerAttachmentId).HasColumnName("PassengerAttachmentID");
        });

        modelBuilder.Entity<Vehicleuiindicator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vehicleuiindicator")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BackgroundTexture).HasColumnType("text");
        });

        modelBuilder.Entity<Vehicleuiindseat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vehicleuiindseat")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.VehicleUiindicatorId, "VehicleUIIndicatorID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.VehicleUiindicatorId).HasColumnName("VehicleUIIndicatorID");
            entity.Property(e => e.Xpos).HasColumnName("XPos");
            entity.Property(e => e.Ypos).HasColumnName("YPos");

            entity.HasOne(d => d.VehicleUiindicator).WithMany(p => p.Vehicleuiindseats)
                .HasForeignKey(d => d.VehicleUiindicatorId)
                .HasConstraintName("vehicleuiindseat_ibfk_1");
        });

        modelBuilder.Entity<Videohardware>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("videohardware")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.D3dOverrides).HasColumnType("text");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.OglOverrides).HasColumnType("text");
            entity.Property(e => e.TerrainLoddistIdx).HasColumnName("TerrainLODDistIdx");
            entity.Property(e => e.TerrainShadowLod).HasColumnName("TerrainShadowLOD");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.WaterLodidx).HasColumnName("WaterLODIdx");
        });

        modelBuilder.Entity<Vocaluisound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vocaluisounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NormalSoundId1, "NormalSoundID_1");

            entity.HasIndex(e => e.NormalSoundId2, "NormalSoundID_2");

            entity.HasIndex(e => e.PissedSoundId1, "PissedSoundID_1");

            entity.HasIndex(e => e.PissedSoundId2, "PissedSoundID_2");

            entity.HasIndex(e => e.RaceId, "RaceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.NormalSoundId1).HasColumnName("NormalSoundID_1");
            entity.Property(e => e.NormalSoundId2).HasColumnName("NormalSoundID_2");
            entity.Property(e => e.PissedSoundId1).HasColumnName("PissedSoundID_1");
            entity.Property(e => e.PissedSoundId2).HasColumnName("PissedSoundID_2");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.VocalUienum).HasColumnName("VocalUIEnum");

            entity.HasOne(d => d.NormalSoundId1Navigation).WithMany(p => p.VocaluisoundNormalSoundId1Navigations)
                .HasForeignKey(d => d.NormalSoundId1)
                .HasConstraintName("vocaluisounds_ibfk_2");

            entity.HasOne(d => d.NormalSoundId2Navigation).WithMany(p => p.VocaluisoundNormalSoundId2Navigations)
                .HasForeignKey(d => d.NormalSoundId2)
                .HasConstraintName("vocaluisounds_ibfk_3");

            entity.HasOne(d => d.PissedSoundId1Navigation).WithMany(p => p.VocaluisoundPissedSoundId1Navigations)
                .HasForeignKey(d => d.PissedSoundId1)
                .HasConstraintName("vocaluisounds_ibfk_4");

            entity.HasOne(d => d.PissedSoundId2Navigation).WithMany(p => p.VocaluisoundPissedSoundId2Navigations)
                .HasForeignKey(d => d.PissedSoundId2)
                .HasConstraintName("vocaluisounds_ibfk_5");

            entity.HasOne(d => d.Race).WithMany(p => p.Vocaluisounds)
                .HasForeignKey(d => d.RaceId)
                .HasConstraintName("vocaluisounds_ibfk_1");
        });

        modelBuilder.Entity<Weaponimpactsound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("weaponimpactsounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CritImpactSoundId1, "CritImpactSoundID_1");

            entity.HasIndex(e => e.CritImpactSoundId10, "CritImpactSoundID_10");

            entity.HasIndex(e => e.CritImpactSoundId2, "CritImpactSoundID_2");

            entity.HasIndex(e => e.CritImpactSoundId3, "CritImpactSoundID_3");

            entity.HasIndex(e => e.CritImpactSoundId4, "CritImpactSoundID_4");

            entity.HasIndex(e => e.CritImpactSoundId5, "CritImpactSoundID_5");

            entity.HasIndex(e => e.CritImpactSoundId6, "CritImpactSoundID_6");

            entity.HasIndex(e => e.CritImpactSoundId7, "CritImpactSoundID_7");

            entity.HasIndex(e => e.CritImpactSoundId8, "CritImpactSoundID_8");

            entity.HasIndex(e => e.CritImpactSoundId9, "CritImpactSoundID_9");

            entity.HasIndex(e => e.ImpactSoundId1, "ImpactSoundID_1");

            entity.HasIndex(e => e.ImpactSoundId10, "ImpactSoundID_10");

            entity.HasIndex(e => e.ImpactSoundId2, "ImpactSoundID_2");

            entity.HasIndex(e => e.ImpactSoundId3, "ImpactSoundID_3");

            entity.HasIndex(e => e.ImpactSoundId4, "ImpactSoundID_4");

            entity.HasIndex(e => e.ImpactSoundId5, "ImpactSoundID_5");

            entity.HasIndex(e => e.ImpactSoundId6, "ImpactSoundID_6");

            entity.HasIndex(e => e.ImpactSoundId7, "ImpactSoundID_7");

            entity.HasIndex(e => e.ImpactSoundId8, "ImpactSoundID_8");

            entity.HasIndex(e => e.ImpactSoundId9, "ImpactSoundID_9");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CritImpactSoundId1).HasColumnName("CritImpactSoundID_1");
            entity.Property(e => e.CritImpactSoundId10).HasColumnName("CritImpactSoundID_10");
            entity.Property(e => e.CritImpactSoundId2).HasColumnName("CritImpactSoundID_2");
            entity.Property(e => e.CritImpactSoundId3).HasColumnName("CritImpactSoundID_3");
            entity.Property(e => e.CritImpactSoundId4).HasColumnName("CritImpactSoundID_4");
            entity.Property(e => e.CritImpactSoundId5).HasColumnName("CritImpactSoundID_5");
            entity.Property(e => e.CritImpactSoundId6).HasColumnName("CritImpactSoundID_6");
            entity.Property(e => e.CritImpactSoundId7).HasColumnName("CritImpactSoundID_7");
            entity.Property(e => e.CritImpactSoundId8).HasColumnName("CritImpactSoundID_8");
            entity.Property(e => e.CritImpactSoundId9).HasColumnName("CritImpactSoundID_9");
            entity.Property(e => e.ImpactSoundId1).HasColumnName("ImpactSoundID_1");
            entity.Property(e => e.ImpactSoundId10).HasColumnName("ImpactSoundID_10");
            entity.Property(e => e.ImpactSoundId2).HasColumnName("ImpactSoundID_2");
            entity.Property(e => e.ImpactSoundId3).HasColumnName("ImpactSoundID_3");
            entity.Property(e => e.ImpactSoundId4).HasColumnName("ImpactSoundID_4");
            entity.Property(e => e.ImpactSoundId5).HasColumnName("ImpactSoundID_5");
            entity.Property(e => e.ImpactSoundId6).HasColumnName("ImpactSoundID_6");
            entity.Property(e => e.ImpactSoundId7).HasColumnName("ImpactSoundID_7");
            entity.Property(e => e.ImpactSoundId8).HasColumnName("ImpactSoundID_8");
            entity.Property(e => e.ImpactSoundId9).HasColumnName("ImpactSoundID_9");
            entity.Property(e => e.WeaponSubClassId).HasColumnName("WeaponSubClassID");

            entity.HasOne(d => d.CritImpactSoundId1Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId1Navigations)
                .HasForeignKey(d => d.CritImpactSoundId1)
                .HasConstraintName("weaponimpactsounds_ibfk_11");

            entity.HasOne(d => d.CritImpactSoundId10Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId10Navigations)
                .HasForeignKey(d => d.CritImpactSoundId10)
                .HasConstraintName("weaponimpactsounds_ibfk_20");

            entity.HasOne(d => d.CritImpactSoundId2Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId2Navigations)
                .HasForeignKey(d => d.CritImpactSoundId2)
                .HasConstraintName("weaponimpactsounds_ibfk_12");

            entity.HasOne(d => d.CritImpactSoundId3Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId3Navigations)
                .HasForeignKey(d => d.CritImpactSoundId3)
                .HasConstraintName("weaponimpactsounds_ibfk_13");

            entity.HasOne(d => d.CritImpactSoundId4Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId4Navigations)
                .HasForeignKey(d => d.CritImpactSoundId4)
                .HasConstraintName("weaponimpactsounds_ibfk_14");

            entity.HasOne(d => d.CritImpactSoundId5Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId5Navigations)
                .HasForeignKey(d => d.CritImpactSoundId5)
                .HasConstraintName("weaponimpactsounds_ibfk_15");

            entity.HasOne(d => d.CritImpactSoundId6Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId6Navigations)
                .HasForeignKey(d => d.CritImpactSoundId6)
                .HasConstraintName("weaponimpactsounds_ibfk_16");

            entity.HasOne(d => d.CritImpactSoundId7Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId7Navigations)
                .HasForeignKey(d => d.CritImpactSoundId7)
                .HasConstraintName("weaponimpactsounds_ibfk_17");

            entity.HasOne(d => d.CritImpactSoundId8Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId8Navigations)
                .HasForeignKey(d => d.CritImpactSoundId8)
                .HasConstraintName("weaponimpactsounds_ibfk_18");

            entity.HasOne(d => d.CritImpactSoundId9Navigation).WithMany(p => p.WeaponimpactsoundCritImpactSoundId9Navigations)
                .HasForeignKey(d => d.CritImpactSoundId9)
                .HasConstraintName("weaponimpactsounds_ibfk_19");

            entity.HasOne(d => d.ImpactSoundId1Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId1Navigations)
                .HasForeignKey(d => d.ImpactSoundId1)
                .HasConstraintName("weaponimpactsounds_ibfk_1");

            entity.HasOne(d => d.ImpactSoundId10Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId10Navigations)
                .HasForeignKey(d => d.ImpactSoundId10)
                .HasConstraintName("weaponimpactsounds_ibfk_10");

            entity.HasOne(d => d.ImpactSoundId2Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId2Navigations)
                .HasForeignKey(d => d.ImpactSoundId2)
                .HasConstraintName("weaponimpactsounds_ibfk_2");

            entity.HasOne(d => d.ImpactSoundId3Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId3Navigations)
                .HasForeignKey(d => d.ImpactSoundId3)
                .HasConstraintName("weaponimpactsounds_ibfk_3");

            entity.HasOne(d => d.ImpactSoundId4Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId4Navigations)
                .HasForeignKey(d => d.ImpactSoundId4)
                .HasConstraintName("weaponimpactsounds_ibfk_4");

            entity.HasOne(d => d.ImpactSoundId5Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId5Navigations)
                .HasForeignKey(d => d.ImpactSoundId5)
                .HasConstraintName("weaponimpactsounds_ibfk_5");

            entity.HasOne(d => d.ImpactSoundId6Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId6Navigations)
                .HasForeignKey(d => d.ImpactSoundId6)
                .HasConstraintName("weaponimpactsounds_ibfk_6");

            entity.HasOne(d => d.ImpactSoundId7Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId7Navigations)
                .HasForeignKey(d => d.ImpactSoundId7)
                .HasConstraintName("weaponimpactsounds_ibfk_7");

            entity.HasOne(d => d.ImpactSoundId8Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId8Navigations)
                .HasForeignKey(d => d.ImpactSoundId8)
                .HasConstraintName("weaponimpactsounds_ibfk_8");

            entity.HasOne(d => d.ImpactSoundId9Navigation).WithMany(p => p.WeaponimpactsoundImpactSoundId9Navigations)
                .HasForeignKey(d => d.ImpactSoundId9)
                .HasConstraintName("weaponimpactsounds_ibfk_9");
        });

        modelBuilder.Entity<Weaponswingsounds2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("weaponswingsounds2")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Sound).WithMany(p => p.Weaponswingsounds2s)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("weaponswingsounds2_ibfk_1");
        });

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("weather")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AmbienceId, "AmbienceID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AmbienceId).HasColumnName("AmbienceID");
            entity.Property(e => e.EffectColor1).HasColumnName("EffectColor_1");
            entity.Property(e => e.EffectColor2).HasColumnName("EffectColor_2");
            entity.Property(e => e.EffectColor3).HasColumnName("EffectColor_3");
            entity.Property(e => e.EffectTexture).HasColumnType("text");

            entity.HasOne(d => d.Ambience).WithMany(p => p.Weathers)
                .HasForeignKey(d => d.AmbienceId)
                .HasConstraintName("weather_ibfk_1");
        });

        modelBuilder.Entity<Wmoareatable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("wmoareatable")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AmbienceId, "AmbienceID");

            entity.HasIndex(e => e.AreaTableId, "AreaTableID");

            entity.HasIndex(e => e.IntroSound, "IntroSound");

            entity.HasIndex(e => e.SoundProviderPref, "SoundProviderPref");

            entity.HasIndex(e => e.SoundProviderPrefUnderwater, "SoundProviderPrefUnderwater");

            entity.HasIndex(e => e.WmogroupId, "WMOGroupID");

            entity.HasIndex(e => e.ZoneMusic, "ZoneMusic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AmbienceId).HasColumnName("AmbienceID");
            entity.Property(e => e.AreaNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_deDE");
            entity.Property(e => e.AreaNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enCN");
            entity.Property(e => e.AreaNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enGB");
            entity.Property(e => e.AreaNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enTW");
            entity.Property(e => e.AreaNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enUS");
            entity.Property(e => e.AreaNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esES");
            entity.Property(e => e.AreaNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esMX");
            entity.Property(e => e.AreaNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_frFR");
            entity.Property(e => e.AreaNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_itIT");
            entity.Property(e => e.AreaNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_koKR");
            entity.Property(e => e.AreaNameLangMask).HasColumnName("AreaName_Lang_Mask");
            entity.Property(e => e.AreaNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptBR");
            entity.Property(e => e.AreaNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptPT");
            entity.Property(e => e.AreaNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ruRU");
            entity.Property(e => e.AreaNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_Unk");
            entity.Property(e => e.AreaNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhCN");
            entity.Property(e => e.AreaNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhTW");
            entity.Property(e => e.AreaTableId).HasColumnName("AreaTableID");
            entity.Property(e => e.NameSetId).HasColumnName("NameSetID");
            entity.Property(e => e.WmogroupId).HasColumnName("WMOGroupID");
            entity.Property(e => e.Wmoid).HasColumnName("WMOID");

            entity.HasOne(d => d.Ambience).WithMany(p => p.Wmoareatables)
                .HasForeignKey(d => d.AmbienceId)
                .HasConstraintName("wmoareatable_ibfk_3");

            entity.HasOne(d => d.AreaTable).WithMany(p => p.Wmoareatables)
                .HasForeignKey(d => d.AreaTableId)
                .HasConstraintName("wmoareatable_ibfk_5");

            entity.HasOne(d => d.IntroSoundNavigation).WithMany(p => p.Wmoareatables)
                .HasForeignKey(d => d.IntroSound)
                .HasConstraintName("wmoareatable_ibfk_6");

            entity.HasOne(d => d.SoundProviderPrefNavigation).WithMany(p => p.WmoareatableSoundProviderPrefNavigations)
                .HasForeignKey(d => d.SoundProviderPref)
                .HasConstraintName("wmoareatable_ibfk_1");

            entity.HasOne(d => d.SoundProviderPrefUnderwaterNavigation).WithMany(p => p.WmoareatableSoundProviderPrefUnderwaterNavigations)
                .HasForeignKey(d => d.SoundProviderPrefUnderwater)
                .HasConstraintName("wmoareatable_ibfk_2");

            entity.HasOne(d => d.ZoneMusicNavigation).WithMany(p => p.Wmoareatables)
                .HasForeignKey(d => d.ZoneMusic)
                .HasConstraintName("wmoareatable_ibfk_4");
        });

        modelBuilder.Entity<Worldmaparea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldmaparea")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId, "AreaID");

            entity.HasIndex(e => e.DefaultDungeonFloor, "DefaultDungeonFloor");

            entity.HasIndex(e => e.DisplayMapId, "DisplayMapID");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.HasIndex(e => e.ParentWorldMapId, "ParentWorldMapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AreaName).HasColumnType("text");
            entity.Property(e => e.DisplayMapId).HasColumnName("DisplayMapID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.ParentWorldMapId).HasColumnName("ParentWorldMapID");

            entity.HasOne(d => d.Area).WithMany(p => p.Worldmapareas)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("worldmaparea_ibfk_2");

            entity.HasOne(d => d.DefaultDungeonFloorNavigation).WithMany(p => p.Worldmapareas)
                .HasForeignKey(d => d.DefaultDungeonFloor)
                .HasConstraintName("worldmaparea_ibfk_4");

            entity.HasOne(d => d.DisplayMap).WithMany(p => p.WorldmapareaDisplayMaps)
                .HasForeignKey(d => d.DisplayMapId)
                .HasConstraintName("worldmaparea_ibfk_3");

            entity.HasOne(d => d.Map).WithMany(p => p.WorldmapareaMaps)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("worldmaparea_ibfk_1");

            entity.HasOne(d => d.ParentWorldMap).WithMany(p => p.InverseParentWorldMap)
                .HasForeignKey(d => d.ParentWorldMapId)
                .HasConstraintName("worldmaparea_ibfk_5");
        });

        modelBuilder.Entity<Worldmapcontinent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldmapcontinent")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.WorldMapId).HasColumnName("WorldMapID");

            entity.HasOne(d => d.Map).WithMany(p => p.Worldmapcontinents)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("worldmapcontinent_ibfk_1");
        });

        modelBuilder.Entity<Worldmapoverlay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldmapoverlay")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId1, "AreaID_1");

            entity.HasIndex(e => e.AreaId2, "AreaID_2");

            entity.HasIndex(e => e.AreaId3, "AreaID_3");

            entity.HasIndex(e => e.AreaId4, "AreaID_4");

            entity.HasIndex(e => e.MapAreaId, "MapAreaID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId1).HasColumnName("AreaID_1");
            entity.Property(e => e.AreaId2).HasColumnName("AreaID_2");
            entity.Property(e => e.AreaId3).HasColumnName("AreaID_3");
            entity.Property(e => e.AreaId4).HasColumnName("AreaID_4");
            entity.Property(e => e.MapAreaId).HasColumnName("MapAreaID");
            entity.Property(e => e.TextureName).HasColumnType("text");

            entity.HasOne(d => d.AreaId1Navigation).WithMany(p => p.WorldmapoverlayAreaId1Navigations)
                .HasForeignKey(d => d.AreaId1)
                .HasConstraintName("worldmapoverlay_ibfk_2");

            entity.HasOne(d => d.AreaId2Navigation).WithMany(p => p.WorldmapoverlayAreaId2Navigations)
                .HasForeignKey(d => d.AreaId2)
                .HasConstraintName("worldmapoverlay_ibfk_3");

            entity.HasOne(d => d.AreaId3Navigation).WithMany(p => p.WorldmapoverlayAreaId3Navigations)
                .HasForeignKey(d => d.AreaId3)
                .HasConstraintName("worldmapoverlay_ibfk_4");

            entity.HasOne(d => d.AreaId4Navigation).WithMany(p => p.WorldmapoverlayAreaId4Navigations)
                .HasForeignKey(d => d.AreaId4)
                .HasConstraintName("worldmapoverlay_ibfk_5");

            entity.HasOne(d => d.MapArea).WithMany(p => p.Worldmapoverlays)
                .HasForeignKey(d => d.MapAreaId)
                .HasConstraintName("worldmapoverlay_ibfk_1");
        });

        modelBuilder.Entity<Worldmaptransform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldmaptransforms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.HasIndex(e => e.NewDungeonMapId, "NewDungeonMapID");

            entity.HasIndex(e => e.NewMapId, "NewMapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.NewDungeonMapId).HasColumnName("NewDungeonMapID");
            entity.Property(e => e.NewMapId).HasColumnName("NewMapID");

            entity.HasOne(d => d.Map).WithMany(p => p.WorldmaptransformMaps)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("worldmaptransforms_ibfk_1");

            entity.HasOne(d => d.NewDungeonMap).WithMany(p => p.Worldmaptransforms)
                .HasForeignKey(d => d.NewDungeonMapId)
                .HasConstraintName("worldmaptransforms_ibfk_3");

            entity.HasOne(d => d.NewMap).WithMany(p => p.WorldmaptransformNewMaps)
                .HasForeignKey(d => d.NewMapId)
                .HasConstraintName("worldmaptransforms_ibfk_2");
        });

        modelBuilder.Entity<Worldsafeloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldsafelocs")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Continent, "Continent");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_deDE");
            entity.Property(e => e.AreaNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enCN");
            entity.Property(e => e.AreaNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enGB");
            entity.Property(e => e.AreaNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enTW");
            entity.Property(e => e.AreaNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_enUS");
            entity.Property(e => e.AreaNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esES");
            entity.Property(e => e.AreaNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_esMX");
            entity.Property(e => e.AreaNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_frFR");
            entity.Property(e => e.AreaNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_itIT");
            entity.Property(e => e.AreaNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_koKR");
            entity.Property(e => e.AreaNameLangMask).HasColumnName("AreaName_Lang_Mask");
            entity.Property(e => e.AreaNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptBR");
            entity.Property(e => e.AreaNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ptPT");
            entity.Property(e => e.AreaNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_ruRU");
            entity.Property(e => e.AreaNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_Unk");
            entity.Property(e => e.AreaNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhCN");
            entity.Property(e => e.AreaNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("AreaName_Lang_zhTW");

            entity.HasOne(d => d.ContinentNavigation).WithMany(p => p.Worldsafelocs)
                .HasForeignKey(d => d.Continent)
                .HasConstraintName("worldsafelocs_ibfk_1");
        });

        modelBuilder.Entity<Worldstateui>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldstateui")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId, "AreaID");

            entity.HasIndex(e => e.MapId, "MapID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.DynamicIcon).HasColumnType("text");
            entity.Property(e => e.DynamicTooltipLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_deDE");
            entity.Property(e => e.DynamicTooltipLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_enCN");
            entity.Property(e => e.DynamicTooltipLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_enGB");
            entity.Property(e => e.DynamicTooltipLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_enTW");
            entity.Property(e => e.DynamicTooltipLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_enUS");
            entity.Property(e => e.DynamicTooltipLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_esES");
            entity.Property(e => e.DynamicTooltipLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_esMX");
            entity.Property(e => e.DynamicTooltipLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_frFR");
            entity.Property(e => e.DynamicTooltipLangItIt)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_itIT");
            entity.Property(e => e.DynamicTooltipLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_koKR");
            entity.Property(e => e.DynamicTooltipLangMask).HasColumnName("DynamicTooltip_Lang_Mask");
            entity.Property(e => e.DynamicTooltipLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_ptBR");
            entity.Property(e => e.DynamicTooltipLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_ptPT");
            entity.Property(e => e.DynamicTooltipLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_ruRU");
            entity.Property(e => e.DynamicTooltipLangUnk)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_Unk");
            entity.Property(e => e.DynamicTooltipLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_zhCN");
            entity.Property(e => e.DynamicTooltipLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DynamicTooltip_Lang_zhTW");
            entity.Property(e => e.ExtendedUi)
                .HasColumnType("text")
                .HasColumnName("ExtendedUI");
            entity.Property(e => e.ExtendedUistateVariable1).HasColumnName("ExtendedUIStateVariable_1");
            entity.Property(e => e.ExtendedUistateVariable2).HasColumnName("ExtendedUIStateVariable_2");
            entity.Property(e => e.ExtendedUistateVariable3).HasColumnName("ExtendedUIStateVariable_3");
            entity.Property(e => e.Icon).HasColumnType("text");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.StringLangDeDe)
                .HasColumnType("text")
                .HasColumnName("String_Lang_deDE");
            entity.Property(e => e.StringLangEnCn)
                .HasColumnType("text")
                .HasColumnName("String_Lang_enCN");
            entity.Property(e => e.StringLangEnGb)
                .HasColumnType("text")
                .HasColumnName("String_Lang_enGB");
            entity.Property(e => e.StringLangEnTw)
                .HasColumnType("text")
                .HasColumnName("String_Lang_enTW");
            entity.Property(e => e.StringLangEnUs)
                .HasColumnType("text")
                .HasColumnName("String_Lang_enUS");
            entity.Property(e => e.StringLangEsEs)
                .HasColumnType("text")
                .HasColumnName("String_Lang_esES");
            entity.Property(e => e.StringLangEsMx)
                .HasColumnType("text")
                .HasColumnName("String_Lang_esMX");
            entity.Property(e => e.StringLangFrFr)
                .HasColumnType("text")
                .HasColumnName("String_Lang_frFR");
            entity.Property(e => e.StringLangItIt)
                .HasColumnType("text")
                .HasColumnName("String_Lang_itIT");
            entity.Property(e => e.StringLangKoKr)
                .HasColumnType("text")
                .HasColumnName("String_Lang_koKR");
            entity.Property(e => e.StringLangMask).HasColumnName("String_Lang_Mask");
            entity.Property(e => e.StringLangPtBr)
                .HasColumnType("text")
                .HasColumnName("String_Lang_ptBR");
            entity.Property(e => e.StringLangPtPt)
                .HasColumnType("text")
                .HasColumnName("String_Lang_ptPT");
            entity.Property(e => e.StringLangRuRu)
                .HasColumnType("text")
                .HasColumnName("String_Lang_ruRU");
            entity.Property(e => e.StringLangUnk)
                .HasColumnType("text")
                .HasColumnName("String_Lang_Unk");
            entity.Property(e => e.StringLangZhCn)
                .HasColumnType("text")
                .HasColumnName("String_Lang_zhCN");
            entity.Property(e => e.StringLangZhTw)
                .HasColumnType("text")
                .HasColumnName("String_Lang_zhTW");
            entity.Property(e => e.TooltipLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_deDE");
            entity.Property(e => e.TooltipLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_enCN");
            entity.Property(e => e.TooltipLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_enGB");
            entity.Property(e => e.TooltipLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_enTW");
            entity.Property(e => e.TooltipLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_enUS");
            entity.Property(e => e.TooltipLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_esES");
            entity.Property(e => e.TooltipLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_esMX");
            entity.Property(e => e.TooltipLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_frFR");
            entity.Property(e => e.TooltipLangItIt)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_itIT");
            entity.Property(e => e.TooltipLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_koKR");
            entity.Property(e => e.TooltipLangMask).HasColumnName("Tooltip_Lang_Mask");
            entity.Property(e => e.TooltipLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_ptBR");
            entity.Property(e => e.TooltipLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_ptPT");
            entity.Property(e => e.TooltipLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_ruRU");
            entity.Property(e => e.TooltipLangUnk)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_Unk");
            entity.Property(e => e.TooltipLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_zhCN");
            entity.Property(e => e.TooltipLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Tooltip_Lang_zhTW");

            entity.HasOne(d => d.Area).WithMany(p => p.Worldstateuis)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("worldstateui_ibfk_2");

            entity.HasOne(d => d.Map).WithMany(p => p.Worldstateuis)
                .HasForeignKey(d => d.MapId)
                .HasConstraintName("worldstateui_ibfk_1");
        });

        modelBuilder.Entity<Worldstatezonesound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("worldstatezonesounds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AreaId, "AreaID");

            entity.HasIndex(e => e.SoundAmbienceId, "SoundAmbienceID");

            entity.HasIndex(e => e.SoundProviderPreferencesId, "SoundProviderPreferencesID");

            entity.HasIndex(e => e.WmoareaId, "WMOAreaID");

            entity.HasIndex(e => e.ZoneMusicId, "ZoneMusicID");

            entity.HasIndex(e => e.ZoneintroMusicId, "ZoneintroMusicID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.SoundAmbienceId).HasColumnName("SoundAmbienceID");
            entity.Property(e => e.SoundProviderPreferencesId).HasColumnName("SoundProviderPreferencesID");
            entity.Property(e => e.WmoareaId).HasColumnName("WMOAreaID");
            entity.Property(e => e.WorldStateId).HasColumnName("WorldStateID");
            entity.Property(e => e.ZoneMusicId).HasColumnName("ZoneMusicID");
            entity.Property(e => e.ZoneintroMusicId).HasColumnName("ZoneintroMusicID");

            entity.HasOne(d => d.Area).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("worldstatezonesounds_ibfk_1");

            entity.HasOne(d => d.SoundAmbience).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.SoundAmbienceId)
                .HasConstraintName("worldstatezonesounds_ibfk_5");

            entity.HasOne(d => d.SoundProviderPreferences).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.SoundProviderPreferencesId)
                .HasConstraintName("worldstatezonesounds_ibfk_6");

            entity.HasOne(d => d.Wmoarea).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.WmoareaId)
                .HasConstraintName("worldstatezonesounds_ibfk_2");

            entity.HasOne(d => d.ZoneMusic).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.ZoneMusicId)
                .HasConstraintName("worldstatezonesounds_ibfk_4");

            entity.HasOne(d => d.ZoneintroMusic).WithMany(p => p.Worldstatezonesounds)
                .HasForeignKey(d => d.ZoneintroMusicId)
                .HasConstraintName("worldstatezonesounds_ibfk_3");
        });

        modelBuilder.Entity<WowerrorString>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("wowerror_strings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ErrorName).HasColumnType("text");
            entity.Property(e => e.ErrorStringDeDe)
                .HasColumnType("text")
                .HasColumnName("ErrorString_deDE");
            entity.Property(e => e.ErrorStringEnCn)
                .HasColumnType("text")
                .HasColumnName("ErrorString_enCN");
            entity.Property(e => e.ErrorStringEnGb)
                .HasColumnType("text")
                .HasColumnName("ErrorString_enGB");
            entity.Property(e => e.ErrorStringEnTw)
                .HasColumnType("text")
                .HasColumnName("ErrorString_enTW");
            entity.Property(e => e.ErrorStringEnUs)
                .HasColumnType("text")
                .HasColumnName("ErrorString_enUS");
            entity.Property(e => e.ErrorStringEsEs)
                .HasColumnType("text")
                .HasColumnName("ErrorString_esES");
            entity.Property(e => e.ErrorStringEsMx)
                .HasColumnType("text")
                .HasColumnName("ErrorString_esMX");
            entity.Property(e => e.ErrorStringFrFr)
                .HasColumnType("text")
                .HasColumnName("ErrorString_frFR");
            entity.Property(e => e.ErrorStringItIt)
                .HasColumnType("text")
                .HasColumnName("ErrorString_itIT");
            entity.Property(e => e.ErrorStringKoKr)
                .HasColumnType("text")
                .HasColumnName("ErrorString_koKR");
            entity.Property(e => e.ErrorStringMask).HasColumnName("ErrorString_Mask");
            entity.Property(e => e.ErrorStringPtBr)
                .HasColumnType("text")
                .HasColumnName("ErrorString_ptBR");
            entity.Property(e => e.ErrorStringPtPt)
                .HasColumnType("text")
                .HasColumnName("ErrorString_ptPT");
            entity.Property(e => e.ErrorStringRuRu)
                .HasColumnType("text")
                .HasColumnName("ErrorString_ruRU");
            entity.Property(e => e.ErrorStringUnk)
                .HasColumnType("text")
                .HasColumnName("ErrorString_Unk");
            entity.Property(e => e.ErrorStringZhCn)
                .HasColumnType("text")
                .HasColumnName("ErrorString_zhCN");
            entity.Property(e => e.ErrorStringZhTw)
                .HasColumnType("text")
                .HasColumnName("ErrorString_zhTW");
        });

        modelBuilder.Entity<Zoneintromusictable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("zoneintromusictable")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SoundId, "SoundID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");

            entity.HasOne(d => d.Sound).WithMany(p => p.Zoneintromusictables)
                .HasForeignKey(d => d.SoundId)
                .HasConstraintName("zoneintromusictable_ibfk_1");
        });

        modelBuilder.Entity<Zonemusic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("zonemusic")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Sounds1, "Sounds_1");

            entity.HasIndex(e => e.Sounds2, "Sounds_2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SetName).HasColumnType("text");
            entity.Property(e => e.SilenceintervalMax1).HasColumnName("SilenceintervalMax_1");
            entity.Property(e => e.SilenceintervalMax2).HasColumnName("SilenceintervalMax_2");
            entity.Property(e => e.SilenceintervalMin1).HasColumnName("SilenceintervalMin_1");
            entity.Property(e => e.SilenceintervalMin2).HasColumnName("SilenceintervalMin_2");
            entity.Property(e => e.Sounds1).HasColumnName("Sounds_1");
            entity.Property(e => e.Sounds2).HasColumnName("Sounds_2");

            entity.HasOne(d => d.Sounds1Navigation).WithMany(p => p.ZonemusicSounds1Navigations)
                .HasForeignKey(d => d.Sounds1)
                .HasConstraintName("zonemusic_ibfk_1");

            entity.HasOne(d => d.Sounds2Navigation).WithMany(p => p.ZonemusicSounds2Navigations)
                .HasForeignKey(d => d.Sounds2)
                .HasConstraintName("zonemusic_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}