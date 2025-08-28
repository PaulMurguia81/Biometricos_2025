using Biometricos.Clases;
using Biometricos.Properties;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors.Filtering.Templates;
using IBM.Data.DB2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biometricos.Clases.SDKHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Biometricos.Forms
{
    public partial class Consulta : Form
    {
        private Form1 _Consultas;
        public SDKHelper SDK = new SDKHelper();
        public BD bd = new BD();
        public zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();
        string id_bio, IP;
        E_Biometricos objEntidad = new E_Biometricos();
        E_Usuarios _Usuarios = new E_Usuarios();

        public Consulta(Form1 Parent)
        {
            InitializeComponent();
            _Consultas = Parent;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            SDK.sta_SetRTLogListBox(RealTimeEventListBox);
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

        private void checkBox_timePeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_timePeriod.Checked == true)
            {
                stime_log.Enabled = true;
                etime_log.Enabled = true;
                //btn_deloldlog.Enabled = true;
            }
            else
            {
                stime_log.Enabled = false;
                etime_log.Enabled = false;
                //btn_deloldlog.Enabled = false;
            }
        }

        private void btn_readAttLog_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string bio = (int)cbBiometricos.SelectedValue + " - " + cbBiometricos.GetItemText(cbBiometricos.SelectedItem);
            List<Employee> users = SDK.sta_getEmployees();
          
            if (checkBox_timePeriod.Checked == true)
            {
                //string fromTime = stime_log.Text.Trim().ToString();
                //string toTime = etime_log.Text.Trim().ToString();
                string fromTime = stime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "00:00:00";
                string toTime = etime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59"; 
                DataTable dt_periodLog = new DataTable("dt_periodLog");
                gv_Attlog.Columns.Clear();
                dt_periodLog.Columns.Add("Biometrico", Type.GetType("System.String"));
                dt_periodLog.Columns.Add("User ID", Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Verify Date", Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Verify Hour", Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Verify Type", Type.GetType("System.Int32"));
                dt_periodLog.Columns.Add("Verify State", Type.GetType("System.Int32"));
                dt_periodLog.Columns.Add("WorkCode", Type.GetType("System.Int32"));                
                                                
                SDK.sta_readLogByPeriod(lbSysOutputInfo, dt_periodLog, fromTime, toTime);
                
                var listaUsers = (from row in dt_periodLog.AsEnumerable()
                                    select new 
                                    {
                                        NIC = row["User ID"].ToString(),
                                        Fecha = row["Verify Date"].ToString(),
                                        Hora = row["Verify Hour"].ToString(),
                                        Tipo = int.Parse(row["Verify Type"].ToString()),
                                        State = int.Parse(row["Verify State"].ToString()),
                                        WorkCode = int.Parse(row["WorkCode"].ToString())
                                    }).ToList();


                var joined = (from list1 in users
                              join list2 in listaUsers
                              on list1.pin equals list2.NIC
                              where list1.pin == list2.NIC
                              orderby list2.Fecha descending
                              select new
                              {
                                  Biometrico = bio,
                                  Date = Convert.ToDateTime(list2.Fecha).ToString("MM-dd-yyyy"),
                                  Time = Convert.ToDateTime(list2.Hora).ToString("HH:mm:ss"),
                                  ID = list2.NIC,
                                  Nombre = list1.name,
                                  Index = "0",
                                  Action = "Verify ID",
                                  Status = "Success"
                              }).ToList();

                gc_Attlog.DataSource = joined;
                lblStatus.Visible = true;
                ShowStatusBar(gv_Attlog.RowCount + " registros encontrados!!", true);
            }
            else
            {
                DataTable dt_period = new DataTable("dt_period");
                gv_Attlog.Columns.Clear();
                dt_period.Columns.Add("User ID", System.Type.GetType("System.String"));
                dt_period.Columns.Add("Verify Date", System.Type.GetType("System.String"));
                dt_period.Columns.Add("Verify Hour", Type.GetType("System.String"));
                dt_period.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
                dt_period.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
                dt_period.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));

                SDK.sta_readAttLog(lbSysOutputInfo, dt_period);

                var listaUsers = (from row in dt_period.AsEnumerable()
                                  select new
                                  {
                                      NIC = row["User ID"].ToString(),
                                      Fecha = row["Verify Date"].ToString(),
                                      Hora = row["Verify Hour"].ToString(),
                                      Tipo = int.Parse(row["Verify Type"].ToString()),
                                      State = int.Parse(row["Verify State"].ToString()),
                                      WorkCode = int.Parse(row["WorkCode"].ToString())
                                  }).ToList();

                var joined = (from list1 in users
                              join list2 in listaUsers
                              on list1.pin equals list2.NIC
                              where list1.pin == list2.NIC
                              orderby list2.Fecha descending
                              select new
                              {
                                  Biometrico = bio,
                                  Date = Convert.ToDateTime(list2.Fecha).ToString("MM-dd-yyyy"),
                                  Time = Convert.ToDateTime(list2.Hora).ToString("HH:mm:ss"),
                                  ID = list2.NIC,
                                  Nombre = list1.name,
                                  Index = "0",
                                  Action = "Verify ID",
                                  Status = "Success"
                              }).ToList();
                
                gc_Attlog.DataSource = joined;
                lblStatus.Visible = true;
                ShowStatusBar(gv_Attlog.RowCount + " registros encontrados!!", true);
            }
            Cursor = Cursors.Default;
        }

        private void BiometAObjeto()
        {
            objEntidad.id_biometrico = (int)cbBiometricos.SelectedValue;
        }

        private void cbBiometricos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiometAObjeto();
            if (cbBiometricos.SelectedIndex == -1)
                id_bio = string.Empty;
            else
                IP = bd.D_ObtenerIP(objEntidad);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int ret = SDK.sta_ConnectTCP(lbSysOutputInfo, IP, "4370", "0");
            if (ret == 1)
            {
                ShowStatusBar("Biometrico Conectado!!", true);
                btnConnect.Text = "Desconectar";
                btnConnect.Refresh();
                btnConnect.Image = Resources.connected_25px;
                cbBiometricos.Enabled = false;
                btn_readAttLog.Enabled = true;
                btnBorrar.Enabled = true;
                btnExcel.Enabled = true;                
                btn_readAttLog.PerformClick();
            }
            else/* if (ret == -2)*/
            {
                ShowStatusBar("Biometrico Desconectado!!", true);
                btnConnect.Text = "Conectar";
                btnConnect.Image = Resources.disconnected_25px;
                btnConnect.Refresh();
                axCZKEM1.Disconnect();
                lbSysOutputInfo.Items.Clear();
                cbBiometricos.Enabled = true;
                btn_readAttLog.Enabled = false;
                btnBorrar.Enabled = false;
                btnExcel.Enabled = false;
                gc_Attlog.DataSource = null;
            }
            Cursor = Cursors.Default;
        }
        public static bool IsNumeric(string input)
        {
            // ^ asserts position at the start of the string.
            // \d matches a digit (0-9).
            // + matches one or more occurrences of the preceding character (\d).
            // $ asserts position at the end of the string.
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(input);
        }
        private void btnBD_Click(object sender, EventArgs e)
        {
            if (IsNumeric(tbBuscar.Text))
                buscarEmpleadoXNIC();
            else
                buscarEmpleadoXNombre();
        }

        public void buscarEmpleadoXNIC()
        {
            string fromTime = stime_log.Value.Date.ToString("MM/dd/yyyy");
            string toTime = etime_log.Value.Date.ToString("MM/dd/yyyy");
            _Usuarios.NIC = tbBuscar.Text.ToString();
            DataTable dt = bd.D_BuscarEmpXNIC(_Usuarios, fromTime, toTime);
            gc_Attlog.DataSource = dt;
            ShowStatusBar(gv_Attlog.RowCount + " registros encontrados!!", true);
            tbBuscar.Text = "";
            tbBuscar.Focus();
        }

        public void buscarEmpleadoXNombre()
        {
            string fromTime = stime_log.Value.Date.ToString("MM/dd/yyyy");
            string toTime = etime_log.Value.Date.ToString("MM/dd/yyyy");
            _Usuarios.Nombre = tbBuscar.Text.ToString().ToUpper();
            DataTable dt = bd.D_BuscarEmpXFecha(_Usuarios, fromTime,toTime);
            gc_Attlog.DataSource=dt;
            ShowStatusBar(gv_Attlog.RowCount + " registros encontrados!!", true);
            tbBuscar.Text = "";
            tbBuscar.Focus();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text!="")
                btnConnect.Enabled = false;
            else
                btnConnect.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (checkBox_timePeriod.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Desea Borrar los Registros de las Fechas Seleccionadas? ", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    //string hora1 = "00:00:00";
                    //string hora2 = "23:59:59";
                    //string desde = stime_log.Value.Date.ToString("yyyy-MM-dd") + " " + hora1;
                    //string hasta = etime_log.Value.Date.ToString("yyyy-MM-dd") + " " + hora2;

                    string fromTime = stime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "00:00:00";
                    string toTime = etime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59";

                    SDK.sta_DeleteAttLogByPeriod(lbSysOutputInfo, fromTime, toTime);
                    MessageBox.Show("Registros Borrados");

                    btn_readAttLog.PerformClick();                    
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Periodo Para Borrar Las Entradas y Salidas del Personal");
                //SDK.sta_DeleteAttLog(lbSysOutputInfo);
            }
            Cursor = Cursors.Default;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            crearCSV();
            //gc_Attlog.ExportToCsv(@"C:\Documentos\ExportedData.csv");
        }

        private void crearCSV()
        {
            if (gv_Attlog.RowCount > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Error al guardar archivo." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            string fullPath = sfd.FileName;
                            gc_Attlog.ExportToCsv(fullPath);    
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                    MessageBox.Show("Archivo Creado Correctamente!!!", "Info");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para Exportar!!!", "Info");
            }
        }

        public void ShowStatusBar(string message, bool type)
        {
            if (message.Trim() == string.Empty)
            {
                lblStatus.Visible = false;
                lblDeviceInfo.Visible = false;
                return;
            }

            lblStatus.Visible = true;
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.White;

            if (message == "Biometrico Desconectado!!")
            {
                lblStatus.BackColor = Color.FromArgb(255, 0, 0);
                lblDeviceInfo.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                lblStatus.BackColor = Color.FromArgb(51, 122, 183);
                lblDeviceInfo.BackColor = Color.FromArgb(51, 122, 183);
            }
        }

    }
}
