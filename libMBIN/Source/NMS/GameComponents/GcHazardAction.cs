using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDD1753E3C085C69, NameHash = 0x2FCEFF0AE05742C0)]
    public class GcHazardAction : NMSTemplate
    {
        /* 0x0 */ public GcPlayerHazardType Hazard;
        /* 0x4 */ public float Strength;
        /* 0x8 */ public float Radius;
        /* 0xC */ public bool RadiusBasedStrength;
    }
}
