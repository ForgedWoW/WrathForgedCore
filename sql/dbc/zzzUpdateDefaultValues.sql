
UPDATE achievement SET Instance_Id = NULL WHERE Instance_Id IN (0, -1);
UPDATE achievement SET Supercedes = NULL WHERE Supercedes IN (0, -1);
UPDATE achievement SET Category = NULL WHERE Category IN (0, -1);
UPDATE achievement SET IconID = NULL WHERE IconID IN (0, -1, 1243604, 4);
UPDATE achievement SET Shares_Criteria = NULL WHERE Shares_Criteria IN (0, -1);

UPDATE achievement_category SET Parent = NULL WHERE Parent IN (0, -1);

-- Delete invalid mappings. Its junk data anyway.
DELETE ac FROM achievement_criteria ac
LEFT JOIN achievement a ON ac.Achievement_Id = a.ID
WHERE ac.Achievement_Id IS NOT NULL AND a.ID IS NULL;
UPDATE achievement_criteria SET Achievement_Id = NULL WHERE Achievement_Id IN (0, -1);

UPDATE areagroup SET AreaID_1 = NULL WHERE AreaID_1 IN (0, -1);
UPDATE areagroup SET AreaID_2 = NULL WHERE AreaID_2 IN (0, -1);
UPDATE areagroup SET AreaID_3 = NULL WHERE AreaID_3 IN (0, -1);
UPDATE areagroup SET AreaID_4 = NULL WHERE AreaID_4 IN (0, -1);
UPDATE areagroup SET AreaID_5 = NULL WHERE AreaID_5 IN (0, -1);
UPDATE areagroup SET AreaID_6 = NULL WHERE AreaID_6 IN (0, -1);
UPDATE areagroup SET NextAreaID = NULL WHERE NextAreaID IN (0, -1);

UPDATE areapoi SET AreaID = NULL WHERE AreaID IN (0, -1);

UPDATE areatable SET ContinentID = NULL WHERE ContinentID IN (0, -1);
UPDATE areatable SET ParentAreaID = NULL WHERE ParentAreaID IN (0, -1);
UPDATE areatable SET SoundProviderPref = NULL WHERE SoundProviderPref IN (0, -1);
UPDATE areatable SET SoundProviderPrefUnderwater = NULL WHERE SoundProviderPrefUnderwater IN (0, -1);
UPDATE areatable SET AmbienceID = NULL WHERE AmbienceID IN (0, -1);
UPDATE areatable SET ZoneMusic = NULL WHERE ZoneMusic IN (0, -1);
UPDATE areatable SET IntroSound = NULL WHERE IntroSound IN (0, -1);
UPDATE areatable SET LiquidTypeID_1 = NULL WHERE LiquidTypeID_1 IN (0, -1);
UPDATE areatable SET LiquidTypeID_2 = NULL WHERE LiquidTypeID_2 IN (0, -1);
UPDATE areatable SET LiquidTypeID_3 = NULL WHERE LiquidTypeID_3 IN (0, -1);
UPDATE areatable SET LiquidTypeID_4 = NULL WHERE LiquidTypeID_4 IN (0, -1);
UPDATE areatable SET Lightid = NULL WHERE Lightid IN (0, -1);

UPDATE areatrigger SET ContinentID = NULL WHERE ContinentID IN (0, -1);

UPDATE attackanimkits SET Animation = NULL WHERE Animation IN (0, -1);
UPDATE attackanimkits SET Type = NULL WHERE Type IN (0, -1);

UPDATE auctionhouse SET FactionID = NULL WHERE FactionID IN (0, -1);

UPDATE battlemasterlist SET MapID_1 = NULL WHERE MapID_1 IN (0, -1);
UPDATE battlemasterlist SET MapID_2 = NULL WHERE MapID_2 IN (0, -1);
UPDATE battlemasterlist SET MapID_3 = NULL WHERE MapID_3 IN (0, -1);
UPDATE battlemasterlist SET MapID_4 = NULL WHERE MapID_4 IN (0, -1);
UPDATE battlemasterlist SET MapID_5 = NULL WHERE MapID_5 IN (0, -1);
UPDATE battlemasterlist SET MapID_6 = NULL WHERE MapID_6 IN (0, -1);
UPDATE battlemasterlist SET MapID_7 = NULL WHERE MapID_7 IN (0, -1);
UPDATE battlemasterlist SET MapID_8 = NULL WHERE MapID_8 IN (0, -1);

UPDATE charbaseinfo SET RaceID = NULL WHERE RaceID IN (0, -1);
UPDATE charbaseinfo SET ClassID = NULL WHERE ClassID IN (0, -1);

UPDATE charhairgeosets SET RaceID = NULL WHERE RaceID IN (0, -1);

UPDATE charhairtextures SET Race = NULL WHERE Race IN (0, -1);

UPDATE charsections SET RaceID = NULL WHERE RaceID IN (0, -1);

UPDATE charstartoutfit SET RaceID = NULL WHERE RaceID IN (0, -1);
UPDATE charstartoutfit SET ClassID = NULL WHERE ClassID IN (0, -1);

UPDATE chatchannels SET FactionGroup = NULL WHERE FactionGroup IN (0, -1);

UPDATE chrclasses SET CinematicSequenceID = NULL WHERE CinematicSequenceID IN (0, -1);

UPDATE chrraces SET FactionID = NULL WHERE FactionID IN (0, -1);
UPDATE chrraces SET ExplorationSoundID = NULL WHERE ExplorationSoundID IN (0, -1);
UPDATE chrraces SET MaleDisplayId = NULL WHERE MaleDisplayId IN (0, -1);
UPDATE chrraces SET FemaleDisplayId = NULL WHERE FemaleDisplayId IN (0, -1);
UPDATE chrraces SET CreatureType = NULL WHERE CreatureType IN (0, -1);
UPDATE chrraces SET CinematicSequenceID = NULL WHERE CinematicSequenceID IN (0, -1);

UPDATE cinematiccamera SET SoundID = NULL WHERE SoundID IN (0, -1);

UPDATE cinematicsequences 
SET 
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END,
Camera_1 = CASE WHEN Camera_1 IN (0, -1) THEN NULL ELSE Camera_1 END,
Camera_2 = CASE WHEN Camera_2 IN (0, -1) THEN NULL ELSE Camera_2 END,
Camera_3 = CASE WHEN Camera_3 IN (0, -1) THEN NULL ELSE Camera_3 END,
Camera_4 = CASE WHEN Camera_4 IN (0, -1) THEN NULL ELSE Camera_4 END,
Camera_5 = CASE WHEN Camera_5 IN (0, -1) THEN NULL ELSE Camera_5 END,
Camera_6 = CASE WHEN Camera_6 IN (0, -1) THEN NULL ELSE Camera_6 END,
Camera_7 = CASE WHEN Camera_7 IN (0, -1) THEN NULL ELSE Camera_7 END,
Camera_8 = CASE WHEN Camera_8 IN (0, -1) THEN NULL ELSE Camera_8 END;
UPDATE creaturedisplayinfo 
SET 
ModelID = CASE WHEN ModelID IN (0, -1) THEN NULL ELSE ModelID END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END,
ExtendedDisplayInfoID = CASE WHEN ExtendedDisplayInfoID IN (0, -1) THEN NULL ELSE ExtendedDisplayInfoID END,
BloodLevel = CASE WHEN BloodLevel IN (0, -1) THEN NULL ELSE BloodLevel END,
BloodID = CASE WHEN BloodID IN (0, -1) THEN NULL ELSE BloodID END,
NPCSoundID = CASE WHEN NPCSoundID IN (0, -1) THEN NULL ELSE NPCSoundID END,
ParticleColorID = CASE WHEN ParticleColorID IN (0, -1) THEN NULL ELSE ParticleColorID END,
ObjectEffectPackageID = CASE WHEN ObjectEffectPackageID IN (0, -1) THEN NULL ELSE ObjectEffectPackageID END;

