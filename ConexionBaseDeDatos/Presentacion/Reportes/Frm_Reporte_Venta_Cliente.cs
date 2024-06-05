using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomapedidos.Presentacion.Reportes
{
    public partial class Frm_Reporte_Venta_Cliente : Form
    {
        public Frm_Reporte_Venta_Cliente()
        {
            InitializeComponent();
        }

        DataTable tabla1 = new DataTable();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text != "")
            {
              string buscado = btnBuscar.Text;

            
            }
        }

        private async Task Reportes(string IdCliente)
        {
            CONEXION conn = new CONEXION();

            string query1 = "select * from tblHola";

            string query2 = "";

            string query3 = "";

            string query4 = "";

            string query5 = "";

            //using (OleDbConnection conexion = new OleDbConnection(conn.ConexionXpos())
            //{

            //  OleDbDataAdapter da = new OleDbDataAdapter(query1,conexion);
            //da.Fill(tabla1);


        }

        
        
        
        

        
    }
}
