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
        string Ini;
        string IniSection;
        string SvcName;
        string DisplayName;
        string Log;
        string LogSection;
    }





    public partial class fmuServiceIni : Form
    {

        protected
          string fIniLogFile;

        private
          //THandle fSrvHandle; 
         // byte fLastState;
        const string USER_LOCAL_SYSTEM = "LocalSystem";
        const string PASS_UNASSIGNED = "PASS_UNASSIGNED";
        private void LoadDBParams()
        {
            #region

            #endregion
        }
        private void SaveDBParams()
        {
            #region
            string ini = GetServiceIniPath();
            #endregion
        }
        private string GetServiceIniPath() {
            #region
            return "";
            #endregion
        }

        public fmuServiceIni()
        {
            InitializeComponent();
        }
    }
}
