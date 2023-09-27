DROP TABLE IF EXISTS `VocalUISounds`; 
CREATE TABLE `VocalUISounds` ( `ID` INT NOT NULL DEFAULT '0', `VocalUIEnum` INT NOT NULL DEFAULT '0', `RaceID` INT NOT NULL DEFAULT '0', `NormalSoundID_1` INT NOT NULL DEFAULT '0', `NormalSoundID_2` INT NOT NULL DEFAULT '0', `PissedSoundID_1` INT NOT NULL DEFAULT '0', `PissedSoundID_2` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8; 
INSERT INTO `VocalUISounds` VALUES (9,0,1,1875,1999,626,626),
(10,1,1,2618,2581,628,-1),
(11,2,1,1876,2000,631,-1),
(12,3,1,1877,2001,631,-1),
(13,4,1,1878,2002,633,-1),
(14,5,1,1879,2003,635,-1),
(15,6,1,-1,-1,-1,-1),
(16,7,1,-1,-1,638,-1),
(17,8,1,2620,2985,663,-1),
(18,9,1,-1,-1,-1,-1),
(19,10,1,1881,2005,-1,-1),
(20,11,1,1882,2006,-1,-1),
(21,12,1,1883,2584,-1,-1),
(22,13,1,2622,2585,-1,-1),
(23,14,1,1884,2008,-1,-1),
(24,15,1,1885,2009,-1,-1),
(25,16,1,-1,-1,-1,-1),
(26,17,1,1886,2010,-1,-1),
(27,18,1,2624,2586,-1,-1),
(170,0,3,1581,1654,0,0),
(171,1,3,2601,2889,0,0),
(172,5,3,1586,1658,0,0),
(173,2,3,1652,1655,0,0),
(174,3,3,1584,1656,0,0),
(175,4,3,1585,1657,0,0),
(176,6,3,-1,-1,0,0),
(177,7,3,-1,-1,0,0),
(178,10,3,1588,1660,0,0),
(179,11,3,1589,1661,0,0),
(180,12,3,1590,1662,0,0),
(181,14,3,1591,1663,0,0),
(182,15,3,1592,1664,0,0),
(183,17,3,1593,2895,0,0),
(184,19,3,-1,-1,0,0),
(185,20,3,1595,1667,0,0),
(186,21,3,-1,-1,0,0),
(187,22,3,1598,1669,0,0),
(188,23,3,-1,-1,0,0),
(189,24,3,-1,-1,0,0),
(190,25,3,1601,1672,0,0),
(191,26,3,1602,1676,0,0),
(192,27,3,1639,1674,0,0),
(193,28,3,1608,1675,0,0),
(194,29,3,1609,1673,0,0),
(195,30,3,1616,1677,0,0),
(196,31,3,1618,1665,0,0),
(197,32,3,-1,-1,0,0),
(198,33,3,1623,1679,0,0),
(199,34,3,1623,1680,0,0),
(200,35,3,1624,1681,0,0),
(201,36,3,-1,-1,0,0),
(202,37,3,1610,1683,0,0),
(203,38,3,1614,1684,0,0),
(204,39,3,1630,1686,0,0),
(205,40,3,1630,1686,0,0),
(206,41,3,1605,1687,0,0),
(207,43,3,1606,1688,0,0),
(208,44,3,1631,1689,0,0),
(209,45,3,1626,1690,0,0),
(210,46,3,1633,1691,0,0),
(211,47,3,1627,1692,0,0),
(212,48,3,1634,1693,0,0),
(213,49,3,1625,1694,0,0),
(214,50,3,1607,1695,0,0),
(215,51,3,1653,1696,0,0),
(216,52,3,1613,1697,0,0),
(217,53,3,1640,1698,0,0),
(218,54,3,1635,1699,0,0),
(219,55,3,1617,1700,0,0),
(220,56,3,-1,-1,0,0),
(221,57,3,1636,1702,0,0),
(222,58,3,-1,-1,0,0),
(223,59,3,1612,1704,0,0),
(224,60,3,1632,1705,0,0),
(225,61,3,1637,1706,0,0),
(226,62,3,1615,1707,0,0),
(227,0,7,1708,1709,0,0),
(228,2,7,1710,1765,0,0),
(229,3,7,1711,1766,0,0),
(230,4,7,1712,1767,0,0),
(231,5,7,1713,1768,0,0),
(232,7,7,-1,-1,0,0),
(233,10,7,1715,1770,0,0),
(234,11,7,1716,1771,0,0),
(235,12,7,1717,1772,0,0),
(236,14,7,1718,1773,0,0),
(237,15,7,1719,1774,0,0),
(238,17,7,1720,1775,0,0),
(239,19,7,-1,-1,0,0),
(240,20,7,1722,1777,0,0),
(241,21,7,-1,-1,0,0),
(242,22,7,1724,1779,0,0),
(243,24,7,-1,-1,0,0),
(244,25,7,1726,1783,0,0),
(245,26,7,1727,1784,0,0),
(246,27,7,1728,1785,0,0),
(247,28,7,1729,1786,0,0),
(248,29,7,1730,1787,0,0),
(249,30,7,1731,1788,0,0),
(250,31,7,1732,1789,0,0),
(251,32,7,-1,-1,0,0),
(252,33,7,1734,1791,0,0),
(253,34,7,1735,1792,0,0),
(254,35,7,1736,1793,0,0),
(255,36,7,-1,-1,0,0),
(256,37,7,1740,1795,0,0),
(257,38,7,1741,1796,0,0),
(258,39,7,1743,1798,0,0),
(259,40,7,1743,1798,0,0),
(260,41,7,1744,1799,0,0),
(261,43,7,1745,1800,0,0),
(262,44,7,1746,1801,0,0),
(263,45,7,1747,1802,0,0),
(264,46,7,1748,1803,0,0),
(265,47,7,1749,1804,0,0),
(266,48,7,1750,1805,0,0),
(267,49,7,1751,1806,0,0),
(268,50,7,1752,1807,0,0),
(269,51,7,1753,1808,0,0),
(270,52,7,1754,1809,0,0),
(271,53,7,1755,1810,0,0),
(272,54,7,1756,1811,0,0),
(273,55,7,1757,1812,0,0),
(274,56,7,-1,-1,0,0),
(275,57,7,1759,1814,0,0),
(276,58,7,-1,-1,0,0),
(277,59,7,1761,1816,0,0),
(278,60,7,1762,1817,0,0),
(279,61,7,1763,1818,0,0),
(280,62,7,1764,1819,0,0),
(281,0,8,1820,1930,0,0),
(282,23,7,-1,-1,0,0),
(283,2,8,1821,1931,0,0),
(284,3,8,1822,1932,0,0),
(285,4,8,1823,1933,0,0),
(286,5,8,1824,1934,0,0),
(287,7,8,-1,-1,0,0),
(288,10,8,1826,1936,0,0),
(289,11,8,1827,1937,0,0),
(290,12,8,1828,1938,0,0),
(291,14,8,1829,1939,0,0),
(292,15,8,1830,1940,0,0),
(293,17,8,1831,1941,0,0),
(294,19,8,-1,-1,0,0),
(295,20,8,1833,1943,0,0),
(296,21,8,-1,-1,0,0),
(297,22,8,1835,1945,0,0),
(298,23,8,-1,-1,0,0),
(299,24,8,-1,-1,0,0),
(300,25,8,1838,1948,0,0),
(301,26,8,1839,1949,0,0),
(302,27,8,1840,1950,0,0),
(303,28,8,1841,1951,0,0),
(304,29,8,1842,1952,0,0),
(305,30,8,1843,1953,0,0),
(306,31,8,1844,1954,0,0),
(307,32,8,-1,-1,0,0),
(308,33,8,1846,1956,0,0),
(309,34,8,1847,1957,0,0),
(310,35,8,1848,1958,0,0),
(311,36,8,-1,-1,0,0),
(312,37,8,1850,1960,0,0),
(313,38,8,1851,1961,0,0),
(314,39,8,1853,1963,0,0),
(315,40,8,1853,1963,0,0),
(316,41,8,1854,1964,0,0),
(317,43,8,1855,1965,0,0),
(318,44,8,1856,1966,0,0),
(319,45,8,1857,1967,0,0),
(320,46,8,1858,1968,0,0),
(321,47,8,1859,1983,0,0),
(322,48,8,1860,1984,0,0),
(323,49,8,1861,1985,0,0),
(324,50,8,1862,1986,0,0),
(325,51,8,1863,1987,0,0),
(326,52,8,1864,1988,0,0),
(327,53,8,1865,1989,0,0),
(328,54,8,1866,1990,0,0),
(329,55,8,1867,1991,0,0),
(330,56,8,-1,-1,0,0),
(331,57,8,1869,1993,0,0),
(332,58,8,-1,-1,0,0),
(333,59,8,1871,1995,0,0),
(334,60,8,1872,1996,0,0),
(335,61,8,1873,1997,0,0),
(336,62,8,1874,1998,0,0),
(337,19,1,-1,-1,0,0),
(338,20,1,1888,2012,0,0),
(339,21,1,-1,-1,0,0),
(340,22,1,1890,2014,0,0),
(341,23,1,-1,-1,0,0),
(342,24,1,-1,-1,0,0),
(343,25,1,1893,2017,0,0),
(344,26,1,1894,2018,0,0),
(345,27,1,1895,2019,0,0),
(346,28,1,1896,2020,0,0),
(347,29,1,1897,2021,0,0),
(348,30,1,1898,2022,0,0),
(349,31,1,1899,2023,0,0),
(350,32,1,-1,-1,0,0),
(351,33,1,1901,2025,0,0),
(352,34,1,1902,2026,0,0),
(353,35,1,1903,2027,0,0),
(354,36,1,-1,-1,0,0),
(355,37,1,1905,2029,0,0),
(356,38,1,1906,2030,0,0),
(357,39,1,1908,1798,0,0),
(358,40,1,1908,2032,0,0),
(359,41,1,1909,2033,0,0),
(360,43,1,1910,2034,0,0),
(361,44,1,1911,2035,0,0),
(362,45,1,1912,2036,0,0),
(363,46,1,1913,2037,0,0),
(364,47,1,1914,2038,0,0),
(365,48,1,1915,2039,0,0),
(366,49,1,1916,2040,0,0),
(367,50,1,1917,2041,0,0),
(368,51,1,1918,2042,0,0),
(369,52,1,1919,2043,0,0),
(370,53,1,1920,2044,0,0),
(371,54,1,1921,2045,0,0),
(372,55,1,1922,2046,0,0),
(373,56,1,-1,-1,0,0),
(374,57,1,1924,2048,0,0),
(375,58,1,-1,-1,0,0),
(376,59,1,1926,2050,0,0),
(377,60,1,1927,2051,0,0),
(378,61,1,1928,2052,0,0),
(379,62,1,1929,2053,0,0),
(380,0,5,2054,2173,0,0),
(381,2,5,2055,2174,0,0),
(382,3,5,2056,2175,0,0),
(383,4,5,2057,2176,0,0),
(384,5,5,2058,2177,0,0),
(385,7,5,-1,-1,0,0),
(386,10,5,2060,2179,0,0),
(387,11,5,2062,2180,0,0),
(388,14,5,2063,2183,0,0),
(389,15,5,2064,2184,0,0),
(390,17,5,2065,2185,0,0),
(391,19,5,-1,-1,0,0),
(392,20,5,2067,2187,0,0),
(393,21,5,-1,-1,0,0),
(394,22,5,2069,2189,0,0),
(395,23,5,-1,-1,0,0),
(396,24,5,-1,-1,0,0),
(397,25,5,2072,2192,0,0),
(398,26,5,2073,2193,0,0),
(399,27,5,2074,2194,0,0),
(400,28,5,2075,2195,0,0),
(401,29,5,2076,2196,0,0),
(402,30,5,2077,2197,0,0),
(403,31,5,2078,2198,0,0),
(404,32,5,-1,-1,0,0),
(405,33,5,2080,2200,0,0),
(406,34,5,2081,2201,0,0),
(407,35,5,2082,2202,0,0),
(408,36,5,-1,-1,0,0),
(409,37,5,2084,2204,0,0),
(410,38,5,2085,2205,0,0),
(411,39,5,2096,2207,0,0),
(412,40,5,2096,2207,0,0),
(413,41,5,2097,2208,0,0),
(414,43,5,2098,2209,0,0),
(415,44,5,2099,2210,0,0),
(416,45,5,2100,2211,0,0),
(417,46,5,2101,2212,0,0),
(418,47,5,2102,2213,0,0),
(419,48,5,2103,2214,0,0),
(420,49,5,2104,2215,0,0),
(421,50,5,2105,2216,0,0),
(422,51,5,2106,2217,0,0),
(423,52,5,2107,2218,0,0),
(424,53,5,2108,2219,0,0),
(425,54,5,2109,2220,0,0),
(426,55,5,2110,2221,0,0),
(427,56,5,-1,-1,0,0),
(428,57,5,2112,2223,0,0),
(429,58,5,-1,-1,0,0),
(430,59,5,2114,2225,0,0),
(431,60,5,2115,2226,0,0),
(432,61,5,2116,2227,0,0),
(433,62,5,2117,2228,0,0),
(434,0,4,2118,2229,0,0),
(435,2,4,2119,2230,0,0),
(436,3,4,2120,2231,0,0),
(437,4,4,2121,2232,0,0),
(438,5,4,2122,2233,0,0),
(439,7,4,-1,-1,0,0),
(440,10,4,2124,2235,0,0),
(441,11,4,2125,2236,0,0),
(442,12,4,2126,2237,0,0),
(443,14,4,2127,2238,0,0),
(444,15,4,2128,2239,0,0),
(445,17,4,2129,2240,0,0),
(446,19,4,-1,-1,0,0),
(447,20,4,2131,2242,0,0),
(448,21,4,-1,-1,0,0),
(449,22,4,2133,2244,0,0),
(450,23,4,-1,-1,0,0),
(451,24,4,-1,-1,0,0),
(452,25,4,2136,2247,0,0),
(453,26,4,2137,2248,0,0),
(454,27,4,2138,2249,0,0),
(455,28,4,2139,2250,0,0),
(456,29,4,2140,2251,0,0),
(457,30,4,2141,2252,0,0),
(458,31,4,2142,2253,0,0),
(459,32,4,-1,-1,0,0),
(460,33,4,2144,2255,0,0),
(461,34,4,2145,2256,0,0),
(462,35,4,2146,2257,0,0),
(463,36,4,-1,-1,0,0),
(464,37,4,2148,2259,0,0),
(465,38,4,2149,2260,0,0),
(466,39,4,2151,2262,0,0),
(467,40,4,2151,2262,0,0),
(468,41,4,2152,2263,0,0),
(469,43,4,2153,2264,0,0),
(470,44,4,2154,2265,0,0),
(471,45,4,2155,2266,0,0),
(472,46,4,2156,2267,0,0),
(473,47,4,2157,2268,0,0),
(474,48,4,2158,2269,0,0),
(475,49,4,2159,2270,0,0),
(476,50,4,2160,2271,0,0),
(477,51,4,2161,2272,0,0),
(478,52,4,2162,2273,0,0),
(479,53,4,2163,2274,0,0),
(480,54,4,2164,2275,0,0),
(481,55,4,2165,2276,0,0),
(482,56,4,-1,-1,0,0),
(483,57,4,2167,2278,0,0),
(484,58,4,-1,-1,0,0),
(485,59,4,2169,2280,0,0),
(486,60,4,2170,2281,0,0),
(487,61,4,2171,2282,0,0),
(488,62,4,2172,2283,0,0),
(489,12,5,2181,2182,0,0),
(490,0,2,2284,2341,0,0),
(491,2,2,2285,2342,0,0),
(492,3,2,2286,2343,0,0),
(493,4,2,2287,2344,0,0),
(494,5,2,2288,2345,0,0),
(495,7,2,-1,-1,0,0),
(496,10,2,2290,2347,0,0),
(497,11,2,2291,2348,0,0),
(498,12,2,2292,2349,0,0),
(499,14,2,2293,2350,0,0),
(500,15,2,2294,2351,0,0),
(501,17,2,2295,2352,0,0),
(502,19,2,-1,-1,0,0),
(503,20,2,2297,2354,0,0),
(504,21,2,-1,-1,0,0),
(505,22,2,2299,2356,0,0),
(506,23,2,-1,-1,0,0),
(507,24,2,-1,-1,0,0),
(508,25,2,2302,2359,0,0),
(509,26,2,2305,2360,0,0),
(510,27,2,2306,2361,0,0),
(511,28,2,2307,2362,0,0),
(512,29,2,2308,2363,0,0),
(513,30,2,2309,2364,0,0),
(514,31,2,2310,2365,0,0),
(515,32,2,-1,-1,0,0),
(516,33,2,2312,2367,0,0),
(517,34,2,2313,2368,0,0),
(518,35,2,2314,2369,0,0),
(519,36,2,-1,-1,0,0),
(520,37,2,2316,2371,0,0),
(521,38,2,2317,2372,0,0),
(522,39,2,2319,2374,0,0),
(523,40,2,2319,2374,0,0),
(524,41,2,2320,2375,0,0),
(525,43,2,2321,2376,0,0),
(526,44,2,2322,2377,0,0),
(527,45,2,2323,2378,0,0),
(528,46,2,2324,2379,0,0),
(529,47,2,2325,2380,0,0),
(530,48,2,2326,2381,0,0),
(531,49,2,2327,2382,0,0),
(532,50,2,2328,2383,0,0),
(533,51,2,2329,2384,0,0),
(534,52,2,2330,2385,0,0),
(535,53,2,2331,2386,0,0),
(536,54,2,2332,2387,0,0),
(537,55,2,2333,2388,0,0),
(538,56,2,-1,-1,0,0),
(539,57,2,2335,2390,0,0),
(540,58,2,-1,-1,0,0),
(541,59,2,2337,2392,0,0),
(542,60,2,2338,2393,0,0),
(543,61,2,2339,2394,0,0),
(544,62,2,2340,2395,0,0),
(545,0,6,2396,2397,0,0),
(546,2,6,2399,2398,0,0),
(547,3,6,2400,2401,0,0),
(548,4,6,2403,2402,0,0),
(549,5,6,2404,2405,0,0),
(550,7,6,-1,-1,0,0),
(551,10,6,2408,2409,0,0),
(552,11,6,2411,2410,0,0),
(553,12,6,2412,2413,0,0),
(554,14,6,2415,2414,0,0),
(555,15,6,2416,2417,0,0),
(556,17,6,2419,2418,0,0),
(557,19,6,-1,-1,0,0),
(558,20,6,2422,2423,0,0),
(559,21,6,-1,-1,0,0),
(560,22,6,2426,2427,0,0),
(561,23,6,-1,-1,0,0),
(562,24,6,-1,-1,0,0),
(563,25,6,2432,2433,0,0),
(564,26,6,2435,2434,0,0),
(565,27,6,2436,2437,0,0),
(566,28,6,2439,2438,0,0),
(567,29,6,2440,2441,0,0),
(568,30,6,2443,2442,0,0),
(569,31,6,2444,2445,0,0),
(570,32,6,-1,-1,0,0),
(571,33,6,2448,2449,0,0),
(572,34,6,2451,2450,0,0),
(573,35,6,2452,2453,0,0),
(574,36,6,-1,-1,0,0),
(575,37,6,2456,2457,0,0),
(576,38,6,2459,2458,0,0),
(577,39,6,2463,2462,0,0),
(578,40,6,2463,2462,0,0),
(579,41,6,2465,2464,0,0),
(580,43,6,2466,2467,0,0),
(581,44,6,2469,2468,0,0),
(582,45,6,2471,2470,0,0),
(583,46,6,2472,2473,0,0),
(584,47,6,2475,2474,0,0),
(585,48,6,2476,2477,0,0),
(586,49,6,2479,2478,0,0),
(587,50,6,2480,2481,0,0),
(588,51,6,2483,2482,0,0),
(589,52,6,2484,2485,0,0),
(590,53,6,2487,2486,0,0),
(591,54,6,2488,2489,0,0),
(592,55,6,2491,2490,0,0),
(593,56,6,-1,-1,0,0),
(594,57,6,2495,2494,0,0),
(595,58,6,-1,-1,0,0),
(596,59,6,2499,2498,0,0),
(597,60,6,2500,2501,0,0),
(598,61,6,2503,2502,0,0),
(599,62,6,2504,2505,0,0),
(600,63,1,2626,2565,0,0),
(601,65,1,2628,2563,0,0),
(602,64,1,2627,2564,0,0),
(603,63,6,2568,2922,0,0),
(604,63,5,2637,2571,0,0),
(605,42,1,2625,2587,0,0),
(606,1,6,2588,2914,0,0),
(607,6,6,-1,-1,0,0),
(608,8,6,2986,2916,0,0),
(609,9,6,0,-1,0,0),
(610,13,6,2616,2918,0,0),
(611,16,6,-1,-1,0,0),
(612,18,6,2591,2920,0,0),
(613,42,6,2592,2921,0,0),
(614,64,6,2567,2923,0,0),
(615,65,6,2566,2924,0,0),
(616,1,5,2629,2593,0,0),
(617,6,5,-1,-1,0,0),
(618,8,5,2631,2595,0,0),
(619,9,5,-1,-1,0,0),
(620,13,5,2633,2597,0,0),
(621,16,5,-1,-1,0,0),
(622,18,5,2635,2599,0,0),
(623,42,5,2636,2600,0,0),
(624,64,5,2638,2570,0,0),
(625,65,5,2639,2569,0,0),
(626,8,3,2603,2891,0,0),
(627,9,3,-1,-1,0,0),
(628,13,3,2605,2893,0,0),
(629,16,3,-1,-1,0,0),
(630,18,3,2607,2896,0,0),
(631,42,3,2608,2897,0,0),
(632,63,3,2572,2898,0,0),
(633,64,3,2573,2899,0,0),
(634,65,3,2574,2900,0,0),
(635,1,8,2609,2973,0,0),
(636,6,8,-1,-1,0,0),
(637,8,8,2987,2975,0,0),
(638,9,8,0,-1,0,0),
(639,13,8,2611,2977,0,0),
(640,16,8,-1,-1,0,0),
(641,18,8,2613,2979,0,0),
(642,42,8,2614,2980,0,0),
(643,63,8,2576,2981,0,0),
(644,64,8,2577,2982,0,0),
(645,65,8,2578,2983,0,0),
(646,1,4,2640,2657,0,0),
(647,6,4,-1,-1,0,0),
(648,8,4,2642,2659,0,0),
(649,9,4,-1,-1,0,0),
(650,13,4,2644,2661,0,0),
(651,16,4,-1,-1,0,0),
(652,18,4,2646,2663,0,0),
(653,42,4,2647,2664,0,0),
(654,63,4,2648,2665,0,0),
(655,64,4,2649,2666,0,0),
(656,65,4,2650,2667,0,0),
(657,1,7,2877,2903,0,0),
(658,6,7,-1,-1,0,0),
(659,8,7,2881,2905,0,0),
(660,9,7,-1,-1,0,0),
(661,13,7,2882,2907,0,0),
(662,16,7,-1,-1,0,0),
(663,18,7,2884,2909,0,0),
(664,42,7,2885,2910,0,0),
(665,63,7,2886,2911,0,0),
(666,64,7,2887,2912,0,0),
(667,65,7,2888,2913,0,0),
(668,1,2,2945,2962,0,0),
(669,6,2,-1,-1,0,0),
(670,8,2,2947,2964,0,0),
(671,9,2,-1,-1,0,0),
(672,13,2,2949,2966,0,0),
(673,16,2,-1,-1,0,0),
(674,18,2,2951,2968,0,0),
(675,42,2,2952,2969,0,0),
(676,63,2,2953,2970,0,0),
(677,64,2,2954,2971,0,0),
(678,65,2,2955,2972,0,0),
(679,0,9,0,0,0,0),
(699,67,4,2060,2060,0,0),
(719,67,1,0,0,0,0),
(739,66,3,1589,1661,0,0),
(740,67,3,0,0,0,0),
(741,9,10,0,0,0,0),
(742,0,10,9549,9550,0,0),
(743,1,10,9551,9552,0,0),
(744,0,11,9465,9466,0,0),
(745,6,10,9561,9562,0,0),
(746,11,11,9464,9483,0,0),
(747,1,11,9467,9468,0,0),
(748,2,11,9469,9470,0,0),
(749,3,11,9471,9472,0,0),
(750,4,11,9473,9474,0,0),
(751,5,11,9475,9476,0,0),
(752,6,11,9477,9478,0,0),
(753,7,11,0,0,0,0),
(754,8,11,9479,9480,0,0),
(755,10,11,9482,9481,0,0),
(756,12,11,9485,9484,0,0),
(757,13,11,9487,9486,0,0),
(758,14,11,9489,9488,0,0),
(759,15,11,9491,9490,0,0),
(760,17,11,9493,9492,0,0),
(761,18,11,9495,9494,0,0),
(762,20,11,9496,9497,0,0),
(763,22,11,9498,9499,0,0),
(764,25,11,9500,9501,0,0),
(765,26,11,9502,9503,0,0),
(766,27,11,9502,9503,0,0),
(767,28,11,9502,9503,0,0),
(768,29,11,9504,9505,0,0),
(769,30,11,9506,9507,0,0),
(770,31,11,9508,9509,0,0),
(771,33,11,9489,9488,0,0),
(772,35,11,9512,9513,0,0),
(773,38,11,9463,9514,0,0),
(774,39,11,9498,9499,0,0),
(775,40,11,9498,9499,0,0),
(776,41,11,9515,9516,0,0),
(777,42,11,9517,9518,0,0),
(778,43,11,9519,9520,0,0),
(779,44,11,9521,9522,0,0),
(780,45,11,9463,9514,0,0),
(781,46,11,9525,9526,0,0),
(782,47,11,9477,9478,0,0),
(783,48,11,9529,9530,0,0),
(784,49,11,9531,9532,0,0),
(785,50,11,10660,10659,0,0),
(786,51,11,9535,9536,0,0),
(787,52,11,9537,9538,0,0),
(788,54,11,9498,9499,0,0),
(789,55,11,9489,9488,0,0),
(790,56,11,0,0,0,0),
(791,57,11,9482,9481,0,0),
(792,59,11,9541,9542,0,0),
(793,61,11,9489,9488,0,0),
(794,62,11,9543,9544,0,0),
(795,63,11,9545,9546,0,0),
(796,64,11,9547,9548,0,0),
(797,66,11,9464,9483,0,0),
(798,2,10,9553,9554,0,0),
(799,3,10,9555,9556,0,0),
(800,4,10,9557,9558,0,0),
(801,5,10,9559,9560,0,0),
(802,8,10,9563,9564,0,0),
(803,10,10,9565,9566,0,0),
(804,11,10,9567,9568,0,0),
(805,12,10,9569,9570,0,0),
(806,13,10,9571,9572,0,0),
(807,14,10,9573,9574,0,0),
(808,15,10,9575,9576,0,0),
(809,17,10,9577,9578,0,0),
(810,18,10,9579,9580,0,0),
(811,20,10,9581,9582,0,0),
(812,22,10,9583,9584,0,0),
(813,25,10,9585,9586,0,0),
(814,26,10,9587,9588,0,0),
(815,27,10,9587,9588,0,0),
(816,28,10,9587,9588,0,0),
(817,29,10,9589,9590,0,0),
(818,30,10,9591,9592,0,0),
(819,31,10,9593,9594,0,0),
(820,33,10,9573,9574,0,0),
(821,35,10,9595,9596,0,0),
(822,38,10,9597,9598,0,0),
(823,39,10,9583,9584,0,0),
(824,40,10,9583,9584,0,0),
(825,41,10,9599,9600,0,0),
(826,42,10,9601,9602,0,0),
(827,43,10,9603,9604,0,0),
(828,44,10,9605,9606,0,0),
(829,45,10,9597,9598,0,0),
(830,46,10,9565,9566,0,0),
(831,47,10,9561,9562,0,0),
(832,48,10,9607,9608,0,0),
(833,49,10,9609,9610,0,0),
(834,50,10,10658,10657,0,0),
(835,51,10,9611,9612,0,0),
(836,52,10,9613,9614,0,0),
(837,54,10,9583,9584,0,0),
(838,55,10,9573,9574,0,0),
(839,56,10,0,0,0,0),
(840,57,10,9565,9566,0,0),
(841,59,10,9615,9616,0,0),
(842,61,10,9573,9574,0,0),
(843,62,10,9617,9618,0,0),
(844,63,10,9619,9620,0,0),
(845,64,10,9621,9622,0,0),
(846,66,10,9567,9568,0,0),
(847,58,10,0,0,0,0),
(848,0,15,0,0,0,0); 
