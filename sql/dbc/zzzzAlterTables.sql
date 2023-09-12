ALTER TABLE achievement
ADD FOREIGN KEY (Instance_Id) REFERENCES map(ID),
ADD FOREIGN KEY (Supercedes) REFERENCES achievement(ID),
ADD FOREIGN KEY (Category) REFERENCES achievement_category(ID),
ADD FOREIGN KEY (IconID) REFERENCES spellicon(ID),
ADD FOREIGN KEY (Shares_Criteria) REFERENCES achievement(ID);

ALTER TABLE achievement_category
ADD FOREIGN KEY (Parent) REFERENCES achievement_category(ID);

ALTER TABLE achievement_criteria
ADD FOREIGN KEY (Achievement_Id) REFERENCES achievement(ID);

ALTER TABLE areagroup
ADD FOREIGN KEY (AreaID_1) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_2) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_3) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_4) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_5) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_6) REFERENCES areatable(ID),
ADD FOREIGN KEY (NextAreaID) REFERENCES areagroup(ID);

ALTER TABLE areapoi
ADD FOREIGN KEY (FactionID) REFERENCES faction(ID),
ADD FOREIGN KEY (AreaID) REFERENCES areatable(ID);

CREATE INDEX idx_wmogroupid ON areatable (WMOGroupID);
ALTER TABLE areatable
ADD FOREIGN KEY (ContinentID) REFERENCES map(ID),
ADD FOREIGN KEY (ParentAreaID) REFERENCES areatable(ID),
ADD FOREIGN KEY (SoundProviderPref) REFERENCES soundproviderpreferences(ID),
ADD FOREIGN KEY (SoundProviderPrefUnderwater) REFERENCES soundproviderpreferences(ID),
ADD FOREIGN KEY (AmbienceID) REFERENCES soundambience(ID),
ADD FOREIGN KEY (ZoneMusic) REFERENCES zonemusic(ID),
ADD FOREIGN KEY (IntroSound) REFERENCES zoneintromusictable(ID),
ADD FOREIGN KEY (LiquidTypeID_1) REFERENCES liquidtype(ID),
ADD FOREIGN KEY (LiquidTypeID_2) REFERENCES liquidtype(ID),
ADD FOREIGN KEY (LiquidTypeID_3) REFERENCES liquidtype(ID),
ADD FOREIGN KEY (LiquidTypeID_4) REFERENCES liquidtype(ID),
ADD FOREIGN KEY (Lightid) REFERENCES light(ID);

ALTER TABLE areatrigger
ADD FOREIGN KEY (ContinentID) REFERENCES map(ID);

ALTER TABLE attackanimkits
ADD FOREIGN KEY (Animation) REFERENCES animationdata(ID),
ADD FOREIGN KEY (Type) REFERENCES attackanimtypes(ID);

ALTER TABLE auctionhouse
ADD FOREIGN KEY (FactionID) REFERENCES faction(ID);


ALTER TABLE battlemasterlist
ADD FOREIGN KEY (MapID_1) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_2) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_3) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_4) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_5) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_6) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_7) REFERENCES map(ID),
ADD FOREIGN KEY (MapID_8) REFERENCES map(ID);

ALTER TABLE charbaseinfo
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID),
ADD FOREIGN KEY (ClassID) REFERENCES chrclasses(ID);

ALTER TABLE charhairgeosets
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID);

ALTER TABLE charhairtextures
ADD FOREIGN KEY (Race) REFERENCES chrraces(ID);

ALTER TABLE charsections
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID);

ALTER TABLE charstartoutfit
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID),
ADD FOREIGN KEY (ClassID) REFERENCES chrclasses(ID);

ALTER TABLE chatchannels
ADD FOREIGN KEY (FactionGroup) REFERENCES factiongroup(ID);

ALTER TABLE chrclasses
ADD FOREIGN KEY (CinematicSequenceID) REFERENCES cinematicsequences(ID);

