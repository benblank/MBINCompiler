namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B72D28DF2B25B17, NameHash = 0x788C67D6B87C29E3)]
    public class GcBroadcastLevel : NMSTemplate
    {
        // size: 0x3
        public enum BroadcastLevelEnum {
            Scene,
            LocalModel,
            Local
        }
        /* 0x0 */ public BroadcastLevelEnum BroadcastLevel;
    }
}
