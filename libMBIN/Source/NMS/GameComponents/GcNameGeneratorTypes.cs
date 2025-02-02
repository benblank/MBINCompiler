namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFABB4C4BE97FDB12, NameHash = 0xC9FA06A9CF2CE65D)]
    public class GcNameGeneratorTypes : NMSTemplate
    {
        // size: 0x8
        public enum MarkovSelectorEnum {
            Generic,
            Mineral,
            Region_NO,
            Region_RU,
            Region_CH,
            Region_JP,
            Region_LT,
            Region_FL
        }
        /* 0x0 */ public MarkovSelectorEnum MarkovSelector;
    }
}
