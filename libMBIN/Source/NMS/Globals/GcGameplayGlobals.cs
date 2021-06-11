using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1D20, GUID = 0x35FE7EAD026B8549, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x10 NexusRecipeCostType;
        /* 0x0010 */ public int NexusRecipeCostNaniteMultiplier;
        /* 0x0014 */ public float ShipScanPlanetRechargeMultiplier;
        /* 0x0018 */ public float ShipScanSpaceRechargeMultiplier;
        /* 0x0020 */ public NMSString0x10 FreeSuitSlotID;
        /* 0x0030 */ public float InitialLocationProtectionRadiusMultiplier;
        /* 0x0034 */ public float PartyPlanetSearchDistance;
        /* 0x0038 */ public int MaxActiveWeatherHazardGifts;
        /* 0x003C */ public float WeatherHazardGiftMaxDistance;
        /* 0x0040 */ public float WeatherHazardGiftLifeTime;
        /* 0x0044 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x0048 */ public float MaxMeteorSurfaceAngle;
        /* 0x004C */ public float StormGravityChangeTime;
        /* 0x0050 */ public float StormBonusJetpackMod;
        /* 0x0054 */ public float StormBonusSprintMod;
        /* 0x0058 */ public float StormBonusMiningHeatMod;
        /* 0x005C */ public float StormBonusMiningAmountMod;
        /* 0x0060 */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x0064 */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x0068 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x006C */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x0070 */ public float AlienPodThreshold2;
        /* 0x0074 */ public float AlienPodThreshold1;
        /* 0x0080 */ public Colour BulletTraceLineColour;
        /* 0x0090 */ public float BulletTraceLineWidth;
        /* 0x0094 */ public float TracerBeamStart;
        /* 0x0098 */ public float TracerBeamEnd;
        /* 0x009C */ public float VehicleAllIconScanTime;
        /* 0x00A0 */ public int GPSRandomChangeTimeWide;
        /* 0x00A4 */ public int GPSRandomChangeTimeMid;
        /* 0x00A8 */ public int GPSRandomChangeTimeNarrow;
        /* 0x00AC */ public float SalvageValueAsProds;
        /* 0x00B0 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4)]
        /* 0x00B8 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x00F8 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x0138 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x0178 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x01B8 */ public NMSString0x10[] SalvageTechList;
        /* 0x0258 */ public List<NMSString0x10> SalvageProdsList;
        /* 0x0268 */ public List<NMSString0x10> SalvageSubstancesList;
        /* 0x0278 */ public bool AlwaysSpaceBattle;
        /* 0x027C */ public float MultidimensionalFadeTime;
        /* 0x0280 */ public float TeleporterDistanceTravelledMultiplier;
        /* 0x0290 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x02E0 */ public Colour BinocularSelectedColour;
        /* 0x02F0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x0300 */ public float CockpitScale;
        /* 0x0304 */ public float MaxDistanceForLadderTeleport;
        /* 0x0308 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x030C */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x0310 */ public float AutoTranslateWordChance;
        /* 0x0314 */ public bool MissionSurveySuggestSurveyForNearScannables;
        /* 0x0318 */ public float MissionSurveyMaxGuidanceDistance;
        /* 0x031C */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x0320 */ public float MissionSurveyScanRangeMultiplier;
        /* 0x0324 */ public float MissionSurveyMaxScanAngle;
        /* 0x0328 */ public float MissionSurveyMaxScanAngleScannableComp;
        /* 0x032C */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x0330 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x0334 */ public float MissionSurveyScanSpeed;
        /* 0x0338 */ public float MissionSurveyScanSpeedScannableComp;
        /* 0x033C */ public float MissionSurveyRevealWithoutScanDistance;
        /* 0x0340 */ public float MissionSurveyAutoScanDistance;
        /* 0x0344 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        /* 0x0348 */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x034C */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x0350 */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x0354 */ public float MissionSurveyMaxAngleOffset;
        /* 0x0358 */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x035C */ public float MissionSurveyInShipArrivedDistance;
        /* 0x0360 */ public float SurveyBeginScanPercentage;
        /* 0x0364 */ public float SurveyScanMinSpeed;
        /* 0x0368 */ public float SurveyScanMaxSpeed;
        /* 0x036C */ public float SurveySonarPulseSpeedBandCount;
        /* 0x0370 */ public float SurveySonarMinPulseSpeed;
        /* 0x0374 */ public float SurveySonarMaxPulseSpeed;
        /* 0x0378 */ public float SurveySonarMiddleRangeMin;
        /* 0x037C */ public float SurveySonarMiddleRangeMax;
        /* 0x0380 */ public float SurveyMaxDistance;
        /* 0x0384 */ public int CreaturesToBaitForTutorial;
        /* 0x0388 */ public int CreaturesToFeedForTutorial;
        /* 0x038C */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x038D */ public bool DisableNexusInQuickMenu;
        /* 0x038E */ public bool EnableTeleporters;
        /* 0x038F */ public bool AllowSpaceScanEvents;
        /* 0x0390 */ public bool CanMoveTechnology;
        /* 0x0394 */ public float NormalModeHeatBonus;
        /* 0x0398 */ public float BaseLaserHeatTime;
        /* 0x039C */ public float HeatAlertTime;
        /* 0x03A0 */ public float HeatAlertTimeSurvival;
        /* 0x03A4 */ public float HeatDamageBoost;
        /* 0x03A8 */ public float HeatWidthBoost;
        /* 0x03AC */ public float HeatWidthBoostAlt;
        /* 0x03B0 */ public float OverheatGenerosity;
        /* 0x03B4 */ public float HeatMaxPowerPoint;
        /* 0x03B8 */ public float HeatMaxPowerPointSurvival;
        /* 0x03BC */ public float OverheatDecay;
        /* 0x03C0 */ public float OverheatDecaySurvival;
        /* 0x03C4 */ public TkCurveType OverheatCurve;
        /* 0x03C8 */ public TkCurveType OverheatCurveSurvival;
        /* 0x03CC */ public bool UseOverheatColour;
        /* 0x03D0 */ public Colour OverHeatColour;
        /* 0x03E0 */ public Colour OverHeatBarColour;
        /* 0x03F0 */ public Colour OverHeatColourSurvival;
        /* 0x0400 */ public TkCurveType OverheatColourCurve;
        /* 0x0404 */ public TkCurveType OverheatColourCurveSurvival;
        /* 0x0408 */ public int RefinerProductsMadeInTime;
        /* 0x040C */ public int RefinerSubsMadeInTime;
        /* 0x0410 */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x0414 */ public int RefinerSubsMadeInTimeSurvival;
        /* 0x0418 */ public List<NMSString0x10> HyperdriveAccess;
        /* 0x0428 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        /* 0x0438 */ public float SeasonalMessageModuleAttractDistanceMul;
        /* 0x043C */ public float HmdInteractionRangeMinRange;
        /* 0x0440 */ public float HmdInteractionRangeMinDistance;
        /* 0x0444 */ public float HmdInteractionRangeMultiplier;
        [NMSDescription("Set to False to revert to legacy method of installing technologies and upgrades")]
        /* 0x0448 */ public bool InstallTechWithInteraction;
        /* 0x0449 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x044A */ public bool DisableAnomalyAmbientSpawn;
        /* 0x044B */ public bool AllowDeconstruct;
        /* 0x044C */ public bool AllowBinocularMarker;
        /* 0x044D */ public bool EveryMaintenanceIsBroken;
        /* 0x044E */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x044F */ public bool EnableShootHitEffect;
        /* 0x0450 */ public int MaxNumSameGroupTech;
        /* 0x0454 */ public float ShootableArmourHighlightHitTime;
        /* 0x0458 */ public float ShootableAggroMinStartTime;
        /* 0x045C */ public float ShootableAggroForgetTime;
        /* 0x0460 */ public Colour RefinerColour1A;
        /* 0x0470 */ public Colour RefinerColour1B;
        /* 0x0480 */ public Colour RefinerColour1C;
        /* 0x0490 */ public Colour RefinerColour1D;
        /* 0x04A0 */ public float AtmosphereEntryTime;
        /* 0x04A4 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x04A8 */ public float AtmosphereEntryOffset;
        /* 0x04AC */ public TkCurveType AtmosphereEntryCurve;
        /* 0x04B0 */ public float AtmosphereEntryErrorTime;
        /* 0x04B4 */ public float TerrainResourceScanTime;
        /* 0x04B8 */ public float TerrainResourceScanRange;
        /* 0x04BC */ public float TerrainResourceCompassRange;
        /* 0x04C0 */ public bool BinocsDisplayUnknownCreatures;
        /* 0x04C4 */ public float BinocularScanTargetMinHeight;
        /* 0x04C8 */ public float BinocularScanTargetHeightRange;
        /* 0x04CC */ public float BinocTimeBeforeScan;
        /* 0x04D0 */ public float BinocMinScanTime;
        /* 0x04D4 */ public float BinocScanTime;
        /* 0x04D8 */ public float BinocCreatureScanTime;
        /* 0x04DC */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x04E0 */ public float BinocularScanTargetInitialFadeTime;
        /* 0x04E4 */ public float BinocularScanTargetScaler;
        /* 0x04E8 */ public float BinocularScanTargetLineWidth;
        /* 0x04EC */ public float BinocularScanTargetFadeTime;
        /* 0x04F0 */ public Colour BinocularScanTargetColour;
        /* 0x0500 */ public GcScanEffectData BinocularScanEffect;
        /* 0x0550 */ public float ScannerIconsClumpRadius;
        /* 0x0554 */ public float ScannableComponentMarkerOffset;
        /* 0x0558 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x055C */ public float MissionEventAllowResetDistance;
        /* 0x0560 */ public float AllRecipesKnownNanitesMin;
        /* 0x0564 */ public float AllRecipesKnownNanitesMax;
        /* 0x0568 */ public float MaxPossibleShipDamagePotential;
        /* 0x056C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0570 */ public float CriticalHitMultiplier;
        /* 0x0574 */ public float HitEffectMinTime;
        /* 0x0578 */ public float GrabPlayerCooldownTime;
        /* 0x057C */ public float TapInteractionIncreaseAmount;
        /* 0x0580 */ public float TapInteractionDecay;
        /* 0x0590 */ public GcScanEffectData DeconstructEffect;
        /* 0x05E0 */ public GcScanEffectData HitEffect;
        /* 0x0630 */ public GcScanEffectData HitEffectCritical;
        /* 0x0680 */ public float CommunicatorSpawnOffset;
        /* 0x0684 */ public float CommunicatorSpawnHeightOffset;
        /* 0x0690 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x06A0 */ public float CommunicatorSpawnScale;
        /* 0x06A4 */ public float CommunicatorSpawnRotation;
        /* 0x06A8 */ public float CommunicatorFadeTime;
        /* 0x06B0 */ public List<GcScanEffectData> CommunicatorEffectTable;
        /* 0x06C0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x06C4 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        /* 0x06C8 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        /* 0x06CC */ public float InteractionStickOptionStrength;
        /* 0x06D0 */ public float InteractionMessageModuleDisplayTime;
        /* 0x06D4 */ public float InteractionAttractTime;
        /* 0x06D8 */ public float InteractionDescriptionTextTime;
        /* 0x06DC */ public float InteractionMinTimeForResponseText;
        /* 0x06E0 */ public bool InteractionOverride;
        /* 0x06E4 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x06E8 */ public GcInteractionType InteractionOverrideTo;
        /* 0x06EC */ public float DestroyEffectHeight;
        /* 0x06F0 */ public float DestroyEffectMaxScale;
        /* 0x06F4 */ public float EventTargetSpeed;
        /* 0x06F8 */ public int SpecialMiningAmount;
        /* 0x06FC */ public float SpecialMiningTime;
        /* 0x0700 */ public int HardModeTechDamageMidNum;
        /* 0x0704 */ public int HardModeTechDamageMidPercent;
        /* 0x0708 */ public int HardModeTechDamageHighPercent;
        /* 0x070C */ public int EarlyPiratesToBeKilled;
        /* 0x0710 */ public int PirateInterestOverride;
        /* 0x0714 */ public float PirateInterestDistance;
        /* 0x0718 */ public float PirateInterestDistanceMPMission;
        [NMS(Size = 0x3)]
        /* 0x071C */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x0728 */ public int[] PirateInterestLevelsSurvival;
        /* 0x0734 */ public float SpaceCombatRadius;
        /* 0x0738 */ public int WarpsBetweenBattles;
        /* 0x073C */ public float HoursBetweenBattles;
        /* 0x0740 */ public float SpaceBattleRadius;
        /* 0x0744 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0748 */ public float FreighterBattleRadius;
        /* 0x074C */ public float MissileMaxTurnAngle;
        /* 0x0750 */ public float MissileLockTime;
        /* 0x0754 */ public float MissileReloadTime;
        /* 0x0758 */ public float MissileRotateMin;
        /* 0x075C */ public float MissileRotateMax;
        /* 0x0760 */ public float MissileMaxSpeed;
        /* 0x0764 */ public float MissileForceMin;
        /* 0x0768 */ public float MissileForceMax;
        /* 0x076C */ public float MissileBrakeForceMin;
        /* 0x0770 */ public float MissileBrakeForceMax;
        /* 0x0774 */ public float MissileThreatTime;
        /* 0x0778 */ public float MissileBrakeTime;
        /* 0x077C */ public float MissileHitRadius;
        /* 0x0780 */ public float MissileOffset;
        /* 0x0784 */ public float MissileMinCircleTime;
        /* 0x0788 */ public float MissileApproachTime;
        /* 0x078C */ public float MissileRotateSpeed;
        /* 0x0790 */ public float ScanStartTimeDelayMinDist;
        /* 0x0794 */ public float ScanStartTimeDelayRange;
        /* 0x0798 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x079C */ public float ScanStickyDecay;
        /* 0x07A0 */ public float CreatureScanStickyDecay;
        /* 0x07A4 */ public float CreatureScanAngle;
        /* 0x07A8 */ public float CreatureMinScanTime;
        /* 0x07AC */ public float ScanAngle;
        /* 0x07B0 */ public float NewDiscoveryDisplayTime;
        /* 0x07B4 */ public bool FailToFindBuildings;
        /* 0x07B8 */ public float WaterLandingDamageMultiplier;
        /* 0x07BC */ public int CritDamage;
        /* 0x07C0 */ public float CritScale;
        /* 0x07C4 */ public int NumMissionsPerSolarSystem;
        /* 0x07C8 */ public float EmergencyBuildingScanEventDistance;
        /* 0x07CC */ public float EmergencyBuildingScanEventTime;
        /* 0x07D0 */ public float ProjectileLightIntensity;
        /* 0x07D4 */ public float AggressiveSentinelProbability;
        /* 0x07D8 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x07DC */ public float LowSentinelProbability;
        /* 0x07E0 */ public float LowSentinelProbabilitySurvival;
        /* 0x07E4 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x07E8 */ public int MaxDronesLow;
        /* 0x07EC */ public int MaxDronesLowSurvival;
        /* 0x07F0 */ public int MaxDronesNormal;
        /* 0x07F4 */ public int MaxDronesNormalSurvival;
        /* 0x07F8 */ public int MaxDronesAggressive;
        /* 0x07FC */ public int MaxDronesAggressiveSurvival;
        /* 0x0800 */ public GcExperienceTimers SentinelTimersLow;
        /* 0x0820 */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x0840 */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x0860 */ public int FreighterStartPecent;
        /* 0x0864 */ public GcExperienceTimers FreighterTimers;
        /* 0x0884 */ public GcExperienceTimers PirateTimers;
        /* 0x08A4 */ public GcExperienceTimers HardPirateTimers;
        /* 0x08C8 */ public List<float> PirateEarlySpawnChances;
        /* 0x08D8 */ public float PirateEarlySpawnTime;
        /* 0x08DC */ public GcExperienceTimers FlybyTimers;
        /* 0x08FC */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Size = 0x5)]
        /* 0x091C */ public int[] FreighterTechQualityWeightings;
        /* 0x0930 */ public int SentinelsHigh;
        /* 0x0934 */ public int SentinelsLow;
        /* 0x0938 */ public float AsteroidHitForce;
        /* 0x093C */ public float AsteroidTorqueForce;
        /* 0x0940 */ public float AsteroidCarveRadius;
        /* 0x0944 */ public int DeathMoneyPenalty;
        /* 0x0948 */ public int DeathMoneyPenaltyHardMode;
        /* 0x094C */ public int MaxResourceCrystalBlobSize;
        /* 0x0950 */ public float BuildingBeamDistance;
        /* 0x0954 */ public float WaypointScanTime;
        /* 0x0958 */ public int RareSubstanceEffectiveness;
        /* 0x095C */ public int CommonProductEffectiveness;
        /* 0x0960 */ public int RareProductEffectiveness;
        /* 0x0964 */ public int AsteroidResourceReducer;
        /* 0x0968 */ public float VoxelAsteroidResourceChance;
        /* 0x096C */ public int ResourceReducer;
        /* 0x0970 */ public int ResourceMinAmount;
        /* 0x0974 */ public int ResourceMaxAmount;
        /* 0x0978 */ public int ResourceCommonReducer;
        /* 0x097C */ public int ResourceCommonMinAmount;
        /* 0x0980 */ public int ResourceCommonMaxAmount;
        /* 0x0984 */ public int ResourceDirtReducer;
        /* 0x0988 */ public int ResourceDirtMinAmount;
        /* 0x098C */ public int ResourceDirtMaxAmount;
        /* 0x0990 */ public NMSString0x10 ResourceDirtSubstanceID;
        /* 0x09A0 */ public NMSString0x10 BioShipTerrainResource;
        /* 0x09B0 */ public NMSString0x20 RobotResource;
        /* 0x09D0 */ public NMSString0x20 DepotResource;
        /* 0x09F0 */ public float DockNodeBuyRadius;
        /* 0x09F4 */ public float BeaconInteractRange;
        /* 0x09F8 */ public float ShipInteractRadius;
        /* 0x09FC */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0A30 */ public float ScanAngleCutoff;
        /* 0x0A34 */ public GcScanData ToolScan;
        /* 0x0A48 */ public GcScanData ToolScanHardMode;
        /* 0x0A5C */ public GcScanData WaypointScan;
        /* 0x0A70 */ public GcScanData BeaconScan;
        /* 0x0A84 */ public GcScanData RadioTowerScan;
        /* 0x0A98 */ public GcScanData ObservatoryScan;
        /* 0x0AAC */ public GcScanData DistressSignalScan;
        /* 0x0AC0 */ public GcScanData DebugScanPlanet;
        /* 0x0AD4 */ public GcScanData DebugScanSpace;
        /* 0x0AE8 */ public GcScanData ShipScan;
        /* 0x0AFC */ public GcScanData VisualScan;
        /* 0x0B10 */ public float ZoomFindBuildingRange;
        /* 0x0B14 */ public float TimeToDisplayScanResults;
        /* 0x0B18 */ public float HoverTimeToScan;
        /* 0x0B1C */ public float HoverTimeToScanCreatures;
        /* 0x0B20 */ public int HoverVisiblePointsNeeded;
        /* 0x0B28 */ public List<GcZoomData> ZoomLevels;
        /* 0x0B40 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0B90 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0BE0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0C30 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0C80 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0CD0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0D20 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x0D70 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x0DC0 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x0E10 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0E60 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x0EB0 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x0F00 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x0F50 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x0FA0 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x0FF0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x1040 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x1090 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x10E0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x1130 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x1180 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x11D0 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x11D4 */ public bool UseDebugScan;
        /* 0x11D5 */ public bool DebugScanForceBuilding;
        /* 0x11D8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x11DC */ public float ShipScanOffset;
        /* 0x11E0 */ public float ShipScanOffsetGap;
        /* 0x11E4 */ public TkCurveType ShipScanCurve;
        /* 0x11E8 */ public float ScannerMarkerFadeTime;
        /* 0x11EC */ public float ScannerSmallMarkerFadeTime;
        /* 0x11F0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x11F4 */ public float ScannerAnalyzeFXRate;
        /* 0x11F8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x11FC */ public float ScannerTuningA;
        /* 0x1200 */ public float ScannerTuningB;
        /* 0x1204 */ public float ScannerTuningC;
        /* 0x1208 */ public float ScannerTuningD;
        /* 0x120C */ public float ScannerTuningResourceOffset1;
        /* 0x1210 */ public float ScannerTuningResourceOffset2;
        /* 0x1214 */ public float ScannerTuningSmoothStepAmount;
        /* 0x1218 */ public float ScannerTuningTrailingEdge;
        /* 0x121C */ public bool Autolevel;
        /* 0x1220 */ public Colour ScannerColour1;
        /* 0x1230 */ public Colour ScannerColour2;
        /* 0x1240 */ public float HUDStoreFlashTime;
        /* 0x1244 */ public float ExcitingViewAngle;
        /* 0x1248 */ public float ExcitingViewRange;
        /* 0x124C */ public float ExcitingNearRange;
        /* 0x1250 */ public float ProjectileSpeedBoost;
        /* 0x1254 */ public float LineWidth;
        /* 0x1258 */ public float LockOffFactor;
        /* 0x125C */ public float OffscreenFadeDistance;
        /* 0x1260 */ public float OffscreenMinDot;
        /* 0x1264 */ public bool HUDUpdateFromData;
        /* 0x1268 */ public float HUDLockOnAudioTime;
        /* 0x126C */ public float HUDArrowPrimaryScaler;
        /* 0x1270 */ public Vector2f HUDDamageSize;
        /* 0x1278 */ public Vector2f HUDDamageSplatSize;
        /* 0x1280 */ public Colour HUDDamageSplatShieldColour;
        /* 0x1290 */ public Colour HUDDamageSplatPainColour;
        /* 0x12A0 */ public float HUDDamageOffset;
        /* 0x12A4 */ public float HUDDamageScaler;
        /* 0x12A8 */ public float HUDDamageRadius;
        /* 0x12B0 */ public GcShipHUDTargetData HUDTarget;
        /* 0x16E0 */ public float HUDLabelTime;
        /* 0x16E4 */ public float HUDLabelAngle;
        /* 0x16E8 */ public float HUDLabelAngleOffset;
        /* 0x16EC */ public float HUDLabelOffsetX;
        /* 0x16F0 */ public float HUDLabelOffsetY;
        /* 0x16F4 */ public float HUDLabelOffsetZ;
        /* 0x16F8 */ public float HUDLabelScale;
        /* 0x16FC */ public float MaxSpawnTime;
        /* 0x1700 */ public NMSString0x80 ResourceParticleFile;
        /* 0x1780 */ public float ResourceParticleSpeed;
        /* 0x1784 */ public float ResourceParticleSpread;
        /* 0x1788 */ public int ResourceParticleMaxNum;
        /* 0x178C */ public int ResourceParticleMinNum;
        /* 0x1790 */ public float MapHeight;
        /* 0x1794 */ public float MapOffset;
        /* 0x1798 */ public float MapTargetOffset;
        /* 0x179C */ public float MapFOV;
        /* 0x17A0 */ public float MapRadius;
        /* 0x17A4 */ public float HUDScaleAdd;
        /* 0x17A8 */ public float HUDScaleRadius;
        /* 0x17AC */ public float HUDScaleMin;
        /* 0x17B0 */ public float HUDScaleMinAim;
        /* 0x17B4 */ public float HUDScaleMax;
        /* 0x17B8 */ public float HUDScaleFarTarget;
        /* 0x17BC */ public float HUDReticuleMoveBack;
        /* 0x17C0 */ public float HUDReticuleMoveAim;
        /* 0x17C4 */ public float MouseSensitivity;
        /* 0x17C8 */ public float MouseSensitivityShip;
        /* 0x17CC */ public float MouseSensitivityVehicle;
        /* 0x17D0 */ public float PainTime;
        /* 0x17D4 */ public TkCurveType PainCurve;
        /* 0x17E0 */ public Colour PainColour;
        /* 0x17F0 */ public float GunOffsetX;
        /* 0x17F4 */ public float GunOffsetY;
        /* 0x17F8 */ public float GunOffsetZ;
        /* 0x17FC */ public float GunDownAngle;
        /* 0x1800 */ public float GunUpAngle;
        /* 0x1804 */ public float BarrelOffset;
        /* 0x1808 */ public float HitOffset;
        /* 0x180C */ public GcTracerData BulletTracer;
        /* 0x1824 */ public GcTracerData ShipTracer;
        /* 0x1840 */ public NMSString0x10 DefaultAnim;
        /* 0x1850 */ public bool DebugDrawTriggerBoxes;
        /* 0x1854 */ public float SpeedReadoutMultiplier;
        /* 0x1858 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x185C */ public int TorchCookieIndex;
        /* 0x1860 */ public float TorchFoV;
        /* 0x1864 */ public float TorchStrength;
        /* 0x1868 */ public int TorchDimCookieIndex;
        /* 0x186C */ public float TorchDimFoV;
        /* 0x1870 */ public float TorchDimStrength;
        /* 0x1874 */ public float InteractionTorchFoV;
        /* 0x1878 */ public float InteractionTorchStrength;
        /* 0x187C */ public float UndergroundTorchFoV;
        /* 0x1880 */ public float UndergroundTorchStrength;
        /* 0x1884 */ public float TorchOffsetX;
        /* 0x1888 */ public float TorchOffsetY;
        /* 0x188C */ public float TorchOffsetZ;
        /* 0x1890 */ public float TorchOffsetZMin;
        /* 0x1894 */ public float TorchOffsetZSpeedRange;
        /* 0x1898 */ public float TorchOffsetZMinSpeed;
        /* 0x189C */ public float TorchHandOffsetX;
        /* 0x18A0 */ public float TorchHandOffsetY;
        /* 0x18A4 */ public float TorchHandOffsetZ;
        /* 0x18A8 */ public bool TorchDisabledInTheDay;
        /* 0x18AC */ public float TorchRotation;
        /* 0x18B0 */ public float TorchFollowCameraPitch;
        /* 0x18B4 */ public float TorchFollowCameraTime;
        /* 0x18C0 */ public Colour TorchColour;
        /* 0x18D0 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x18E0 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x18F0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x18F4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x18F8 */ public float SimpleInteractionPickupAngle;
        /* 0x18FC */ public float SimpleInteractionPickupRadius;
        /* 0x1900 */ public float SimpleInteractionMessageTime;
        /* 0x1904 */ public float InteractionPickupAngle;
        /* 0x1908 */ public float InteractionPickupRadius;
        /* 0x190C */ public float ExplosionRadiusMultiplier;
        /* 0x1910 */ public float ExplosionForce;
        /* 0x1914 */ public float ExplosionForceMaxForceRadius;
        /* 0x1918 */ public float LaserExplosionForceRadius;
        /* 0x191C */ public float LaserExplosionForce;
        /* 0x1920 */ public float LaserExplosionForceMaxForceRadius;
        /* 0x1924 */ public NMSString0x80 InitialDebrisScene;
        /* 0x19A4 */ public float BonusSameTypeElementsAdd;
        /* 0x19A8 */ public float BonusSameTypeElementsMultiply;
        /* 0x19AC */ public float BonusChildTypeElementsAdd;
        /* 0x19B0 */ public float BonusChildTypeElementsMultiply;
        /* 0x19B4 */ public float InteractionComponentUpdateDistance;
        /* 0x19B8 */ public float GoalGapVoxelDist;
        /* 0x19BC */ public float BlackHoleJumpVoxelDist;
        /* 0x19C0 */ public float BlackHoleJumpVoxelVariation;
        /* 0x19C4 */ public float JumpToCenterFuelCost;
        /* 0x19C8 */ public int WarpsBetweenMiniStation;
        /* 0x19CC */ public float HoursBetweenMiniStation;
        /* 0x19D0 */ public NMSString0x80 LegacyBaseBuildingTable;
        /* 0x1A50 */ public NMSString0x80 BaseBuildingTable;
        /* 0x1AD0 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1AD8 */ public float LightStrength;
        /* 0x1ADC */ public float AirLockDoorRange;
        /* 0x1AE0 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1AE1 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1AE2 */ public bool UseMultiplierBonus;
        /* 0x1AE4 */ public float ShipDisplayDamageMultiplier;
        /* 0x1AE8 */ public float IllegalProductTradingMod;
        /* 0x1AEC */ public bool UseTradingCostTable;
        /* 0x1AED */ public bool ChangePricesLocally;
        /* 0x1AEE */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1AF0 */ public int ProductItemStockDecayTime;
        /* 0x1AF4 */ public int ProductItemStockReplenishTime;
        /* 0x1AF8 */ public int SubstanceItemStockDecayTime;
        /* 0x1AFC */ public int SubstanceItemStockReplenishTime;
        /* 0x1B00 */ public GcPortalData Portal;
        /* 0x1B08 */ public int FourthRaceSpawnPercentage;
        /* 0x1B0C */ public int NonDominantRaceSpawnPercentage;
        /* 0x1B10 */ public float ViciousSentinelProbability;
        /* 0x1B14 */ public float ViciousStormProbability;
        /* 0x1B18 */ public float ViciousWeatherProbability;
        /* 0x1B1C */ public float ScrapDroneProbability;
        /* 0x1B20 */ public float MaxRespawnOnGroundHeight;
        /* 0x1B24 */ public float DeadPlanetGravityFactor;
        /* 0x1B30 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x1B80 */ public float SalvageShipPitch;
        /* 0x1B84 */ public float SalvageShipHeightOffset;
        /* 0x1B88 */ public float SalvageShipExplodeSpeed;
        /* 0x1B8C */ public float SalvageShipShowShipSpeed;
        /* 0x1B90 */ public float SalvageShipShowShipDistance;
        /* 0x1B94 */ public float SalvageShipExplodeShipDistance;
        /* 0x1B98 */ public float SalvageShipOneRevolutionTime;
        /* 0x1BA0 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        /* 0x1BC0 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        /* 0x1BE0 */ public float PulseEncounterCheckTimer;
        /* 0x1BE4 */ public float PulseEncounterChance;
        /* 0x1BE8 */ public float PulseEncounterChanceStandard;
        /* 0x1BEC */ public float PulseEncounterChanceRed;
        /* 0x1BF0 */ public float PulseEncounterChanceGreen;
        /* 0x1BF4 */ public float PulseEncounterChanceBlue;
        /* 0x1BF8 */ public float PulseEncounterStopPower;
        /* 0x1BFC */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x5)]
        /* 0x1C00 */ public int[] AlienShipEvolveCosts;
        /* 0x1C14 */ public float SpawnerWeaponRange;
        /* 0x1C18 */ public TkTextureResource WeaponSpawnObject;
        /* 0x1C9C */ public TkTextureResource WeaponSpawnAltObject;
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