UPDATE creaturedisplayinfoextra 
SET 
DisplayRaceID = CASE WHEN DisplayRaceID IN (0, -1) THEN NULL ELSE DisplayRaceID END,
NPCItemDisplay_1 = CASE WHEN NPCItemDisplay_1 IN (0, -1) THEN NULL ELSE NPCItemDisplay_1 END,
NPCItemDisplay_2 = CASE WHEN NPCItemDisplay_2 IN (0, -1) THEN NULL ELSE NPCItemDisplay_2 END,
NPCItemDisplay_3 = CASE WHEN NPCItemDisplay_3 IN (0, -1) THEN NULL ELSE NPCItemDisplay_3 END,
NPCItemDisplay_4 = CASE WHEN NPCItemDisplay_4 IN (0, -1) THEN NULL ELSE NPCItemDisplay_4 END,
NPCItemDisplay_5 = CASE WHEN NPCItemDisplay_5 IN (0, -1) THEN NULL ELSE NPCItemDisplay_5 END,
NPCItemDisplay_6 = CASE WHEN NPCItemDisplay_6 IN (0, -1) THEN NULL ELSE NPCItemDisplay_6 END,
NPCItemDisplay_7 = CASE WHEN NPCItemDisplay_7 IN (0, -1) THEN NULL ELSE NPCItemDisplay_7 END,
NPCItemDisplay_8 = CASE WHEN NPCItemDisplay_8 IN (0, -1) THEN NULL ELSE NPCItemDisplay_8 END,
NPCItemDisplay_9 = CASE WHEN NPCItemDisplay_9 IN (0, -1) THEN NULL ELSE NPCItemDisplay_9 END,
NPCItemDisplay_10 = CASE WHEN NPCItemDisplay_10 IN (0, -1) THEN NULL ELSE NPCItemDisplay_10 END,
NPCItemDisplay_11 = CASE WHEN NPCItemDisplay_11 IN (0, -1) THEN NULL ELSE NPCItemDisplay_11 END;

UPDATE creaturefamily 
SET 
SkillLine_1 = CASE WHEN SkillLine_1 IN (0, -1) THEN NULL ELSE SkillLine_1 END,
SkillLine_2 = CASE WHEN SkillLine_2 IN (0, -1) THEN NULL ELSE SkillLine_2 END;

UPDATE creaturemodeldata 
SET 
BloodID = CASE WHEN BloodID IN (0, -1) THEN NULL ELSE BloodID END,
FootprintTextureID = CASE WHEN FootprintTextureID IN (0, -1) THEN NULL ELSE FootprintTextureID END,
FootstepShakeSize = CASE WHEN FootstepShakeSize IN (0, -1) THEN NULL ELSE FootstepShakeSize END,
DeathThudShakeSize = CASE WHEN DeathThudShakeSize IN (0, -1) THEN NULL ELSE DeathThudShakeSize END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;
UPDATE creaturesounddata 
SET 
SoundExertionID = CASE WHEN SoundExertionID IN (0, -1) THEN NULL ELSE SoundExertionID END,
SoundExertionCriticalID = CASE WHEN SoundExertionCriticalID IN (0, -1) THEN NULL ELSE SoundExertionCriticalID END,
SoundInjuryID = CASE WHEN SoundInjuryID IN (0, -1) THEN NULL ELSE SoundInjuryID END,
SoundInjuryCriticalID = CASE WHEN SoundInjuryCriticalID IN (0, -1) THEN NULL ELSE SoundInjuryCriticalID END,
SoundInjuryCrushingBlowID = CASE WHEN SoundInjuryCrushingBlowID IN (0, -1) THEN NULL ELSE SoundInjuryCrushingBlowID END,
SoundDeathID = CASE WHEN SoundDeathID IN (0, -1) THEN NULL ELSE SoundDeathID END,
SoundStunID = CASE WHEN SoundStunID IN (0, -1) THEN NULL ELSE SoundStunID END,
SoundStandID = CASE WHEN SoundStandID IN (0, -1) THEN NULL ELSE SoundStandID END,
SoundFootstepID = CASE WHEN SoundFootstepID IN (0, -1) THEN NULL ELSE SoundFootstepID END,
SoundAggroID = CASE WHEN SoundAggroID IN (0, -1) THEN NULL ELSE SoundAggroID END,
SoundWingFlapID = CASE WHEN SoundWingFlapID IN (0, -1) THEN NULL ELSE SoundWingFlapID END,
SoundWingGlideID = CASE WHEN SoundWingGlideID IN (0, -1) THEN NULL ELSE SoundWingGlideID END,
SoundAlertID = CASE WHEN SoundAlertID IN (0, -1) THEN NULL ELSE SoundAlertID END,
SoundFidget_1 = CASE WHEN SoundFidget_1 IN (0, -1) THEN NULL ELSE SoundFidget_1 END,
SoundFidget_2 = CASE WHEN SoundFidget_2 IN (0, -1) THEN NULL ELSE SoundFidget_2 END,
SoundFidget_3 = CASE WHEN SoundFidget_3 IN (0, -1) THEN NULL ELSE SoundFidget_3 END,
SoundFidget_4 = CASE WHEN SoundFidget_4 IN (0, -1) THEN NULL ELSE SoundFidget_4 END,
SoundFidget_5 = CASE WHEN SoundFidget_5 IN (0, -1) THEN NULL ELSE SoundFidget_5 END,
NPCSoundID = CASE WHEN NPCSoundID IN (0, -1) THEN NULL ELSE NPCSoundID END,
LoopSoundID = CASE WHEN LoopSoundID IN (0, -1) THEN NULL ELSE LoopSoundID END,
SoundJumpStartID = CASE WHEN SoundJumpStartID IN (0, -1) THEN NULL ELSE SoundJumpStartID END,
SoundJumpEndID = CASE WHEN SoundJumpEndID IN (0, -1) THEN NULL ELSE SoundJumpEndID END,
SoundPetAttackID = CASE WHEN SoundPetAttackID IN (0, -1) THEN NULL ELSE SoundPetAttackID END,
SoundPetOrderID = CASE WHEN SoundPetOrderID IN (0, -1) THEN NULL ELSE SoundPetOrderID END,
SoundPetDismissID = CASE WHEN SoundPetDismissID IN (0, -1) THEN NULL ELSE SoundPetDismissID END,
BirthSoundID = CASE WHEN BirthSoundID IN (0, -1) THEN NULL ELSE BirthSoundID END,
SpellCastDirectedSoundID = CASE WHEN SpellCastDirectedSoundID IN (0, -1) THEN NULL ELSE SpellCastDirectedSoundID END,
SubmergeSoundID = CASE WHEN SubmergeSoundID IN (0, -1) THEN NULL ELSE SubmergeSoundID END,
SubmergedSoundID = CASE WHEN SubmergedSoundID IN (0, -1) THEN NULL ELSE SubmergedSoundID END;

UPDATE creaturespelldata 
SET 
Spells_1 = CASE WHEN Spells_1 IN (0, -1) THEN NULL ELSE Spells_1 END,
Spells_2 = CASE WHEN Spells_2 IN (0, -1) THEN NULL ELSE Spells_2 END,
Spells_3 = CASE WHEN Spells_3 IN (0, -1) THEN NULL ELSE Spells_3 END,
Spells_4 = CASE WHEN Spells_4 IN (0, -1) THEN NULL ELSE Spells_4 END;

UPDATE deaththudlookups 
SET 
TerraintypeSoundID = CASE WHEN TerraintypeSoundID IN (0, -1) THEN NULL ELSE TerraintypeSoundID END,
SoundEntryID = CASE WHEN SoundEntryID IN (0, -1) THEN NULL ELSE SoundEntryID END,
SoundEntryIDWater = CASE WHEN SoundEntryIDWater IN (0, -1) THEN NULL ELSE SoundEntryIDWater END;

UPDATE declinedwordcases 
SET DeclinedWordID = CASE WHEN DeclinedWordID IN (0, -1) THEN NULL ELSE DeclinedWordID END;

UPDATE dungeonencounter 
SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
Difficulty = CASE WHEN Difficulty IN (0, -1) THEN NULL ELSE Difficulty END;

UPDATE dungeonmap 
SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
ParentWorldMapID = CASE WHEN ParentWorldMapID IN (0, -1) THEN NULL ELSE ParentWorldMapID END;

UPDATE dungeonmapchunk 
SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
WmoGroupID = CASE WHEN WmoGroupID IN (0, -1) THEN NULL ELSE WmoGroupID END,
DungeonMapID = CASE WHEN DungeonMapID IN (0, -1) THEN NULL ELSE DungeonMapID END;

UPDATE emotes 
SET 
AnimID = CASE WHEN AnimID IN (0, -1) THEN NULL ELSE AnimID END,
EventSoundID = CASE WHEN EventSoundID IN (0, -1) THEN NULL ELSE EventSoundID END;

