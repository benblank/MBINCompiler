using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x983693477C16EC06, NameHash = 0xFB7EF63CCFF49839)]
    public class GcAreaDamageDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAreaDamageData> Table;
    }
}
