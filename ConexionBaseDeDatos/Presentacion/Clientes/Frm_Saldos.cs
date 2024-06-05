using ConexionBaseDeDatos.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Tomapedidos.Logica;
using Tomapedidos.Modelos;

namespace Tomapedidos.Presentacion.Clientes
{
    public partial class Frm_Saldos : Form
    {
        public Frm_Saldos()
        {
            InitializeComponent();
        }

        private CD_Saldos obj = new CD_Saldos();  // se genera la clase logica en el formulatio para ser usado por todos los botones

        private async void Saldos_Load(object sender, EventArgs e)
        {
          OptAFavor.Checked = true;
          OptPendientes.Checked = true;

          await  ListarSaldos();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            Saldo sd = new Saldo();

            sd.IdCliente = txtIdcliente.Text;
            sd.Factura = txtFactura.Text;
            sd.Motivo = txtMotivo.Text;
            sd.SaldoFavor = Convert.ToInt64(txtValor.Text);
            sd.SubioInforme = Principal.Asesor;

            if (sd.IdCliente == "" || sd.Factura == "" || sd.Motivo == "" || sd.SaldoFavor == 0 || sd.SubioInforme == "")
            {
                MessageBox.Show("Te falta uno de los datos");
            
            }

            if (sd.IdCliente == null) { sd.IdCliente = "";}
            if (sd.Factura == null) { sd.Factura = ""; }
            if (sd.Motivo == null) { sd.Motivo = ""; }
            if (sd.SubioInforme == null) { sd.SubioInforme = ""; }

            await Registrar(sd);

           

        }

        private async Task Registrar(Saldo sd)
        {

           

            bool respuesta = await obj.Registrar(sd);
            if (respuesta)
            {
                MessageBox.Show("Se registro del saldo ha sido exitoso.");
                limpiarCampos();
                ListarSaldos();
            }
            else
            {
                MessageBox.Show("Ocurrio un error ingresando el Saldo");

            }


        }

        private void limpiarCampos()
        { 
        
            txtIdcliente.Text = string.Empty;
            txtFactura.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtMotivo.Text = string.Empty;
           
        }

        private async Task ListarSaldos()
        { 
          

           DataTable dt = new DataTable();

           dt =  await obj.Listar(false);  // debo se generar una consulta a los checkbox para que me liste tanto los saldos que estan pendientes como los que ya estan saldados

            dgvSaldos.DataSource = dt;



        }
    }
}
