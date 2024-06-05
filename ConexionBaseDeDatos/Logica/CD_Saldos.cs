using ADODB;
using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomapedidos.Modelos;

namespace Tomapedidos.Logica
{
    public class CD_Saldos
    {

        /*
         1) listar parametro de estado
         2) agregar 
         3) actualizar estado
         4) actualizar jalada de información 
         5) Elimimar
         */

        public async Task<DataTable> Listar(bool estado)
        { 
           DataTable dt = new DataTable();

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {

                    await conn.OpenAsync();

                    string query = "select * from tbl_SaldosFavor where Saldado = " + estado;

                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, conn))
                    {
                        da.Fill(dt);

                    }
                }
            }
            catch (Exception)
            {

                return dt;
            }

          
                return dt;
        
        }

        public async Task<string> BuscarSaldoPendienteDelCliente(string idcliente, string asesor)
        {
            string mensaje = "";
            mensaje = await buscarDeuda(idcliente);
            /* 
            SI ENCUENTRA UN SALDOA A FAVOR DEL CLIENTE  SE GENERA UN MENSAJE, 
            DE LO CONTRARIO EL MENSAJE QUEDA VACIO
            */
            
            if (mensaje.Length > 0) 
            {

                              
               
            }
        
             return mensaje;
        
        }



        private async Task<string> buscarDeuda(string IdCliente)
        {
            string frase = "";

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {
                    await conn.OpenAsync();

                    string query = "SELECT Fecha, Valor, Motivo FROM tbl_SaldosFavor WHERE Saldado = false AND idcliente = " + IdCliente;

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                DateTime fecha = reader.GetDateTime(1);
                                decimal valor = reader.GetDecimal(3);
                                string factura = reader.GetString(4);
                                string motivo = reader.GetString(5);

                                frase = $"El cliente tiene un saldo de {valor} por motivo de {motivo} desde {fecha.ToShortDateString()} en la factura {factura}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes registrar el error si es necesario
                Console.WriteLine(ex.Message);
                return frase;
            }

            return frase;
        }

        public async Task<bool> Registrar(Saldo saldo)
        { 
          bool estado = true;

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {

                    await conn.OpenAsync();

                    string query = "insert into tbl_SaldosFavor(Idcliente, Factura, Motivo,SaldoFavor) " +
                                   "Values (@IdCliente,@Factura,@Motivo,@SaldoFavor)";

                    using (OleDbCommand cmd = new OleDbCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", saldo.IdCliente);
                        cmd.Parameters.AddWithValue("@Factura", saldo.Factura);
                        cmd.Parameters.AddWithValue("@Motivo", saldo.Motivo);
                        cmd.Parameters.AddWithValue("@SaldoFavor", saldo.SaldoFavor);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                estado = false;
                return estado;
            }



            return estado;
        }

        public async Task<bool> ActualizarEstado(Saldo saldo)
        {
            bool estado = true;

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {

                    await conn.OpenAsync();

                    string query = "insert into tbl_SaldosFavor(Idcliente, Factura, Motivo,SaldoFavor) " +
                                   "Values (@IdCliente,@Factura,@Motivo,@SaldoFavor)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", saldo.IdCliente);
                        cmd.Parameters.AddWithValue("@Factura", saldo.Factura);
                        cmd.Parameters.AddWithValue("@Motivo", saldo.Motivo);
                        cmd.Parameters.AddWithValue("@SaldoFavor", saldo.SaldoFavor);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                estado = false;
                return estado;
            }



            return estado;
        }

        public async Task<bool> ActualizarJalonDeSaldo(int IdSaldo)
        {
            bool estado = true;
            DateTime fechaAhora = DateTime.Now;
            string fecha = fechaAhora.ToString("dd/MM/yyyy HH:mm");

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {

                    await conn.OpenAsync();

                    string query = "update tbl_SaldosFavor set Saldado = true,  where id = @IdSaldo";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSaldo", IdSaldo);


                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                estado = false;
                return estado;
            }

            return estado;
        }

        public async Task<bool> Eliminar(int IdSaldo)
        {
            bool estado = true;

            try
            {
                CONEXION con = new CONEXION();

                using (OleDbConnection conn = new OleDbConnection(con.ConexionCallCenter()))
                {

                    await conn.OpenAsync();

                    string query = "delete from tbl_SaldosFavor where id = @IdSaldo";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSaldo", IdSaldo);
                       

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                estado = false;
                return estado;
            }

            return estado;
        }

        //BuscarSaldoPendienteDelCliente


        /* public string Id { get; set; }
        public string fechaIngreso { get; set; }
        public string IdCliente { get; set; }

        public decimal SaldoFavor { get; set; }

        public string Factura { get; set; }

        public string Motivo { get; set; }

        public bool Saldado { get; set; }

        public string FechaPago { get; set; }

        public string SubioInforme { get; set; }

        public string JaloInforme { get; set; }
         */
    }
}
