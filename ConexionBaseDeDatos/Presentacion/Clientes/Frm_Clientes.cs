using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos.Utilitarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Tomapedidos.Logica;
using Tomapedidos.Modelos;
using Tomapedidos.Modelos.Deplegables;
using Tomapedidos.Presentacion.Clientes;
using Tomapedidos.Utilitarios;

namespace ConexionBaseDeDatos.Presentacion.Clientes
{
    public partial class Frm_Clientes : Form
    {
        string _tel;
        public Frm_Clientes(string tel = "")
        {
            InitializeComponent();
            _tel = tel;
        }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnGuardar_click(object sender, EventArgs e)
        {
            Guardar();
        }

    


        private void Guardar()
        {
            // Se declaran las variables que se van a usar
            string Nombre;
            string Apellido;
            string Direccion;
            string Telefono;
            string Correo;

            /*
             se supone que al crear al cliente, este no inicia con los 4 telefonos
             de una vez por lo que no es necesario los otros campos de telefonos 
            */

           

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
            cliente.strmail = Correo.ToLower();
            cliente.blnImpoconsumoEnVenta = true;
            cliente.strNroDocumento = txtNit_Cedula.Text;
            cliente.strUsuarioCreoCliente = Principal.Asesor;
            cliente.lngIDCajaCreoCliente = 1;
            cliente.blnFE = true;
            cliente.dtmNacimiento = txtCumpleaños.Text;


            bool personaJuridica; // se declara la variable que cambia el hecho de si se creara una persona natural o una persona juridica


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
            MessageBox.Show("se oprimio el boton de buscar"); // 
           // DataTable dt = new CD_Cliente().Buscar("3013290093");

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

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            if (_tel != "") { txtTelefono.Text = _tel; }
            List<TipoDocumento> lista = new List<TipoDocumento> {

             new TipoDocumento{Id = 1,Descripcion = "Cedula"},
             new TipoDocumento{Id = 2,Descripcion = "Nit"},
             new TipoDocumento{Id = 4,Descripcion = "Pasaporte"},

            };
            cb_TipoDocumento.DataSource = lista;
            cb_TipoDocumento.DisplayMember = "Descripcion";
            cb_TipoDocumento.ValueMember = "Id";

            btn_Actualizar.Enabled = false;
        }

        private void btnDireccion2_Click(object sender, EventArgs e)
        {

            string direccionOrganizada = new Funciones().InputFormularioDireccion();

            txtDireccionBuscada.Text = direccionOrganizada;

            
        }

