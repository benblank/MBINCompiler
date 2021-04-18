using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1CE0, GUID = 0xB36B01A8EEDB59BA, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public float ShipScanPlanetRechargeMultiplier;
        /* 0x0004 */ public float ShipScanSpaceRechargeMultiplier;
        [NMS(Size = 0x10)]
        /* 0x0008 */ public string FreeSuitSlotID;
        /* 0x0018 */ public float InitialLocationProtectionRadiusMultiplier;
        /* 0x001C */ public float PartyPlanetSearchDistance;
        /* 0x0020 */ public int MaxActiveWeatherHazardGifts;
        /* 0x0024 */ public float WeatherHazardGiftMaxDistance;
        /* 0x0028 */ public float WeatherHazardGiftLifeTime;
        /* 0x002C */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x0030 */ public float MaxMeteorSurfaceAngle;
        /* 0x0034 */ public float StormGravityChangeTime;
        /* 0x0038 */ public float StormBonusJetpackMod;
        /* 0x003C */ public float StormBonusSprintMod;
        /* 0x0040 */ public float StormBonusMiningHeatMod;
        /* 0x0044 */ public float StormBonusMiningAmountMod;
        /* 0x0048 */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x004C */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x0050 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x0054 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x0058 */ public float AlienPodThreshold2;
        /* 0x005C */ public float AlienPodThreshold1;
        /* 0x0060 */ public Colour BulletTraceLineColour;
        /* 0x0070 */ public float BulletTraceLineWidth;
        /* 0x0074 */ public float TracerBeamStart;
        /* 0x0078 */ public float TracerBeamEnd;
        /* 0x007C */ public float VehicleAllIconScanTime;
        /* 0x0080 */ public int GPSRandomChangeTimeWide;
        /* 0x0084 */ public int GPSRandomChangeTimeMid;
        /* 0x0088 */ public int GPSRandomChangeTimeNarrow;
        /* 0x008C */ public float SalvageValueAsProds;
        /* 0x0090 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0094 */ public byte[] Padding94;
        [NMS(Size = 0x4)]
        /* 0x0098 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x00D8 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x0118 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x0158 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x0198 */ public NMSString0x10[] SalvageTechList;
        /* 0x0238 */ public List<NMSString0x10> SalvageProdsList;
        /* 0x0248 */ public List<NMSString0x10> SalvageSubstancesList;
        /* 0x0258 */ public bool AlwaysSpaceBattle;
        /* 0x025C */ public float MultidimensionalFadeTime;
        /* 0x0260 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0264 */ public byte[] Padding264;
        /* 0x0270 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x02C0 */ public Colour BinocularSelectedColour;
        /* 0x02D0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x02E0 */ public float CockpitScale;
        /* 0x02E4 */ public float MaxDistanceForLadderTeleport;
        /* 0x02E8 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x02EC */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x02F0 */ public float AutoTranslateWordChance;
        /* 0x02F4 */ public bool MissionSurveySuggestSurveyForNearScannables;
        /* 0x02F8 */ public float MissionSurveyMaxGuidanceDistance;
        /* 0x02FC */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x0300 */ public float MissionSurveyScanRangeMultiplier;
        /* 0x0304 */ public float MissionSurveyMaxScanAngle;
        /* 0x0308 */ public float MissionSurveyMaxScanAngleScannableComp;
        /* 0x030C */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x0310 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x0314 */ public float MissionSurveyScanSpeed;
        /* 0x0318 */ public float MissionSurveyScanSpeedScannableComp;
        /* 0x031C */ public float MissionSurveyRevealWithoutScanDistance;
        /* 0x0320 */ public float MissionSurveyAutoScanDistance;
        /* 0x0324 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        /* 0x0328 */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x032C */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x0330 */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x0334 */ public float MissionSurveyMaxAngleOffset;
        /* 0x0338 */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x033C */ public float MissionSurveyInShipArrivedDistance;
        /* 0x0340 */ public float SurveyBeginScanPercentage;
        /* 0x0344 */ public float SurveyScanMinSpeed;
        /* 0x0348 */ public float SurveyScanMaxSpeed;
        /* 0x034C */ public float SurveySonarPulseSpeedBandCount;
        /* 0x0350 */ public float SurveySonarMinPulseSpeed;
        /* 0x0354 */ public float SurveySonarMaxPulseSpeed;
        /* 0x0358 */ public float SurveySonarMiddleRangeMin;
        /* 0x035C */ public float SurveySonarMiddleRangeMax;
        /* 0x0360 */ public float SurveyMaxDistance;
        /* 0x0364 */ public int CreaturesToBaitForTutorial;
        /* 0x0368 */ public int CreaturesToFeedForTutorial;
        /* 0x036C */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x036D */ public bool DisableNexusInQuickMenu;
        /* 0x036E */ public bool EnableTeleporters;
        /* 0x036F */ public bool AllowSpaceScanEvents;
        /* 0x0370 */ public bool CanMoveTechnology;
        /* 0x0374 */ public float NormalModeHeatBonus;
        /* 0x0378 */ public float BaseLaserHeatTime;
        /* 0x037C */ public float HeatAlertTime;
        /* 0x0380 */ public float HeatAlertTimeSurvival;
        /* 0x0384 */ public float HeatDamageBoost;
        /* 0x0388 */ public float HeatWidthBoost;
        /* 0x038C */ public float HeatWidthBoostAlt;
        /* 0x0390 */ public float OverheatGenerosity;
        /* 0x0394 */ public float HeatMaxPowerPoint;
        /* 0x0398 */ public float HeatMaxPowerPointSurvival;
        /* 0x039C */ public float OverheatDecay;
        /* 0x03A0 */ public float OverheatDecaySurvival;
        /* 0x03A4 */ public TkCurveType OverheatCurve;
        /* 0x03A8 */ public TkCurveType OverheatCurveSurvival;
        /* 0x03AC */ public bool UseOverheatColour;
        /* 0x03B0 */ public Colour OverHeatColour;
        /* 0x03C0 */ public Colour OverHeatBarColour;
        /* 0x03D0 */ public Colour OverHeatColourSurvival;
        /* 0x03E0 */ public TkCurveType OverheatColourCurve;
        /* 0x03E4 */ public TkCurveType OverheatColourCurveSurvival;
        /* 0x03E8 */ public int RefinerProductsMadeInTime;
        /* 0x03EC */ public int RefinerSubsMadeInTime;
        /* 0x03F0 */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x03F4 */ public int RefinerSubsMadeInTimeSurvival;
        /* 0x03F8 */ public List<NMSString0x10> HyperdriveAccess;
        /* 0x0408 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        /* 0x0418 */ public float SeasonalMessageModuleAttractDistanceMul;
        /* 0x041C */ public float HmdInteractionRangeMinRange;
        /* 0x0420 */ public float HmdInteractionRangeMinDistance;
        /* 0x0424 */ public float HmdInteractionRangeMultiplier;
        [NMSDescription("Set to False to revert to legacy method of installing technologies and upgrades")]
        /* 0x0428 */ public bool InstallTechWithInteraction;
        /* 0x0429 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x042A */ public bool DisableAnomalyAmbientSpawn;
        /* 0x042B */ public bool AllowDeconstruct;
        /* 0x042C */ public bool AllowBinocularMarker;
        /* 0x042D */ public bool EveryMaintenanceIsBroken;
        /* 0x042E */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x042F */ public bool EnableShootHitEffect;
        /* 0x0430 */ public int MaxNumSameGroupTech;
        /* 0x0434 */ public float ShootableArmourHighlightHitTime;
        /* 0x0438 */ public float ShootableAggroMinStartTime;
        /* 0x043C */ public float ShootableAggroForgetTime;
        /* 0x0440 */ public Colour RefinerColour1A;
        /* 0x0450 */ public Colour RefinerColour1B;
        /* 0x0460 */ public Colour RefinerColour1C;
        /* 0x0470 */ public Colour RefinerColour1D;
        /* 0x0480 */ public float AtmosphereEntryTime;
        /* 0x0484 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x0488 */ public float AtmosphereEntryOffset;
        /* 0x048C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x0490 */ public float AtmosphereEntryErrorTime;
        /* 0x0494 */ public float TerrainResourceScanTime;
        /* 0x0498 */ public float TerrainResourceScanRange;
        /* 0x049C */ public float TerrainResourceCompassRange;
        /* 0x04A0 */ public bool BinocsDisplayUnknownCreatures;
        /* 0x04A4 */ public float BinocularScanTargetMinHeight;
        /* 0x04A8 */ public float BinocularScanTargetHeightRange;
        /* 0x04AC */ public float BinocTimeBeforeScan;
        /* 0x04B0 */ public float BinocMinScanTime;
        /* 0x04B4 */ public float BinocScanTime;
        /* 0x04B8 */ public float BinocCreatureScanTime;
        /* 0x04BC */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x04C0 */ public float BinocularScanTargetInitialFadeTime;
        /* 0x04C4 */ public float BinocularScanTargetScaler;
        /* 0x04C8 */ public float BinocularScanTargetLineWidth;
        /* 0x04CC */ public float BinocularScanTargetFadeTime;
        /* 0x04D0 */ public Colour BinocularScanTargetColour;
        /* 0x04E0 */ public GcScanEffectData BinocularScanEffect;
        /* 0x0530 */ public float ScannerIconsClumpRadius;
        /* 0x0534 */ public float ScannableComponentMarkerOffset;
        /* 0x0538 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x053C */ public float MissionEventAllowResetDistance;
        /* 0x0540 */ public float AllRecipesKnownNanitesMin;
        /* 0x0544 */ public float AllRecipesKnownNanitesMax;
        /* 0x0548 */ public float MaxPossibleShipDamagePotential;
        /* 0x054C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0550 */ public float CriticalHitMultiplier;
        /* 0x0554 */ public float HitEffectMinTime;
        /* 0x0558 */ public float GrabPlayerCooldownTime;
        /* 0x055C */ public float TapInteractionIncreaseAmount;
        /* 0x0560 */ public float TapInteractionDecay;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0564 */ public byte[] Padding564;
        /* 0x0570 */ public GcScanEffectData DeconstructEffect;
        /* 0x05C0 */ public GcScanEffectData HitEffect;
        /* 0x0610 */ public GcScanEffectData HitEffectCritical;
        /* 0x0660 */ public float CommunicatorSpawnOffset;
        /* 0x0664 */ public float CommunicatorSpawnHeightOffset;
        /* 0x0670 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x0680 */ public float CommunicatorSpawnScale;
        /* 0x0684 */ public float CommunicatorSpawnRotation;
        /* 0x0688 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x068C */ public byte[] Padding68C;
        /* 0x0690 */ public List<GcScanEffectData> CommunicatorEffectTable;
        /* 0x06A0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x06A4 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        /* 0x06A8 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        /* 0x06AC */ public float InteractionStickOptionStrength;
        /* 0x06B0 */ public float InteractionMessageModuleDisplayTime;
        /* 0x06B4 */ public float InteractionAttractTime;
        /* 0x06B8 */ public float InteractionDescriptionTextTime;
        /* 0x06BC */ public float InteractionMinTimeForResponseText;
        /* 0x06C0 */ public bool InteractionOverride;
        /* 0x06C4 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x06C8 */ public GcInteractionType InteractionOverrideTo;
        /* 0x06CC */ public float DestroyEffectHeight;
        /* 0x06D0 */ public float DestroyEffectMaxScale;
        /* 0x06D4 */ public float EventTargetSpeed;
        /* 0x06D8 */ public int SpecialMiningAmount;
        /* 0x06DC */ public float SpecialMiningTime;
        /* 0x06E0 */ public int HardModeTechDamageMidNum;
        /* 0x06E4 */ public int HardModeTechDamageMidPercent;
        /* 0x06E8 */ public int HardModeTechDamageHighPercent;
        /* 0x06EC */ public int EarlyPiratesToBeKilled;
        /* 0x06F0 */ public int PirateInterestOverride;
        /* 0x06F4 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x06F8 */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x0704 */ public int[] PirateInterestLevelsSurvival;
        /* 0x0710 */ public float SpaceCombatRadius;
        /* 0x0714 */ public int WarpsBetweenBattles;
        /* 0x0718 */ public float HoursBetweenBattles;
        /* 0x071C */ public float SpaceBattleRadius;
        /* 0x0720 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0724 */ public float FreighterBattleRadius;
        /* 0x0728 */ public float MissileMaxTurnAngle;
        /* 0x072C */ public float MissileLockTime;
        /* 0x0730 */ public float MissileReloadTime;
        /* 0x0734 */ public float MissileRotateMin;
        /* 0x0738 */ public float MissileRotateMax;
        /* 0x073C */ public float MissileMaxSpeed;
        /* 0x0740 */ public float MissileForceMin;
        /* 0x0744 */ public float MissileForceMax;
        /* 0x0748 */ public float MissileBrakeForceMin;
        /* 0x074C */ public float MissileBrakeForceMax;
        /* 0x0750 */ public float MissileThreatTime;
        /* 0x0754 */ public float MissileBrakeTime;
        /* 0x0758 */ public float MissileHitRadius;
        /* 0x075C */ public float MissileOffset;
        /* 0x0760 */ public float MissileMinCircleTime;
        /* 0x0764 */ public float MissileApproachTime;
        /* 0x0768 */ public float MissileRotateSpeed;
        /* 0x076C */ public float ScanStartTimeDelayMinDist;
        /* 0x0770 */ public float ScanStartTimeDelayRange;
        /* 0x0774 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x0778 */ public float ScanStickyDecay;
        /* 0x077C */ public float CreatureScanStickyDecay;
        /* 0x0780 */ public float CreatureScanAngle;
        /* 0x0784 */ public float CreatureMinScanTime;
        /* 0x0788 */ public float ScanAngle;
        /* 0x078C */ public float NewDiscoveryDisplayTime;
        /* 0x0790 */ public bool FailToFindBuildings;
        /* 0x0794 */ public float WaterLandingDamageMultiplier;
        /* 0x0798 */ public int CritDamage;
        /* 0x079C */ public float CritScale;
        /* 0x07A0 */ public int NumMissionsPerSolarSystem;
        /* 0x07A4 */ public float EmergencyBuildingScanEventDistance;
        /* 0x07A8 */ public float EmergencyBuildingScanEventTime;
        /* 0x07AC */ public float ProjectileLightIntensity;
        /* 0x07B0 */ public float AggressiveSentinelProbability;
        /* 0x07B4 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x07B8 */ public float LowSentinelProbability;
        /* 0x07BC */ public float LowSentinelProbabilitySurvival;
        /* 0x07C0 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x07C4 */ public int MaxDronesLow;
        /* 0x07C8 */ public int MaxDronesLowSurvival;
        /* 0x07CC */ public int MaxDronesNormal;
        /* 0x07D0 */ public int MaxDronesNormalSurvival;
        /* 0x07D4 */ public int MaxDronesAggressive;
        /* 0x07D8 */ public int MaxDronesAggressiveSurvival;
        /* 0x07DC */ public GcExperienceTimers SentinelTimersLow;
        /* 0x07FC */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x081C */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x083C */ public int FreighterStartPecent;
        /* 0x0840 */ public GcExperienceTimers FreighterTimers;
        /* 0x0860 */ public GcExperienceTimers PirateTimers;
        /* 0x0880 */ public GcExperienceTimers HardPirateTimers;
        /* 0x08A0 */ public List<float> PirateEarlySpawnChances;
        /* 0x08B0 */ public float PirateEarlySpawnTime;
        /* 0x08B4 */ public GcExperienceTimers FlybyTimers;
        /* 0x08D4 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Size = 0x5)]
        /* 0x08F4 */ public int[] FreighterTechQualityWeightings;
        /* 0x0908 */ public int SentinelsHigh;
        /* 0x090C */ public int SentinelsLow;
        /* 0x0910 */ public float AsteroidHitForce;
        /* 0x0914 */ public float AsteroidTorqueForce;
        /* 0x0918 */ public float AsteroidCarveRadius;
        /* 0x091C */ public int DeathMoneyPenalty;
        /* 0x0920 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0924 */ public int MaxResourceCrystalBlobSize;
        /* 0x0928 */ public float BuildingBeamDistance;
        /* 0x092C */ public float WaypointScanTime;
        /* 0x0930 */ public int RareSubstanceEffectiveness;
        /* 0x0934 */ public int CommonProductEffectiveness;
        /* 0x0938 */ public int RareProductEffectiveness;
        /* 0x093C */ public int AsteroidResourceReducer;
        /* 0x0940 */ public float VoxelAsteroidResourceChance;
        /* 0x0944 */ public int ResourceReducer;
        /* 0x0948 */ public int ResourceMinAmount;
        /* 0x094C */ public int ResourceMaxAmount;
        /* 0x0950 */ public int ResourceCommonReducer;
        /* 0x0954 */ public int ResourceCommonMinAmount;
        /* 0x0958 */ public int ResourceCommonMaxAmount;
        /* 0x095C */ public int ResourceDirtReducer;            // Do not set to 0
        /* 0x0960 */ public int ResourceDirtMinAmount;
        /* 0x0964 */ public int ResourceDirtMaxAmount;
        [NMS(Size = 0x10)]
        /* 0x0968 */ public string ResourceDirtSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0978 */ public string BioShipTerrainResource;        // "SUNGOLD" -> Liquid Sun substance
        [NMS(Size = 0x20)]
        /* 0x0988 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x09A8 */ public string DepotResource;
        /* 0x09C8 */ public float DockNodeBuyRadius;
        /* 0x09CC */ public float BeaconInteractRange;
        /* 0x09D0 */ public float ShipInteractRadius;
        /* 0x09D4 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0A08 */ public float ScanAngleCutoff;
        /* 0x0A0C */ public GcScanData ToolScan;
        /* 0x0A20 */ public GcScanData ToolScanHardMode;
        /* 0x0A34 */ public GcScanData WaypointScan;
        /* 0x0A48 */ public GcScanData BeaconScan;
        /* 0x0A5C */ public GcScanData RadioTowerScan;
        /* 0x0A70 */ public GcScanData ObservatoryScan;
        /* 0x0A84 */ public GcScanData DistressSignalScan;
        /* 0x0A98 */ public GcScanData DebugScanPlanet;
        /* 0x0AAC */ public GcScanData DebugScanSpace;
        /* 0x0AC0 */ public GcScanData ShipScan;
        /* 0x0AD4 */ public GcScanData VisualScan;
        /* 0x0AE8 */ public float ZoomFindBuildingRange;
        /* 0x0AEC */ public float TimeToDisplayScanResults;
        /* 0x0AF0 */ public float HoverTimeToScan;
        /* 0x0AF4 */ public float HoverTimeToScanCreatures;
        /* 0x0AF8 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0AFC */ public byte[] PaddingAFC;
        /* 0x0B00 */ public List<GcZoomData> ZoomLevels;
        /* 0x0B10 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0B60 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0BB0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0C00 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0C50 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0CA0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0CF0 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x0D40 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x0D90 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x0DE0 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0E30 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x0E80 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x0ED0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x0F20 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x0F70 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x0FC0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x1010 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x1060 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x10B0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x1100 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x1150 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x11A0 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x11A4 */ public bool UseDebugScan;
        /* 0x11A5 */ public bool DebugScanForceBuilding;
        /* 0x11A8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x11AC */ public float ShipScanOffset;
        /* 0x11B0 */ public float ShipScanOffsetGap;
        /* 0x11B4 */ public TkCurveType ShipScanCurve;
        /* 0x11B8 */ public float ScannerMarkerFadeTime;
        /* 0x11BC */ public float ScannerSmallMarkerFadeTime;
        /* 0x11C0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x11C4 */ public float ScannerAnalyzeFXRate;
        /* 0x11C8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x11CC */ public float ScannerTuningA;
        /* 0x11D0 */ public float ScannerTuningB;
        /* 0x11D4 */ public float ScannerTuningC;
        /* 0x11D8 */ public float ScannerTuningD;
        /* 0x11DC */ public float ScannerTuningResourceOffset1;
        /* 0x11E0 */ public float ScannerTuningResourceOffset2;
        /* 0x11E4 */ public float ScannerTuningSmoothStepAmount;
        /* 0x11E8 */ public float ScannerTuningTrailingEdge;
        /* 0x11EC */ public bool Autolevel;
        /* 0x11F0 */ public Colour ScannerColour1;
        /* 0x1200 */ public Colour ScannerColour2;
        /* 0x1210 */ public float HUDStoreFlashTime;
        /* 0x1214 */ public float ExcitingViewAngle;
        /* 0x1218 */ public float ExcitingViewRange;
        /* 0x121C */ public float ExcitingNearRange;
        /* 0x1220 */ public float ProjectileSpeedBoost;
        /* 0x1224 */ public float LineWidth;
        /* 0x1228 */ public float LockOffFactor;
        /* 0x122C */ public float OffscreenFadeDistance;
        /* 0x1230 */ public float OffscreenMinDot;
        /* 0x1234 */ public bool HUDUpdateFromData;
        /* 0x1238 */ public float HUDLockOnAudioTime;
        /* 0x123C */ public float HUDArrowPrimaryScaler;
        /* 0x1240 */ public Vector2f HUDDamageSize;
        /* 0x1248 */ public Vector2f HUDDamageSplatSize;
        /* 0x1250 */ public Colour HUDDamageSplatShieldColour;
        /* 0x1260 */ public Colour HUDDamageSplatPainColour;
        /* 0x1270 */ public float HUDDamageOffset;
        /* 0x1274 */ public float HUDDamageScaler;
        /* 0x1278 */ public float HUDDamageRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x127C */ public byte[] Padding127C;
        /* 0x1280 */ public GcShipHUDTargetData HUDTarget;
        /* 0x16B0 */ public float HUDLabelTime;
        /* 0x16B4 */ public float HUDLabelAngle;
        /* 0x16B8 */ public float HUDLabelAngleOffset;
        /* 0x16BC */ public float HUDLabelOffsetX;
        /* 0x16C0 */ public float HUDLabelOffsetY;
        /* 0x16C4 */ public float HUDLabelOffsetZ;
        /* 0x16C8 */ public float HUDLabelScale;
        /* 0x16CC */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x16D0 */ public string ResourceParticleFile;
        /* 0x1750 */ public float ResourceParticleSpeed;
        /* 0x1754 */ public float ResourceParticleSpread;
        /* 0x1758 */ public int ResourceParticleMaxNum;
        /* 0x175C */ public int ResourceParticleMinNum;
        /* 0x1760 */ public float MapHeight;
        /* 0x1764 */ public float MapOffset;
        /* 0x1768 */ public float MapTargetOffset;
        /* 0x176C */ public float MapFOV;
        /* 0x1770 */ public float MapRadius;
        /* 0x1774 */ public float HUDScaleAdd;
        /* 0x1778 */ public float HUDScaleRadius;
        /* 0x177C */ public float HUDScaleMin;
        /* 0x1780 */ public float HUDScaleMinAim;
        /* 0x1784 */ public float HUDScaleMax;
        /* 0x1788 */ public float HUDScaleFarTarget;
        /* 0x178C */ public float HUDReticuleMoveBack;
        /* 0x1790 */ public float HUDReticuleMoveAim;
        /* 0x1794 */ public float MouseSensitivity;
        /* 0x1798 */ public float MouseSensitivityShip;
        /* 0x179C */ public float MouseSensitivityVehicle;
        /* 0x17A0 */ public float PainTime;
        /* 0x17A4 */ public TkCurveType PainCurve;
        /* 0x17B0 */ public Colour PainColour;
        /* 0x17C0 */ public float GunOffsetX;
        /* 0x17C4 */ public float GunOffsetY;
        /* 0x17C8 */ public float GunOffsetZ;
        /* 0x17CC */ public float GunDownAngle;
        /* 0x17D0 */ public float GunUpAngle;
        /* 0x17D4 */ public float BarrelOffset;
        /* 0x17D8 */ public float HitOffset;
        /* 0x17DC */ public GcTracerData BulletTracer;
        /* 0x17F4 */ public GcTracerData ShipTracer;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x180C */ public byte[] Padding180C;
        [NMS(Size = 0x10)]
        /* 0x1810 */ public string DefaultAnim;
        /* 0x1820 */ public bool DebugDrawTriggerBoxes;
        /* 0x1824 */ public float SpeedReadoutMultiplier;
        /* 0x1828 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x182C */ public int TorchCookieIndex;
        /* 0x1830 */ public float TorchFoV;
        /* 0x1834 */ public float TorchStrength;
        /* 0x1838 */ public int TorchDimCookieIndex;
        /* 0x183C */ public float TorchDimFoV;
        /* 0x1840 */ public float TorchDimStrength;
        /* 0x1844 */ public float InteractionTorchFoV;
        /* 0x1848 */ public float InteractionTorchStrength;
        /* 0x184C */ public float TorchOffsetX;
        /* 0x1850 */ public float TorchOffsetY;
        /* 0x1854 */ public float TorchOffsetZ;
        /* 0x1858 */ public float TorchHandOffsetX;
        /* 0x185C */ public float TorchHandOffsetY;
        /* 0x1860 */ public float TorchHandOffsetZ;
        /* 0x1864 */ public bool TorchDisabledInTheDay;
        /* 0x1868 */ public float TorchRotation;
        /* 0x186C */ public float TorchFollowCameraPitch;
        /* 0x1870 */ public float TorchFollowCameraTime;
        /* 0x1880 */ public Colour TorchColour;
        /* 0x1890 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x18A0 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x18B0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x18B4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x18B8 */ public float SimpleInteractionPickupAngle;
        /* 0x18BC */ public float SimpleInteractionPickupRadius;
        /* 0x18C0 */ public float SimpleInteractionMessageTime;
        /* 0x18C4 */ public float InteractionPickupAngle;
        /* 0x18C8 */ public float InteractionPickupRadius;
        /* 0x18CC */ public float ExplosionRadiusMultiplier;
        /* 0x18D0 */ public float ExplosionForce;
        /* 0x18D4 */ public float ExplosionForceMaxForceRadius;
        /* 0x18D8 */ public float LaserExplosionForceRadius;
        /* 0x18DC */ public float LaserExplosionForce;
        /* 0x18E0 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x18E4 */ public string InitialDebrisScene;
        /* 0x1964 */ public float BonusSameTypeElementsAdd;
        /* 0x1968 */ public float BonusSameTypeElementsMultiply;
        /* 0x196C */ public float BonusChildTypeElementsAdd;
        /* 0x1970 */ public float BonusChildTypeElementsMultiply;
        /* 0x1974 */ public float InteractionComponentUpdateDistance;
        /* 0x1978 */ public float GoalGapVoxelDist;
        /* 0x197C */ public float BlackHoleJumpVoxelDist;
        /* 0x1980 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1984 */ public float JumpToCenterFuelCost;
        /* 0x1988 */ public int WarpsBetweenMiniStation;
        /* 0x198C */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1990 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1A10 */ public string BaseBuildingTable;
        /* 0x1A90 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1A98 */ public float LightStrength;
        /* 0x1A9C */ public float AirLockDoorRange;
        /* 0x1AA0 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1AA1 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1AA2 */ public bool UseMultiplierBonus;
        /* 0x1AA4 */ public float ShipDisplayDamageMultiplier;
        /* 0x1AA8 */ public float IllegalProductTradingMod;
        /* 0x1AAC */ public bool UseTradingCostTable;
        /* 0x1AAD */ public bool ChangePricesLocally;
        /* 0x1AAE */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1AB0 */ public int ProductItemStockDecayTime;
        /* 0x1AB4 */ public int ProductItemStockReplenishTime;
        /* 0x1AB8 */ public int SubstanceItemStockDecayTime;
        /* 0x1ABC */ public int SubstanceItemStockReplenishTime;
        /* 0x1AC0 */ public GcPortalData Portal;
        /* 0x1AC8 */ public int FourthRaceSpawnPercentage;
        /* 0x1ACC */ public int NonDominantRaceSpawnPercentage;
        /* 0x1AD0 */ public float ViciousSentinelProbability;
        /* 0x1AD4 */ public float ViciousStormProbability;
        /* 0x1AD8 */ public float ViciousWeatherProbability;
        /* 0x1ADC */ public float ScrapDroneProbability;
        /* 0x1AE0 */ public float MaxRespawnOnGroundHeight;
        /* 0x1AE4 */ public float DeadPlanetGravityFactor;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1AE8 */ public byte[] Padding1AE8;
        /* 0x1AF0 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x1B40 */ public float SalvageShipPitch;
        /* 0x1B44 */ public float SalvageShipHeightOffset;
        /* 0x1B48 */ public float SalvageShipExplodeSpeed;
        /* 0x1B4C */ public float SalvageShipShowShipSpeed;
        /* 0x1B50 */ public float SalvageShipShowShipDistance;
        /* 0x1B54 */ public float SalvageShipExplodeShipDistance;
        /* 0x1B58 */ public float SalvageShipOneRevolutionTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1B5C */ public byte[] Padding1B5C;
        [NMS(Size = 0x20)]
        /* 0x1B60 */ public string CommunicatorFireteamNexusExitDialog;
        [NMS(Size = 0x20)]
        /* 0x1B80 */ public string CommunicatorNexusExitAbandonWarningDialog;
        /* 0x1BA0 */ public float PulseEncounterCheckTimer;
        /* 0x1BA4 */ public float PulseEncounterChance;
        /* 0x1BA8 */ public float PulseEncounterChanceStandard;
        /* 0x1BAC */ public float PulseEncounterChanceRed;
        /* 0x1BB0 */ public float PulseEncounterChanceGreen;
        /* 0x1BB4 */ public float PulseEncounterChanceBlue;
        /* 0x1BB8 */ public float PulseEncounterStopPower;
        /* 0x1BBC */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x5)]
        /* 0x1BC0 */ public int[] AlienShipEvolveCosts;
        /* 0x1BD4 */ public float SpawnerWeaponRange;
        /* 0x1BD8 */ public TkTextureResource WeaponSpawnObject;
        /* 0x1C5C */ public TkTextureResource WeaponSpawnAltObject;
    }
}

/* Notes and algorithms:

Since the names for the sentinal timer and flyby timers are a bit hard to understand,
this is the algorithm that shows how the game uses them:

if SentinelLevel == Agressive:
	MaxActiveDrones = 1
	SentinelTimer = SentinelTimer_Default_or_Aggressive
	FlybyTimer = FlybyTimer_B_or_Aggressive
else:
	MaxActiveDrones = 2
	if RNG(0,100) >= SentinelTimer_Default_Chance_percent:
		SentinelTimer = SentinelTimer_A
		if RNG(0,100) < SentinelTimer_B_Chance_percent:
			SentinelTimer = SentinelTimer_B
	else:
		SentinelTimer = SentinelTimer_Default_or_Aggressive
	
	if RNG(0,100) >= FlybyTimer_Default_Chance_percent:
		FlybyTimer = FlybyTimer_A
		if RNG(0,100) < FlybyTimer_B_Chance_percent:
			FlybyTimer = FlybyTimer_B_or_Aggressive
	else:
		FlybyTimer = FlybyTimer_Default
*/