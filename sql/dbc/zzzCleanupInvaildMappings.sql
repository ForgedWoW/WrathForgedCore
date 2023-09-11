UPDATE achievement a
LEFT JOIN map m ON a.Instance_Id = m.ID
LEFT JOIN achievement ac1 ON a.Supercedes = ac1.ID
LEFT JOIN achievement_category ac2 ON a.Category = ac2.ID
LEFT JOIN spellicon s ON a.IconID = s.ID
LEFT JOIN achievement ac3 ON a.Shares_Criteria = ac3.ID
SET 
a.Instance_Id = CASE WHEN a.Instance_Id IS NOT NULL AND m.ID IS NULL THEN NULL ELSE a.Instance_Id END,
a.Supercedes = CASE WHEN a.Supercedes IS NOT NULL AND ac1.ID IS NULL THEN NULL ELSE a.Supercedes END,
a.Category = CASE WHEN a.Category IS NOT NULL AND ac2.ID IS NULL THEN NULL ELSE a.Category END,
a.IconID = CASE WHEN a.IconID IS NOT NULL AND s.ID IS NULL THEN NULL ELSE a.IconID END,
a.Shares_Criteria = CASE WHEN a.Shares_Criteria IS NOT NULL AND ac3.ID IS NULL THEN NULL ELSE a.Shares_Criteria END;

UPDATE achievement_category ac
LEFT JOIN achievement_category ac1 ON ac.Parent = ac1.ID
SET 
ac.Parent = CASE WHEN ac.Parent IS NOT NULL AND ac1.ID IS NULL THEN NULL ELSE ac.Parent END;

UPDATE achievement_criteria ac
LEFT JOIN achievement a ON ac.Achievement_Id = a.ID
SET 
ac.Achievement_Id = CASE WHEN ac.Achievement_Id IS NOT NULL AND a.ID IS NULL THEN NULL ELSE ac.Achievement_Id END;

UPDATE areagroup ag
LEFT JOIN areatable at1 ON ag.AreaID_1 = at1.ID
LEFT JOIN areatable at2 ON ag.AreaID_2 = at2.ID
LEFT JOIN areatable at3 ON ag.AreaID_3 = at3.ID
LEFT JOIN areatable at4 ON ag.AreaID_4 = at4.ID
LEFT JOIN areatable at5 ON ag.AreaID_5 = at5.ID
LEFT JOIN areatable at6 ON ag.AreaID_6 = at6.ID
LEFT JOIN areagroup ag1 ON ag.NextAreaID = ag1.ID
SET 
ag.AreaID_1 = CASE WHEN ag.AreaID_1 IS NOT NULL AND at1.ID IS NULL THEN NULL ELSE ag.AreaID_1 END,
ag.AreaID_2 = CASE WHEN ag.AreaID_2 IS NOT NULL AND at2.ID IS NULL THEN NULL ELSE ag.AreaID_2 END,
ag.AreaID_3 = CASE WHEN ag.AreaID_3 IS NOT NULL AND at3.ID IS NULL THEN NULL ELSE ag.AreaID_3 END,
ag.AreaID_4 = CASE WHEN ag.AreaID_4 IS NOT NULL AND at4.ID IS NULL THEN NULL ELSE ag.AreaID_4 END,
ag.AreaID_5 = CASE WHEN ag.AreaID_5 IS NOT NULL AND at5.ID IS NULL THEN NULL ELSE ag.AreaID_5 END,
ag.AreaID_6 = CASE WHEN ag.AreaID_6 IS NOT NULL AND at6.ID IS NULL THEN NULL ELSE ag.AreaID_6 END,
ag.NextAreaID = CASE WHEN ag.NextAreaID IS NOT NULL AND ag1.ID IS NULL THEN NULL ELSE ag.NextAreaID END;

UPDATE areapoi ap
LEFT JOIN areatable at ON ap.AreaID = at.ID
SET 
ap.AreaID = CASE WHEN ap.AreaID IS NOT NULL AND at.ID IS NULL THEN NULL ELSE ap.AreaID END;

-- For areatable
UPDATE areatable a
LEFT JOIN map m1 ON a.ContinentID = m1.ID
LEFT JOIN areatable a1 ON a.ParentAreaID = a1.ID
LEFT JOIN soundproviderpreferences spp1 ON a.SoundProviderPref = spp1.ID
LEFT JOIN soundproviderpreferences spp2 ON a.SoundProviderPrefUnderwater = spp2.ID
LEFT JOIN soundambience sa ON a.AmbienceID = sa.ID
LEFT JOIN zonemusic zm ON a.ZoneMusic = zm.ID
LEFT JOIN zoneintromusictable zimt ON a.IntroSound = zimt.ID
LEFT JOIN liquidtype lt1 ON a.LiquidTypeID_1 = lt1.ID
LEFT JOIN liquidtype lt2 ON a.LiquidTypeID_2 = lt2.ID
LEFT JOIN liquidtype lt3 ON a.LiquidTypeID_3 = lt3.ID
LEFT JOIN liquidtype lt4 ON a.LiquidTypeID_4 = lt4.ID
LEFT JOIN light l ON a.Lightid = l.ID
SET 
a.ContinentID = IF(a.ContinentID IS NOT NULL AND m1.ID IS NULL, NULL, a.ContinentID),
a.ParentAreaID = IF(a.ParentAreaID IS NOT NULL AND a1.ID IS NULL, NULL, a.ParentAreaID),
a.SoundProviderPref = IF(a.SoundProviderPref IS NOT NULL AND spp1.ID IS NULL, NULL, a.SoundProviderPref),
a.SoundProviderPrefUnderwater = IF(a.SoundProviderPrefUnderwater IS NOT NULL AND spp2.ID IS NULL, NULL, a.SoundProviderPrefUnderwater),
a.AmbienceID = IF(a.AmbienceID IS NOT NULL AND sa.ID IS NULL, NULL, a.AmbienceID),
a.ZoneMusic = IF(a.ZoneMusic IS NOT NULL AND zm.ID IS NULL, NULL, a.ZoneMusic),
a.IntroSound = IF(a.IntroSound IS NOT NULL AND zimt.ID IS NULL, NULL, a.IntroSound),
a.LiquidTypeID_1 = IF(a.LiquidTypeID_1 IS NOT NULL AND lt1.ID IS NULL, NULL, a.LiquidTypeID_1),
a.LiquidTypeID_2 = IF(a.LiquidTypeID_2 IS NOT NULL AND lt2.ID IS NULL, NULL, a.LiquidTypeID_2),
a.LiquidTypeID_3 = IF(a.LiquidTypeID_3 IS NOT NULL AND lt3.ID IS NULL, NULL, a.LiquidTypeID_3),
a.LiquidTypeID_4 = IF(a.LiquidTypeID_4 IS NOT NULL AND lt4.ID IS NULL, NULL, a.LiquidTypeID_4),
a.Lightid = IF(a.Lightid IS NOT NULL AND l.ID IS NULL, NULL, a.Lightid);

-- For areatrigger
UPDATE areatrigger at
LEFT JOIN map m ON at.ContinentID = m.ID
SET 
at.ContinentID = IF(at.ContinentID IS NOT NULL AND m.ID IS NULL, NULL, at.ContinentID);

-- For attackanimkits
UPDATE attackanimkits aa
LEFT JOIN animationdata ad ON aa.Animation = ad.ID
LEFT JOIN attackanimtypes aat ON aa.Type = aat.ID
SET 
aa.Animation = IF(aa.Animation IS NOT NULL AND ad.ID IS NULL, NULL, aa.Animation),
aa.Type = IF(aa.Type IS NOT NULL AND aat.ID IS NULL, NULL, aa.Type);

-- For auctionhouse
UPDATE auctionhouse ah
LEFT JOIN faction f ON ah.FactionID = f.ID
SET 
ah.FactionID = IF(ah.FactionID IS NOT NULL AND f.ID IS NULL, NULL, ah.FactionID);

-- For battlemasterlist
UPDATE battlemasterlist b
LEFT JOIN map m1 ON b.MapID_1 = m1.ID
LEFT JOIN map m2 ON b.MapID_2 = m2.ID
LEFT JOIN map m3 ON b.MapID_3 = m3.ID
LEFT JOIN map m4 ON b.MapID_4 = m4.ID
LEFT JOIN map m5 ON b.MapID_5 = m5.ID
LEFT JOIN map m6 ON b.MapID_6 = m6.ID
LEFT JOIN map m7 ON b.MapID_7 = m7.ID
LEFT JOIN map m8 ON b.MapID_8 = m8.ID
SET 
b.MapID_1 = IF(b.MapID_1 IS NOT NULL AND m1.ID IS NULL, NULL, b.MapID_1),
b.MapID_2 = IF(b.MapID_2 IS NOT NULL AND m2.ID IS NULL, NULL, b.MapID_2),
b.MapID_3 = IF(b.MapID_3 IS NOT NULL AND m3.ID IS NULL, NULL, b.MapID_3),
b.MapID_4 = IF(b.MapID_4 IS NOT NULL AND m4.ID IS NULL, NULL, b.MapID_4),
b.MapID_5 = IF(b.MapID_5 IS NOT NULL AND m5.ID IS NULL, NULL, b.MapID_5),
b.MapID_6 = IF(b.MapID_6 IS NOT NULL AND m6.ID IS NULL, NULL, b.MapID_6),
b.MapID_7 = IF(b.MapID_7 IS NOT NULL AND m7.ID IS NULL, NULL, b.MapID_7),
b.MapID_8 = IF(b.MapID_8 IS NOT NULL AND m8.ID IS NULL, NULL, b.MapID_8);

-- For charbaseinfo
UPDATE charbaseinfo cb
LEFT JOIN chrraces cr ON cb.RaceID = cr.ID
LEFT JOIN chrclasses cc ON cb.ClassID = cc.ID
SET 
cb.RaceID = IF(cb.RaceID IS NOT NULL AND cr.ID IS NULL, NULL, cb.RaceID),
cb.ClassID = IF(cb.ClassID IS NOT NULL AND cc.ID IS NULL, NULL, cb.ClassID);

-- For charhairgeosets
UPDATE charhairgeosets chg
LEFT JOIN chrraces cr ON chg.RaceID = cr.ID
SET 
chg.RaceID = IF(chg.RaceID IS NOT NULL AND cr.ID IS NULL, NULL, chg.RaceID);

-- For charhairtextures
UPDATE charhairtextures cht
LEFT JOIN chrraces cr ON cht.Race = cr.ID
SET 
cht.Race = IF(cht.Race IS NOT NULL AND cr.ID IS NULL, NULL, cht.Race);

