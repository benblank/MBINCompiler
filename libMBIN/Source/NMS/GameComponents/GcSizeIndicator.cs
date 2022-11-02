namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6974724BC0F6C38, NameHash = 0x22715A99B359A960)]
    public class GcSizeIndicator : NMSTemplate
    {
        // size: 0x3
        public enum SizeIndicatorEnum {
            Small,
            Medium,
            Large
        }
        /* 0x0 */ public SizeIndicatorEnum SizeIndicator;
    }
}
