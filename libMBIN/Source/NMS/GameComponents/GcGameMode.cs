namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12B8A9683D0E67A4, NameHash = 0x2BFE76ABF5398879)]
    public class GcGameMode : NMSTemplate
    {
        // size: 0x7
        public enum PresetGameModeEnum {
            Unspecified,
            Normal,
            Creative,
            Survival,
            Ambient,
            Permadeath,
            Seasonal
        }
        /* 0x0 */ public PresetGameModeEnum PresetGameMode;
    }
}
