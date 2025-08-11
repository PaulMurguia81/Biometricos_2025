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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBiometricos_Click(object sender, EventArgs e)
        {
            pnlTerminal.Visible = true;
            pnlUser.Visible = false;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlTerminal.Dock = DockStyle.Fill;

            if (pnlTerminal.Controls.Count == 0)
            {
                TerminalForm terminalForm = new TerminalForm(this);
                terminalForm.TopLevel = false;
                this.pnlTerminal.Controls.Add(terminalForm);
                terminalForm.btnClicked = true;
                terminalForm.Show();
                terminalForm.Dock = DockStyle.Fill;  
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlTerminal.Visible = false;
            pnlUser.Visible = true;
            pnlPersonalize.Visible = false;
            pnlData.Visible = false;
            pnlAccess.Visible = false;
            pnlOther.Visible = false;
            pnlUser.Dock = DockStyle.Fill;

            if (pnlUser.Controls.Count == 0)
            {
                UsersForm UserMng = new UsersForm(this);
                UserMng.TopLevel = false;
                this.pnlUser.Controls.Add(UserMng);
                UserMng.Show();
                UserMng.Dock = DockStyle.Fill;
            }
        }
    }
}
