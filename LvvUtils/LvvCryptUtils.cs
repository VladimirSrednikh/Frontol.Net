using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontolSO
{
    class LvvCryptUtils
    {
        static public string EncryptToHexStr(string Data) {
            byte[] bytes = Encoding.ASCII.GetBytes(Data);

            Data.ToArray()
        }

        static public string DecryptHexStr(string Data) {

            string someString = Encoding.ASCII.GetString(bytes);
        }
        

    }
}