-- For charsections
UPDATE charsections cs
LEFT JOIN chrraces cr ON cs.RaceID = cr.ID
SET 
cs.RaceID = IF(cs.RaceID IS NOT NULL AND cr.ID IS NULL, NULL, cs.RaceID);

-- For charstartoutfit
UPDATE charstartoutfit cso
LEFT JOIN chrraces cr ON cso.RaceID = cr.ID
LEFT JOIN chrclasses cc ON cso.ClassID = cc.ID
SET 
cso.RaceID = IF(cso.RaceID IS NOT NULL AND cr.ID IS NULL, NULL, cso.RaceID),
cso.ClassID = IF(cso.ClassID IS NOT NULL AND cc.ID IS NULL, NULL, cso.ClassID);

-- For chatchannels
UPDATE chatchannels cc
LEFT JOIN factiongroup fg ON cc.FactionGroup = fg.ID
SET 
cc.FactionGroup = IF(cc.FactionGroup IS NOT NULL AND fg.ID IS NULL, NULL, cc.FactionGroup);

-- For chrclasses
UPDATE chrclasses cc
LEFT JOIN cinematicsequences c ON cc.CinematicSequenceID = c.ID
SET 
cc.CinematicSequenceID = IF(cc.CinematicSequenceID IS NOT NULL AND c.ID IS NULL, NULL, cc.CinematicSequenceID);

-- For chrraces
UPDATE chrraces cr
LEFT JOIN factiontemplate ft ON cr.FactionID = ft.ID
LEFT JOIN soundentries se ON cr.ExplorationSoundID = se.ID
LEFT JOIN creaturedisplayinfo cdi1 ON cr.MaleDisplayId = cdi1.ID
LEFT JOIN creaturedisplayinfo cdi2 ON cr.FemaleDisplayId = cdi2.ID
LEFT JOIN creaturetype ct ON cr.CreatureType = ct.ID
LEFT JOIN cinematicsequences cs ON cr.CinematicSequenceID = cs.ID
SET 
cr.FactionID = IF(cr.FactionID IS NOT NULL AND ft.ID IS NULL, NULL, cr.FactionID),
cr.ExplorationSoundID = IF(cr.ExplorationSoundID IS NOT NULL AND se.ID IS NULL, NULL, cr.ExplorationSoundID),
cr.MaleDisplayId = IF(cr.MaleDisplayId IS NOT NULL AND cdi1.ID IS NULL, NULL, cr.MaleDisplayId),
cr.FemaleDisplayId = IF(cr.FemaleDisplayId IS NOT NULL AND cdi2.ID IS NULL, NULL, cr.FemaleDisplayId),
cr.CreatureType = IF(cr.CreatureType IS NOT NULL AND ct.ID IS NULL, NULL, cr.CreatureType),
cr.CinematicSequenceID = IF(cr.CinematicSequenceID IS NOT NULL AND cs.ID IS NULL, NULL, cr.CinematicSequenceID);

-- For cinematiccamera
UPDATE cinematiccamera cc
LEFT JOIN soundentries se ON cc.SoundID = se.ID
SET 
cc.SoundID = IF(cc.SoundID IS NOT NULL AND se.ID IS NULL, NULL, cc.SoundID);

-- For cinematicsequences
UPDATE cinematicsequences cs
LEFT JOIN soundentries se ON cs.SoundID = se.ID
LEFT JOIN cinematiccamera c1 ON cs.Camera_1 = c1.ID
LEFT JOIN cinematiccamera c2 ON cs.Camera_2 = c2.ID
LEFT JOIN cinematiccamera c3 ON cs.Camera_3 = c3.ID
LEFT JOIN cinematiccamera c4 ON cs.Camera_4 = c4.ID
LEFT JOIN cinematiccamera c5 ON cs.Camera_5 = c5.ID
LEFT JOIN cinematiccamera c6 ON cs.Camera_6 = c6.ID
LEFT JOIN cinematiccamera c7 ON cs.Camera_7 = c7.ID
LEFT JOIN cinematiccamera c8 ON cs.Camera_8 = c8.ID
SET 
cs.SoundID = IF(cs.SoundID IS NOT NULL AND se.ID IS NULL, NULL, cs.SoundID),
cs.Camera_1 = IF(cs.Camera_1 IS NOT NULL AND c1.ID IS NULL, NULL, cs.Camera_1),
cs.Camera_2 = IF(cs.Camera_2 IS NOT NULL AND c2.ID IS NULL, NULL, cs.Camera_2),
cs.Camera_3 = IF(cs.Camera_3 IS NOT NULL AND c3.ID IS NULL, NULL, cs.Camera_3),
cs.Camera_4 = IF(cs.Camera_4 IS NOT NULL AND c4.ID IS NULL, NULL, cs.Camera_4),
cs.Camera_5 = IF(cs.Camera_5 IS NOT NULL AND c5.ID IS NULL, NULL, cs.Camera_5),
cs.Camera_6 = IF(cs.Camera_6 IS NOT NULL AND c6.ID IS NULL, NULL, cs.Camera_6),
cs.Camera_7 = IF(cs.Camera_7 IS NOT NULL AND c7.ID IS NULL, NULL, cs.Camera_7),
cs.Camera_8 = IF(cs.Camera_8 IS NOT NULL AND c8.ID IS NULL, NULL, cs.Camera_8);

-- For creaturedisplayinfo
UPDATE creaturedisplayinfo cdi
LEFT JOIN creaturemodeldata cmd ON cdi.ModelID = cmd.ID
LEFT JOIN creaturesounddata csd ON cdi.SoundID = csd.ID
LEFT JOIN creaturedisplayinfoextra cdie ON cdi.ExtendedDisplayInfoID = cdie.ID
LEFT JOIN unitbloodlevels ubl ON cdi.BloodLevel = ubl.ID
LEFT JOIN unitblood ub ON cdi.BloodID = ub.ID
LEFT JOIN npcsounds ns ON cdi.NPCSoundID = ns.ID
LEFT JOIN particlecolor pc ON cdi.ParticleColorID = pc.ID
LEFT JOIN objecteffectpackage oep ON cdi.ObjectEffectPackageID = oep.ID
SET 
cdi.ModelID = IF(cdi.ModelID IS NOT NULL AND cmd.ID IS NULL, NULL, cdi.ModelID),
cdi.SoundID = IF(cdi.SoundID IS NOT NULL AND csd.ID IS NULL, NULL, cdi.SoundID),
cdi.ExtendedDisplayInfoID = IF(cdi.ExtendedDisplayInfoID IS NOT NULL AND cdie.ID IS NULL, NULL, cdi.ExtendedDisplayInfoID),
cdi.BloodLevel = IF(cdi.BloodLevel IS NOT NULL AND ubl.ID IS NULL, NULL, cdi.BloodLevel),
cdi.BloodID = IF(cdi.BloodID IS NOT NULL AND ub.ID IS NULL, NULL, cdi.BloodID),
cdi.NPCSoundID = IF(cdi.NPCSoundID IS NOT NULL AND ns.ID IS NULL, NULL, cdi.NPCSoundID),
cdi.ParticleColorID = IF(cdi.ParticleColorID IS NOT NULL AND pc.ID IS NULL, NULL, cdi.ParticleColorID),
cdi.ObjectEffectPackageID = IF(cdi.ObjectEffectPackageID IS NOT NULL AND oep.ID IS NULL, NULL, cdi.ObjectEffectPackageID);

-- For creaturefamily
UPDATE creaturefamily cf
LEFT JOIN skillline sl1 ON cf.SkillLine_1 = sl1.ID
LEFT JOIN skillline sl2 ON cf.SkillLine_2 = sl2.ID
SET 
cf.SkillLine_1 = IF(cf.SkillLine_1 IS NOT NULL AND sl1.ID IS NULL, NULL, cf.SkillLine_1),
cf.SkillLine_2 = IF(cf.SkillLine_2 IS NOT NULL AND sl2.ID IS NULL, NULL, cf.SkillLine_2);

-- For creaturemodeldata
UPDATE creaturemodeldata cmd
LEFT JOIN unitbloodlevels ubl ON cmd.BloodID = ubl.ID
LEFT JOIN footprinttextures ft ON cmd.FootprintTextureID = ft.ID
LEFT JOIN camerashakes cs1 ON cmd.FootstepShakeSize = cs1.ID
LEFT JOIN camerashakes cs2 ON cmd.DeathThudShakeSize = cs2.ID
LEFT JOIN creaturesounddata csd ON cmd.SoundID = csd.ID
SET 
cmd.BloodID = IF(cmd.BloodID IS NOT NULL AND ubl.ID IS NULL, NULL, cmd.BloodID),
cmd.FootprintTextureID = IF(cmd.FootprintTextureID IS NOT NULL AND ft.ID IS NULL, NULL, cmd.FootprintTextureID),
cmd.FootstepShakeSize = IF(cmd.FootstepShakeSize IS NOT NULL AND cs1.ID IS NULL, NULL, cmd.FootstepShakeSize),
cmd.DeathThudShakeSize = IF(cmd.DeathThudShakeSize IS NOT NULL AND cs2.ID IS NULL, NULL, cmd.DeathThudShakeSize),
cmd.SoundID = IF(cmd.SoundID IS NOT NULL AND csd.ID IS NULL, NULL, cmd.SoundID);


-- For creaturefamily
UPDATE creaturefamily cf
LEFT JOIN skillline sl1 ON cf.SkillLine_1 = sl1.ID
LEFT JOIN skillline sl2 ON cf.SkillLine_2 = sl2.ID
SET 
cf.SkillLine_1 = IF(cf.SkillLine_1 IS NOT NULL AND sl1.ID IS NULL, NULL, cf.SkillLine_1),
cf.SkillLine_2 = IF(cf.SkillLine_2 IS NOT NULL AND sl2.ID IS NULL, NULL, cf.SkillLine_2);

-- For creaturemodeldata
UPDATE creaturemodeldata cmd
LEFT JOIN unitbloodlevels ubl ON cmd.BloodID = ubl.ID
LEFT JOIN footprinttextures ft ON cmd.FootprintTextureID = ft.ID
LEFT JOIN camerashakes cs1 ON cmd.FootstepShakeSize = cs1.ID
LEFT JOIN camerashakes cs2 ON cmd.DeathThudShakeSize = cs2.ID
LEFT JOIN creaturesounddata csd ON cmd.SoundID = csd.ID
SET 
cmd.BloodID = IF(cmd.BloodID IS NOT NULL AND ubl.ID IS NULL, NULL, cmd.BloodID),
cmd.FootprintTextureID = IF(cmd.FootprintTextureID IS NOT NULL AND ft.ID IS NULL, NULL, cmd.FootprintTextureID),
cmd.FootstepShakeSize = IF(cmd.FootstepShakeSize IS NOT NULL AND cs1.ID IS NULL, NULL, cmd.FootstepShakeSize),
cmd.DeathThudShakeSize = IF(cmd.DeathThudShakeSize IS NOT NULL AND cs2.ID IS NULL, NULL, cmd.DeathThudShakeSize),
cmd.SoundID = IF(cmd.SoundID IS NOT NULL AND csd.ID IS NULL, NULL, cmd.SoundID);

