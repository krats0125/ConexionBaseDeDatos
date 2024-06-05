using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    public partial class ReportesImpresion : Form
    {
        public ReportesImpresion()
        {
            InitializeComponent();
        }

        private void ReportesImpresion_Load(object sender, EventArgs e)
        {

            Opt1.Checked = true;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Opt1_CheckedChanged(object sender, EventArgs e)
        {
          await  ReporteComandas(1);
        }

        private async void Opt2_CheckedChanged(object sender, EventArgs e)
        {
            await ReporteComandas(2);
        }

        private async void Opt3_CheckedChanged(object sender, EventArgs e)
        {
            await ReporteComandas(3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private async Task ReporteComandas() 
        //{
        //    CONEXION conexion = new CONEXION();

        //    string cadenaConexion = conexion.ConexionCallCenter();
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        using (OleDbConnection con = new OleDbConnection(cadenaConexion))
        //        {
        //            await con.OpenAsync();


        //            string query = "select top 50 * from registros order by Hora desc";

        //            OleDbDataAdapter da = new OleDbDataAdapter(query, con);

        //            da.Fill(dt);


        //        }
               
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    dgvReporte.DataSource = dt;

        //}

        private async Task ReporteComandas(int tabla)
        {
            string query = "";

            switch (tabla)
            {
                case 1:
                    query = "select top 500 * from tbl_venta3 order by idventa desc";
                    break;
                case 2:
                    query = "select top 500 * from venta2 order by idventa desc";
                    break;

                case 3:
                    query = "select top 500 * from tbl_venta order by idventa desc";
                    break;
                default:
                    break;
            }

            CONEXION conexion = new CONEXION();

            string cadenaConexion = conexion.ConexionAzure();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    await con.OpenAsync();


                

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    da.Fill(dt);


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvReporte.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvReporte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tabla = "";
            // Verificar que el índice de la fila no sea el de la nueva fila (cuando se permite agregar filas)
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la primera y cuarta columna
                string Idventa = dgvReporte.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (Opt1.Checked == true) { tabla = "tbl_venta3"; }
                if (Opt2.Checked == true) { tabla = "venta2"; }
                if (Opt3.Checked == true) { tabla = "tbl_venta"; }

                if (tabla != "tbl_venta3")
                { 
                    MessageBox.Show("Esta funcion en esta tabla aun no es posible..... se esta trabajando");
                    return;
                }

                // Crear una instancia del formulario Frm_Detalle
                Frm_DetallePedido frmDetalle = new Frm_DetallePedido(Idventa, tabla);

                // Mostrar el formulario Frm_Detalle
                frmDetalle.ShowDialog();
            }
        }


    }
}
