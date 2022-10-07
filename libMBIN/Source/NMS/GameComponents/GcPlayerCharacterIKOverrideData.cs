namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28A5F0DD7B123C68, NameHash = 0xD3E29E0D0AAA3B2B)]
    public class GcPlayerCharacterIKOverrideData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x04 */ public float Strength;
        /* 0x10 */ public Vector3f RotStrengths;
    }
}
