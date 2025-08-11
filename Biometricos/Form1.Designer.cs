namespace Biometricos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMenuIzq = new System.Windows.Forms.Panel();
            this.btnBiometricos = new System.Windows.Forms.Button();
            this.pnlPersonalize = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.pnlAccess = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenuIzq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 105);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(916, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlMenuIzq
            // 
            this.pnlMenuIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(133)))), ((int)(((byte)(136)))));
            this.pnlMenuIzq.Controls.Add(this.btnUsuarios);
            this.pnlMenuIzq.Controls.Add(this.btnBiometricos);
            this.pnlMenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuIzq.Location = new System.Drawing.Point(0, 105);
            this.pnlMenuIzq.Name = "pnlMenuIzq";
            this.pnlMenuIzq.Size = new System.Drawing.Size(200, 541);
            this.pnlMenuIzq.TabIndex = 1;
            // 
            // btnBiometricos
            // 
            this.btnBiometricos.BackColor = System.Drawing.Color.Transparent;
            this.btnBiometricos.FlatAppearance.BorderSize = 0;
            this.btnBiometricos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiometricos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiometricos.ForeColor = System.Drawing.Color.White;
            this.btnBiometricos.Image = ((System.Drawing.Image)(resources.GetObject("btnBiometricos.Image")));
            this.btnBiometricos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiometricos.Location = new System.Drawing.Point(3, 6);
            this.btnBiometricos.Name = "btnBiometricos";
            this.btnBiometricos.Size = new System.Drawing.Size(194, 69);
            this.btnBiometricos.TabIndex = 0;
            this.btnBiometricos.Text = "             Biometricos";
            this.btnBiometricos.UseVisualStyleBackColor = false;
            this.btnBiometricos.Click += new System.EventHandler(this.btnBiometricos_Click);
            // 
            // pnlPersonalize
            // 
            this.pnlPersonalize.Location = new System.Drawing.Point(854, 111);
            this.pnlPersonalize.Name = "pnlPersonalize";
            this.pnlPersonalize.Size = new System.Drawing.Size(16, 17);
            this.pnlPersonalize.TabIndex = 9;
            // 
            // pnlUser
            // 
            this.pnlUser.Location = new System.Drawing.Point(839, 111);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(16, 17);
            this.pnlUser.TabIndex = 8;
            // 
            // pnlOther
            // 
            this.pnlOther.Location = new System.Drawing.Point(898, 111);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(16, 17);
            this.pnlOther.TabIndex = 12;
            // 
            // pnlAccess
            // 
            this.pnlAccess.Location = new System.Drawing.Point(883, 111);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(16, 17);
            this.pnlAccess.TabIndex = 11;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(868, 111);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(16, 17);
            this.pnlData.TabIndex = 10;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.BackColor = System.Drawing.Color.White;
            this.pnlTerminal.Location = new System.Drawing.Point(824, 111);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(16, 17);
            this.pnlTerminal.TabIndex = 7;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 81);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(194, 69);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "             Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 646);
            this.Controls.Add(this.pnlPersonalize);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlOther);
            this.Controls.Add(this.pnlAccess);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlTerminal);
            this.Controls.Add(this.pnlMenuIzq);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenuIzq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenuIzq;
        private System.Windows.Forms.Button btnBiometricos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPersonalize;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Panel pnlAccess;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.Button btnUsuarios;
    }
}

