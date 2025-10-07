using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Biometricos.Clases
{
    public partial class Usuario_Acceso
    {
        public int usuario_accesoid { get; set; }
        public int usuarioid { get; set; }
        public Nullable<bool> activo { get; set; }
        public string clave { get; set; }
        public Nullable<System.DateTime> error_clave { get; set; }
        public Nullable<short> errores_en_clave { get; set; }
        public Nullable<System.DateTime> cambio_clave { get; set; }
        public string ficha { get; set; }
        public Nullable<System.DateTime> expira_ficha { get; set; }
        public string sistema { get; set; }
        public string nombreusuario { get; set; }

    }
}
