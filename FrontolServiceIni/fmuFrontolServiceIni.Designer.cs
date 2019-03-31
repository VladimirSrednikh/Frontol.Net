namespace FrontolServiceIni
{
    partial class frmFrontolServiceIni
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrontolServiceIni));
            this.tsMaintain = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tsMaintain);
            this.tabControl1.Controls.SetChildIndex(this.tsMaintain, 0);
            // 
            // tsMaintain
            // 
            this.tsMaintain.Location = new System.Drawing.Point(4, 22);
            this.tsMaintain.Name = "tsMaintain";
            this.tsMaintain.Padding = new System.Windows.Forms.Padding(3);
            this.tsMaintain.Size = new System.Drawing.Size(355, 232);
            this.tsMaintain.TabIndex = 3;
            this.tsMaintain.Text = "Обслуживание БД";
            this.tsMaintain.UseVisualStyleBackColor = true;
            // 
            // frmFrontolServiceIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFrontolServiceIni";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tsMaintain;
    }
}
