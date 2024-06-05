using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Modelos
{
    public   class PQRS
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Motivo { get; set; }
        public string Descripcion { get; set; }
        public string Asesor { get; set; }
        public string Medio_Pqrs { get; set; }
        public string Fecha { get; set; }
        public string No_Procesos { get; set; }
        public string Estado { get; set; }
        public string Resuelto { get; set; }
    }

}
