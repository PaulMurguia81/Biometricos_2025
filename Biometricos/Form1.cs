using Biometricos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometricos
{
    public partial class Form1 : Form
    {
        TerminalForm terminalForm;
        UsersForm UserMng;
        Consulta consulta;
        Poleo poleo;
        Transfer transfer;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            btnUsuarios.Location = new Point(0, 69);
            btnConsultas.Location = new Point(0, 130);
            btnTransfer.Location= new Point(0, 191);
            btnBiometricos.Focus();
        }

        #region MENU DESPLEGABLE
        public void customizeDesign()
        {
            pnlSubMenu.Visible=false;
        }
        
        public void hideSubMenu()
        {
            if (pnlSubMenu.Visible == true)
                pnlSubMenu.Visible = false;
        }

        public void showSubMenu1(Panel submenu)
        {
            if (submenu.Visible == true)
            {
                hideSubMenu();
                submenu.Visible = false;
                submenu.Size = new Size(0, 0);
                btnUsuarios.Location = new Point(0, 69);
                btnConsultas.Location = new Point(0, 130);
                btnTransfer.Location = new Point(0, 191);
            }
        }

        public void showSubMenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                hideSubMenu();
                submenu.Visible = true;
                submenu.Size=new Size(200,96);
                btnUsuarios.Location = new Point(3, 171);
                btnConsultas.Location = new Point(3,242);
                btnTransfer.Location = new Point(3, 314);
            }
            else
            {
                submenu.Visible = false;
                submenu.Size = new Size(0,0);
                btnUsuarios.Location = new Point(0, 69);
                btnConsultas.Location = new Point(0, 130);
                btnTransfer.Location= new Point(0, 191);        
            }                
        }
        
        #endregion

        private void btnBiometricos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenu);
        }
 
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu1(pnlSubMenu);
            pnlTerminal.Visible = false;
            pnlUser.Visible = true;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlUser.Dock = DockStyle.Fill;

            if (pnlUser.Controls.Count == 0)
            {
                UserMng = new UsersForm(this);
                UserMng.TopLevel = false;
                this.pnlUser.Controls.Add(UserMng);
                UserMng.Show();
                UserMng.Dock = DockStyle.Fill;
            }
            else
            {
                UserMng.cargarCombobox();
                UserMng.gbUsuario.Visible = false;
                if (UserMng.lvUserInfo.Items.Count>0)
                    UserMng.btnConnect.PerformClick();
                
                UserMng.Limpiar();
            }
        }

        private void btnConsultas_Click_1(object sender, EventArgs e)
        {
            showSubMenu1(pnlSubMenu);
            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = true;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlPersonalize.Dock = DockStyle.Fill;

            if (pnlPersonalize.Controls.Count == 0)
            {
                consulta = new Consulta(this);
                consulta.TopLevel = false;
                this.pnlPersonalize.Controls.Add(consulta);
                consulta.Show();
                consulta.Dock = DockStyle.Fill;
            }
            else
            {
                consulta.cargarCombobox();
                if (consulta.gv_Attlog.RowCount > 0)
                    consulta.btnConnect.PerformClick();
            }
        }

        private void btnAddBiometricos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenu);
            pnlTerminal.Visible = true;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlTerminal.Dock = DockStyle.Fill;

            if (pnlTerminal.Controls.Count == 0)
            {
                terminalForm = new TerminalForm(this);
                terminalForm.TopLevel = false;
                this.pnlTerminal.Controls.Add(terminalForm);
                terminalForm.btnClicked = true;
                terminalForm.Show();
                terminalForm.Dock = DockStyle.Fill;
            }
            else
            {
                terminalForm.Limpiar();
                terminalForm.cargarGrid();
            }
        }

        private void btnPoleo_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenu);
            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = true;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlData.Dock = DockStyle.Fill;

            if (pnlData.Controls.Count == 0)
            {
                poleo = new Poleo(this);
                poleo.TopLevel = false;
                this.pnlData.Controls.Add(poleo);
                poleo.Show();
                poleo.Dock = DockStyle.Fill;
                poleo.dataGridView1.CurrentCell = null;
            }
            else
            {
                
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            showSubMenu1(pnlSubMenu);
            pnlTerminal.Visible = false;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = true;
            pnlOther.Visible = false;
            pnlAccess.Dock = DockStyle.Fill;

            if (pnlAccess.Controls.Count == 0)
            {
                transfer = new Transfer(this);
                transfer.TopLevel = false;
                this.pnlAccess.Controls.Add(transfer);
                transfer.Show();
                transfer.Dock = DockStyle.Fill;
            }
            else
            {
                if (!transfer.cbBiometricos.Enabled)
                    transfer.btnConnect.PerformClick();
                
                if (!transfer.cbBiometricos1.Enabled)
                    transfer.btnConnectUP.PerformClick();

                transfer.lvUserInfo2.Items.Clear();
                transfer.lstBiometric2.Items.Clear();
                transfer.tbBuscar.Text = "";
                transfer.tbBuscarPalmas.Text = "";
            }
        }

        private void abrirControlBiometToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show(); // Show the form
            //this.WindowState = FormWindowState.Maximized; // Restore to normal state
            //notifyIcon1.Visible = false; // Hide the NotifyIcon
        }

        private void cerrarControlBiometToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide the form from the taskbar
            //notifyIcon1.Visible = true; // Show the NotifyIcon in the system tray
            //notifyIcon1.ShowBalloonTip(3000, "Aplicacion Minimizada", "La aplicacion esta trabajando en segundo plano.", ToolTipIcon.Info); // Optional: show a balloon tip
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide(); // Hide the form from the taskbar
            //    notifyIcon1.Visible = true; // Show the NotifyIcon in the system tray
            //    notifyIcon1.ShowBalloonTip(3000, "Aplicacion Minimizada", "La aplicacion esta trabajando en segundo plano.", ToolTipIcon.Info); // Optional: show a balloon tip
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aquí puedes limpiar recursos si es necesario
            Environment.Exit(0);
        }
    }
}
