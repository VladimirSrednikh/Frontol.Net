using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace FrontolSO
{

    class LvvShell
    {
        internal static class NativeMethods
        {
            [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
            public static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken,
                                              uint dwFlags, [Out] StringBuilder pszPath);
        }

        const int CSIDL_FLAG_CREATE = 0x8000;
        const int CSIDL_COMMON_APPDATA = 0x23;
        const int CSIDL_APPDATA = 0x1a;

        public static string GetShellFolder(Int32 AFolderCSIDL) {
        StringBuilder sb = new StringBuilder();
        int retVal = NativeMethods.SHGetFolderPath(IntPtr.Zero,
                                     AFolderCSIDL | CSIDL_FLAG_CREATE,
                                     IntPtr.Zero,
                                     0,
                                     sb);
        Debug.Assert(retVal >= 0);  // assert that the function call succeeded
        return sb.ToString();
    }

      public static string IncludeTrailingPathDelimiter(string s) {
        if (s.EndsWith(Path.PathSeparator.ToString())) { return s; }
        else return s + Path.PathSeparator;
    }
      public static string GetFrontolCommonAppDataPath(string ASubFolder) {
        string res = IncludeTrailingPathDelimiter(GetShellFolder(CSIDL_COMMON_APPDATA)) + "ATOL\\Frontol5\\";
        if (ASubFolder != "") res = IncludeTrailingPathDelimiter(res + ASubFolder);
        if (!Directory.Exists(res)) Directory.CreateDirectory(res);
        return res;
        }
      public static string GetFrontolUserAppDataPath(string ASubFolder) {
        string res = GetShellFolder(CSIDL_APPDATA);
        if (ASubFolder != "") res = IncludeTrailingPathDelimiter(res + ASubFolder);
        if (!Directory.Exists(res)) Directory.CreateDirectory(res);
        return res;
        }
      public static string GetFrontolTempPath() {
            return Path.GetTempPath();
        }

    }
}