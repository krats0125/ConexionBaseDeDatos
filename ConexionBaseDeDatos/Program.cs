using ConexionBaseDeDatos.Presentacion.Asesores;
using ConexionBaseDeDatos.Presentacion.Clientes;
using ConexionBaseDeDatos.Presentacion.Logistico;
using ConexionBaseDeDatos.Presentacion.PQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Presentacion.Clientes;
using Tomapedidos.Presentacion.DashBoard;
using Tomapedidos.Presentacion.Sistema;

namespace ConexionBaseDeDatos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
