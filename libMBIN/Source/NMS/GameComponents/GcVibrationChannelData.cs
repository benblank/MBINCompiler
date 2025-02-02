using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x645F7891B7673B8A, NameHash = 0xAF919B46C646D940)]
    public class GcVibrationChannelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x2
        public enum DataEnum {
            Left,
            Right
        }
        [NMS(Size = 0x2, EnumType = typeof(DataEnum))]
        /* 0x10 */ public GcVibrationData[] Data;
    }
}
