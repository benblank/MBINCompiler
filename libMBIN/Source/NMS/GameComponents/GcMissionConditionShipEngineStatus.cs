namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x347120D2E460CD9D, NameHash = 0x9A43A9B870251F8C)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        // size: 0x8
        public enum EngineStatusEnum {
            Thrusting,
            Braking,
            Landing,
            Landed,
            Boosting,
            Pulsing,
            LowFlight,
            Inverted
        }
        /* 0x0 */ public EngineStatusEnum EngineStatus;
    }
}