-- Part 1
UPDATE creaturesounddata csd
LEFT JOIN soundentries se1 ON csd.SoundExertionID = se1.ID
LEFT JOIN soundentries se2 ON csd.SoundExertionCriticalID = se2.ID
LEFT JOIN soundentries se3 ON csd.SoundInjuryID = se3.ID
LEFT JOIN soundentries se4 ON csd.SoundInjuryCriticalID = se4.ID
LEFT JOIN soundentries se5 ON csd.SoundInjuryCrushingBlowID = se5.ID
LEFT JOIN soundentries se6 ON csd.SoundDeathID = se6.ID
LEFT JOIN soundentries se7 ON csd.SoundStunID = se7.ID
LEFT JOIN soundentries se8 ON csd.SoundStandID = se8.ID
LEFT JOIN soundentries se9 ON csd.SoundFootstepID = se9.ID
LEFT JOIN soundentries se10 ON csd.SoundAggroID = se10.ID
SET 
csd.SoundExertionID = IF(csd.SoundExertionID IS NOT NULL AND se1.ID IS NULL, NULL, csd.SoundExertionID),
csd.SoundExertionCriticalID = IF(csd.SoundExertionCriticalID IS NOT NULL AND se2.ID IS NULL, NULL, csd.SoundExertionCriticalID),
csd.SoundInjuryID = IF(csd.SoundInjuryID IS NOT NULL AND se3.ID IS NULL, NULL, csd.SoundInjuryID),
csd.SoundInjuryCriticalID = IF(csd.SoundInjuryCriticalID IS NOT NULL AND se4.ID IS NULL, NULL, csd.SoundInjuryCriticalID),
csd.SoundInjuryCrushingBlowID = IF(csd.SoundInjuryCrushingBlowID IS NOT NULL AND se5.ID IS NULL, NULL, csd.SoundInjuryCrushingBlowID),
csd.SoundDeathID = IF(csd.SoundDeathID IS NOT NULL AND se6.ID IS NULL, NULL, csd.SoundDeathID),
csd.SoundStunID = IF(csd.SoundStunID IS NOT NULL AND se7.ID IS NULL, NULL, csd.SoundStunID),
csd.SoundStandID = IF(csd.SoundStandID IS NOT NULL AND se8.ID IS NULL, NULL, csd.SoundStandID),
csd.SoundFootstepID = IF(csd.SoundFootstepID IS NOT NULL AND se9.ID IS NULL, NULL, csd.SoundFootstepID),
csd.SoundAggroID = IF(csd.SoundAggroID IS NOT NULL AND se10.ID IS NULL, NULL, csd.SoundAggroID);

-- Part 2
UPDATE creaturesounddata csd
LEFT JOIN soundentries se11 ON csd.SoundWingFlapID = se11.ID
LEFT JOIN soundentries se12 ON csd.SoundWingGlideID = se12.ID
LEFT JOIN soundentries se13 ON csd.SoundAlertID = se13.ID
LEFT JOIN soundentries se14 ON csd.SoundFidget_1 = se14.ID
LEFT JOIN soundentries se15 ON csd.SoundFidget_2 = se15.ID
LEFT JOIN soundentries se16 ON csd.SoundFidget_3 = se16.ID
SET 
csd.SoundWingFlapID = IF(csd.SoundWingFlapID IS NOT NULL AND se11.ID IS NULL, NULL, csd.SoundWingFlapID),
csd.SoundWingGlideID = IF(csd.SoundWingGlideID IS NOT NULL AND se12.ID IS NULL, NULL, csd.SoundWingGlideID),
csd.SoundAlertID = IF(csd.SoundAlertID IS NOT NULL AND se13.ID IS NULL, NULL, csd.SoundAlertID),
csd.SoundFidget_1 = IF(csd.SoundFidget_1 IS NOT NULL AND se14.ID IS NULL, NULL, csd.SoundFidget_1),
csd.SoundFidget_2 = IF(csd.SoundFidget_2 IS NOT NULL AND se15.ID IS NULL, NULL, csd.SoundFidget_2),
csd.SoundFidget_3 = IF(csd.SoundFidget_3 IS NOT NULL AND se16.ID IS NULL, NULL, csd.SoundFidget_3);

-- Part 3
UPDATE creaturesounddata csd
LEFT JOIN soundentries se17 ON csd.SoundFidget_4 = se17.ID
LEFT JOIN soundentries se18 ON csd.SoundFidget_5 = se18.ID
LEFT JOIN soundentries se19 ON csd.NPCSoundID = se19.ID
LEFT JOIN soundentries se20 ON csd.LoopSoundID = se20.ID
LEFT JOIN soundentries se21 ON csd.SoundJumpStartID = se21.ID
LEFT JOIN soundentries se22 ON csd.SoundJumpEndID = se22.ID
LEFT JOIN soundentries se23 ON csd.SoundPetAttackID = se23.ID
LEFT JOIN soundentries se24 ON csd.SoundPetOrderID = se24.ID
LEFT JOIN soundentries se25 ON csd.SoundPetDismissID = se25.ID
LEFT JOIN soundentries se26 ON csd.BirthSoundID = se26.ID
LEFT JOIN soundentries se27 ON csd.SpellCastDirectedSoundID = se27.ID
LEFT JOIN soundentries se28 ON csd.SubmergeSoundID = se28.ID
LEFT JOIN soundentries se29 ON csd.SubmergedSoundID = se29.ID
SET 
csd.SoundFidget_4 = IF(csd.SoundFidget_4 IS NOT NULL AND se17.ID IS NULL, NULL, csd.SoundFidget_4),
csd.SoundFidget_5 = IF(csd.SoundFidget_5 IS NOT NULL AND se18.ID IS NULL, NULL, csd.SoundFidget_5),
csd.NPCSoundID = IF(csd.NPCSoundID IS NOT NULL AND se19.ID IS NULL, NULL, csd.NPCSoundID),
csd.LoopSoundID = IF(csd.LoopSoundID IS NOT NULL AND se20.ID IS NULL, NULL, csd.LoopSoundID),
csd.SoundJumpStartID = IF(csd.SoundJumpStartID IS NOT NULL AND se21.ID IS NULL, NULL, csd.SoundJumpStartID),
csd.SoundJumpEndID = IF(csd.SoundJumpEndID IS NOT NULL AND se22.ID IS NULL, NULL, csd.SoundJumpEndID),
csd.SoundPetAttackID = IF(csd.SoundPetAttackID IS NOT NULL AND se23.ID IS NULL, NULL, csd.SoundPetAttackID),
csd.SoundPetOrderID = IF(csd.SoundPetOrderID IS NOT NULL AND se24.ID IS NULL, NULL, csd.SoundPetOrderID),
csd.SoundPetDismissID = IF(csd.SoundPetDismissID IS NOT NULL AND se25.ID IS NULL, NULL, csd.SoundPetDismissID),
csd.BirthSoundID = IF(csd.BirthSoundID IS NOT NULL AND se26.ID IS NULL, NULL, csd.BirthSoundID),
csd.SpellCastDirectedSoundID = IF(csd.SpellCastDirectedSoundID IS NOT NULL AND se27.ID IS NULL, NULL, csd.SpellCastDirectedSoundID),
csd.SubmergeSoundID = IF(csd.SubmergeSoundID IS NOT NULL AND se28.ID IS NULL, NULL, csd.SubmergeSoundID),
csd.SubmergedSoundID = IF(csd.SubmergedSoundID IS NOT NULL AND se29.ID IS NULL, NULL, csd.SubmergedSoundID);


-- For creaturespelldata
UPDATE creaturespelldata csd
LEFT JOIN spell s1 ON csd.Spells_1 = s1.ID
LEFT JOIN spell s2 ON csd.Spells_2 = s2.ID
LEFT JOIN spell s3 ON csd.Spells_3 = s3.ID
LEFT JOIN spell s4 ON csd.Spells_4 = s4.ID
SET 
csd.Spells_1 = IF(csd.Spells_1 IS NOT NULL AND s1.ID IS NULL, NULL, csd.Spells_1),
csd.Spells_2 = IF(csd.Spells_2 IS NOT NULL AND s2.ID IS NULL, NULL, csd.Spells_2),
csd.Spells_3 = IF(csd.Spells_3 IS NOT NULL AND s3.ID IS NULL, NULL, csd.Spells_3),
csd.Spells_4 = IF(csd.Spells_4 IS NOT NULL AND s4.ID IS NULL, NULL, csd.Spells_4);

-- For deaththudlookups
UPDATE deaththudlookups dtl
LEFT JOIN terraintype tt ON dtl.TerraintypeSoundID = tt.ID
LEFT JOIN soundentries se1 ON dtl.SoundEntryID = se1.ID
LEFT JOIN soundentries se2 ON dtl.SoundEntryIDWater = se2.ID
SET 
dtl.TerraintypeSoundID = IF(dtl.TerraintypeSoundID IS NOT NULL AND tt.ID IS NULL, NULL, dtl.TerraintypeSoundID),
dtl.SoundEntryID = IF(dtl.SoundEntryID IS NOT NULL AND se1.ID IS NULL, NULL, dtl.SoundEntryID),
dtl.SoundEntryIDWater = IF(dtl.SoundEntryIDWater IS NOT NULL AND se2.ID IS NULL, NULL, dtl.SoundEntryIDWater);

-- For declinedwordcases
UPDATE declinedwordcases dwc
LEFT JOIN declinedword dw ON dwc.DeclinedWordID = dw.ID
SET 
dwc.DeclinedWordID = IF(dwc.DeclinedWordID IS NOT NULL AND dw.ID IS NULL, NULL, dwc.DeclinedWordID);

-- For dungeonencounter
UPDATE dungeonencounter de
LEFT JOIN map m ON de.MapID = m.ID
LEFT JOIN mapdifficulty md ON de.Difficulty = md.ID
SET 
de.MapID = IF(de.MapID IS NOT NULL AND m.ID IS NULL, NULL, de.MapID),
de.Difficulty = IF(de.Difficulty IS NOT NULL AND md.ID IS NULL, NULL, de.Difficulty);

