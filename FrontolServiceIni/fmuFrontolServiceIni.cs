using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrontolSO;

namespace FrontolServiceIni
{
    public partial class frmFrontolServiceIni : FrontolSO.fmuServiceIni
    {
        public frmFrontolServiceIni()
        {
            InitializeComponent();
        }

        protected override TServiceParams Params()
        {
            return new FrontolSO.TServiceParams(
                "FrontolService.ini",
                "DATABASE",
                "srvFrontol",
                "FrontolService",
                "FrontolService.log",
                PosConst.INI_SECTION_CUSTOM
                );
        }

    }
}
