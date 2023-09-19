DROP TABLE IF EXISTS `SpellMissileMotion`; 
CREATE TABLE `SpellMissileMotion` ( `ID` INT NOT NULL DEFAULT '0', `Name` TEXT NULL, `ScriptBody` TEXT NULL, `Flags` INT NOT NULL DEFAULT '0', `MissileCount` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellMissileMotion` VALUES (13,"Parabola","local angle = 0
local maxMagnitude = startDistance * .15

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (19,"Spiral Vortex","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,7); 
INSERT INTO `SpellMissileMotion` VALUES (20,"Drunken Missiles","local maxMagnitude = 1.5
local minSpeedScalar = .7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 1000)) + cos((rand2 * 1000) + (time * 200))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)
",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (22,"Metawheel","local outerWheelSpinRate = 600
local outerWheelMag = 1.5
local innerWheelSpinRate = 800
local innerWheelMagBase = .75
local innerWheelMagVariance = .25
local innerWheelOscillateRate = 300

transAngle = time * outerWheelSpinRate
transMag = outerWheelMag * (1 - progress)
local innerMag = innerWheelMagBase + (innerWheelMagVariance * sin(time * innerWheelOscillateRate))
if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount - 1)
	transRight = innerMag * cos((time * innerWheelSpinRate) + (missileIndex * anglePerMissile))
	transUp = innerMag * sin((time * innerWheelSpinRate ) + (missileIndex * anglePerMissile))
end",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (23,"Forward Spin","local spinRate = 720

modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (24,"Boomerang","local angle = 90
local maxMagnitude = startDistance * .2
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (25,"Spinning Wave","local startAngle = 0
local finalAngle = 720
local wavesPerSec = 2
local maxMagnitude = 3

transAngle = startAngle + ((finalAngle - startAngle) * progress)
transMag = sin(time * wavesPerSec * 360) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (26,"Wave Beam","local waveHeight = .8
local wavesPerSec = 4

transUp = waveHeight * sin(time * wavesPerSec * 360)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (35,"Glaive","local spinRate = 360
local angle = 90
local maxMagnitude = startDistance * .1

modelYaw = 90
modelRoll = time * spinRate
modelPitch = 90

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (36,"Meteor Strike","local magnitude = totalDistance * .5

transUp = magnitude * ( 1 - progress )
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (37,"Orbital Strike","local magnitude = totalDistance * 2

transUp = magnitude * ( 1 - progress )
transFront = distanceToImpactPos
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (38,"Forward Spin + Parabola","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 360

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (39,"Spirit Fountain","--
-- This is actually more like a heat-seeking missile
-- That always misses. 
-- However, if you use it with a Nearby-Circumference (Dest)
-- It looks awesome! 
-- Check out 37099 for an example.
--
local angle = 0
local maxMagnitude = startDistance*.75

transAngle = angle

if ( progress > .5 ) then
	transFront = (progress) / 2
else
	transFront = ((progress) * 1.5 - 0.5 )
end

transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
	
transFront = transFront * totalDistance",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (40,"Fountain","local angle = 0
local maxMagnitude = startDistance * .75

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (41,"Rocket Spiral","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

-- Add Upward Arc
transUp = (progress * 2) - 1
transUp = (1 - (transUp * transUp)) * startDistance * .15

transFront = transFront + -distanceToFirePos * (1 - progress)",0,7); 
INSERT INTO `SpellMissileMotion` VALUES (61,"Shrink","scale = 1 - progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (62,"Grow","scale = progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (81,"Spiral Vortex (3 Missiles)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (101,"Roll (Clockwise)","local spinRate = 720

modelRoll = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (121,"Snake","local waveHeight = .8
local wavesPerSec = 2

transRight = waveHeight * sin(time * wavesPerSec * 360) * ( 1 - progress ) * 2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (122,"Snake (half frequency)","local waveHeight = .8
local wavesPerSec = 1

transRight = waveHeight * sin(time * wavesPerSec * 360) * ( 1 - progress ) * 2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (123,"Spiral Vortex (2 Missiles)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (124,"Parabola (-90 Pitch)","local angle = 0
local maxMagnitude = startDistance * .15
modelPitch = -90

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (125,"Parabola (-90 to -45) (Flag Throw)","local angle = 0
local maxMagnitude = startDistance * .15
modelPitch = -90 + 45 * progress

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (141,"Grow (x3)","scale = 3 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (142,"Booterang","local angle = 90
local maxMagnitude = startDistance * .2
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelYaw = time * spinRate
modelPitch = 90",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (161,"Spin Around Caster","local outerWheelSpinRate = 360 	-- 1 spin / sec
local outerWheelMag = 2			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	--local anglePerMissile = 360 / (missileCount - 1)
	--missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle )
transRight = outerWheelMag * sin ( missileAngle )
transUp = -distanceToFirePos",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (162,"Spin Around Caster  (3)","local outerWheelSpinRate = 360 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle )
transRight = outerWheelMag * sin ( missileAngle )
transUp = -distanceToFirePos",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (163,"Spin Around Caster Slow (3)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle )
transRight = outerWheelMag * sin ( missileAngle )
transUp = -distanceToFirePos",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (181,"Spiral (3 Missiles)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle )
transRight = outerWheelMag * sin ( missileAngle )
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (182,"Spiral Inward (3 Missiles)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle ) * (1 - progress) * 2
transRight = outerWheelMag * sin ( missileAngle ) * (1 - progress) * 2
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (201,"Axe Boomerang","local angle = -90
local maxMagnitude = startDistance * .2
local spinRate = 720

modelRoll = 90

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (202,"Axe Boomerang Return","local angle = 90
local maxMagnitude = startDistance * .2
local spinRate = 720

modelRoll = 90

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelYaw = time * spinRate

transFront = distanceToImpactPos - distanceToFirePos",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (221,"Black Temple - Glaive Throw (Illidan)","modelRoll = time * 90",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (222,"Black Temple - Glaives Return (Illidan)","modelRoll = time * 90",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (223,"Rotation Test","local angle = 90
local maxMagnitude = startDistance * .2
local yawSpin = 1080

transAngle = angle
--transMag = (progress * 2) - 1
--transMag = (1 - (transMag * transMag)) * maxMagnitude
--modelYaw = time * yawSpin
--modelRoll = progress * 90
modelRoll = time * 500",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (224,"Parabola (High)","local angle = 0
local maxMagnitude = startDistance * .30

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (225,"Spiral","local spinRate = 720

modelRoll = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (226,"Soul Vortex (3 Missiles)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

--progress = 1 - progress

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (227,"Black Temple - Akama Soul Retrieve (Do Not Reuse)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transUp = distanceToImpactPos - distanceToFirePos
transMag = 10 * (1-progress) * (1-progress)

transFront = distanceToImpactPos * (1 - progress) * (1 - progress)",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (241,"Multi-shot Parabola (8 Missiles)","local angle = 0
local maxMagnitude = startDistance * .50
local spread = 5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transRight = (rand1 - 0.5) * spread * progress
transUp = (rand2 - 0.5) * spread * progress",0,8); 
INSERT INTO `SpellMissileMotion` VALUES (261,"Grow (1 -> 3)","scale = 1 + 2 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (321,"Grow (1 -> 3) - Model Reversed","scale = 1 + 2 * progress
modelYaw = 180",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (341,"Forward Spin + Parabola (High)","local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 360

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (361,"Parabola (Top Spin)","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (362,"Parabola (Pitch Spin)","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (381,"Test Missile - LAB","local startAngle = 0
local degreesPerSec = 720
local maxMagnitude = 1
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (382,"Possessed Knives","speedScalar = 0.1 + 35 * progress * progress
transUp  = (1.4 - 2 * rand1) * (1 - progress)
transRight  = (1 - 2 * rand2) * (1 - progress)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (383,"Twin Wave - Horizontal","
local waveHeight = 1.5
local wavesPerSec = 0.7

if (missileIndex == 0) then
transRight = waveHeight * sin(time * wavesPerSec * 360)
end

if (missileIndex == 1) then
transRight = - waveHeight * sin(time * wavesPerSec * 360)
end",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (384,"Twin Waves - Double","
local waveHeight = 1.5
local wavesPerSec = 0.7

if (missileIndex == 0) then
transRight = waveHeight * sin(time * wavesPerSec * 360)
end

if (missileIndex == 1) then
transRight = - waveHeight * sin(time * wavesPerSec * 360)
end
--[[
if (missileIndex == 2) then
transUp = waveHeight * sin(time * wavesPerSec * 360) /2
end

if (missileIndex == 3) then
transUp = - waveHeight * sin(time * wavesPerSec * 360) /2
end ]]",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (385,"Split Four Ways","
local spread = 1.2
local distanceToFireMin = 5
local distanceToFireMax = 7
local spreadSpeed = 0.1
local finalSpeed = 1.5

if ( distanceToFirePos > distanceToFireMin and distanceToFirePos < distanceToFireMax ) then
   speedScalar = spreadSpeed
   if (missileIndex == 0) then
   transUp = spread * ( distanceToFirePos - distanceToFireMin ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 1) then
   transUp = -spread * ( distanceToFirePos - distanceToFireMin   ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 2) then
   transRight = spread * ( distanceToFirePos - distanceToFireMin   ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 3) then
   transRight = -spread * ( distanceToFirePos - distanceToFireMin    ) / ( distanceToFireMax - distanceToFireMin )
   end
end

if ( distanceToFirePos > distanceToFireMax ) then
   speedScalar = finalSpeed
   if (missileIndex == 0) then
   transUp = spread
   end
   if (missileIndex == 1) then
   transUp = -spread
   end
   if (missileIndex == 2) then
   transRight = spread
   end
   if (missileIndex == 3) then
   transRight = -spread
   end
end
",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (386,"Possessed Knives x8","speedScalar = 0.1 + 35 * progress * progress
transUp  = (1.4 - 2 * rand1) * (1 - progress)
transRight  = (1 - 2 * rand2) * (1 - progress)",0,8); 
INSERT INTO `SpellMissileMotion` VALUES (401,"Spin (Roll) - 1080","local spinRate = 1080

modelRoll = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (421,"Zul'Aman - Skull Throw","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 720

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (441,"Forward Spin + Parabola (Very High)","local angle = 0
local maxMagnitude = startDistance * .90
local spinRate = 360

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (482,"Soul Vortex (3 Missiles - No Kickback)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 2.5
local maxKickBack = 0

--progress = 1 - progress

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (501,"Parabola (Low)","local angle = 0
local maxMagnitude = startDistance * .10

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (521,"Parabola (Top Spin, High)","local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (541,"Crazy Launch (1 Missile)","local outerWheelSpinRate = 1     -- 180 = 1 spin / sec
local outerWheelMag = 1
local missileAngle = 1

outerWheelSpinRate = 360 - 400 * (progress)
speedScalar = sin(100 * progress) + 0.1
missileAngle = outerWheelSpinRate * time
outerWheelMag = 10 * sin (500 * progress)
transFront = outerWheelMag * cos ( missileAngle )
transRight = outerWheelMag * sin ( missileAngle )
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (542,"Parabola (Very High)","local angle = 0
local maxMagnitude = startDistance * .60

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (561,"Meandering Missile (1)","local maxMagnitude = 1.0
local minSpeedScalar = 1.0
local maxSpeedScalar = 1.0
local randscalar = 100
local timescalar = 50
 
local angle = 0
local maxArcMagnitude = startDistance * .35

local magnitude = (progress * 1.9) - 1

magnitude = 1 

transRight = (sin((rand1 * randscalar * progress) + (time * randscalar)) + sin((rand2 * randscalar * progress) + (time * timescalar))) * magnitude
transUp = (sin((rand2 * randscalar * progress) + (time * randscalar)) + sin((rand1 * randscalar * progress) + (time * timescalar))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxArcMagnitude
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (581,"Meandering Missile Soul (1)","local maxMagnitude = 1.0
local minSpeedScalar = 1.0
local maxSpeedScalar = 1.0
local randscalar = 100
local timescalar = 50
 
local angle = 0
local maxMagnitude = startDistance * .35

local magnitude = (progress * 1.9) - 1

local Xmagnitude = 4 
local Ymagnitude = 2

transRight = (sin((rand1 * randscalar * progress)+ (time * randscalar)) + sin((rand2 * randscalar * progress))) * Xmagnitude
transUp = (sin((rand2 * randscalar * progress) + (time * randscalar)) + sin((rand1 * randscalar * progress) + (time * timescalar))) * Ymagnitude
transUp = transUp - 0
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (601,"Time-Warped Shot","
local slowProgressStart = 0.4
local slowProgressEnd = 0.65
local slowSpeed = 0.3
local finalSpeed = 6

speedScalar = finalSpeed

if ( progress > slowProgressStart and progress < slowProgressEnd ) then
   speedScalar = slowSpeed
end

",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (621,"Parabola (Pitch and Yaw Spin, High Altitude)","local angle = 0
local maxMagnitude = startDistance * 1
local spinRateP = 180
local spinRateY = 45

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude


modelPitch = time * spinRateP
modelYaw = time * spinRateY",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (641,"Multi-Shot (3 Missiles)","-- spread out as the missiles travel
local outerWheelMag = 1.5 * progress
local missileAngle


if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	transAngle = anglePerMissile * missileIndex
end

transMag = outerWheelMag
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (661,"Big to Small to Big Scale","local m1x=0.4    --the first progress point where the missile is smallest
local m1y=0.4    --the scale of the missile at the point above

local m2x=0.6    --the first progress opint where the missile begins growing again
local m2y=0.4    --the scale of the missile at the point above


local slope
local intercept
if (progress <m1x) then
                slope=(1-m1y)/(0-m1x)
                intercept=1
elseif (progress<m2x) then
                slope=(m1y-m2y)/(m1x-m2x)
                intercept=m1y-slope*m1x
else
                slope=(m2y-1)/(m2x-1)
                intercept=1-slope
end
scale=slope*progress+intercept
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (681,"Creature - Drain Power Effect (Malacrass)","local startAngle = 0
local degreesPerSec = 720
local maxMagnitude = 1
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (701,"Forward Spin (Fast)","local spinRate = 1440

modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (721,"Triple Parabola (Low)","local angle = 0
local maxMagnitude = startDistance * .10

transAngle = angle
progress = math.fmod(progress * 3, 1)
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (722,"Triple Parabola (Low, Falloff) ","local angle = 0
local maxMagnitude = startDistance * .10

transAngle = angle
progress = math.fmod(progress * 3, 1)
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
transMag = transMag * (1 - progress)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (741,"Grow (1 -> 10)","scale = 10 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (761,"Paper Airlplane, Flying Machine ","
local minSpeedScalar = 1.0
local maxSpeedScalar = 1.0
local randscalar = 100
local timescalar = 50
 
local angle = 0
local maxMagnitude = startDistance * .20

local magnitude = (progress * 1.9) - 1

local Xmagnitude = 4 
local Ymagnitude = 2


local modProgress = 4*(-1*(progress*progress) + progress)

transRight = (sin((rand1 * randscalar * modProgress)+ (time * randscalar * modProgress)) + sin((rand2 * randscalar * modProgress))) * Xmagnitude
transUp = (sin((rand2 * randscalar * modProgress) + (time * randscalar)) + sin((rand1 * randscalar * modProgress) + (time * timescalar))) * Ymagnitude
transUp = transUp - 0
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (781,"Paper Airlplane, Zeppelin","local randscalar = 100
local timescalar = 100
local wavefreqscalar = 50
local yawlimit = 60
local rolllimit = 25
local minSpeedScalar = 1.0
local maxSpeedScalar = 1.0

local angle = 0
local maxMagnitude = startDistance * .10

local Ymagnitude = 1
local Xmagnitude = 3

local modProgress = 4*(-1*(progress*progress) + progress)

modelYaw = sin(time*timescalar*rand1) * yawlimit * rand2
modelRoll = sin(time*timescalar*rand2) * rolllimit * rand1
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)
transUp = (sin((rand3 * randscalar * modProgress) + (time * randscalar)) + sin((rand1 * randscalar * modProgress) + (time * wavefreqscalar))) * Ymagnitude

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (801,"Always Miss","transRight = progress * 2
transUp = progress * 4
transFront = progress * 20",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (821,"Orbital Strike (Reverse)","local magnitude = totalDistance * 2.0

transUp = totalDistance + -magnitude * ( progress )
transFront = distanceFromImpactPos

-- speedScalar = 0.8",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (841,"Drunken Missiles Slow","local maxMagnitude = 0.5
local minSpeedScalar = .9
local maxSpeedScalar = 1.1

local angle = 0
local maxArcMagnitude = startDistance * .75


local magnitude = (progress * 1.9) - 1
magnitude = (1 - (magnitude * magnitude * magnitude * magnitude)) * maxMagnitude

transRight = (sin((rand1 * 1000) + (time * 700)) + cos((rand2 * 1000) + (time * 100))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxArcMagnitude",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (861,"Multi-shot Parabola (4 Missiles)","local angle = 0
local maxMagnitude = startDistance * .50
local spread = 5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transRight = (rand1 - 0.5) * spread * progress
transUp = (rand2 - 0.5) * spread * progress",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (881,"Forward Spin (med) + Parabola (Random low)","local angle = 0
local randomMagnitudeScalar = rand1

if (randomMagnitudeScalar <= 0.33)then
	randomMagnitudeScalar = 0.20
elseif (randomMagnitudeScalar <= 0.66)then
	randomMagnitudeScalar = 0.30
elseif (randomMagnitudeScalar <= 0.99)then
	randomMagnitudeScalar = 0.40
end

local maxMagnitude = startDistance * randomMagnitudeScalar
local spinRate = 540

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (901,"Midsummer - Juggle Torch, Self","local missileSpeed = 0.42
local startSpeed = 20
local p0 = 0.5

local travelTime = (startDistance / missileSpeed) - 2.5
local v0 = startSpeed
local acc = (v0*travelTime + p0) / (travelTime*travelTime)

transUp = -acc*time*time + v0*time + p0

local spinRate = 1080
modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (921,"Midsummer - Juggle Torch (Quest)","local angle = 0
local maxMagnitude = (distanceToImpactPos) * 2

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

local spinRate = 1080
modelPitch = time * spinRate

speedScalar = 1",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (922,"Creature - Encapsulate (Felblaze)","scale = 0.10 + 1 * progress * progress
--speedScalar = 3 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (941,"Midsummer - Juggle Torch, Slow","local missileSpeed = 3.9
local startSpeed = 20
local p0 = 0

local travelTime = (startDistance / missileSpeed)
local v0 = startSpeed
local acc = (v0*travelTime + p0) / (travelTime*travelTime)

transUp = -acc*time*time + v0*time + p0

--transFront = -distanceToFirePos

local spinRate = 1420
modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (942,"Midsummer - Juggle Torch, Medium","local missileSpeed = 6
local startSpeed = 15
local p0 = 0

local travelTime = (startDistance / missileSpeed)
local v0 = startSpeed
local acc = (v0*travelTime + p0) / (travelTime*travelTime)

transUp = -acc*time*time + v0*time + p0

--transFront = -distanceToFirePos

local spinRate = 1500
modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (943,"Midsummer - Juggle Torch, Fast","local missileSpeed = 9
local startSpeed = 20
local p0 = 0

local travelTime = (startDistance / missileSpeed)
local v0 = startSpeed
local acc = (v0*travelTime + p0) / (travelTime*travelTime)

transUp = -acc*time*time + v0*time + p0

--transFront = -distanceToFirePos

local spinRate = 1600
modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (961,"Creature - Summon Void Sentinel (M'uru)","local degreesPerSec = 720
local maxMagnitude = 4

transAngle = (missileIndex / missileCount) * 360 + (time * degreesPerSec)
transMag = 1- progress
transMag = transMag * maxMagnitude
transUp = 5 * progress",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (981,"Creature - Transform Visual Missile (M'uru)","local sideMagnitude = startDistance * .3
local frontMagnitude = startDistance
local minAngle = -135
local maxAngle = -45
local collapseAngle = -90

speedScalar = .4 + (progress * 1.2)

transAngle = minAngle + (rand1 * (maxAngle - minAngle))
transAngle = (transAngle * (1 - progress)) + (collapseAngle * progress)
transMag = sin(progress * 480) * (1 - progress) * sideMagnitude
transUp = (rand2 - 0.5) * (15 * progress) - 2

transFront = sin(progress * 240) * (1 - progress) * frontMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1001,"Parabola (Very VERY High)","local angle = 0
local maxMagnitude = startDistance * .90

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1041,"Drunken Missiles (High Parabolic)","local maxMagnitude = 1.5
local minSpeedScalar = .7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 1000)) + cos((rand2 * 1000) + (time * 200))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 360

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (1061,"Parabola - Tree Tumble","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 120

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate
modelRoll = time * spinRate/2
modelPitch = time * spinRate/4",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1101,"Spiral + Parabola (Low, Random)","local angle = 0
local maxMagnitude = startDistance * .05
local spinRate = 720

if ( rand1 > 0.5 ) then
	spinRate = spinRate * -1
end

modelRoll = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1141,"Parabola (Pitch Spin, High)","local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1161,"Parabola (Spin, High)","local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1181,"Parabola (Top Spin, Very High)","local angle = 0
local maxMagnitude = startDistance * .60
local spinRate = 360

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1183,"Big to Small to Big Scale (shifted upwards)","local m1x=0.4    --the first progress point where the missile is smallest
local m1y=0.4    --the scale of the missile at the point above

local m2x=0.6    --the first progress opint where the missile begins growing again
local m2y=0.4    --the scale of the missile at the point above


local slope
local intercept
if (progress <m1x) then
                slope=(1-m1y)/(0-m1x)
                intercept=1
elseif (progress<m2x) then
                slope=(m1y-m2y)/(m1x-m2x)
                intercept=m1y-slope*m1x
else
                slope=(m2y-1)/(m2x-1)
                intercept=1-slope
end
scale=slope*progress+intercept

transUp=1.6",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1201,"Creature - Summon Telestra Clone (Telestra)","local angle = 0
local maxMagnitude = startDistance * .90

transAngle = angle
transMag = (progress * 2) - 1
transMag = 2*(1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1221,"Spiral Cyclone (Slow)","local numSpirals = 5
local radius = 5 * progress * (rand1 + .5)

local curAngle = numSpirals * progress * 360

transFront = (sin(curAngle) * radius) - distanceToFirePos
transRight = (cos(curAngle) * radius)

transUp = 1.5 * progress

speedScalar = .2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1241,"REUSEME","local magnitude = totalDistance * 2
local spinRate = 1080

transUp = magnitude * ( 1 - progress )
transFront = distanceToImpactPos
modelRoll = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1242,"Parabola (Pitch Spin, VERY VERY HIGH)","local angle = 0
local maxMagnitude = startDistance * 6
local spinRateP = 60

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude


modelPitch = time * spinRateP
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1261,"Creature - Spirit Burst Extra Visual (Ymiron)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle ) * (rand1*30) * time
transRight = outerWheelMag * sin ( missileAngle ) * (rand2*30) * time

transUp = distanceToFirePos*10",0,10); 
INSERT INTO `SpellMissileMotion` VALUES (1262,"Creature - Spirit Burst (Ymiron)","local angle = 0
local maxMagnitude = startDistance * .60

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1281,"Creature - Summon Avenging Spirit Visual (Ymiron)","
	transUp = (1 - progress) * 8


",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1301,"Grizzly Hills - Quest - Burning Oil","
local angle = 0
local maxMagnitude = 4

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude


local spread = 1
local distanceToFireMin = 5
local distanceToFireMax = 30
local spreadSpeed = 1
local finalSpeed = 1.5

if ( distanceToFirePos > distanceToFireMin and distanceToFirePos < distanceToFireMax ) then
   speedScalar = spreadSpeed
   if (missileIndex == 0) then
   transUp = spread * ( distanceToFirePos - distanceToFireMin ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 1) then
   transUp = -spread * ( distanceToFirePos - distanceToFireMin   ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 2) then
   transRight = spread * ( distanceToFirePos - distanceToFireMin   ) / ( distanceToFireMax - distanceToFireMin )
   end
   if (missileIndex == 3) then
   transRight = -spread * ( distanceToFirePos - distanceToFireMin    ) / ( distanceToFireMax - distanceToFireMin )
   end
end

if ( distanceToFirePos > distanceToFireMax ) then
   speedScalar = finalSpeed
   if (missileIndex == 0) then
   transUp = spread
   end
   if (missileIndex == 1) then
   transUp = -spread
   end
   if (missileIndex == 2) then
   transRight = spread
   end
   if (missileIndex == 3) then
   transRight = -spread
   end
end",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (1321,"Tumbling Debris (Spin, Very High)","local angle = 0
local maxMagnitude = startDistance * .90
local spinRate = 1440

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate *rand1
modelYaw = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1322,"Tumbling Debris (Very High)","local angle = 0
local maxMagnitude = startDistance * .90
local spinRate = 1440

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1341,"Forward Spin (Med) + Grow (1->3)","local spinRate = 540

modelPitch = time * spinRate

scale = 1 + 2 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1361,"Parabola (Grow)","local angle = 0
local maxMagnitude = startDistance * .15

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

scale = progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1381,"Upper Deck - Ethereal Pet OnKill Give Essence","local maxHeight = 10

transUp = progress * (1 - progress) * maxHeight

--transFront = startDistance - 2 * distanceToFirePos  --this would reverse the direction of the missile
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1401,"Scale - 2.00","scale = 2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1421,"Parabola (Top Spin, Very VERY High)","local angle = 0
local maxMagnitude = startDistance * .60
local spinRate = 360

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1422,"Missile Swarm","local maxMagnitude = 0.5
local minSpeedScalar = 0.7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 100)) + cos((rand2 * 1000) + (time * 200))) * magnitude * (1-progress)
--transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)

",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (1441,"zzOLDCreature - Glare of the Tribunal (Tribunal)","
	if missileIndex == 1 then
		transRight =  (1 - progress) * 3
	else
		transRight =  (1 - progress) * -3
	end",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (1461,"Always Miss (Revised, Random)","transRight = 5 * (1 - progress * 2 * rand2)
transUp = 2 * (1 - progress * 2 * rand1)
transFront = 80 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1462,"Reverse Direction","transFront = startDistance - 2 * distanceToFirePos  --this would reverse the direction of the missile
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1481,"Parabola (Fast Spin, High)","local angle = 0
local maxMagnitude = startDistance * .30
local spinRate = 1440

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1501,"Accelerated Missile","speedScalar = 0.2 + 2 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1502,"Soul Vortex (7 Missiles)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

--progress = 1 - progress

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,7); 
INSERT INTO `SpellMissileMotion` VALUES (1503,"Soul Vortex (7 Missiles - Resyncced)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10
speedscalar = 0.5

--progress = 1 - progress

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,7); 
INSERT INTO `SpellMissileMotion` VALUES (1521,"Machine Gun","
if (missileIndex > 0) then
    transFront = progress * (3 - 2 * missileIndex)
end

",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1522,"Rocket Spiral (x3)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 10

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

-- Add Upward Arc
transUp = (progress * 2) - 1
transUp = (1 - (transUp * transUp)) * startDistance * .15

transFront = transFront + -distanceToFirePos * (1 - progress)",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1541,"Parabola (Pitch and Yaw Spin)","local angle = 0
local maxMagnitude = startDistance * 0.5
local spinRateP = 180
local spinRateY = 45

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude


modelPitch = time * spinRateP
modelYaw = time * spinRateY",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1542,"Parabola (Pitch and Yaw Spin, Low)","local angle = 0
local maxMagnitude = startDistance * 0.25
local spinRateP = 180
local spinRateY = 45

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude


modelPitch = time * spinRateP
modelYaw = time * spinRateY",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1561,"Reverse Test (maybe works?)","transMag = ((1 - progress) * distanceToImpactPos) + (progress * -distanceToFirePos)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1581,"Parabola (Pitch Spin, slow, low)","local angle = 0
local maxMagnitude = startDistance * .1
local spinRate = 120

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1601,"Creature - Raise Dead Effect (Anub'ar Necromancer)","local maxMagnitude = startDistance * .5
local spinRate = 360


transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = (rand1 * 5) * (time * spinRate)
speedScalar = (rand1 + 1)/2.5

transUp = rand1 * progress
transFront = rand2 * progress
transRight = rand3 * progress
",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (1621,"Parabola (Yaw Spin)","local angle = 0
local maxMagnitude = startDistance * 0.25
local spinRateY = 360

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelYaw = time * spinRateY",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1641,"Missile Swarm (1 Missile)","local maxMagnitude = 0.5
local minSpeedScalar = 0.7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 100)) + cos((rand2 * 1000) + (time * 200))) * magnitude * (1-progress)
--transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1661,"Multi-Shot (2 Missiles)","-- spread out as the missiles travel
local outerWheelMag = 1.5 * progress
local missileAngle


if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	transAngle = anglePerMissile * missileIndex
end

transMag = outerWheelMag
",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (1662,"Missile - 2","",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (1663,"Forward Spin (Med, Scale = 2)","scale = 2
local spinRate = 540

modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1664,"Shrink (Less)","scale = 1 - (progress / 2)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1684,"Creature - Ritual Strike (Svala)","local spinRate = 360

modelRoll = time * spinRate

transUp = progress * 3",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1704,"Drunken Missiles (2 Missiles)","local maxMagnitude = 1.5
local minSpeedScalar = .7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 1000)) + cos((rand2 * 1000) + (time * 200))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)
",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (1724,"Twin Waves - Double - Large","
local waveHeight = 15
local wavesPerSec = 0.3

if (missileIndex == 0) then
transRight = waveHeight * sin(time * wavesPerSec * 360)
end

if (missileIndex == 1) then
transRight = - waveHeight * sin(time * wavesPerSec * 360)
end

if (missileIndex == 2) then
transUp = waveHeight * sin(time * wavesPerSec * 360) /2
end

if (missileIndex == 3) then
transUp = - waveHeight * sin(time * wavesPerSec * 360) /2
end",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (1725,"Creature - Magic Sickle","local angle = 0
local maxMagnitude = startDistance * .20
local spinRate = -3600

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1726,"Creature - Summon Harpoon (Skadi)","local angle = 0
local maxMagnitude = startDistance * 2
local spinRate = 1080

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1744,"Creature - Arcane Swarm (Malygos)","local angle = 0
local maxMagnitude = startDistance * 3

transAngle = angle	

if progress < 0.3 then
	transMag = (1 - (((progress*3.33)-1)^2)) * 15
	speedScalar = .5
else
	transMag = (1 - (progress*1.43) +0.43) * 15
	speedScalar = 20 * progress * progress * progress
end


if progress <= .3 then
	transRight = (cos(progress*3000)) * 2 * (1-progress)
	transUp = (sin(progress*3000)) * 2 * (1-progress)
end",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1764,"Always Miss (Random, JZB)","transRight = progress * ( 5 * rand1)
transUp = progress * ( 4 * rand2)
transFront = progress * 10


",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1784,"Creature - Rock Shards (Archavon)","	
	modelPitch = -90
--	scale = progress

--	transRight = (missileIndex * 5) * (1-progress)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1804,"Flip Coin, Self","--[[

--Old script, was based on 

local missileSpeed = 10
local startSpeed = 20
local p0 = 0.5

local travelTime = (startDistance / missileSpeed)  -- - 2.5
local v0 = startSpeed
local acc = (v0*travelTime + p0) / (travelTime*travelTime)

--transUp = -acc*time*time + v0*time + p0

]]--

local spinRate = 1080
modelPitch = time * spinRate


-- distance = X (totalDistance / 2)
-- acceleration due to gravity = -9.8
-- velocity = v0 + a * t
-- position = p0 + v0 * t + 0.5 a * t * t

local initialPosition = 0;
local initialVelocity = 9.8; 
local initialDistance = startDistance - initialPosition;

local travelTime = initialDistance / initialVelocity;

local t = travelTime * progress

transUp = initialPosition + initialVelocity * t + -9.8 * t * t
transFront = 0",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1824,"Creature - Shadow Crash (Forgotten One)","local angle = 0
local maxMagnitude = startDistance * .40

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelRoll = progress * 6000",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1825,"Engineering - Rocket Turret","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 3
local maxKickBack = 12

--progress = 1 - progress
if ( rand1 < 0.5 ) then
	missileIndex = 1;
else
	missileIndex = 2;
end

transAngle = startAngle + ( missileIndex / 2 * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1844,"Creature - Ember Shower (Sandoval)","local angle = 0
local maxMagnitude = startDistance * .10 + (rand1 * 5)
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelRoll = progress * 3000",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1864,"Parabola (Very VERY high, -45 to -0) (bunny jump)","local angle = 0
local maxMagnitude = startDistance * .90
modelPitch = -45 + 45 * progress

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1865,"Parabola (Pitch Spin, Very High)","local angle = 0
local maxMagnitude = startDistance * .60
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1884,"Multi-Shot (7 Missiles, Rolling, Tight, Drunken)","-- spread out as the missiles travel
local outerWheelMag =  progress / 3
local missileAngle


local maxMagnitude = 1.0
local minSpeedScalar = .8
local maxSpeedScalar = 1.2

local magnitude = (progress * 1.9) - 1
magnitude = (1 - (magnitude * magnitude * magnitude * magnitude)) / 3

transRight = (sin((rand1 * 1000) + (time * 1000)) + cos((rand2 * 1000) + (time * 200))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)


if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	transAngle = anglePerMissile * missileIndex
end

modelRoll = (missileIndex + 2) * progress * 360

transMag = outerWheelMag
",0,7); 
INSERT INTO `SpellMissileMotion` VALUES (1904,"Creature - Arcane Swarm (Malygos)","local angle = 0
local maxMagnitude = startDistance * 3

transAngle = angle	

if progress < 0.3 then
	transMag = (1 - (((progress*3.33)-1)^2)) * 15
	speedScalar = .5

else
	transMag = (1 - (progress*1.43) +0.43) * 15
	speedScalar = 20 * progress * progress * progress
end


if progress <= .3 then
	transRight = (cos(progress*3000)) * 2 * (1-progress)
	transUp = (sin(progress*3000)) * 2 * (1-progress)
end",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1905,"Creature - Solar Flare (Elder Brightleaf)","local angle = 0
local maxMagnitude = startDistance * 1

transAngle = angle	

if progress < .3 then	
transMag = (1 - (((progress*3.33)-1)^2)) * 10
	speedScalar = .3
else
	transMag = (1 - (progress*1.43) +0.33) * 10
	speedScalar = 20 * progress * progress * progress
end
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1924,"Spiral + Spin (4 Missiles)","local spread = 1.2

local startAngle = 360 * missileIndex / missileCount;
local degreesPerSec = 180

transAngle = startAngle + (time * degreesPerSec)
transMag = spread;

local spinRate = 360
modelRoll = time * spinRate
",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (1964,"Spiral Inward (3 Missiles)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle ) * (1 - progress) * 2
transRight = outerWheelMag * sin ( missileAngle ) * (1 - progress) * 2
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1965,"Creature - Acivate Construct (Ignis)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 2.5			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle ) * (1 - progress) * 2 * progress
transRight = outerWheelMag * sin ( missileAngle ) * (1 - progress) * 2 * progress


local angle = 0
local maxMagnitude = startDistance * .50

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (1984,"Creature - Summon Proximity Mines (Mimiron - P1)","local angle = 0
local maxMagnitude = startDistance * .8
local spinRate = 540

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (1985,"Creautre - Rocket Strike (Mimiron)","local angle = 0
local maxMagnitude = 20

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

speedScalar = ((progress + .05)^1.5) * startDistance * .2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2004,"Creature - Laser Barrage (Mimiron)","
	if missileIndex == 1 then
		transRight = (progress * (rand1 - .50) * 10) + .75
		transUp = progress * (rand2 - .70) * 10
	elseif missileIndex == 2 then
		transRight = (progress * (rand2 - .50) * 10) - .75
		transUp = progress * (rand3 - .70) * 10
	else
		transRight = progress * (rand2 - .50) * 10
		transUp = progress * ((rand1 - .70) * 10) + .75
	end

transFront = progress * 3",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2024,"Forward Spin (fast) + Parabola","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 1080

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2025,"Creature - Rapid Burst Effect (Mimiron)","	if missileIndex == 1 then
		speedScalar = rand1/1.5 + 1
	elseif missileIndex == 2 then
		speedScalar = rand2/1.5 + 1
	else
		speedScalar = rand3/1.5 + 1
	end

	if missileIndex == 1 then
		transRight = progress * (rand1 - .50) + .5
		transUp = progress * (rand2 - .50)
	elseif missileIndex == 2 then
		transRight = progress * (rand2 - .50) - .5
		transUp = progress * (rand3 - .50)
	else
		transRight = progress * (rand2 - .50)
		transUp = progress * (rand1 - .50) + .5
	end",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2044,"Missile - 3","",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2064,"Morgan Test","local throwHeight = 32;
local progressAtFirstBounce = .45;
local heightOfFirstBounce = 10;
local progressAtSecondBounce = .75;
local heightOfSecondBounce = 7;
local spinRate = 360

modelPitch = time * spinRate
transUp = throwHeight * progress;

if (progress < progressAtFirstBounce) then

	local normalizedProgress = progress / progressAtFirstBounce;
	transUp = transUp - ((normalizedProgress * normalizedProgress) * throwHeight);

elseif (progress < progressAtSecondBounce) then

	local normalizedProgress = (progress - progressAtFirstBounce) /
		(progressAtSecondBounce - progressAtFirstBounce);

	local curHeight = (normalizedProgress * 2) - 1;
	curHeight = (1 - (curHeight * curHeight)) * heightOfFirstBounce;

	transUp = (transUp - throwHeight) + curHeight;

else

	local normalizedProgress = (progress - progressAtSecondBounce) /
		(1.0 - progressAtSecondBounce);

	local curHeight = (normalizedProgress * 2) - 1;
	curHeight = (1 - (curHeight * curHeight)) * heightOfSecondBounce;

	transUp = (transUp - throwHeight) + curHeight;

end",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2084,"Creature - Flame Leviathan - Rockets (Spiral)","local maxHeight = 5 + (startDistance * .08)

local newness = 1 - (progress * progress)

transAngle = (rand1 * 360) + (time * 400)

if progress < 0.05 then
	transMag = progress * 40
elseif progress < .1 then
	transMag = 2
elseif progress < .433333333 then
	transMag = 2 * (1 - ((progress - .1) * 3))
end

local transUp1 = (progress * 3.33) - 1
transUp1 = (1 - (transUp1 * transUp1)) * maxHeight

local transUp2 = (1.43 - (progress * 1.43)) * maxHeight

if progress < .2 then
	transUp = transUp1
elseif progress < .4 then
	transUp = transUp1 + ((transUp2 - transUp1) * ((progress - .2) * 5))
else
	transUp = transUp2
end

local accel = progress + .23
speedScalar = .05 + (8 * accel * accel * accel)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2104,"Boomerang (Return)","local angle = -90
local maxMagnitude = startDistance * .2
local spinRate = 720

progress = 1 - progress

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelYaw = time * spinRate


transFront = distanceToImpactPos - distanceToFirePos
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2124,"Creature - Laser Barrage","
	if missileIndex == 1 then
		transRight = (progress * (rand1 - .50) * 10) + .75
		transUp = progress * (rand2 - .70) * 10
	elseif missileIndex == 2 then
		transRight = (progress * (rand2 - .50) * 10) - .75
		transUp = progress * (rand3 - .70) * 10
	else
		transRight = progress * (rand2 - .50) * 10
		transUp = progress * ((rand1 - .70) * 10) + .75
	end

transFront = progress",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2144,"Creature - Summon Magnetic Core (Mimiron - P3)","local angle = 0
local maxMagnitude = startDistance * .4
local spinRate = 540

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2164,"Dan's Test Motion","transUp = 5",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2184,"Isle of Conquest - Place Seaforium Charge","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 1080

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2204,"Isle of Conquest - Glaive","local spinRate = 1080

modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2224,"Fountain (Flaming Cinder)","local angle = 0
local maxMagnitude = startDistance * .5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2244,"Snake (3 Missiles)","local waveHeight = .8
local wavesPerSec = 2

transRight = waveHeight * sin(time * wavesPerSec * 360) * ( 1 - progress ) * 2",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2284,"Isle of Conquest - Blade Salvo (Glaive Thrower)","modelPitch = 90
local spinRate = 1080

modelYaw = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2304,"Isle of Conquest - Dagger Throw (Generals)","local spinRate = 1080

modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2344,"Parabola (High, Pitch Spin)","local angle = 0
local maxMagnitude = startDistance * .3
local spinRate = 720

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2384,"Spiral Cyclone JS","local numSpirals = 2
local radius = 5 * progress * (rand1 + 0.5)

local curAngle = numSpirals * progress * 360

transFront = (sin(curAngle) * radius) - distanceToFirePos
transRight = (cos(curAngle) * radius)

transUp = 2 * progress",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (2404,"Spiral Flat JS","local numSpirals = 5
local minRadius = 10
local radius = minRadius + (10 * progress * (rand1 * 5))

local curAngle = numSpirals * progress * 360

transFront = (sin(curAngle) * radius) - distanceToFirePos
transRight = (cos(curAngle) * radius)

transUp = rand2 * 5",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2424,"Drunken Fountain (5 Missiles)","local angle = 0
local maxMagnitude = startDistance * .5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)

local magnitude = transMag * .15

transRight = (sin((rand1 * 1000) + (time * 400)) + cos((rand3 * 1000) + (time * 60))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 300)) + cos((rand1 * 1000) + (time * 100))) * magnitude
transFront = transFront +
	(sin((rand3 * 1000) + (time * 300)) + cos((rand2 * 1000) + (time * 100))) * magnitude

speedScalar = 1 - (progress * .5)",0,5); 
INSERT INTO `SpellMissileMotion` VALUES (2444,"Creature - Summon Ice Ring (Arthas Encounter)","local angle = 0
local maxMagnitude = startDistance * .8
--local spinRate = 1080

--transAngle = angle
--transMag = (progress * 2) - 1
--transMag = (1 - (transMag * transMag)) * maxMagnitude
--transUp = progress * 1.1
transUp = 20 + (progress * -19)
transFront = 3 + (progress * -3)

--modelPitch = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2464,"Forward Spin (fast) + Parabola + Grow (1 -> 3)","local angle = 0
local maxMagnitude = startDistance * .15
local spinRate = 1080

modelPitch = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

scale = 1 + 2 * progress",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2484,"Soul Vortex (10 Missiles - No Kickback)","local startAngle = 0
local degreesPerSec = 180
local maxMagnitude = 2.5
local maxKickBack = 0

--progress = 1 - progress

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude

--transUp = distanceToImpactPos - distanceToFirePos",0,10); 
INSERT INTO `SpellMissileMotion` VALUES (2504,"Creature - Soul Reaper Effect (Arthas Encounter)","local outerWheelSpinRate = 180 	-- 1 spin / sec
local outerWheelMag = 1			-- 1 yard
local missileAngle = outerWheelSpinRate * time

if (missileIndex > 0) then
	local anglePerMissile = 360 / (missileCount)
	missileAngle = missileAngle + anglePerMissile * missileIndex
end

transFront = outerWheelMag * cos ( missileAngle ) * (1 - progress) * 2
transRight = outerWheelMag * sin ( missileAngle ) * (1 - progress) * 2
",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2544,"Stinger Missile (always arrive in ~7 sec)","
transAngle = 0	

if (time < 7) then
	speedAbs = distanceToImpactPos / (7 - time)
else
	speedAbs = 100000
end

if progress < 0.4 then
	transMag = (1 - (((progress*3.33)-1)^2)) * 20
	speedAbs = speedAbs * 0.4
elseif progress < 0.9 then
	transMag = (1 - (progress*1.43) +0.43) * 20
	speedAbs = speedAbs * (progress^2)
else
	transMag = (1 - (progress*1.43) +0.43) * 20
end

",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2564,"Spiral + Spin (2 Missiles)","local spread = 1.2

local startAngle = 360 * missileIndex / missileCount;
local degreesPerSec = 180

transAngle = startAngle + (time * degreesPerSec)
transMag = spread;

local spinRate = 360
modelRoll = time * spinRate
",0,2); 
INSERT INTO `SpellMissileMotion` VALUES (2584,"Fast Spiral + Spin (4 Missiles)","local spread = .5

local startAngle = 360 * missileIndex / missileCount;
local degreesPerSec = 360

transAngle = startAngle + (time * degreesPerSec)
transMag = spread;

local spinRate = 360
modelRoll = time * spinRate
",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (2624,"Drunken Fountain (1 Missile)","local angle = 0
local maxMagnitude = startDistance * .5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)

local magnitude = transMag * .15

transRight = (sin((rand1 * 1000) + (time * 400)) + cos((rand3 * 1000) + (time * 60))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 300)) + cos((rand1 * 1000) + (time * 100))) * magnitude
transFront = transFront +
	(sin((rand3 * 1000) + (time * 300)) + cos((rand2 * 1000) + (time * 100))) * magnitude

speedScalar = 1 - (progress * .5)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2644,"Creature - Gunship Cannon Fire (Arthas Dungeon)","transUp = (progress * (rand1 - .5)) * 20
transRight = (progress * (rand2 - .5)) * 20

",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2645,"Creature - Ice Bomb (Sindragosa)","local angle = 0
local maxMagnitude = 20

local angle = 0
local maxMagnitude = startDistance * .10

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
speedAbs = totalDistance/5.5",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2664,"Spirtal + Spin","local spread = 1.2

local startAngle = 360 * missileIndex / missileCount;
local degreesPerSec = 180

transAngle = startAngle + (time * degreesPerSec)
transMag = spread;

local spinRate = 360
modelRoll = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2684,"Icecrown Dungeon - Destroy Wall, Sylvanas","transUp = ((progress * (rand1 - .5)) * 5) + (progress * 5)
transRight = (progress * (rand2 - .5)) * 20",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2704,"Fast Spiral + Spin (1 Missile)","local spread = .5

local startAngle = 360 * missileIndex / missileCount;
local degreesPerSec = 360

transAngle = startAngle + (time * degreesPerSec)
transMag = spread;

local spinRate = 360
modelRoll = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2744,"Triple Parabola (Medium)","local angle = 1
local maxMagnitude = startDistance * .20

transAngle = angle
progress = math.fmod(progress * 3, 1)
transMag = (progress * 2) - 1
transMag = (.85 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2764,"Stinger Missile (No speed mod)","
transAngle = 0	

--speedAbs = startDistance / 7.5

if progress < 0.4 then
	transMag = (1 - (((progress*3.33)-1)^2)) * 20
	speedAbs = speedAbs * .5
else
	transMag = (1 - (progress*1.43) +0.43) * 20
	speedAbs = speedAbs * (1.2+progress)^3
end

",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2784,"Parabola (Medium)","local angle = 0
local maxMagnitude = startDistance * .20

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2804,"Forward Spin + Triple Parabola (Low)","local angle = 1
local maxMagnitude = startDistance * .20
local spinRate = 360


transAngle = angle
progress = math.fmod(progress * 3, 1)
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
modelPitch = time * spinRate",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2824,"Drunken Fountain (3 Missiles)","local angle = 0
local maxMagnitude = startDistance * .5

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)

local magnitude = transMag * .15

transRight = (sin((rand1 * 1000) + (time * 400)) + cos((rand3 * 1000) + (time * 60))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 300)) + cos((rand1 * 1000) + (time * 100))) * magnitude
transFront = transFront +
	(sin((rand3 * 1000) + (time * 300)) + cos((rand2 * 1000) + (time * 100))) * magnitude

speedScalar = 1 - (progress * .5)",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2825,"Spiral + Parabola","local waveHeight = 1
local wavesPerSec = 2
local angle = 2
local maxMagnitude = startDistance * .15
local spinRate = 720

modelRoll = time * spinRate
transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2828,"Drunken Missiles (1 Missile)","local maxMagnitude = 1.5
local minSpeedScalar = .7
local maxSpeedScalar = 1.5

local magnitude = (progress * 1.9) - 1
magnitude = 1 - (magnitude * magnitude * magnitude * magnitude)

transRight = (sin((rand1 * 1000) + (time * 1000)) + cos((rand2 * 1000) + (time * 200))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 700)) + cos((rand1 * 1000) + (time * 300))) * magnitude
speedScalar = minSpeedScalar + ((maxSpeedScalar - minSpeedScalar) * rand3)
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2830,"Creature - Nightmares (Green Dragon Encounter)","modelPitch = 90",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2831,"Spiral (Small) Flat","local radius = (progress * 8)

local curAngle = progress * 90

transFront = (sin(curAngle) * radius) - distanceToFirePos
transRight = (cos(curAngle) * radius)",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2832,"Spiral Vortex (4 Missiles) (Tight, Don't Spiral)","local startAngle = 45
local degreesPerSec = 0
local maxMagnitude = 1.75
local maxKickBack = 5

transAngle = startAngle + ((missileIndex / missileCount) * 360) + (time * degreesPerSec)
transMag = 1 - progress
transMag = (transMag * transMag * 2) - 1
transMag = (1 - (transMag * transMag))
transFront = transMag * -maxKickBack
transMag = transMag * maxMagnitude
",0,4); 
INSERT INTO `SpellMissileMotion` VALUES (2833,"Festergut - Malleable Ooze","local throwHeight = 32.5;
local progressAtFirstBounce = .45;
local heightOfFirstBounce = 10;
local progressAtSecondBounce = .75;
local heightOfSecondBounce = 7;
local spinRate = 360

modelPitch = time * spinRate
transUp = throwHeight * progress;

if (progress < progressAtFirstBounce) then

	local normalizedProgress = progress / progressAtFirstBounce;
	transUp = transUp - ((normalizedProgress * normalizedProgress) * throwHeight);

elseif (progress < progressAtSecondBounce) then

	local normalizedProgress = (progress - progressAtFirstBounce) /
		(progressAtSecondBounce - progressAtFirstBounce);

	local curHeight = (normalizedProgress * 2) - 1;
	curHeight = (1 - (curHeight * curHeight)) * heightOfFirstBounce;

	transUp = (transUp - throwHeight) + curHeight;

else

	local normalizedProgress = (progress - progressAtSecondBounce) /
		(1.0 - progressAtSecondBounce);

	local curHeight = (normalizedProgress * 2) - 1;
	curHeight = (1 - (curHeight * curHeight)) * heightOfSecondBounce;

	transUp = (transUp - throwHeight) + curHeight;

end",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2834,"Creature - Broken Frostmourne Soul Missiles (Arthas Enc","local numSpirals = 5
local minRadius = 10
local radius = minRadius + (10 * progress * (rand1 * 2))

local curAngle = numSpirals * progress * -360

transFront = ((sin(curAngle) * radius * rand3)) * progress
transRight = (cos(curAngle) * radius * rand3) * progress

transUp = (rand2 * 5)* progress

scale = (rand2 + 1) * 2",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2835,"Random Scale (1->2)","scale = 1 + 1*rand1",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2836,"Creature - Player Wins, Frostmourne Room - Missiles","local angle = 0
local maxMagnitude = startDistance * .35

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

transFront = -distanceToFirePos * (1 - progress)

local magnitude = transMag * .15

transRight = (sin((rand1 * 1000) + (time * 400)) + cos((rand3 * 1000) + (time * 60))) * magnitude
transUp = (sin((rand2 * 1000) + (time * 300)) + cos((rand1 * 1000) + (time * 100))) * magnitude
transFront = transFront +
	(sin((rand3 * 1000) + (time * 300)) + cos((rand2 * 1000) + (time * 100))) * magnitude

speedScalar = 1 - (progress * .5)",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2837,"Icecrown Raid - Arthas - Frostmoune Breaks","local angle = 0
local maxMagnitude = startDistance * .75
local spinRate = 540

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude

modelPitch = time * spinRate *rand1
modelYaw = time * spinRate
",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2839,"Snake (half amp, rand wave)","local waveHeight = .2
local wavesPerSec = 2 + (rand1 * 3)

transRight = waveHeight * sin(time * wavesPerSec * 360) * ( 1 - progress ) * 2",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2840,"Stinger Missile (always arrive in ~5 sec)","
transAngle = 0	

if (time < 5) then
	speedAbs = distanceToImpactPos / (5 - time)
else
	speedAbs = 100000
end

if progress < 0.4 then
	transMag = (1 - (((progress*3.33)-1)^2)) * 20
	speedAbs = speedAbs * 0.4
elseif progress < 0.9 then
	transMag = (1 - (progress*1.43) +0.43) * 20
	speedAbs = speedAbs * (progress^2)
else
	transMag = (1 - (progress*1.43) +0.43) * 20
end

",0,3); 
INSERT INTO `SpellMissileMotion` VALUES (2841,"Creature - Meteor Strike (Halion)","local angle = 0
local maxMagnitude = 20

local angle = 0
local maxMagnitude = startDistance * .10

transAngle = angle
transMag = (progress * 2) - 1
transMag = (1 - (transMag * transMag)) * maxMagnitude
speedAbs = totalDistance/6.5",0,1); 
INSERT INTO `SpellMissileMotion` VALUES (2853,"Creature - Tsunami (Throne of Tides)","	scale = (1/(progress+.2))",0,1); 