ALTER TABLE chrraces
ADD FOREIGN KEY (FactionID) REFERENCES factiontemplate(ID),
ADD FOREIGN KEY (ExplorationSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (MaleDisplayId) REFERENCES creaturedisplayinfo(ID),
ADD FOREIGN KEY (FemaleDisplayId) REFERENCES creaturedisplayinfo(ID),
ADD FOREIGN KEY (CreatureType) REFERENCES creaturetype(ID),
ADD FOREIGN KEY (CinematicSequenceID) REFERENCES cinematicsequences(ID);

ALTER TABLE cinematiccamera
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE cinematicsequences
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Camera_1) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_2) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_3) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_4) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_5) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_6) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_7) REFERENCES cinematiccamera(ID),
ADD FOREIGN KEY (Camera_8) REFERENCES cinematiccamera(ID);

ALTER TABLE creaturedisplayinfo
ADD FOREIGN KEY (ModelID) REFERENCES creaturemodeldata(ID),
ADD FOREIGN KEY (SoundID) REFERENCES creaturesounddata(ID),
ADD FOREIGN KEY (ExtendedDisplayInfoID) REFERENCES creaturedisplayinfoextra(ID),
ADD FOREIGN KEY (BloodLevel) REFERENCES unitbloodlevels(ID),
ADD FOREIGN KEY (BloodID) REFERENCES unitblood(ID),
ADD FOREIGN KEY (NPCSoundID) REFERENCES npcsounds(ID),
ADD FOREIGN KEY (ParticleColorID) REFERENCES particlecolor(ID),
ADD FOREIGN KEY (ObjectEffectPackageID) REFERENCES objecteffectpackage(ID);

ALTER TABLE creaturedisplayinfoextra
ADD FOREIGN KEY (DisplayRaceID) REFERENCES chrraces(ID),
ADD FOREIGN KEY (NPCItemDisplay_1) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_2) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_3) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_4) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_5) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_6) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_7) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_8) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_9) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_10) REFERENCES itemdisplayinfo(ID),
ADD FOREIGN KEY (NPCItemDisplay_11) REFERENCES itemdisplayinfo(ID);

ALTER TABLE creaturefamily
ADD FOREIGN KEY (SkillLine_1) REFERENCES skillline(ID),
ADD FOREIGN KEY (SkillLine_2) REFERENCES skillline(ID);

ALTER TABLE creaturemodeldata
ADD FOREIGN KEY (BloodID) REFERENCES unitbloodlevels(ID),
ADD FOREIGN KEY (FootprintTextureID) REFERENCES footprinttextures(ID),
ADD FOREIGN KEY (FootstepShakeSize) REFERENCES camerashakes(ID),
ADD FOREIGN KEY (DeathThudShakeSize) REFERENCES camerashakes(ID),
ADD FOREIGN KEY (SoundID) REFERENCES creaturesounddata(ID);

ALTER TABLE creaturesounddata
ADD FOREIGN KEY (SoundExertionID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundExertionCriticalID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundInjuryID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundInjuryCriticalID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundInjuryCrushingBlowID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundDeathID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundStunID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundStandID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFootstepID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundAggroID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundWingFlapID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundWingGlideID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundAlertID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFidget_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFidget_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFidget_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFidget_4) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundFidget_5) REFERENCES soundentries(ID),
ADD FOREIGN KEY (NPCSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (LoopSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundJumpStartID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundJumpEndID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundPetAttackID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundPetOrderID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundPetDismissID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (BirthSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SpellCastDirectedSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SubmergeSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SubmergedSoundID) REFERENCES soundentries(ID);

ALTER TABLE creaturespelldata
ADD FOREIGN KEY (Spells_1) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_2) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_3) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_4) REFERENCES spell(ID);

ALTER TABLE deaththudlookups
ADD FOREIGN KEY (TerraintypeSoundID) REFERENCES terraintype(ID),
ADD FOREIGN KEY (SoundEntryID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundEntryIDWater) REFERENCES soundentries(ID);

ALTER TABLE declinedwordcases
ADD FOREIGN KEY (DeclinedWordID) REFERENCES declinedword(ID);