UPDATE emotestext 
SET 
EmoteID = CASE WHEN EmoteID IN (0, -1) THEN NULL ELSE EmoteID END,
EmoteText_1 = CASE WHEN EmoteText_1 IN (0, -1) THEN NULL ELSE EmoteText_1 END,
EmoteText_2 = CASE WHEN EmoteText_2 IN (0, -1) THEN NULL ELSE EmoteText_2 END,
EmoteText_3 = CASE WHEN EmoteText_3 IN (0, -1) THEN NULL ELSE EmoteText_3 END,
EmoteText_4 = CASE WHEN EmoteText_4 IN (0, -1) THEN NULL ELSE EmoteText_4 END,
EmoteText_5 = CASE WHEN EmoteText_5 IN (0, -1) THEN NULL ELSE EmoteText_5 END,
EmoteText_6 = CASE WHEN EmoteText_6 IN (0, -1) THEN NULL ELSE EmoteText_6 END,
EmoteText_7 = CASE WHEN EmoteText_7 IN (0, -1) THEN NULL ELSE EmoteText_7 END,
EmoteText_8 = CASE WHEN EmoteText_8 IN (0, -1) THEN NULL ELSE EmoteText_8 END,
EmoteText_9 = CASE WHEN EmoteText_9 IN (0, -1) THEN NULL ELSE EmoteText_9 END,
EmoteText_10 = CASE WHEN EmoteText_10 IN (0, -1) THEN NULL ELSE EmoteText_10 END,
EmoteText_11 = CASE WHEN EmoteText_11 IN (0, -1) THEN NULL ELSE EmoteText_11 END,
EmoteText_12 = CASE WHEN EmoteText_12 IN (0, -1) THEN NULL ELSE EmoteText_12 END,
EmoteText_13 = CASE WHEN EmoteText_13 IN (0, -1) THEN NULL ELSE EmoteText_13 END,
EmoteText_14 = CASE WHEN EmoteText_14 IN (0, -1) THEN NULL ELSE EmoteText_14 END,
EmoteText_15 = CASE WHEN EmoteText_15 IN (0, -1) THEN NULL ELSE EmoteText_15 END,
EmoteText_16 = CASE WHEN EmoteText_16 IN (0, -1) THEN NULL ELSE EmoteText_16 END;
UPDATE emotestextsound 
SET 
EmotesTextID = CASE WHEN EmotesTextID IN (0, -1) THEN NULL ELSE EmotesTextID END,
RaceID = CASE WHEN RaceID IN (0, -1) THEN NULL ELSE RaceID END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;

UPDATE environmentaldamage 
SET 
VisualkitID = CASE WHEN VisualkitID IN (0, -1) THEN NULL ELSE VisualkitID END;

UPDATE faction 
SET 
ParentFactionID = CASE WHEN ParentFactionID IN (0, -1) THEN NULL ELSE ParentFactionID END;

UPDATE factiontemplate 
SET 
Faction = CASE WHEN Faction IN (0, -1) THEN NULL ELSE Faction END,
Enemies_1 = CASE WHEN Enemies_1 IN (0, -1) THEN NULL ELSE Enemies_1 END,
Enemies_2 = CASE WHEN Enemies_2 IN (0, -1) THEN NULL ELSE Enemies_2 END,
Enemies_3 = CASE WHEN Enemies_3 IN (0, -1) THEN NULL ELSE Enemies_3 END,
Enemies_4 = CASE WHEN Enemies_4 IN (0, -1) THEN NULL ELSE Enemies_4 END,
Friend_1 = CASE WHEN Friend_1 IN (0, -1) THEN NULL ELSE Friend_1 END,
Friend_2 = CASE WHEN Friend_2 IN (0, -1) THEN NULL ELSE Friend_2 END,
Friend_3 = CASE WHEN Friend_3 IN (0, -1) THEN NULL ELSE Friend_3 END,
Friend_4 = CASE WHEN Friend_4 IN (0, -1) THEN NULL ELSE Friend_4 END;

UPDATE footstepterrainlookup 
SET 
CreatureFootstepID = CASE WHEN CreatureFootstepID IN (0, -1) THEN NULL ELSE CreatureFootstepID END,
TerrainSoundID = CASE WHEN TerrainSoundID IN (0, -1) THEN NULL ELSE TerrainSoundID END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END,
SoundIDSplash = CASE WHEN SoundIDSplash IN (0, -1) THEN NULL ELSE SoundIDSplash END;

UPDATE gameobjectdisplayinfo 
SET 
Sound_1 = CASE WHEN Sound_1 IN (0, -1) THEN NULL ELSE Sound_1 END,
Sound_2 = CASE WHEN Sound_2 IN (0, -1) THEN NULL ELSE Sound_2 END,
Sound_3 = CASE WHEN Sound_3 IN (0, -1) THEN NULL ELSE Sound_3 END,
Sound_4 = CASE WHEN Sound_4 IN (0, -1) THEN NULL ELSE Sound_4 END,
Sound_5 = CASE WHEN Sound_5 IN (0, -1) THEN NULL ELSE Sound_5 END,
Sound_6 = CASE WHEN Sound_6 IN (0, -1) THEN NULL ELSE Sound_6 END,
Sound_7 = CASE WHEN Sound_7 IN (0, -1) THEN NULL ELSE Sound_7 END,
Sound_8 = CASE WHEN Sound_8 IN (0, -1) THEN NULL ELSE Sound_8 END,
Sound_9 = CASE WHEN Sound_9 IN (0, -1) THEN NULL ELSE Sound_9 END,
Sound_10 = CASE WHEN Sound_10 IN (0, -1) THEN NULL ELSE Sound_10 END,
ObjectEffectPackageID = CASE WHEN ObjectEffectPackageID IN (0, -1) THEN NULL ELSE ObjectEffectPackageID END;

UPDATE gemproperties 
SET 
Enchant_Id = CASE WHEN Enchant_Id IN (0, -1) THEN NULL ELSE Enchant_Id END;

UPDATE glyphproperties 
SET 
SpellID = CASE WHEN SpellID IN (0, -1) THEN NULL ELSE SpellID END,
SpellIconID = CASE WHEN SpellIconID IN (0, -1) THEN NULL ELSE SpellIconID END;

UPDATE gmsurveyanswers 
SET 
GMSurveyQuestionID = CASE WHEN GMSurveyQuestionID IN (0, -1) THEN NULL ELSE GMSurveyQuestionID END;

UPDATE gmsurveycurrentsurvey 
SET 
GMSURVEY_ID = CASE WHEN GMSURVEY_ID IN (0, -1) THEN NULL ELSE GMSURVEY_ID END;

UPDATE gmsurveysurveys 
SET 
Q_1 = CASE WHEN Q_1 IN (0, -1) THEN NULL ELSE Q_1 END,
Q_2 = CASE WHEN Q_2 IN (0, -1) THEN NULL ELSE Q_2 END,
Q_3 = CASE WHEN Q_3 IN (0, -1) THEN NULL ELSE Q_3 END,
Q_4 = CASE WHEN Q_4 IN (0, -1) THEN NULL ELSE Q_4 END,
Q_5 = CASE WHEN Q_5 IN (0, -1) THEN NULL ELSE Q_5 END,
Q_6 = CASE WHEN Q_6 IN (0, -1) THEN NULL ELSE Q_6 END,
Q_7 = CASE WHEN Q_7 IN (0, -1) THEN NULL ELSE Q_7 END,
Q_8 = CASE WHEN Q_8 IN (0, -1) THEN NULL ELSE Q_8 END,
Q_9 = CASE WHEN Q_9 IN (0, -1) THEN NULL ELSE Q_9 END,
Q_10 = CASE WHEN Q_10 IN (0, -1) THEN NULL ELSE Q_10 END;
UPDATE groundeffecttexture 
SET 
DoodadId_1 = CASE WHEN DoodadId_1 IN (0, -1) THEN NULL ELSE DoodadId_1 END,
DoodadId_2 = CASE WHEN DoodadId_2 IN (0, -1) THEN NULL ELSE DoodadId_2 END,
DoodadId_3 = CASE WHEN DoodadId_3 IN (0, -1) THEN NULL ELSE DoodadId_3 END,
DoodadId_4 = CASE WHEN DoodadId_4 IN (0, -1) THEN NULL ELSE DoodadId_4 END;

