using Biometricos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Biometricos.Forms
{
    public partial class Login : Form
    {
        public BD bd = new BD();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        public void Entrar()
        {
            if (string.IsNullOrWhiteSpace(tbUser.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Debe capturar usuario y contraseña", "Error");
                return;
            }

            try
            {
                if (bd.buscarEmpleado(tbUser.Text.Trim().ToString(), tbPassword.Text.Trim().ToString()))
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    SetUserCredentials();
                }
                else
                {
                    MessageBox.Show("Usuario no Autorizado o Datos Capturados Incorrectos", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUser.Text = "";
                    tbPassword.Text = "";
                    tbUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Intentar Logearse " + ex);
            }
        }

        public void SetUserCredentials()
        {
            
            if (cbRecordarUsuario.Checked)
            {
                Properties.Settings.Default.Username = tbUser.Text;
                Properties.Settings.Default.RememberMe = cbRecordarUsuario.Checked;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                tbUser.Text= Properties.Settings.Default.Username ;
                cbRecordarUsuario.Checked = Properties.Settings.Default.RememberMe;
                tbPassword.Select();
            }
            else
            {
                tbUser.Text = "";
                cbRecordarUsuario.Checked = false;
                tbUser.Focus();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)            
                Entrar();            
        }
    }
}
