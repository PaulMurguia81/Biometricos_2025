using Biometricos.Clases;
using DevExpress.Utils.ScrollAnnotations;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometricos.Forms
{
    public partial class TerminalForm : Form
    {
        #region VARIABLES GLOBALES

        private Form1 Terminal;
        public BD bd = new BD();
        private bool buttonClick = false;
        string tabla = "", ipAddress = "";
        E_Biometricos objEntidad = new E_Biometricos();
        public SDKHelper SDK = new SDKHelper();
        Cargando cargar;
        public bool btnClicked, pingSuccess;

        #endregion

        public TerminalForm(Form1 Parent)
        {
            InitializeComponent();
            Terminal = Parent;
        }
             

        private void TerminalForm_Load(object sender, EventArgs e)
        {
            tbBiomet.Focus();
            gvBiomet.ClearSelection();
            cargarGrid();
            Limpiar();
        }

        public void cargarGrid()
        {
            DataTable dt = bd.D_listado();
            dataGridView1.DataSource = dt;
            ChangeGridProperties(dataGridView1);
            //gcBiomet.DataSource = dt;
        }

        private bool validarTextBox()
        {
            if (String.IsNullOrEmpty(tbBiomet.Text) || String.IsNullOrEmpty(tbIpbiomet.Text) || String.IsNullOrEmpty(tbUbicacion.Text)
                || String.IsNullOrEmpty(tbDescrip.Text) || String.IsNullOrEmpty(cbMunicipio.Text))
            {
                MessageBox.Show("No puede haber campos vacios, verifique la informacion o \n asegurese de haber seleccionado un biometrico.");
                return false;
            }
            else
                return true;
        }

        private void TextboxAObjeto()
        {
            if (checkBiometrico.Checked && tbBiomet.Text != "" && buttonClick)
            {
                objEntidad.id_biometrico = Convert.ToInt32(tbBiomet.Text.ToString());
                objEntidad.ip_biometrico = tbIpbiomet.Text.Trim();
                objEntidad.num_serie = 1;
                objEntidad.municipio = cbMunicipio.Text.Trim();
                objEntidad.ubicacion = tbUbicacion.Text.Trim();
                objEntidad.status = "I";
                objEntidad.descripcion = tbDescrip.Text.Trim();
                objEntidad.status_inc = "I";
                if (cbMunicipio.SelectedItem.ToString() == "Tijuana" || cbMunicipio.SelectedItem.ToString() == "Rosarito")
                    objEntidad.tabla = "reportetj";
                else
                    objEntidad.tabla = "reporte1";
                //objEntidad.tabla = tabla;
            }
            else
            {
                objEntidad.id_biometrico = Convert.ToInt32(tbBiomet.Text.ToString());
                objEntidad.ip_biometrico = tbIpbiomet.Text.Trim();
                objEntidad.num_serie = 1;
                objEntidad.municipio = cbMunicipio.Text.Trim();
                objEntidad.ubicacion = tbUbicacion.Text.Trim();
                objEntidad.status = "A";
                objEntidad.descripcion = tbDescrip.Text.Trim();
                objEntidad.status_inc = "A";
                if (cbMunicipio.SelectedItem.ToString() == "Tijuana" || cbMunicipio.SelectedItem.ToString() == "Rosarito")
                    objEntidad.tabla = "reportetj";
                else
                    objEntidad.tabla = "reporte1";
                //objEntidad.tabla = tabla;
            }
        }

        public void Limpiar()
        {
            tbBiomet.Text = "";
            tbIpbiomet.Text = "";
            cbMunicipio.Text = "";
            tbUbicacion.Text = "";
            tbDescrip.Text = "";
            tabla = "";
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMunicipio.SelectedItem.ToString() == "Tijuana" || cbMunicipio.SelectedItem.ToString() == "Rosarito")
                tabla = "reportetj";
            else
                tabla = "reporte1";
        }

        private void btnBorrarBiom_Click(object sender, EventArgs e)
        {
            bool x = validarTextBox();
            if (x)
            {
                DialogResult dr = MessageBox.Show("Desea eliminar el Biometrico seleccionado?", "Borrar Dispositivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    int nGuardar = -1;
                    TextboxAObjeto();
                    nGuardar = bd.D_BorrarBiometrico(objEntidad);

                    if (nGuardar != -1)
                        MessageBox.Show("El Biometrico fue eliminado");
                    else
                        MessageBox.Show("Error al borrar el biometrico");

                    tbBiomet.Focus();
                    cargarGrid();
                    Limpiar();
                }
            }
        }

        private void gvBiomet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //foreach (int i in gvBiomet.GetSelectedRows())
            //{
            //    DataRow row = gvBiomet.GetDataRow(i);
            //    tbBiomet.Text = row[0].ToString();
            //    tbIpbiomet.Text = row[1].ToString();
            //    cbMunicipio.Text = row[2].ToString();
            //    tbUbicacion.Text = row[3].ToString();
            //    tbDescrip.Text = row[4].ToString();
            //}
        }

        private void checkBiometrico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBiometrico.Checked)
            {
                btnInactivar.Image = Properties.Resources.cancel_50px;
                label29.Text = "Inactivar Biom";
            }
            else
            {
                btnInactivar.Image = Properties.Resources.Checkmark_50px;
                label29.Text = "Activar Biom";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool x = validarTextBox();
            if (x)
            {
                int nGuardar = -1;

                TextboxAObjeto();

                nGuardar = bd.D_ActualizarBiometrico(objEntidad);

                if (nGuardar != -1)
                    MessageBox.Show("El Biometrico fue modificado con Exito");
                else
                    MessageBox.Show("Error al modificar el biometrico en la BD");

                tbBiomet.Focus();
                cargarGrid();
                Limpiar();
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            buttonClick = true;
            bool x = validarTextBox();
            if (x)
            {
                int nGuardar = -1;
                TextboxAObjeto();
                nGuardar = bd.D_InactivarBiometrico(objEntidad);

                if (nGuardar != -1)
                    MessageBox.Show("El Biometrico fue Cambiado");
                else
                    MessageBox.Show("Error al modificar el biometrico");

                Limpiar();
                tbBiomet.Focus();
                cargarGrid();
            }
            checkBiometrico.Checked = false;
            buttonClick = false;
        }

        private void btnGuardarBio_Click(object sender, EventArgs e)
        {
            bool x = validarTextBox();
            if (x)
            {
                int nGuardar = -1;

                TextboxAObjeto();

                nGuardar = bd.D_InsertarBiometrico(objEntidad);

                if (nGuardar != -1)
                    MessageBox.Show("Error al guardar el biometrico en la BD");
                else
                    MessageBox.Show("El biometrico se guardo en la BD");

                tbBiomet.Focus();
                cargarGrid();
                Limpiar();
            }
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

        public void ping()
        {
            Cursor = Cursors.WaitCursor;
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {               
                string ip = row.Cells["ip_biometrico"].Value.ToString();               
                i = row.Index;

                bool isValidIpA = bd.ValidateIP(ip);
                if (!isValidIpA)
                    throw new Exception("The Device IP is invalid !!");

                isValidIpA = bd.PingTheDevice(ip);
                if (isValidIpA)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(51, 196, 129);
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.CurrentCell.Selected = false;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(191, 57, 25);
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.CurrentCell.Selected = false;
                }
            }
            Cursor = Cursors.Default;
        }

        private void btnOnLine_Click(object sender, EventArgs e)
        {
            //cargarGrid();
            ping();
            //Cursor = Cursors.WaitCursor;
            //for (int i = 0; i < gvBiomet.DataRowCount; i++)
            //{
            //    DataRowView row = gvBiomet.GetRow(i) as DataRowView;
            //    string ip = gvBiomet.GetRowCellValue(i, "ip_biometrico").ToString();
            //    bool isValidIpA = bd.ValidateIP(ip);
            //    if (!isValidIpA)
            //        throw new Exception("La IP es invalida !!");

            //    pingSuccess = bd.PingTheDevice(ip);

            //    if (!pingSuccess)
            //    {
            //        gvBiomet.SetRowCellValue(i, "municipio", "Fuera de Linea");
            //        //gvBiomet.SetRowCellValue(i, "ubicacion", "Fuera de Linea");
            //        //gvBiomet.SetRowCellValue(i, "descripcion", "Fuera de Linea");
            //    }
            //    else
            //    {
            //        //gvBiomet.Appearance.Row.BackColor = Color.FromArgb(191, 57, 25);
            //        //gvBiomet.Appearance.Row.ForeColor = Color.Black;
            //    }
            //}
            //gvBiomet.RowStyle += gvBiomet_RowStyle;
            //gvBiomet.ClearSelection();
            //Cursor = Cursors.Default;
        }

        private async void btnSYNC_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("La sincronizacion de los Biometricos puede tardar!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                ShowCarga("Sincronizando Biometricos . . . . .");

                Task oTask = new Task(sincronizarHora);//sincHora
                oTask.Start();

                await oTask;
                HideCarga();

            }
            MessageBox.Show("Biometricos Sincronizados!!!");
            SDK.GetConnectState();
            cargarGrid();
            Limpiar();

        }

        public void sincronizarHora()
        {
            Thread.Sleep(1000);
            foreach (DataGridViewRow hora in dataGridView1.Rows)
            {
                //SDK.GetConnectState1();
                int ret = 0;
                ret = SDK.sta_ConnectTCP(lbSysOutputInfo, hora.Cells["ip_biometrico"].Value.ToString(),"4370", "0");
                if (SDK.GetConnectState())
                {
                    int ret1 = SDK.sta_SYNCTime(lbSysOutputInfo, lbDeviceTime);

                    if (ret1 == 1)                    
                        Console.WriteLine("BIOMETRICO #{0}      SINCRONIZADO", hora.Cells["id_biometrico"].Value.ToString());
                }
            }
        }

        public void sincHora()
        {
            //foreach (GridColumn row in gvBiomet.Columns)
            for (int i = 0; i < gvBiomet.DataRowCount; i++)
            {
                //int i = row.AbsoluteIndex;
                string ip = gvBiomet.GetRowCellValue(i, "ip_biometrico").ToString();
                string idBio = gvBiomet.GetRowCellValue(i, "id_biometrico").ToString();
                int ret = 0;
                ret = SDK.sta_ConnectTCP(lbSysOutputInfo, ip.ToString(), "4370", "0");
                if (SDK.GetConnectState())
                {
                    //Cursor = Cursors.WaitCursor;

                    int ret1 = SDK.sta_SYNCTime(lbSysOutputInfo, lbDeviceTime);

                    if (ret1 == 1)
                    {
                        Console.WriteLine("BIOMETRICO #{0}      SINCRONIZADO", idBio.ToString());
                    }

                    //Cursor = Cursors.Default;
                }
            }
        }

        public void ShowCarga(string mensaje)
        {
            cargar = new Cargando();
            cargar.Show();
            cargar.label1.Text = mensaje;
            
        }

        public void HideCarga()
        {
            if (cargar != null)
                cargar.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbBiomet.Text = row.Cells[0].Value.ToString();
                tbIpbiomet.Text = row.Cells[1].Value.ToString();
                cbMunicipio.Text = row.Cells[2].Value.ToString();
                tbUbicacion.Text = row.Cells[3].Value.ToString();
                tbDescrip.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void gvBiomet_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    // Get the cell value from the desired column
            //    object cellValue = gvBiomet.GetRowCellValue(e.RowHandle, "municipio");

            //    // Apply conditional logic based on the cell value
            //    if (cellValue != null && cellValue.ToString() == "Fuera de Linea")
            //    {
            //        e.Appearance.BackColor = Color.FromArgb(191, 57, 25);
            //        e.Appearance.ForeColor = Color.White;
            //    }
            //}
        }

    }
}
