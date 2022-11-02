namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x139842ABA7D2269C, NameHash = 0xFFDCD21B79EE81DE)]
    public class GcScreenFilterData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LocText;
        /* 0x20 */ public NMSString0x80 Filename;
        /* 0xA0 */ public float FadeDistance;
        /* 0xA4 */ public bool SelectableInPhotoMode;
        /* 0xA8 */ public float HdrAreaAdjust;
    }
}
