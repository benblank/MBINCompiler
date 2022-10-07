using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70B2586324A969F1, NameHash = 0xA1666CAA6E88F270)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        /* 0x00 */ public GcBiomeSubType SubType;
        /* 0x04 */ public NMSString0x80 Filename;
        /* 0x84 */ public float Weight;
    }
}
