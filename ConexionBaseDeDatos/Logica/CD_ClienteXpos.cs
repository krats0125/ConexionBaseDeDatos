using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionBaseDeDatos.Modelos;

namespace ConexionBaseDeDatos.Logica
{
    public class CD_ClienteXpos
    {
        /*
           1) Buscar cliente cliente ok
           2) registrar cliente
           3) Editar Cliente
           4) TaerProductosPreferidosCliente
           5) Traer Hora promedio de compra
           6) Traer ticker promedio de compra
           7) traer ultima Factura
        */



        public async Task<Cliente> BuscarTelefono(string buscado)
        {
            Cliente ocliente = new Cliente();
            try
            {
                CONEXION cn = new CONEXION();
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionXpos()))
                {
                   await conn.OpenAsync();

                    string Query = "SELECT strIDCliente, strEmpresa, strDireccion," +
                                   " strTelefono, strCelular, strTelefonoOficina," +
                                   " strWhatsapp, strTipoCliente, dtmFechaUltimaCompra" +
                                   " FROM tblCliente where strIDCliente like '%" + buscado + "%'" +
                                   " or strTelefono like '%" + buscado + "%'" +
                                   " or strCelular like '%" + buscado + "%'" +
                                   " or strTelefonoOficina like '%" + buscado + "%'" +
                                   " or strWhatsapp like '%" + buscado + "%'";
                   
                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        using (OleDbDataReader reader =(OleDbDataReader) await cmd.ExecuteReaderAsync())
                        {
                            DataTable dt = new DataTable();

                            dt.Load(reader);

                            if (dt.Rows.Count > 0)
                            {
                                // Acceder a la primera fila
                                DataRow row = dt.Rows[0];

                                ocliente.IdCliente = row[0].ToString();
                                ocliente.Nombre = row[1].ToString().Trim();
                                ocliente.Direccion = row[2].ToString().Trim();
                                ocliente.Telefono = row[3].ToString().Trim();
                                ocliente.Telefono2 = row[4].ToString().Trim();
                                ocliente.Telefono3 = row[5].ToString().Trim();
                                ocliente.Telefono4 = row[6].ToString().Trim();
                                ocliente.Categoria = row[7].ToString().Trim();
                                ocliente.dtmFechaUltimaCompra = row[8].ToString().Trim();



                            }


                        }
                    }
                }
            }
            catch (Exception)
            {

                return new Cliente();
            }

            return ocliente;

        }

        public async Task TaerProductosPreferidosCliente(string cliente,DataGridView tabla)
        {
            DataTable preferidos = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                /*string query = "SELECT (qryVentasPLUxCliente.strDesLar) As Item, Sum(qryVentasPLUxCliente.sngCan) AS Cant " +
                               "FROM qryVentasPLUxCliente " +
                               "GROUP BY qryVentasPLUxCliente.strDesLar, qryVentasPLUxCliente.strIDCliente " +
                               "HAVING qryVentasPLUxCliente.strIDCliente = '" + cliente + "' " +
                               "ORDER BY Sum(qryVentasPLUxCliente.sngCan) DESC";
                */




                string query = "SELECT (tblPLU.strDesLar) As Producto, Sum(qryVentasPLUxCliente.sngCan) AS Cant, (tblPLU.bytDep) AS Dep " +
                               "FROM qryVentasPLUxCliente INNER JOIN tblPLU ON qryVentasPLUxCliente.lngPLU = tblPLU.lngPLU " +
                               "GROUP BY tblPLU.strDesLar, qryVentasPLUxCliente.strIDCliente, tblPLU.bytDep " +
                               $"HAVING (((qryVentasPLUxCliente.strIDCliente)='{cliente}')) " +
                               "ORDER BY Sum(qryVentasPLUxCliente.sngCan) DESC";
                 
                


                using (OleDbConnection connection = new OleDbConnection(cn.ConexionXpos()))
                {
                   await connection.OpenAsync();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    adapter.Fill(preferidos);


                    tabla.Invoke((MethodInvoker)delegate { tabla.DataSource = preferidos; });
                   


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error cuando se iba a llenar la tabla de preferidos del cliente");
            }
            
        }

        public async Task<bool> ActualizarNombreYDireccion(Cliente oCliente) 
        {
            CONEXION cn = new CONEXION();

            try
            {
                string query = $"UPDATE tblCliente set strEmpresa = @Nombre, strDireccion = @Direccion where strIDCliente = @IdCliente";
                    

                using (OleDbConnection connection = new OleDbConnection(cn.ConexionXpos()))
                {
                    await connection.OpenAsync();
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", oCliente.Direccion);
                    cmd.Parameters.AddWithValue("@IdCliente", oCliente.IdCliente);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible actualizar los datos del cliente -" + ex.Message);
                return false;
            }



            return  true;
        }


        
        /*
                 private async Task BuscarTelefono(string buscado)
        {
            try
            {
                CONEXION cn = new CONEXION();
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionXpos()))
                {


                    await conn.OpenAsync().ConfigureAwait(false);

                    string Query = "Select * from tblCliente where strIDCliente like '%" + buscado + "%'";
                    /// or strIDCliente like '%" + buscado + "%' or strTelefono like '%" + buscado + "%' or strCelular like '%" + buscado + "%' or strTelefonoOficina like '%" + buscado + "%' or strWhatsapp like '%" + buscado + "%'";

                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            if (dt.Rows.Count > 0)
                            {
                                // Acceder a la primera fila
                                DataRow row = dt.Rows[0];


                                txtDireccion.Text = row[8].ToString().Trim();


                                txtNombre.Text = row[1].ToString().Trim();

                                txtId.Text = row[0].ToString().Trim();

                            }


                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error");
            }


            
        }
         
         */ // codigo asincrono de busar el telefono
    }
}
