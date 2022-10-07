using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCA8C490826A0A433, NameHash = 0xC45203411E9AFE95)]
    public class GcSpaceshipGlobals : NMSTemplate
    {
        /* 0x0000 */ public float ShieldLeechMul;
        /* 0x0004 */ public float AtmosphereCombatHeight;
        /* 0x0008 */ public NMSString0x10 SailShipCoreTechID;
        /* 0x0018 */ public bool AllowSideScreenPointing;
        /* 0x0019 */ public bool AddShipToCollectionOnEnter;
        /* 0x001A */ public bool EnablePulseDriveSpaceStationOrient;
        /* 0x001C */ public float DockingApproachRollHmdMod;
        /* 0x0020 */ public float DockingApproachSpeedHmdMod;
        /* 0x0024 */ public float DockingApproachBrakeHmdMod;
        /* 0x0028 */ public float LandingDirectionalSideOffsetFactor;
        /* 0x002C */ public float LandingHoverOffset;
        /* 0x0030 */ public float LandingMaxSpeed;
        /* 0x0034 */ public float LandingMaxAngle;
        /* 0x0038 */ public float LandingMargin;
        /* 0x003C */ public float LandingObstacleMinHeight;
        /* 0x0040 */ public float LandingTooManyLowPointsFraction;
        /* 0x0044 */ public float VignetteAmountAcceleration;
        /* 0x0048 */ public float VignetteAmountTurning;
        /* 0x004C */ public float PulseDriveBoostDoubleTapTime;
        /* 0x0050 */ public float RudderToRollMultiplierMin;
        /* 0x0054 */ public float RudderToRollMultiplierMax;
        /* 0x0058 */ public float RudderToRollMultiplierOpposite;
        /* 0x005C */ public float RudderToRollMultiplierSpace;
        /* 0x0060 */ public float RudderToRollMultiplierLow;
        /* 0x0064 */ public float RudderToRollCutoffRotation;
        /* 0x0068 */ public float RudderToRollUpsideDownRotation;
        /* 0x006C */ public TkCurveType RudderToRollCurve;
        /* 0x0070 */ public float RudderToRollAngleUpMax;
        /* 0x0074 */ public float RudderToRollAngleDownMin;
        /* 0x0078 */ public float RudderToRollAngleDownMax;
        /* 0x007C */ public float PulseDriveStationApproachAngleMin;
        /* 0x0080 */ public float PulseDriveStationApproachAngleRange;
        /* 0x0084 */ public float PulseDriveStationApproachPerpAngleMin;
        /* 0x0088 */ public float PulseDriveStationApproachPerpAngleRange;
        /* 0x008C */ public float PulseDriveStationApproachOffset;
        /* 0x0090 */ public float PulseDriveStationApproachSlowdown;
        /* 0x0094 */ public float PulseDriveStationApproachSlowdownRangeMin;
        /* 0x0098 */ public float PulseDriveStationApproachSlowdownRange;
        /* 0x009C */ public float HandControllerActiveBlendMinTime;
        /* 0x00A0 */ public float HandControllerActiveBlendTime;
        /* 0x00A4 */ public Vector2f HandControllerValueMultiplier;
        /* 0x00AC */ public Vector2f HandControllerValueMultiplierSpace;
        /* 0x00B4 */ public Vector2f HandControllerDeadZone;
        /* 0x00BC */ public Vector2f HandControllerExtents;
        /* 0x00C4 */ public float HandControllerXReorientationMove;
        /* 0x00C8 */ public float HandControllerZReorientationMove;
        /* 0x00CC */ public float HandControllerXReorientation;
        /* 0x00D0 */ public float HandControllerZReorientation;
        /* 0x00D4 */ public float HandControllerThrottleDistance;
        /* 0x00D8 */ public float HandControllerThrottleRange;
        /* 0x00DC */ public float HandControllerThrottleDeadZone;
        /* 0x00E0 */ public float HandControllerDirOffsetAngle;
        /* 0x00E4 */ public float HandControllerDirOffsetAngleMove;
        /* 0x00E8 */ public float CockpitRollAngleHmd;
        /* 0x00EC */ public float CockpitPitchCorrectAngleHmd;
        /* 0x00F0 */ public float CockpitDriftAngleHmd;
        /* 0x00F4 */ public float CockpitRollAngle;
        /* 0x00F8 */ public float CockpitPitchCorrectAngle;
        /* 0x00FC */ public float CockpitDriftAngle;
        /* 0x0100 */ public float CockpitRollAngleExtra;
        /* 0x0104 */ public float CockpitRollTime;
        /* 0x0108 */ public float CockpitRollMultiplierCentre;
        /* 0x010C */ public float CockpitRollMultiplierOpposite;
        /* 0x0110 */ public float MaximumDistanceFromShipWhenExiting;
        /* 0x0114 */ public float MaximumHeightWhenExitingShip;
        /* 0x0118 */ public float DistanceFromShipToAllowSpawningOnFreighter;
        /* 0x011C */ public float FreighterBattleIgnoreFriendlyFireDistance;
        /* 0x0120 */ public bool AltControls;
        /* 0x0121 */ public bool SpaceMapInWorld;
        /* 0x0122 */ public bool _3rdPersonShipEnabled;
        /* 0x0123 */ public bool AimZoomAuto;
        /* 0x0124 */ public bool EnableDepthTestedCrosshairSections;
        /* 0x0125 */ public bool CritsFromBehind;
        /* 0x0126 */ public bool DrawLineLockTarget;
        /* 0x0127 */ public bool ApplyHeightForce;
        /* 0x0128 */ public bool ApplyHeightAlign;
        /* 0x0129 */ public bool DoPreCollision;
        /* 0x012A */ public bool SpeedTrackModeEnabled;
        /* 0x012C */ public int TrailMaxNumPointsPerFrameOverride;
        /* 0x0130 */ public float TestTrailSpeed;
        /* 0x0134 */ public float TestTrailRadius;
        /* 0x0138 */ public float CockpitExitAnimTime;
        /* 0x013C */ public float CockpitExitAnimOffset;
        /* 0x0140 */ public TkCurveType CockpitExitAnimCurve;
        /* 0x0144 */ public float WingmanSpeedTrackForceMax;
        /* 0x0148 */ public float WingmanSpeedTrackForceMin;
        /* 0x014C */ public float WingmanSpeedTrackDistance;
        /* 0x0150 */ public float WingmanSpeedTrackOffset;
        /* 0x0154 */ public float WingmanSpeedApproachSpeed;
        /* 0x0158 */ public float WingmanSpeedApproachSpeedSpace;
        /* 0x015C */ public float DockingAttractAlign;
        /* 0x0160 */ public float DockingAttractAlignRange;
        /* 0x0170 */ public Colour LandingEffectSpaceColourOverride;
        /* 0x0180 */ public Colour GroundEffectBuildingColour;
        /* 0x0190 */ public Colour GroundEffectWaterColour;
        /* 0x01A0 */ public float GroundNearEffectLightFactor;
        /* 0x01A4 */ public float GroundNearEffectWaterLightFactor;
        /* 0x01A8 */ public float GroundWaterSpeedFactor;
        /* 0x01AC */ public float AtmosphereLightIntensity;
        /* 0x01B0 */ public Vector3f AtmosphereLightOffset;
        /* 0x01C0 */ public float OutpostDockSpeedAlignMinDistance;
        /* 0x01C4 */ public float OutpostDockSpeedAlignRange;
        /* 0x01C8 */ public float NearGroundPitchCorrectMinHeight;
        /* 0x01CC */ public float NearGroundPitchCorrectRange;
        /* 0x01D0 */ public float NearGroundPitchCorrectMinHeightRemote;
        /* 0x01D4 */ public float NearGroundPitchCorrectRangeRemote;
        /* 0x01D8 */ public float MiniWarpMarkerApproachSlowdown;
        /* 0x01DC */ public float MiniWarpMarkerAlignSlowdown;
        /* 0x01E0 */ public float MiniWarpMarkerAlignSlowdownRange;
        /* 0x01E4 */ public float MiniWarpAlignSlerp;
        /* 0x01E8 */ public float WarpInTime;
        /* 0x01EC */ public float WarpInFlashTime;
        /* 0x01F0 */ public float WarpInRange;
        /* 0x01F4 */ public float WarpScale;
        /* 0x01F8 */ public float WarpInTimeFreighter;
        /* 0x01FC */ public float WarpInFlashTimeFreighter;
        /* 0x0200 */ public float WarpInRangeFreighter;
        /* 0x0204 */ public float WarpScaleFreighter;
        /* 0x0208 */ public float WarpFadeInTime;
        /* 0x020C */ public float WarpInLineWidth;
        /* 0x0210 */ public TkCurveType WarpInCurve;
        /* 0x0214 */ public float WarpOutRange;
        /* 0x0218 */ public float WarpOutTime;
        /* 0x021C */ public float WarpInTimeNexus;
        /* 0x0220 */ public float WarpInFlashTimeNexus;
        /* 0x0224 */ public float WarpInRangeNexus;
        /* 0x0228 */ public float WarpScaleNexus;
        /* 0x022C */ public float WarpNexusRotation;
        /* 0x0230 */ public float WarpNexusPitch;
        /* 0x0234 */ public float WarpNexusDistance;
        /* 0x0238 */ public float NetworkDockSearchRadius;
        /* 0x023C */ public float DirectionDockingIndicatorRange;
        /* 0x0240 */ public float DirectionDockingIndicatorClearAngleRange;
        /* 0x0244 */ public float DirectionDockingIndicatorAngleRange;
        /* 0x0248 */ public float DirectionDockingIndicatorMinHeight;
        /* 0x024C */ public float DirectionDockingIndicatorMaxHeight;
        /* 0x0250 */ public Colour DirectionDockingInRangeColour;
        /* 0x0260 */ public Colour DirectionDockingOutRangeColour;
        /* 0x0270 */ public float DirectionDockingCircleOffset;
        /* 0x0274 */ public float DirectionDockingCircleOffsetExtra;
        /* 0x0278 */ public float DirectionDockingCircleWidth;
        /* 0x027C */ public float DirectionDockingCircleRadius;
        /* 0x0280 */ public float DirectionDockingCircleRadiusExtra;
        /* 0x0284 */ public float DirectionDockingIndicatorSpeed;
        /* 0x0288 */ public TkCurveType DirectionDockingIndicatorCurve;
        /* 0x028C */ public float ExhaustSpeed;
        /* 0x0290 */ public float LowAltitudeAnimationHeight;
        /* 0x0294 */ public float LowAltitudeAnimationHysteresisTime;
        /* 0x0298 */ public float LowAltitudeAnimationTime;
        /* 0x029C */ public float LowAltitudeContrailFadeAtAnimProgress;
        /* 0x02A0 */ public float GroundNearEffectHeight;
        /* 0x02A4 */ public float GroundNearEffectRange;
        /* 0x02A8 */ public float GroundNearEffectNormalOffset;
        /* 0x02AC */ public float GroundNearEffectBuildingFade;
        /* 0x02B0 */ public bool TestShipAnims;
        /* 0x02B4 */ public float TestShipAnimRoll;
        /* 0x02B8 */ public float TestShipAnimThrust;
        /* 0x02BC */ public float TestShipAnimPulse;
        /* 0x02C0 */ public float TestShipAnimSpace;
        /* 0x02C4 */ public float TestShipAnimLowAltitude;
        /* 0x02C8 */ public GcSpaceshipAvoidanceData Avoidance;
        /* 0x02EC */ public float DefaultTrailInitialSpeed;
        /* 0x02F0 */ public float DefaultTrailSpeedDamping;
        /* 0x02F4 */ public float DefaultTrailMinForwardSpeed;
        /* 0x02F8 */ public float TrailVelocityFactor;
        /* 0x02FC */ public float ContrailSpeedDamping;
        /* 0x0300 */ public float MaxOverspeedBrake;
        /* 0x0304 */ public float PostWarpSlowDownTime;
        /* 0x0308 */ public float PostFreighterWarpTransitionTime;
        /* 0x030C */ public float PulseDrivePlanetApproachMinAngle;
        /* 0x0310 */ public float PulseDrivePlanetApproachMaxAngle;
        /* 0x0314 */ public float PulseDrivePlanetApproachHeight;
        /* 0x0318 */ public float TestJetsStage1;
        /* 0x031C */ public float TestJetsStage2;
        /* 0x0320 */ public float TestJetsBoost;
        /* 0x0324 */ public float TestTrailThreshold;
        /* 0x0328 */ public float ContrailDefaultAlpha;
        /* 0x032C */ public float EngineJetLightIntensityMultiplier;
        /* 0x0330 */ public float EngineEffectsThrustContribution;
        /* 0x0334 */ public float TestShieldEffect;
        /* 0x0338 */ public float ShieldEffectHitTime;
        /* 0x033C */ public TkCurveType ShieldEffectHitCurve;
        /* 0x0340 */ public GcScanEffectData ShieldEffectScanData;
        /* 0x0390 */ public float AcrobaticLowFlightLevel;
        /* 0x0394 */ public float _3rdPersonUpOffsetRollChangeSpeed;
        /* 0x0398 */ public float _3rdPersonRollAngle;
        /* 0x039C */ public float _3rdPersonRollAngleDropship;
        /* 0x03A0 */ public float _3rdPersonRollAngleScience;
        /* 0x03A4 */ public float _3rdPersonRollAngleAlien;
        /* 0x03A8 */ public float _3rdPersonPitchAngle;
        /* 0x03AC */ public float _3rdPersonYawAngle;
        /* 0x03B0 */ public float _3rdPersonYawAngleLateralExtra;
        /* 0x03B4 */ public float _3rdPersonAngleSpringTime;
        /* 0x03B8 */ public float _3rdPersonAngleMinSpeed;
        /* 0x03BC */ public float _3rdPersonAngleSpeedRangePitch;
        /* 0x03C0 */ public float _3rdPersonAngleSpeedRangeYaw;
        /* 0x03C4 */ public float _3rdPersonLowHeightMin;
        /* 0x03C8 */ public float _3rdPersonLowHeightMax;
        /* 0x03CC */ public float _3rdPersonLowHeightOffsetVertRotationY;
        /* 0x03D0 */ public float _3rdPersonLowHeightOffsetY;
        /* 0x03D4 */ public float _3rdPersonLowHeightSpringTime;
        /* 0x03D8 */ public float _3rdPersonAvoidanceAdjustPitchFactor;
        /* 0x03DC */ public float _3rdPersonHeightForceAdjustPitchFactor;
        /* 0x03E0 */ public float _3rdPersonAvoidanceAdjustRollFactor;
        /* 0x03E4 */ public float _3rdPersonAvoidanceAdjustYawFactor;
        /* 0x03E8 */ public float _3rdPersonFlashIntensity;
        /* 0x03EC */ public float _3rdPersonFlashDuration;
        /* 0x03F0 */ public float _3rdPersonTransitionTime;
        /* 0x03F4 */ public float _3rdPersonWarpXWander;
        /* 0x03F8 */ public float _3rdPersonWarpYWander;
        /* 0x03FC */ public float _3rdPersonWarpZWander;
        /* 0x0400 */ public float _3rdPersonWarpWanderStartTime;
        /* 0x0404 */ public float _3rdPersonWarpWanderSpring;
        /* 0x0408 */ public float _3rdPersonWarpWanderTimeX;
        /* 0x040C */ public float _3rdPersonWarpWanderTimeY;
        /* 0x0410 */ public float _3rdPersonWarpWanderTimeZ;
        /* 0x0414 */ public TkCurveType _3rdPersonWarpWanderCurve;
        /* 0x0418 */ public float AvoidancePower;
        /* 0x041C */ public float AvoidanceDistancePower;
        /* 0x0420 */ public float CollisionDeflectForce;
        /* 0x0424 */ public float CollisionAlignStrength;
        /* 0x0430 */ public Vector3f DefaultCentreOffset;
        /* 0x0440 */ public Vector3f DefaultCentreOffsetDropship;
        /* 0x0450 */ public Vector3f DefaultCentreOffsetScientific;
        /* 0x0460 */ public Vector3f DefaultCentreOffsetRoyal;
        /* 0x0470 */ public Vector3f DefaultCentreOffsetSail;
        /* 0x0480 */ public float WeaponDamagePotentialReferenceRange;
        /* 0x0484 */ public float DirectionBrakeVerticalMultiplier;
        /* 0x0488 */ public float LateralDriftRollAmount;
        /* 0x048C */ public float LateralDriftRange;
        /* 0x0490 */ public float PadTurnSpeed;
        /* 0x0494 */ public float PadThrustSmoothTime;
        /* 0x0498 */ public float KBThrustSmoothTime;
        /* 0x049C */ public float HoverTakeoffHeight;
        /* 0x04A0 */ public float HoverTime;
        /* 0x04A4 */ public float HoverAlignTime;
        /* 0x04A8 */ public float HoverTimeAlt;
        /* 0x04AC */ public float HoverAlignTimeAlt;
        /* 0x04B0 */ public float HoverSpeedFactor;
        /* 0x04B4 */ public float HoverHeightFactor;
        /* 0x04B8 */ public float HoverMinSpeed;
        /* 0x04BC */ public float HoverLandReachedMinTime;
        /* 0x04C0 */ public float HoverLandReachedDistance;
        /* 0x04C4 */ public float HoverLandManeuvreTimeMin;
        /* 0x04C8 */ public float HoverLandManeuvreTimeMax;
        /* 0x04CC */ public float HoverLandManeuvreTimeHmdMin;
        /* 0x04D0 */ public float HoverLandManeuvreTimeHmdMax;
        /* 0x04D4 */ public float HoverLandManeuvreBrake;
        /* 0x04D8 */ public float LandingOnGroundTip;
        /* 0x04DC */ public bool LandingCheckBuildings;
        /* 0x04E0 */ public float LandingCheckBuildingRadiusFactor;
        /* 0x04E4 */ public float AutoLevelWaterMargin;
        /* 0x04E8 */ public float AutoLevelWaterTorque;
        /* 0x04EC */ public float AutoLevelWaterAngle;
        /* 0x04F0 */ public float AutoLevelPitchCorrectMargin;
        /* 0x0500 */ public Vector3f PostCollisionAngularFactor;
        /* 0x0510 */ public float DrawLineLockTargetLineWidth;
        /* 0x0514 */ public float DamageFlashScale;
        /* 0x0518 */ public float DamageFlashMin;
        /* 0x051C */ public float LandingButtonMinTime;
        /* 0x0520 */ public float LandingPushNoseUpFactor;
        /* 0x0524 */ public float GroundHeightSoftForce;
        /* 0x0528 */ public float GroundHeightSoft;
        /* 0x052C */ public float GroundHeightSoftHorizontal;
        /* 0x0530 */ public TkCurveType GroundHeightSoftCurve;
        /* 0x0534 */ public float GroundHeightHard;
        /* 0x0538 */ public float GroundHeightHardHorizontal;
        /* 0x053C */ public TkCurveType GroundHeightHardCurve;
        /* 0x0540 */ public float GroundHeightPostCollisionMultiplier;
        /* 0x0544 */ public float GroundHeightPostCollisionMultiplierTime;
        /* 0x0548 */ public float GroundHeightDownSpeedMultiplier;
        /* 0x054C */ public float GroundHeightBrakeMultiplier;
        /* 0x0550 */ public float PitchCorrectDownSpeedMinSpeed;
        /* 0x0554 */ public float PitchCorrectDownSpeedRange;
        /* 0x0558 */ public float PitchCorrectDownSpeedSoftAngle;
        /* 0x055C */ public float PitchCorrectDownSpeedMaxDownAngle;
        /* 0x0560 */ public float PitchCorrectDownSpeedHeightMin;
        /* 0x0564 */ public float PitchCorrectDownSpeedHeightMax;
        /* 0x0568 */ public float PitchCorrectCockpitSpring;
        /* 0x056C */ public float PitchCorrectSoftDownAngle;
        /* 0x0570 */ public float PitchCorrectMaxDownAngle;
        /* 0x0574 */ public float PitchCorrectMaxDownAnglePostCollision;
        /* 0x0578 */ public float PitchCorrectSoftDownAnglePostCollision;
        /* 0x057C */ public float PitchCorrectMaxDownAngleWater;
        /* 0x0580 */ public float PitchCorrectSoftDownAngleWater;
        /* 0x0584 */ public float PitchCorrectTimeMin;
        /* 0x0588 */ public float PitchCorrectTimeMax;
        /* 0x058C */ public float PitchCorrectTimeHeight;
        /* 0x0590 */ public float PitchCorrectHeightSpring;
        /* 0x0594 */ public float PitchCorrectHeightMin;
        /* 0x0598 */ public float PitchCorrectHeightMax;
        /* 0x059C */ public TkCurveType PitchCorrectHeightCurve;
        /* 0x05A0 */ public TkCurveType LandingCurve;
        /* 0x05A4 */ public TkCurveType LandingCurveHeavy;
        /* 0x05A8 */ public GcPlayerSpaceshipControlData Control;
        /* 0x07C4 */ public GcPlayerSpaceshipControlData ControlLight;
        /* 0x09E0 */ public GcPlayerSpaceshipControlData ControlHeavy;
        /* 0x0BFC */ public GcPlayerSpaceshipClassBonuses ControlBonusC;
        /* 0x0C2C */ public GcPlayerSpaceshipClassBonuses ControlBonusB;
        /* 0x0C5C */ public GcPlayerSpaceshipClassBonuses ControlBonusA;
        /* 0x0C8C */ public GcPlayerSpaceshipClassBonuses ControlBonusS;
        /* 0x0CBC */ public float HaulerTakeOffMod;
        /* 0x0CC0 */ public float FighterTakeOffMod;
        /* 0x0CC4 */ public float ShuttleTakeOffMod;
        /* 0x0CC8 */ public float ExplorerTakeOffMod;
        /* 0x0CCC */ public float RoyalTakeOffMod;
        /* 0x0CD0 */ public Colour AlarmLightColour;
        /* 0x0CE0 */ public Colour AlarmLightColourHostile;
        /* 0x0CF0 */ public List<Vector3f> AlarmLightOffsets;
        /* 0x0D00 */ public float AlarmLightIntensity;
        /* 0x0D04 */ public float AlarmRate;
        /* 0x0D08 */ public float AlarmLightIntensityHostile;
        /* 0x0D0C */ public float AlarmRateHostileMin;
        /* 0x0D10 */ public float AlarmRateHostileMax;
        /* 0x0D14 */ public float AlarmLastHitTime;
        /* 0x0D18 */ public float LockTargetMinDistance;
        /* 0x0D1C */ public float LockTargetRange;
        /* 0x0D20 */ public float LockTargetMinScale;
        /* 0x0D24 */ public float LockTargetMaxScale;
        /* 0x0D28 */ public float AutoLevelMinPitchAngle;
        /* 0x0D2C */ public float AutoLevelMaxPitchAngle;
        /* 0x0D30 */ public float AutoLevelMinAngle;
        /* 0x0D34 */ public float AutoLevelMaxAngle;
        /* 0x0D38 */ public bool AutoEjectOnLanding;
        /* 0x0D39 */ public bool LandedCockpitFreeLook;
        /* 0x0D3C */ public float FrigateTargetLockRange;
        /* 0x0D40 */ public float ResetTargetLockAngle;
        /* 0x0D44 */ public float TargetLockRange;
        /* 0x0D48 */ public float TargetLockNearestAngle;
        /* 0x0D4C */ public float RemotePlayerLockTimeAfterShot;
        /* 0x0D50 */ public Colour TargetLockPassiveColour;
        /* 0x0D60 */ public Colour TargetLockDangerColour;
        /* 0x0D70 */ public float ShieldRechargeMinHitTime;
        /* 0x0D74 */ public float ShieldRechargeRate;
        /* 0x0D78 */ public float NoBoostStationDistance;
        /* 0x0D7C */ public float NoBoostAnomalyDistance;
        /* 0x0D80 */ public float NoBoostSpaceAnomalyDistance;
        /* 0x0D84 */ public float NoBoostFreighterDistance;
        /* 0x0D88 */ public float NoBoostFreighterAngle;
        /* 0x0D8C */ public float NoBoostShipDistance;
        /* 0x0D90 */ public float NoBoostShipNearMinTime;
        /* 0x0D94 */ public float NoBoostShipLastHitTime;
        /* 0x0D98 */ public float NoBoostCombatEventMinBattleTime;
        /* 0x0D9C */ public float NoBoostCombatEventMinFreighterBattleTime;
        /* 0x0DA0 */ public float NoBoostCombatEventTime;
        /* 0x0DA4 */ public float ThrustDecaySpring;
        /* 0x0DA8 */ public float ThrustDecaySpringCombat;
        /* 0x0DAC */ public float DriftEffectIntensity;
        /* 0x0DB0 */ public float SpeedCoolOffset;
        /* 0x0DB4 */ public float SpeedCoolNormalSpeedAmount;
        /* 0x0DB8 */ public int HitAsteroidDamage;
        /* 0x0DBC */ public float CameraPostWarpFovTime;
        /* 0x0DC0 */ public float CameraPostWarpFov;
        /* 0x0DC4 */ public float PlayerFreighterClearSpaceRadius;
        /* 0x0DC8 */ public float DriftSpring;
        /* 0x0DCC */ public float DriftTurnStrengthMultiplier;
        /* 0x0DD0 */ public float DriftTurnBrakeMultiplier;
        /* 0x0DD4 */ public float DirectionBrakeVRBoost;
        /* 0x0DD8 */ public float TurnRudderStrength;
        /* 0x0DDC */ public float MuzzleLightIntensity;
        /* 0x0DE0 */ public float MuzzleAnimSpeed;
        /* 0x0DE4 */ public TkHitCurveData MuzzleLightCurve;
        /* 0x0E00 */ public Colour MuzzleLightColour;
        /* 0x0E10 */ public Vector3f DamageLightOffsetTop;
        /* 0x0E20 */ public Vector3f DamageLightOffsetLeft;
        /* 0x0E30 */ public Vector3f DamageLightOffsetRight;
        /* 0x0E40 */ public float DamageLightIntensity;
        /* 0x0E44 */ public TkHitCurveData DamageLightCurve;
        /* 0x0E60 */ public Colour DamageLightColourShield;
        /* 0x0E70 */ public Colour DamageLightColour;
        /* 0x0E80 */ public bool AltAtmosphere;
        /* 0x0E84 */ public float AsteroidHitAngle;
        /* 0x0E88 */ public float AsteroidHitAngleBoosting;
        /* 0x0E8C */ public float AimCritAngle;
        /* 0x0E90 */ public float AimCritMinFwdAngle;
        /* 0x0E94 */ public float AimCritBehindAngle;
        /* 0x0E98 */ public float MissileShootTime;
        /* 0x0E9C */ public float CruiseHeight;
        /* 0x0EA0 */ public float CruiseHeightRange;
        /* 0x0EA4 */ public float CruiseOffAngle;
        /* 0x0EA8 */ public float CruiseOffAngleRange;
        /* 0x0EAC */ public float CruiseForce;
        /* 0x0EB0 */ public float HoverMaxSpeed;
        /* 0x0EB4 */ public float HoverStopTime;
        /* 0x0EB8 */ public float LandOffset;
        /* 0x0EBC */ public float AimFoVBoost;
        /* 0x0EC0 */ public float AimFoVBoostTime;
        /* 0x0EC4 */ public float AimFoVBoostTimeAuto;
        /* 0x0EC8 */ public float AimTurnSlower;
        /* 0x0ECC */ public float AimMaxAutoAngle;
        /* 0x0ED0 */ public float HoverBrakeStrength;
        /* 0x0ED4 */ public float StickyTurnMinAngle;
        /* 0x0ED8 */ public float StickyTurnAngleRange;
        /* 0x0EDC */ public float StickyTurnLow;
        /* 0x0EE0 */ public float StickyTurnHigh;
        /* 0x0EE4 */ public float StickyStickAngle;
        /* 0x0EE8 */ public float ShipMotionDeadZone;
        /* 0x0EEC */ public Vector2f DeathSpinRoll;
        /* 0x0EF4 */ public Vector2f DeathSpinPitch;
        /* 0x0EFC */ public int MiniWarpLinesNum;
        /* 0x0F00 */ public float MiniWarpLinesSpacing;
        /* 0x0F04 */ public float MiniWarpLinesOffset;
        /* 0x0F08 */ public float MiniWarpLinesHeight;
        /* 0x0F0C */ public float GravityDropMinHeight;
        /* 0x0F10 */ public float GravityDropMaxForceHeight;
        /* 0x0F14 */ public float GravityDropMaxHeight;
        /* 0x0F18 */ public float GravityDropForce;
        /* 0x0F1C */ public GcPlayerStickData StickData;
        /* 0x0F38 */ public float ResourceCollectOffset;
        /* 0x0F3C */ public float AimSpeedTrackDistance;
        /* 0x0F40 */ public float AimSpeedTrackForce;
        /* 0x0F44 */ public float CombatBoostMultiplier;
        /* 0x0F48 */ public float CombatBoostTurnDamp;
        /* 0x0F4C */ public float MarkerEventTime;
        /* 0x0F50 */ public int GunAmmoMultiplier;
        /* 0x0F58 */ public List<GcPlayerSpaceshipAim> LaserAimArray;
        /* 0x0F68 */ public int LaserAimLevel;
        /* 0x0F70 */ public List<GcPlayerSpaceshipAim> GunAimArray;
        /* 0x0F80 */ public int TakeOffCost;
        /* 0x0F84 */ public int LandingCost;
        /* 0x0F88 */ public int GunAimLevel;
        /* 0x0F8C */ public GcPlayerSpaceshipAim MissileAim;
        /* 0x0FA4 */ public float MissileLockSpeedUp;
        /* 0x0FA8 */ public float MissileLockTime;
        /* 0x0FAC */ public float AutoPilotAlignStrength;
        /* 0x0FB0 */ public float AutoPilotSmallShipAlignStrength;
        /* 0x0FB4 */ public float AutoPilotCallDistance;
        /* 0x0FB8 */ public float AutoPilotCallAngle;
        /* 0x0FBC */ public float AutoPilotCallAngleVertical;
        /* 0x0FC0 */ public float AutoPilotPositionAlignStrength;
        /* 0x0FC4 */ public float FreighterApproachDistanceMin;
        /* 0x0FC8 */ public float FreighterApproachDistanceMax;
        /* 0x0FCC */ public float FreighterApproachSpeedDamper;
        /* 0x0FD0 */ public float FreighterApproachExtraMargin;
        /* 0x0FD4 */ public float MiniWarpShakeStrength;
        /* 0x0FD8 */ public float MiniWarpPlanetRadius;
        /* 0x0FDC */ public float MiniWarpStationRadius;
        /* 0x0FE0 */ public float MiniWarpFuelTime;
        /* 0x0FE4 */ public float MiniWarpAlignStrength;
        /* 0x0FE8 */ public float MiniWarpChargeTime;
        /* 0x0FEC */ public float MiniWarpSpeed;
        /* 0x0FF0 */ public float MiniWarpTopSpeedTime;
        /* 0x0FF4 */ public float MiniWarpTime;
        /* 0x0FF8 */ public float MiniWarpCooldownTime;
        /* 0x0FFC */ public float MiniWarpStoppingMarginPlanet;
        /* 0x1000 */ public float MiniWarpMinPlanetDistance;
        /* 0x1004 */ public float MiniWarpStoppingMarginDefault;
        /* 0x1008 */ public float MiniWarpStoppingMarginLong;
        /* 0x100C */ public float MiniWarpTrackingMargin;
        /* 0x1010 */ public float MiniWarpExitSpeed;
        /* 0x1014 */ public float MiniWarpExitSpeedStation;
        /* 0x1018 */ public float MiniWarpExitTime;
        /* 0x101C */ public float MiniWarpHUDArrowAttractAngle;
        /* 0x1020 */ public float MiniWarpHUDArrowAttractAngleStation;
        /* 0x1024 */ public float MiniWarpHUDArrowAttractAngleOtherPlayerStuff;
        /* 0x1028 */ public float MiniWarpHUDArrowAttractAngleSaveBeacon;
        /* 0x102C */ public float MiniWarpHUDArrowAttractAngleDense;
        /* 0x1030 */ public int MiniWarpHUDArrowNumMarkersToBeDense;
        /* 0x1034 */ public TkCurveType MiniWarpCurve;
        /* 0x1038 */ public float MiniWarpFlashIntensity;
        /* 0x103C */ public float MiniWarpFlashDuration;
        /* 0x1040 */ public float MiniWarpFlashDelay;
        /* 0x1044 */ public float MiniWarpNoAsteroidRadius;
        /* 0x1048 */ public float BoostNoAsteroidRadius;
        /* 0x104C */ public float ShipHeatAlertTime;
        /* 0x1050 */ public float LaserOverheatTime;
        /* 0x1054 */ public float LaserOverheatDownTime;
        /* 0x1058 */ public float LaserCoolFactor;
        /* 0x105C */ public float LaserFireTime;
        /* 0x1060 */ public float LaserWaitTime;
        /* 0x1064 */ public float ProjectileOverheatTime;
        /* 0x1068 */ public float ProjectileFireRate;
        /* 0x106C */ public float ProjectileReloadTime;
        /* 0x1070 */ public int ProjectileClipSize;
        /* 0x1074 */ public float SummonShipAnywhereHeightOffset;
        /* 0x1078 */ public float SummonShipAnywhereFwdOffset;
        /* 0x107C */ public float SummonShipAnywhereRangeMax;
        /* 0x1080 */ public float SummonShipAnywhereRangeMin;
        /* 0x1084 */ public float SummonShipHeightOffset;
        /* 0x1088 */ public float SummonShipApproachOffset;
        /* 0x108C */ public float LandingHelperMinAngle;
        /* 0x1090 */ public float LandingHelperTurnTime;
        /* 0x1094 */ public float LandingHelperRollTime;
        /* 0x1098 */ public float AnomalyStationMaxApproachSpeed;
        /* 0x109C */ public float TakeOffSphereCastLength;
        /* 0x10A0 */ public float TakeOffSphereCastRadiusMul;
        /* 0x10A4 */ public float LandGroundTakeOffTime;
        /* 0x10A8 */ public float LandLookingForward;
        /* 0x10AC */ public float LandHeightThreshold;
        /* 0x10B0 */ public float LandWidthThreshold;
        /* 0x10B4 */ public float LandSlopeMax;
        /* 0x10B8 */ public float LandingAreaRadius;
        /* 0x10BC */ public float LandingAreaFloorOffset;
        /* 0x10C0 */ public float TargetLockTime;
        /* 0x10C4 */ public float TargetLockChangeTime;
        /* 0x10C8 */ public float TargetLockLoseTime;
        /* 0x10CC */ public float BoostChargeRate;
        /* 0x10D0 */ public float DamageMinHitTime;
        /* 0x10D4 */ public float DamageMaxHitTime;
        /* 0x10D8 */ public float DamageMinWoundTime;
        /* 0x10DC */ public float SpaceBrakeMinAngularSpeed;
        /* 0x10E0 */ public float SpaceBrakeAngularRange;
        /* 0x10E4 */ public float CollisionSpeedDamageAmount;
        /* 0x10E8 */ public float CollisionDeflectTime;
        /* 0x10EC */ public float CollisionDeflectDamping;
        /* 0x10F0 */ public float CollisionDeflectNormalFactor;
        /* 0x10F4 */ public float CollisionAsteroidDamp;
        /* 0x10F8 */ public float CollisionGroundDamp;
        /* 0x10FC */ public float CollisionDistance;
        /* 0x1100 */ public float CollisionDistanceGround;
        /* 0x1104 */ public float CollisionDistanceAsteroid;
        /* 0x1108 */ public float CollisionDistanceAsteroidSide;
        /* 0x110C */ public float CollisionDistanceSpaceships;
        /* 0x1110 */ public float DeflectDistance;
        /* 0x1114 */ public float DeflectAlignTimeMin;
        /* 0x1118 */ public float DeflectAlignTimeMax;
        /* 0x111C */ public TkCurveType DeflectCurve;
        /* 0x1120 */ public float CollisionRadiusMultiplier;
        /* 0x1124 */ public float GroundHeightHardTimeMin;
        /* 0x1128 */ public float GroundHeightHardTimeMax;
        /* 0x112C */ public float GroundHeightPostCollisionDamper;
        /* 0x1130 */ public float GroundHeightSpeedLength;
        /* 0x1134 */ public float GroundHeightSpeedAngle;
        /* 0x1138 */ public float GroundHeightSpeedAngleRange;
        /* 0x113C */ public int GroundHeightNumRays;
        /* 0x1140 */ public float GroundHeightSmoothTime;
        /* 0x1144 */ public float LinearDamping;
        /* 0x1148 */ public float AngularDamping;
        /* 0x114C */ public float DirectionDockingAngle;
        /* 0x1150 */ public float DirectionDockTime;
        /* 0x1154 */ public float DirectionDockingInfoRange;
        /* 0x1158 */ public float LootAttractDistance;
        /* 0x115C */ public float LootAttractTime;
        /* 0x1160 */ public float LootDampForce;
        /* 0x1164 */ public float LootCollectDistance;
        /* 0x1168 */ public float GunOffset3rdPersonMultiplier;
        /* 0x1170 */ public Vector3f GunOffsetLeft;
        /* 0x1180 */ public Vector3f GunOffsetRight;
        /* 0x1190 */ public Vector3f GunOffsetLeft2;
        /* 0x11A0 */ public Vector3f GunOffsetRight2;
        /* 0x11B0 */ public Vector3f GunOffset3rdPersonLeft;
        /* 0x11C0 */ public Vector3f GunOffset3rdPersonRight;
        /* 0x11D0 */ public GcPlayerSpaceshipWarpData Warp;
        /* 0x11E4 */ public float DockingRotateSpeed;
        /* 0x11E8 */ public float DockingRotateSpeedVR;
        /* 0x11EC */ public float EjectAnimSwitchPoint;
        /* 0x11F0 */ public float EjectAnimSpeedFactor;
        /* 0x11F4 */ public float ShipDifferentRepelRange;
        /* 0x11F8 */ public float ShipDifferentRepelAmount;
        /* 0x11FC */ public float AtmosphereSpeed;
        /* 0x1200 */ public float AtmosphereAngle;
        /* 0x1204 */ public float DroneAlignUpTime;
        /* 0x1208 */ public float DroneDustHeight;
        /* 0x120C */ public float DroneMinHeight;
        /* 0x1210 */ public float DroneHeightAdjust;
        /* 0x1214 */ public float FreighterSpeed;
        /* 0x1218 */ public float DroneWarpTime;
        /* 0x121C */ public float DroneWarpMinForce;
        /* 0x1220 */ public float DroneWarpMaxForce;
        /* 0x1230 */ public Vector3f CockpitScale;
        /* 0x1240 */ public float ShakePowerScaler;
        /* 0x1244 */ public float ShakeSpeed;
        /* 0x1248 */ public float ShakeMaxPower;
        /* 0x124C */ public float ShakeMaxSpeed;
        /* 0x1250 */ public float ShakeAlignBrake;
        /* 0x1254 */ public float WingmanAtTimeStart;
        /* 0x1258 */ public float WingmanAtTime;
        /* 0x125C */ public float WingmanAtTimeBack;
        /* 0x1260 */ public float WingmanPerpTime;
        /* 0x1264 */ public float WingmanAttackOffset;
        /* 0x1268 */ public float WingmanAttackRange;
        /* 0x126C */ public float WingmanAttackMinRange;
        /* 0x1270 */ public float WingmanAttackAngle;
        /* 0x1274 */ public float WingmanViewerAngle;
        /* 0x1278 */ public float WingmanAttackAimAngle;
        /* 0x127C */ public float WingmanAttackTime;
        /* 0x1280 */ public float WingmanAttackTimeout;
        /* 0x1284 */ public float WingmanAttackCoolTime;
        /* 0x1288 */ public float WingmanSpawnDist;
        /* 0x128C */ public float WingmanAlign;
        /* 0x1290 */ public float WingmanAngle;
        /* 0x1294 */ public float WingmanAngle2;
        /* 0x1298 */ public float WingmanRadius;
        /* 0x129C */ public float WingmanFwd1;
        /* 0x12A0 */ public float WingmanFwd2;
        /* 0x12A4 */ public float DronePlanetAttackRange;
        /* 0x12A8 */ public float DronePlanetAttackMinRange;
        /* 0x12AC */ public float DroneShootTime;
        /* 0x12B0 */ public float DroneAlertAngle;
        /* 0x12B4 */ public float DroneAlertRange;
        /* 0x12B8 */ public float DronePatrolRadius;
        /* 0x12BC */ public float DroneMoveArrivedRange;
        /* 0x12C0 */ public float DronePatrolTime;
        /* 0x12C4 */ public float ShipEnterRange;
        /* 0x12C8 */ public float ShipEnterAngle;
        /* 0x12CC */ public float ShipEnterTransitionTime;
        /* 0x12D0 */ public float ShipEnterSpeed;
        /* 0x12D4 */ public float ShipEnterMinTime;
        /* 0x12D8 */ public List<NMSString0x80> ShipModels;
        /* 0x12E8 */ public float HUDBoostUpgradeMultiplier;
        /* 0x12EC */ public float LaunchThrustersRegenTimePeriod;
        /* 0x12F0 */ public float LaunchThrustersMinimumSummonPercentage;
        /* 0x12F4 */ public float LaunchThrustersSummonCostMultiplier;
        /* 0x12F8 */ public float SpeedUpDistanceThreshold;
        /* 0x12FC */ public float SpeedUpDistanceFadeThreshold;
        /* 0x1300 */ public float SpeedUpVelocityThreshold;
        /* 0x1304 */ public float SpeedUpVelocityCoeff;
        /* 0x1308 */ public float MaxSpeedUpDistance;
        /* 0x130C */ public float MaxSpeedUpVelocity;
        /* 0x1310 */ public float StickLandThreshold;
        /* 0x1314 */ public float StickPulseThreshold;
        /* 0x1320 */ public Vector3f StickAnimationDamping;
        /* 0x1330 */ public float SpaceCombatFollowModeMaxTorque;
        /* 0x1334 */ public float SpaceCombatFollowModeAimTime;
        /* 0x1338 */ public float SpaceCombatFollowModeTargetDistance;
        /* 0x133C */ public float SpaceCombatFollowModeEvadeRoll;
        /* 0x1340 */ public float SpaceCombatFollowModeEvadeTime;
        /* 0x1344 */ public float SpaceCombatFollowModeBrakeBehindAngle;
        /* 0x1348 */ public float SpaceCombatFollowModeMaxBrakeBehind;
        /* 0x134C */ public float SpaceCombatFollowModeMaxBrakeHeadOn;
        /* 0x1350 */ public float SpaceCombatFollowModeEvadeThrust;
        /* 0x1354 */ public bool SpaceCombatFollowModeUseEvadeTarget;
        /* 0x1355 */ public bool SpaceCombatFollowModeUseBoost;
    }
}
