using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Logica
{
    public class CD_UnidadResidencial
    {

        public DataTable ListarUnidades()  // Se listan todas las unidades
        {
           DataTable dt = new DataTable();

            CONEXION conn = new CONEXION();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(conn.ConexionBDInterna()))
                {
                    conexion.Open();

                    string query = "select * from Unidades";

                    using (OleDbDataAdapter DA = new OleDbDataAdapter(query, conexion))
                    {
                        DA.Fill(dt);


                    }

                }
            }
            catch (Exception)
            {

                return dt;
            }
                       
            return dt;
        }
    }
}
