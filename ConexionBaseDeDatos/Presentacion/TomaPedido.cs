using ADODB;
using ConexionBaseDeDatos.Logica;
using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos.Presentacion;
using Tomapedidos.Logica.LaBodegaWeb;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.VisualBasic;
using ConexionBaseDeDatos.Utilitarios;
using System.Web.UI.WebControls;
using Tomapedidos.Logica;

namespace ConexionBaseDeDatos
{

    
    public partial class TomaPedido : Form
    {
        public DataGridView DgvPedido => dgvPedido;

        private string asesor = Principal.Asesor.ToString();
        private string puesto = Principal.Puesto.ToString();
        private string CodTel = Principal.CodTel.ToString();
        private string CodWpp = Principal.CodWpp.ToString();

        private string enlace1;
        private string enlace2;
        private string enlace3;
        private string enlace4;
        private string enlace5;
        private string enlace6;

        // variables que se usan para revisar si hubo algun cambio en la direccion

        private string nombreOriginal;  
        private string direccionOriginal;
        private bool seHaBuscado;

        // Enlace Fijo para pag de whats app. modificable si es aplicasion o pagina
        //private string PagWhatsApp = "whatsapp://send?phone=";
        private string PagWhatsApp = "https://web.whatsapp.com/send?phone=";
        //private string PagWhatsApp = "https://api.whatsapp.com/send?phone=";
      

        public TomaPedido()
        {
            InitializeComponent();
           
        }

        /*
         Datos que se deben tener del cliente
        - Nombre completo
        - Edad
        - genero
        - Direccion
        . Numero de telefono
        _______________________________ Historial de compras
        -Productos comprados anteriormente
        - frecuencia de compra
        - valor promedio por compras
        - ultima Fecha de compra
        - Total Gastado en el supermercado
        - Hora promedio de compra
         ___________________________________ Preferencias de compras
        - categoria de productos preferidos
        - Marcas favoritas
        - Tipos de productos comprados con mayor frecuencia
        - Canales de compras preferidos (Tienda fisica, online, telefono)
        - Respuesta a promociones anteriores
        - Calificaciones de satisfacción
        - Quejas o problemas recurrentes
        _____________________________________Interacciones previas con el sercicio al cliente
        - Detalle de consultas o quejas anteriores
        - Soluciones Ofrecidas
        - Preferencias de comunicación (Telefono, email, chat)
        _____________________________________ Historial de promociones a las que ha respondido en el pasado
        - promociones a las que ha respondido en el pasado
        - Ofertas especiales recibidas
        - Descuentos utilizados
        _____________________________________ Segmentación
        - Categoria de cliente (bronce, cobre, plata, oro, diamante)
        ______________________________________ Engagement en redes sociales
        - Interacciones con las redes sociales
        - Participación de encuestas y concursos en linea
        _____________________________________________         Usos

        --Ofertas personalizadas : usando el historial de compras y preferencias  de productos,
        se puede enviar ofertas personalizadas y descuentos en productos que el cliente a demostrado interez

        - Descuentos espaciale sen las horas en las que el cliente suele realizar las compras

        - Implementacion de programas de puntos y recompensas para inventivar mayores compras y fidelidad

         */ // Datos que debemos tener del cliente para ofrecerle unac compra al cliente de manera personalizada

        private async void TomaPedido_Load(object sender, EventArgs e)
        {
            lbMensajeProcesando.Visible = true;
            await RevisarGuardadores();
            lbMensajeProcesando.Visible = false;
            LoopConsultas loopConsultas = new LoopConsultas();
            loopConsultas.IniciarCiclo();

            seHaBuscado = false;

        }

        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioProductos();
        }

        private void AbrirFormularioProductos()
        {
            Frm_Producto frm = new Frm_Producto();
            frm.Show();

        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            lbMensajeProcesando.Visible = true;
            

            DateTime Hora = DateTime.Now;
            string horaFormateada = Hora.ToString("HH:mm");
            LbHoraAtencion.Text = horaFormateada;
            string telefonoBuscado = this.txtTelefono.Text;
            CD_ClienteXpos cliente = new CD_ClienteXpos();
            if(telefonoBuscado != "")
            {
               Cliente ocliente = new Cliente();

                ocliente = await Task.Run(() => cliente.BuscarTelefono(telefonoBuscado));

                txtDireccion.Text = ocliente.Direccion;
                txtNombre.Text = ocliente.Nombre;
                Lb_IdCliente.Text = ocliente.IdCliente;
                Lb_UltimaCompra.Text = ocliente.dtmFechaUltimaCompra;
                if (Lb_IdCliente.Text != "")
                {
                    //DataTable dt = new DataTable();
                    //dt = await cliente.TaerProductosPreferidosCliente(Lb_IdCliente.Text);
                    // dgvPreferidosCliente.DataSource = dt;

                   await Task.Run(async () => await cliente.TaerProductosPreferidosCliente(ocliente.IdCliente, dgvPreferidosCliente));
                    CD_Saldos saldito = new CD_Saldos();
                   //await Task.Run(async () => await saldito.BuscarSaldoPendienteDelCliente(ocliente.IdCliente));
                }
               
                if (txtDireccion.Text != "")
                {
                    seHaBuscado = true;


                }
                else 
                {
                    seHaBuscado = false;


                }
              
            };
            lbMensajeProcesando.Visible = false;


        }
        
        


