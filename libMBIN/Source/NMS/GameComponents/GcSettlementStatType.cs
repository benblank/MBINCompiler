namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA36A0948C879475E, NameHash = 0x9394F46EDEDBE660)]
    public class GcSettlementStatType : NMSTemplate
    {
        // size: 0x7
        public enum SettlementStatTypeEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        /* 0x0 */ public SettlementStatTypeEnum SettlementStatType;
    }
}
