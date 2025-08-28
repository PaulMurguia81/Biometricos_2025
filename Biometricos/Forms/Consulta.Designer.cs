namespace Biometricos.Forms
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.btnConnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBiometricos = new System.Windows.Forms.ComboBox();
            this.gc_Attlog = new DevExpress.XtraGrid.GridControl();
            this.gv_Attlog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkBox_timePeriod = new System.Windows.Forms.CheckBox();
            this.stime_log = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.etime_log = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_readAttLog = new System.Windows.Forms.Button();
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attlog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnConnect.Image = global::Biometricos.Properties.Resources.disconnected_25px;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(416, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 31);
            this.btnConnect.TabIndex = 1037;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 1036;
            this.label7.Text = "Listado de Biometricos";
            // 
            // cbBiometricos
            // 
            this.cbBiometricos.BackColor = System.Drawing.Color.White;
            this.cbBiometricos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBiometricos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBiometricos.FormattingEnabled = true;
            this.cbBiometricos.Location = new System.Drawing.Point(184, 25);
            this.cbBiometricos.Name = "cbBiometricos";
            this.cbBiometricos.Size = new System.Drawing.Size(226, 31);
            this.cbBiometricos.TabIndex = 1035;
            this.cbBiometricos.SelectedIndexChanged += new System.EventHandler(this.cbBiometricos_SelectedIndexChanged);
            // 
            // gc_Attlog
            // 
            this.gc_Attlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_Attlog.Location = new System.Drawing.Point(0, 161);
            this.gc_Attlog.MainView = this.gv_Attlog;
            this.gc_Attlog.Name = "gc_Attlog";
            this.gc_Attlog.Size = new System.Drawing.Size(1547, 378);
            this.gc_Attlog.TabIndex = 1039;
            this.gc_Attlog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Attlog});
            // 
            // gv_Attlog
            // 
            this.gv_Attlog.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Attlog.Appearance.Row.Options.UseFont = true;
            this.gv_Attlog.GridControl = this.gc_Attlog;
            this.gv_Attlog.Name = "gv_Attlog";
            this.gv_Attlog.OptionsBehavior.Editable = false;
            this.gv_Attlog.OptionsFind.AlwaysVisible = true;
            // 
            // checkBox_timePeriod
            // 
            this.checkBox_timePeriod.AutoSize = true;
            this.checkBox_timePeriod.Checked = true;
            this.checkBox_timePeriod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timePeriod.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.checkBox_timePeriod.Location = new System.Drawing.Point(578, 25);
            this.checkBox_timePeriod.Name = "checkBox_timePeriod";
            this.checkBox_timePeriod.Size = new System.Drawing.Size(83, 27);
            this.checkBox_timePeriod.TabIndex = 1044;
            this.checkBox_timePeriod.Text = "Periodo";
            this.checkBox_timePeriod.UseVisualStyleBackColor = true;
            this.checkBox_timePeriod.CheckedChanged += new System.EventHandler(this.checkBox_timePeriod_CheckedChanged);
            // 
            // stime_log
            // 
            this.stime_log.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.stime_log.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.stime_log.Location = new System.Drawing.Point(728, 25);
            this.stime_log.Name = "stime_log";
            this.stime_log.Size = new System.Drawing.Size(288, 29);
            this.stime_log.TabIndex = 1042;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label15.Location = new System.Drawing.Point(662, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 23);
            this.label15.TabIndex = 1040;
            this.label15.Text = "Desde:";
            // 
            // etime_log
            // 
            this.etime_log.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.etime_log.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.etime_log.Location = new System.Drawing.Point(1092, 25);
            this.etime_log.Name = "etime_log";
            this.etime_log.Size = new System.Drawing.Size(288, 29);
            this.etime_log.TabIndex = 1043;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label16.Location = new System.Drawing.Point(1032, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 23);
            this.label16.TabIndex = 1041;
            this.label16.Text = "Hasta:";
            // 
            // btn_readAttLog
            // 
            this.btn_readAttLog.BackColor = System.Drawing.Color.White;
            this.btn_readAttLog.Enabled = false;
            this.btn_readAttLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_readAttLog.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btn_readAttLog.Image = global::Biometricos.Properties.Resources.accounting_50px;
            this.btn_readAttLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_readAttLog.Location = new System.Drawing.Point(578, 71);
            this.btn_readAttLog.Name = "btn_readAttLog";
            this.btn_readAttLog.Size = new System.Drawing.Size(71, 61);
            this.btn_readAttLog.TabIndex = 1045;
            this.btn_readAttLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_readAttLog.UseVisualStyleBackColor = false;
            this.btn_readAttLog.Click += new System.EventHandler(this.btn_readAttLog_Click);
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(337, 2);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(252, 17);
            this.lbSysOutputInfo.TabIndex = 1046;
            this.lbSysOutputInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1048;
            this.label2.Text = "Checadas Biometrico";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblStatus.Location = new System.Drawing.Point(0, 547);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatus.Size = new System.Drawing.Size(1548, 35);
            this.lblStatus.TabIndex = 1049;
            this.lblStatus.Text = "label3";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblStatus.Visible = false;
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceInfo.Location = new System.Drawing.Point(497, 549);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(236, 25);
            this.lblDeviceInfo.TabIndex = 1050;
            this.lblDeviceInfo.Text = "Device Info : --";
            this.lblDeviceInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1402, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1052;
            this.label3.Text = "Checadas BD";
            // 
            // btnBD
            // 
            this.btnBD.BackColor = System.Drawing.Color.White;
            this.btnBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBD.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnBD.Image = global::Biometricos.Properties.Resources.Database_View_50px;
            this.btnBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBD.Location = new System.Drawing.Point(1413, 71);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(71, 61);
            this.btnBD.TabIndex = 1051;
            this.btnBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBD.UseVisualStyleBackColor = false;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.tbBuscar.Location = new System.Drawing.Point(1149, 103);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(243, 29);
            this.tbBuscar.TabIndex = 1053;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label1.Location = new System.Drawing.Point(869, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 1054;
            this.label1.Text = "Buscar Nombre o Num. de Credencial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1056;
            this.label4.Text = "Borrar Checadas";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(725, 71);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(71, 61);
            this.btnBorrar.TabIndex = 1055;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 1058;
            this.label5.Text = "Exportar Para SAPyN";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Enabled = false;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(31, 71);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 61);
            this.btnExcel.TabIndex = 1057;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(611, 5);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(252, 17);
            this.lbRTOutputInfo.TabIndex = 1059;
            this.lbRTOutputInfo.Visible = false;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1548, 582);
            this.Controls.Add(this.lbRTOutputInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.lblDeviceInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSysOutputInfo);
            this.Controls.Add(this.btn_readAttLog);
            this.Controls.Add(this.checkBox_timePeriod);
            this.Controls.Add(this.stime_log);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.etime_log);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gc_Attlog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBiometricos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbBiometricos;
        private System.Windows.Forms.CheckBox checkBox_timePeriod;
        private System.Windows.Forms.DateTimePicker stime_log;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker etime_log;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_readAttLog;
        public System.Windows.Forms.ListBox lbSysOutputInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBD;
        public DevExpress.XtraGrid.GridControl gc_Attlog;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_Attlog;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
    }
}