UPDATE holidays 
SET 
HolidayNameID = CASE WHEN HolidayNameID IN (0, -1) THEN NULL ELSE HolidayNameID END,
HolidayDescriptionID = CASE WHEN HolidayDescriptionID IN (0, -1) THEN NULL ELSE HolidayDescriptionID END;

UPDATE item 
SET 
ClassID = CASE WHEN ClassID IN (0, -1) THEN NULL ELSE ClassID END,
SubclassID = CASE WHEN SubclassID IN (0, -1) THEN NULL ELSE SubclassID END,
Material = CASE WHEN Material IN (0, -1) THEN NULL ELSE Material END,
DisplayInfoID = CASE WHEN DisplayInfoID IN (0, -1) THEN NULL ELSE DisplayInfoID END;

UPDATE itemdisplayinfo 
SET 
GroupSoundIndex = CASE WHEN GroupSoundIndex IN (0, -1) THEN NULL ELSE GroupSoundIndex END,
HelmetGeosetVis_1 = CASE WHEN HelmetGeosetVis_1 IN (0, -1) THEN NULL ELSE HelmetGeosetVis_1 END,
HelmetGeosetVis_2 = CASE WHEN HelmetGeosetVis_2 IN (0, -1) THEN NULL ELSE HelmetGeosetVis_2 END,
ItemVisual = CASE WHEN ItemVisual IN (0, -1) THEN NULL ELSE ItemVisual END;

UPDATE itemextendedcost 
SET 
ItemID_1 = CASE WHEN ItemID_1 IN (0, -1) THEN NULL ELSE ItemID_1 END,
ItemID_2 = CASE WHEN ItemID_2 IN (0, -1) THEN NULL ELSE ItemID_2 END,
ItemID_3 = CASE WHEN ItemID_3 IN (0, -1) THEN NULL ELSE ItemID_3 END,
ItemID_4 = CASE WHEN ItemID_4 IN (0, -1) THEN NULL ELSE ItemID_4 END,
ItemID_5 = CASE WHEN ItemID_5 IN (0, -1) THEN NULL ELSE ItemID_5 END,
ItemPurchaseGroup = CASE WHEN ItemPurchaseGroup IN (0, -1) THEN NULL ELSE ItemPurchaseGroup END;

UPDATE itemgroupsounds 
SET 
Pickup = CASE WHEN Pickup IN (0, -1) THEN NULL ELSE Pickup END,
`Drop` = CASE WHEN `Drop` IN (0, -1) THEN NULL ELSE `Drop` END,
`Close` = CASE WHEN `Close` IN (0, -1) THEN NULL ELSE `Close` END,
`Use` = CASE WHEN `Use` IN (0, -1) THEN NULL ELSE `Use` END;

UPDATE itempurchasegroup 
SET 
ItemID_1 = CASE WHEN ItemID_1 IN (0, -1) THEN NULL ELSE ItemID_1 END,
ItemID_2 = CASE WHEN ItemID_2 IN (0, -1) THEN NULL ELSE ItemID_2 END,
ItemID_3 = CASE WHEN ItemID_3 IN (0, -1) THEN NULL ELSE ItemID_3 END,
ItemID_4 = CASE WHEN ItemID_4 IN (0, -1) THEN NULL ELSE ItemID_4 END,
ItemID_5 = CASE WHEN ItemID_5 IN (0, -1) THEN NULL ELSE ItemID_5 END,
ItemID_6 = CASE WHEN ItemID_6 IN (0, -1) THEN NULL ELSE ItemID_6 END,
ItemID_7 = CASE WHEN ItemID_7 IN (0, -1) THEN NULL ELSE ItemID_7 END,
ItemID_8 = CASE WHEN ItemID_8 IN (0, -1) THEN NULL ELSE ItemID_8 END;

UPDATE itemrandomproperties 
SET 
Enchantment_1 = CASE WHEN Enchantment_1 IN (0, -1) THEN NULL ELSE Enchantment_1 END,
Enchantment_2 = CASE WHEN Enchantment_2 IN (0, -1) THEN NULL ELSE Enchantment_2 END,
Enchantment_3 = CASE WHEN Enchantment_3 IN (0, -1) THEN NULL ELSE Enchantment_3 END,
Enchantment_4 = CASE WHEN Enchantment_4 IN (0, -1) THEN NULL ELSE Enchantment_4 END,
Enchantment_5 = CASE WHEN Enchantment_5 IN (0, -1) THEN NULL ELSE Enchantment_5 END;

UPDATE itemrandomsuffix 
SET 
Enchantment_1 = CASE WHEN Enchantment_1 IN (0, -1) THEN NULL ELSE Enchantment_1 END,
Enchantment_2 = CASE WHEN Enchantment_2 IN (0, -1) THEN NULL ELSE Enchantment_2 END,
Enchantment_3 = CASE WHEN Enchantment_3 IN (0, -1) THEN NULL ELSE Enchantment_3 END,
Enchantment_4 = CASE WHEN Enchantment_4 IN (0, -1) THEN NULL ELSE Enchantment_4 END,
Enchantment_5 = CASE WHEN Enchantment_5 IN (0, -1) THEN NULL ELSE Enchantment_5 END;

UPDATE itemset 
SET 
ItemID_1 = CASE WHEN ItemID_1 IN (0, -1) THEN NULL ELSE ItemID_1 END,
ItemID_2 = CASE WHEN ItemID_2 IN (0, -1) THEN NULL ELSE ItemID_2 END,
ItemID_3 = CASE WHEN ItemID_3 IN (0, -1) THEN NULL ELSE ItemID_3 END,
ItemID_4 = CASE WHEN ItemID_4 IN (0, -1) THEN NULL ELSE ItemID_4 END,
ItemID_5 = CASE WHEN ItemID_5 IN (0, -1) THEN NULL ELSE ItemID_5 END,
ItemID_6 = CASE WHEN ItemID_6 IN (0, -1) THEN NULL ELSE ItemID_6 END,
ItemID_7 = CASE WHEN ItemID_7 IN (0, -1) THEN NULL ELSE ItemID_7 END,
ItemID_8 = CASE WHEN ItemID_8 IN (0, -1) THEN NULL ELSE ItemID_8 END,
ItemID_9 = CASE WHEN ItemID_9 IN (0, -1) THEN NULL ELSE ItemID_9 END,
ItemID_10 = CASE WHEN ItemID_10 IN (0, -1) THEN NULL ELSE ItemID_10 END,
ItemID_11 = CASE WHEN ItemID_11 IN (0, -1) THEN NULL ELSE ItemID_11 END,
ItemID_12 = CASE WHEN ItemID_12 IN (0, -1) THEN NULL ELSE ItemID_12 END,
ItemID_13 = CASE WHEN ItemID_13 IN (0, -1) THEN NULL ELSE ItemID_13 END,
ItemID_14 = CASE WHEN ItemID_14 IN (0, -1) THEN NULL ELSE ItemID_14 END,
ItemID_15 = CASE WHEN ItemID_15 IN (0, -1) THEN NULL ELSE ItemID_15 END,
ItemID_16 = CASE WHEN ItemID_16 IN (0, -1) THEN NULL ELSE ItemID_16 END,
ItemID_17 = CASE WHEN ItemID_17 IN (0, -1) THEN NULL ELSE ItemID_17 END,
SetSpellID_1 = CASE WHEN SetSpellID_1 IN (0, -1) THEN NULL ELSE SetSpellID_1 END,
SetSpellID_2 = CASE WHEN SetSpellID_2 IN (0, -1) THEN NULL ELSE SetSpellID_2 END,
SetSpellID_3 = CASE WHEN SetSpellID_3 IN (0, -1) THEN NULL ELSE SetSpellID_3 END,
SetSpellID_4 = CASE WHEN SetSpellID_4 IN (0, -1) THEN NULL ELSE SetSpellID_4 END,
SetSpellID_5 = CASE WHEN SetSpellID_5 IN (0, -1) THEN NULL ELSE SetSpellID_5 END,
SetSpellID_6 = CASE WHEN SetSpellID_6 IN (0, -1) THEN NULL ELSE SetSpellID_6 END,
SetSpellID_7 = CASE WHEN SetSpellID_7 IN (0, -1) THEN NULL ELSE SetSpellID_7 END,
SetSpellID_8 = CASE WHEN SetSpellID_8 IN (0, -1) THEN NULL ELSE SetSpellID_8 END,
RequiredSkill = CASE WHEN RequiredSkill IN (0, -1) THEN NULL ELSE RequiredSkill END;
UPDATE itemsubclass SET 
ClassID = CASE WHEN ClassID IN (0, -1) THEN NULL ELSE ClassID END;

