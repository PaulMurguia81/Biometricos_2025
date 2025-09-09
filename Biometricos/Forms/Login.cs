using Biometricos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

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
    }
}
