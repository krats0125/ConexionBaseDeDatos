using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDeDatos.Modelos
{
    public class DatosPedido
    {
        public int Plu { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Departamento { get; set; }
        public string Ubicacion { get; set; }

        public string Cantidad { get; set; }


    }
}