-- For dungeonmap
UPDATE dungeonmap dm
LEFT JOIN map m ON dm.MapID = m.ID
LEFT JOIN worldmaparea wma ON dm.ParentWorldMapID = wma.ID
SET 
dm.MapID = IF(dm.MapID IS NOT NULL AND m.ID IS NULL, NULL, dm.MapID),
dm.ParentWorldMapID = IF(dm.ParentWorldMapID IS NOT NULL AND wma.ID IS NULL, NULL, dm.ParentWorldMapID);

-- For dungeonmapchunk
UPDATE dungeonmapchunk dmc
LEFT JOIN map m ON dmc.MapID = m.ID
LEFT JOIN wmoareatable wat ON dmc.WmoGroupID = wat.ID
LEFT JOIN dungeonmap dm ON dmc.DungeonMapID = dm.ID
SET 
dmc.MapID = IF(dmc.MapID IS NOT NULL AND m.ID IS NULL, NULL, dmc.MapID),
dmc.WmoGroupID = IF(dmc.WmoGroupID IS NOT NULL AND wat.ID IS NULL, NULL, dmc.WmoGroupID),
dmc.DungeonMapID = IF(dmc.DungeonMapID IS NOT NULL AND dm.ID IS NULL, NULL, dmc.DungeonMapID);

-- For emotes
UPDATE emotes e
LEFT JOIN animationdata ad ON e.AnimID = ad.ID
LEFT JOIN soundentries se ON e.EventSoundID = se.ID
SET 
e.AnimID = IF(e.AnimID IS NOT NULL AND ad.ID IS NULL, NULL, e.AnimID),
e.EventSoundID = IF(e.EventSoundID IS NOT NULL AND se.ID IS NULL, NULL, e.EventSoundID);

-- For emotestext
UPDATE emotestext et
LEFT JOIN emotes e ON et.EmoteID = e.ID
LEFT JOIN emotestextdata etd1 ON et.EmoteText_1 = etd1.ID
LEFT JOIN emotestextdata etd2 ON et.EmoteText_2 = etd2.ID
LEFT JOIN emotestextdata etd3 ON et.EmoteText_3 = etd3.ID
LEFT JOIN emotestextdata etd4 ON et.EmoteText_4 = etd4.ID
LEFT JOIN emotestextdata etd5 ON et.EmoteText_5 = etd5.ID
LEFT JOIN emotestextdata etd6 ON et.EmoteText_6 = etd6.ID
LEFT JOIN emotestextdata etd7 ON et.EmoteText_7 = etd7.ID
LEFT JOIN emotestextdata etd8 ON et.EmoteText_8 = etd8.ID
LEFT JOIN emotestextdata etd9 ON et.EmoteText_9 = etd9.ID
LEFT JOIN emotestextdata etd10 ON et.EmoteText_10 = etd10.ID
LEFT JOIN emotestextdata etd11 ON et.EmoteText_11 = etd11.ID
LEFT JOIN emotestextdata etd12 ON et.EmoteText_12 = etd12.ID
LEFT JOIN emotestextdata etd13 ON et.EmoteText_13 = etd13.ID
LEFT JOIN emotestextdata etd14 ON et.EmoteText_14 = etd14.ID
LEFT JOIN emotestextdata etd15 ON et.EmoteText_15 = etd15.ID
LEFT JOIN emotestextdata etd16 ON et.EmoteText_16 = etd16.ID
SET 
et.EmoteID = IF(et.EmoteID IS NOT NULL AND e.ID IS NULL, NULL, et.EmoteID),
et.EmoteText_1 = IF(et.EmoteText_1 IS NOT NULL AND etd1.ID IS NULL, NULL, et.EmoteText_1),
et.EmoteText_2 = IF(et.EmoteText_2 IS NOT NULL AND etd2.ID IS NULL, NULL, et.EmoteText_2),
et.EmoteText_3 = IF(et.EmoteText_3 IS NOT NULL AND etd3.ID IS NULL, NULL, et.EmoteText_3),
et.EmoteText_4 = IF(et.EmoteText_4 IS NOT NULL AND etd4.ID IS NULL, NULL, et.EmoteText_4),
et.EmoteText_5 = IF(et.EmoteText_5 IS NOT NULL AND etd5.ID IS NULL, NULL, et.EmoteText_5),
et.EmoteText_6 = IF(et.EmoteText_6 IS NOT NULL AND etd6.ID IS NULL, NULL, et.EmoteText_6),
et.EmoteText_7 = IF(et.EmoteText_7 IS NOT NULL AND etd7.ID IS NULL, NULL, et.EmoteText_7),
et.EmoteText_8 = IF(et.EmoteText_8 IS NOT NULL AND etd8.ID IS NULL, NULL, et.EmoteText_8),
et.EmoteText_9 = IF(et.EmoteText_9 IS NOT NULL AND etd9.ID IS NULL, NULL, et.EmoteText_9),
et.EmoteText_10 = IF(et.EmoteText_10 IS NOT NULL AND etd10.ID IS NULL, NULL, et.EmoteText_10),
et.EmoteText_11 = IF(et.EmoteText_11 IS NOT NULL AND etd11.ID IS NULL, NULL, et.EmoteText_11),
et.EmoteText_12 = IF(et.EmoteText_12 IS NOT NULL AND etd12.ID IS NULL, NULL, et.EmoteText_12),
et.EmoteText_13 = IF(et.EmoteText_13 IS NOT NULL AND etd13.ID IS NULL, NULL, et.EmoteText_13),
et.EmoteText_14 = IF(et.EmoteText_14 IS NOT NULL AND etd14.ID IS NULL, NULL, et.EmoteText_14),
et.EmoteText_15 = IF(et.EmoteText_15 IS NOT NULL AND etd15.ID IS NULL, NULL, et.EmoteText_15),
et.EmoteText_16 = IF(et.EmoteText_16 IS NOT NULL AND etd16.ID IS NULL, NULL, et.EmoteText_16);

-- For emotestextsound
UPDATE emotestextsound ets
LEFT JOIN emotestext et ON ets.EmotesTextID = et.ID
LEFT JOIN chrraces cr ON ets.RaceID = cr.ID
LEFT JOIN soundentries se ON ets.SoundID = se.ID
SET 
ets.EmotesTextID = IF(ets.EmotesTextID IS NOT NULL AND et.ID IS NULL, NULL, ets.EmotesTextID),
ets.RaceID = IF(ets.RaceID IS NOT NULL AND cr.ID IS NULL, NULL, ets.RaceID),
ets.SoundID = IF(ets.SoundID IS NOT NULL AND se.ID IS NULL, NULL, ets.SoundID);

-- For creaturedisplayinfoextra
UPDATE creaturedisplayinfoextra cdie
LEFT JOIN chrraces cr ON cdie.DisplayRaceID = cr.ID
LEFT JOIN itemdisplayinfo idi1 ON cdie.NPCItemDisplay_1 = idi1.ID
LEFT JOIN itemdisplayinfo idi2 ON cdie.NPCItemDisplay_2 = idi2.ID
LEFT JOIN itemdisplayinfo idi3 ON cdie.NPCItemDisplay_3 = idi3.ID
LEFT JOIN itemdisplayinfo idi4 ON cdie.NPCItemDisplay_4 = idi4.ID
LEFT JOIN itemdisplayinfo idi5 ON cdie.NPCItemDisplay_5 = idi5.ID
LEFT JOIN itemdisplayinfo idi6 ON cdie.NPCItemDisplay_6 = idi6.ID
LEFT JOIN itemdisplayinfo idi7 ON cdie.NPCItemDisplay_7 = idi7.ID
LEFT JOIN itemdisplayinfo idi8 ON cdie.NPCItemDisplay_8 = idi8.ID
LEFT JOIN itemdisplayinfo idi9 ON cdie.NPCItemDisplay_9 = idi9.ID
LEFT JOIN itemdisplayinfo idi10 ON cdie.NPCItemDisplay_10 = idi10.ID
LEFT JOIN itemdisplayinfo idi11 ON cdie.NPCItemDisplay_11 = idi11.ID
SET 
cdie.DisplayRaceID = IF(cdie.DisplayRaceID IS NOT NULL AND cr.ID IS NULL, NULL, cdie.DisplayRaceID),
cdie.NPCItemDisplay_1 = IF(cdie.NPCItemDisplay_1 IS NOT NULL AND idi1.ID IS NULL, NULL, cdie.NPCItemDisplay_1),
cdie.NPCItemDisplay_2 = IF(cdie.NPCItemDisplay_2 IS NOT NULL AND idi2.ID IS NULL, NULL, cdie.NPCItemDisplay_2),
cdie.NPCItemDisplay_3 = IF(cdie.NPCItemDisplay_3 IS NOT NULL AND idi3.ID IS NULL, NULL, cdie.NPCItemDisplay_3),
cdie.NPCItemDisplay_4 = IF(cdie.NPCItemDisplay_4 IS NOT NULL AND idi4.ID IS NULL, NULL, cdie.NPCItemDisplay_4),
cdie.NPCItemDisplay_5 = IF(cdie.NPCItemDisplay_5 IS NOT NULL AND idi5.ID IS NULL, NULL, cdie.NPCItemDisplay_5),
cdie.NPCItemDisplay_6 = IF(cdie.NPCItemDisplay_6 IS NOT NULL AND idi6.ID IS NULL, NULL, cdie.NPCItemDisplay_6),
cdie.NPCItemDisplay_7 = IF(cdie.NPCItemDisplay_7 IS NOT NULL AND idi7.ID IS NULL, NULL, cdie.NPCItemDisplay_7),
cdie.NPCItemDisplay_8 = IF(cdie.NPCItemDisplay_8 IS NOT NULL AND idi8.ID IS NULL, NULL, cdie.NPCItemDisplay_8),
cdie.NPCItemDisplay_9 = IF(cdie.NPCItemDisplay_9 IS NOT NULL AND idi9.ID IS NULL, NULL, cdie.NPCItemDisplay_9),
cdie.NPCItemDisplay_10 = IF(cdie.NPCItemDisplay_10 IS NOT NULL AND idi10.ID IS NULL, NULL, cdie.NPCItemDisplay_10),
cdie.NPCItemDisplay_11 = IF(cdie.NPCItemDisplay_11 IS NOT NULL AND idi11.ID IS NULL, NULL, cdie.NPCItemDisplay_11);