ALTER TABLE dungeonencounter
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (Difficulty) REFERENCES mapdifficulty(ID);

ALTER TABLE dungeonmap
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (ParentWorldMapID) REFERENCES worldmaparea(ID);

ALTER TABLE dungeonmapchunk
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (WmoGroupID) REFERENCES wmoareatable(WMOGroupID),
ADD FOREIGN KEY (DungeonMapID) REFERENCES dungeonmap(ID);

ALTER TABLE emotes
ADD FOREIGN KEY (AnimID) REFERENCES animationdata(ID),
ADD FOREIGN KEY (EventSoundID) REFERENCES soundentries(ID);

ALTER TABLE emotestext
ADD FOREIGN KEY (EmoteID) REFERENCES emotes(ID),
ADD FOREIGN KEY (EmoteText_1) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_2) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_3) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_4) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_5) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_6) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_7) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_8) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_9) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_10) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_11) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_12) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_13) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_14) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_15) REFERENCES emotestextdata(ID),
ADD FOREIGN KEY (EmoteText_16) REFERENCES emotestextdata(ID);

ALTER TABLE emotestextsound
ADD FOREIGN KEY (EmotesTextID) REFERENCES emotestext(ID),
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID),
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE environmentaldamage
ADD FOREIGN KEY (VisualkitID) REFERENCES soundentries(ID);

ALTER TABLE faction
ADD FOREIGN KEY (ParentFactionID) REFERENCES faction(ID);

ALTER TABLE factiontemplate
ADD FOREIGN KEY (Faction) REFERENCES faction(ID),
ADD FOREIGN KEY (Enemies_1) REFERENCES faction(ID),
ADD FOREIGN KEY (Enemies_2) REFERENCES faction(ID),
ADD FOREIGN KEY (Enemies_3) REFERENCES faction(ID),
ADD FOREIGN KEY (Enemies_4) REFERENCES faction(ID),
ADD FOREIGN KEY (Friend_1) REFERENCES faction(ID),
ADD FOREIGN KEY (Friend_2) REFERENCES faction(ID),
ADD FOREIGN KEY (Friend_3) REFERENCES faction(ID),
ADD FOREIGN KEY (Friend_4) REFERENCES faction(ID);

ALTER TABLE footstepterrainlookup
ADD FOREIGN KEY (CreatureFootstepID) REFERENCES groundeffectdoodad(ID),
ADD FOREIGN KEY (TerrainSoundID) REFERENCES terraintype(ID),
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundIDSplash) REFERENCES soundentries(ID);

ALTER TABLE gameobjectdisplayinfo
ADD FOREIGN KEY (Sound_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_4) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_5) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_6) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_7) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_8) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_9) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_10) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ObjectEffectPackageID) REFERENCES objecteffectpackage(ID);

ALTER TABLE gemproperties
ADD FOREIGN KEY (Enchant_Id) REFERENCES spellitemenchantment(ID);

ALTER TABLE glyphproperties
ADD FOREIGN KEY (SpellID) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellIconID) REFERENCES spellicon(ID);

ALTER TABLE gmsurveyanswers
ADD FOREIGN KEY (GMSurveyQuestionID) REFERENCES gmsurveyquestions(ID);

ALTER TABLE gmsurveycurrentsurvey
ADD FOREIGN KEY (GMSURVEY_ID) REFERENCES gmsurveysurveys(ID);

ALTER TABLE gmsurveysurveys
ADD FOREIGN KEY (Q_1) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_2) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_3) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_4) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_5) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_6) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_7) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_8) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_9) REFERENCES gmsurveyquestions(ID),
ADD FOREIGN KEY (Q_10) REFERENCES gmsurveyquestions(ID);

ALTER TABLE groundeffecttexture
ADD FOREIGN KEY (DoodadId_1) REFERENCES groundeffectdoodad(ID),
ADD FOREIGN KEY (DoodadId_2) REFERENCES groundeffectdoodad(ID),
ADD FOREIGN KEY (DoodadId_3) REFERENCES groundeffectdoodad(ID),
ADD FOREIGN KEY (DoodadId_4) REFERENCES groundeffectdoodad(ID);

