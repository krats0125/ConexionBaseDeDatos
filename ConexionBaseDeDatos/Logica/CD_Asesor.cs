using ConexionBaseDeDatos;
using Tomapedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Tomapedidos.Logica
{
    public class CD_Asesor
    {
        public bool Crear(Asesor asesor)
        {

            bool respuesta = false;



            CONEXION conexion = new CONEXION();

            using (OleDbConnection con = new OleDbConnection(conexion.ConexionCallCenter()))
            {
               
                con.Open();

                string query = "Insert into tbl_Asesores(Nombre,CodigoTelefono,CodigoWhatsApp) values(@Nombre,@CodigoTelefono,@CodigoWhatsApp)";

                using (OleDbCommand cmd = new OleDbCommand(query,con))
                {
                   cmd.Parameters.AddWithValue("@Nombre",asesor.Nombre);
                    cmd.Parameters.AddWithValue("@CodigoTelefono", asesor.CodigoTelefono);
                    cmd.Parameters.AddWithValue("@CodigoWhatsApp", asesor.CodigoWhatsApp);

                    cmd.ExecuteNonQuery();
                    respuesta = true;

                }


            }


            return respuesta;

        }
        public DataTable Listar() 
        {

            DataTable lista = new DataTable();

            CONEXION conexion = new CONEXION();
            try
            {
                

                using (OleDbConnection con = new OleDbConnection(conexion.ConexionCallCenter()))
                {
                    string query = "select * from tbl_Asesores";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                    da.Fill(lista);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema en la conexion con la base de datos - " + ex.Message);
               
                return lista;
            }
           
           
                return lista;

                   
        
        }

        public bool Actualizar(int IdAsesor)
        {


            bool respuesta = false;


            CONEXION conexion = new CONEXION();

            using (OleDbConnection con = new OleDbConnection(conexion.ConexionCallCenter()))
            {
                string query = "update from tbl_Asesores where IdAsesor =" + IdAsesor;



            }


            return respuesta;

        }

        public bool Eliminar(int IdAsesor)
        {

            bool respuesta = false;
                       

            CONEXION conexion = new CONEXION();

            using (OleDbConnection con = new OleDbConnection(conexion.ConexionCallCenter()))
            {
                string query = "delete from tbl_Asesores where IdAsesor =" + IdAsesor;

            }

            return respuesta;

        }
    }
}
