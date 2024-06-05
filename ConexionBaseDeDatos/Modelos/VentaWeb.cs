using Tomapedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tomapedidos.Modelos
{
    public class VentaWeb
    {
        public int IdVenta { set; get; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string TelefonoCliente2 { get; set; }
        public string TelefonoCliente3 { get; set; }
        public string TelefonoCliente4 { get; set; }
        public string DireccionCliente { get; set; }
        public string Vendedor { get; set; }
        public string Pedido { get; set; }
        public string FechaPedido { get; set; }
        public string HoraPedido { get; set; }
        public string Novedad { get; set; }
        public string MedioPago { get; set; }
        public string Canal { get; set; }
        public List<DetalleVenta> Productos { get; set; }

    }
}
