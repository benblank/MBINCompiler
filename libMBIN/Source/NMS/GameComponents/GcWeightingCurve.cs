namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3B3509D53536EAB, NameHash = 0xB33B21B3131CD08D)]
    public class GcWeightingCurve : NMSTemplate
    {
        // size: 0x7
        public enum WeightingCurveEnum {
            NoWeighting,
            MaxIsUncommon,
            MaxIsRare,
            MaxIsSuperRare,
            MinIsUncommon,
            MinIsRare,
            MinIsSuperRare
        }
        /* 0x0 */ public WeightingCurveEnum WeightingCurve;
    }
}
