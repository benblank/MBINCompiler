using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB4DFDB459F73DAD, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        /* 0x0 */ public GcBiomeType Type;
        /* 0x4 */ public bool AnyInfested;
    }
}