UPDATE itemvisuals SET 
Slot_1 = CASE WHEN Slot_1 IN (0, -1) THEN NULL ELSE Slot_1 END,
Slot_2 = CASE WHEN Slot_2 IN (0, -1) THEN NULL ELSE Slot_2 END,
Slot_3 = CASE WHEN Slot_3 IN (0, -1) THEN NULL ELSE Slot_3 END,
Slot_4 = CASE WHEN Slot_4 IN (0, -1) THEN NULL ELSE Slot_4 END,
Slot_5 = CASE WHEN Slot_5 IN (0, -1) THEN NULL ELSE Slot_5 END;

UPDATE languagewords SET 
LanguageID = CASE WHEN LanguageID IN (0, -1) THEN NULL ELSE LanguageID END;

UPDATE lfgdungeonexpansion SET 
Lfg_Id = CASE WHEN Lfg_Id IN (0, -1) THEN NULL ELSE Lfg_Id END;

UPDATE lfgdungeons SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
Faction = CASE WHEN Faction IN (0, -1) THEN NULL ELSE Faction END;

UPDATE lightparams SET 
LightSkyboxID = CASE WHEN LightSkyboxID IN (0, -1) THEN NULL ELSE LightSkyboxID END;

UPDATE loadingscreentaxisplines SET 
PathID = CASE WHEN PathID IN (0, -1) THEN NULL ELSE PathID END;

UPDATE `lock` SET 
Type_1 = CASE WHEN Type_1 IN (0, -1) THEN NULL ELSE Type_1 END,
Type_2 = CASE WHEN Type_2 IN (0, -1) THEN NULL ELSE Type_2 END,
Type_3 = CASE WHEN Type_3 IN (0, -1) THEN NULL ELSE Type_3 END,
Type_4 = CASE WHEN Type_4 IN (0, -1) THEN NULL ELSE Type_4 END,
Type_5 = CASE WHEN Type_5 IN (0, -1) THEN NULL ELSE Type_5 END,
Type_6 = CASE WHEN Type_6 IN (0, -1) THEN NULL ELSE Type_6 END,
Type_7 = CASE WHEN Type_7 IN (0, -1) THEN NULL ELSE Type_7 END,
Type_8 = CASE WHEN Type_8 IN (0, -1) THEN NULL ELSE Type_8 END;

UPDATE map SET 
AreaTableID = CASE WHEN AreaTableID IN (0, -1) THEN NULL ELSE AreaTableID END,
LoadingScreenID = CASE WHEN LoadingScreenID IN (0, -1) THEN NULL ELSE LoadingScreenID END,
CorpseMapID = CASE WHEN CorpseMapID IN (0, -1) THEN NULL ELSE CorpseMapID END;

UPDATE mapdifficulty SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END;

UPDATE material SET 
FoleySoundID = CASE WHEN FoleySoundID IN (0, -1) THEN NULL ELSE FoleySoundID END,
SheatheSoundID = CASE WHEN SheatheSoundID IN (0, -1) THEN NULL ELSE SheatheSoundID END,
UnsheatheSoundID = CASE WHEN UnsheatheSoundID IN (0, -1) THEN NULL ELSE UnsheatheSoundID END;

UPDATE namegen SET 
RaceID = CASE WHEN RaceID IN (0, -1) THEN NULL ELSE RaceID END;

UPDATE npcsounds SET 
SoundID_1 = CASE WHEN SoundID_1 IN (0, -1) THEN NULL ELSE SoundID_1 END,
SoundID_2 = CASE WHEN SoundID_2 IN (0, -1) THEN NULL ELSE SoundID_2 END,
SoundID_3 = CASE WHEN SoundID_3 IN (0, -1) THEN NULL ELSE SoundID_3 END,
SoundID_4 = CASE WHEN SoundID_4 IN (0, -1) THEN NULL ELSE SoundID_4 END;

UPDATE objecteffect SET 
ObjectEffectGroupID = CASE WHEN ObjectEffectGroupID IN (0, -1) THEN NULL ELSE ObjectEffectGroupID END,
ObjectEffectModifierID = CASE WHEN ObjectEffectModifierID IN (0, -1) THEN NULL ELSE ObjectEffectModifierID END;

UPDATE objecteffectpackageelem SET 
ObjectEffectGroupID = CASE WHEN ObjectEffectGroupID IN (0, -1) THEN NULL ELSE ObjectEffectGroupID END,
ObjectEffectPackageID = CASE WHEN ObjectEffectPackageID IN (0, -1) THEN NULL ELSE ObjectEffectPackageID END;

UPDATE overridespelldata SET 
Spells_1 = CASE WHEN Spells_1 IN (0, -1) THEN NULL ELSE Spells_1 END,
Spells_2 = CASE WHEN Spells_2 IN (0, -1) THEN NULL ELSE Spells_2 END,
Spells_3 = CASE WHEN Spells_3 IN (0, -1) THEN NULL ELSE Spells_3 END,
Spells_4 = CASE WHEN Spells_4 IN (0, -1) THEN NULL ELSE Spells_4 END,
Spells_5 = CASE WHEN Spells_5 IN (0, -1) THEN NULL ELSE Spells_5 END,
Spells_6 = CASE WHEN Spells_6 IN (0, -1) THEN NULL ELSE Spells_6 END,
Spells_7 = CASE WHEN Spells_7 IN (0, -1) THEN NULL ELSE Spells_7 END,
Spells_8 = CASE WHEN Spells_8 IN (0, -1) THEN NULL ELSE Spells_8 END,
Spells_9 = CASE WHEN Spells_9 IN (0, -1) THEN NULL ELSE Spells_9 END,
Spells_10 = CASE WHEN Spells_10 IN (0, -1) THEN NULL ELSE Spells_10 END;

UPDATE pvpdifficulty SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END;

UPDATE sheathesoundlookups SET 
ItemClass = CASE WHEN ItemClass IN (0, -1) THEN NULL ELSE ItemClass END,
ItemSubclass = CASE WHEN ItemSubclass IN (0, -1) THEN NULL ELSE ItemSubclass END,
SheathSoundID = CASE WHEN SheathSoundID IN (0, -1) THEN NULL ELSE SheathSoundID END,
UnsheathSoundID = CASE WHEN UnsheathSoundID IN (0, -1) THEN NULL ELSE UnsheathSoundID END;

UPDATE skillline SET 
CategoryID = CASE WHEN CategoryID IN (0, -1) THEN NULL ELSE CategoryID END,
SkillCostsID = CASE WHEN SkillCostsID IN (0, -1) THEN NULL ELSE SkillCostsID END,
SpellIconID = CASE WHEN SpellIconID IN (0, -1) THEN NULL ELSE SpellIconID END;

UPDATE skilllineability SET 
SkillLine = CASE WHEN SkillLine IN (0, -1) THEN NULL ELSE SkillLine END,
Spell = CASE WHEN Spell IN (0, -1) THEN NULL ELSE Spell END;

UPDATE skillraceclassinfo SET 
SkillID = CASE WHEN SkillID IN (0, -1) THEN NULL ELSE SkillID END,
SkillTierID = CASE WHEN SkillTierID IN (0, -1) THEN NULL ELSE SkillTierID END,
SkillCostIndex = CASE WHEN SkillCostIndex IN (0, -1) THEN NULL ELSE SkillCostIndex END;

UPDATE soundambience SET 
AmbienceID_1 = CASE WHEN AmbienceID_1 IN (0, -1) THEN NULL ELSE AmbienceID_1 END,
AmbienceID_2 = CASE WHEN AmbienceID_2 IN (0, -1) THEN NULL ELSE AmbienceID_2 END;

UPDATE soundemitters SET 
SoundEntriesID = CASE WHEN SoundEntriesID IN (0, -1) THEN NULL ELSE SoundEntriesID END,
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END;

UPDATE soundentries SET 
SoundEntriesAdvancedID = CASE WHEN SoundEntriesAdvancedID IN (0, -1) THEN NULL ELSE SoundEntriesAdvancedID END;

