namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A369F580CCFD0EE, NameHash = 0x67530B28A8F0F92)]
    public class GcMessageSummonAndDismiss : NMSTemplate
    {
        // size: 0x2
        public enum SummonEventTypeEnum {
            Summon,
            Dismiss
        }
        /* 0x0 */ public SummonEventTypeEnum SummonEventType;
    }
}
