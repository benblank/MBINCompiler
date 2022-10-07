namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A90AA1BA5899070, NameHash = 0x9C74A74AB0211EF6)]
    public class GcDoShipFlybyClose : NMSTemplate
    {
        /* 0x0 */ public float LockOffset;
        /* 0x4 */ public float LockTime;
        /* 0x8 */ public float LockSpread;
        /* 0xC */ public bool StayCloseAtLowSpeed;
        /* 0xD */ public bool HailingBehaviour;
    }
}
