namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC44D601AF6AE9B96, NameHash = 0x56096224708D16B)]
    public class GcInteractionBufferType : NMSTemplate
    {
        // size: 0xB
        public enum InteractionBufferTypeEnum {
            Distress_Signal,
            Crate,
            Destructable,
            Terrain,
            Cost,
            Building,
            Creature,
            Maintenance,
            Personal,
            Personal_Maintenance,
            FireteamSync
        }
        /* 0x0 */ public InteractionBufferTypeEnum InteractionBufferType;
    }
}
