using Biometricos.Clases;
using Biometricos.Properties;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biometricos.Clases.SDKHelper;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Biometricos.Forms
{
    public partial class Poleo : Form
    {
        private Form1 _Poleo;
        public BD bd = new BD();
        E_Biometricos obj = new E_Biometricos();
        //E_Usuario_Registros e_usuarios = new E_Usuario_Registros();
        public SDKHelper SDK = new SDKHelper();
        int i;

        public Poleo(Form1 Parent)
        {
            InitializeComponent();
            _Poleo = Parent;
        }

        private void Poleo_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public static void ChangeGridProperties(DataGridView dgvMaster)
        {
            dgvMaster.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaster.RowHeadersWidth = 10;
            dgvMaster.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMaster.RowHeadersVisible = false;
            dgvMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaster.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 0, 10, 0);
            // dgvMaster.Columns[0].AutoSizeMode =DataGridViewAutoSizeColumnMode.DisplayedCells;
            foreach (DataGridViewColumn c in dgvMaster.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
            }
            dgvMaster.AllowUserToOrderColumns = true;
            dgvMaster.BackgroundColor = SystemColors.Control;
            dgvMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        public void cargarGrid()
        {
            DataTable dt = bd.D_listado();
            dataGridView1.DataSource = dt;
            ChangeGridProperties(dataGridView1);
        }

        private void btnPoleoG_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los registros de todos los biometricos se guardaran en la BD, \neste proceso puede tardar unos minutos, desea continuar?", "Poleo Manual", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                bd.max_transac();
                PoleoGlobal();

                MessageBox.Show("La informacion de los biometricos poleados se guardo correctamente");
               
            }
        }

        private void PoleoGlobal()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                obj.id_biometrico = (int)row.Cells["id_biometrico"].Value;
                obj.ip_biometrico = row.Cells["ip_biometrico"].Value.ToString();
                obj.descripcion = row.Cells["descripcion"].Value.ToString();
                
                i = row.Index;
                conectarBiometrico();
                //cargarDatosBiometrico(int.Parse(bio));
            }
        }

        public void conectarBiometrico()
        {
            Cursor = Cursors.WaitCursor;

            int ret = SDK.sta_ConnectTCP1(lbSysOutputInfo, obj.ip_biometrico, "4370", "0");
            if (ret == 1)
            {
                cargarDatosBiometrico(obj.id_biometrico);
                //MessageBox.Show("Se conecto el Biometrico # " + obj.id_biometrico + "con IP: " + obj.ip_biometrico );
            }
            else if (ret == -2)
            {
                //MessageBox.Show("NO SE CONECTO EL BIOMETRICO");
            }
            Cursor = Cursors.Default;
        }

        public void cargarDatosBiometrico(int biomet)
        {
            List<E_Usuario_Registros> e_usr = new List<E_Usuario_Registros>();
            E_Usuario_Registros e_usuarios = new E_Usuario_Registros();
            List<Employee> users = SDK.sta_getEmployees();
            string fromTime = stime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "00:00:00";
            string toTime = etime_log.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59";
            DataTable dt_periodLog = new DataTable("dt_periodLog");
            
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
                          select new E_Usuario_Registros
                          {
                              fecha = e_usuarios.fecha = Convert.ToDateTime(list2.Fecha).ToString("MM-dd-yyyy"),
                              hora = e_usuarios.hora = Convert.ToDateTime(list2.Hora).ToString("HH:mm:ss"),
                              actividad = e_usuarios.actividad = "0000000001",
                              mensaje = e_usuarios.mensaje = "1",
                              nic = e_usuarios.nic = Convert.ToInt32(list2.NIC),
                              id_biometrico = e_usuarios.id_biometrico= obj.id_biometrico
                          }).ToList();

          


            int nGuardar = -1;            

            nGuardar = bd.D_InsertarRegistros(joined);
        }

        private void BiometAObjeto()
        {
            //e_usuarios.id_biometrico = obj.id_biometrico;

        }
    }
}