        private async void btn_Guardar_Click(object sender, EventArgs e)
        {

            btn_Guardar.Enabled = false;


            DialogResult seEnvia = MessageBox.Show("Ya verificamos el pedido, Seguro(a)?", "Seleccione Medio",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (seEnvia == DialogResult.Yes)
            {
                ValidacionCampos();
                await Enviar();
                btn_Guardar.Enabled = true;
            }
            else if (seEnvia == DialogResult.No)
            {
                btn_Guardar.Enabled = true;
                return;
            }

            btn_Guardar.Enabled = true;
        }

        private void ValidacionCampos()
        {

            if (txtTelefono.Text == "" && chkAnexo.Checked != true)
            {
                MessageBox.Show("El Campo del telefono no puede estar vacio");
                return;
            }

            if (cb_MedioPedido.Text == "" && chkAnexo.Checked != true)
            {

                DialogResult result = MessageBox.Show("¿Por qué medio realizó el pedido? si) Telefono y No) Whatsapp", "Seleccione Medio",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    cb_MedioPedido.Text = "TELEFONO";
                }
                else if (result == DialogResult.No)
                {
                    cb_MedioPedido.Text = "WHATS´APP";
                }


                MessageBox.Show("El medio del pedido no puede estar vacio, elije entre Telefono o Whastapp");

            }

            //VerificarCambios(); // este metodo asincrono  lo uso para actualizar los datos de los clientes.  solo el campo direccion y Nombre

            


        }

        private async Task Enviar()
        {
                        
            lbMensajeProcesando.Visible = true;

            DatosComanda DC = new DatosComanda();
            DC = asignacionValores();


            if (chkAnexo.Checked != true)
            {
                //string mensajesPlataformas = "";
                // 1) Guardar datos en la base de datos y obtener el id del pedido

                CD_Pedido objPedido = new CD_Pedido();
                int Pedido = await objPedido.GuardarPedido(DC);

                // 2) Revisar si se debe de enviar a la plataforma de la veciendad

                //mensajesPlataformas = EnvioAPaginas();

                AccionesHTTP accionesHTTP = new AccionesHTTP();

                try
                {
                    string mensaje = "";

                    // Ejecutar ambas tareas en paralelo
                    var tareas = new[]
                    {
                           accionesHTTP.EnviarALaVecindad(DC, Pedido),
                           accionesHTTP.EnviarAPaginaWebLaBodega(DC, Pedido)
                    };

                    var resultados = await Task.WhenAll(tareas);

                    // Verificar resultados
                    bool PrimeraPagina = resultados[0];
                    bool SegundaPagina = resultados[1];

                    if (!PrimeraPagina) { mensaje += "- No se pudo enviar el Pedido a la pagina la vecindad "; }
                    if (!SegundaPagina) { mensaje += "- No se pudo enviar el Pedido a la pagina del Supermercado"; }

                    // Mostrar mensaje en caso de errores
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        await LimpiarCampos();
                    }

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error");
                }

                /*
                try
                {
                                        
                    string mensaje = "";

                    bool PrimeraPagina = await accionesHTTP.EnviarALaVecindad(DC, Pedido);
                    if (!PrimeraPagina) { mensaje += "- No se pudo enviar el Pedio a la pagina la vecindad "; }

                    bool SegundaPagina = await accionesHTTP.EnviarAPaginaWebLaBodega(DC, Pedido);
                    if (!SegundaPagina) { mensaje += "- No se pudo enviar el Pedido a la pagina del Supermercado"; }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error");
                }
                */


                // 3) Imprimir (Teniendo en cuenta que se debe de organizar por pasillo y categoria)

                // 4) Imprimir productos de la carniceria  --  por ahora se enviara en el json que se imprima en la macro de la impresion automatica

                // 5) Imprimir productos de la legumbreria -- por ahora se enviara en el json que se imprima en la macro de la impresion automatica

                // Imprimir en caso de que no se requiera que se envie a la web

                // DefinirVariablesAImprimir(DC);

                // 6) Borrar datos del formulario para un nuevo pedido


            }
            else
            {
                DefinirVariablesAImprimir(DC);
                await LimpiarCampos();
            }

           

            lbMensajeProcesando.Visible = false;

        }

