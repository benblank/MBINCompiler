using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A23A530852BCA7E, NameHash = 0x6310315CF52D5A45)]
    public class GcTriggerFeedbackState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcInputActions Action;
        /* 0x14 */ public TkTriggerFeedbackData Data;
    }
}