ALTER TABLE holidays
ADD FOREIGN KEY (HolidayNameID) REFERENCES holidaynames(ID),
ADD FOREIGN KEY (HolidayDescriptionID) REFERENCES holidaydescriptions(ID);

ALTER TABLE item
ADD FOREIGN KEY (ClassID) REFERENCES itemclass(ID),
ADD FOREIGN KEY (SubclassID) REFERENCES itemsubclass(ID),
ADD FOREIGN KEY (Material) REFERENCES material(ID),
ADD FOREIGN KEY (DisplayInfoID) REFERENCES itemdisplayinfo(ID);

ALTER TABLE itemdisplayinfo
ADD FOREIGN KEY (GroupSoundIndex) REFERENCES itemgroupsounds(ID),
ADD FOREIGN KEY (HelmetGeosetVis_1) REFERENCES helmetgeosetvisdata(ID),
ADD FOREIGN KEY (HelmetGeosetVis_2) REFERENCES helmetgeosetvisdata(ID),
ADD FOREIGN KEY (ItemVisual) REFERENCES itemvisuals(ID);

ALTER TABLE itemextendedcost
ADD FOREIGN KEY (ItemPurchaseGroup) REFERENCES itempurchasegroup(ID);

ALTER TABLE itemgroupsounds
ADD FOREIGN KEY (Sound_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sound_4) REFERENCES soundentries(ID);

ALTER TABLE itempurchasegroup
ADD FOREIGN KEY (ItemID_1) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_2) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_3) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_4) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_5) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_6) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_7) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_8) REFERENCES item(ID);

ALTER TABLE itemrandomproperties
ADD FOREIGN KEY (Enchantment_1) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_2) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_3) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_4) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_5) REFERENCES spellitemenchantment(ID);

ALTER TABLE itemrandomsuffix
ADD FOREIGN KEY (Enchantment_1) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_2) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_3) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_4) REFERENCES spellitemenchantment(ID),
ADD FOREIGN KEY (Enchantment_5) REFERENCES spellitemenchantment(ID);

ALTER TABLE itemset
ADD FOREIGN KEY (ItemID_1) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_2) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_3) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_4) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_5) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_6) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_7) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_8) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_9) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_10) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_11) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_12) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_13) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_14) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_15) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_16) REFERENCES item(ID),
ADD FOREIGN KEY (ItemID_17) REFERENCES item(ID),
ADD FOREIGN KEY (SetSpellID_1) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_2) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_3) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_4) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_5) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_6) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_7) REFERENCES spell(ID),
ADD FOREIGN KEY (SetSpellID_8) REFERENCES spell(ID),
ADD FOREIGN KEY (RequiredSkill) REFERENCES skillline(ID);

ALTER TABLE itemvisuals
ADD FOREIGN KEY (Slot_1) REFERENCES itemvisualeffects(ID),
ADD FOREIGN KEY (Slot_2) REFERENCES itemvisualeffects(ID),
ADD FOREIGN KEY (Slot_3) REFERENCES itemvisualeffects(ID),
ADD FOREIGN KEY (Slot_4) REFERENCES itemvisualeffects(ID),
ADD FOREIGN KEY (Slot_5) REFERENCES itemvisualeffects(ID);

ALTER TABLE languagewords
ADD FOREIGN KEY (LanguageID) REFERENCES languages(ID);

ALTER TABLE lfgdungeonexpansion
ADD FOREIGN KEY (Lfg_Id) REFERENCES lfgdungeons(ID);

ALTER TABLE lfgdungeons
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (Faction) REFERENCES faction(ID);

ALTER TABLE lightparams
ADD FOREIGN KEY (LightSkyboxID) REFERENCES lightskybox(ID);

ALTER TABLE loadingscreentaxisplines
ADD FOREIGN KEY (PathID) REFERENCES taxipath(ID);