UPDATE soundentriesadvanced SET 
SoundEntryID = CASE WHEN SoundEntryID IN (0, -1) THEN NULL ELSE SoundEntryID END;

UPDATE soundwatertype SET 
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;
UPDATE spell SET 
Category = CASE WHEN Category IN (0, -1) THEN NULL ELSE Category END,
DispelType = CASE WHEN DispelType IN (0, -1) THEN NULL ELSE DispelType END,
Mechanic = CASE WHEN Mechanic IN (0, -1) THEN NULL ELSE Mechanic END,
RequiresSpellFocus = CASE WHEN RequiresSpellFocus IN (0, -1) THEN NULL ELSE RequiresSpellFocus END,
CastingTimeIndex = CASE WHEN CastingTimeIndex IN (0, -1) THEN NULL ELSE CastingTimeIndex END,
DurationIndex = CASE WHEN DurationIndex IN (0, -1) THEN NULL ELSE DurationIndex END,
RangeIndex = CASE WHEN RangeIndex IN (0, -1) THEN NULL ELSE RangeIndex END,
EffectMechanic_1 = CASE WHEN EffectMechanic_1 IN (0, -1) THEN NULL ELSE EffectMechanic_1 END,
EffectMechanic_2 = CASE WHEN EffectMechanic_2 IN (0, -1) THEN NULL ELSE EffectMechanic_2 END,
EffectMechanic_3 = CASE WHEN EffectMechanic_3 IN (0, -1) THEN NULL ELSE EffectMechanic_3 END,
EffectRadiusIndex_1 = CASE WHEN EffectRadiusIndex_1 IN (0, -1) THEN NULL ELSE EffectRadiusIndex_1 END,
EffectRadiusIndex_2 = CASE WHEN EffectRadiusIndex_2 IN (0, -1) THEN NULL ELSE EffectRadiusIndex_2 END,
EffectRadiusIndex_3 = CASE WHEN EffectRadiusIndex_3 IN (0, -1) THEN NULL ELSE EffectRadiusIndex_3 END,
RequiredTotemCategoryID_1 = CASE WHEN RequiredTotemCategoryID_1 IN (0, -1) THEN NULL ELSE RequiredTotemCategoryID_1 END,
RequiredTotemCategoryID_2 = CASE WHEN RequiredTotemCategoryID_2 IN (0, -1) THEN NULL ELSE RequiredTotemCategoryID_2 END,
Reagent_1 = CASE WHEN Reagent_1 IN (0, -1) THEN NULL ELSE Reagent_1 END,
Reagent_2 = CASE WHEN Reagent_2 IN (0, -1) THEN NULL ELSE Reagent_2 END,
Reagent_3 = CASE WHEN Reagent_3 IN (0, -1) THEN NULL ELSE Reagent_3 END,
Reagent_4 = CASE WHEN Reagent_4 IN (0, -1) THEN NULL ELSE Reagent_4 END,
Reagent_5 = CASE WHEN Reagent_5 IN (0, -1) THEN NULL ELSE Reagent_5 END,
Reagent_6 = CASE WHEN Reagent_6 IN (0, -1) THEN NULL ELSE Reagent_6 END,
Reagent_7 = CASE WHEN Reagent_7 IN (0, -1) THEN NULL ELSE Reagent_7 END,
Reagent_8 = CASE WHEN Reagent_8 IN (0, -1) THEN NULL ELSE Reagent_8 END,
SpellVisualID_1 = CASE WHEN SpellVisualID_1 IN (0, -1) THEN NULL ELSE SpellVisualID_1 END,
SpellVisualID_2 = CASE WHEN SpellVisualID_2 IN (0, -1) THEN NULL ELSE SpellVisualID_2 END,
SpellIconID = CASE WHEN SpellIconID IN (0, -1) THEN NULL ELSE SpellIconID END,
ActiveIconID = CASE WHEN ActiveIconID IN (0, -1) THEN NULL ELSE ActiveIconID END,
RequiredAreasID = CASE WHEN RequiredAreasID IN (0, -1) THEN NULL ELSE RequiredAreasID END,
RuneCostID = CASE WHEN RuneCostID IN (0, -1) THEN NULL ELSE RuneCostID END,
SpellMissileID = CASE WHEN SpellMissileID IN (0, -1) THEN NULL ELSE SpellMissileID END,
SpellDescriptionVariableID = CASE WHEN SpellDescriptionVariableID IN (0, -1) THEN NULL ELSE SpellDescriptionVariableID END,
SpellDifficultyID = CASE WHEN SpellDifficultyID IN (0, -1) THEN NULL ELSE SpellDifficultyID END,
PowerDisplayID = CASE WHEN PowerDisplayID IN (0, -1) THEN NULL ELSE PowerDisplayID END;

UPDATE spelldifficulty SET 
DifficultySpellID_1 = CASE WHEN DifficultySpellID_1 IN (0, -1) THEN NULL ELSE DifficultySpellID_1 END,
DifficultySpellID_2 = CASE WHEN DifficultySpellID_2 IN (0, -1) THEN NULL ELSE DifficultySpellID_2 END,
DifficultySpellID_3 = CASE WHEN DifficultySpellID_3 IN (0, -1) THEN NULL ELSE DifficultySpellID_3 END,
DifficultySpellID_4 = CASE WHEN DifficultySpellID_4 IN (0, -1) THEN NULL ELSE DifficultySpellID_4 END;

UPDATE spelleffectcamerashakes SET 
CameraShake_1 = CASE WHEN CameraShake_1 IN (0, -1) THEN NULL ELSE CameraShake_1 END,
CameraShake_2 = CASE WHEN CameraShake_2 IN (0, -1) THEN NULL ELSE CameraShake_2 END,
CameraShake_3 = CASE WHEN CameraShake_3 IN (0, -1) THEN NULL ELSE CameraShake_3 END;

UPDATE spellitemenchantment SET 
Effect_1 = CASE WHEN Effect_1 IN (0, -1) THEN NULL ELSE Effect_1 END,
Effect_2 = CASE WHEN Effect_2 IN (0, -1) THEN NULL ELSE Effect_2 END,
Effect_3 = CASE WHEN Effect_3 IN (0, -1) THEN NULL ELSE Effect_3 END,
ItemVisual = CASE WHEN ItemVisual IN (0, -1) THEN NULL ELSE ItemVisual END,
Src_ItemID = CASE WHEN Src_ItemID IN (0, -1) THEN NULL ELSE Src_ItemID END,
Condition_Id = CASE WHEN Condition_Id IN (0, -1) THEN NULL ELSE Condition_Id END,
RequiredSkillID = CASE WHEN RequiredSkillID IN (0, -1) THEN NULL ELSE RequiredSkillID END;

UPDATE spellshapeshiftform SET 
CreatureType = CASE WHEN CreatureType IN (0, -1) THEN NULL ELSE CreatureType END,
AttackIconID = CASE WHEN AttackIconID IN (0, -1) THEN NULL ELSE AttackIconID END,
CreatureDisplayID_1 = CASE WHEN CreatureDisplayID_1 IN (0, -1) THEN NULL ELSE CreatureDisplayID_1 END,
CreatureDisplayID_2 = CASE WHEN CreatureDisplayID_2 IN (0, -1) THEN NULL ELSE CreatureDisplayID_2 END,
CreatureDisplayID_3 = CASE WHEN CreatureDisplayID_3 IN (0, -1) THEN NULL ELSE CreatureDisplayID_3 END,
CreatureDisplayID_4 = CASE WHEN CreatureDisplayID_4 IN (0, -1) THEN NULL ELSE CreatureDisplayID_4 END,
PresetSpellID_1 = CASE WHEN PresetSpellID_1 IN (0, -1) THEN NULL ELSE PresetSpellID_1 END,
PresetSpellID_2 = CASE WHEN PresetSpellID_2 IN (0, -1) THEN NULL ELSE PresetSpellID_2 END,
PresetSpellID_3 = CASE WHEN PresetSpellID_3 IN (0, -1) THEN NULL ELSE PresetSpellID_3 END,
PresetSpellID_4 = CASE WHEN PresetSpellID_4 IN (0, -1) THEN NULL ELSE PresetSpellID_4 END,
PresetSpellID_5 = CASE WHEN PresetSpellID_5 IN (0, -1) THEN NULL ELSE PresetSpellID_5 END,
PresetSpellID_6 = CASE WHEN PresetSpellID_6 IN (0, -1) THEN NULL ELSE PresetSpellID_6 END,
PresetSpellID_7 = CASE WHEN PresetSpellID_7 IN (0, -1) THEN NULL ELSE PresetSpellID_7 END,
PresetSpellID_8 = CASE WHEN PresetSpellID_8 IN (0, -1) THEN NULL ELSE PresetSpellID_8 END;

