using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

// Change this to match your program's normal namespace
namespace FrontolSO
{
    [DllImport("shell32.dll"), CharSet = CharSet.Auto]
    static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken,
                                      uint dwFlags, [Out] StringBuilder pszPath);

    const int CSIDL_FLAG_CREATE = 0x8000;

    public string GetShellFolder(Integer AFolderCSIDL) {
        StringBuilder sb = new StringBuilder();
        int retVal = SHGetFolderPath(IntPtr.Zero,
                                     nFolder | CSIDL_FLAG_CREATE,
                                     IntPtr.Zero,
                                     0,
                                     sb);
        Debug.Assert(retVal >= 0);  // assert that the function call succeeded
        return sb.ToString();
    }

    public string IncludeTrailingPathDelimiter(string s) {
        if (Right(s, 1) != Path.PathSeparator) then return s + Path.PathSeparator;
        else return s;
    }
    public string GetFrontolCommonAppDataPath(string ASubFolder) {
        string res = GetShellFolder(CSIDL_COMMON_APPDATA) ;


    }
    public string GetFrontolUserAppDataPath(string ASubFolder) {
        string res = GetShellFolder(CSIDL_APPDATA);
    }
    public string GetFrontolTempPath {
        return Path.GetTempPath();
    }


}