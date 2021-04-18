﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x077DC59C00406CFA, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Archetype;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string AppearAnim;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string SpawnLocator;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string SpawnLocatorScanEvent;
        public enum FaceDirEnum { Random, TowardsPlayer, SpawnerAt };
        /* 0x50 */ public FaceDirEnum FaceDir;
        /* 0x54 */ public float MinDist;
        /* 0x58 */ public float MaxDist;
        [NMS(Size = 0x7, EnumType = typeof(GcGameMode.PresetGameModeEnum))]
        /* 0x5C */ public int[] MinNum;
        [NMS(Size = 0x7, EnumType = typeof(GcGameMode.PresetGameModeEnum))]
        /* 0x78 */ public int[] MaxNum;
        /* 0x94 */ public float ActiveTime;
    }
}
