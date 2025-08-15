using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometricos.Clases
{
    public class E_Usuarios
    {
        public int Id_Biometrico { get; set; }
        public string NIC { get; set; }
        public string Nombre { get; set; }
        public int Consec_Dedo { get; set; }
        public string TmpData { get; set; }
        public int Privilegio { get; set; }
        public string Contrasena { get; set; }
        public bool Habilitado { get; set; }
        public string iFlag { get; set; }
    }
}
