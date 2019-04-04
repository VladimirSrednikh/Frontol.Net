namespace FrontolSO
{
    public partial class fmuServiceIni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tsService = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSvcState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxServiceAutoRun = new System.Windows.Forms.CheckBox();
            this.tsServiceLogon = new System.Windows.Forms.TabPage();
            this.edtLogonPassword = new System.Windows.Forms.TextBox();
            this.edtLogonUser = new System.Windows.Forms.TextBox();
            this.rbLogonUser = new System.Windows.Forms.RadioButton();
            this.rbLogonSystem = new System.Windows.Forms.RadioButton();
            this.lblLogonPassword = new System.Windows.Forms.Label();
            this.btnSelectLogonUser = new System.Windows.Forms.Button();
            this.tsSystem = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtDBPswrd = new System.Windows.Forms.TextBox();
            this.edtLogFile = new System.Windows.Forms.TextBox();
            this.edtDBUser = new System.Windows.Forms.TextBox();
            this.edtDBFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtDBPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.btnTestDB = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tmrUpdateStatus = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tsService.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tsServiceLogon.SuspendLayout();
            this.tsSystem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tsService);
            this.tabControl1.Controls.Add(this.tsServiceLogon);
            this.tabControl1.Controls.Add(this.tsSystem);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tsService
            // 
            this.tsService.Controls.Add(this.groupBox1);
            this.tsService.Controls.Add(this.groupBox4);
            this.tsService.Controls.Add(this.cbxServiceAutoRun);
            this.tsService.Location = new System.Drawing.Point(4, 22);
            this.tsService.Name = "tsService";
            this.tsService.Padding = new System.Windows.Forms.Padding(3);
            this.tsService.Size = new System.Drawing.Size(355, 232);
            this.tsService.TabIndex = 0;
            this.tsService.Text = "Служба";
            this.tsService.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSvcState);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(4, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // lblSvcState
            // 
            this.lblSvcState.AutoSize = true;
            this.lblSvcState.Location = new System.Drawing.Point(91, 20);
            this.lblSvcState.Name = "lblSvcState";
            this.lblSvcState.Size = new System.Drawing.Size(73, 13);
            this.lblSvcState.TabIndex = 5;
            this.lblSvcState.Text = "<Состояние>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Состояние:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(178, 44);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(77, 25);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Перезапуск";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(262, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 3;
            this.button6.Text = "Открыть лог";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edtPath);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(4, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 69);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Регистрационная информация службы";
            // 
            // edtPath
            // 
            this.edtPath.Location = new System.Drawing.Point(10, 36);
            this.edtPath.Name = "edtPath";
            this.edtPath.ReadOnly = true;
            this.edtPath.Size = new System.Drawing.Size(329, 20);
            this.edtPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Путь";
            // 
            // cbxServiceAutoRun
            // 
            this.cbxServiceAutoRun.AutoSize = true;
            this.cbxServiceAutoRun.Location = new System.Drawing.Point(4, 11);
            this.cbxServiceAutoRun.Name = "cbxServiceAutoRun";
            this.cbxServiceAutoRun.Size = new System.Drawing.Size(85, 17);
            this.cbxServiceAutoRun.TabIndex = 4;
            this.cbxServiceAutoRun.Text = "Автозапуск";
            this.cbxServiceAutoRun.UseVisualStyleBackColor = true;
            this.cbxServiceAutoRun.CheckedChanged += new System.EventHandler(this.ParamsChanged);
            // 
            // tsServiceLogon
            // 
            this.tsServiceLogon.Controls.Add(this.edtLogonPassword);
            this.tsServiceLogon.Controls.Add(this.edtLogonUser);
            this.tsServiceLogon.Controls.Add(this.rbLogonUser);
            this.tsServiceLogon.Controls.Add(this.rbLogonSystem);
            this.tsServiceLogon.Controls.Add(this.lblLogonPassword);
            this.tsServiceLogon.Controls.Add(this.btnSelectLogonUser);
            this.tsServiceLogon.Location = new System.Drawing.Point(4, 22);
            this.tsServiceLogon.Name = "tsServiceLogon";
            this.tsServiceLogon.Padding = new System.Windows.Forms.Padding(3);
            this.tsServiceLogon.Size = new System.Drawing.Size(355, 232);
            this.tsServiceLogon.TabIndex = 1;
            this.tsServiceLogon.Text = "Вход в систему";
            this.tsServiceLogon.UseVisualStyleBackColor = true;
            // 
            // edtLogonPassword
            // 
            this.edtLogonPassword.Location = new System.Drawing.Point(130, 61);
            this.edtLogonPassword.Name = "edtLogonPassword";
            this.edtLogonPassword.Size = new System.Drawing.Size(160, 20);
            this.edtLogonPassword.TabIndex = 5;
            this.edtLogonPassword.TextChanged += new System.EventHandler(this.ParamsChanged);
            // 
            // edtLogonUser
            // 
            this.edtLogonUser.Location = new System.Drawing.Point(130, 35);
            this.edtLogonUser.Name = "edtLogonUser";
            this.edtLogonUser.Size = new System.Drawing.Size(160, 20);
            this.edtLogonUser.TabIndex = 4;
            this.edtLogonUser.TextChanged += new System.EventHandler(this.ParamsChanged);
            // 
            // rbLogonUser
            // 
            this.rbLogonUser.AutoSize = true;
            this.rbLogonUser.Location = new System.Drawing.Point(4, 37);
            this.rbLogonUser.Name = "rbLogonUser";
            this.rbLogonUser.Size = new System.Drawing.Size(124, 17);
            this.rbLogonUser.TabIndex = 3;
            this.rbLogonUser.Text = "С учетной записью:";
            this.rbLogonUser.UseVisualStyleBackColor = true;
            this.rbLogonUser.CheckedChanged += new System.EventHandler(this.rbLogon_CheckedChanged);
            // 
            // rbLogonSystem
            // 
            this.rbLogonSystem.AutoSize = true;
            this.rbLogonSystem.Location = new System.Drawing.Point(4, 11);
            this.rbLogonSystem.Name = "rbLogonSystem";
            this.rbLogonSystem.Size = new System.Drawing.Size(179, 17);
            this.rbLogonSystem.TabIndex = 2;
            this.rbLogonSystem.Text = "С системной учетной записью";
            this.rbLogonSystem.UseVisualStyleBackColor = true;
            this.rbLogonSystem.CheckedChanged += new System.EventHandler(this.rbLogon_CheckedChanged);
            // 
            // lblLogonPassword
            // 
            this.lblLogonPassword.AutoSize = true;
            this.lblLogonPassword.Location = new System.Drawing.Point(76, 64);
            this.lblLogonPassword.Name = "lblLogonPassword";
            this.lblLogonPassword.Size = new System.Drawing.Size(48, 13);
            this.lblLogonPassword.TabIndex = 1;
            this.lblLogonPassword.Text = "Пароль:";
            // 
            // btnSelectLogonUser
            // 
            this.btnSelectLogonUser.Location = new System.Drawing.Point(296, 35);
            this.btnSelectLogonUser.Name = "btnSelectLogonUser";
            this.btnSelectLogonUser.Size = new System.Drawing.Size(25, 21);
            this.btnSelectLogonUser.TabIndex = 0;
            this.btnSelectLogonUser.Text = "...";
            this.btnSelectLogonUser.UseVisualStyleBackColor = true;
            // 
            // tsSystem
            // 
            this.tsSystem.Controls.Add(this.groupBox2);
            this.tsSystem.Controls.Add(this.edtDBPath);
            this.tsSystem.Controls.Add(this.label4);
            this.tsSystem.Controls.Add(this.btnRestoreDefaults);
            this.tsSystem.Controls.Add(this.btnTestDB);
            this.tsSystem.Controls.Add(this.btnOpenDB);
            this.tsSystem.Location = new System.Drawing.Point(4, 22);
            this.tsSystem.Name = "tsSystem";
            this.tsSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tsSystem.Size = new System.Drawing.Size(355, 232);
            this.tsSystem.TabIndex = 2;
            this.tsSystem.Text = "База данных";
            this.tsSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtDBPswrd);
            this.groupBox2.Controls.Add(this.edtLogFile);
            this.groupBox2.Controls.Add(this.edtDBUser);
            this.groupBox2.Controls.Add(this.edtDBFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(4, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры базы данных";
            // 
            // edtDBPswrd
            // 
            this.edtDBPswrd.Location = new System.Drawing.Point(178, 78);
            this.edtDBPswrd.Name = "edtDBPswrd";
            this.edtDBPswrd.Size = new System.Drawing.Size(160, 20);
            this.edtDBPswrd.TabIndex = 7;
            this.edtDBPswrd.Text = "masterkey";
            // 
            // edtLogFile
            // 
            this.edtLogFile.Location = new System.Drawing.Point(10, 78);
            this.edtLogFile.Name = "edtLogFile";
            this.edtLogFile.Size = new System.Drawing.Size(160, 20);
            this.edtLogFile.TabIndex = 6;
            this.edtLogFile.Text = "LOG.GDB";
            // 
            // edtDBUser
            // 
            this.edtDBUser.Location = new System.Drawing.Point(178, 36);
            this.edtDBUser.Name = "edtDBUser";
            this.edtDBUser.Size = new System.Drawing.Size(160, 20);
            this.edtDBUser.TabIndex = 5;
            this.edtDBUser.Text = "SYSDBA";
            // 
            // edtDBFile
            // 
            this.edtDBFile.Location = new System.Drawing.Point(10, 36);
            this.edtDBFile.Name = "edtDBFile";
            this.edtDBFile.Size = new System.Drawing.Size(160, 20);
            this.edtDBFile.TabIndex = 4;
            this.edtDBFile.Text = "MAIN.GDB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Журнал:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Пользователь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Основная:";
            // 
            // edtDBPath
            // 
            this.edtDBPath.Location = new System.Drawing.Point(4, 20);
            this.edtDBPath.Name = "edtDBPath";
            this.edtDBPath.Size = new System.Drawing.Size(324, 20);
            this.edtDBPath.TabIndex = 4;
            this.edtDBPath.TextChanged += new System.EventHandler(this.ParamsChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Каталог базы данных:";
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Location = new System.Drawing.Point(116, 164);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(105, 25);
            this.btnRestoreDefaults.TabIndex = 2;
            this.btnRestoreDefaults.Text = "По умолчанию";
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // btnTestDB
            // 
            this.btnTestDB.Location = new System.Drawing.Point(4, 164);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(105, 25);
            this.btnTestDB.TabIndex = 1;
            this.btnTestDB.Text = "Проверить";
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(330, 18);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(24, 23);
            this.btnOpenDB.TabIndex = 0;
            this.btnOpenDB.Text = "...";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 34);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(194, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 25);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Выберите каталог";
            // 
            // fmuServiceIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmuServiceIni";
            this.Text = "fmuServiceIni";
            this.tabControl1.ResumeLayout(false);
            this.tsService.ResumeLayout(false);
            this.tsService.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tsServiceLogon.ResumeLayout(false);
            this.tsServiceLogon.PerformLayout();
            this.tsSystem.ResumeLayout(false);
            this.tsSystem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tsService;
        private System.Windows.Forms.TabPage tsServiceLogon;
        private System.Windows.Forms.TabPage tsSystem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelectLogonUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.Button btnTestDB;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbxServiceAutoRun;
        private System.Windows.Forms.Label lblSvcState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtLogonPassword;
        private System.Windows.Forms.TextBox edtLogonUser;
        private System.Windows.Forms.RadioButton rbLogonUser;
        private System.Windows.Forms.RadioButton rbLogonSystem;
        private System.Windows.Forms.Label lblLogonPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtDBPswrd;
        private System.Windows.Forms.TextBox edtLogFile;
        private System.Windows.Forms.TextBox edtDBUser;
        private System.Windows.Forms.TextBox edtDBFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtDBPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtPath;
        private System.Windows.Forms.Timer tmrUpdateStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}