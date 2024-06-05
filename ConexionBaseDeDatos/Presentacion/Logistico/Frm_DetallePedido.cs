using ConexionBaseDeDatos.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    public partial class Frm_DetallePedido : Form
    {
        private string Idventa;
        private string tabla;

        public Frm_DetallePedido(string IdVenta, string tabla)
        {
            InitializeComponent();
            this.Idventa = IdVenta;
            this.tabla = tabla;

           
        }

        CD_Pedido objPedido = new CD_Pedido();

        //Variables a usar en este formulario

        
        /*
             1) traer el dato del formulario de registros (ok)
             2) realizar la busqueda de los detalles del registro (ok)
             3) realizar la busqueda de los articulos del registro (ok)
             4) tener el boton para que se reimprima el pedido de la pagina
            */
        private async void Frm_DetallePedido_Load(object sender, EventArgs e)
        {
            string tablaInternainfo = "";
            string tablaInternaDetalle = "";

            var tarea1 = objPedido.LeerInformacioPedidoRegistroLocal(Idventa, tabla);
            var tarea2 = objPedido.LeerDetallePedidoRegistroLocal(Idventa, tabla);


            DataTable[] resultados = await Task.WhenAll(tarea1, tarea2);

            //dgvInfoPedido.DataSource = resultados[0];

            foreach (DataColumn columna in resultados[0].Columns)
            {
                string nombreCampo = columna.ColumnName;
                string valorCampo = resultados[0].Rows[0][columna].ToString();
                dgvInfoPedido.Rows.Add(nombreCampo, valorCampo);
            }
            dgvPedido.DataSource = resultados[1];

            lb_IdVenta.Text = Idventa;

        }

       

        private async Task ReimprimirPedido(string idventa,string tabla)
        {
         bool resultado =  await objPedido.ReimprimirPedido(idventa, tabla);
            if (resultado) 
            { 
                MessageBox.Show("Se ha impreso correctamente.");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al reimprimir.");
            }

        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            if (tabla != "tbl_venta3")
            {
                MessageBox.Show("Esta función aun no sirve con esta tabla");
                return;
            }


            string TablaReal = "";
            if (tabla == "tbl_venta3") { TablaReal = "venta3"; }
            await ReimprimirPedido(Idventa, TablaReal);
        }
    }
}
