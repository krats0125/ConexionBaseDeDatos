using ConexionBaseDeDatos.Presentacion.Asesores;
using ConexionBaseDeDatos.Presentacion.Clientes;
using ConexionBaseDeDatos.Presentacion.Logistico;
using ConexionBaseDeDatos.Presentacion.PaginaWeb.ClientesWeb;
using ConexionBaseDeDatos.Presentacion.PaginaWeb.MensajesWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Presentacion.Clientes;

namespace ConexionBaseDeDatos.Presentacion
{
    public partial class Principal : Form
    {
        private Frm_Login login;

        public static string Asesor;
        public static string Puesto;
        public static string CodTel = "";
        public static string CodWpp = "";

        //public Label lb_Aviso_Procesando;

        public Principal(Frm_Login frmlogin)
        {
            InitializeComponent();
            this.login = frmlogin;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lb_Asesor.Text = Frm_Login.Asesor.ToString();
            Asesor = lb_Asesor.Text;
            lb_Puesto.Text = Frm_Login.Puesto.ToString();
            Puesto = lb_Puesto.Text;
            lb_CodTelefono.Text = Frm_Login.CodTel.ToString();
            CodTel = lb_CodTelefono.Text;
            lb_CodWhatsapp.Text = Frm_Login.CodWpp.ToString();
            CodWpp = lb_CodWhatsapp.Text;

            AbrirFormularioEnPanel<TomaPedido>();
        }



        private Form FormActivado = null;


        private void abrirFormulario(Form FormularioHijo)
        {
            if (FormActivado != null)
            {
                FormActivado.Close();

            }

            FormActivado = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelMaestro.Controls.Add(FormularioHijo);
            PanelMaestro.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }
        private Dictionary<Type, Form> InstanciaDelFormulario = new Dictionary<Type, Form>();
        private void AbrirFormularioEnPanel<T>() where T : Form, new()
        {
            Type formType = typeof(T);

            // Verificar si ya existe una instancia del formulario
            if (InstanciaDelFormulario.ContainsKey(formType))
            {
                Form ExisteFormulario = InstanciaDelFormulario[formType];
                if (!ExisteFormulario.IsDisposed)
                {
                    ExisteFormulario.BringToFront(); // Traer el formulario al frente si está oculto detrás de otros controles
                    return;
                }
                // Si el formulario está desechado, eliminar la instancia
                InstanciaDelFormulario.Remove(formType);
            }

            // Crear una nueva instancia del formulario
            T FormularioHijo = new T();
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            PanelMaestro.Controls.Add(FormularioHijo);
            FormularioHijo.Show();

            // Almacenar la instancia del formulario en el diccionario
            InstanciaDelFormulario.Add(formType, FormularioHijo);
        }


        private void Principal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            login.mostrarFormulario();
        }

        private void btnMenuConfiguracion_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new Frm_Configuracion());

            AbrirFormularioEnPanel<Frm_Configuracion>();
        }

        private void tomaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new TomaPedido());

            AbrirFormularioEnPanel<TomaPedido>();
        }

        private void buscarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Frm_BuscarVentas>();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarFactura frm = new Frm_BuscarFactura();
            frm.Show();
            //AbrirFormularioEnPanel<Frm_BuscarFactura>(); // codigo para abrirlo dentro del mismo formulario
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Frm_Clientes>();
        }

        private void clientesPaginaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Frm_ClientesWeb>();
        }

        private void mensajesPQRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmMensajesWeb>();

        }

        private void FormularioAsesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Frm_Asesores>();
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesImpresion frm = new ReportesImpresion();
            frm.Show();



            ///AbrirFormularioEnPanel<ReportesImpresion>();
                
        }

        #region Teclas para accesos directos

        private void TeclasDeAccesoDirectoAFormularios(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               
                case Keys.F2:
                    //MetodoF2();  //Formulario Reporte
                    break;
                case Keys.F3:
                    //MetodoF3();  // formulario de Pqrs
                    break;
                case Keys.F4:
                    //MetodoF4();  //
                    break;
                case Keys.F5:
                    //MetodoF5();
                    break;
                case Keys.F6:
                    //MetodoF6(); Metodo para marcar un anexo
                    break;
                case Keys.F7:
                    //MetodoF7();
                    break;
                case Keys.F8:
                    //MetodoF8();
                    break;
                case Keys.F9:
                    //MetodoF9();
                    break;
                case Keys.F10:
                    //MetodoF10();
                    break;
                default:
                    break;
            }

           
        }




        #endregion

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Frm_Saldos>();
        }
    }
}
