DROP TABLE IF EXISTS `SpellDescriptionVariables`; 
CREATE TABLE `SpellDescriptionVariables` ( `ID` INT NOT NULL DEFAULT '0', `Variables` TEXT NULL, PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `SpellDescriptionVariables` VALUES (1,"$funny=$?s48165[${$m1/10}.5]?a66109[${13}][${($m1*3)+17}]
$maybe=$?s48165[${1}.5][${$66109m2*4/$<funny>}.2]
$storm=${0.14*$AP*$<maybe>}

"); 
INSERT INTO `SpellDescriptionVariables` VALUES (28,"$min=$?s54825[${$m1/2}][${$m1}]
$max=$?s54825[${$M1/2}][${$M1}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (29,"$junk=1"); 
INSERT INTO `SpellDescriptionVariables` VALUES (30,"$total=${$m1*5}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (31,"$total=${$m1*5}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (61,"$mana=$?s55441[${$16191m1+1}][${$16191m1}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (62,"$charges=$?s58673[${4+2}][${4}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (63,"$dur1=$?s56801[${6+2+5}][${6+2}]
$dur2=$?s56801[${6+4+5}][${6+4}]
$dur3=$?s56801[${6+6+5}][${6+6}]
$dur4=$?s56801[${6+8+5}][${6+8}]
$dur5=$?s56801[${6+10+5}][${6+10}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (64,"$bonus=$?s56807[${$m3*1.4}][${$m3}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (81,"$weapon=$?s58657[${$m2*1.2}][${$m2}]
$bonus=$?s58657[${$m1*$m2/100*1.2}][${$m1*$m2/100}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (82,"$absorb=$?s58635[${$m1*$AR*0.01*(100+$58635m1)*0.01}][${$m1*$AR*0.01}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (83,"$percent=$?s56216[${$m1*(1+$56216m1/100)}][${$m1}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (84,"$damage=$?s63333[${$m1*1.15}][${$m1}]
$healing=$?s63333[${$m1*1.15*1.5}][${$m1*1.5}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (86,"$images=$?s63093[${$63093m1+$55342m2}][${$55342m2}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (87,"$threat=$?s63326[${$m3*-1+$63326m1}][${$m3}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (101,"$chance=$?s55439[${$m2+$55439m1}][${$m2}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (102,"$bonus=${$m1*0.4}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (121,"$duration=$?s56846[${3}][${5}]
$mult=$?s56846[${4}][${2}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (162,"$mult=$?s55673[${1.2}][${1}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (164,"$glyph=$?s56810[${3}]$[${0}]
$mult1=$?s14165[${25}][${0}]
$mult=$?s14166[${50}][${$<mult1>}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (165,"$dur=$?s54818[${8}][${6}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (166,"$bonus=${$m1*0.5}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (167,"$arctic1=$?s31674[${1.01}][${1}]
$arctic2=$?s31675[${1.02}][${$<arctic1>}]
$arctic3=$?s31676[${1.03}][${$<arctic2>}]
$arctic4=$?s31677[${1.04}][${$<arctic3>}]
$arctic5=$?s31678[${1.05}][${$<arctic4>}]
$piercing1=$?s11151[${1.02}][${1}]
$piercing2=$?s12952[${1.04}][${$<piercing1>}]
$piercing3=$?s12953[${1.06}][${$<piercing2>}]
$mult=${$<arctic5>*$<piercing3>}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (169,"$mult1=$?s14162[${1.07}][${1.0}]
$mult2=$?s14163[${1.14}][${$<mult1>}]
$mult=$?s14164[${1.2}][${$<mult2>}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (170,"$heal=$?a63279[${$m1*1.2}][${$m1}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (171,"$aggression1=$?s18427[${103}][${100}]
$aggression2=$?s18428[${106}][${$<aggression1>}]
$aggression3=$?s18429[${109}][${$<aggression2>}]
$aggression4=$?s61330[${112}][${$<aggression3>}]
$percent=$?s61331[${115}][${$<aggression4>}]

"); 
INSERT INTO `SpellDescriptionVariables` VALUES (172,"$opportunity1=$?s14057[${110}][${100}]
$percent=$?s14072[${120}][${$<opportunity1>}]"); 
INSERT INTO `SpellDescriptionVariables` VALUES (175,"$tap1=$?s18182[${$18182m1*0.01+1}][${1}]
$tap2=$?s18183[${$18183m1*0.01+1}][${$<tap1>}]
$mult=${$<tap2>}
"); 
INSERT INTO `SpellDescriptionVariables` VALUES (176,"$genesis1=$?s57810[${1+0.01*$57810m1}][${1}]
$genesis2=$?s57811[${1+0.01*$57811m1}][${$<genesis1>}]
$genesis3=$?s57812[${1+0.01*$57812m1}][${$<genesis2>}]
$genesis4=$?s57813[${1+0.01*$57813m1}][${$<genesis3>}]
$genesis5=$?s57814[${1+0.01*$57814m1}][${$<genesis4>}]
$mult=${$<genesis5>}"); 
INSERT INTO `SpellDescriptionVariables` VALUES (181,"$base=($pl-1)*3+10
$melee=${$AP*0.22}
$spell=${$sp*0.376}
$which=${$gt($<melee>,$<spell>)}"); 
