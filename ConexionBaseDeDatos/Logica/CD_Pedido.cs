using ConexionBaseDeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ConexionBaseDeDatos.Logica
{
    public class CD_Pedido
    {

 
        public async  Task<int> GuardarPedido(DatosComanda dc) // guarda el pedido en una base de datos local en el disco local C:/
        {
            int Pedido = 0;
            try
            {
              await  PedidoGuardado(dc);
              int IdPedido = await BuscarIdPedido();
              await PedidoGuardadoDetalle(dc, IdPedido);
              await IngresarPedidoARegistros(dc, IdPedido);


                Pedido = IdPedido;

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el pedido");
                return Pedido;
            }
            return Pedido;
        }

        private async Task PedidoGuardado(DatosComanda dc)
        {
            CONEXION cn = new CONEXION();

            string query = "INSERT INTO tbl_DescOrdenes (CantArticulos, Novedad, MedioPago, EstadoPQRS, Categoria) " +
                                   "VALUES (@CantArticulos, @Novedad, @MedioPago, @EstadoPQRS, @Categoria)";
                                  

            using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
            {
               await  connection.OpenAsync();
                OleDbCommand command = new OleDbCommand(query, connection);

                //command.Parameters.AddWithValue("@Fecha", dc.Fecha);
                command.Parameters.AddWithValue("@CantArticulos", dc.CantArticulos);
                command.Parameters.AddWithValue("@Novedad", dc.Novedad);
                command.Parameters.AddWithValue("@MedioPago", dc.MedioPago);
                command.Parameters.AddWithValue("@EstadoPQRS", dc.EstadoPQRS);
                command.Parameters.AddWithValue("@Categoria", dc.Categoria);
                await  command.ExecuteNonQueryAsync();
            }

        }

        private async Task IngresarPedidoARegistros(DatosComanda dc, int IdPedido)
        {
            CONEXION cn = new CONEXION();

            string query = "INSERT INTO REGISTROS (Hora, Telefono, Nombre, Unidad, EquipoImpresion, Id_Orden,Asesor,Medio) " +
                                   "VALUES (@Hora, @Telefono, @Nombre, @Unidad, @EquipoImpresion, @Id_Orden,@Asesor,@Medio)";

            string FechaVenta = dc.Fecha + " " + dc.Hora;
            using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
            {
                await connection.OpenAsync();
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Hora", FechaVenta);
                command.Parameters.AddWithValue("@Telefono", dc.Telefono);
                command.Parameters.AddWithValue("@Nombre", dc.Nombre);
                command.Parameters.AddWithValue("@Unidad", dc.Direccion);
                command.Parameters.AddWithValue("@EquipoImpresion", dc.Puesto);
                command.Parameters.AddWithValue("@Id_Orden", IdPedido);
                command.Parameters.AddWithValue("@Asesor", dc.Asesor);
                command.Parameters.AddWithValue("@Medio", dc.Medio);
                await command.ExecuteNonQueryAsync();
            }

        }

        private async Task PedidoGuardadoDetalle(DatosComanda dc, int IdPedido)
        {
            CONEXION cn = new CONEXION();

            using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
            {
               await connection.OpenAsync();

                foreach (var row in dc.ListPedido)
                {

                    OleDbCommand command = new OleDbCommand();

                    string query = "INSERT INTO tbl_OrdenesDeCompra (Id_Orden,Articulo)"
                                 + " VALUES (@IdPedido,@Articulo)";



                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPedido", IdPedido);
                    command.Parameters.AddWithValue("@Articulo", row.ToString());
                    
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task<int> BuscarIdPedido()
        {
            int Id = 0;
            
            try
            {
                CONEXION cn = new CONEXION();
                using (OleDbConnection conexion = new OleDbConnection(cn.ConexionCallCenter()))
                {
                   await conexion.OpenAsync();
                    string query = "Select max(Id_Orden) from tbl_DescOrdenes";

                    OleDbCommand cmd = new OleDbCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    object pedido = await  cmd.ExecuteScalarAsync();

                    if (pedido != null)
                    { 
                        Id = Convert.ToInt32(pedido);
                    }
                    else
                    {
                        Id = 0;
                    }
                }
            }
            catch (Exception)
            {

                return Id;
            }

            return Id;
        }

        public async Task<DataTable> LeerPedidoGuardado(string IdPedido)
        {
            DataTable cotizacion = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
                {
                  await connection.OpenAsync();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM PedidoGuardado where Cajon = '" + IdPedido + "'", connection);
                    adapter.Fill(cotizacion);
                }

            }
            catch (Exception)
            {

                return cotizacion;
            }
            return cotizacion;
        }

       
        public async Task<DataTable> LeerPedido(int id)
        {
            DataTable PedidoGuardadoDetalle = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
                {
                 await connection.OpenAsync();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM PedidoGuardadoDetalle WHERE Id = @Id", connection);
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

        public async Task EliminarPedido(int IdPedido)
        {
            CONEXION cn = new CONEXION();
            using (OleDbConnection connection = new OleDbConnection(cn.ConexionCallCenter()))
            {
              await connection.OpenAsync();
                OleDbCommand command = new OleDbCommand("DELETE FROM PedidoGuardado WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", IdPedido);
              await  command.ExecuteNonQueryAsync();
            }

        }

        public async Task<bool> ReimprimirPedido(string Idventa,string tabla)
        {
            bool resultado = true;
            CONEXION cn = new CONEXION();

            try
            {
                using (SqlConnection connection = new SqlConnection(cn.ConexionAzure()))
                {
                    await connection.OpenAsync();
                    string query = $"update {tabla} set impreso = 0, pendienteImpreso = 0 where Idventa = {Idventa}";

                    SqlCommand command = new SqlCommand(query, connection);

                    await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                resultado = false;
                return resultado;
            }
           return resultado;    

        }

        public async Task<DataTable> LeerInformacioPedidoRegistroLocal(string idventa, string tabla) // busca la informacion del pedido en la base de datos local
        {
            DataTable InformacionPedido = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (SqlConnection connection = new SqlConnection(cn.ConexionAzure()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tabla} WHERE IdVenta = {idventa}", connection);
                    await connection.OpenAsync();
                    //adapter.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
                    adapter.Fill(InformacionPedido);
                }
            }
            catch (Exception)
            {

                return InformacionPedido;
            }

            return InformacionPedido;
        }

        public async Task<DataTable> LeerDetallePedidoRegistroLocal(string idventa,string tabla) // busca el detalle del pedido en la base de datos local
        {
            string detalleVenta = "";
            if (tabla == "tbl_venta3") { detalleVenta = "DETALLE_VENTA3"; }
            if (tabla == "venta2") { detalleVenta = "DETALLE_VENTA2"; }
            if (tabla == "tbl_venta") { detalleVenta = "DETALLE_VENTA"; }
            DataTable PedidoDetalle = new DataTable();

            CONEXION cn = new CONEXION();

            try
            {
                using (SqlConnection connection = new SqlConnection(cn.ConexionAzure()))
                {
                    await connection.OpenAsync();
                    SqlDataAdapter adapter = new SqlDataAdapter($"select Item from {detalleVenta} where IdVenta = {idventa}", connection);
                    //adapter.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
                    adapter.Fill(PedidoDetalle);
                }
            }
            catch (Exception)
            {

                return PedidoDetalle;
            }

            return PedidoDetalle;
        }


    }
}