UPDATE spellvisual SET 
PrecastKit = CASE WHEN PrecastKit IN (0, -1) THEN NULL ELSE PrecastKit END,
CastKit = CASE WHEN CastKit IN (0, -1) THEN NULL ELSE CastKit END,
ImpactKit = CASE WHEN ImpactKit IN (0, -1) THEN NULL ELSE ImpactKit END,
StateKit = CASE WHEN StateKit IN (0, -1) THEN NULL ELSE StateKit END,
StateDoneKit = CASE WHEN StateDoneKit IN (0, -1) THEN NULL ELSE StateDoneKit END,
ChannelKit = CASE WHEN ChannelKit IN (0, -1) THEN NULL ELSE ChannelKit END,
MissileModel = CASE WHEN MissileModel IN (0, -1) THEN NULL ELSE MissileModel END,
MissileSound = CASE WHEN MissileSound IN (0, -1) THEN NULL ELSE MissileSound END,
AnimEventSoundID = CASE WHEN AnimEventSoundID IN (0, -1) THEN NULL ELSE AnimEventSoundID END,
CasterImpactKit = CASE WHEN CasterImpactKit IN (0, -1) THEN NULL ELSE CasterImpactKit END,
TargetImpactKit = CASE WHEN TargetImpactKit IN (0, -1) THEN NULL ELSE TargetImpactKit END,
MissileTargetingKit = CASE WHEN MissileTargetingKit IN (0, -1) THEN NULL ELSE MissileTargetingKit END,
InstantAreaKit = CASE WHEN InstantAreaKit IN (0, -1) THEN NULL ELSE InstantAreaKit END,
ImpactAreaKit = CASE WHEN ImpactAreaKit IN (0, -1) THEN NULL ELSE ImpactAreaKit END,
PersistentAreaKit = CASE WHEN PersistentAreaKit IN (0, -1) THEN NULL ELSE PersistentAreaKit END;

UPDATE spellvisualkit SET 
StartAnimID = CASE WHEN StartAnimID IN (0, -1) THEN NULL ELSE StartAnimID END,
AnimID = CASE WHEN AnimID IN (0, -1) THEN NULL ELSE AnimID END,
HeadEffect = CASE WHEN HeadEffect IN (0, -1) THEN NULL ELSE HeadEffect END,
ChestEffect = CASE WHEN ChestEffect IN (0, -1) THEN NULL ELSE ChestEffect END,
BaseEffect = CASE WHEN BaseEffect IN (0, -1) THEN NULL ELSE BaseEffect END,
LeftHandEffect = CASE WHEN LeftHandEffect IN (0, -1) THEN NULL ELSE LeftHandEffect END,
RightHandEffect = CASE WHEN RightHandEffect IN (0, -1) THEN NULL ELSE RightHandEffect END,
BreathEffect = CASE WHEN BreathEffect IN (0, -1) THEN NULL ELSE BreathEffect END,
LeftWeaponEffect = CASE WHEN LeftWeaponEffect IN (0, -1) THEN NULL ELSE LeftWeaponEffect END,
RightWeaponEffect = CASE WHEN RightWeaponEffect IN (0, -1) THEN NULL ELSE RightWeaponEffect END,
SpecialEffect_1 = CASE WHEN SpecialEffect_1 IN (0, -1) THEN NULL ELSE SpecialEffect_1 END,
SpecialEffect_2 = CASE WHEN SpecialEffect_2 IN (0, -1) THEN NULL ELSE SpecialEffect_2 END,
SpecialEffect_3 = CASE WHEN SpecialEffect_3 IN (0, -1) THEN NULL ELSE SpecialEffect_3 END,
WorldEffect = CASE WHEN WorldEffect IN (0, -1) THEN NULL ELSE WorldEffect END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END,
ShakeID = CASE WHEN ShakeID IN (0, -1) THEN NULL ELSE ShakeID END;

UPDATE spellvisualkitmodelattach SET 
ParentSpellVisualKitID = CASE WHEN ParentSpellVisualKitID IN (0, -1) THEN NULL ELSE ParentSpellVisualKitID END,
SpellVisualEffectNameID = CASE WHEN SpellVisualEffectNameID IN (0, -1) THEN NULL ELSE SpellVisualEffectNameID END;

UPDATE stationery SET 
ItemID = CASE WHEN ItemID IN (0, -1) THEN NULL ELSE ItemID END;

UPDATE talent SET 
TabID = CASE WHEN TabID IN (0, -1) THEN NULL ELSE TabID END,
SpellRank_1 = CASE WHEN SpellRank_1 IN (0, -1) THEN NULL ELSE SpellRank_1 END,
SpellRank_2 = CASE WHEN SpellRank_2 IN (0, -1) THEN NULL ELSE SpellRank_2 END,
SpellRank_3 = CASE WHEN SpellRank_3 IN (0, -1) THEN NULL ELSE SpellRank_3 END,
SpellRank_4 = CASE WHEN SpellRank_4 IN (0, -1) THEN NULL ELSE SpellRank_4 END,
SpellRank_5 = CASE WHEN SpellRank_5 IN (0, -1) THEN NULL ELSE SpellRank_5 END,
SpellRank_6 = CASE WHEN SpellRank_6 IN (0, -1) THEN NULL ELSE SpellRank_6 END,
SpellRank_7 = CASE WHEN SpellRank_7 IN (0, -1) THEN NULL ELSE SpellRank_7 END,
SpellRank_8 = CASE WHEN SpellRank_8 IN (0, -1) THEN NULL ELSE SpellRank_8 END,
SpellRank_9 = CASE WHEN SpellRank_9 IN (0, -1) THEN NULL ELSE SpellRank_9 END,
PrereqTalent_1 = CASE WHEN PrereqTalent_1 IN (0, -1) THEN NULL ELSE PrereqTalent_1 END,
PrereqTalent_2 = CASE WHEN PrereqTalent_2 IN (0, -1) THEN NULL ELSE PrereqTalent_2 END,
PrereqTalent_3 = CASE WHEN PrereqTalent_3 IN (0, -1) THEN NULL ELSE PrereqTalent_3 END,
RequiredSpellID = CASE WHEN RequiredSpellID IN (0, -1) THEN NULL ELSE RequiredSpellID END;
UPDATE talenttab SET 
SpellIconID = CASE WHEN SpellIconID IN (0, -1) THEN NULL ELSE SpellIconID END;

UPDATE taxinodes SET 
ContinentID = CASE WHEN ContinentID IN (0, -1) THEN NULL ELSE ContinentID END;

UPDATE taxipath SET 
FromTaxiNode = CASE WHEN FromTaxiNode IN (0, -1) THEN NULL ELSE FromTaxiNode END,
ToTaxiNode = CASE WHEN ToTaxiNode IN (0, -1) THEN NULL ELSE ToTaxiNode END;

UPDATE taxipathnode SET 
PathID = CASE WHEN PathID IN (0, -1) THEN NULL ELSE PathID END,
ContinentID = CASE WHEN ContinentID IN (0, -1) THEN NULL ELSE ContinentID END;

UPDATE terraintype SET 
FootstepSprayRun = CASE WHEN FootstepSprayRun IN (0, -1) THEN NULL ELSE FootstepSprayRun END,
FootstepSprayWalk = CASE WHEN FootstepSprayWalk IN (0, -1) THEN NULL ELSE FootstepSprayWalk END,
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;

UPDATE transportanimation SET 
SequenceID = CASE WHEN SequenceID IN (0, -1) THEN NULL ELSE SequenceID END;

UPDATE uisoundlookups SET 
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;

UPDATE vehicle SET 
PowerDisplayID_1 = CASE WHEN PowerDisplayID_1 IN (0, -1) THEN NULL ELSE PowerDisplayID_1 END,
PowerDisplayID_2 = CASE WHEN PowerDisplayID_2 IN (0, -1) THEN NULL ELSE PowerDisplayID_2 END,
PowerDisplayID_3 = CASE WHEN PowerDisplayID_3 IN (0, -1) THEN NULL ELSE PowerDisplayID_3 END;

