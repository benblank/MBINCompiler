namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42D5E0C093493E60, NameHash = 0x5C2C30D664D4775B)]
    public class GcInventoryClass : NMSTemplate
    {
        // size: 0x4
        public enum InventoryClassEnum {
            C,
            B,
            A,
            S
        }
        /* 0x0 */ public InventoryClassEnum InventoryClass;
    }
}
