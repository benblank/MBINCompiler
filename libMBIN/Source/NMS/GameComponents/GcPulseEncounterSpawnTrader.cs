using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9765E4ED2AE6637, NameHash = 0x61E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public bool UseCustomMessage;
        /* 0x2B0 */ public NMSString0x20A CustomHailOSD;
        /* 0x2D0 */ public GcPlayerCommunicatorMessage HailingMessage;
    }
}
