﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3E0, GUID = 0xE5E5B707523C6390)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x000 */ public bool MassiveSolarSystems;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x010 */ public Vector3f SolarSystemSize;
        /* 0x020 */ public float SolarSystemMaximumRadius;
        /* 0x024 */ public float SolarSystemMaximumRadiusMassive;
        /* 0x028 */ public bool GenerateMaximumSolarSystem;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x029 */ public byte[] Padding29;
        /* 0x02C */ public int GenerateForcedNumberPlanets;
        /* 0x030 */ public bool UseSingleRacePerSystem;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x031 */ public byte[] Padding31;
        /* 0x034 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        /* 0x03C */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        /* 0x044 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x04C */ public float[] ExtremePlanetChance;
        /* 0x05C */ public float StationSpawnAvoidRadius;
        /* 0x060 */ public int LocatorScatterMinCount;
        /* 0x064 */ public int LocatorScatterMaxCount;
        /* 0x068 */ public float LocatorScatterMaxDistanceFromPlanet;
        /* 0x06C */ public int LocatorScatterChanceOfCapitalShips;
        /* 0x070 */ public int LocatorScatterChanceOfPirates;
        /* 0x074 */ public float DirectorLocatorBusyDistance;
        /* 0x078 */ public float DirectorLocatorBusyAngle;
        /* 0x07C */ public float PlanetInvalidAsteroidZone;
        /* 0x080 */ public bool AsteroidsEnabled;
        /* 0x081 */ public bool AsteroidsCheckNoise;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x082 */ public byte[] Padding82;
        /* 0x084 */ public float AsteroidNoiseScale;
        /* 0x088 */ public float AsteroidDetailNoiseScale;
        /* 0x08C */ public int AsteroidNoiseOctaves;
        /* 0x090 */ public float AsteroidNoiseMinCutoff;
        /* 0x094 */ public float AsteroidNoiseMaxCutoff;
        /* 0x098 */ public float AsteroidRotateMin;
        /* 0x09C */ public float AsteroidRotateMax;
        /* 0x0A0 */ public Vector2f AsteroidScaleVariance;
        /* 0x0A8 */ public float AsteroidFadeTime;
        /* 0x0AC */ public Vector2f AsteroidNoiseRange;
        /* 0x0B4 */ public Vector2f LargeAsteroidNoiseRange;
        /* 0x0BC */ public Vector2f RareAsteroidNoiseRangeFewRares;
        /* 0x0C4 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0x0CC */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        /* 0x0D4 */ public float AsteroidSomeRaresOdds;
        /* 0x0D8 */ public float AsteroidLotsOfRaresOdds;
        /* 0x0DC */ public float AsteroidFadeRangeMin;
        /* 0x0E0 */ public float AsteroidFadeRangeMax;
        /* 0x0E4 */ public float AsteroidSpacing;
        /* 0x0E8 */ public float RareAsteroidScale;
        /* 0x0EC */ public int RareAsteroidMinResources;
        /* 0x0F0 */ public int RareAsteroidMaxResources;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0F4 */ public byte[] PaddingF4;
        [NMS(Size = 0x10)]
        /* 0x0F8 */ public string RareAsteroidResource;
        /* 0x108 */ public int RareAsteroidHealth;
        /* 0x10C */ public float CommonAsteroidScale;
        /* 0x110 */ public int CommonAsteroidMinResources;
        /* 0x114 */ public int CommonAsteroidMaxResources;
        /* 0x118 */ public int CommonAsteroidResourceFuelMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] Padding11C;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string CommonAsteroidResourceFuel;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string RareAsteroidResourceFuel;     // GEODE_SPACE
        [NMS(Size = 0x10)]
        /* 0x140 */ public string CommonAsteroidResourceProduct;     // GEODE_ASTEROID
        [NMS(Size = 0x10)]
        /* 0x150 */ public string CommonAsteroidResourceMain;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string CommonAsteroidResourceSecondary;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string RareAsteroidDataProduct;
        /* 0x180 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x184 */ public float RareAsteroidResourceFuelOdds;
        /* 0x188 */ public float CommonAsteroidResourceProductOdds;
        /* 0x18C */ public float RareAsteroidDataProductOdds;
        /* 0x190 */ public float CommonAsteroidResourceSecondaryOdds;
        /* 0x194 */ public int CommonAsteroidHealth;
        /* 0x198 */ public float LargeAsteroidSpacing;
        /* 0x19C */ public float LargeAsteroidFadeTime;
        /* 0x1A0 */ public float LargeAsteroidFadeRangeMin;
        /* 0x1A4 */ public float LargeAsteroidFadeRangeMax;
        /* 0x1A8 */ public float LargeAsteroidMoveFadeTime;
        /* 0x1AC */ public float RingAsteroidScale;
        /* 0x1B0 */ public float RingAsteroidSpacing;
        /* 0x1B4 */ public float RingAsteroidFadeRangeMin;
        /* 0x1B8 */ public float RingAsteroidFadeRangeMax;
        /* 0x1BC */ public int AsteroidMaxNumGenerates;
        /* 0x1C0 */ public int AsteroidMaxNumGeneratesPulseJump;
        /* 0x1C4 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x1C8 */ public float AsteroidAnomalyAvoidRadius;
        /* 0x1CC */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1D0 */ public float[] AbandonedSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1E0 */ public float[] EmptySystemProbability;
        /* 0x1F0 */ public int CivilianTraderSpaceshipsCacheCount;
        [NMS(Size = 0x3)]
        /* 0x1F4 */ public float[] SpaceshipSpawnFreqMultipliers;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]     // I think this is the enum type...
        /* 0x200 */ public GcAISpaceshipWeightingData[] SpaceshipWeightings;
        /* 0x300 */ public float PlanetRingProbability;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x304 */ public byte[] Padding304;
        /* 0x310 */ public GcPlanetRingData PlanetRingsMin;
        /* 0x370 */ public GcPlanetRingData PlanetRingsMax;
        /* 0x3D0 */ public int PercentChanceExtraPrime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3D4 */ public byte[] EndPadding;
    }
}
