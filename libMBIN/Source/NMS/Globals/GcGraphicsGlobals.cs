using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x5EF103312E583027, NameHash = 0xB24409E83457E875)]
    public class GcGraphicsGlobals : NMSTemplate
    {
        /* 0x000 */ public float LUTDistanceFlightMultiplier;
        /* 0x004 */ public float SunLightIntensity;
        /* 0x008 */ public float SunLightBlendTime;
        /* 0x00C */ public float HBAOBias;
        /* 0x010 */ public float HBAORadius;
        /* 0x014 */ public float HBAOIntensity;
        /* 0x020 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x050 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x080 */ public float SunRayDensity;
        /* 0x084 */ public float SunRayDecay;
        /* 0x088 */ public float SunRayExposure;
        /* 0x08C */ public float SunRayWeight;
        /* 0x090 */ public float Brightness;
        /* 0x094 */ public float Contrast;
        /* 0x098 */ public float Saturation;
        /* 0x09C */ public bool Redo_On;
        /* 0x0A0 */ public float Redo_LightIntensity;
        /* 0x0A4 */ public float Redo_SkyIntensity;
        /* 0x0A8 */ public float Redo_BounceIntensity;
        /* 0x0AC */ public float New_BounceLightWarp;
        /* 0x0B0 */ public float New_BounceLightPower;
        /* 0x0B4 */ public float New_BounceLightIntensity;
        /* 0x0B8 */ public float New_SkyLightWarp;
        /* 0x0BC */ public float New_SkyLightPower;
        /* 0x0C0 */ public float New_SkyLightIntensity;
        /* 0x0C4 */ public float New_SideRimWarp;
        /* 0x0C8 */ public float New_SideRimColourMixer;
        /* 0x0CC */ public float New_TopRimWarp;
        /* 0x0D0 */ public float New_TopRimColourMixer;
        /* 0x0D4 */ public float New_TopRimPower;
        /* 0x0D8 */ public float New_TopRimIntensity;
        /* 0x0DC */ public float Old_BounceLightWarp;
        /* 0x0E0 */ public float Old_BounceLightPower;
        /* 0x0E4 */ public float Old_BounceLightIntensity;
        /* 0x0E8 */ public float Old_SkyLightWarp;
        /* 0x0EC */ public float Old_SkyLightPower;
        /* 0x0F0 */ public float Old_SkyLightIntensity;
        /* 0x0F4 */ public float Old_SideRimWarp;
        /* 0x0F8 */ public float Old_SideRimColourMixer;
        /* 0x0FC */ public float Old_TopRimWarp;
        /* 0x100 */ public float Old_TopRimColourMixer;
        /* 0x104 */ public float Old_TopRimPower;
        /* 0x108 */ public float Old_TopRimIntensity;
        /* 0x10C */ public float ModelRendererLightIntensity;
        /* 0x110 */ public float PetModelRendererLightIntensity;
        /* 0x114 */ public float ScanFresnel;
        /* 0x118 */ public float ScanClamp;
        /* 0x11C */ public float ScanAlpha;
        /* 0x120 */ public Colour ScanColour;
        /* 0x130 */ public bool DebugLinesDepthTest;
        /* 0x131 */ public bool CenterRenderSpaceOffset;
        /* 0x140 */ public TkImGuiSettings ImGui;
        /* 0x2D0 */ public Colour UIColour;
        /* 0x2E0 */ public Colour UIShipColour;
        /* 0x2F0 */ public float HUDMotionXSpring;
        /* 0x2F4 */ public float HUDMotionYSpring;
        /* 0x2F8 */ public float HUDMotionPosSpring;
        /* 0x2FC */ public float HUDMotionX;
        /* 0x300 */ public float HUDMotionY;
        /* 0x304 */ public float HUDMotionPos;
        /* 0x308 */ public float HUDDistance;
        /* 0x30C */ public float NearClipDistance;
        /* 0x310 */ public float FarClipDistance;
        /* 0x314 */ public float WarpK;
        /* 0x318 */ public float WarpKCube;
        /* 0x31C */ public float WarpScale;
        /* 0x320 */ public float WarpKDispersion;
        /* 0x324 */ public int ShadowMapSize;
        /* 0x328 */ public float DirectionLightRadius;
        /* 0x32C */ public float DirectionLightFOV;
        /* 0x330 */ public float DirectionLightShadowBias;
        /* 0x334 */ public float ShadowLength;
        /* 0x338 */ public float ShadowLengthShip;
        /* 0x33C */ public float ShadowLengthSpace;
        /* 0x340 */ public float ShadowLengthStation;
        /* 0x344 */ public float ShadowLengthFreighter;
        /* 0x348 */ public float ShadowLengthFreighterAbandoned;
        /* 0x34C */ public float ShadowLengthCameraView;
        /* 0x350 */ public Vector4f ShadowSplit;
        /* 0x360 */ public Vector4f ShadowSplitShip;
        /* 0x370 */ public Vector4f ShadowSplitSpace;
        /* 0x380 */ public Vector4f ShadowSplitStation;
        /* 0x390 */ public Vector4f ShadowSplitCameraView;
        /* 0x3A0 */ public Vector4f ShadowBias;
        /* 0x3B0 */ public bool ShadowQuantized;
        /* 0x3B4 */ public float ShadowBillboardOffset;
        /* 0x3B8 */ public float QuantizeTime;
        /* 0x3BC */ public float QuantizeTimeShip;
        /* 0x3C0 */ public float QuantizeTimeSpace;
        /* 0x3C4 */ public float QuantizeTimeCameraView;
        /* 0x3C8 */ public float ToneMapExposure;
        /* 0x3CC */ public float HDRExposure;
        /* 0x3D0 */ public float HDRGamma;
        /* 0x3D4 */ public float HDRLutExposure;
        /* 0x3D8 */ public float HDRLutGamma;
        /* 0x3DC */ public float HDRLutToe;
        /* 0x3E0 */ public float HDRThreshold;
        /* 0x3E4 */ public float HDROffset;
        /* 0x3E8 */ public float LensThreshold;
        /* 0x3EC */ public float LensOffset;
        /* 0x3F0 */ public float LensScale;
        /* 0x3F4 */ public float LensDirt;
        /* 0x3F8 */ public float ToneMapExposureCave;
        /* 0x3FC */ public float HDRExposureCave;
        /* 0x400 */ public float HDRThresholdCave;
        /* 0x404 */ public float HDROffsetCave;
        /* 0x408 */ public float LensThresholdCave;
        /* 0x40C */ public float LensOffsetCave;
        /* 0x410 */ public float LensScaleCave;
        /* 0x414 */ public float LensDirtCave;
        /* 0x418 */ public float DOFNearPlane;
        /* 0x41C */ public float DOFFarPlane;
        /* 0x420 */ public float DOFAmountManual;
        /* 0x424 */ public float DOFAmountManualLightIndoor;
        /* 0x428 */ public float DOFAmountManualFullIndoor;
        /* 0x42C */ public float DOFAmountManualLight;
        /* 0x430 */ public float DOFAmountManualFull;
        /* 0x434 */ public float DOFNearFadeDistance;
        /* 0x438 */ public float DOFNearFadeDistanceManual;
        /* 0x43C */ public float DOFFarFadeDistance;
        /* 0x440 */ public float DOFFarPlaneCave;
        /* 0x444 */ public float DOFFarFadeDistanceCave;
        /* 0x448 */ public float DOFFarPlaneSpace;
        /* 0x44C */ public float DOFFarFadeDistanceSpace;
        /* 0x450 */ public float DOFFarStrengthWater;
        /* 0x454 */ public float DOFFarPlaneWater;
        /* 0x458 */ public float DOFFarFadeDistanceWater;
        /* 0x45C */ public float DOFFarPlaneManual;
        /* 0x460 */ public float DOFFarFadeDistanceManualIndoor;
        /* 0x464 */ public float DOFFarFadeDistanceManual;
        /* 0x468 */ public float DOFAutoFarAmount;
        /* 0x46C */ public float DOFAutoFarFarPlaneFade;
        /* 0x470 */ public float DOFAutoFarFarPlane;
        /* 0x474 */ public float DOFAutoFarNearPlane;
        /* 0x478 */ public float DOFNearMinInteraction;
        /* 0x47C */ public float DOFNearAdjustInteraction;
        /* 0x480 */ public float DOFFarPlaneInteraction;
        /* 0x484 */ public float DOFFarFadeDistanceInteraction;
        /* 0x488 */ public bool DOFEnableBokeh;
        /* 0x489 */ public bool DOFEnableNewBokehShader;
        /* 0x48A */ public bool DOFEnablePhysCamera;
        /* 0x48C */ public float VignetteStart;
        /* 0x490 */ public float VignetteEnd;
        /* 0x494 */ public float VignetteStartTurnVR;
        /* 0x498 */ public float VignetteEndTurnVR;
        /* 0x49C */ public float VignetteStartMoveVR;
        /* 0x4A0 */ public float VignetteEndMoveVR;
        /* 0x4A4 */ public float VignetteVRTurnInterpTime;
        /* 0x4A8 */ public float VignetteVRMoveInterpTime;
        /* 0x4AC */ public float VignetteStartMoveVRShip;
        /* 0x4B0 */ public float VignetteEndMoveVRShip;
        /* 0x4B4 */ public float VignetteVRMoveInterpTimeShip;
        /* 0x4B8 */ public float VignetteStartTurnVRShip;
        /* 0x4BC */ public float VignetteEndTurnVRShip;
        /* 0x4C0 */ public float VignetteVRTurnInterpTimeShip;
        /* 0x4C4 */ public float VignetteStartTurnRidingVR;
        /* 0x4C8 */ public float VignetteEndTurnRidingVR;
        /* 0x4CC */ public float VignetteVRTurnRidingInterpTime;
        /* 0x4D0 */ public float VignetteStartRidingVR;
        /* 0x4D4 */ public float VignetteEndRidingVR;
        /* 0x4D8 */ public float VignetteVRRidingInterpTime;
        /* 0x4DC */ public float LowHealthVignetteStart;
        /* 0x4E0 */ public float LowHealthVignetteEnd;
        /* 0x4E4 */ public float LowHealthDesaturationIntensityMin;
        /* 0x4E8 */ public float LowHealthDesaturationIntensityMax;
        /* 0x4EC */ public float LowHealthDesaturationIntensityTimeSinceHit;
        /* 0x4F0 */ public float LowHealthOverlayIntensity;
        /* 0x4F4 */ public float LowHealthFadeInTime;
        /* 0x4F8 */ public float LowHealthFadeOutTime;
        /* 0x4FC */ public float LowHealthPulseRateLowShield;
        /* 0x500 */ public float LowHealthPulseRateFullShield;
        /* 0x504 */ public float LowHealthStrengthLowShield;
        /* 0x508 */ public float LowHealthStrengthFullShield;
        /* 0x50C */ public float ShieldDownScanlineTime;
        /* 0x510 */ public bool FullscreenScanEffect;
        /* 0x511 */ public bool UseImposters;
        /* 0x520 */ public Vector4f MipLevelDebug;
        /* 0x530 */ public Vector4f LensParams;
        /* 0x540 */ public Colour VerticalColourTop;
        /* 0x550 */ public Colour VerticalColourBottom;
        /* 0x560 */ public Vector4f VerticalGradient;
        /* 0x570 */ public float ScanFadeInTime;
        /* 0x574 */ public float ScanFadeOutTime;
        /* 0x578 */ public float ScanEffectSpeed;
        /* 0x57C */ public float ScanObjectFade;
        /* 0x580 */ public float ScanBandWidth;
        /* 0x584 */ public float ScanHeightScale;
        /* 0x588 */ public float ScanDistance;
        /* 0x58C */ public float ScanHorizontalScale;
        /* 0x590 */ public float Single1ScanTime;
        /* 0x594 */ public float Single1ScanHeightScale;
        /* 0x598 */ public float Single1ScanBandWidth;
        /* 0x59C */ public float Single1ScanEffectSpeed;
        /* 0x5A0 */ public float Single1ScanObjectFade;
        /* 0x5A4 */ public float Single1ScanHorizontalScale;
        /* 0x5A8 */ public float Single2ScanTime;
        /* 0x5AC */ public float Single2ScanHeightScale;
        /* 0x5B0 */ public float Single2ScanBandWidth;
        /* 0x5B4 */ public float Single2ScanEffectSpeed;
        /* 0x5B8 */ public float Single2ScanObjectFade;
        /* 0x5BC */ public float Single2ScanHorizontalScale;
        /* 0x5C0 */ public float TeleportFlashTime;
        /* 0x5C4 */ public Vector2f WindDir1;
        /* 0x5CC */ public Vector2f WindDir2;
        /* 0x5D4 */ public float AtmosphereSize;
        /* 0x5D8 */ public float RingSize;
        /* 0x5DC */ public float RingRadius;
        /* 0x5E0 */ public float HueVariance;
        /* 0x5E4 */ public float SaturationVariance;
        /* 0x5E8 */ public float ValueVariance;
        /* 0x5EC */ public float FoliageSaturationMin;
        /* 0x5F0 */ public float FoliageSaturationMax;
        /* 0x5F4 */ public float FoliageValueMin;
        /* 0x5F8 */ public float FoliageValueMax;
        /* 0x5FC */ public float GrassSaturationMin;
        /* 0x600 */ public float GrassSaturationMax;
        /* 0x604 */ public float GrassValueMin;
        /* 0x608 */ public float GrassValueMax;
        /* 0x60C */ public float SkySaturationMin;
        /* 0x610 */ public float SkySaturationMax;
        /* 0x614 */ public float SkyValueMin;
        /* 0x618 */ public float SkyValueMax;
        /* 0x61C */ public float SpaceScale;
        /* 0x620 */ public float SpaceMieFactor;
        /* 0x624 */ public float SpaceSunFactor;
        /* 0x628 */ public float MaxSpaceFogStrength;
        /* 0x62C */ public float ReflectionStrength;
        /* 0x630 */ public float AlphaCutoutMin;
        /* 0x634 */ public float AlphaCutoutMax;
        /* 0x638 */ public float WaterHueShift;
        /* 0x63C */ public float WaterSaturation;
        /* 0x640 */ public float WaterValue;
        /* 0x644 */ public float MaxParticleRenderRange;
        /* 0x648 */ public float MaxParticleRenderRangeSpace;
        /* 0x64C */ public float MotionBlurShutterSpeed;
        /* 0x650 */ public float MotionBlurShutterAngle;
        /* 0x654 */ public float TaaLowFreqConstant;
        /* 0x658 */ public float TaaHighFreqConstant;
        /* 0x65C */ public float TaaAccumDelay;
        /* 0x660 */ public float FrustumJitterAmount;
        /* 0x664 */ public float FrustumJitterAmountDLSS;
        /* 0x668 */ public bool UseTaaResolve;
        /* 0x669 */ public bool ApplyTaaTest;
        /* 0x66A */ public bool ShowTaaBuf;
        /* 0x66B */ public bool TonemapInLuminance;
        /* 0x66C */ public bool ShowTaaVarianceBuf;
        /* 0x66D */ public bool ShowTaaNVarianceBuf;
        /* 0x66E */ public bool ShowTaaCVarianceBuf;
        /* 0x670 */ public Vector4f TaaSettings;
        // size: 0x4
        public enum TessSettingsEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(TessSettingsEnum))]
        /* 0x680 */ public Vector4f[] TessSettings;
        /* 0x6C0 */ public Vector4f TerrainMipDistanceLow;
        /* 0x6D0 */ public Vector4f TerrainMipDistanceMed;
        /* 0x6E0 */ public Vector4f TerrainMipDistanceHigh;
        /* 0x6F0 */ public Vector4f TerrainMipDistanceUlt;
        // size: 0x4
        public enum ShellsSettingsEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(ShellsSettingsEnum))]
        /* 0x700 */ public Vector4f[] ShellsSettings;
        /* 0x740 */ public int TerrainAnisoLow;
        /* 0x744 */ public int TerrainAnisoMed;
        /* 0x748 */ public int TerrainAnisoHi;
        /* 0x74C */ public int TerrainAnisoUlt;
        /* 0x750 */ public int TerrainDroppedMipsLow;
        /* 0x754 */ public int TerrainDroppedMipsMed;
        /* 0x758 */ public float TerrainMipBiasLow;
        /* 0x75C */ public float TerrainMipBiasMed;
        /* 0x760 */ public int TerrainBlocksPerFrameLow;
        /* 0x764 */ public int TerrainBlocksPerFrameMed;
        /* 0x768 */ public int TerrainBlocksPerFrameHi;
        /* 0x76C */ public int TerrainBlocksPerFrameUlt;
        /* 0x770 */ public int TerrainBlocksPerFramePs430;
        /* 0x774 */ public int TerrainBlocksPerFramePs460;
        /* 0x778 */ public int TerrainBlocksPerFrameXb130;
        /* 0x77C */ public int TerrainBlocksPerFrameXb160;
        /* 0x780 */ public int TerrainBlocksPerFrameOberon;
        /* 0x784 */ public bool EnableTerrainCachePs4Base;
        /* 0x785 */ public bool EnableTerrainCachePs4Pro;
        /* 0x786 */ public bool EnableTerrainCacheXb1Base;
        /* 0x787 */ public bool EnableTerrainCacheXb1X;
        /* 0x788 */ public bool ForceCachedTerrain;
        /* 0x789 */ public bool ForceUncachedTerrain;
        /* 0x78C */ public float MinPixelSizeOfObjectsInShadowsSpace;
        /* 0x790 */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        /* 0x794 */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;
        /* 0x798 */ public bool AllowPartialCascadeRender;
        /* 0x7A0 */ public List<int> CascadeRenderSequence;
        /* 0x7B0 */ public int SupersamplingLevel;
        /* 0x7B4 */ public bool EnableTextureStreaming;
        /* 0x7B5 */ public bool ForceStreamAllTextures;
        /* 0x7B6 */ public bool ForceEvictAllTextures;
        /* 0x7B8 */ public int TargetTextureMemUsageMB;
        /* 0x7BC */ public float MotionBlurThresholdOnFoot;
        /* 0x7C0 */ public float MotionBlurThresholdInVehicle;
        /* 0x7C4 */ public float MotionBlurThresholdSpace;
        /* 0x7C8 */ public float MotionBlurThresholdDefault;
        /* 0x7CC */ public float SpaceIBLBlendStart;
        /* 0x7D0 */ public float SpaceIBLBlendDistance;
        /* 0x7D4 */ public float NoFocusMaxFPS;
        /* 0x7D8 */ public bool EnableCrossPipeSharing;
        /* 0x7D9 */ public bool EnableSSR;
        /* 0x7DA */ public bool ShowReflectionProbes;
        /* 0x7DC */ public float SharpenFilterAmount;
        /* 0x7E0 */ public float SharpenFilterDepthFactorStart;
        /* 0x7E4 */ public float SharpenFilterDepthFactorEnd;
        // size: 0x4
        public enum GraphicsDetailPresetsPCEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(GraphicsDetailPresetsPCEnum))]
        /* 0x7E8 */ public TkGraphicsDetailPreset[] GraphicsDetailPresetsPC;
        /* 0x8F8 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4;
        /* 0x93C */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR;
        /* 0x980 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro;
        /* 0x9C4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR;
        /* 0xA08 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1;
        /* 0xA4C */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1X;
        /* 0xA90 */ public TkGraphicsDetailPreset GraphicsDetailPresetOberon;
        /* 0xAD4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5VR;
        /* 0xB18 */ public bool EnableVariableUpdate;
        // size: 0x4
        public enum VariableUpdatePeriodModifersEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(VariableUpdatePeriodModifersEnum))]
        /* 0xB1C */ public float[] VariableUpdatePeriodModifers;
        /* 0xB2C */ public float PhotoModeBloomGainMin;
        /* 0xB30 */ public float PhotoModeBloomThresholdMin;
        /* 0xB34 */ public float PhotoModeDefaultBloomValue;
        /* 0xB38 */ public float PhotoModeMediumValue;
        /* 0xB3C */ public float PhotoModeBloomGainMedium;
        /* 0xB40 */ public float PhotoModeBloomThresholdMedium;
        /* 0xB44 */ public float PhotoModeBloomGainMax;
        /* 0xB48 */ public float PhotoModeBloomThresholdMax;
    }
}