ALTER TABLE `lock`
ADD FOREIGN KEY (Type_1) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_2) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_3) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_4) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_5) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_6) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_7) REFERENCES locktype(ID),
ADD FOREIGN KEY (Type_8) REFERENCES locktype(ID);

ALTER TABLE map
ADD FOREIGN KEY (AreaTableID) REFERENCES areatable(ID),
ADD FOREIGN KEY (LoadingScreenID) REFERENCES loadingscreens(ID),
ADD FOREIGN KEY (CorpseMapID) REFERENCES map(ID);

ALTER TABLE mapdifficulty
ADD FOREIGN KEY (MapID) REFERENCES map(ID);

ALTER TABLE material
ADD FOREIGN KEY (FoleySoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SheatheSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (UnsheatheSoundID) REFERENCES soundentries(ID);

ALTER TABLE namegen
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID);

ALTER TABLE npcsounds
ADD FOREIGN KEY (SoundID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundID_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundID_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (SoundID_4) REFERENCES soundentries(ID);

ALTER TABLE objecteffect
ADD FOREIGN KEY (ObjectEffectGroupID) REFERENCES objecteffectgroup(ID),
ADD FOREIGN KEY (ObjectEffectModifierID) REFERENCES objecteffectmodifier(ID);

ALTER TABLE objecteffectpackageelem
ADD FOREIGN KEY (ObjectEffectGroupID) REFERENCES objecteffectgroup(ID),
ADD FOREIGN KEY (ObjectEffectPackageID) REFERENCES objecteffectpackage(ID);

ALTER TABLE overridespelldata
ADD FOREIGN KEY (Spells_1) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_2) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_3) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_4) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_5) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_6) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_7) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_8) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_9) REFERENCES spell(ID),
ADD FOREIGN KEY (Spells_10) REFERENCES spell(ID);

ALTER TABLE pvpdifficulty
ADD FOREIGN KEY (MapID) REFERENCES map(ID);