-- For creaturespelldata
UPDATE creaturespelldata csd
LEFT JOIN spell s1 ON csd.Spells_1 = s1.ID
LEFT JOIN spell s2 ON csd.Spells_2 = s2.ID
LEFT JOIN spell s3 ON csd.Spells_3 = s3.ID
LEFT JOIN spell s4 ON csd.Spells_4 = s4.ID
SET 
csd.Spells_1 = IF(csd.Spells_1 IS NOT NULL AND s1.ID IS NULL, NULL, csd.Spells_1),
csd.Spells_2 = IF(csd.Spells_2 IS NOT NULL AND s2.ID IS NULL, NULL, csd.Spells_2),
csd.Spells_3 = IF(csd.Spells_3 IS NOT NULL AND s3.ID IS NULL, NULL, csd.Spells_3),
csd.Spells_4 = IF(csd.Spells_4 IS NOT NULL AND s4.ID IS NULL, NULL, csd.Spells_4);

-- deaththudlookups table
UPDATE deaththudlookups SET TerraintypeSoundID = NULL WHERE TerraintypeSoundID NOT IN (SELECT ID FROM terraintype);
UPDATE deaththudlookups SET SoundEntryID = NULL WHERE SoundEntryID NOT IN (SELECT ID FROM soundentries);
UPDATE deaththudlookups SET SoundEntryIDWater = NULL WHERE SoundEntryIDWater NOT IN (SELECT ID FROM soundentries);

-- declinedwordcases table
UPDATE declinedwordcases SET DeclinedWordID = NULL WHERE DeclinedWordID NOT IN (SELECT ID FROM declinedword);

-- dungeonencounter table
UPDATE dungeonencounter SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE dungeonencounter SET Difficulty = NULL WHERE Difficulty NOT IN (SELECT ID FROM mapdifficulty);

-- dungeonmap table
UPDATE dungeonmap SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE dungeonmap SET ParentWorldMapID = NULL WHERE ParentWorldMapID NOT IN (SELECT ID FROM worldmaparea);

-- dungeonmapchunk table
UPDATE dungeonmapchunk SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE dungeonmapchunk SET WmoGroupID = NULL WHERE WmoGroupID NOT IN (SELECT ID FROM wmoareatable);
UPDATE dungeonmapchunk SET DungeonMapID = NULL WHERE DungeonMapID NOT IN (SELECT ID FROM dungeonmap);

-- emotes table
UPDATE emotes SET AnimID = NULL WHERE AnimID NOT IN (SELECT ID FROM animationdata);
UPDATE emotes SET EventSoundID = NULL WHERE EventSoundID NOT IN (SELECT ID FROM soundentries);

-- emotestext table
UPDATE emotestext SET EmoteID = NULL WHERE EmoteID NOT IN (SELECT ID FROM emotes);
UPDATE emotestext SET EmoteText_1 = NULL WHERE EmoteText_1 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_2 = NULL WHERE EmoteText_2 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_3 = NULL WHERE EmoteText_3 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_4 = NULL WHERE EmoteText_4 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_5 = NULL WHERE EmoteText_5 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_6 = NULL WHERE EmoteText_6 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_7 = NULL WHERE EmoteText_7 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_8 = NULL WHERE EmoteText_8 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_9 = NULL WHERE EmoteText_9 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_10 = NULL WHERE EmoteText_10 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_11 = NULL WHERE EmoteText_11 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_12 = NULL WHERE EmoteText_12 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_13 = NULL WHERE EmoteText_13 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_14 = NULL WHERE EmoteText_14 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_15 = NULL WHERE EmoteText_15 NOT IN (SELECT ID FROM emotestextdata);
UPDATE emotestext SET EmoteText_16 = NULL WHERE EmoteText_16 NOT IN (SELECT ID FROM emotestextdata);

-- emotestextsound table
UPDATE emotestextsound SET EmotesTextID = NULL WHERE EmotesTextID NOT IN (SELECT ID FROM emotestext);
UPDATE emotestextsound SET RaceID = NULL WHERE RaceID NOT IN (SELECT ID FROM chrraces);
UPDATE emotestextsound SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);

-- environmentaldamage table
UPDATE environmentaldamage SET VisualkitID = NULL WHERE VisualkitID NOT IN (SELECT ID FROM soundentries);

-- factiontemplate table
UPDATE factiontemplate SET factiontemplate.Faction = NULL WHERE factiontemplate.Faction NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Enemies_1 = NULL WHERE Enemies_1 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Enemies_2 = NULL WHERE Enemies_2 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Enemies_3 = NULL WHERE Enemies_3 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Enemies_4 = NULL WHERE Enemies_4 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Friend_1 = NULL WHERE Friend_1 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Friend_2 = NULL WHERE Friend_2 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Friend_3 = NULL WHERE Friend_3 NOT IN (SELECT ID FROM faction);
UPDATE factiontemplate SET Friend_4 = NULL WHERE Friend_4 NOT IN (SELECT ID FROM faction);

-- footstepterrainlookup table
UPDATE footstepterrainlookup SET CreatureFootstepID = NULL WHERE CreatureFootstepID NOT IN (SELECT ID FROM groundeffectdoodad);
UPDATE footstepterrainlookup SET TerrainSoundID = NULL WHERE TerrainSoundID NOT IN (SELECT ID FROM terraintype);
UPDATE footstepterrainlookup SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);
UPDATE footstepterrainlookup SET SoundIDSplash = NULL WHERE SoundIDSplash NOT IN (SELECT ID FROM soundentries);

-- gameobjectdisplayinfo table
UPDATE gameobjectdisplayinfo SET Sound_1 = NULL WHERE Sound_1 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_2 = NULL WHERE Sound_2 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_3 = NULL WHERE Sound_3 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_4 = NULL WHERE Sound_4 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_5 = NULL WHERE Sound_5 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_6 = NULL WHERE Sound_6 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_7 = NULL WHERE Sound_7 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_8 = NULL WHERE Sound_8 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_9 = NULL WHERE Sound_9 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET Sound_10 = NULL WHERE Sound_10 NOT IN (SELECT ID FROM soundentries);
UPDATE gameobjectdisplayinfo SET ObjectEffectPackageID = NULL WHERE ObjectEffectPackageID NOT IN (SELECT ID FROM objecteffectpackage);

-- gemproperties table
UPDATE gemproperties SET Enchant_Id = NULL WHERE Enchant_Id NOT IN (SELECT ID FROM spellitemenchantment);

-- glyphproperties table
UPDATE glyphproperties SET SpellID = NULL WHERE SpellID NOT IN (SELECT ID FROM spell);
UPDATE glyphproperties SET SpellIconID = NULL WHERE SpellIconID NOT IN (SELECT ID FROM spellicon);

-- gmsurveyanswers table
UPDATE gmsurveyanswers SET GMSurveyQuestionID = NULL WHERE GMSurveyQuestionID NOT IN (SELECT ID FROM gmsurveyquestions);

-- gmsurveycurrentsurvey table
UPDATE gmsurveycurrentsurvey SET GMSURVEY_ID = NULL WHERE GMSURVEY_ID NOT IN (SELECT ID FROM gmsurveysurveys);

-- gmsurveysurveys table
UPDATE gmsurveysurveys SET Q_1 = NULL WHERE Q_1 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_2 = NULL WHERE Q_2 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_3 = NULL WHERE Q_3 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_4 = NULL WHERE Q_4 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_5 = NULL WHERE Q_5 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_6 = NULL WHERE Q_6 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_7 = NULL WHERE Q_7 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_8 = NULL WHERE Q_8 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_9 = NULL WHERE Q_9 NOT IN (SELECT ID FROM gmsurveyquestions);
UPDATE gmsurveysurveys SET Q_10 = NULL WHERE Q_10 NOT IN (SELECT ID FROM gmsurveyquestions);

-- groundeffecttexture table
UPDATE groundeffecttexture SET DoodadId_1 = NULL WHERE DoodadId_1 NOT IN (SELECT ID FROM groundeffectdoodad);
UPDATE groundeffecttexture SET DoodadId_2 = NULL WHERE DoodadId_2 NOT IN (SELECT ID FROM groundeffectdoodad);
UPDATE groundeffecttexture SET DoodadId_3 = NULL WHERE DoodadId_3 NOT IN (SELECT ID FROM groundeffectdoodad);
UPDATE groundeffecttexture SET DoodadId_4 = NULL WHERE DoodadId_4 NOT IN (SELECT ID FROM groundeffectdoodad);

-- holidays table
UPDATE holidays SET HolidayNameID = NULL WHERE HolidayNameID NOT IN (SELECT ID FROM holidaynames);
UPDATE holidays SET HolidayDescriptionID = NULL WHERE HolidayDescriptionID NOT IN (SELECT ID FROM holidaydescriptions);

-- item table
UPDATE item SET ClassID = NULL WHERE ClassID NOT IN (SELECT ID FROM itemclass);
UPDATE item SET SubclassID = NULL WHERE SubclassID NOT IN (SELECT ID FROM itemsubclass);
UPDATE item SET Material = NULL WHERE Material NOT IN (SELECT ID FROM material);
UPDATE item SET DisplayInfoID = NULL WHERE DisplayInfoID NOT IN (SELECT ID FROM itemdisplayinfo);

-- itemdisplayinfo table
UPDATE itemdisplayinfo SET GroupSoundIndex = NULL WHERE GroupSoundIndex NOT IN (SELECT ID FROM itemgroupsounds);
UPDATE itemdisplayinfo SET HelmetGeosetVis_1 = NULL WHERE HelmetGeosetVis_1 NOT IN (SELECT ID FROM helmetgeosetvisdata);
UPDATE itemdisplayinfo SET HelmetGeosetVis_2 = NULL WHERE HelmetGeosetVis_2 NOT IN (SELECT ID FROM helmetgeosetvisdata);
UPDATE itemdisplayinfo SET ItemVisual = NULL WHERE ItemVisual NOT IN (SELECT ID FROM itemvisuals);

-- itemextendedcost table
UPDATE itemextendedcost SET ItemPurchaseGroup = NULL WHERE ItemPurchaseGroup NOT IN (SELECT ID FROM itempurchasegroup);

-- itemgroupsounds table
UPDATE itemgroupsounds SET Pickup = NULL WHERE Pickup NOT IN (SELECT ID FROM soundentries);
UPDATE itemgroupsounds SET `Drop` = NULL WHERE `Drop` NOT IN (SELECT ID FROM soundentries);
UPDATE itemgroupsounds SET `Close` = NULL WHERE `Close` NOT IN (SELECT ID FROM soundentries);
UPDATE itemgroupsounds SET `Use` = NULL WHERE `Use` NOT IN (SELECT ID FROM soundentries);

