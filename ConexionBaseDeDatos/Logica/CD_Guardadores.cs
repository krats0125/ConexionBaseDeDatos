using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBaseDeDatos.Modelos;
using System.Windows.Forms;
using ADODB;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel;

namespace ConexionBaseDeDatos.Logica
{
    public class CD_Guardadores
    {
        public async Task<bool> AgregarAPedidosGuardados(DatosComanda dc, DataTable PedidoGuardadoDetalleDT)
        {
            bool respuesta = false;
            try
            {
               await PedidoGuardado(dc);
               int IdPedido = await BuscarIdPedidoGuardado();
               await PedidoGuardadoDetalle(PedidoGuardadoDetalleDT,IdPedido);

                respuesta = true;

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el pedido");
                return false;
            }
            return respuesta;
        }

        private async Task PedidoGuardado(DatosComanda dc)
        {

           
            CONEXION cn = new CONEXION();
            using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
            {
               await connection.OpenAsync();
                OleDbCommand command = new OleDbCommand("INSERT INTO PedidoGuardado (IdCliente, Nombre, Telefono, MedioPago, Asesor, Puesto, Cajon,Direccion) values (@IdCliente,@Nombre,@Telefono,@MedioPago,@Asesor,@Puesto,@Cajon,@Direccion)", connection);
                command.Parameters.AddWithValue("@IdCliente", dc.IdCliente);
                command.Parameters.AddWithValue("@Nombre", dc.Nombre);
                if (dc.Telefono != null)
                {
                    command.Parameters.AddWithValue("@Telefono", dc.Telefono);
                }
                else 
                {
                    command.Parameters.AddWithValue("@Telefono", 0);
                }
                command.Parameters.AddWithValue("@MedioPago", dc.MedioPago);
                command.Parameters.AddWithValue("@Asesor", dc.Asesor);
                command.Parameters.AddWithValue("@Puesto", dc.Puesto);
                command.Parameters.AddWithValue("@Cajon", dc.Cajon);
                command.Parameters.AddWithValue("@Direccion", dc.Direccion);
                await command.ExecuteScalarAsync();
                
            }

        }

        private async Task PedidoGuardadoDetalle(DataTable PedidoGuardadoDetalleDT, int IdPedido)
        { CONEXION cn = new CONEXION();

            using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
            {
               await connection.OpenAsync();
                foreach (DataRow row in PedidoGuardadoDetalleDT.Rows)
                {
                       
                    OleDbCommand command = new OleDbCommand();
                    if (row["Producto"].ToString() != "")
                    {
                        string query = "INSERT INTO PedidoGuardadoDetalle (IdPedido,Cantidad,Producto,Descripcion,Precio,Departamento,Ubicacion,Plu)"
                                    + " VALUES (@IdPedido,@Cantidad,@Producto,@Descripcion,@Precio,@Departamento,@Ubicacion,@Plu)";



                        command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@IdPedido", IdPedido);
                        command.Parameters.AddWithValue("@Cantidad", row["Cant"]);
                        command.Parameters.AddWithValue("@Producto", row["Producto"]);
                        command.Parameters.AddWithValue("@Descripcion", row["Descripcion"]);
                        command.Parameters.AddWithValue("@Precio", row["Precio"]);
                        command.Parameters.AddWithValue("@Departamento", row["Departamento"]);
                        command.Parameters.AddWithValue("@Ubicacion", row["Ubicacion"]);
                        command.Parameters.AddWithValue("@Plu", row["Plu"]);
                        await command.ExecuteNonQueryAsync();
                    }

                   
                }
            }
        }

        private async Task<int> BuscarIdPedidoGuardado()
        {
            int Id = 0;
            try
            {
                CONEXION cn = new CONEXION();
                using (OleDbConnection conexion = new OleDbConnection(cn.ConexionBDInterna()))
                {
                   await conexion.OpenAsync();
                    string query = "Select max(Id) from PedidoGuardado";

                    OleDbCommand cmd = new OleDbCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    object result = await cmd.ExecuteScalarAsync();
                    if (result != DBNull.Value) // Verifica si el resultado no es nulo
                    {
                        Id = Convert.ToInt32(result);
                    }


                }
            }
            catch (Exception)
            {

                return 0;
            }

            return Id;
        }

        public async Task<DataTable> LeerPedidoGuardado(string cajon)
        {
            DataTable cotizacion = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
                {
                    await connection.OpenAsync();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM PedidoGuardado where Cajon = '" + cajon + "'", connection);
                    adapter.Fill(cotizacion);
                }
                
            }
            catch (Exception)
            {

                return cotizacion;
            }
            return cotizacion;
        }

        public async Task<int> RevisarCajon(string cajon)
        {
            int hayDato = 0;

           // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\APP BODEGA DE NACHO\Nuevos projectos\BddLocal.accdb;Persist Security Info=False;";
            try
            {
                
                DataTable cotizacion = new DataTable();

                CONEXION cn = new CONEXION();
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
                {
                    string query = "SELECT Id FROM PedidoGuardado WHERE Cajon = '" + cajon + "'";

                    await connection.OpenAsync();
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                

                   object dato = await cmd.ExecuteScalarAsync();

                    if (dato != null) { hayDato = 1; }

                }
            }
            catch (Exception ex)
            {
                               
                return hayDato;
            }
            
            return hayDato;
        }
        public async Task<List<int>> RevisarCajones()
        {
            List<int> lista = new List<int>();

            
            try
            {

                DataTable cotizacion = new DataTable();

                CONEXION cn = new CONEXION();
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
                {
                    string query = "SELECT Cajon FROM PedidoGuardado";

                    await connection.OpenAsync();
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    OleDbDataReader leerFilas =(OleDbDataReader) await cmd.ExecuteReaderAsync();

                    while(leerFilas.Read()) 
                    {
                        lista.Add(int.Parse(leerFilas[0].ToString()));
                                            
                    }

                }
            }
            catch (Exception ex)
            {

                return new List<int>();
            }

            return lista;
        }

        public async Task<DataTable> LeerPedidoGuardadoDetalle(int id)
        {
            DataTable PedidoGuardadoDetalle = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
                {
                    await connection.OpenAsync();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM PedidoGuardadoDetalle WHERE IdPedido = @Id", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
                    adapter.Fill(PedidoGuardadoDetalle);
                }
            }
            catch (Exception)
            {
                
                return PedidoGuardadoDetalle;
            }
           
            return PedidoGuardadoDetalle;
        }

        public async Task EliminarPedidoGuardado(int IdPedidoGuardado)
        {
            CONEXION cn = new CONEXION();
            using (OleDbConnection connection = new OleDbConnection(cn.ConexionBDInterna()))
            {
                await connection.OpenAsync();
                OleDbCommand command = new OleDbCommand("DELETE FROM PedidoGuardado WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", IdPedidoGuardado);
              await command.ExecuteNonQueryAsync();
            }
           
        }

      
    }
}
