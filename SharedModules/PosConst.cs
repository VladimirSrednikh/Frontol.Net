using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontolSO
{
    public struct TServiceStatus {
        public const int SERVICE_STOPPED = 0x00000001;
        public const int SERVICE_START_PENDING =  0x00000002;
        public const int SERVICE_STOP_PENDING  =  0x00000003;
        public const int SERVICE_RUNNING = 0x00000004;
        public const int SERVICE_CONTINUE_PENDING = 0x00000005;
        public const int SERVICE_PAUSE_PENDING = 0x00000006;
        public const int SERVICE_PAUSED = 0x00000007;


    }

    public static class PosConst
    {
    

        public const string INI_SECTION_BDS = "BDS";
        public const string INI_SECTION_GENERAL = "GENERAL";
        public const string INI_SECTION_DATABASE = "DATABASE";
        public const string INI_SECTION_CUSTOM = "Custom";
        public const string INI_SECTION_POS = "POS";
        public const string INI_SECTION_TPISCAN = "TPISCAN";
        public const string INI_SECTION_EMENU = "EMENU";



    }
}
