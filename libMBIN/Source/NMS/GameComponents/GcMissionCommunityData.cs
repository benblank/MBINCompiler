using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2077A7CECC1F140F, NameHash = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> CommunityMissionsIDs;
        /* 0x10 */ public List<GcMissionCommunityMissionData> CommunityMissionsData;
    }
}
