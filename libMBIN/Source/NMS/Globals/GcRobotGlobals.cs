using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF1B39D1BDAB103BA, NameHash = 0xDD7401143C40F868)]
    public class GcRobotGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool ForceShowDebugMoveTrail;
        /* 0x0008 */ public NMSString0x10 ForceDroneWeapon;
        /* 0x0018 */ public float GrenadeLaunchFlightTime;
        /* 0x001C */ public int AttackSentinelWantedValue;
        /* 0x0020 */ public int MaxNumPatrolDrones;
        /* 0x0024 */ public float UnderwaterPerceptionMargin;
        /* 0x0028 */ public bool DronePatrolScanPlayer;
        /* 0x002C */ public float DroneSearchPickNearbyTime;
        /* 0x0030 */ public float DroneSearchPickNearbyAngleMin;
        /* 0x0034 */ public float DroneSearchPickNearbyAngleMax;
        /* 0x0038 */ public float DroneInvestigateMinWitnessRange;
        /* 0x003C */ public float DroneInvestigateMinWitnessRangeCantSee;
        /* 0x0040 */ public float DroneInvestigateMinChaseRange;
        /* 0x0044 */ public float DroneInvestigateMinWitnessTime;
        /* 0x0048 */ public float DroneInvestigateSpeedBoost;
        /* 0x004C */ public float DroneInvestigateSpeedBoostStartDistance;
        /* 0x0050 */ public float DroneInvestigateSpeedBoostRange;
        /* 0x0054 */ public float DroneCrimePostInvestigateWaitTime;
        /* 0x0058 */ public float EncounterRangeToBlockWantedSpawns;
        /* 0x005C */ public float EncounterRangeToAllowPulledIntoFight;
        /* 0x0060 */ public bool DroneEnableVariableUpdate;
        /* 0x0064 */ public float DroneUpdateFPSMax;
        /* 0x0068 */ public float DroneUpdateFPSMin;
        /* 0x006C */ public float DroneUpdateDistForMax;
        /* 0x0070 */ public float DroneUpdateDistForMin;
        /* 0x0074 */ public float DroneAttackPlayerHeightOffset;
        /* 0x0078 */ public float DroneAttackMaxAngleDownFromPlayer;
        /* 0x007C */ public float DroneSpawnTime;
        /* 0x0080 */ public float DroneSpawnFadeTime;
        /* 0x0084 */ public float LineOfSightReturnCheckMinDistance;
        /* 0x0088 */ public float LineOfSightReturnCheckRadius;
        /* 0x008C */ public float LineOfSightReturnRange;
        /* 0x0090 */ public float FakeQuadGuard;
        /* 0x0094 */ public float RobotSightAngle;
        /* 0x0098 */ public float FriendlyDroneChatCooldown;
        /* 0x009C */ public float FriendlyDroneDissolveTime;
        /* 0x00A0 */ public float FriendlyDroneChatChanceSummoned;
        /* 0x00A4 */ public float FriendlyDroneChatChanceUnsummoned;
        /* 0x00A8 */ public float FriendlyDroneChatChanceBecomeWanted;
        /* 0x00AC */ public float FriendlyDroneChatChanceLoseWanted;
        /* 0x00B0 */ public float FriendlyDroneChatChanceIdle;
        /* 0x00B4 */ public float FriendlyDroneBeepReplaceChatChance;
        /* 0x00C0 */ public Vector3f DroneRepairOffset;
        /* 0x00D0 */ public float QuadLookAngleMin;
        /* 0x00D4 */ public float QuadLookAngleMax;
        /* 0x00D8 */ public Vector2f QuadLookTurnSpeeds;
        /* 0x00E0 */ public float QuadAttackTurnAngleMin;
        /* 0x00E4 */ public float QuadAttackTurnAngleMax;
        /* 0x00E8 */ public Vector2f QuadAttackTurnSpeeds;
        /* 0x00F0 */ public int DroneAggroDamage;
        /* 0x00F4 */ public float CombatWaveSpawnTime;
        /* 0x00F8 */ public float DronePerceptionMinHearingSpeed;
        /* 0x00FC */ public float DroneSearchLookSpeed;
        /* 0x0100 */ public float DroneSearchLookDistance;
        /* 0x0104 */ public float DroneCrimeWitnessInvestigateDistance;
        /* 0x0108 */ public bool DroneChatter;
        /* 0x010C */ public float WalkerEnergyLength;
        /* 0x0110 */ public float WalkerEnergySpeedMin;
        /* 0x0114 */ public float WalkerEnergySpeedMax;
        /* 0x0118 */ public float WalkerEnergyRadiusStartMin;
        /* 0x011C */ public float WalkerEnergyRadiusStartMax;
        /* 0x0120 */ public float WalkerEnergyMinAlpha;
        /* 0x0124 */ public float WalkerEnergyMaxAlpha;
        /* 0x0128 */ public float CriticalHitSizeDrone;
        /* 0x012C */ public float CriticalHitSizeQuad;
        /* 0x0130 */ public float CriticalHitSizeMech;
        /* 0x0134 */ public float CriticalHitSizeWalker;
        /* 0x0138 */ public float LabelOffsetDrone;
        /* 0x013C */ public float LabelOffsetQuad;
        /* 0x0140 */ public float LabelOffsetMech;
        /* 0x0144 */ public float LabelOffsetWalker;
        /* 0x0150 */ public Vector3f QuadCriticalOffset;
        /* 0x0160 */ public Vector3f DroneCriticalOffset;
        /* 0x0170 */ public Vector3f WalkerGunOffset1;
        /* 0x0180 */ public Vector3f WalkerGunOffset2;
        /* 0x0190 */ public float RobotSteeringFollowWeight;
        /* 0x0194 */ public float RobotSteeringAvoidTurnWeight;
        /* 0x0198 */ public float RobotSteeringAvoidCreaturesWeight;
        /* 0x019C */ public float RobotSteeringAvoidDangerWeight;
        /* 0x01A0 */ public GcScanData AttackScan;
        /* 0x01B4 */ public float RobotHUDMarkerRange;
        /* 0x01B8 */ public float RobotHUDMarkerFalloff;
        /* 0x01BC */ public float DroneMoveDistancePlayerMechMultiplier;
        /* 0x01C0 */ public float DroneSquadSpawnRadius;
        /* 0x01C4 */ public float DroneSpawnHeight;
        /* 0x01C8 */ public float DroneScale;
        /* 0x01CC */ public float TrackArrowOffsetMultiplier;
        /* 0x01D0 */ public float DroneCombatSpawnAngle;
        /* 0x01D4 */ public float CombatSpawnSquadRadiusDrones;
        /* 0x01D8 */ public float CombatSpawnSquadRadiusRobots;
        /* 0x01DC */ public float RobotMapScale;
        /* 0x01E0 */ public float WalkerLaserOvershootVehicleReducer;
        /* 0x01E4 */ public bool DronesUseEscalationTimer;
        /* 0x01E5 */ public bool DisableDronePerception;
        /* 0x01E8 */ public float DroneHeightAngle;
        /* 0x01EC */ public float DroneAttackGetInRangeBoost;
        /* 0x01F0 */ public float DroneAggressiveInvestigateAttackTime;
        /* 0x01F4 */ public float DronePushLaserForce;
        /* 0x01F8 */ public float DronePushMaxSpeed;
        /* 0x01FC */ public float DronePushMaxTurn;
        /* 0x0200 */ public float DroneCriminalScanTime;
        /* 0x0204 */ public bool DroneClickToMove;
        /* 0x0208 */ public float DroneInvestigateMinScanTime;
        /* 0x020C */ public float MedicDroneMinHealTime;
        /* 0x0210 */ public GcScanEffectData DroneScanEffect;
        // size: 0x9
        public enum SentinelSpawnLimitsEnum {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            Mech,
            Walker,
            FriendlyDrone
        }
        [NMS(Size = 0x9, EnumType = typeof(SentinelSpawnLimitsEnum))]
        /* 0x0260 */ public int[] SentinelSpawnLimits;
        // size: 0x9
        public enum SentinelResourcesEnum {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            Mech,
            Walker,
            FriendlyDrone
        }
        [NMS(Size = 0x9, EnumType = typeof(SentinelResourcesEnum))]
        /* 0x0284 */ public GcSentinelResource[] SentinelResources;
        /* 0x0794 */ public float HeightTestSampleDistance;
        /* 0x0798 */ public float HeightTestSampleTime;
        /* 0x079C */ public float CollisionDistance;
        /* 0x07A0 */ public float RobotSightTimer;
        /* 0x07A4 */ public bool DroneHitImpulseEnabled;
        /* 0x07A8 */ public float DroneHitImpulseFlipForceDownBound;
        /* 0x07AC */ public float DroneHitImpulseMinVerticalComponentScale;
        /* 0x07B0 */ public float DroneHitImpulseMultiplier;
        /* 0x07B4 */ public float DroneHitImpulseLaserMultiplier;
        /* 0x07B8 */ public float DroneHitImpulseCooldown;
        /* 0x07BC */ public float DroneReAttackTime;
        /* 0x07C0 */ public float DronePatrolAttackSightTime;
        /* 0x07C4 */ public float DronePatrolInvestigateSpeedBoost;
        /* 0x07C8 */ public float DronePatrolSearchTime;
        /* 0x07CC */ public int MaxNumInvestigatingDrones;
        /* 0x07D0 */ public float DroneCrimeCooldown;
        /* 0x07D4 */ public float DroneCrimeCooldownWaitTime;
        /* 0x07D8 */ public float DroneCrimeCooldownWaitTimeAtMax;
        /* 0x07DC */ public float DroneRadius;
        /* 0x07E0 */ public float DroneMaxScanLength;
        /* 0x07E4 */ public float DroneDecisionTime;
        /* 0x07E8 */ public float DroneInvestigateMinPositionAngle;
        /* 0x07EC */ public float DroneInvestigateMaxPositionAngle;
        /* 0x07F0 */ public float DroneInvestigateRepositionTime;
        /* 0x07F4 */ public float DroneInvestigateMinCrimeInterval;
        /* 0x07F8 */ public float DroneScanRadius;
        /* 0x07FC */ public float DroneMaxScanAngle;
        /* 0x0800 */ public float DroneScanWaitTime;
        /* 0x0804 */ public float DroneScanMinPerpSpeed;
        /* 0x0808 */ public float EnergyExplodeTime;
        /* 0x080C */ public float FollowRoutineArriveRadius;
        /* 0x0810 */ public float RepairCheckForTargetCooldownTime;
        /* 0x0814 */ public float RepairOffsetChangeTime;
        /* 0x0818 */ public float RepairOffset;
        /* 0x081C */ public float RepairScanArriveDistance;
        /* 0x0820 */ public float RepairRate;
        /* 0x0824 */ public float RepairScanRadius;
        /* 0x0828 */ public float RepairChargeTime;
        /* 0x0830 */ public NMSString0x10 RepairEffect;
        /* 0x0840 */ public float RepairEffectScaleDrone;
        /* 0x0844 */ public float RepairEffectScaleQuad;
        /* 0x0848 */ public float MechFadeInTime;
        /* 0x084C */ public float MechFadeOutTime;
        /* 0x0850 */ public float MechFadeInDistance;
        /* 0x0854 */ public float ExoMechJumpCooldownTimeInCombat;
        /* 0x0858 */ public float ExoMechJumpCooldownTimeOutOfCombat;
        /* 0x085C */ public float SentinelMechJumpCooldownTimeInCombat;
        /* 0x0860 */ public float SentinelMechJumpCooldownTimeOutOfCombat;
        /* 0x0864 */ public float MechStartJumpMinDistanceInCombat;
        /* 0x0868 */ public float MechEndJumpMinDistanceInCombat;
        /* 0x086C */ public float MechStartJumpMinDistanceOutOfCombat;
        /* 0x0870 */ public float MechEndJumpMinDistanceOutOfCombat;
        /* 0x0874 */ public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings;
        /* 0x08A4 */ public float MechMinMaintainTargetTime;
        /* 0x08A8 */ public float MechMinMaintainFireTargetTime;
        /* 0x08AC */ public float MechAttackRate;
        /* 0x08B0 */ public float MechMinTurretAngle;
        /* 0x08B4 */ public float MechAttackMoveMinOffsetRotation;
        /* 0x08B8 */ public float MechAttackMoveMaxOffsetRotation;
        /* 0x08BC */ public float MechAttackMoveHoldPositionTime;
        /* 0x08C0 */ public float MechAttackMoveAngleToleranceDeg;
        /* 0x08C4 */ public float MechAttackMoveFacingAngleTolerance;
        /* 0x08C8 */ public float MechAlertRange;
        /* 0x08CC */ public float MechAttackRange;
        /* 0x08D0 */ public float MechSightRange;
        /* 0x08D4 */ public float MechSightAngle;
        /* 0x08D8 */ public float MechHearingRange;
        /* 0x08DC */ public float MechPatrolRadius;
        /* 0x08E0 */ public Vector2f MechPatrolPauseTime;
        // size: 0x3
        public enum SentinelMechWeaponDataEnum {
            Gun,
            Canon,
            Flamethrower
        }
        [NMS(Size = 0x3, EnumType = typeof(SentinelMechWeaponDataEnum))]
        /* 0x08E8 */ public GcSentinelMechWeaponData[] SentinelMechWeaponData;
        /* 0x0A68 */ public float WalkerPauseTime;
        /* 0x0A6C */ public float WalkerAttackRange;
        /* 0x0A70 */ public float WalkerGuardAlertRange;
        /* 0x0A74 */ public float WalkerClosingRange;
        /* 0x0A78 */ public float WalkerAttackRate;
        /* 0x0A7C */ public float WalkerAttackAngle;
        /* 0x0A80 */ public float WalkerMoveSpeed;
        /* 0x0A84 */ public float WalkerFastMoveFactor;
        /* 0x0A88 */ public float WalkerHeight;
        /* 0x0A8C */ public float WalkerNavRadius;
        /* 0x0A90 */ public float WalkerPushTime;
        /* 0x0A94 */ public float WalkerPushRadius;
        /* 0x0A98 */ public float WalkerLaserOvershootStart;
        /* 0x0A9C */ public float WalkerLaserOvershootEnd;
        /* 0x0AA0 */ public float WalkerLaserBodyOffset;
        /* 0x0AA4 */ public float WalkerObstacleSize;
        /* 0x0AA8 */ public float WalkerGunShootTime;
        /* 0x0AAC */ public float WalkerGunChargeTime;
        /* 0x0AB0 */ public float WalkerGunRate;
        /* 0x0AB4 */ public float WalkerTitanFallHeight;
        /* 0x0AB8 */ public float WalkerTitanFallSpeed;
        /* 0x0AC0 */ public NMSString0x10 WalkerTitanFallEffect;
        /* 0x0AD0 */ public float WalkerTitanFallEffectScale;
        /* 0x0AD8 */ public NMSString0x10 WalkerTitanFallShake;
        /* 0x0AE8 */ public List<NMSString0x20> WalkerLeftLegArmourNodes;
        /* 0x0AF8 */ public List<NMSString0x20> WalkerRightLegArmourNodes;
        /* 0x0B08 */ public bool WalkerLegShotDefendEnabled;
        /* 0x0B0C */ public float WalkerLegShotDefendTime;
        /* 0x0B10 */ public bool WalkerLegShotEnrageEnabled;
        /* 0x0B14 */ public float WalkerLegShotEnrageShotInterval;
        /* 0x0B18 */ public int WalkerLegShotEnrageShotsPerVolley;
        /* 0x0B1C */ public float WalkerLegShotEnrageVolleyInterval;
        /* 0x0B20 */ public float WalkerLegShotEnrageShotSpreadMin;
        /* 0x0B24 */ public float WalkerLegShotEnrageShotSpreadMax;
        /* 0x0B28 */ public float WalkerHeadMoveTimeIdle;
        /* 0x0B2C */ public float WalkerHeadMoveTimeActive;
        /* 0x0B30 */ public float WalkerHeadMaxYaw;
        /* 0x0B34 */ public float WalkerHeadMaxPitch;
        /* 0x0B40 */ public Vector3f WalkerHeadEyeOffset;
        /* 0x0B50 */ public float QuadAlertRange;
        /* 0x0B54 */ public float QuadAttackRange;
        /* 0x0B58 */ public float QuadAttackMinRange;
        /* 0x0B5C */ public float QuadAttackAngle;
        /* 0x0B60 */ public float QuadAttackRepositionTime;
        /* 0x0B64 */ public float QuadJumpBackRange;
        /* 0x0B68 */ public float QuadJumpBackCheckRange;
        /* 0x0B6C */ public float QuadJumpBackHeightRange;
        /* 0x0B70 */ public float QuadJumpBackJumpDistance;
        /* 0x0B74 */ public float QuadJumpBackJumpMinLength;
        /* 0x0B78 */ public float QuadJumpBackDoFlipDistance;
        /* 0x0B7C */ public float QuadJumpBackMinTime;
        /* 0x0B80 */ public float QuadJumpBackFacingAngle;
        /* 0x0B84 */ public float QuadJumpBackTestRadius;
        /* 0x0B88 */ public float QuadJumpBackTestHeightOffset;
        /* 0x0B8C */ public float QuadPounceRange;
        /* 0x0B90 */ public float QuadPounceMinRange;
        /* 0x0B94 */ public float QuadPounceMinTimeBetweenPounces;
        /* 0x0B98 */ public float QuadPounceTimeFireRateScoreExtra;
        /* 0x0B9C */ public float QuadPounceMinFireRateScore;
        /* 0x0BA0 */ public float QuadPounceMaxFireRateScore;
        /* 0x0BA4 */ public float QuadPounceOffset;
        /* 0x0BA8 */ public float QuadPounceDamageRadius;
        /* 0x0BAC */ public float QuadCannotSeeTargetRepositionTime;
        /* 0x0BB0 */ public float QuadChargeTime;
        /* 0x0BB4 */ public float QuadFireTime;
        /* 0x0BB8 */ public float QuadChargeTargetLockPercent;
        /* 0x0BBC */ public float QuadHopMinTime;
        /* 0x0BC0 */ public float QuadHopCombatMinTime;
        /* 0x0BC4 */ public int QuadDamageMoveThreshold;
        /* 0x0BC8 */ public float QuadAttackRate;
        /* 0x0BCC */ public float QuadMoveSpeed;
        /* 0x0BD0 */ public float QuadLaserSpringMin;
        /* 0x0BD4 */ public float QuadLaserSpringMax;
        /* 0x0BD8 */ public float QuadLaserIntensity;
        /* 0x0BDC */ public float QuadFastMoveFactor;
        /* 0x0BE0 */ public float QuadTurnBlendTime;
        /* 0x0BE4 */ public float QuadHeight;
        /* 0x0BE8 */ public float QuadNavRadius;
        /* 0x0BEC */ public float QuadObstacleSize;
        /* 0x0BF0 */ public float QuadPatrolRadius;
        /* 0x0BF4 */ public Vector2f QuadPatrolPauseTime;
        /* 0x0BFC */ public float QuadHearingRange;
        /* 0x0C00 */ public float QuadSightRange;
        /* 0x0C04 */ public float QuadSightAngle;
        /* 0x0C08 */ public float DronePerceptionRange;
        /* 0x0C0C */ public float DronePerceptionRangeHostile;
        /* 0x0C10 */ public float DronePerceptionSightRange;
        /* 0x0C14 */ public float DronePerceptionSightRangeHostile;
        /* 0x0C18 */ public float DronePerceptionSightAngle;
        /* 0x0C1C */ public bool SpawnFriendlyDrone;
        /* 0x0C20 */ public float AttackMoveMaxTime;
        /* 0x0C24 */ public float AttackMoveArrivalDistance;
        /* 0x0C28 */ public float LaserFadeTime;
        /* 0x0C2C */ public float LaserFadeTime2;
        /* 0x0C30 */ public int SummonerDroneResummonThreshold;
        /* 0x0C34 */ public float SummonerDroneCooldownOffset;
        /* 0x0C38 */ public float SummonerDroneCooldown;
        /* 0x0C3C */ public float SummonerDroneBeginTime;
        /* 0x0C40 */ public float SummonerDroneBuildupTime;
        /* 0x0C48 */ public NMSString0x10 SummonerDroneBuildupEffect;
        /* 0x0C58 */ public NMSString0x10 SummonerDroneSpawnEffect;
        /* 0x0C68 */ public float SummonRadius;
        /* 0x0C6C */ public float SummonVerticalOffset;
        /* 0x0C70 */ public float SummonPreviewInterpSpeedMin;
        /* 0x0C74 */ public float SummonPreviewInterpSpeedMax;
        /* 0x0C78 */ public bool SummonerTestSummonEffects;
        /* 0x0C7C */ public float FireRateLastHitBypassTime;
        /* 0x0C80 */ public float FireRateModifierMin;
        /* 0x0C84 */ public float FireRateModifierMax;
        /* 0x0C88 */ public int ScoreForMinFireRateModifier;
        /* 0x0C8C */ public int ScoreForMaxFireRateModifier;
        // size: 0x9
        public enum FireRateModifierScoresEnum {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            Mech,
            Walker,
            FriendlyDrone
        }
        [NMS(Size = 0x9, EnumType = typeof(FireRateModifierScoresEnum))]
        /* 0x0C90 */ public float[] FireRateModifierScores;
        /* 0x0CC0 */ public GcRobotLaserData WalkerLaser;
        /* 0x0D10 */ public GcRobotLaserData QuadLaser;
        /* 0x0D60 */ public GcDroneData DroneControl;
        /* 0x1100 */ public List<GcDroneWeaponData> DroneWeapons;
    }
}