ALTER TABLE sheathesoundlookups
ADD FOREIGN KEY (ItemClass) REFERENCES itemsubclass(ID),
ADD FOREIGN KEY (ItemSubclass) REFERENCES itemsubclass(ID),
ADD FOREIGN KEY (SheathSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (UnsheathSoundID) REFERENCES soundentries(ID);

ALTER TABLE skillline
ADD FOREIGN KEY (CategoryID) REFERENCES skilllinecategory(ID),
ADD FOREIGN KEY (SkillCostsID) REFERENCES skillcostsdata(ID),
ADD FOREIGN KEY (SpellIconID) REFERENCES spellicon(ID);

ALTER TABLE skilllineability
ADD FOREIGN KEY (SkillLine) REFERENCES skillline(ID),
ADD FOREIGN KEY (Spell) REFERENCES spell(ID);

ALTER TABLE skillraceclassinfo
ADD FOREIGN KEY (SkillID) REFERENCES skillline(ID),
ADD FOREIGN KEY (SkillTierID) REFERENCES skilltiers(ID),
ADD FOREIGN KEY (SkillCostIndex) REFERENCES skillcostsdata(ID);

ALTER TABLE soundambience
ADD FOREIGN KEY (AmbienceID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (AmbienceID_2) REFERENCES soundentries(ID);

ALTER TABLE soundemitters
ADD FOREIGN KEY (SoundEntriesID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (MapID) REFERENCES map(ID);

ALTER TABLE soundentries
ADD FOREIGN KEY (SoundEntriesAdvancedID) REFERENCES soundentriesadvanced(ID);

ALTER TABLE soundentriesadvanced
ADD FOREIGN KEY (SoundEntryID) REFERENCES soundentries(ID);

ALTER TABLE soundwatertype
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE spell
ADD FOREIGN KEY (Category) REFERENCES spellcategory(ID),
ADD FOREIGN KEY (DispelType) REFERENCES spelldispeltype(ID),
ADD FOREIGN KEY (Mechanic) REFERENCES spellmechanic(ID),
ADD FOREIGN KEY (RequiresSpellFocus) REFERENCES spellfocusobject(ID),
ADD FOREIGN KEY (CastingTimeIndex) REFERENCES spellcasttimes(ID),
ADD FOREIGN KEY (DurationIndex) REFERENCES spellduration(ID),
ADD FOREIGN KEY (RangeIndex) REFERENCES spellrange(ID),
ADD FOREIGN KEY (EffectMechanic_1) REFERENCES spellmechanic(ID),
ADD FOREIGN KEY (EffectMechanic_2) REFERENCES spellmechanic(ID),
ADD FOREIGN KEY (EffectMechanic_3) REFERENCES spellmechanic(ID),
ADD FOREIGN KEY (EffectRadiusIndex_1) REFERENCES spellradius(ID),
ADD FOREIGN KEY (EffectRadiusIndex_2) REFERENCES spellradius(ID),
ADD FOREIGN KEY (EffectRadiusIndex_3) REFERENCES spellradius(ID),
ADD FOREIGN KEY (RequiredTotemCategoryID_1) REFERENCES totemcategory(ID),
ADD FOREIGN KEY (RequiredTotemCategoryID_2) REFERENCES totemcategory(ID),
ADD FOREIGN KEY (Reagent_1) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_2) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_3) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_4) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_5) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_6) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_7) REFERENCES item(ID),
ADD FOREIGN KEY (Reagent_8) REFERENCES item(ID),
ADD FOREIGN KEY (SpellVisualID_1) REFERENCES spellvisual(ID),
ADD FOREIGN KEY (SpellVisualID_2) REFERENCES spellvisual(ID),
ADD FOREIGN KEY (SpellIconID) REFERENCES spellicon(ID),
ADD FOREIGN KEY (ActiveIconID) REFERENCES spellicon(ID),
ADD FOREIGN KEY (RequiredAreasID) REFERENCES areagroup(ID),
ADD FOREIGN KEY (RuneCostID) REFERENCES spellrunecost(ID),
ADD FOREIGN KEY (SpellMissileID) REFERENCES spellmissile(ID),
ADD FOREIGN KEY (SpellDescriptionVariableID) REFERENCES spelldescriptionvariables(ID),
ADD FOREIGN KEY (SpellDifficultyID) REFERENCES spelldifficulty(ID),
ADD FOREIGN KEY (PowerDisplayID) REFERENCES powerdisplay(ID);

ALTER TABLE spelldifficulty
ADD FOREIGN KEY (DifficultySpellID_1) REFERENCES spell(ID),
ADD FOREIGN KEY (DifficultySpellID_2) REFERENCES spell(ID),
ADD FOREIGN KEY (DifficultySpellID_3) REFERENCES spell(ID),
ADD FOREIGN KEY (DifficultySpellID_4) REFERENCES spell(ID);

ALTER TABLE spelleffectcamerashakes
ADD FOREIGN KEY (CameraShake_1) REFERENCES camerashakes(ID),
ADD FOREIGN KEY (CameraShake_2) REFERENCES camerashakes(ID),
ADD FOREIGN KEY (CameraShake_3) REFERENCES camerashakes(ID);

ALTER TABLE spellitemenchantment
  ADD FOREIGN KEY (Effect_1) REFERENCES spelldispeltype(ID),
  ADD FOREIGN KEY (Effect_2) REFERENCES spelldispeltype(ID),
  ADD FOREIGN KEY (Effect_3) REFERENCES spelldispeltype(ID),
  ADD FOREIGN KEY (ItemVisual) REFERENCES itemvisuals(ID),
  ADD FOREIGN KEY (Src_ItemID) REFERENCES item(ID),
  ADD FOREIGN KEY (Condition_Id) REFERENCES spellitemenchantmentcondition(ID),
  ADD FOREIGN KEY (RequiredSkillID) REFERENCES skillline(ID);

