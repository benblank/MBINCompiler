using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC, GUID = 0x8EA0C78526E4DF5D, NameHash = 0x8713A8C7BE9925C6)]
    public class GcMechPartAudioEventOverride : NMSTemplate
    {
        /* 0x0 */ public GcMechMeshPart MeshPart;
        /* 0x4 */ public GcMechMeshType MeshType;
        /* 0x8 */ public GcAudioWwiseEvents OverrideEvent;
    }
}