        private void cb_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TipoDocumento.Text == "Nit")
            {
                rdTipoCliente2.Checked = true;
                txtApellido.Visible = false;
                Label_Apellido.Visible = false;
                txtTelefono.Size = new System.Drawing.Size(196, 27);
                Label_Telefono.Size = new System.Drawing.Size(196, 27);
                Label_Nombre.Text = "Razon Social";
            }
            else
            {
                rdTipoCliente1.Checked = true;
                txtApellido.Visible = true;
                Label_Apellido.Visible = true;
                txtTelefono.Size = new System.Drawing.Size(97, 27);
                Label_Telefono.Size = new System.Drawing.Size(97, 27);
                Label_Nombre.Text = "Nombre";
            }
        }
               
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNit_Cedula.Text = string.Empty; ;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtTelefono3.Text = string.Empty;
            txtTelefono4.Text = string.Empty;
            txtCumpleaños.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            rdTipoCliente1.Checked = true;
            cb_TipoDocumento.Text = "Cedula";

            dgv_DatosCliente.DataSource = null;
            dgv_DatosCliente.Rows.Clear();
            txtDireccionBuscada.Text = string.Empty;
            lb_Idcliente.Text = string.Empty;

            btnGuardar.Enabled = true;
            btn_Actualizar.Enabled = false;


        }

        private void btnBuscarDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccionBuscada.Text.Trim() == "")
            { return; }

            string buscado = txtDireccionBuscada.Text;

            DataTable lista = new CD_Cliente().Buscar(buscado);

            dgv_DatosCliente.DataSource = lista;

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cliente ocliente = new Cliente();

            if (rdTipoCliente1.Checked)
            {
                ocliente.strNombre1 = txtNombre.Text.ToUpper(); 
                ocliente.strApellido1 = txtApellido.Text.ToUpper();
                ocliente.blnperjuridica = false;
                ocliente.strEmpresa = ocliente.strNombre1 + " " + ocliente.strApellido1;
                ocliente.strRazonSocial = "";
            }
            else
            {
                ocliente.strRazonSocial = txtNombre.Text.ToUpper();
                ocliente.strEmpresa = txtNombre.Text.ToUpper();
                ocliente.blnperjuridica = true;
            }
            if (txtNit_Cedula.Text == "")
            { ocliente.strNit = "222222222222"; }
            else
            { ocliente.strNit = txtNit_Cedula.Text; }
                        
            ocliente.strIdCliente = lb_Idcliente.Text;
            ocliente.Telefono = txtTelefono.Text;
            ocliente.Telefono2 = txtTelefono2.Text;
            ocliente.Telefono3 = txtTelefono3.Text;
            ocliente.Telefono4 = txtTelefono4.Text;
             
            ocliente.strDireccion = txtDireccion.Text;

            if (txtCorreo.Text == "")
            {
                ocliente.strmail = "labodegadenacho@hotmail.com";
            }
            else
            {
                ocliente.strmail = txtCorreo.Text.ToLower();
            }
           
            ocliente.dtmNacimiento = txtCumpleaños.Text;



            // Ya que estan definidos todos los valores, vamos a actualizar

            CD_Cliente objCliente = new CD_Cliente();

            if (objCliente.ActualizarCliente(ocliente))
            {
                MessageBox.Show("El cliente se ha actualizado correctamente.");

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la actualizacion del cliente.");
            }

        }

        private void dgv_DatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Coger Cada uno de los datos que nos interezan el cliente para ser actualizados

            TraerDatosCliente();
            btnGuardar.Enabled = false; // boton crear
            btn_Actualizar.Enabled = true;

        }

        private void TraerDatosCliente()
        {
          

            /*
        "SELECT (strDireccion) as Direccion,(strIDCliente) as IdCliente, (strTelefono) as Telefono1, (strCelular) as Telefono2, (strTelefonoOficina) as Telefono3,(strWhatsapp) as Telefono4, (strEmpresa) AS NombreCompleto," +
        " (strNit) as Documento, (strCiudad) as Ciudad, (dtmNacimiento) as Nacimiento, (strTipoCliente) As IdCategoria, (lngPuntosAcumulados) as Puntos, (strmail) as Correo, (blnperjuridica) as EsPersonaJuridica," +
        " bytTipoDocumento, (strRazonSocial) as RazonSocial, (strNombre1) As Nombre1, (strNombre2) as Nombre2,(strApellido1) as Apellido1, (strApellido2) as Apelllido2," +
        " (blnRegimenComun) as EsRegimenComun, (dtmFechaCreoCliente) As FechaCreacion, (lngMesUltimaFactura) As FechaUltCompra" +
             
             */



            // Asegurarse de que haya al menos una fila seleccionada en el DataGridView de los clientes
            if (dgv_DatosCliente.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgv_DatosCliente.SelectedRows[0];

                Cliente ocliente = new Cliente();

                ocliente.blnperjuridica = Convert.ToBoolean(filaSeleccionada.Cells["EsPersonaJuridica"].Value);
                /* si el cliente es persona juridica indica que no se debe de traer apellido ni nombre, si no razon social*/
                
                ocliente.strNombre1 = filaSeleccionada.Cells["Nombre1"].Value.ToString(); ;
                ocliente.strApellido1 = filaSeleccionada.Cells["Apellido1"].Value.ToString();
                ocliente.strRazonSocial = filaSeleccionada.Cells["RazonSocial"].Value.ToString();
                ocliente.strNit = filaSeleccionada.Cells["Documento"].Value.ToString();
                ocliente.strIdCliente = filaSeleccionada.Cells["IdCliente"].Value.ToString();
                ocliente.Telefono = filaSeleccionada.Cells["Telefono1"].Value.ToString(); 
                ocliente.Telefono2 = filaSeleccionada.Cells["Telefono2"].Value.ToString(); 
                ocliente.Telefono3 = filaSeleccionada.Cells["Telefono3"].Value.ToString();
                ocliente.Telefono4 = filaSeleccionada.Cells["Telefono4"].Value.ToString();
               
                ocliente.strDireccion = filaSeleccionada.Cells["Direccion"].Value.ToString();
               
                ocliente.strmail = filaSeleccionada.Cells["Correo"].Value.ToString();
                              
                ocliente.dtmNacimiento = filaSeleccionada.Cells["Nacimiento"].Value.ToString();

                lb_Idcliente.Text = ocliente.strIdCliente;

                if (!ocliente.blnperjuridica)
                {
                    txtNombre.Text = ocliente.strNombre1;
                    txtApellido.Text = ocliente.strApellido1;

                    rdTipoCliente1.Checked = true;
                }
                else
                {
                    txtNombre.Text = ocliente.strRazonSocial;
                    rdTipoCliente2.Checked = true;
                }

                txtNit_Cedula.Text = ocliente.strNit;
                txtDireccion.Text = ocliente.strDireccion;
                txtTelefono.Text = ocliente.Telefono;
                txtTelefono2.Text = ocliente.Telefono2;
                txtTelefono3.Text = ocliente.Telefono3;
                txtTelefono4.Text = ocliente.Telefono4;
                txtCumpleaños.Text = ocliente.dtmNacimiento;
                txtCorreo.Text = ocliente.strmail;
                
                                              
               
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }


        }
    }
}