        private DatosComanda asignacionValores()
        {
            string asesor = Principal.Asesor.ToString();
            string puesto = Principal.Puesto.ToString();
            string CodTel = Principal.CodTel.ToString();
            string CodWpp = Principal.CodWpp.ToString();


            DatosComanda DC = new DatosComanda();
            DC.Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            DC.Hora = DateTime.Now.ToString("HH:mm");
           
            DC.Telefono = txtTelefono.Text;
            if (txtNombre.Text == "") { DC.Nombre = "SIN NOMBRE" ; } else { DC.Nombre = txtNombre.Text;}
            if (txtDireccion.Text == "") { DC.Direccion = "SIN DIRECCION"; } else { DC.Direccion = txtDireccion.Text; }
            DC.Puesto = puesto;
            if (Lb_IdCliente.Text == "" || Lb_IdCliente.Text == "0")
            {
                Random random = new Random();

                // Generar un número aleatorio entre 1 y 10000 si el cliente no esta creado para envitar problemas con la vecindad
                DC.IdCliente = (random.Next(1, 10001)).ToString();
               
            }
            else
            {
                DC.IdCliente = Lb_IdCliente.Text;
            }
                   
            
            //DC.IdPedido = string.Empty; // el idpedido se asigna cuando el pedido se agrego a la base de datos 
            DC.Novedad = txtNovedad.Text;
            DC.CantArticulos = lb_CantArticulos.Text;
            DC.EstadoPQRS = Lb_Estado.Text;
            DC.MedioPago = cbMedioPago.Text;
            DC.Medio = cb_MedioPedido.Text;
            DC.Categoria = Lb_Categoria.Text;

            if (DC.Medio == "TELEFONO")
            {
                DC.Asesor = asesor + "-" + CodTel;

            }
            else
            {
                DC.Asesor = asesor + "-" + CodWpp;
            }
            





            DataTable PedidoDT = new DataTable();
            

            List<string> listaDePedidos = new List<string>();

            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                // Ignorar la última fila vacía si está presente
                if (fila.IsNewRow)
                    continue;

                // Obtener los valores de cada celda en la fila
                string cantidad = fila.Cells["Cantidad"].Value?.ToString() ?? "";
                string producto = fila.Cells["Producto"].Value?.ToString() ?? "";
                // logica de que si es de la categoria carne o legumbre poner el respectivo caracter
                string descripcion = fila.Cells["Descripcion"].Value?.ToString().ToUpper() ?? "";

                string separador = "";
                if (descripcion.Length > 0) { separador = "->"; }
                // Concatenar los valores en un string y agregarlo a la lista
                string pedido = $"{cantidad} {producto} {separador} {descripcion}";
                listaDePedidos.Add(pedido);
            }
            DC.ListPedido = listaDePedidos;