-- itempurchasegroup table
UPDATE itempurchasegroup SET ItemID_1 = NULL WHERE ItemID_1 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_2 = NULL WHERE ItemID_2 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_3 = NULL WHERE ItemID_3 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_4 = NULL WHERE ItemID_4 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_5 = NULL WHERE ItemID_5 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_6 = NULL WHERE ItemID_6 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_7 = NULL WHERE ItemID_7 NOT IN (SELECT ID FROM item);
UPDATE itempurchasegroup SET ItemID_8 = NULL WHERE ItemID_8 NOT IN (SELECT ID FROM item);

-- itemrandomproperties table
UPDATE itemrandomproperties SET Enchantment_1 = NULL WHERE Enchantment_1 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomproperties SET Enchantment_2 = NULL WHERE Enchantment_2 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomproperties SET Enchantment_3 = NULL WHERE Enchantment_3 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomproperties SET Enchantment_4 = NULL WHERE Enchantment_4 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomproperties SET Enchantment_5 = NULL WHERE Enchantment_5 NOT IN (SELECT ID FROM spellitemenchantment);

-- itemrandomsuffix table
UPDATE itemrandomsuffix SET Enchantment_1 = NULL WHERE Enchantment_1 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomsuffix SET Enchantment_2 = NULL WHERE Enchantment_2 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomsuffix SET Enchantment_3 = NULL WHERE Enchantment_3 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomsuffix SET Enchantment_4 = NULL WHERE Enchantment_4 NOT IN (SELECT ID FROM spellitemenchantment);
UPDATE itemrandomsuffix SET Enchantment_5 = NULL WHERE Enchantment_5 NOT IN (SELECT ID FROM spellitemenchantment);

-- itemset table
UPDATE itemset SET ItemID_1 = NULL WHERE ItemID_1 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_2 = NULL WHERE ItemID_2 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_3 = NULL WHERE ItemID_3 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_4 = NULL WHERE ItemID_4 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_5 = NULL WHERE ItemID_5 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_6 = NULL WHERE ItemID_6 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_7 = NULL WHERE ItemID_7 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_8 = NULL WHERE ItemID_8 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_9 = NULL WHERE ItemID_9 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_10 = NULL WHERE ItemID_10 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_11 = NULL WHERE ItemID_11 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_12 = NULL WHERE ItemID_12 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_13 = NULL WHERE ItemID_13 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_14 = NULL WHERE ItemID_14 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_15 = NULL WHERE ItemID_15 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_16 = NULL WHERE ItemID_16 NOT IN (SELECT ID FROM item);
UPDATE itemset SET ItemID_17 = NULL WHERE ItemID_17 NOT IN (SELECT ID FROM item);
UPDATE itemset SET SetSpellID_1 = NULL WHERE SetSpellID_1 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_2 = NULL WHERE SetSpellID_2 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_3 = NULL WHERE SetSpellID_3 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_4 = NULL WHERE SetSpellID_4 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_5 = NULL WHERE SetSpellID_5 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_6 = NULL WHERE SetSpellID_6 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_7 = NULL WHERE SetSpellID_7 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET SetSpellID_8 = NULL WHERE SetSpellID_8 NOT IN (SELECT ID FROM spell);
UPDATE itemset SET RequiredSkill = NULL WHERE RequiredSkill NOT IN (SELECT ID FROM skillline);

-- itemsubclass table
UPDATE itemsubclass SET ClassID = NULL WHERE ClassID NOT IN (SELECT ClassID FROM itemclass);

-- itemvisuals table
UPDATE itemvisuals SET Slot_1 = NULL WHERE Slot_1 NOT IN (SELECT ID FROM itemvisualeffects);
UPDATE itemvisuals SET Slot_2 = NULL WHERE Slot_2 NOT IN (SELECT ID FROM itemvisualeffects);
UPDATE itemvisuals SET Slot_3 = NULL WHERE Slot_3 NOT IN (SELECT ID FROM itemvisualeffects);
UPDATE itemvisuals SET Slot_4 = NULL WHERE Slot_4 NOT IN (SELECT ID FROM itemvisualeffects);
UPDATE itemvisuals SET Slot_5 = NULL WHERE Slot_5 NOT IN (SELECT ID FROM itemvisualeffects);

-- languagewords table
UPDATE languagewords SET LanguageID = NULL WHERE LanguageID NOT IN (SELECT ID FROM languages);

-- lfgdungeonexpansion table
UPDATE lfgdungeonexpansion SET Lfg_Id = NULL WHERE Lfg_Id NOT IN (SELECT ID FROM lfgdungeons);

-- lfgdungeons table
UPDATE lfgdungeons SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE lfgdungeons SET lfgdungeons.Faction = NULL WHERE lfgdungeons.Faction NOT IN (SELECT ID FROM faction);

-- lightparams table
UPDATE lightparams SET LightSkyboxID = NULL WHERE LightSkyboxID NOT IN (SELECT ID FROM lightskybox);

-- loadingscreentaxisplines table
UPDATE loadingscreentaxisplines SET PathID = NULL WHERE PathID NOT IN (SELECT ID FROM taxipath);

-- lock table
UPDATE `lock` SET Type_1 = NULL WHERE Type_1 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_2 = NULL WHERE Type_2 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_3 = NULL WHERE Type_3 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_4 = NULL WHERE Type_4 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_5 = NULL WHERE Type_5 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_6 = NULL WHERE Type_6 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_7 = NULL WHERE Type_7 NOT IN (SELECT ID FROM locktype);
UPDATE `lock` SET Type_8 = NULL WHERE Type_8 NOT IN (SELECT ID FROM locktype);

-- map table
UPDATE map SET AreaTableID = NULL WHERE AreaTableID NOT IN (SELECT ID FROM areatable);
UPDATE map SET LoadingScreenID = NULL WHERE LoadingScreenID NOT IN (SELECT ID FROM loadingscreens);

-- mapdifficulty table
UPDATE mapdifficulty SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);

-- material table
UPDATE material SET FoleySoundID = NULL WHERE FoleySoundID NOT IN (SELECT ID FROM soundentries);
UPDATE material SET SheatheSoundID = NULL WHERE SheatheSoundID NOT IN (SELECT ID FROM soundentries);
UPDATE material SET UnsheatheSoundID = NULL WHERE UnsheatheSoundID NOT IN (SELECT ID FROM soundentries);

-- namegen table
UPDATE namegen SET RaceID = NULL WHERE RaceID NOT IN (SELECT ID FROM chrraces);

-- npcsounds table
UPDATE npcsounds SET SoundID_1 = NULL WHERE SoundID_1 NOT IN (SELECT ID FROM soundentries);
UPDATE npcsounds SET SoundID_2 = NULL WHERE SoundID_2 NOT IN (SELECT ID FROM soundentries);
UPDATE npcsounds SET SoundID_3 = NULL WHERE SoundID_3 NOT IN (SELECT ID FROM soundentries);
UPDATE npcsounds SET SoundID_4 = NULL WHERE SoundID_4 NOT IN (SELECT ID FROM soundentries);

-- objecteffect table
UPDATE objecteffect SET ObjectEffectGroupID = NULL WHERE ObjectEffectGroupID NOT IN (SELECT ID FROM objecteffectgroup);
UPDATE objecteffect SET ObjectEffectModifierID = NULL WHERE ObjectEffectModifierID NOT IN (SELECT ID FROM objecteffectmodifier);

-- objecteffectpackageelem table
UPDATE objecteffectpackageelem SET ObjectEffectGroupID = NULL WHERE ObjectEffectGroupID NOT IN (SELECT ID FROM objecteffectgroup);
UPDATE objecteffectpackageelem SET ObjectEffectPackageID = NULL WHERE ObjectEffectPackageID NOT IN (SELECT ID FROM objecteffectpackage);

-- overridespelldata table
UPDATE overridespelldata SET Spells_1 = NULL WHERE Spells_1 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_2 = NULL WHERE Spells_2 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_3 = NULL WHERE Spells_3 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_4 = NULL WHERE Spells_4 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_5 = NULL WHERE Spells_5 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_6 = NULL WHERE Spells_6 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_7 = NULL WHERE Spells_7 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_8 = NULL WHERE Spells_8 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_9 = NULL WHERE Spells_9 NOT IN (SELECT ID FROM spell);
UPDATE overridespelldata SET Spells_10 = NULL WHERE Spells_10 NOT IN (SELECT ID FROM spell);

-- pvpdifficulty table
UPDATE pvpdifficulty SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);

-- sheathesoundlookups table
UPDATE sheathesoundlookups SET ItemClass = NULL WHERE ItemClass NOT IN (SELECT ID FROM itemsubclass);
UPDATE sheathesoundlookups SET ItemSubclass = NULL WHERE ItemSubclass NOT IN (SELECT ID FROM itemsubclass);
UPDATE sheathesoundlookups SET SheathSoundID = NULL WHERE SheathSoundID NOT IN (SELECT ID FROM soundentries);
UPDATE sheathesoundlookups SET UnsheathSoundID = NULL WHERE UnsheathSoundID NOT IN (SELECT ID FROM soundentries);

-- skillline table
UPDATE skillline SET CategoryID = NULL WHERE CategoryID NOT IN (SELECT ID FROM skilllinecategory);
UPDATE skillline SET SkillCostsID = NULL WHERE SkillCostsID NOT IN (SELECT ID FROM skillcostsdata);
UPDATE skillline SET SpellIconID = NULL WHERE SpellIconID NOT IN (SELECT ID FROM spellicon);

-- skilllineability table
UPDATE skilllineability SET SkillLine = NULL WHERE SkillLine NOT IN (SELECT ID FROM skillline);
UPDATE skilllineability SET Spell = NULL WHERE Spell NOT IN (SELECT ID FROM spell);

-- skillraceclassinfo table
UPDATE skillraceclassinfo SET SkillID = NULL WHERE SkillID NOT IN (SELECT ID FROM skillline);
UPDATE skillraceclassinfo SET SkillTierID = NULL WHERE SkillTierID NOT IN (SELECT ID FROM skilltiers);
UPDATE skillraceclassinfo SET SkillCostIndex = NULL WHERE SkillCostIndex NOT IN (SELECT ID FROM skillcostsdata);

-- soundambience table
UPDATE soundambience SET AmbienceID_1 = NULL WHERE AmbienceID_1 NOT IN (SELECT ID FROM soundentries);
UPDATE soundambience SET AmbienceID_2 = NULL WHERE AmbienceID_2 NOT IN (SELECT ID FROM soundentries);