UPDATE vehicleuiindseat SET 
VehicleUIIndicatorID = CASE WHEN VehicleUIIndicatorID IN (0, -1) THEN NULL ELSE VehicleUIIndicatorID END;

UPDATE vocaluisounds SET 
RaceID = CASE WHEN RaceID IN (0, -1) THEN NULL ELSE RaceID END,
MaleNormalSound = CASE WHEN MaleNormalSound IN (0, -1) THEN NULL ELSE MaleNormalSound END,
FemaleNormalSound = CASE WHEN FemaleNormalSound IN (0, -1) THEN NULL ELSE FemaleNormalSound END,
MalePissedSound = CASE WHEN MalePissedSound IN (0, -1) THEN NULL ELSE MalePissedSound END,
FemalePissedSound = CASE WHEN FemalePissedSound IN (0, -1) THEN NULL ELSE FemalePissedSound END;

UPDATE weaponimpactsounds SET 
ImpactSoundID_1 = CASE WHEN ImpactSoundID_1 IN (0, -1) THEN NULL ELSE ImpactSoundID_1 END,
ImpactSoundID_2 = CASE WHEN ImpactSoundID_2 IN (0, -1) THEN NULL ELSE ImpactSoundID_2 END,
ImpactSoundID_3 = CASE WHEN ImpactSoundID_3 IN (0, -1) THEN NULL ELSE ImpactSoundID_3 END,
ImpactSoundID_4 = CASE WHEN ImpactSoundID_4 IN (0, -1) THEN NULL ELSE ImpactSoundID_4 END,
ImpactSoundID_5 = CASE WHEN ImpactSoundID_5 IN (0, -1) THEN NULL ELSE ImpactSoundID_5 END,
ImpactSoundID_6 = CASE WHEN ImpactSoundID_6 IN (0, -1) THEN NULL ELSE ImpactSoundID_6 END,
ImpactSoundID_7 = CASE WHEN ImpactSoundID_7 IN (0, -1) THEN NULL ELSE ImpactSoundID_7 END,
ImpactSoundID_8 = CASE WHEN ImpactSoundID_8 IN (0, -1) THEN NULL ELSE ImpactSoundID_8 END,
ImpactSoundID_9 = CASE WHEN ImpactSoundID_9 IN (0, -1) THEN NULL ELSE ImpactSoundID_9 END,
ImpactSoundID_10 = CASE WHEN ImpactSoundID_10 IN (0, -1) THEN NULL ELSE ImpactSoundID_10 END,
CritImpactSoundID_1 = CASE WHEN CritImpactSoundID_1 IN (0, -1) THEN NULL ELSE CritImpactSoundID_1 END,
CritImpactSoundID_2 = CASE WHEN CritImpactSoundID_2 IN (0, -1) THEN NULL ELSE CritImpactSoundID_2 END,
CritImpactSoundID_3 = CASE WHEN CritImpactSoundID_3 IN (0, -1) THEN NULL ELSE CritImpactSoundID_3 END,
CritImpactSoundID_4 = CASE WHEN CritImpactSoundID_4 IN (0, -1) THEN NULL ELSE CritImpactSoundID_4 END,
CritImpactSoundID_5 = CASE WHEN CritImpactSoundID_5 IN (0, -1) THEN NULL ELSE CritImpactSoundID_5 END,
CritImpactSoundID_6 = CASE WHEN CritImpactSoundID_6 IN (0, -1) THEN NULL ELSE CritImpactSoundID_6 END,
CritImpactSoundID_7 = CASE WHEN CritImpactSoundID_7 IN (0, -1) THEN NULL ELSE CritImpactSoundID_7 END,
CritImpactSoundID_8 = CASE WHEN CritImpactSoundID_8 IN (0, -1) THEN NULL ELSE CritImpactSoundID_8 END,
CritImpactSoundID_9 = CASE WHEN CritImpactSoundID_9 IN (0, -1) THEN NULL ELSE CritImpactSoundID_9 END,
CritImpactSoundID_10 = CASE WHEN CritImpactSoundID_10 IN (0, -1) THEN NULL ELSE CritImpactSoundID_10 END;

UPDATE weaponswingsounds2 SET 
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;

UPDATE weather SET 
AmbienceID = CASE WHEN AmbienceID IN (0, -1) THEN NULL ELSE AmbienceID END;

UPDATE wmoareatable SET 
SoundProviderPref = CASE WHEN SoundProviderPref IN (0, -1) THEN NULL ELSE SoundProviderPref END,
SoundProviderPrefUnderwater = CASE WHEN SoundProviderPrefUnderwater IN (0, -1) THEN NULL ELSE SoundProviderPrefUnderwater END,
AmbienceID = CASE WHEN AmbienceID IN (0, -1) THEN NULL ELSE AmbienceID END,
ZoneMusic = CASE WHEN ZoneMusic IN (0, -1) THEN NULL ELSE ZoneMusic END,
AreaTableID = CASE WHEN AreaTableID IN (0, -1) THEN NULL ELSE AreaTableID END,
IntroSound = CASE WHEN IntroSound IN (0, -1) THEN NULL ELSE IntroSound END;

UPDATE worldmaparea SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
AreaID = CASE WHEN AreaID IN (0, -1) THEN NULL ELSE AreaID END,
DisplayMapID = CASE WHEN DisplayMapID IN (0, -1) THEN NULL ELSE DisplayMapID END,
DefaultDungeonFloor = CASE WHEN DefaultDungeonFloor IN (0, -1) THEN NULL ELSE DefaultDungeonFloor END,
ParentWorldMapID = CASE WHEN ParentWorldMapID IN (0, -1) THEN

 NULL ELSE ParentWorldMapID END;

UPDATE worldmapcontinent SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END;

UPDATE worldmapoverlay SET 
MapAreaID = CASE WHEN MapAreaID IN (0, -1) THEN NULL ELSE MapAreaID END,
AreaID_1 = CASE WHEN AreaID_1 IN (0, -1) THEN NULL ELSE AreaID_1 END,
AreaID_2 = CASE WHEN AreaID_2 IN (0, -1) THEN NULL ELSE AreaID_2 END,
AreaID_3 = CASE WHEN AreaID_3 IN (0, -1) THEN NULL ELSE AreaID_3 END,
AreaID_4 = CASE WHEN AreaID_4 IN (0, -1) THEN NULL ELSE AreaID_4 END;

UPDATE worldmaptransforms SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
NewMapID = CASE WHEN NewMapID IN (0, -1) THEN NULL ELSE NewMapID END,
NewDungeonMapID = CASE WHEN NewDungeonMapID IN (0, -1) THEN NULL ELSE NewDungeonMapID END;

UPDATE worldsafelocs SET 
Continent = CASE WHEN Continent IN (0, -1) THEN NULL ELSE Continent END;

UPDATE worldstateui SET 
MapID = CASE WHEN MapID IN (0, -1) THEN NULL ELSE MapID END,
AreaID = CASE WHEN AreaID IN (0, -1) THEN NULL ELSE AreaID END;

UPDATE worldstatezonesounds SET 
AreaID = CASE WHEN AreaID IN (0, -1) THEN NULL ELSE AreaID END,
WMOAreaID = CASE WHEN WMOAreaID IN (0, -1) THEN NULL ELSE WMOAreaID END,
ZoneintroMusicID = CASE WHEN ZoneintroMusicID IN (0, -1) THEN NULL ELSE ZoneintroMusicID END,
ZoneMusicID = CASE WHEN ZoneMusicID IN (0, -1) THEN NULL ELSE ZoneMusicID END,
SoundAmbienceID = CASE WHEN SoundAmbienceID IN (0, -1) THEN NULL ELSE SoundAmbienceID END,
SoundProviderPreferencesID = CASE WHEN SoundProviderPreferencesID IN (0, -1) THEN NULL ELSE SoundProviderPreferencesID END;

UPDATE zoneintromusictable SET 
SoundID = CASE WHEN SoundID IN (0, -1) THEN NULL ELSE SoundID END;

UPDATE zonemusic SET 
DayMusic = CASE WHEN DayMusic IN (0, -1) THEN NULL ELSE DayMusic END,
NightMusic = CASE WHEN NightMusic IN (0, -1) THEN NULL ELSE NightMusic END;