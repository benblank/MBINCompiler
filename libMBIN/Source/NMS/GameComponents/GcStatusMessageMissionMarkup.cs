﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCB39899C49E9126, SubGUID = 0x8E8EC2C807363E97)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // 0x10 entries
        public enum MissionMarkupEnum { KillFiend, KillPirate, KillSentinel, KillHazardousPlants, KillTraders, KillCreatures, KillPredators, KillDepot, FeedCreature,
            CollectBones, CollectScrap, Discover, CollectSubstanceProduct, Build, Always, None }
        public MissionMarkupEnum MissionMarkup;
    }
}