namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B36B72058AFAB8C, NameHash = 0xCD771E985A27F526)]
    public class GcMissionSequenceWaitForStatMilestone : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Stat;
        // size: 0x3
        public enum MilestoneEnum {
            Bronze,
            Silver,
            Gold
        }
        /* 0x90 */ public MilestoneEnum Milestone;
        /* 0x94 */ public bool EveryMilestone;
        /* 0x95 */ public NMSString0x80 DebugText;
    }
}