ALTER TABLE spellshapeshiftform
  ADD FOREIGN KEY (CreatureType) REFERENCES creaturetype(ID),
  ADD FOREIGN KEY (AttackIconID) REFERENCES spellicon(ID), 
  ADD FOREIGN KEY (CreatureDisplayID_1) REFERENCES creaturedisplayinfo(ID),
  ADD FOREIGN KEY (CreatureDisplayID_2) REFERENCES creaturedisplayinfo(ID),
  ADD FOREIGN KEY (CreatureDisplayID_3) REFERENCES creaturedisplayinfo(ID),
  ADD FOREIGN KEY (CreatureDisplayID_4) REFERENCES creaturedisplayinfo(ID),
  ADD FOREIGN KEY (PresetSpellID_1) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_2) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_3) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_4) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_5) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_6) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_7) REFERENCES spell(ID),
  ADD FOREIGN KEY (PresetSpellID_8) REFERENCES spell(ID);

ALTER TABLE spellvisual
ADD FOREIGN KEY (PrecastKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (CastKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (ImpactKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (StateKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (StateDoneKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (ChannelKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (MissileModel) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (MissileSound) REFERENCES soundentries(ID),
ADD FOREIGN KEY (AnimEventSoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CasterImpactKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (TargetImpactKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (MissileTargetingKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (InstantAreaKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (ImpactAreaKit) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (PersistentAreaKit) REFERENCES spellvisualkit(ID);

ALTER TABLE spellvisualkit
ADD FOREIGN KEY (StartAnimID) REFERENCES animationdata(ID),
ADD FOREIGN KEY (AnimID) REFERENCES animationdata(ID),
ADD FOREIGN KEY (HeadEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (ChestEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (BaseEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (LeftHandEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (RightHandEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (BreathEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (LeftWeaponEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (RightWeaponEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (SpecialEffect_1) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (SpecialEffect_2) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (SpecialEffect_3) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (WorldEffect) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ShakeID) REFERENCES spelleffectcamerashakes(ID);

ALTER TABLE spellvisualkitmodelattach
ADD FOREIGN KEY (ParentSpellVisualKitID) REFERENCES spellvisualkit(ID),
ADD FOREIGN KEY (SpellVisualEffectNameID) REFERENCES spellvisualeffectname(ID);

ALTER TABLE stationery
ADD FOREIGN KEY (ItemID) REFERENCES item(ID);

ALTER TABLE talent
ADD FOREIGN KEY (TabID) REFERENCES talenttab(ID),
ADD FOREIGN KEY (SpellRank_1) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_2) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_3) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_4) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_5) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_6) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_7) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_8) REFERENCES spell(ID),
ADD FOREIGN KEY (SpellRank_9) REFERENCES spell(ID),
ADD FOREIGN KEY (RequiredSpellID) REFERENCES spell(ID);

ALTER TABLE talenttab
ADD FOREIGN KEY (SpellIconID) REFERENCES spellicon(ID);

ALTER TABLE taxinodes
ADD FOREIGN KEY (ContinentID) REFERENCES map(ID);

ALTER TABLE taxipath
ADD FOREIGN KEY (FromTaxiNode) REFERENCES taxinodes(ID),
ADD FOREIGN KEY (ToTaxiNode) REFERENCES taxinodes(ID);

ALTER TABLE taxipathnode
ADD FOREIGN KEY (PathID) REFERENCES taxipath(ID),
ADD FOREIGN KEY (ContinentID) REFERENCES map(ID);

ALTER TABLE terraintype
ADD FOREIGN KEY (FootstepSprayRun) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (FootstepSprayWalk) REFERENCES spellvisualeffectname(ID),
ADD FOREIGN KEY (SoundID) REFERENCES terraintypesounds(ID);

ALTER TABLE transportanimation
ADD FOREIGN KEY (SequenceID) REFERENCES animationdata(ID);

ALTER TABLE uisoundlookups
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE vehicle
ADD FOREIGN KEY (PowerDisplayID_1) REFERENCES powerdisplay(ID),
ADD FOREIGN KEY (PowerDisplayID_2) REFERENCES powerdisplay(ID),
ADD FOREIGN KEY (PowerDisplayID_3) REFERENCES powerdisplay(ID);

ALTER TABLE vehicleuiindseat
ADD FOREIGN KEY (VehicleUIIndicatorID) REFERENCES vehicleuiindicator(ID);

ALTER TABLE vocaluisounds
ADD FOREIGN KEY (RaceID) REFERENCES chrraces(ID),
ADD FOREIGN KEY (NormalSoundID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (NormalSoundID_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (PissedSoundID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (PissedSoundID_2) REFERENCES soundentries(ID);

ALTER TABLE weaponimpactsounds
ADD FOREIGN KEY (ImpactSoundID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_4) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_5) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_6) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_7) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_8) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_9) REFERENCES soundentries(ID),
ADD FOREIGN KEY (ImpactSoundID_10) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_2) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_3) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_4) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_5) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_6) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_7) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_8) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_9) REFERENCES soundentries(ID),
ADD FOREIGN KEY (CritImpactSoundID_10) REFERENCES soundentries(ID);

