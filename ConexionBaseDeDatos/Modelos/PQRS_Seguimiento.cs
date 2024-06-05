using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Modelos
{
    public class PQRS_Seguimiento
    {
        public int IdSeguimiento { get; set; }
        public PQRS oPQRS { get; set; }
        public string Descripcion { get; set; }
        public string Asesor { get; set; }
        public string Fecha { get; set; }

        
    }
}
