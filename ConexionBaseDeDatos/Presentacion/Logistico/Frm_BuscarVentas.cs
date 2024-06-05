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

namespace ConexionBaseDeDatos.Presentacion.Logistico
{
    public partial class Frm_BuscarVentas : Form
    {
        public Frm_BuscarVentas()
        {
            InitializeComponent();
        }



        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();

            int filtro = 1;

            string idcliente = txtIdCliente.Text;
            if (idcliente == "")
            {
                MessageBox.Show("No Has puesto ningun cliente");

               return;
            }

            if (OptIdCliente.Checked) { filtro = 1; }
            if (OptCajero.Checked) { filtro = 2; }
            if (OptAsesor.Checked) { filtro = 3; }
            if (OptValor.Checked) { filtro = 4; }
            if (OptFecha.Checked) { filtro = 5; }
            if (OptCaja.Checked) { filtro = 6; }
           


            try
            {
                dt = await BuscarVentas(idcliente, filtro);
            }
            catch (Exception)
            {

               MessageBox.Show("Ocurrio un error.");
            }
                      
            dgvReporteCompras.DataSource = dt;

            

        }

        private async Task<DataTable> BuscarVentas(string buscado, int filtro)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            string paramName = string.Empty;

            switch (filtro)
            {
                case 1: // Buscar por ID del cliente
                    query = "SELECT tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVentaPOS.strIDCliente = @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    break;
                case 2: // Buscar por nombre del cajero
                    query = "SELECT top 10 tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVentaPOS.strIDCajero = @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    break;
                case 3: // Buscar por nombre del asesor
                    query = "SELECT top 10 tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVendedor.strNombreCorto = @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    break;
                case 4: // Buscar por valor
                    query = "SELECT top 10 tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVentaPOS.sngTotal = @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    break;
                case 5: // Buscar por fecha
                    query = "SELECT top 10 tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVentaPOS.dtmFechaHora LIKE @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    buscado = "%" + buscado + "%"; // Usar comodines para LIKE
                    break;
                case 6: // Buscar por caja
                    query = "SELECT top 10 tblVentaPOS.lngIDCaja AS Caja, tblVentaPOS.lngIDVenta AS Factura, " +
                            "tblVentaPOS.strIDCliente AS [Id Cliente], tblVentaPOS.strIDCajero AS Cajero, " +
                            "tblVendedor.strNombreCorto AS Vendedor, tblVentaPOS.dtmFechaHora AS Fecha, " +
                            "tblVentaPOS.sngTotal AS Total " +
                            "FROM tblVendedor " +
                            "INNER JOIN tblVentaPOS ON tblVendedor.bytIDVendedor = tblVentaPOS.bytIDVendedor " +
                            "WHERE tblVentaPOS.lngIDCaja = @buscado " +
                            "ORDER BY tblVentaPOS.dtmFechaHora DESC";
                    paramName = "@buscado";
                    break;
                default:
                    throw new ArgumentException("Filtro no válido.");
            }

            CONEXION conexion = new CONEXION();
            try
            {
                using (OleDbConnection con = new OleDbConnection(conexion.ConexionXpos()))
                {
                    await con.OpenAsync();
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(paramName, buscado);

                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }

            return dt;
        }

        private void Frm_BuscarVentas_Load(object sender, EventArgs e)
        {
            OptIdCliente.Checked = true;
        }
    }
}
