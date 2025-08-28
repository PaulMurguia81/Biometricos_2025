namespace Biometricos.Forms
{
    partial class Poleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poleo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbBiomet = new System.Windows.Forms.GroupBox();
            this.checkBox_timePeriod = new System.Windows.Forms.CheckBox();
            this.stime_log = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.etime_log = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.btnPoleoInd = new System.Windows.Forms.Button();
            this.btnPoleoG = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbBiomet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1545, 482);
            this.dataGridView1.TabIndex = 1031;
            // 
            // gbBiomet
            // 
            this.gbBiomet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.gbBiomet.Controls.Add(this.lbSysOutputInfo);
            this.gbBiomet.Controls.Add(this.checkBox_timePeriod);
            this.gbBiomet.Controls.Add(this.stime_log);
            this.gbBiomet.Controls.Add(this.label15);
            this.gbBiomet.Controls.Add(this.etime_log);
            this.gbBiomet.Controls.Add(this.label16);
            this.gbBiomet.Controls.Add(this.label46);
            this.gbBiomet.Controls.Add(this.btnPoleoInd);
            this.gbBiomet.Controls.Add(this.btnPoleoG);
            this.gbBiomet.Controls.Add(this.label30);
            this.gbBiomet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBiomet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBiomet.Location = new System.Drawing.Point(0, 0);
            this.gbBiomet.Name = "gbBiomet";
            this.gbBiomet.Size = new System.Drawing.Size(1545, 148);
            this.gbBiomet.TabIndex = 1030;
            this.gbBiomet.TabStop = false;
            // 
            // checkBox_timePeriod
            // 
            this.checkBox_timePeriod.AutoSize = true;
            this.checkBox_timePeriod.Checked = true;
            this.checkBox_timePeriod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timePeriod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_timePeriod.ForeColor = System.Drawing.Color.White;
            this.checkBox_timePeriod.Location = new System.Drawing.Point(305, 23);
            this.checkBox_timePeriod.Name = "checkBox_timePeriod";
            this.checkBox_timePeriod.Size = new System.Drawing.Size(87, 23);
            this.checkBox_timePeriod.TabIndex = 1049;
            this.checkBox_timePeriod.Text = "Periodo";
            this.checkBox_timePeriod.UseVisualStyleBackColor = true;
            // 
            // stime_log
            // 
            this.stime_log.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.stime_log.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.stime_log.Location = new System.Drawing.Point(484, 19);
            this.stime_log.Name = "stime_log";
            this.stime_log.Size = new System.Drawing.Size(288, 29);
            this.stime_log.TabIndex = 1047;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(417, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 1045;
            this.label15.Text = "Desde:";
            // 
            // etime_log
            // 
            this.etime_log.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.etime_log.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.etime_log.Location = new System.Drawing.Point(840, 19);
            this.etime_log.Name = "etime_log";
            this.etime_log.Size = new System.Drawing.Size(288, 29);
            this.etime_log.TabIndex = 1048;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(778, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 19);
            this.label16.TabIndex = 1046;
            this.label16.Text = "Hasta:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(145, 116);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(124, 19);
            this.label46.TabIndex = 977;
            this.label46.Text = "Polo Individual";
            // 
            // btnPoleoInd
            // 
            this.btnPoleoInd.BackColor = System.Drawing.Color.White;
            this.btnPoleoInd.Image = ((System.Drawing.Image)(resources.GetObject("btnPoleoInd.Image")));
            this.btnPoleoInd.Location = new System.Drawing.Point(171, 54);
            this.btnPoleoInd.Name = "btnPoleoInd";
            this.btnPoleoInd.Size = new System.Drawing.Size(71, 61);
            this.btnPoleoInd.TabIndex = 976;
            this.btnPoleoInd.UseVisualStyleBackColor = false;
            // 
            // btnPoleoG
            // 
            this.btnPoleoG.BackColor = System.Drawing.Color.White;
            this.btnPoleoG.Image = ((System.Drawing.Image)(resources.GetObject("btnPoleoG.Image")));
            this.btnPoleoG.Location = new System.Drawing.Point(36, 54);
            this.btnPoleoG.Name = "btnPoleoG";
            this.btnPoleoG.Size = new System.Drawing.Size(71, 61);
            this.btnPoleoG.TabIndex = 963;
            this.btnPoleoG.UseVisualStyleBackColor = false;
            this.btnPoleoG.Click += new System.EventHandler(this.btnPoleoG_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(13, 116);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 19);
            this.label30.TabIndex = 963;
            this.label30.Text = "Poleo Global";
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(17, 12);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(252, 17);
            this.lbSysOutputInfo.TabIndex = 1050;
            this.lbSysOutputInfo.Visible = false;
            // 
            // Poleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1545, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbBiomet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Poleo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poleo";
            this.Load += new System.EventHandler(this.Poleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbBiomet.ResumeLayout(false);
            this.gbBiomet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbBiomet;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnPoleoInd;
        private System.Windows.Forms.Button btnPoleoG;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox_timePeriod;
        private System.Windows.Forms.DateTimePicker stime_log;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker etime_log;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ListBox lbSysOutputInfo;
    }
}