using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Runtime.InteropServices;

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
            ServiceController SC;
        // byte fLastState;
        const string USER_LOCAL_SYSTEM = "LocalSystem";
        const string PASS_UNASSIGNED = "PASS_UNASSIGNED";


        private void LoadDBParams()
        {
            SaveIni(new IniFile(GetServiceIniPath()));
        }
        private void SaveDBParams()
        {
            SaveIni(new IniFile(GetServiceIniPath()));
        }
        private void LoadService() {
            try
            {
                SC = new ServiceController(Params().SvcName);
                //throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to open handle to Service Control Manager");
                /*
                user = SC.
                    string(lpqscBuf.lpServiceStartName);
                rbLogonUser.Checked := user <> USER_LOCAL_SYSTEM;
                if rbLogonUser.Checked then
                begin
          edtLogonPassword.Text := PASS_UNASSIGNED; // пароль получить невозможно, просто отобразим звездочки (АИ)
                edtLogonUser.Text := user;
                end; */



            }
            catch (Win32Exception ex)
            {                       //ERROR_ACCESS_DENIED
                if (ex.NativeErrorCode == 5) edtPath.Text = "Недостаточно прав для управления службой";
                else edtPath.Text = "Служба " + Params().DisplayName + " не установлена";
            }
            finally {
                UpdateControls();
            }
        }
        private void SaveService() { }
        private void UpdateControls() {
            if (SC == null)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnRestart.Enabled = false;
                cbxServiceAutoRun.Enabled = false;
                tmrUpdateStatus.Enabled = false;
                rbLogonSystem.Enabled = false;
                rbLogonUser.Enabled = false;
                edtLogonUser.Enabled = false;
                edtLogonPassword.Enabled = false;
                btnSelectLogonUser.Enabled = false;
            }
            else {
                //cbxServiceAutoRun.Checked = (SC.StartType == ServiceStartMode.Automatic);

              
            };
        }
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
