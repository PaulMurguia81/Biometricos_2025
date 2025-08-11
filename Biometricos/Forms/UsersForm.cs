using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometricos.Forms
{
    public delegate void MessageEvent(string message);
    public partial class UsersForm : Form
    {
        public UsersForm(Form1 Parent)
        {
            InitializeComponent();
            UserMng = Parent;
        }

        private Form1 UserMng;
    }

}
