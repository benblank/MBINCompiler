using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9DD036CB59D969D, NameHash = 0x4992418A4C059481)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 StupidUserName;
        /* 0x80 */ public List<GcCreatureStupidName> Table;
    }
}
