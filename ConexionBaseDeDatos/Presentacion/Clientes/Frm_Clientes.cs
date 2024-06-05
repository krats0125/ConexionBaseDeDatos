using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Tomapedidos.Logica;
using Tomapedidos.Modelos.Deplegables;
using Tomapedidos.Presentacion.Clientes;
using Tomapedidos.Utilitarios;

namespace ConexionBaseDeDatos.Presentacion.Clientes
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load_1(object sender, EventArgs e)
        {

            List<TipoDocumento> lista = new List<TipoDocumento> {

             new TipoDocumento{Id = 1,Descripcion = "Cedula"},
             new TipoDocumento{Id = 2,Descripcion = "Nit"},
             new TipoDocumento{Id = 4,Descripcion = "Pasaporte"},

            };
            cb_TipoDocumento.DataSource = lista;
            cb_TipoDocumento.DisplayMember = "Descripcion";
            cb_TipoDocumento.ValueMember = "Id";
        }


       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnGuardar_click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNit_Cedula.Text = string.Empty; ;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            rdTipoCliente1.Checked = true;
            cb_TipoDocumento.Text = "Cedula";
        }


        private void Guardar()
        {
            string Nombre;
            string Apellido;
            string Direccion;
            string Telefono;
            string Correo;

            bool personaJuridica;

            if (txtNombre.Text == "") { Nombre = "Sin Nombre"; }
            else { Nombre = txtNombre.Text; }
            if (txtTelefono.Text == "") { Telefono = "4442109"; }
            else { Telefono = txtTelefono.Text; }
            if (txtApellido.Text == "") { Apellido = "1"; }
            else { Apellido = txtApellido.Text; }
            if (txtDireccion.Text == "") { Direccion = "CR 84 B 9 - 12"; }
            else { Direccion = txtDireccion.Text; }
            if (txtCorreo.Text == "") { Correo = "labodegadenacho@hotmail.com"; }
            else { Correo = txtCorreo.Text; }



            Cliente cliente = new Cliente();


            cliente.strIdCliente = txtNit_Cedula.Text;
            cliente.strTelefono = Telefono;
            cliente.strDireccion = Direccion.ToUpper();
            cliente.strCiudad = "MEDELLÍN";
            cliente.strTipoCliente = "1";
            cliente.bytTipoDocumento = Convert.ToInt16(cb_TipoDocumento.SelectedValue.ToString());
            cliente.blnRegimenComun = false;
            cliente.bytRegimen = 1;
            cliente.lngCodigoMunicipio = 1;
            cliente.strWeb = Correo.ToLower();
            cliente.blnImpoconsumoEnVenta = true;
            cliente.strNroDocumento = txtNit_Cedula.Text;
            cliente.strUsuarioCreoCliente = Principal.Asesor;
            cliente.lngIDCajaCreoCliente = 1;
            cliente.blnFE = true;





            if (rdTipoCliente1.Checked)
            {
                cliente.blnperjuridica = false;
                cliente.bytTipoDireccion = 1;
                cliente.strNombre1 = Nombre.ToUpper();
                cliente.strApellido1 = Apellido.ToUpper();
                cliente.strEmpresa = Nombre.ToUpper() + " " + Apellido.ToUpper();
                personaJuridica = false;
            }
            else
            {
                cliente.strEmpresa = Nombre.ToUpper();
                cliente.blnperjuridica = true;
                cliente.bytDigitoVerificacion = new Recursos().DigitoVerificacion(txtNit_Cedula.Text);
                cliente.bytTipoDireccion = 5;
                cliente.strRazonSocial = Nombre.ToUpper();
                cliente.strNit = txtNit_Cedula.Text + "-" + cliente.bytDigitoVerificacion;

                personaJuridica = true;
            }

            CD_Cliente objCliente = new CD_Cliente();
            bool seCreo = false;
            if (personaJuridica)
            {
                seCreo = objCliente.CrearPersonaJuridica(cliente);
            }
            else
            {
                seCreo = objCliente.CrearPersonaNatural(cliente);
            }


            if (seCreo) { MessageBox.Show("Creacion Exitosa"); } else { MessageBox.Show("Ocurrio un error"); }

        }

        private void Buscar()
        {
            CD_Cliente obj = new CD_Cliente();
            DataTable dt = new DataTable();
            dt = obj.Buscar("3013290093");

        }

        private void cb_TipoDocumento_TextChanged(object sender, EventArgs e)
        {
            if (cb_TipoDocumento.Text == "Nit")
            {
                rdTipoCliente2.Checked = true;
                txtApellido.Visible = false;
                Label_Apellido.Visible = false;
                txtTelefono.Size = new System.Drawing.Size(346, 27);
                Label_Telefono.Size = new System.Drawing.Size(346, 27);
                Label_Nombre.Text = "Razon Social";
            }
            else
            {
                rdTipoCliente1.Checked = true;
                txtApellido.Visible = true;
                Label_Apellido.Visible = true;
                txtTelefono.Size = new System.Drawing.Size(171, 27);
                Label_Telefono.Size = new System.Drawing.Size(171, 27);
                Label_Nombre.Text = "Nombre";
            }
        }



        private void btnOrganizarCliente_Click(object sender, EventArgs e)
        {
            string telefono = ""; // txtTelParaOrganizar.Text;

            if (telefono == "")
            {
                MessageBox.Show("El campo del telefono que vas a organizar esta vacio");

                return;

            }

            bool respuesta = new CD_Cliente().ActualizarCliente(telefono);

            if (respuesta)
            {
                MessageBox.Show("Actualizado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar");
            }

        }



        private void btn_MenuConsulta_Click_1(object sender, EventArgs e)
        {
            Form frm = new FrmConsultaCliente();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            string direccionOrganizada = new Funciones().InputFormularioDireccion();

            txtDireccion.Text = direccionOrganizada;
        }
    }
}