-- soundemitters table
UPDATE soundemitters SET SoundEntriesID = NULL WHERE SoundEntriesID NOT IN (SELECT ID FROM soundentries);
UPDATE soundemitters SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);

-- soundentries table
UPDATE soundentries SET SoundEntriesAdvancedID = NULL WHERE SoundEntriesAdvancedID NOT IN (SELECT ID FROM soundentriesadvanced);

-- soundentriesadvanced table
UPDATE soundentriesadvanced SET SoundEntryID = NULL WHERE SoundEntryID NOT IN (SELECT ID FROM soundentries);

-- soundwatertype table
UPDATE soundwatertype SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);

-- spell table
UPDATE spell SET Category = NULL WHERE Category NOT IN (SELECT ID FROM spellcategory);
UPDATE spell SET DispelType = NULL WHERE DispelType NOT IN (SELECT ID FROM spelldispeltype);
UPDATE spell SET Mechanic = NULL WHERE Mechanic NOT IN (SELECT ID FROM spellmechanic);
UPDATE spell SET RequiresSpellFocus = NULL WHERE RequiresSpellFocus NOT IN (SELECT ID FROM spellfocusobject);
UPDATE spell SET CastingTimeIndex = NULL WHERE CastingTimeIndex NOT IN (SELECT ID FROM spellcasttimes);
UPDATE spell SET DurationIndex = NULL WHERE DurationIndex NOT IN (SELECT ID FROM spellduration);
UPDATE spell SET RangeIndex = NULL WHERE RangeIndex NOT IN (SELECT ID FROM spellrange);
UPDATE spell SET EffectMechanic_1 = NULL WHERE EffectMechanic_1 NOT IN (SELECT ID FROM spellmechanic);
UPDATE spell SET EffectMechanic_2 = NULL WHERE EffectMechanic_2 NOT IN (SELECT ID FROM spellmechanic);
UPDATE spell SET EffectMechanic_3 = NULL WHERE EffectMechanic_3 NOT IN (SELECT ID FROM spellmechanic);
UPDATE spell SET EffectRadiusIndex_1 = NULL WHERE EffectRadiusIndex_1 NOT IN (SELECT ID FROM spellradius);
UPDATE spell SET EffectRadiusIndex_2 = NULL WHERE EffectRadiusIndex_2 NOT IN (SELECT ID FROM spellradius);
UPDATE spell SET EffectRadiusIndex_3 = NULL WHERE EffectRadiusIndex_3 NOT IN (SELECT ID FROM spellradius);
UPDATE spell SET RequiredTotemCategoryID_1 = NULL WHERE RequiredTotemCategoryID_1 NOT IN (SELECT ID FROM item);
UPDATE spell SET RequiredTotemCategoryID_2 = NULL WHERE RequiredTotemCategoryID_2 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_1 = NULL WHERE Reagent_1 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_2 = NULL WHERE Reagent_2 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_3 = NULL WHERE Reagent_3 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_4 = NULL WHERE Reagent_4 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_5 = NULL WHERE Reagent_5 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_6 = NULL WHERE Reagent_6 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_7 = NULL WHERE Reagent_7 NOT IN (SELECT ID FROM item);
UPDATE spell SET Reagent_8 = NULL WHERE Reagent_8 NOT IN (SELECT ID FROM item);
UPDATE spell SET SpellVisualID_1 = NULL WHERE SpellVisualID_1 NOT IN (SELECT ID FROM spellvisual);
UPDATE spell SET SpellVisualID_2 = NULL WHERE SpellVisualID_2 NOT IN (SELECT ID FROM spellvisual);
UPDATE spell SET SpellIconID = NULL WHERE SpellIconID NOT IN (SELECT ID FROM spellicon);
UPDATE spell SET ActiveIconID = NULL WHERE ActiveIconID NOT IN (SELECT ID FROM spellicon);
UPDATE spell SET RequiredAreasID = NULL WHERE RequiredAreasID NOT IN (SELECT ID FROM areagroup);
UPDATE spell SET RuneCostID = NULL WHERE RuneCostID NOT IN (SELECT ID FROM spellrunecost);
UPDATE spell SET SpellMissileID = NULL WHERE SpellMissileID NOT IN (SELECT ID FROM spellmissile);
UPDATE spell SET SpellDescriptionVariableID = NULL WHERE SpellDescriptionVariableID NOT IN (SELECT ID FROM spelldescriptionvariables);
UPDATE spell SET SpellDifficultyID = NULL WHERE SpellDifficultyID NOT IN (SELECT ID FROM spelldifficulty);
UPDATE spell SET PowerDisplayID = NULL WHERE PowerDisplayID NOT IN (SELECT ID FROM powerdisplay);

-- spelldifficulty table
UPDATE spelldifficulty SET DifficultySpellID_1 = NULL WHERE DifficultySpellID_1 NOT IN (SELECT ID FROM spell);
UPDATE spelldifficulty SET DifficultySpellID_2 = NULL WHERE DifficultySpellID_2 NOT IN (SELECT ID FROM spell);
UPDATE spelldifficulty SET DifficultySpellID_3 = NULL WHERE DifficultySpellID_3 NOT IN (SELECT ID FROM spell);
UPDATE spelldifficulty SET DifficultySpellID_4 = NULL WHERE DifficultySpellID_4 NOT IN (SELECT ID FROM spell);

-- spelleffectcamerashakes table
UPDATE spelleffectcamerashakes SET CameraShake_1 = NULL WHERE CameraShake_1 NOT IN (SELECT ID FROM camerashakes);
UPDATE spelleffectcamerashakes SET CameraShake_2 = NULL WHERE CameraShake_2 NOT IN (SELECT ID FROM camerashakes);
UPDATE spelleffectcamerashakes SET CameraShake_3 = NULL WHERE CameraShake_3 NOT IN (SELECT ID FROM camerashakes);

-- spellitemenchantment table
UPDATE spellitemenchantment SET Effect_1 = NULL WHERE Effect_1 NOT IN (SELECT ID FROM spell);
UPDATE spellitemenchantment SET Effect_2 = NULL WHERE Effect_2 NOT IN (SELECT ID FROM spell);
UPDATE spellitemenchantment SET Effect_3 = NULL WHERE Effect_3 NOT IN (SELECT ID FROM spell);
UPDATE spellitemenchantment SET ItemVisual = NULL WHERE ItemVisual NOT IN (SELECT ID FROM itemvisuals);
UPDATE spellitemenchantment SET Src_ItemID = NULL WHERE Src_ItemID NOT IN (SELECT ID FROM item);
UPDATE spellitemenchantment SET Condition_Id = NULL WHERE Condition_Id NOT IN (SELECT ID FROM spellitemenchantmentcondition);
UPDATE spellitemenchantment SET RequiredSkillID = NULL WHERE RequiredSkillID NOT IN (SELECT ID FROM skillline);

-- spellshapeshiftform table
UPDATE spellshapeshiftform SET CreatureType = NULL WHERE CreatureType NOT IN (SELECT ID FROM creaturetype);
UPDATE spellshapeshiftform SET AttackIconID = NULL WHERE AttackIconID NOT IN (SELECT ID FROM spellicon);
UPDATE spellshapeshiftform SET CreatureDisplayID_1 = NULL WHERE CreatureDisplayID_1 NOT IN (SELECT ID FROM creaturedisplayinfo);
UPDATE spellshapeshiftform SET CreatureDisplayID_2 = NULL WHERE CreatureDisplayID_2 NOT IN (SELECT ID FROM creaturedisplayinfo);
UPDATE spellshapeshiftform SET CreatureDisplayID_3 = NULL WHERE CreatureDisplayID_3 NOT IN (SELECT ID FROM creaturedisplayinfo);
UPDATE spellshapeshiftform SET CreatureDisplayID_4 = NULL WHERE CreatureDisplayID_4 NOT IN (SELECT ID FROM creaturedisplayinfo);
UPDATE spellshapeshiftform SET PresetSpellID_1 = NULL WHERE PresetSpellID_1 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_2 = NULL WHERE PresetSpellID_2 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_3 = NULL WHERE PresetSpellID_3 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_4 = NULL WHERE PresetSpellID_4 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_5 = NULL WHERE PresetSpellID_5 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_6 = NULL WHERE PresetSpellID_6 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_7 = NULL WHERE PresetSpellID_7 NOT IN (SELECT ID FROM spell);
UPDATE spellshapeshiftform SET PresetSpellID_8 = NULL WHERE PresetSpellID_8 NOT IN (SELECT ID FROM spell);

-- spellvisual table
UPDATE spellvisual SET PrecastKit = NULL WHERE PrecastKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET CastKit = NULL WHERE CastKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET ImpactKit = NULL WHERE ImpactKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET StateKit = NULL WHERE StateKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET StateDoneKit = NULL WHERE StateDoneKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET ChannelKit = NULL WHERE ChannelKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET MissileModel = NULL WHERE MissileModel NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisual SET MissileSound = NULL WHERE MissileSound NOT IN (SELECT ID FROM soundentries);
UPDATE spellvisual SET AnimEventSoundID = NULL WHERE AnimEventSoundID NOT IN (SELECT ID FROM soundentries);
UPDATE spellvisual SET CasterImpactKit = NULL WHERE CasterImpactKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET TargetImpactKit = NULL WHERE TargetImpactKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET MissileTargetingKit = NULL WHERE MissileTargetingKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET InstantAreaKit = NULL WHERE InstantAreaKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET ImpactAreaKit = NULL WHERE ImpactAreaKit NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisual SET PersistentAreaKit = NULL WHERE PersistentAreaKit NOT IN (SELECT ID FROM spellvisualkit);

-- spellvisualkit table
UPDATE spellvisualkit SET StartAnimID = NULL WHERE StartAnimID NOT IN (SELECT ID FROM animationdata);
UPDATE spellvisualkit SET AnimID = NULL WHERE AnimID NOT IN (SELECT ID FROM animationdata);
UPDATE spellvisualkit SET HeadEffect = NULL WHERE HeadEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET ChestEffect = NULL WHERE ChestEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET BaseEffect = NULL WHERE BaseEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET LeftHandEffect = NULL WHERE LeftHandEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET RightHandEffect = NULL WHERE RightHandEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET BreathEffect = NULL WHERE BreathEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET LeftWeaponEffect = NULL WHERE LeftWeaponEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET RightWeaponEffect = NULL WHERE RightWeaponEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET SpecialEffect_1 = NULL WHERE SpecialEffect_1 NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET SpecialEffect_2 = NULL WHERE SpecialEffect_2 NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET SpecialEffect_3 = NULL WHERE SpecialEffect_3 NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET WorldEffect = NULL WHERE WorldEffect NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE spellvisualkit SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);
UPDATE spellvisualkit SET ShakeID = NULL WHERE ShakeID NOT IN (SELECT ID FROM spelleffectcamerashakes);

