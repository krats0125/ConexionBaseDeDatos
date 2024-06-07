using ADODB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Modelos
{
    public class Notificacion
    {
        public int IdNotifcacion { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; } 
    }

}
