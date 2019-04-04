using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontolSO
{
    public class LvvUtils
    {
        public static string IncludeTrailingPathDelimiter(string s)
        {
            if (s.EndsWith(Path.PathSeparator.ToString())) { return s; }
            else return s + Path.DirectorySeparatorChar;
        }
    }
}