ALTER TABLE weaponswingsounds2
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE weather
ADD FOREIGN KEY (AmbienceID) REFERENCES soundentries(ID);

ALTER TABLE wmoareatable
  ADD FOREIGN KEY (SoundProviderPref) REFERENCES soundproviderpreferences(ID),
  ADD FOREIGN KEY (SoundProviderPrefUnderwater) REFERENCES soundproviderpreferences(ID),
  ADD FOREIGN KEY (AmbienceID) REFERENCES soundambience(ID),
  ADD FOREIGN KEY (ZoneMusic) REFERENCES zonemusic(ID),
  ADD FOREIGN KEY (AreaTableID) REFERENCES areatable(ID),
  ADD FOREIGN KEY (IntroSound) REFERENCES zoneintromusictable(ID);

ALTER TABLE worldmaparea
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (AreaID) REFERENCES areatable(ID),
ADD FOREIGN KEY (DisplayMapID) REFERENCES map(ID),
ADD FOREIGN KEY (DefaultDungeonFloor) REFERENCES dungeonmap(ID),
ADD FOREIGN KEY (ParentWorldMapID) REFERENCES worldmaparea(ID);

ALTER TABLE worldmapcontinent
ADD FOREIGN KEY (MapID) REFERENCES map(ID);

ALTER TABLE worldmapoverlay
ADD FOREIGN KEY (MapAreaID) REFERENCES worldmaparea(ID),
ADD FOREIGN KEY (AreaID_1) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_2) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_3) REFERENCES areatable(ID),
ADD FOREIGN KEY (AreaID_4) REFERENCES areatable(ID);

ALTER TABLE worldmaptransforms
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (NewMapID) REFERENCES map(ID),
ADD FOREIGN KEY (NewDungeonMapID) REFERENCES dungeonmap(ID);

ALTER TABLE worldsafelocs
ADD FOREIGN KEY (Continent) REFERENCES map(ID);

ALTER TABLE worldstateui
ADD FOREIGN KEY (MapID) REFERENCES map(ID),
ADD FOREIGN KEY (AreaID) REFERENCES areatable(ID);

ALTER TABLE worldstatezonesounds
ADD FOREIGN KEY (AreaID) REFERENCES areatable(ID),
ADD FOREIGN KEY (WMOAreaID) REFERENCES wmoareatable(ID),
ADD FOREIGN KEY (ZoneintroMusicID) REFERENCES zoneintromusictable(ID),
ADD FOREIGN KEY (ZoneMusicID) REFERENCES zonemusic(ID),
ADD FOREIGN KEY (SoundAmbienceID) REFERENCES soundambience(ID),
ADD FOREIGN KEY (SoundProviderPreferencesID) REFERENCES soundproviderpreferences(ID);

ALTER TABLE zoneintromusictable
ADD FOREIGN KEY (SoundID) REFERENCES soundentries(ID);

ALTER TABLE zonemusic
ADD FOREIGN KEY (Sounds_1) REFERENCES soundentries(ID),
ADD FOREIGN KEY (Sounds_2) REFERENCES soundentries(ID);
