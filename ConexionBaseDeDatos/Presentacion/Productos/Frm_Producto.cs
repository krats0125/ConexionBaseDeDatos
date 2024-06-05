using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Tomapedidos.Modelos;


namespace ConexionBaseDeDatos
{
    public partial class Frm_Producto : Form
    {
        Funciones CapaFunciones = new Funciones();



        public Frm_Producto()
        {
            InitializeComponent();
        }




        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            txtBuscado.Focus();
        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscado.Text;

            try
            {
                await Task.Run(() => BuscarProductos(buscado));

                if (dgv_Productos.Rows.Count > 0) // SI SE TRAEN DATOS QUE SE ENFOQUE EN LA TABLA, PARA AGILIZAR LA SELECCION, PERO E CASO CONTRARIO QUE ESTE EN EL TEXTO PARA MODIFICARLO Y REALIZAR UNA NUEVA CONSULTA
                {
                    dgv_Productos.Focus();
                }
                else
                {
                    txtBuscado.Focus();
                }
            }
            catch (Exception)
            {

                txtBuscado.Focus();
            }

           
            
        }

        private async Task BuscarProductos(string buscado)
        {
            CONEXION cn = new CONEXION();
            using (OleDbConnection conn = new OleDbConnection(cn.ConexionXpos()))
            {
                await conn.OpenAsync().ConfigureAwait(false); // ESTA LINEA PERMITE QUE NO SE TRAVE EL FORMULARIO MIENTRAS EJECUTA LA CONSULTA

                string Query = "SELECT (tblPLU.lngPLU) as PLU, (tblPLU.strDesLar) AS PRODUCTO, (tblPLU.lngPre) AS PRECIO, (tblPLU.strIDUnidad) AS MEDIDA," + 
                " (tblBodegaArticulo.sngCan) AS CANT, (tblPLU.bytDep) AS CATEGORIA, (tblPLU.strUbicacion) AS PASILLO,(blnCom) as Compuesto " +
                " FROM tblPLU INNER JOIN tblBodegaArticulo ON tblPLU.lngPLU = tblBodegaArticulo.lngPLU" +
                " WHERE (tblBodegaArticulo.lngIDBod = 1) AND (tblPLU.blnVenPer = True) AND (tblPLU.blnParaVenta = True) AND";

                string[] palabras = buscado.Split(' '); // ESTA LINEA PERMITE CONGER EL TEXTO Y SEPARARLO EN UN ARRAY POR CADA ESPACIO, ESTO ME PERMITE REALIZAR UNA CONSULTA A LA BASE DE DATOS TENIENDO ENCUENTA CADA PALABRA QUE SE ESCRIBA POR SEPARADO

                for (int x = 0; x <= palabras.GetUpperBound(0); x++)                  // GENERO UN BUCLE POR LA CANTIDAD DE PALABRAS QUE TENGO EN EL ARRAY PARA ANEXARLO A LA CONSULTA
                {
                    Query += " tblPLU.strDesLar Like '%" + palabras[x] + "%'";

                    if (x != palabras.GetUpperBound(0))
                    {
                        Query += " AND";
                    }
                }

                Query += "ORDER BY tblPLU.strDesLar";  // ORDENO LA CONSULTA POR LA DESCRIPCION


                using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                {
                    using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Actualizar la UI en el hilo de la interfaz de usuario
                        Invoke((Action)(() => dgv_Productos.DataSource = dt));

                        

                    }

                    
                }
            }
        }

        private void SeleccionarIte()
        {
           

            // Asegurarse de que haya al menos una fila seleccionada en el DataGridView
            if (dgv_Productos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgv_Productos.SelectedRows[0];

                decimal inventario = Convert.ToDecimal(filaSeleccionada.Cells["CANT"].Value);
                bool compuesto = Convert.ToBoolean(filaSeleccionada.Cells["Compuesto"].Value);

                if (inventario <= 0 && compuesto == false)
                {
                    MessageBox.Show("No hay inventario de este producto");
                    return;
                
                }


                    // Solicitar la cantidad al usuario utilizando el método MostrarInputBox

                    // resInputBox es un objeto {valorIngresado : "1" , uMedida:"UND" }
                    InputBoxMessage resInputBox = new InputBoxMessage();

                string cant = "";
                string uMedida = "";
                string departamento = filaSeleccionada.Cells["CATEGORIA"].Value.ToString();
                string descripcion = "";

                if (departamento == "70")
                {
                    resInputBox = CapaFunciones.MostrarInputBox("Cantidad?", "1", true);

                }
                else
                {
                    resInputBox = CapaFunciones.MostrarInputBox("Cantidad?", "1", false);
                }
                            

                cant = resInputBox.Descripcion.ToString();
                uMedida = resInputBox.Umedida.ToString();
                
               
                if (departamento == "70" )
                {
                    var objeto2 = CapaFunciones.MostrarInputBox("Descripcion?");

                    descripcion = objeto2.Descripcion.ToString();
                    descripcion = "///" + descripcion.ToUpper();
                    
                }

                decimal LogicaPecio = 0;
                if (uMedida == "LIBRA")
                {
                    LogicaPecio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value) / 2;


                }
                else
                {
                    LogicaPecio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);

                }

               

                DatosPedido Item = new DatosPedido {

                    Cantidad = cant,
                    Plu = Convert.ToInt32(filaSeleccionada.Cells["PLU"].Value),
                    Producto =  uMedida + " " + filaSeleccionada.Cells["PRODUCTO"].Value.ToString(),
                    Descripcion = descripcion,
                    Precio = LogicaPecio,
                    Departamento = filaSeleccionada.Cells["CATEGORIA"].Value.ToString(),
                    Ubicacion = filaSeleccionada.Cells["PASILLO"].Value.ToString()


                  

                };
             
                    TomaPedido tomaPedidoForm = ObtenerInstanciaTomaPedido();

                if (tomaPedidoForm != null)
                {
                    // Acceder al control dgvPedido a través de la propiedad expuesta
                    DataGridView dgvPedido = tomaPedidoForm.DgvPedido;
                    dgvPedido.Rows.Add(Item.Cantidad,Item.Plu,Item.Producto,Item.Descripcion,Item.Precio,Item.Departamento,Item.Ubicacion);

                    tomaPedidoForm.CalcularSumatoria();
                }
                else
                {
                    MessageBox.Show("El formulario TomaPedido no está abierto.");
                }

                txtBuscado.Text = "";

                txtBuscado.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }

            
        }
        private TomaPedido ObtenerInstanciaTomaPedido()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TomaPedido tomaPedidoForm)
                {
                    return tomaPedidoForm;
                }
            }
            return null;
        }


        private void txtBuscado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar.Focus();
                e.SuppressKeyPress = true; // Evitar el sonido
                e.Handled = true;
            }
        }

        private void dgv_Productos_KeyDown_1(object sender, KeyEventArgs e)
        {
        
        if (e.KeyCode == Keys.Enter)
            {
                // Evitamos que la tecla Enter sea procesada por el control por defecto
                e.Handled = true;
                e.SuppressKeyPress = true;
                //

                SeleccionarIte();

            } 
        }

        private async void btnBuscarCarne_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscado2.Text;

            // Ejecutar el método asincrónico en un nuevo hilo
            await Task.Run(() => BuscarProductosCarniceria(buscado));

            if (dvgProductosCarniceria.Rows.Count > 0) // SI SE TRAEN DATOS QUE SE ENFOQUE EN LA TABLA, PARA AGILIZAR LA SELECCION, PERO E CASO CONTRARIO QUE ESTE EN EL TEXTO PARA MODIFICARLO Y REALIZAR UNA NUEVA CONSULTA
            {
                dvgProductosCarniceria.Focus();
            }
            else
            {
                txtBuscado2.Focus();
            }
        }

        private async Task BuscarProductosCarniceria(string buscado)
        {
            CONEXION cn = new CONEXION();
            using (OleDbConnection conn = new OleDbConnection(cn.ConexionCallCenter()))
            {
                await conn.OpenAsync().ConfigureAwait(false); // ESTA LINEA PERMITE QUE NO SE TRAVE EL FORMULARIO MIENTRAS EJECUTA LA CONSULTA

                string Query = @"SELECT codigo,[Nombre Comercial] , precio, medida  FROM tbl_carnes 
                                 WHERE Agotado = false and [Nombre Comercial] Like '%" + buscado + "%'";

              
                using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                {
                    using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Actualizar la UI en el hilo de la interfaz de usuario
                        Invoke((Action)(() => dvgProductosCarniceria.DataSource = dt));



                    }


                }
            }
        }

        private void SeleccionarItemCarne()
        {


            // Asegurarse de que haya al menos una fila seleccionada en el DataGridView
            if (dvgProductosCarniceria.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dvgProductosCarniceria.SelectedRows[0];

              

                // Solicitar la cantidad al usuario utilizando el método MostrarInputBox

                InputBoxMessage resInputBox = new InputBoxMessage();

                string cant = "";
                string uMedida = "";
                string departamento = "85";
                string descripcion = "";

                if (departamento == "85")
                {
                    resInputBox = CapaFunciones.MostrarInputBox("Cantidad?", "1", true);

                }
                else
                {
                    resInputBox = CapaFunciones.MostrarInputBox("Cantidad?", "1", false);
                }

                cant = resInputBox.Descripcion.ToString();
                 if(resInputBox.Umedida != null) 
                  { uMedida = resInputBox.Umedida.ToString(); }
                


                if (departamento == "85")
                {
                    var objeto2 = CapaFunciones.MostrarInputBox("Descripcion?");

                    descripcion = objeto2.Descripcion.ToString();
                    descripcion = "..." + descripcion.ToUpper();
                }

                decimal LogicaPecio = 0;

                if (uMedida == "LIBRA")
                {
                    LogicaPecio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value) / 2;


                }
                else 
                {
                    LogicaPecio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);

                }

                


                DatosPedido Item = new DatosPedido
                {

                    Cantidad = cant,
                    Plu = Convert.ToInt32(filaSeleccionada.Cells["codigo"].Value),
                    Producto = uMedida + " " + filaSeleccionada.Cells["Nombre Comercial"].Value.ToString(),
                    Descripcion = descripcion,
                    Precio = LogicaPecio,
                    Departamento = departamento,
                    Ubicacion = "2"


                    /* Cantidad = cant,
                     Plu = Convert.ToInt32(filaSeleccionada.Cells["LngPLU"].Value),
                     Producto = filaSeleccionada.Cells["strDesLar"].Value.ToString(),
                     Descripcion = descripcion,
                     Precio = Convert.ToDecimal(filaSeleccionada.Cells["LngPre"].Value),
                     Departamento = filaSeleccionada.Cells["bytDep"].Value.ToString(),
                     Ubicacion = filaSeleccionada.Cells["strUbicacion"].Value.ToString()*/

                };

                TomaPedido tomaPedidoForm = ObtenerInstanciaTomaPedido();

                if (tomaPedidoForm != null)
                {
                    // Acceder al control dgvPedido a través de la propiedad expuesta
                    DataGridView dgvPedido = tomaPedidoForm.DgvPedido;
                    dgvPedido.Rows.Add(Item.Cantidad, Item.Plu, Item.Producto, Item.Descripcion, Item.Precio, Item.Departamento, Item.Ubicacion);

                    tomaPedidoForm.CalcularSumatoria();
                }
                else
                {
                    MessageBox.Show("El formulario TomaPedido no está abierto.");
                }

                txtBuscado2.Text = "";

                txtBuscado2.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }


        }

        private void dvgProductosCarniceria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitamos que la tecla Enter sea procesada por el control por defecto
                e.Handled = true;
                e.SuppressKeyPress = true;
                //

                SeleccionarItemCarne();

            }
        }

        private void salirAlPresionarScape(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Escape, si lo es cierra el formulario
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; // Evitar el sonido
                e.Handled = true;
                this.Close();
            }
        }

        private void txtBuscado2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCarne.Focus();
                e.SuppressKeyPress = true; // Evitar el sonido
                e.Handled = true;
            }
        }

        private async void btnBuscarPromocion_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscado3.Text;

            // Ejecutar el método asincrónico en un nuevo hilo
            await Task.Run(() => BuscarProductosPromocion(buscado));

            if (dvgProductosPromocion.Rows.Count > 0) // SI SE TRAEN DATOS QUE SE ENFOQUE EN LA TABLA, PARA AGILIZAR LA SELECCION, PERO E CASO CONTRARIO QUE ESTE EN EL TEXTO PARA MODIFICARLO Y REALIZAR UNA NUEVA CONSULTA
            {
                dvgProductosPromocion.Focus();
            }
            else
            {
                txtBuscado3.Focus();
            }
        }
        private async Task BuscarProductosPromocion(string buscado)
        {
            CONEXION cn = new CONEXION();
            using (OleDbConnection conn = new OleDbConnection(cn.ConexionXpos()))
            {
                await conn.OpenAsync().ConfigureAwait(false); // ESTA LINEA PERMITE QUE NO SE TRAVE EL FORMULARIO MIENTRAS EJECUTA LA CONSULTA

                string Query = @"SELECT codigo,[Nombre Comercial] , precio, medida  FROM tbl_carnes 
                                 WHERE Agotado = false and [Nombre Comercial] Like '%" + buscado + "%'";


                using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                {
                    using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Actualizar la UI en el hilo de la interfaz de usuario
                        Invoke((Action)(() => dvgProductosCarniceria.DataSource = dt));



                    }


                }
            }
        }



        /* Cantidad = cant,
                   Plu = Convert.ToInt32(filaSeleccionada.Cells["LngPLU"].Value),
                   Producto = filaSeleccionada.Cells["strDesLar"].Value.ToString(),
                   Descripcion = descripcion,
                   Precio = Convert.ToDecimal(filaSeleccionada.Cells["LngPre"].Value),
                   Departamento = filaSeleccionada.Cells["bytDep"].Value.ToString(),
                   Ubicacion = filaSeleccionada.Cells["strUbicacion"].Value.ToString()*/
    }

}
