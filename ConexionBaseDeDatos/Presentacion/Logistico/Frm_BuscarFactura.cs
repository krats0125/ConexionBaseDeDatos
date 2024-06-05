using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ConexionBaseDeDatos.Presentacion.Logistico
{
    public partial class Frm_BuscarFactura : Form
    {
        public Frm_BuscarFactura()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCaja.Text == "" || txtFactura.Text == "")
            {
                return;
            }

            string caja = txtCaja.Text;
            string factura = txtFactura.Text;

            lb_Procesando.Visible = false;
            await BuscarFactura(caja, factura);
            lb_Procesando.Visible = false;


        }

        private async Task BuscarFactura(string caja, string factura)
        {

            try
            {
                CONEXION con = new CONEXION();
                using (OleDbConnection conn = new OleDbConnection(con.ConexionXpos()))
                {
                    await conn.OpenAsync();

                    string query1 = "SELECT (tblVentaPOS.strIDCliente) as [Id Cliente], (tblVentaPOS.strIDCajero) as Cajero, (tblVendedor.strNombreCorto) as Vendedor, (tblVentaPOS.dtmFechaHora) as Fecha, (tblVentaPOS.sngTotal) as Total " +
                                    "FROM tblVendedor " +
                                    "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                                    "WHERE tblVentaPOS.lngIDCaja = ? AND tblVentaPOS.lngIDVenta = ?;";

                    string query2 = "SELECT (tblVentaPOSDetalle.lngPLU) as Plu, (tblPLU.strDesLar) as Descripcion, (tblVentaPOSDetalle.sngPre) as Precio, (tblVentaPOSDetalle.sngPorDes) as Des, (tblVentaPOSDetalle.sngVal) as Valor " +
                                    "FROM tblPLU " +
                                    "INNER JOIN tblVentaPOSDetalle ON tblPLU.lngPLU = tblVentaPOSDetalle.lngPLU " +
                                    "WHERE tblVentaPOSDetalle.lngIDCaja = ? AND tblVentaPOSDetalle.lngIDVenta = ?;";

                    DataTable tablafactura = new DataTable();
                    DataTable tablaDetalleFactura = new DataTable();

                    using (OleDbDataAdapter cmd1 = new OleDbDataAdapter(query1, conn))
                    {
                        cmd1.SelectCommand.Parameters.AddWithValue("?", caja);
                        cmd1.SelectCommand.Parameters.AddWithValue("?", factura);

                        cmd1.Fill(tablafactura);
                        dgvFactura.DataSource = tablafactura;
                    }

                    if (tablafactura.Rows.Count > 0)
                    {
                        using (OleDbDataAdapter cmd2 = new OleDbDataAdapter(query2, conn))
                        {
                            cmd2.SelectCommand.Parameters.AddWithValue("?", caja);
                            cmd2.SelectCommand.Parameters.AddWithValue("?", factura);

                            cmd2.Fill(tablaDetalleFactura);
                            dgvDetalleFactura.DataSource = tablaDetalleFactura;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la búsqueda: " + ex.Message);
            }


        }

        private void Frm_BuscarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
