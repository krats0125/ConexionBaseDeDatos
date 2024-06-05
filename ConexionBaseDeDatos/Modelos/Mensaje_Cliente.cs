using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Modelos
{
    public class Mensaje_Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Factura { get; set; }
        public string Correo { get; set; }
        public string TextoMensaje { get; set; }
        public bool Asignado { get; set; }
        public string Asesor { get; set; }

        public DateTime Fecha { get; set; }
    }
}
