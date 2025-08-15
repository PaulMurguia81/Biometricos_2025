using DevExpress.Xpo.DB.Helpers;
using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometricos.Clases
{
    public class BD
    {
        DB2Connection con = new DB2Connection(ConfigurationManager.ConnectionStrings["ibmconex"].ConnectionString);

        #region BIOMETRICOS
                
        public DataTable D_listado()
        {
            DB2Command cmd = new DB2Command("select * from v_listar_biometricos order by 1", con);
            cmd.CommandType = CommandType.Text;
            DB2DataAdapter da = new DB2DataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int D_InsertarBiometrico(E_Biometricos e_Biometricos)
        {
            int result = 0;
            DB2Command cmd = new DB2Command("INSERTAR_BIOMETRICO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_biometrico", e_Biometricos.id_biometrico);
            cmd.Parameters.Add("@ip_biometrico", e_Biometricos.ip_biometrico);
            cmd.Parameters.Add("@num_serie", e_Biometricos.num_serie);
            cmd.Parameters.Add("@municipio", e_Biometricos.municipio);
            cmd.Parameters.Add("@ubicacion", e_Biometricos.ubicacion);
            cmd.Parameters.Add("@status", e_Biometricos.status);
            cmd.Parameters.Add("@descripcion", e_Biometricos.descripcion);
            cmd.Parameters.Add("@status_inc", e_Biometricos.status_inc);
            cmd.Parameters.Add("@tabla", e_Biometricos.tabla);

            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Guardar el Biometrico en la Base de Datos");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return result;
        }

        public int D_BorrarBiometrico(E_Biometricos e_Biometricos)
        {
            int result = 0;

            DB2Command cmd = new DB2Command("DELETE from config_biometricosn where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar el Biometrico en la Base de Datos");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return result;
        }

        public int D_ActualizarBiometrico(E_Biometricos e_Biometricos)
        {
            int result = 0;

            DB2Command cmd = new DB2Command("UPDATE config_biometricosn SET id_biometrico=?,ip_biometrico=?,num_serie=?,municipio=?,ubicacion=?,status=?,descripcion=?,status_inc=?,tabla=? where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id_biometrico", e_Biometricos.id_biometrico);
            cmd.Parameters.Add("@ip_biometrico", e_Biometricos.ip_biometrico);
            cmd.Parameters.Add("@num_serie", e_Biometricos.num_serie);
            cmd.Parameters.Add("@municipio", e_Biometricos.municipio);
            cmd.Parameters.Add("@ubicacion", e_Biometricos.ubicacion);
            cmd.Parameters.Add("@status", e_Biometricos.status);
            cmd.Parameters.Add("@descripcion", e_Biometricos.descripcion);
            cmd.Parameters.Add("@status_inc", e_Biometricos.status_inc);
            cmd.Parameters.Add("@tabla", e_Biometricos.tabla);

            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar el Biometrico en la Base de Datos");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return result;
        }

        public int D_InactivarBiometrico(E_Biometricos e_Biometricos)
        {
            int result = 0;

            DB2Command cmd = new DB2Command("UPDATE config_biometricosn SET id_biometrico=?,ip_biometrico=?,num_serie=?,municipio=?,ubicacion=?,status=?,descripcion=?,status_inc=?,tabla=? where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id_biometrico", e_Biometricos.id_biometrico);
            cmd.Parameters.Add("@ip_biometrico", e_Biometricos.ip_biometrico);
            cmd.Parameters.Add("@num_serie", e_Biometricos.num_serie);
            cmd.Parameters.Add("@municipio", e_Biometricos.municipio);
            cmd.Parameters.Add("@ubicacion", e_Biometricos.ubicacion);
            cmd.Parameters.Add("@status", e_Biometricos.status);
            cmd.Parameters.Add("@descripcion", e_Biometricos.descripcion);
            cmd.Parameters.Add("@status_inc", e_Biometricos.status_inc);
            cmd.Parameters.Add("@tabla", e_Biometricos.tabla);

            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar el Biometrico en la Base de Datos");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return result;
        }

        public bool PingTheDevice(string ipAdd)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ipAdd);

                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();
                options.DontFragment = true;

                // Create a buffer of 32 bytes of data to be transmitted. 
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;
                PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidateIP(string addrString)
        {
            IPAddress address;
            if (IPAddress.TryParse(addrString, out address))
                return true;
            else
                return false;
        }

        #endregion

        #region USUARIOS

        public DataTable D_ListarBiometricos()
        {
            DB2Command cmd = new DB2Command("select * from config_biometricosn where status ='A' order by 1", con);
            cmd.CommandType = CommandType.Text;
            DB2DataAdapter da = new DB2DataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string D_ObtenerIP(E_Biometricos e_Biometricos)
        {
            int result = 0;
            string ip;
            DB2Command cmd = new DB2Command("select ip_biometrico from config_biometricosn where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();
                //result = cmd.ExecuteNonQuery();
                ip=cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Consultar Biometrico en la Base de Datos");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

            return ip;
        }

        public DataTable D_BuscarEmp(E_Usuarios e_Usuarios)
        {
            DB2Command cmd = new DB2Command("select * from nrhempleados where numcredencial='" + e_Usuarios.NIC + "'", con);
            cmd.CommandType = CommandType.Text;
            DB2DataAdapter da = new DB2DataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
