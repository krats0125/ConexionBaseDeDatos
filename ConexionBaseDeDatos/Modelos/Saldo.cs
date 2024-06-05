using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Modelos
{
    public class Saldo
    {
        public string Id { get; set; }
        public string fechaIngreso { get; set; }
        public string IdCliente { get; set; }

        public decimal SaldoFavor { get; set; }

        public string Factura { get; set; }

        public string Motivo { get; set; }

        public bool Saldado { get; set; }

        public string FechaPago { get; set; }

        public string SubioInforme { get; set; }

        public string JaloInforme { get; set; }

       

    }
}
