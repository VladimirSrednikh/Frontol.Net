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
using System.Diagnostics;

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

    public partial class fmuServiceIni : Form
    {
        protected
          string fIniLogFile;

        void LoadIni(IniFile AIni) {}
        void SaveIni(IniFile AIni){}
        protected virtual TServiceParams Params() { return new TServiceParams(); }
        string GetServiceLogPath() {
            if (fIniLogFile != "") {
                return fIniLogFile;
            } else {
                return "";
            }
        }
        
        private ServiceControllerStatus fLastState = ServiceControllerStatus.Stopped;
        const string USER_LOCAL_SYSTEM = "LocalSystem";
        const string PASS_UNASSIGNED = "PASS_UNASSIGNED";


        private void LoadDBParams()
        {
            LoadIni(new IniFile(GetServiceIniPath()));
        }
        private void SaveDBParams()
        {
            SaveIni(new IniFile(GetServiceIniPath()));
        }
        private void LoadService() {
            TServiceInfo SI = new TServiceInfo();
            if (Params().SvcName == null) return;
            try
            {                
                ServiceInfo.GetServiceInfo(Params().SvcName, out SI);
                cbxServiceAutoRun.Checked = (SI.StartType == (uint)ServiceStartMode.Automatic);
                edtPath.Text = SI.lpBinaryPathName;
                rbLogonUser.Checked = (SI.lpServiceStartName != USER_LOCAL_SYSTEM);
                rbLogonSystem.Checked = !rbLogonUser.Checked;

                if (rbLogonUser.Checked) {
                    edtLogonPassword.Text = PASS_UNASSIGNED; // пароль получить невозможно, просто отобразим звездочки
                    edtLogonUser.Text = SI.lpServiceStartName;
                }
            }
            catch (Win32Exception ex)
            {                       //ERROR_ACCESS_DENIED
                if (ex.NativeErrorCode == 5) edtPath.Text = "Недостаточно прав для управления службой";
                else edtPath.Text = "Служба " + Params().DisplayName + " не установлена";
            }
            finally {
                UpdateControls(SI);
            }
        }
        private void SaveService() {
            TServiceInfo SI;
            ServiceInfo.GetServiceInfo(Params().SvcName, out SI);

            if (SI.ServiceName != "") {
                TServiceInfo SC_new = new TServiceInfo();
                SC_new.ServiceName = SI.ServiceName;
                SC_new.Password = edtLogonPassword.Text;
                if (cbxServiceAutoRun.Checked) SC_new.StartType = ServiceInfo.SERVICE_AUTO_START;
                else SC_new.StartType = ServiceInfo.SERVICE_DEMAND_START;

                if ((!rbLogonSystem.Checked) & (edtLogonUser.Text.Trim() == "")) rbLogonSystem.Checked = true;
                if (rbLogonSystem.Checked) {
                }
                ServiceInfo.ChangeServiceConfig(SI.ServiceName, SC_new);
            }               

        }
        private void UpdateControls(TServiceInfo SI) {
            Color[] edtEnColor = { SystemColors.ButtonFace, SystemColors.Window };
            if (SI.ServiceName == "")
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
                if (rbLogonUser.Checked) edtLogonUser.BackColor = edtEnColor[1];
                else edtLogonUser.BackColor = edtEnColor[0];
                edtLogonUser.Enabled = rbLogonUser.Checked;

                if (rbLogonUser.Checked) edtLogonPassword.BackColor = edtEnColor[1];
                else edtLogonPassword.BackColor = edtEnColor[0];
                edtLogonPassword.Enabled = rbLogonUser.Checked;
                lblLogonPassword.Enabled = rbLogonUser.Checked;

                btnSelectLogonUser.Enabled = rbLogonUser.Checked;
                if (fLastState != SI.dwCurrentState)
                {
                    fLastState = SI.dwCurrentState;

                    btnStart.Enabled = SI.dwCurrentState == ServiceControllerStatus.Stopped;
                    btnStop.Enabled = SI.dwCurrentState == ServiceControllerStatus.Running;
                    btnRestart.Enabled = SI.dwCurrentState == ServiceControllerStatus.Running;
                    lblSvcState.Text = SI.StateAsStr();                   
                }

            };
        }
        private string GetServiceIniPath()
        {
            if (fIniLogFile != "") return fIniLogFile;
            else return LvvShell.GetFrontolCommonAppDataPath("Logs");
        }
        private void StartService(bool aApplySettings) {
            if (aApplySettings & btnApply.Enabled) {
                if (MessageBox.Show("Сохранить изменения ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                SaveService();
                SaveDBParams();
                btnApply.Enabled = false;
            }
            TServiceInfo SI;            
            ServiceInfo.GetServiceInfo(Params().SvcName, out SI);
            if (SI.dwCurrentState != ServiceControllerStatus.Stopped) throw new System.ArgumentException("'В данный момент запустить " + Params().DisplayName + " невозможно!'");
            ServiceController sc = new ServiceController(Params().SvcName);
            sc.Start();
            try
            {
                /*

        wfrm:= TLvvWaitForm.CreateShow(aviFindFile, 'Прервать', nil);
            try
      wfrm.Status := 'Запуск службы!';
            while ServiceStatus.dwCurrentState = SERVICE_START_PENDING do
                    begin
      
              Sleep(1000);
            if not QueryServiceStatus(fSrvHandle, ServiceStatus) then
              RaiseLastOSError;
            if wfrm.ButtonPressed then
              Abort;
            end;
    finally
      wfrm.Free;
            end;
            if ServiceStatus.dwCurrentState = SERVICE_STOPPED then
                LvvShowMessageBox('Не удалось запустить службу ' + Params.DisplayName + '. Смотрите журнал ошибок', MB_OK or MB_ICONERROR, 0);
                */
            }
            finally {
                UpdateControls(SI);
            }
        }

        public fmuServiceIni()
        {
            InitializeComponent();
            LoadService();
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            edtDBFile.Text = "MAIN.GDB";
            edtLogFile.Text = "LOG.GDB";
            edtDBUser.Text = "SYSDBA";
            edtDBPswrd.Text = "masterkey";
        }

        private void ParamsChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void rbLogon_CheckedChanged(object sender, EventArgs e)
        {
            ParamsChanged(sender, e);
            TServiceInfo SI;
            ServiceInfo.GetServiceInfo(Params().SvcName, out SI);
            UpdateControls(SI);
        }
    }
}
