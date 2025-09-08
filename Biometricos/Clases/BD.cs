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
        int? num_transac_max;
        int rowsAffected = 0;

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

        public int D_InsertarBiometricoTablaAnterior(E_Biometricos e_Biometricos)
        {
            int result = 0;
            DB2Command cmd = new DB2Command("INSERTAR_BIOMETRICO_TABLA_ANTERIOR", con);
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

        public int D_BorrarBiometricoTablaAnterior(E_Biometricos e_Biometricos)
        {
            int result = 0;

            DB2Command cmd = new DB2Command("DELETE from config_biometricos where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
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

        public int D_ActualizarBiometricoTablaAnterior(E_Biometricos e_Biometricos)
        {
            int result = 0;

            DB2Command cmd = new DB2Command("UPDATE config_biometricos SET id_biometrico=?,ip_biometrico=?,num_serie=?,municipio=?,ubicacion=?,status=?,descripcion=?,status_inc=?,tabla=? where id_biometrico='" + e_Biometricos.id_biometrico + "'", con);
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

        public void max_transac()
        {
            try
            {
                // Open a connection                                
                con.Open();
                // Create an SQL command
                //DB2Command cmd = new DB2Command("SELECT MAX(reporte1.num_transac) FROM reporte1", con);
                DB2Command cmd = new DB2Command("SELECT MAX(num_transac) FROM reporte1 where fecha>=(SELECT (TODAY - 1) FROM systables WHERE tabid = 1)", con);
                num_transac_max = (int)cmd.ExecuteScalar();
                // Close the connection
                con.Close();
                Console.ReadLine(); // Wait for a Return
            }
            catch (DB2Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine(); //Wait for a Return
            }
        }

        public int D_InsertarRegistros(List<E_Usuario_Registros> usuario_registros)
        {
           //DB2Command cmd;
            num_transac_max = num_transac_max + 1;
            int result = 0;

            foreach (var item in usuario_registros)
            {
                using (DB2Connection conex = new DB2Connection(ConfigurationManager.ConnectionStrings["ibmconex"].ConnectionString))
                {
                    conex.Open();
                    using (var cmd = conex.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO reporte1 (fecha, hora, actividad,mensaje,num_inc,id_biometrico,num_transac) values (?, ?, ?, ?, ?, ?, ?)";
                        cmd.Parameters.Add("@fecha", item.fecha);
                        cmd.Parameters.Add("@hora", item.hora);
                        cmd.Parameters.Add("@actividad", "0000000001");
                        cmd.Parameters.Add("@mensaje", "1");
                        cmd.Parameters.Add("@num_inc", item.nic);
                        cmd.Parameters.Add("@id_biometrico", item.id_biometrico);
                        cmd.Parameters.Add("@num_transac", num_transac_max);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            return result;
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

        public DataTable D_BuscarEmpXFecha(E_Usuarios e_Usuarios, string fechaini, string fechafin)
        {
            DB2Command cmd = new DB2Command("SELECT DISTINCT c.descripcion as ubicacion,r.fecha, to_char(extend (r.hora, hour to second),'%H:%M:%S') as hora, r.num_inc as num_credencial, e.nombreabreviado as nombre,c.id_biometrico as biometrico  from reporte1 r,nrhempleados e, config_biometricos c where r.num_inc=e.numcredencial and c.id_biometrico= r.id_biometrico and r.fecha between '" + fechaini + "' and '" + fechafin + "' and e.nombreabreviado LIKE '%" + e_Usuarios.Nombre + "%' order by r.fecha desc", con);
            cmd.CommandType = CommandType.Text;
            DB2DataAdapter da = new DB2DataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable D_BuscarEmpXNIC(E_Usuarios e_Usuarios, string fechaini, string fechafin)
        {
            DB2Command cmd = new DB2Command("SELECT DISTINCT c.descripcion as ubicacion,r.fecha, to_char(extend (r.hora, hour to second),'%H:%M:%S') as hora, r.num_inc as num_credencial, e.nombreabreviado as nombre,c.id_biometrico as biometrico  from reporte1 r,nrhempleados e, config_biometricos c where r.num_inc=e.numcredencial and c.id_biometrico= r.id_biometrico and r.fecha between '" + fechaini + "' and '" + fechafin + "' and e.numcredencial= " + e_Usuarios.NIC + " order by r.fecha desc", con);
            cmd.CommandType = CommandType.Text;
            DB2DataAdapter da = new DB2DataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }




        #endregion
    }
}
