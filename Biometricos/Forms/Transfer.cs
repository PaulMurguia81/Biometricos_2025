using Biometricos.Clases;
using Biometricos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biometricos.Forms
{
    public partial class Transfer : Form
    {
        private Form1 _Transfer;
        public BD bd = new BD();
        E_Biometricos obj = new E_Biometricos();
        E_Biometricos obj1 = new E_Biometricos();
        public SDKHelper SDK = new SDKHelper();
        string id_bio, IP,IP1;
        public zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();
        DataTable dt;
        DataView dv;

        public Transfer(Form1 Parent)
        {
            InitializeComponent();
            _Transfer = Parent;

            SDK.biometricTypes.Add("General");
            SDK.biometricTypes.Add("Huellas");
            SDK.biometricTypes.Add("Face");
            SDK.biometricTypes.Add("Voiceprint");
            SDK.biometricTypes.Add("Iris");
            SDK.biometricTypes.Add("Retina");
            SDK.biometricTypes.Add("Palm prints");
            SDK.biometricTypes.Add("FingerVein");
            SDK.biometricTypes.Add("Palmas");
            SDK.biometricTypes.Add("Rostro");

            dt = new DataTable();
            dt.Columns.Add("Num_Credencial");
            dt.Columns.Add("Habilitado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("NoTarjeta");
            dt.Columns.Add("Password");
            dt.Columns.Add("Dedo");
            dt.Columns.Add("Flag");
            dt.Columns.Add("Huella");
            dt.Columns.Add("Privilegio");
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            cargarCombobox1();
        }

        public void cargarCombobox()
        {
            DataTable dt = bd.D_ListarBiometricos();
            cbBiometricos.DisplayMember = "descripcion";
            cbBiometricos.ValueMember = "id_biometrico";
            cbBiometricos.DataSource = dt;
        }

        public void cargarCombobox1()
        {
            DataTable dt = bd.D_ListarBiometricos();
            cbBiometricos1.DisplayMember = "descripcion";
            cbBiometricos1.ValueMember = "id_biometrico";
            cbBiometricos1.DataSource = dt;
        }

        private void BiometAObjeto()
        {
            obj.id_biometrico = (int)cbBiometricos.SelectedValue;
        }

        private void BiometAObjeto1()
        {
            obj1.id_biometrico = (int)cbBiometricos1.SelectedValue;
        }

        private void cbBiometricos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiometAObjeto();
            if (cbBiometricos.SelectedIndex == -1)
                id_bio = string.Empty;
            else
                IP = bd.D_ObtenerIP(obj);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int ret = SDK.sta_ConnectTCP(lbSysOutputInfo, IP, "4370", "0");
            if (SDK.GetConnectState())
            {
                SDK.sta_getBiometricType();
            }

            if (ret == 1)
            {
                //descargarUsuarios();
                descargarHuellas();
                fillDataTable();
                dv = new DataView(dt);
                populateListView(dv);
                btnConnect.Text = "Desconectar";
                btnConnect.Image = Resources.connected_25px;
                btnConnect.Refresh();
                cbBiometricos.Enabled = false;                
            }
            else if (ret == -2)
            {
                //SDK.sta_RemoveAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo, obj.id_biometrico);
                btnConnect.Text = "Conectar";
                btnConnect.Image = Resources.disconnected_25px;
                btnConnect.Refresh();
                axCZKEM1.Disconnect();
                lbSysOutputInfo.Items.Clear();
                cbBiometricos.Enabled = true;
                lstUsers.Items.Clear();
                lvUserInfo.Items.Clear();
                lstBiometric.Items.Clear();
                lvUserInfo.DataBindings.Clear();
            }
            Cursor = Cursors.Default;
        }

        public void descargarUsuarios()
        {
            Cursor = Cursors.WaitCursor;
            if (SDK == null) return;

            if (SDK.GetConnectState())
            {
                cmbBiometricType.Items.Clear();
                for (int i = 0; i < SDK.biometricType.Length; i++)
                {
                    if (SDK.biometricType[i] == '1')
                    {
                        cmbBiometricType.Items.Add(new SDKHelper.BioType() { name = SDK.biometricTypes[i], value = i });
                    }
                }
                SDK.employeeList = SDK.sta_getEmployees();

                lstUsers.Items.Clear();
                lstUsers.BeginUpdate();
                foreach (SDKHelper.Employee employee in SDK.employeeList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = employee.pin;
                    item.SubItems.Add(employee.name);
                    item.SubItems.Add(employee.password);
                    item.SubItems.Add(employee.privilege.ToString());
                    item.SubItems.Add(employee.cardNumber);
                    lstUsers.Items.Add(item);
                }
                lstUsers.EndUpdate();

                PrgSTA.Value = 100;
                lbSysOutputInfo.Items.Add("Download successfully");
            }
            Cursor = Cursors.Default;
        }

        public void descargarHuellas()
        {
           System.Windows.Forms.ListView lv = new System.Windows.Forms.ListView();
           
            //lvUserInfo.Items.Count();
            lvUserInfo.Items.Clear();           
            Cursor = Cursors.WaitCursor;
            int ret = SDK.sta_GetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo);
            Cursor = Cursors.Default;
        }

        public void fillDataTable()
        {
            foreach (ListViewItem item in lvUserInfo.Items)
            {
                dt.Rows.Add(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text,
                    item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text);
            }
        }

        private void btnTransferHuellas_Click(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked)
            {
                pasarTodasHuellas();

                cbSelectAll.Checked = false;
            }
            else
            {
                pasarHuellas();
                tbBuscar.Text = "";
                tbBuscar.Focus();
            }
        }

        private void pasarTodasHuellas()
        {
            foreach (ListViewItem r in lvUserInfo.Items)
            {
                lvUserInfo2.Items.Add((ListViewItem)r.Clone());
                lvUserInfo.Items.Remove(r);
            }
        }

        private void pasarHuellas()
        {
            foreach (ListViewItem r in lvUserInfo.SelectedItems)
            {
                lvUserInfo2.Items.Add((ListViewItem)r.Clone());
                lvUserInfo.Items.Remove(r);
            }
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked)
            {
                this.lvUserInfo.Items.Cast<ListViewItem>()
                .ToList().ForEach(item =>
                {
                    item.BackColor = ColorTranslator.FromHtml("#0x3399FF");
                    item.ForeColor = Color.White;
                });
            }
            else
            {
                this.lvUserInfo.Items.Cast<ListViewItem>()
                   .ToList().ForEach(item =>
                   {
                       item.BackColor = Color.White;
                       item.ForeColor = Color.Black;
                   });
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))            
                dv.RowFilter = string.Format("Num_Credencial like '%{0}%'", tbBuscar.Text);            
            else            
                dv.RowFilter = string.Format("Nombre like '%{0}%'", tbBuscar.Text);
            
            populateListView(dv);
        }

        private void btnDownloadBio_Click(object sender, EventArgs e)
        {
            descargarPalmas();
        }

        public void descargarPalmas()
        {
            Cursor = Cursors.WaitCursor;
            int CountTemplate = 0;
            string strType = string.Empty;

            if (SDK == null) return;
            if (SDK.GetConnectState())
            {
                if (cmbBiometricType.SelectedItem != null)
                {
                    SDKHelper.BioType bioType = cmbBiometricType.SelectedItem as SDKHelper.BioType;
                    List<SDKHelper.BioTemplate> newTemplates = new List<SDKHelper.BioTemplate>();
                    newTemplates = SDK.sta_BatchGetBioTemplates(PrgSTA, bioType.value);
                    CountTemplate = newTemplates.Count;
                    lstBiometric.Items.Clear();

                    lstBiometric.BeginUpdate();
                    foreach (SDKHelper.BioTemplate template in newTemplates)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = template.pin;
                        item.SubItems.Add(template.valid_flag == 1 ? "Valid" : "Invalid");
                        item.SubItems.Add(template.is_duress == 0 ? "False" : "True");
                        strType = string.Empty;
                        switch (template.bio_type)
                        {
                            case 0:
                                strType = "General";
                                break;
                            case 1:
                                strType = "FP";
                                break;
                            case 2:
                                strType = "Face";
                                break;
                            case 7:
                                strType = "FingerVein";
                                break;
                            case 8:
                                strType = "Palm";
                                break;
                            default:
                                break;
                        }
                        item.SubItems.Add(strType);
                        item.SubItems.Add(template.version);
                        item.SubItems.Add(template.data_format == 0 ? "ZK" : "Other");
                        item.SubItems.Add(template.template_no.ToString());
                        item.SubItems.Add(template.template_no_index.ToString());
                        item.SubItems.Add(template.template_data);

                        lstBiometric.Items.Add(item);
                    }
                    lstBiometric.EndUpdate();
                    SDK.bioTemplateList.AddRange(newTemplates);
                    PrgSTA.Value = 100;
                    lbSysOutputInfo.Items.Add("Downlaod  " + strType + " : " + CountTemplate);
                    lbSysOutputInfo.Items.Add("Download successfully");
                }
            }
            Cursor = Cursors.Default;
        }

        private void tbBuscarPalmas_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarPalmas.Text != "")
            {
                for (int i = lstBiometric.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstBiometric.Items[i];
                    if (item.Text.ToLower().Contains(tbBuscarPalmas.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Control;
                        item.ForeColor = SystemColors.InfoText;
                    }
                    else
                    {
                        lstBiometric.Items.Remove(item);
                    }
                }
                if (lstBiometric.SelectedItems.Count == 1)
                {
                    lstBiometric.Focus();
                }
            }
            else
            {
                descargarPalmas();
            }
        }

        private void cbSelecPalms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelecPalms.Checked)
            {
                this.lstBiometric.Items.Cast<ListViewItem>()
                .ToList().ForEach(item =>
                {

                    item.BackColor = ColorTranslator.FromHtml("#0x3399FF");
                    item.ForeColor = Color.White;
                });
            }
            else
            {
                this.lstBiometric.Items.Cast<ListViewItem>()
                   .ToList().ForEach(item =>
                   {

                       item.BackColor = Color.White;
                       item.ForeColor = Color.Black;
                   });
            }
        }

        private void btnTransferPalmas_Click(object sender, EventArgs e)
        {
            if (cbSelecPalms.Checked)
            {
                pasarTodasPalmas();
                cbSelecPalms.Checked = false;
            }
            else
                pasarPalmas();
        }

        private void pasarTodasPalmas()
        {
            foreach (ListViewItem r in lstBiometric.Items)
            {
                lstBiometric2.Items.Add((ListViewItem)r.Clone());
                lstBiometric.Items.Remove(r);
            }
        }

        private void pasarPalmas()
        {
            foreach (ListViewItem r in lstBiometric.SelectedItems)
            {
                lstBiometric2.Items.Add((ListViewItem)r.Clone());
                lstBiometric.Items.Remove(r);
            }
        }

        private void btnConnectUP_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = SDK.sta_ConnectTCP2(lbSysOutputInfo, IP1, "4370", "0");
            if (ret == 1)
            {
                SDK.sta_getBiometricType();
                btnConnectUP.Text = "Desconectar";
                btnConnectUP.Refresh();
                cbBiometricos1.Enabled = false;
                btnConnect.Image = Resources.connected_25px;
            }
            else if (ret == -2)
            {
                btnConnectUP.Text = "Conectar";
                btnConnectUP.Image = Resources.disconnected_25px;
                btnConnectUP.Refresh();
                axCZKEM1.Disconnect();
                lbSysOutputInfo.Items.Clear();
                cbBiometricos1.Enabled = true;
            }
            Cursor = Cursors.Default;
        }

        private void btnUploadUserInfo_Click(object sender, EventArgs e)
        {
            if (lvUserInfo2.Items.Count > 0)
                subirHuellas();

            if (lstBiometric2.Items.Count > 0)
                subirPalmas();

            DialogResult dr = MessageBox.Show("Transferencia completa", "Transferencia", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                cmbBiometricType.Text = "";
                btnConnectUP.PerformClick();
                //btnConnectUP_Click(sender, e);
                PrgSTA.Value = 0;
                tbBuscarPalmas.Text = "";
                tbBuscar.Text = "";
            }
        }

        private void subirHuellas()
        {
            Cursor = Cursors.WaitCursor;
            SDK.sta_batch_SetAllUserFPInfo(lbSysOutputInfo, PrgSTA, lvUserInfo2);
            //btnConnectUP.PerformClick();
            Cursor = Cursors.Default;
        }

        private void subirPalmas()
        {
            Cursor = Cursors.WaitCursor;
            if (SDK != null && SDK.GetConnectState())
            {
                string message = string.Empty;
                SDK.sta_setBioTemplates(SDK.bioTemplateList, out message);
                if (!IsNullOrWhiteSpace(message))
                {
                    lbSysOutputInfo.Items.Add(message);
                }
                else
                {
                    PrgSTA.Value = 100;
                    lbSysOutputInfo.Items.Add("Upload successfully");
                }
            }
            Cursor = Cursors.Default;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsWhiteSpace(value[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvUserInfo2.Items.Clear();
            lstBiometric2.Items.Clear();
            //btnConnectUP_Click(sender, e);
        }

        private void cbBiometricos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiometAObjeto1();
            if (cbBiometricos1.SelectedIndex == -1)
                id_bio = string.Empty;
            else
                IP1 = bd.D_ObtenerIP(obj1);
        }

        public void populateListView(DataView dv)
        {
            lvUserInfo.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvUserInfo.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                    row[4].ToString(),row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() }));
            }
        }
    }
}
