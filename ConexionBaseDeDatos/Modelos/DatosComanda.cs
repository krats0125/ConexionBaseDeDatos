using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDeDatos.Modelos
{
    public class DatosComanda
    {
        public string Hora {  get; set; }
        public string Fecha { get; set; }
        public string CantArticulos { get; set; }
        public string IdPedido { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string MedioPago { get; set; }
        public string Asesor { get; set; }
        public string Puesto { get; set; }
        public string Novedad { get; set; }
        public string Cajon {get; set; }
        public string EstadoPQRS { get; set; }
        public string Categoria {  get; set; }
        public string Medio { get; set; }

        public List<string> ListPedido { get; set; }
    }
}
