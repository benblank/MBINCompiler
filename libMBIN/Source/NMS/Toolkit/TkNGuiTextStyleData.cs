using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4A5705BD009E36F6, NameHash = 0x91FBF976CBE15B5F)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float FontHeight;
        /* 0x14 */ public float FontSpacing;
        /* 0x18 */ public bool IsIndented;
        /* 0x19 */ public bool HasDropShadow;
        /* 0x20 */ public Colour ShadowColour;
        /* 0x30 */ public float DropShadowAngle;
        /* 0x34 */ public float DropShadowOffset;
        /* 0x38 */ public bool HasOutline;
        /* 0x3C */ public float OutlineSize;
        /* 0x40 */ public Colour OutlineColour;
        /* 0x50 */ public bool IsParagraph;
        /* 0x51 */ public bool AllowScroll;
        /* 0x52 */ public bool ForceUpperCase;
        /* 0x53 */ public bool AutoAdjustHeight;
        /* 0x54 */ public bool BlockAudio;
        /* 0x58 */ public int FontIndex;
        /* 0x5C */ public TkNGuiAlignment Align;
    }
}