-- spellvisualkitmodelattach table
UPDATE spellvisualkitmodelattach SET ParentSpellVisualKitID = NULL WHERE ParentSpellVisualKitID NOT IN (SELECT ID FROM spellvisualkit);
UPDATE spellvisualkitmodelattach SET SpellVisualEffectNameID = NULL WHERE SpellVisualEffectNameID NOT IN (SELECT ID FROM spellvisualeffectname);

-- stationery table
UPDATE stationery SET ItemID = NULL WHERE ItemID NOT IN (SELECT ID FROM item);

-- talent table
UPDATE talent SET TabID = NULL WHERE TabID NOT IN (SELECT ID FROM talenttab);
UPDATE talent SET SpellRank_1 = NULL WHERE SpellRank_1 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_2 = NULL WHERE SpellRank_2 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_3 = NULL WHERE SpellRank_3 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_4 = NULL WHERE SpellRank_4 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_5 = NULL WHERE SpellRank_5 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_6 = NULL WHERE SpellRank_6 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_7 = NULL WHERE SpellRank_7 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_8 = NULL WHERE SpellRank_8 NOT IN (SELECT ID FROM spell);
UPDATE talent SET SpellRank_9 = NULL WHERE SpellRank_9 NOT IN (SELECT ID FROM spell);
UPDATE talent SET RequiredSpellID = NULL WHERE RequiredSpellID NOT IN (SELECT ID FROM spell);

-- talenttab table
UPDATE talenttab SET SpellIconID = NULL WHERE SpellIconID NOT IN (SELECT ID FROM spellicon);

-- taxinodes table
UPDATE taxinodes SET ContinentID = NULL WHERE ContinentID NOT IN (SELECT ID FROM map);

-- taxipath table
UPDATE taxipath SET FromTaxiNode = NULL WHERE FromTaxiNode NOT IN (SELECT ID FROM taxinodes);
UPDATE taxipath SET ToTaxiNode = NULL WHERE ToTaxiNode NOT IN (SELECT ID FROM taxinodes);

-- taxipathnode table
UPDATE taxipathnode SET PathID = NULL WHERE PathID NOT IN (SELECT ID FROM taxipath);
UPDATE taxipathnode SET ContinentID = NULL WHERE ContinentID NOT IN (SELECT ID FROM map);

-- terraintype table
UPDATE terraintype SET FootstepSprayRun = NULL WHERE FootstepSprayRun NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE terraintype SET FootstepSprayWalk = NULL WHERE FootstepSprayWalk NOT IN (SELECT ID FROM spellvisualeffectname);
UPDATE terraintype SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM terraintypesounds);

-- transportanimation table
UPDATE transportanimation SET SequenceID = NULL WHERE SequenceID NOT IN (SELECT ID FROM animationdata);

-- uisoundlookups table
UPDATE uisoundlookups SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);

-- vehicle table
UPDATE vehicle SET PowerDisplayID_1 = NULL WHERE PowerDisplayID_1 NOT IN (SELECT ID FROM powerdisplay);
UPDATE vehicle SET PowerDisplayID_2 = NULL WHERE PowerDisplayID_2 NOT IN (SELECT ID FROM powerdisplay);
UPDATE vehicle SET PowerDisplayID_3 = NULL WHERE PowerDisplayID_3 NOT IN (SELECT ID FROM powerdisplay);

-- vehicleuiindseat table
UPDATE vehicleuiindseat SET VehicleUIIndicatorID = NULL WHERE VehicleUIIndicatorID NOT IN (SELECT ID FROM vehicleuiindicator);

-- vocaluisounds table
UPDATE vocaluisounds SET RaceID = NULL WHERE RaceID NOT IN (SELECT ID FROM chrraces);
UPDATE vocaluisounds SET MaleNormalSound = NULL WHERE MaleNormalSound NOT IN (SELECT ID FROM soundentries);
UPDATE vocaluisounds SET FemaleNormalSound = NULL WHERE FemaleNormalSound NOT IN (SELECT ID FROM soundentries);
UPDATE vocaluisounds SET MalePissedSound = NULL WHERE MalePissedSound NOT IN (SELECT ID FROM soundentries);
UPDATE vocaluisounds SET FemalePissedSound = NULL WHERE FemalePissedSound NOT IN (SELECT ID FROM soundentries);

-- weaponimpactsounds table
UPDATE weaponimpactsounds SET ImpactSoundID_1 = NULL WHERE ImpactSoundID_1 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_2 = NULL WHERE ImpactSoundID_2 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_3 = NULL WHERE ImpactSoundID_3 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_4 = NULL WHERE ImpactSoundID_4 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_5 = NULL WHERE ImpactSoundID_5 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_6 = NULL WHERE ImpactSoundID_6 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_7 = NULL WHERE ImpactSoundID_7 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_8 = NULL WHERE ImpactSoundID_8 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_9 = NULL WHERE ImpactSoundID_9 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET ImpactSoundID_10 = NULL WHERE ImpactSoundID_10 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_1 = NULL WHERE CritImpactSoundID_1 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_2 = NULL WHERE CritImpactSoundID_2 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_3 = NULL WHERE CritImpactSoundID_3 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_4 = NULL WHERE CritImpactSoundID_4 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_5 = NULL WHERE CritImpactSoundID_5 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_6 = NULL WHERE CritImpactSoundID_6 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_7 = NULL WHERE CritImpactSoundID_7 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_8 = NULL WHERE CritImpactSoundID_8 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_9 = NULL WHERE CritImpactSoundID_9 NOT IN (SELECT ID FROM soundentries);
UPDATE weaponimpactsounds SET CritImpactSoundID_10 = NULL WHERE CritImpactSoundID_10 NOT IN (SELECT ID FROM soundentries);

-- weaponswingsounds2 table
UPDATE weaponswingsounds2 SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);

-- weather table
UPDATE weather SET AmbienceID = NULL WHERE AmbienceID NOT IN (SELECT ID FROM soundentries);

-- wmoareatable table
UPDATE wmoareatable SET SoundProviderPref = NULL WHERE SoundProviderPref NOT IN (SELECT ID FROM soundproviderpreferences);
UPDATE wmoareatable SET SoundProviderPrefUnderwater = NULL WHERE SoundProviderPrefUnderwater NOT IN (SELECT ID FROM soundproviderpreferences);
UPDATE wmoareatable SET AmbienceID = NULL WHERE AmbienceID NOT IN (SELECT ID FROM soundambience);
UPDATE wmoareatable SET ZoneMusic = NULL WHERE ZoneMusic NOT IN (SELECT ID FROM zonemusic);
UPDATE wmoareatable SET AreaTableID = NULL WHERE AreaTableID NOT IN (SELECT ID FROM areatable);
UPDATE wmoareatable SET IntroSound = NULL WHERE IntroSound NOT IN (SELECT ID FROM zoneintromusictable);

-- worldmaparea table
UPDATE worldmaparea SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE worldmaparea SET AreaID = NULL WHERE AreaID NOT IN (SELECT ID FROM areatable);
UPDATE worldmaparea SET DisplayMapID = NULL WHERE DisplayMapID NOT IN (SELECT ID FROM map);
UPDATE worldmaparea SET DefaultDungeonFloor = NULL WHERE DefaultDungeonFloor NOT IN (SELECT ID FROM dungeonmap);

-- worldmapcontinent table
UPDATE worldmapcontinent SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);

-- worldmapoverlay table
UPDATE worldmapoverlay SET MapAreaID = NULL WHERE MapAreaID NOT IN (SELECT ID FROM worldmaparea);
UPDATE worldmapoverlay SET AreaID_1 = NULL WHERE AreaID_1 NOT IN (SELECT ID FROM areatable);
UPDATE worldmapoverlay SET AreaID_2 = NULL WHERE AreaID_2 NOT IN (SELECT ID FROM areatable);
UPDATE worldmapoverlay SET AreaID_3 = NULL WHERE AreaID_3 NOT IN (SELECT ID FROM areatable);
UPDATE worldmapoverlay SET AreaID_4 = NULL WHERE AreaID_4 NOT IN (SELECT ID FROM areatable);

-- worldmaptransforms table
UPDATE worldmaptransforms SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE worldmaptransforms SET NewMapID = NULL WHERE NewMapID NOT IN (SELECT ID FROM map);
UPDATE worldmaptransforms SET NewDungeonMapID = NULL WHERE NewDungeonMapID NOT IN (SELECT ID FROM dungeonmap);

-- worldsafelocs table
UPDATE worldsafelocs SET Continent = NULL WHERE Continent NOT IN (SELECT ID FROM map);

-- worldstateui table
UPDATE worldstateui SET MapID = NULL WHERE MapID NOT IN (SELECT ID FROM map);
UPDATE worldstateui SET AreaID = NULL WHERE AreaID NOT IN (SELECT ID FROM areatable);

-- worldstatezonesounds table
UPDATE worldstatezonesounds SET AreaID = NULL WHERE AreaID NOT IN (SELECT ID FROM areatable);
UPDATE worldstatezonesounds SET WMOAreaID = NULL WHERE WMOAreaID NOT IN (SELECT ID FROM wmoareatable);
UPDATE worldstatezonesounds SET ZoneintroMusicID = NULL WHERE ZoneintroMusicID NOT IN (SELECT ID FROM zoneintromusictable);
UPDATE worldstatezonesounds SET ZoneMusicID = NULL WHERE ZoneMusicID NOT IN (SELECT ID FROM zonemusic);
UPDATE worldstatezonesounds SET SoundAmbienceID = NULL WHERE SoundAmbienceID NOT IN (SELECT ID FROM soundambience);
UPDATE worldstatezonesounds SET SoundProviderPreferencesID = NULL WHERE SoundProviderPreferencesID NOT IN (SELECT ID FROM soundproviderpreferences);

-- zoneintromusictable table
UPDATE zoneintromusictable SET SoundID = NULL WHERE SoundID NOT IN (SELECT ID FROM soundentries);

-- zonemusic table
UPDATE zonemusic SET Sounds_1 = NULL WHERE Sounds_1 NOT IN (SELECT ID FROM soundentries);
UPDATE zonemusic SET Sounds_2 = NULL WHERE Sounds_2 NOT IN (SELECT ID FROM soundentries);

