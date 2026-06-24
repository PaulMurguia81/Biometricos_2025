namespace Biometricos.Forms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.cbBiometricos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            this.PrgSTA = new System.Windows.Forms.ProgressBar();
            this.lvUserInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFingerIndex = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbPrivilegio = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNIC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbMaterno = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.picFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbFlag = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmpleado)).BeginInit();
            this.SuspendLayout();
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
            this.cbBiometricos.TabIndex = 897;
            this.cbBiometricos.SelectedIndexChanged += new System.EventHandler(this.cbBiometricos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 898;
            this.label7.Text = "Listado de Biometricos";
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(559, 2);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(252, 17);
            this.lbSysOutputInfo.TabIndex = 1028;
            this.lbSysOutputInfo.Visible = false;
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(825, 2);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(252, 17);
            this.lbRTOutputInfo.TabIndex = 1029;
            this.lbRTOutputInfo.Visible = false;
            // 
            // PrgSTA
            // 
            this.PrgSTA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrgSTA.Location = new System.Drawing.Point(0, 559);
            this.PrgSTA.Name = "PrgSTA";
            this.PrgSTA.Size = new System.Drawing.Size(1211, 23);
            this.PrgSTA.TabIndex = 1030;
            // 
            // lvUserInfo
            // 
            this.lvUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvUserInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUserInfo.FullRowSelect = true;
            this.lvUserInfo.GridLines = true;
            this.lvUserInfo.HideSelection = false;
            this.lvUserInfo.LabelEdit = true;
            this.lvUserInfo.Location = new System.Drawing.Point(0, 181);
            this.lvUserInfo.Name = "lvUserInfo";
            this.lvUserInfo.Size = new System.Drawing.Size(1211, 372);
            this.lvUserInfo.TabIndex = 1031;
            this.lvUserInfo.UseCompatibleStateImageBehavior = false;
            this.lvUserInfo.View = System.Windows.Forms.View.Details;
            this.lvUserInfo.Click += new System.EventHandler(this.lvUserInfo_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Credencial";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Habilitado";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NoTarjeta";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contraseña";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dedo";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Flag";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Huella";
            this.columnHeader9.Width = 600;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Rol";
            this.columnHeader10.Width = 100;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBuscar.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(663, 86);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(213, 27);
            this.tbBuscar.TabIndex = 1032;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label1.Location = new System.Drawing.Point(415, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 1033;
            this.label1.Text = "Buscar por Apellido O Credencial:";
            // 
            // cbFingerIndex
            // 
            this.cbFingerIndex.BackColor = System.Drawing.Color.White;
            this.cbFingerIndex.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbFingerIndex.FormattingEnabled = true;
            this.cbFingerIndex.Items.AddRange(new object[] {
            "0 Meñique Izq.",
            "1 Anular Izq.",
            "2 Medio Izq.",
            "3 Indice Izq.",
            "4 Pulgar Izq.",
            "5 Pulgar Der.",
            "6 Indice Der.",
            "7 Medio Der.",
            "8 Anular Der.",
            "9 Meñique Der."});
            this.cbFingerIndex.Location = new System.Drawing.Point(938, 15);
            this.cbFingerIndex.Name = "cbFingerIndex";
            this.cbFingerIndex.Size = new System.Drawing.Size(139, 28);
            this.cbFingerIndex.TabIndex = 962;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label32.Location = new System.Drawing.Point(886, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 20);
            this.label32.TabIndex = 968;
            this.label32.Text = "Dedo:";
            // 
            // cbPrivilegio
            // 
            this.cbPrivilegio.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbPrivilegio.FormattingEnabled = true;
            this.cbPrivilegio.Items.AddRange(new object[] {
            "0 - Usuario Normal",
            "3 - Administrador"});
            this.cbPrivilegio.Location = new System.Drawing.Point(1132, 15);
            this.cbPrivilegio.Name = "cbPrivilegio";
            this.cbPrivilegio.Size = new System.Drawing.Size(139, 28);
            this.cbPrivilegio.TabIndex = 960;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbNombre.Location = new System.Drawing.Point(275, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(149, 26);
            this.tbNombre.TabIndex = 959;
            // 
            // tbNIC
            // 
            this.tbNIC.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNIC.Location = new System.Drawing.Point(63, 17);
            this.tbNIC.Name = "tbNIC";
            this.tbNIC.Size = new System.Drawing.Size(133, 29);
            this.tbNIC.TabIndex = 958;
            this.tbNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNIC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNIC_KeyDown);
            this.tbNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNIC_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label11.Location = new System.Drawing.Point(1083, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 957;
            this.label11.Text = "Rol:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label12.Location = new System.Drawing.Point(208, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 956;
            this.label12.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label13.Location = new System.Drawing.Point(11, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 20);
            this.label13.TabIndex = 955;
            this.label13.Text = "NIC:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label24.Location = new System.Drawing.Point(437, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 20);
            this.label24.TabIndex = 970;
            this.label24.Text = "Paterno:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label25.Location = new System.Drawing.Point(651, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 20);
            this.label25.TabIndex = 972;
            this.label25.Text = "Materno:";
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbApellido.Location = new System.Drawing.Point(496, 15);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(149, 26);
            this.tbApellido.TabIndex = 969;
            // 
            // tbMaterno
            // 
            this.tbMaterno.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbMaterno.Location = new System.Drawing.Point(718, 15);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.Size = new System.Drawing.Size(149, 26);
            this.tbMaterno.TabIndex = 971;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1203, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 35);
            this.button3.TabIndex = 995;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsuario.BackColor = System.Drawing.Color.White;
            this.gbUsuario.Controls.Add(this.btnBorrar);
            this.gbUsuario.Controls.Add(this.picFotoEmpleado);
            this.gbUsuario.Controls.Add(this.btnEditarUsuario);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Controls.Add(this.tbBuscar);
            this.gbUsuario.Controls.Add(this.cbFingerIndex);
            this.gbUsuario.Controls.Add(this.label32);
            this.gbUsuario.Controls.Add(this.cbPrivilegio);
            this.gbUsuario.Controls.Add(this.tbNombre);
            this.gbUsuario.Controls.Add(this.tbNIC);
            this.gbUsuario.Controls.Add(this.label11);
            this.gbUsuario.Controls.Add(this.label12);
            this.gbUsuario.Controls.Add(this.label13);
            this.gbUsuario.Controls.Add(this.button3);
            this.gbUsuario.Controls.Add(this.label24);
            this.gbUsuario.Controls.Add(this.btnGuardar);
            this.gbUsuario.Controls.Add(this.label25);
            this.gbUsuario.Controls.Add(this.btnCancelar);
            this.gbUsuario.Controls.Add(this.tbApellido);
            this.gbUsuario.Controls.Add(this.tbMaterno);
            this.gbUsuario.Location = new System.Drawing.Point(0, 62);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(1211, 116);
            this.gbUsuario.TabIndex = 1034;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(354, 69);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 41);
            this.btnBorrar.TabIndex = 1035;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // picFotoEmpleado
            // 
            this.picFotoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoEmpleado.InitialImage = global::Biometricos.Properties.Resources.noImage;
            this.picFotoEmpleado.Location = new System.Drawing.Point(1338, 11);
            this.picFotoEmpleado.Name = "picFotoEmpleado";
            this.picFotoEmpleado.Size = new System.Drawing.Size(115, 98);
            this.picFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoEmpleado.TabIndex = 1034;
            this.picFotoEmpleado.TabStop = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.White;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.Image")));
            this.btnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUsuario.Location = new System.Drawing.Point(241, 69);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(107, 41);
            this.btnEditarUsuario.TabIndex = 1000;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(15, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 41);
            this.btnGuardar.TabIndex = 964;
            this.btnGuardar.Text = "Enrolar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(128, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 41);
            this.btnCancelar.TabIndex = 965;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnConnect.TabIndex = 899;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbFlag
            // 
            this.cbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlag.FormattingEnabled = true;
            this.cbFlag.Items.AddRange(new object[] {
            "0",
            "1",
            "3"});
            this.cbFlag.Location = new System.Drawing.Point(453, 2);
            this.cbFlag.Name = "cbFlag";
            this.cbFlag.Size = new System.Drawing.Size(84, 21);
            this.cbFlag.TabIndex = 1035;
            this.cbFlag.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Enabled = false;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(600, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 54);
            this.btnExcel.TabIndex = 1058;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 582);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbFlag);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.lvUserInfo);
            this.Controls.Add(this.PrgSTA);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBiometricos);
            this.Controls.Add(this.lbRTOutputInfo);
            this.Controls.Add(this.lbSysOutputInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbBiometricos;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox lbSysOutputInfo;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
        private System.Windows.Forms.ProgressBar PrgSTA;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.ComboBox cbFingerIndex;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbPrivilegio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNIC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbMaterno;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox gbUsuario;
        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox picFotoEmpleado;
        private System.Windows.Forms.ComboBox cbFlag;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.ListView lvUserInfo;
        private System.Windows.Forms.Button btnExcel;
    }
}