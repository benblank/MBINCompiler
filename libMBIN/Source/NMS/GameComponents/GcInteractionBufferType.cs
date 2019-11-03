﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC44D601AF6AE9B96, NameHash = 0x56096224708D16B)]
    public class GcInteractionBufferType : NMSTemplate
    {
		public enum InterationBufferTypeEnum { Distress_Signal, Crate, Destructable, Terrain, Cost, Building, Creature, Maintenance,
                                               Personal, Personal_Maintenance, FireteamSync }
		public InterationBufferTypeEnum InterationBufferType;
    }
}
