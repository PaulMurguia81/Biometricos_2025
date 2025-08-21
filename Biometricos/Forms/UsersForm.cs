using Biometricos.Clases;
using Biometricos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biometricos.Forms
{
    public delegate void MessageEvent(string message);

    public partial class UsersForm : Form
    {
        #region VARIABLES GLOBALES
        public BD bd = new BD();
        private Form1 UserMng;
        public SDKHelper SDK = new SDKHelper();
        public zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();
        private bool isDeviceConnected = false;
        TerminalForm terminal;
        string id_bio,IP;
        E_Biometricos objEntidad = new E_Biometricos();
        E_Usuarios _Usuarios = new E_Usuarios();
        List<ListViewItem> masterlist;
        string ruta_fotos = @"\\192.9.7.51\Gafetes\fotos\";
        #endregion

        public UsersForm(Form1 Parent)
        {
            InitializeComponent();
            UserMng = Parent;
            masterlist = new List<ListViewItem>();
        }
        
        private void UsersForm_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            Cursor = Cursors.WaitCursor;
            SDK.sta_SetRTLogListBox(RealTimeEventListBox);
            Cursor = Cursors.Default;
            picFotoEmpleado.Image = Resources.noImage;
            cbFlag.SelectedIndex = 0;
            cbPrivilegio.SelectedIndex = 0;
            cbFingerIndex.SelectedIndex = 6;
        }

        public ListBox RealTimeEventListBox()
        {
            ListBox dtg = lbRTOutputInfo;
            return dtg;
        }

        public void cargarCombobox()
        {
            DataTable dt = bd.D_ListarBiometricos();
            cbBiometricos.DisplayMember = "descripcion";
            cbBiometricos.ValueMember = "id_biometrico";
            cbBiometricos.DataSource = dt;           
        }

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set { isDeviceConnected = value;

                if (isDeviceConnected)
                {
                    btnConnect.Text = "DesConectar";
                    btnConnect.Image = Resources.icons8_connected_50;
                    btnConnect.Refresh();
                }
                else
                {
                    btnConnect.Text = "Conectar";
                    btnConnect.Image = Resources.icons8_disconnected_50;
                    btnConnect.Refresh();
                    axCZKEM1.Disconnect();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = SDK.sta_ConnectTCP(lbSysOutputInfo, IP,"4370", "0");
            if (ret == 1)
            {
                masterlist.Clear();
                btnConnect.Text = "Desconectar";               
                btnConnect.Refresh();
                SDK.sta_GetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo);
                foreach (ListViewItem originalItem in lvUserInfo.Items)
                {
                    ListViewItem clonedItem = (ListViewItem)originalItem.Clone();
                    masterlist.Add(clonedItem);
                }
                gbUsuario.Visible = true;
                btnConnect.Image = Resources.connected_25px;
                tbNIC.Focus();
                cbBiometricos.Enabled = false;
            }
            else if (ret == -2)
            {
                btnConnect.Text = "Conectar";
                btnConnect.Image = Resources.disconnected_25px;
                btnConnect.Refresh();
                axCZKEM1.Disconnect();
                lvUserInfo.Items.Clear();
                Limpiar();
                gbUsuario.Visible=false;
                lbRTOutputInfo.Items.Clear();
                lbSysOutputInfo.Items.Clear();
                cbBiometricos.Enabled = true;
            }
            Cursor = Cursors.Default;
        }

        //private void DisplayItems()
        //{
        //    lvUserInfo.Items.Clear();
        //    foreach (ListViewItem item in masterlist.Where(lvi => lvi.SubItems[2].Text.ToLower().Contains(tbBuscar.Text.ToLower().Trim())))
        //    {
        //        lvUserInfo.Items.Add(item);
        //    }
        //}

        private void BiometAObjeto()
        {            
            objEntidad.id_biometrico =(int)cbBiometricos.SelectedValue;
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                lvUserInfo.Items.Clear();
                foreach (ListViewItem item in masterlist.Where(lvi => lvi.Text.ToLower().Contains(tbBuscar.Text.ToLower().Trim())))
                {
                    lvUserInfo.Items.Add(item);
                }
            }
            else
            {
                lvUserInfo.Items.Clear();
                foreach (ListViewItem item in masterlist.Where(lvi => lvi.SubItems[2].Text.ToLower().Contains(tbBuscar.Text.ToLower().Trim())))
                {
                    lvUserInfo.Items.Add(item);
                }
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            //DisplayItems();        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();   
        }

        public void Limpiar()
        {
            tbNIC.Text = ""; tbNombre.Text = ""; tbApellido.Text = ""; tbMaterno.Text = ""; /*picFotoEmpleado.Image = Resources.no_selfie_50px;*/
            tbNIC.Focus(); tbBuscar.Text = ""; picFotoEmpleado.Image = Resources.noImage;
        }

        private void tbNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarEmpleado();
                btnGuardar.Focus();
            }
        }       
       
        private void TextboxAObjeto()
        {
            //_Usuarios.NIC = tbNIC.Text.ToString();
            //objEntidad.id_biometrico = Convert.ToInt32(tbBiomet.Text.ToString());
            //objEntidad.ip_biometrico = tbIpbiomet.Text.Trim();
            //objEntidad.num_serie = 1;
            //objEntidad.municipio = cbMunicipio.Text.Trim();
            //objEntidad.ubicacion = tbUbicacion.Text.Trim();
            //objEntidad.status = "A";
            //objEntidad.descripcion = tbDescrip.Text.Trim();
            //objEntidad.status_inc = "A";
            
        }

        public void buscarEmpleado()
        {
            string empno="";
            _Usuarios.NIC = tbNIC.Text.ToString();
            DataTable dt = bd.D_BuscarEmp(_Usuarios);
            foreach (DataRow row in dt.Rows)
            {
                tbNombre.Text = row[3].ToString();
                tbApellido.Text = row[1].ToString();
                tbMaterno.Text = row[2].ToString();
                empno= row[0].ToString();
                string imagen = ruta_fotos + empno + ".jpg";
                if (File.Exists(imagen))
                    picFotoEmpleado.Image = Image.FromFile(imagen);
                else
                    picFotoEmpleado.Image = null;
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txtCardnumber=new System.Windows.Forms.TextBox();
            txtCardnumber.Text = "0000";
            System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
            txtPassword.Text = "1234";
            System.Windows.Forms.TextBox txtNombreCompleto = new System.Windows.Forms.TextBox();
            string nombre=tbNombre.Text.Trim();
            int posicionEspacio = nombre.IndexOf(' ');
            if (posicionEspacio >= 0)
            {
                string resultado = nombre.Substring(0, posicionEspacio);
                txtNombreCompleto.Text = tbApellido.Text.Trim() + " " + tbMaterno.Text.Trim() + " " + resultado.Trim();
            }
            else
                txtNombreCompleto.Text = tbApellido.Text.Trim() + " " + tbMaterno.Text.Trim() + " " + tbNombre.Text.Trim();

            if (tbNIC.Text!="")
            {
                SDK.sta_SetUserInfo(lbSysOutputInfo, tbNIC, txtNombreCompleto, cbPrivilegio, txtCardnumber, txtPassword);
               
                DialogResult dr = MessageBox.Show("Favor de registrar 3 veces la Huella en el dispositivo ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    SDK.sta_OnlineEnroll(lbSysOutputInfo, tbNIC, cbFingerIndex, cbFlag);
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        Thread.Sleep(6000);  // wait for a while
                        DialogResult dr1 =MessageBox.Show("Empleado Capturado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr1 == DialogResult.OK)
                            SDK.sta_GetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo);
                    }
                    finally
                    {
                        Limpiar();
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            else
                MessageBox.Show("Ingrese Numero de Credencial para Enrolar");
        }

        private void lvUserInfo_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvUserInfo.SelectedItems[0];
            tbNIC.Text = selectedItem.Text;
            buscarEmpleado();
        }

        private void tbNIC_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lvUserInfo.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvUserInfo.SelectedItems[0];
                System.Windows.Forms.ComboBox cbUserID2 = new System.Windows.Forms.ComboBox();
                cbUserID2.Text = selectedItem.Text;
                System.Windows.Forms.ComboBox cbBackupDE = new System.Windows.Forms.ComboBox();
                cbBackupDE.Text = "12";
                DialogResult dr = MessageBox.Show("Desea Borrar el Empleado seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (tbNIC.Text != "")
                    {
                        try
                        {
                            int result = SDK.sta_DeleteEnrollData(lbSysOutputInfo, cbUserID2, cbBackupDE);                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Empleado Borrado");
                        Limpiar();
                        SDK.sta_GetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo);
                    }
                }
            }
            else
                MessageBox.Show("Seleccione Empleado A Borrar");
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txtCardnumber = new System.Windows.Forms.TextBox();
            txtCardnumber.Text = "0000";
            System.Windows.Forms.TextBox txtPassword = new System.Windows.Forms.TextBox();
            txtPassword.Text = "1234";
            System.Windows.Forms.TextBox txtNombreCompleto = new System.Windows.Forms.TextBox();
            string nombre = tbNombre.Text.Trim();
            int posicionEspacio = nombre.IndexOf(' ');
            if (posicionEspacio >= 0)
            {
                string resultado = nombre.Substring(0, posicionEspacio);
                txtNombreCompleto.Text = tbApellido.Text.Trim() + " " + tbMaterno.Text.Trim() + " " + resultado.Trim();
            }
            else
                txtNombreCompleto.Text = tbApellido.Text.Trim() + " " + tbMaterno.Text.Trim() + " " + tbNombre.Text.Trim();

            if (tbNIC.Text != "")
            {
                try
                {
                    int result = SDK.sta_SetUserInfo(lbSysOutputInfo, tbNIC, txtNombreCompleto, cbPrivilegio, txtCardnumber, txtPassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Se Edito La Informacion Del Empleado Seleccionado ");
                Limpiar();
                SDK.sta_GetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo);
            }
            else
                MessageBox.Show("Seleccione Empleado Para Editar Su Informacion");
        }

        private void cbBiometricos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiometAObjeto();
            if (cbBiometricos.SelectedIndex == -1)
                id_bio = string.Empty;            
            else
                IP= bd.D_ObtenerIP(objEntidad);            
        }
    }
}
