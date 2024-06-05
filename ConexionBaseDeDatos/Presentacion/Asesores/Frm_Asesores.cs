using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos.Presentacion.Asesores
{
    public partial class Frm_Asesores : Form
    {
        public Frm_Asesores()
        {
            InitializeComponent();
        }

        private void Frm_Asesores_Load(object sender, EventArgs e)
        {
            ConsultarAsesores();
        }

        private async Task ConsultarAsesores()
        {
            try
            {

                CONEXION cn = new CONEXION();
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionCallCenter()))
                {
                    await conn.OpenAsync().ConfigureAwait(false); // ESTA LINEA PERMITE QUE NO SE TRAVE EL FORMULARIO MIENTRAS EJECUTA LA CONSULTA

                    string Query = "select * from tbl_Asesores";


                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Actualizar la UI en el hilo de la interfaz de usuario
                            Invoke((Action)(() => dgvAsesores.DataSource = dt));



                        }


                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error con la conexion, no se encontraron datos");
            }
        
        }



    }
}
