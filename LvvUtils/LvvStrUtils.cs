using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontolSO
{
    class LvvStrUtils
    {
        static public string GetPathWOHost(string APath) {
            if (APath == "") return "";
            int FirstDelim = APath.IndexOf(":");
            if (FirstDelim == 1) return APath; // Значит это обычный путь
            return APath.Substring(FirstDelim);
        }
        static public string GetHostName(string APath)
        {
            int FirstDelim = APath.IndexOf(":");
            if (FirstDelim == 1) return ""; // Значит это обычный путь
            return APath.Substring(0, FirstDelim - 1);
        }
        static public byte[] StrHexToBytes(string AStr, ref bool NewFormat) {

        }

    }
}
