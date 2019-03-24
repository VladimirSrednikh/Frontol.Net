using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontolSO
{
    public struct TServiceParams {
        public string Ini;
        public string IniSection;
        public string SvcName;
        public string DisplayName;
        public string Log;
        public string LogSection;
        public TServiceParams(string AIni, string AIniSection, string ASvcName, string ADisplayName, string ALog, string ALogSection)
        {
            Ini = AIni;
            IniSection = AIniSection;
            DisplayName = ADisplayName;
            SvcName = ASvcName;
            Log = ALog;
            LogSection = ALogSection;
        }
    }

    public abstract partial class fmuServiceIni : Form
    {
        protected
          string fIniLogFile;

        void LoadIni(IniFile AIni) {}
        void SaveIni(IniFile AIni){}
        protected abstract TServiceParams Params();
        string GetServiceLogPath() {
            if (fIniLogFile != "") {
                return fIniLogFile;
            } else {
                return "";
            }
        }
        private
        //THandle fSrvHandle; 
        // byte fLastState;
        const string USER_LOCAL_SYSTEM = "LocalSystem";
        const string PASS_UNASSIGNED = "PASS_UNASSIGNED";


        private void LoadDBParams()
        {
            #region
            IniFile ini = new IniFile(GetServiceIniPath());
            SaveIni(ini);
            #endregion
        }
        private void SaveDBParams()
        {
            #region
            string ini = GetServiceIniPath();
            #endregion
        }
        private void LoadService() { }
        private void SaveService() { }
        private void UpdateControls(int aServiceStatus) { }
        private string GetServiceIniPath()
        {
            if (fIniLogFile != "") return fIniLogFile;
            else return LvvShell.GetFrontolCommonAppDataPath("Logs");
        }
        private void StartService(bool aApplySettings) { }



        public fmuServiceIni()
        {
            InitializeComponent();
        }
    }
}
