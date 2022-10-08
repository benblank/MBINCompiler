using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25288807F8FDA918, NameHash = 0xDF6FAA4A31B4C454)]
    public class GcClothAttractor : NMSTemplate
    {
        /* 0x00 */ public float AttractionStrength;
        /* 0x04 */ public bool UseInitialShapeAsAttractorShape;
        /* 0x08 */ public float AttractionRadiusAtTop;
        /* 0x0C */ public float AttractionRadiusAtBottom;
        /* 0x10 */ public GcCapeLikeInitialShape CapeLikeAttractorShape;
    }
}