            return DC;

        }


        //1) Guardar datos en la base de datos y obtener el id del pedido

        private int GuardarDatosEnLaBaseDeDatos() 
        {
            int respuesta = 0;





            return respuesta;
        }

        //2) Revisar si se debe de enviar a la plataforma de la veciendad

        

        private void DefinirVariablesAImprimir(DatosComanda DC)
        {
            
            // Configuración de la impresora
            PrintDocument printDocument = new PrintDocument();
            Servicios servicio = new Servicios();
            printDocument.PrintPage += (sender, e) => servicio.ImprimirRecibo(e, DC);

            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           if( dgvPedido.SelectedRows.Count > 0) 
            {
                lbMensajeProcesando.Visible = true;
                DataGridViewRow filaSeleccionada = dgvPedido.SelectedRows[0];
                dgvPedido.Rows.Remove(filaSeleccionada);
                CalcularSumatoria();
                lbMensajeProcesando.Visible = false;

            }
           else
            {
                MessageBox.Show("No Has seleccionado ningun item");
            }    
        }

        private void ImprimirCarne()
        {

            PrintDocument pd = new PrintDocument();

            // Establecer el nombre de la impresora compartida en red
            pd.PrinterSettings.PrinterName = @"\\carniceria-pc\impCarne";

            // Manejar el evento de impresión para especificar el contenido a imprimir
            pd.PrintPage += new PrintPageEventHandler(this.OnPrintPage);

            // Iniciar el proceso de impresión
            pd.Print();
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            // Aquí puedes especificar el contenido que deseas imprimir
            // Por ejemplo, puedes dibujar texto o gráficos en el área de impresión

            // Ejemplo: Imprimir el texto "Hola, mundo!"
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString("Hola, mundo!", font, Brushes.Black, 10, 10);
        }

       


        public void CalcularSumatoria()
        {
            // Variable para almacenar la sumatoria
            double sumatoria = 0;

            double Cantidad = 0;
            double Precio = 0;
            
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    // Verificamos si la fila no es nula y tiene celdas
                    if (row != null)
                    {
                        if (row.IsNewRow)
                            continue;

                    if (!double.TryParse(row.Cells[0].Value?.ToString(), out Cantidad))
                    {
                        Cantidad = 0;
                    }

                    if (!double.TryParse(row.Cells[4].Value?.ToString(), out Precio))
                    {
                        Precio = 0;
                    }


                       // Cantidad = Convert.ToDouble(row.Cells[0].Value.ToString());
                       // Precio = Convert.ToDouble(row.Cells[4].Value.ToString());

                        sumatoria += Cantidad * Precio;

                    }
                }
            
            // Recorremos cada fila del DataGridView
            

            lbTotal.Invoke((MethodInvoker)delegate
            {
                lbTotal.Text = sumatoria.ToString();
            });

            Invoke((MethodInvoker)delegate {
                CalcularCantidadArticulos();
            });

            


        }

        private void CalcularCantidadArticulos()
        {
            // Variable para almacenar la sumatoria
            double sumatoria = 0;
            double Cantidad = 0;

            // Acceder al control lb_CantArticulos dentro del subproceso principal
            lb_CantArticulos.Invoke((MethodInvoker)delegate
            {
                // Recorremos cada fila del DataGridView
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    // Verificamos si la fila no es nula y tiene celdas
                    if (row != null && !row.IsNewRow && row.Cells[0].Value != null)
                    {

                        if (!double.TryParse(row.Cells[0].Value?.ToString(), out Cantidad))
                        {
                            Cantidad = 0;
                        }
                       // double cantidad = Convert.ToDouble(row.Cells[0].Value.ToString());
                        sumatoria += Cantidad;
                    }
                }

                // Actualizar el control lb_CantArticulos con la sumatoria en el subproceso principal
                lb_CantArticulos.Text = sumatoria.ToString();
            });
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres limpiar el formulario?", "LIMPIAR FORMULARIO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                LimpiarCampos();
            }
            else if (result == DialogResult.No)
            {
               
            }
           
        }
        private async Task LimpiarCampos() 
        {
            
            dgvPedido.Invoke((MethodInvoker)delegate { dgvPedido.Rows.Clear(); });
            dgvPreferidosCliente.Invoke((MethodInvoker)delegate { dgvPreferidosCliente.DataSource = null; dgvPreferidosCliente.Rows.Clear(); });
            txtNombre.Invoke((MethodInvoker)delegate { txtNombre.Text = string.Empty; });
            txtTelefono.Invoke((MethodInvoker)delegate { txtTelefono.Text = string.Empty; });
            txtDireccion.Invoke((MethodInvoker)delegate { txtDireccion.Text = string.Empty; });
            Lb_IdCliente.Invoke((MethodInvoker)delegate { Lb_IdCliente.Text = string.Empty; });
            cbMedioPago.Invoke((MethodInvoker)delegate { cbMedioPago.Text = "EFECTIVO"; });
            txtNovedad.Invoke((MethodInvoker)delegate { txtNovedad.Text = string.Empty; });
            chkAnexo.Invoke((MethodInvoker)delegate { chkAnexo.Checked = false; ; });
            cb_MedioPedido.Invoke((MethodInvoker)delegate { cb_MedioPedido.Text = string.Empty; });
            

            // los label que se usan como datos del cliente
            Lb_Estado.Invoke((MethodInvoker)delegate { Lb_Estado.Text = string.Empty; ; });
            Lb_Categoria.Invoke((MethodInvoker)delegate { Lb_Categoria.Text = string.Empty; });
            Lb_UltimaCompra.Invoke((MethodInvoker)delegate { Lb_UltimaCompra.Text = "Sin Dato"; });
            Lb_Ultima_factura.Invoke((MethodInvoker)delegate { Lb_Ultima_factura.Text = "No Tiene"; });
            lb_Ticket_Promedio.Invoke((MethodInvoker)delegate { lb_Ticket_Promedio.Text = "$ 00.000"; });
            Lb_Hora_Compra_Promedio.Invoke((MethodInvoker)delegate { Lb_Hora_Compra_Promedio.Text = "Sin Dato"; });




            btnSemaforo1.Invoke((MethodInvoker)delegate { btnSemaforo1.Visible = false; });
            btnSemaforo2.Invoke((MethodInvoker)delegate { btnSemaforo2.Visible = false; });
            btnSemaforo3.Invoke((MethodInvoker)delegate { btnSemaforo3.Visible = false; });
            btnSemaforo4.Invoke((MethodInvoker)delegate { btnSemaforo4.Visible = false; });
            

            LbHoraAtencion.Invoke((MethodInvoker)delegate { LbHoraAtencion.Text = "0:00"; });

            nombreOriginal = "";
            direccionOriginal = "";

            seHaBuscado = false;


            CalcularSumatoria();
           

        }

       
        private void ProductosPreferidosCliente() 
        {
        
        }

        private CD_Guardadores PedidoGuardado = new CD_Guardadores();

        #region Guardadores

        private async Task RevisarGuardadores()
        {
            await Task.Run(async () =>
            {
                for (int i = 1; i <= 6; i++)
                {
                    List<int> Colorear = await PedidoGuardado.RevisarCajones();

                    foreach (int c in Colorear)
                    {
                        Control[] foundControls = Controls.Find("Guardador_" + c, true);
                        if (foundControls.Length > 0 && foundControls[0] is System.Windows.Forms.Button)
                        {
                            System.Windows.Forms.Button button = (System.Windows.Forms.Button)foundControls[0];
                            button.BackColor = Color.Red;
                        }
                    }


                }
            });
        }

        // cada guardador debe
        /*
         1) asignar el cajon
         2) revisar si hay datos con el cajon
         3) en caso de haber datos, traer los datos y luego pintar el boton de azul
         4) en caso de no haber datos, guardar los datos que hay en el formulario y pintar el boton de rojo
         */

        private async Task ProcesarCajon(string cajon,System.Windows.Forms.Button boton, System.Windows.Forms.Label label)
        {
            Invoke((MethodInvoker)(() =>
            {
                lbMensajeProcesando.Visible = true;
            }));
            
            try
            {
                int hayDatos = await PedidoGuardado.RevisarCajon(cajon);

                if (hayDatos > 0)
                {
                    if (txtTelefono.Text.Length > 0) // en caso de que vaya a a traer un pedido que sobrescriba el pedido que ya esta montado
                    {
                        MessageBox.Show("si deseas sobreescribir el pedido, es mejor que lo borres y luego traigas el pedido guardado");
                        return;

                    }
                    await TraerPedidoGuardado(cajon);

                    Invoke((MethodInvoker)(() =>
                    {
                        boton.BackColor = Color.FromArgb(0, 0, 120);
                        label.Text = "0:00";
                    }));
                }
                else
                {
                    await GuardarPedido(cajon);

                    Invoke((MethodInvoker)(() =>
                    {
                        boton.BackColor = Color.Red;
                        label.Text = DateTime.Now.ToString("HH:mm");
                    }));
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción apropiadamente
                Console.WriteLine($"Error al procesar el cajón {cajon}: {ex.Message}");
            }
            Invoke((MethodInvoker)(() =>
            {
                lbMensajeProcesando.Visible = false;
            }));
        }


        private async void Guardador_1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("1", Guardador_1, l_Hora_G_1));
        }

        private async void Guardador_2_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("2", Guardador_2, l_Hora_G_2));


        }

        private async void Guardador_3_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("3", Guardador_3, l_Hora_G_3));

        }

        private async void Guardador_4_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("4", Guardador_4, l_Hora_G_4));
        }

        private async void Guardador_5_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("5", Guardador_5, l_Hora_G_5));
        }

        private async void Guardador_6_Click(object sender, EventArgs e)
        {
            await Task.Run(() => ProcesarCajon("6", Guardador_6, l_Hora_G_6));
        }



        private async Task GuardarPedido(string cajon)
        {
            // Crear copias de los datos de la interfaz de usuario para asegurar el acceso seguro
            string telefono = "";
            string medioPago = "";
            string nombre = "";
            string direccion = "";
            string idCliente = "";
            string novedad = "";

            // Acceder a los controles de la interfaz de usuario dentro del subproceso principal
            txtTelefono.Invoke((MethodInvoker)delegate { telefono = txtTelefono.Text; });
            cbMedioPago.Invoke((MethodInvoker)delegate { medioPago = cbMedioPago.Text; });
            txtNombre.Invoke((MethodInvoker)delegate { nombre = txtNombre.Text; });
            txtDireccion.Invoke((MethodInvoker)delegate { direccion = txtDireccion.Text; });
            Lb_IdCliente.Invoke((MethodInvoker)delegate { idCliente = Lb_IdCliente.Text; });
            txtNovedad.Invoke((MethodInvoker)delegate { novedad = txtNovedad.Text; });

           



            DataTable detalleCotizacion = null;
            dgvPedido.Invoke((MethodInvoker)delegate {
                Servicios servicio = new Servicios();
                detalleCotizacion = servicio.ConvertirDataGridViewToDataTable(dgvPedido);
            });

            DatosComanda DC = new DatosComanda();

            DC.Hora = DateTime.Now.ToString("HH:mm:ss");
            DC.Asesor = asesor;
            DC.Telefono = telefono;
            DC.MedioPago = medioPago;
            DC.Nombre = nombre;
            DC.Direccion = direccion;
            DC.Puesto = puesto;
            DC.IdCliente = idCliente;
            DC.Novedad = novedad;
            DC.Cajon = cajon;

            // Guardar la pedido en la base de datos junto con el detalle
            bool seGuardo = await PedidoGuardado.AgregarAPedidosGuardados(DC, detalleCotizacion);

            if (seGuardo) { LimpiarCampos(); }

            switch (cajon)
            {
                case "1":
                    enlace1 = "57" + telefono;
                    break;
                case "2":
                    enlace2 = "57" + telefono;
                    break;
                case "3":
                    enlace3 = "57" + telefono;
                    break;
                case "4":
                    enlace4 = "57" + telefono;
                    break;
                case "5":
                    enlace5 = "57" + telefono;
                    break;
                case "6":
                    enlace6 = "57" + telefono;
                    break;
                default:
                    break;
            }
        }


        private async Task TraerPedidoGuardado(string cajon)
        {
            // Leer la cotización desde la base de datos
            try
            {
                DataTable pedido = await PedidoGuardado.LeerPedidoGuardado(cajon);
                if (pedido.Rows.Count > 0)
                {
                    DatosComanda DC = new DatosComanda();

                    int IdPedidoGuardado = Convert.ToInt32(pedido.Rows[0]["Id"]);

                    // Mostrar los datos de la cotización en los controles del formulario
                    this.Invoke((MethodInvoker)delegate {
                        txtNombre.Text = pedido.Rows[0]["Nombre"].ToString();
                        txtTelefono.Text = pedido.Rows[0]["Telefono"].ToString();
                        txtDireccion.Text = pedido.Rows[0]["Direccion"].ToString();
                        Lb_IdCliente.Text = pedido.Rows[0]["IdCliente"].ToString();
                        cbMedioPago.Text = pedido.Rows[0]["MedioPago"].ToString();
                        txtNovedad.Text = pedido.Rows[0]["Novedad"].ToString();

                    });

                    // Leer el detalle de la cotización desde la base de datos
                    DataTable detalleCotizacion = await PedidoGuardado.LeerPedidoGuardadoDetalle(IdPedidoGuardado);

                    if (detalleCotizacion.Rows.Count > 0)
                    {
                        foreach (DataRow producto in detalleCotizacion.Rows)
                        {
                            DatosPedido Item = new DatosPedido();

                            Item.Cantidad = producto["Cantidad"].ToString();
                            if (producto["Plu"].ToString() != "")
                            {
                                Item.Plu = Convert.ToInt32(producto["Plu"].ToString());
                            }
                            Item.Producto = producto["Producto"].ToString();
                            Item.Descripcion = producto["Descripcion"].ToString();
                            if (producto["Precio"].ToString() == null || producto["Precio"].ToString() == string.Empty)
                            {
                                Item.Precio = 0;
                            }
                            else
                            {
                                Item.Precio = Convert.ToDecimal(producto["Precio"].ToString());
                            }

                            Item.Departamento = producto["Cantidad"].ToString();
                            Item.Ubicacion = producto["Ubicacion"].ToString();

                            dgvPedido.Invoke((MethodInvoker)delegate {
                                dgvPedido.Rows.Add(Item.Cantidad, Item.Plu, Item.Producto, Item.Descripcion, Item.Precio);
                            });
                        }

                    }

                    await PedidoGuardado.EliminarPedidoGuardado(IdPedidoGuardado);

                    Invoke((MethodInvoker)delegate {
                        CalcularSumatoria();
                    });

                    switch (cajon)
                    {
                        case "1":
                            enlace1 = "";
                            break;
                        case "2":
                            enlace2 = "";
                            break;
                        case "3":
                            enlace3 = "";
                            break;
                        case "4":
                            enlace4 = "";
                            break;
                        case "5":
                            enlace5 = "";
                            break;
                        case "6":
                            enlace6 = "";
                            break;
                        default:
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }



        #endregion // todas los metodos de los guardadores 

        private async Task EnviarAWeb()
        {

            /*
             "IdCliente":
                "NombreCliente":
                "TelefonoCliente":
                "TelefonoCliente2":
                "TelefonoCliente3":
                "TelefonoCliente4":
                "DireccionCliente":
                "Vendedor":
                "Pedido":
                "FechaPedido":
                "HoraPedido":
                "Novedad" :
                "MedioPago":
                "Canal":

             */


            // Crear una instancia de la venta con los datos del formulario
            VentaWeb venta = new VentaWeb
            {
                /*
                IdCliente = Lb_IdCliente.ToString(),
                NombreCliente = txt

                IdVenta = int.Parse(txtIdVenta.Text),
                Valor = decimal.Parse(txtValor.Text),
                Fecha = dateTimePickerFecha.Value,
                Detalles = new List<DetalleVenta>()
                */
            };

            // Agregar detalles de venta (puedes repetir este bloque para agregar más detalles)
            DetalleVenta detalle = new DetalleVenta
            {
                /*
                Item = txtItem.Text,
                Descripcion = txtDescripcion.Text
                */
            };
            venta.Productos.Add(detalle);

            CD_VentaWeb vent = new CD_VentaWeb();

            // Enviar la venta al servidor
            await vent.EnviarVenta(venta);
        }


        #region Teclas para accesos directos
        private async void LecturaDeTeclasParaAccesosDirectos(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AbrirFormularioProductos();  //metodo para abrir el formulario de los productos
                    e.SuppressKeyPress = true; // Evitar el sonido
                    e.Handled = true;
                    break;

                default:
                    break;
            }

            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:

                        btn_Guardar_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D1:
                        Guardador_1_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D2:
                        Guardador_2_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D3:
                        Guardador_3_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D4:
                        Guardador_4_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D5:
                        Guardador_5_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.D6:
                        Guardador_6_Click(sender, e);
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.Q:
                        MensajePreguntaDireccion(); // MetodoCtrlC(); Metodo para copiar las lista de los productos  y con un mensaje de confirmacion
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.W:
                        MensajePreguntaPedido();// MetodoCtrlD(); // Metodo para copiar los datos del cliente para luego ser enviado por whatsapp
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.E:
                        // MetodoCtrlE();
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.M:
                        cbMedioPago.Focus();
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    case Keys.N:
                        txtNovedad.Focus();
                        e.SuppressKeyPress = true; // Evitar el sonido
                        e.Handled = true;
                        break;
                    // Agregar más combinaciones Ctrl+[tecla] según sea necesario
                    default:
                        e.SuppressKeyPress = false; // Evitar el sonido
                       // e.Handled = true;
                        break;
                }
            }
        }

        #endregion


        #region Botones de Enlaces Whats App
        private void btnEnlaceWpp1_Click(object sender, EventArgs e)
        {
           

            //string url = $"https://api.whatsapp.com/send?phone={enlace1}"; //&text={Uri.EscapeDataString(mensaje)}";


            //string url = $"https://web.whatsapp.com/send?phone={enlace1}";

            string url = $"{PagWhatsApp}{enlace1}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnEnlaceWpp2_Click(object sender, EventArgs e)
        {
            string url = $"{PagWhatsApp}{enlace2}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnEnlaceWpp3_Click(object sender, EventArgs e)
        {
            string url = $"{PagWhatsApp}{enlace3}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnEnlaceWpp4_Click(object sender, EventArgs e)
        {
            string url = $"{PagWhatsApp}{enlace4}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnEnlaceWpp5_Click(object sender, EventArgs e)
        {
            string url = $"{PagWhatsApp}{enlace5}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnEnlaceWpp6_Click(object sender, EventArgs e)
        {
            string url = $"{PagWhatsApp}{enlace6}";

            // Abrir la URL en el navegador predeterminado
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        #endregion


        #region Eventos de cambios en las celdas


        private void VerificarCambios()
        {

            if (seHaBuscado) // seHaBuscado es una variable que se utilliza para ver si recien realice una busqueda. y esto confirma que se trajo los datos de un cliente registrado
            {
                // se revisa su hubo algun cambio en los datos que se trajeron inicialmente. 
                if (txtNombre.Text != nombreOriginal || txtDireccion.Text != direccionOriginal)
                {

                    //  se debe proceder a buscar si la direccion que se puso ya esta creada en el sistema 

                    /*
                     - De estar creada la dirección, que debe revisar si hay un campo libre de la direccion en los campos de los telefonos,
                    y si lo hay agregar el numero al campo del telefono... ¿pero que pasa con la direccion que estaba ocupando anterioirmente 
                    nuestro cliente ?- despues de ingresar el dato a la direccion y liego eliminar el telefono de la direccion
                    {
                    caso: el  hombre de la casa ya no quiere vivir con los papas, y por lo tanti decide vivir en otro apartamento pero cerca del
                    apartamento de los padres...
                    
                    }
                     
                    otra de las opciones es que se borre todos los numeros de la direccion anterior. suponiendo que todo el grupo familiar se cambio
                    de casa.

                     
                     
                     
                     */

                    DialogResult result = MessageBox.Show("¿Desea actualizar el Nombre y la Direccion del cliente?", "Confirmar Actualización", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Cliente ocliente = new Cliente();
                        ocliente.IdCliente = Lb_IdCliente.Text;
                        ocliente.Nombre = txtNombre.Text;
                        ocliente.Direccion = txtDireccion.Text;


                        CD_ClienteXpos obj = new CD_ClienteXpos();

                        obj.ActualizarNombreYDireccion(ocliente);
                                       


                    }
                    else
                    {
                        // Restaurar los valores originales
                        txtNombre.Text = nombreOriginal;
                        txtDireccion.Text = direccionOriginal;
                    }
                }
            }
            
            
        }



        #endregion

        #region Mensajes De Confirmacion de Infomacion al cliente Direccion y Pedido


        private void MensajePreguntaDireccion()
        {
            string direccion = txtDireccion.Text;
            //direccion = direccion.Replace(" ", "%20");
            string mensaje = "Me confirmas si tenemos correcta la dirección:";
           // mensaje = mensaje.Replace(" ", "%20");
            //string telefono = "57" + txtTelefono.Text;
            //string url = $"{PagWhatsApp}{telefono}&text={mensaje}{direccion}";

            string mensajeCompiado = $"{mensaje} {direccion}?";

            //MessageBox.Show(url);

            // Abrir la URL en el navegador predeterminado
            //Process.Start(new ProcessStartInfo
            //{
            //    FileName = url,
            //    UseShellExecute = true
            //});



            Clipboard.SetText(mensajeCompiado);
        }

        private void MensajePreguntaPedido()
        {
            //%0A
            //%20

            string mensaje = "El pedido quedaría de la siguiente manera: ";
            //mensaje = mensaje.Replace(" ", "%20");

            string mensaje2 = "\nMe Revisas que los productos y las cantidades son las correctas.";
            //mensaje2 = mensaje2.Replace(" ", "%20");
            string telefono = "57" + txtTelefono.Text;


            string pedidoCompleto = "";

            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                // Ignorar la última fila vacía si está presente
                if (fila.IsNewRow)
                    continue;

                // Obtener los valores de cada celda en la fila
                string cantidad = fila.Cells["Cantidad"].Value?.ToString() ?? "";
                string producto = fila.Cells["Producto"].Value?.ToString() ?? "";
                // logica de que si es de la categoria carne o legumbre poner el respectivo caracter
                string descripcion = fila.Cells["Descripcion"].Value?.ToString().ToUpper() ?? "";
                descripcion = descripcion.Replace("///", "");
                descripcion = descripcion.Replace("...", "");
                string separador = "";
                if (descripcion.Length > 0) { separador = "->"; }
                // Concatenar los valores en un string y agregarlo a la lista
                string pedido = $"{cantidad} {producto} {separador} {descripcion}";
                pedidoCompleto += "<salto>" + pedido;
            }
            //pedidoCompleto = pedidoCompleto.Replace("<salto>", "%0A");
            //pedidoCompleto = pedidoCompleto.Replace(" ", "%20");
            pedidoCompleto = pedidoCompleto.Replace("<salto>", "\n");



            //string url = $"{PagWhatsApp}{telefono}&text={mensaje}{pedidoCompleto}{mensaje2}";

            string mensajeCompiado = $"{mensaje}{pedidoCompleto}{mensaje2}";
            Clipboard.SetText(mensajeCompiado);
            // Abrir la URL en el navegador predeterminado
            //Process.Start(new ProcessStartInfo
            //{
            //    FileName = url,
            //    UseShellExecute = true
            //});
        }





        #endregion

       

        private void btnOrganizarDireccion_Click(object sender, EventArgs e)
        {
            OrganizarDireccion();
        }

        private void OrganizarDireccion()
        {
            string direccionOrganizada = new Funciones().InputFormularioDireccion();

            txtDireccion.Text = direccionOrganizada;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender,e);
                e.SuppressKeyPress = true; // Evitar el sonido
                e.Handled = true;
            }
        }

        //private Task ReportesCliente() // organizar todas las consultas para que se realicen en paralelo
        //{
        //    var tareas = new[]
        //           {


        //                accionesHTTP.EnviarALaVecindad(DC, Pedido),
        //                accionesHTTP.EnviarAPaginaWebLaBodega(DC, Pedido)
        //           };

        //    var resultados = await Task.WhenAll(tareas);

        //    // Verificar resultados
        //    bool PrimeraPagina = resultados[0];
        //    bool SegundaPagina = resultados[1];




        //}
    }
}

