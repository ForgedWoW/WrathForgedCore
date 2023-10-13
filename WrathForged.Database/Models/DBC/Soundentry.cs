// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Soundentry.dbc")]
public partial class Soundentry : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int SoundType { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? Name { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? File1 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? File2 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? File3 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? File4 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? File5 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? File6 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? File7 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? File8 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? File9 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? File10 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Freq1 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Freq2 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Freq3 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Freq4 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int Freq5 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int Freq6 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Freq7 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int Freq8 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int Freq9 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int Freq10 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DirectoryBase { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
    public float Volumefloat { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
    public float MinDistance { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
    public float DistanceCutoff { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int Eaxdef { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int? SoundEntriesAdvancedId { get; set; }

    public virtual ICollection<Chrrace> Chrraces { get; set; } = new List<Chrrace>();

    public virtual ICollection<Cinematiccamera> Cinematiccameras { get; set; } = new List<Cinematiccamera>();

    public virtual ICollection<Cinematicsequence> Cinematicsequences { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumBirthSounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumLoopSounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumNpcsounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundAggros { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundAlerts { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundDeaths { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundExertionCriticals { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundExertions { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFidget1Navigations { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFidget2Navigations { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFidget3Navigations { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFidget4Navigations { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFidget5Navigations { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundFootsteps { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundInjuries { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundInjuryCriticals { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundInjuryCrushingBlows { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundJumpEnds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundJumpStarts { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundPetAttacks { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundPetDismisses { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundPetOrders { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundStands { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundStuns { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundWingFlaps { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSoundWingGlides { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSpellCastDirectedSounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSubmergeSounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Creaturesounddatum> CreaturesounddatumSubmergedSounds { get; set; } = new List<Creaturesounddatum>();

    public virtual ICollection<Deaththudlookup> DeaththudlookupSoundEntries { get; set; } = new List<Deaththudlookup>();

    public virtual ICollection<Deaththudlookup> DeaththudlookupSoundEntryIdwaterNavigations { get; set; } = new List<Deaththudlookup>();

    public virtual ICollection<Emote> Emotes { get; set; } = new List<Emote>();

    public virtual ICollection<Emotestextsound> Emotestextsounds { get; set; } = new List<Emotestextsound>();

    public virtual ICollection<Environmentaldamage> Environmentaldamages { get; set; } = new List<Environmentaldamage>();

    public virtual ICollection<Footstepterrainlookup> FootstepterrainlookupSoundIdsplashNavigations { get; set; } = new List<Footstepterrainlookup>();

    public virtual ICollection<Footstepterrainlookup> FootstepterrainlookupSounds { get; set; } = new List<Footstepterrainlookup>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound10Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound1Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound2Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound3Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound4Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound5Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound6Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound7Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound8Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> GameobjectdisplayinfoSound9Navigations { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Itemgroupsound> ItemgroupsoundSound1Navigations { get; set; } = new List<Itemgroupsound>();

    public virtual ICollection<Itemgroupsound> ItemgroupsoundSound2Navigations { get; set; } = new List<Itemgroupsound>();

    public virtual ICollection<Itemgroupsound> ItemgroupsoundSound3Navigations { get; set; } = new List<Itemgroupsound>();

    public virtual ICollection<Itemgroupsound> ItemgroupsoundSound4Navigations { get; set; } = new List<Itemgroupsound>();

    public virtual ICollection<Material> MaterialFoleySounds { get; set; } = new List<Material>();

    public virtual ICollection<Material> MaterialSheatheSounds { get; set; } = new List<Material>();

    public virtual ICollection<Material> MaterialUnsheatheSounds { get; set; } = new List<Material>();

    public virtual ICollection<Npcsound> NpcsoundSoundId1Navigations { get; set; } = new List<Npcsound>();

    public virtual ICollection<Npcsound> NpcsoundSoundId2Navigations { get; set; } = new List<Npcsound>();

    public virtual ICollection<Npcsound> NpcsoundSoundId3Navigations { get; set; } = new List<Npcsound>();

    public virtual ICollection<Npcsound> NpcsoundSoundId4Navigations { get; set; } = new List<Npcsound>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupSheathSounds { get; set; } = new List<Sheathesoundlookup>();

    public virtual ICollection<Sheathesoundlookup> SheathesoundlookupUnsheathSounds { get; set; } = new List<Sheathesoundlookup>();

    public virtual Soundentriesadvanced? SoundEntriesAdvanced { get; set; }

    public virtual ICollection<Soundambience> SoundambienceAmbienceId1Navigations { get; set; } = new List<Soundambience>();

    public virtual ICollection<Soundambience> SoundambienceAmbienceId2Navigations { get; set; } = new List<Soundambience>();

    public virtual ICollection<Soundemitter> Soundemitters { get; set; } = new List<Soundemitter>();

    public virtual ICollection<Soundentriesadvanced> Soundentriesadvanceds { get; set; } = new List<Soundentriesadvanced>();

    public virtual ICollection<Soundwatertype> Soundwatertypes { get; set; } = new List<Soundwatertype>();

    public virtual ICollection<Spellvisual> SpellvisualAnimEventSounds { get; set; } = new List<Spellvisual>();

    public virtual ICollection<Spellvisual> SpellvisualMissileSoundNavigations { get; set; } = new List<Spellvisual>();

    public virtual ICollection<Spellvisualkit> Spellvisualkits { get; set; } = new List<Spellvisualkit>();

    public virtual ICollection<Uisoundlookup> Uisoundlookups { get; set; } = new List<Uisoundlookup>();

    public virtual ICollection<Vocaluisound> VocaluisoundNormalSoundId1Navigations { get; set; } = new List<Vocaluisound>();

    public virtual ICollection<Vocaluisound> VocaluisoundNormalSoundId2Navigations { get; set; } = new List<Vocaluisound>();

    public virtual ICollection<Vocaluisound> VocaluisoundPissedSoundId1Navigations { get; set; } = new List<Vocaluisound>();

    public virtual ICollection<Vocaluisound> VocaluisoundPissedSoundId2Navigations { get; set; } = new List<Vocaluisound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId10Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId1Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId2Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId3Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId4Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId5Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId6Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId7Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId8Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundCritImpactSoundId9Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId10Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId1Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId2Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId3Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId4Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId5Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId6Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId7Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId8Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponimpactsound> WeaponimpactsoundImpactSoundId9Navigations { get; set; } = new List<Weaponimpactsound>();

    public virtual ICollection<Weaponswingsounds2> Weaponswingsounds2s { get; set; } = new List<Weaponswingsounds2>();

    public virtual ICollection<Weather> Weathers { get; set; } = new List<Weather>();

    public virtual ICollection<Zoneintromusictable> Zoneintromusictables { get; set; } = new List<Zoneintromusictable>();

    public virtual ICollection<Zonemusic> ZonemusicSounds1Navigations { get; set; } = new List<Zonemusic>();

    public virtual ICollection<Zonemusic> ZonemusicSounds2Navigations { get; set; } = new List<Zonemusic>();
}