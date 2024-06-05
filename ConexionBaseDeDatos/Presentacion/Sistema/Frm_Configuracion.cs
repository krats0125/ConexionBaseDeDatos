using ConexionBaseDeDatos.Modelos;
using Tomapedidos.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private  void Frm_Configuracion_Load(object sender, EventArgs e)
        {
          Configuracion conf =  new Configuracion();
          chkEnviarALaVecindad.Checked = conf.EnvioALaPLataformaLaVecindad;
          chkImprimirEnCarniceria.Checked = conf.ImprimirEnCarniceria;
          chkImprimirEnLegumbria.Checked = conf.ImprimirEnLegumbreria;
          txtDireccionImpresoraCarniceria.Text = conf.DireccionImpresoraCarniceria;
          txtDireccionImpresoraLegumbreria.Text = conf.DireccionImpresoraLegumbreria;
          txtCadenaDeConexion.Text = conf.CadenaDeConexionXPos;
          txtCadenaDeConexionCallCenter.Text = conf.CadenaDeConexionBDCallCenter;
          lb_Version.Text = conf.version;
          
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "krats") 
            {
                txtCadenaDeConexion.Enabled = true;
                txtCadenaDeConexionCallCenter.Enabled = true;
                txtDireccionImpresoraCarniceria.Enabled = true;
                txtDireccionImpresoraLegumbreria.Enabled = true;
                chkEnviarALaVecindad.Enabled = true;
                chkImprimirEnCarniceria.Enabled=true;
                chkImprimirEnLegumbria.Enabled=true;
                btnGuardar.Enabled = true;
               
            }
            else
            {
                txtCadenaDeConexion.Enabled = false;
                txtCadenaDeConexionCallCenter.Enabled = false;
                txtDireccionImpresoraCarniceria.Enabled = false;
                txtDireccionImpresoraLegumbreria.Enabled = false;
                chkEnviarALaVecindad.Enabled = false;
                chkImprimirEnCarniceria.Enabled = false;
                chkImprimirEnLegumbria.Enabled = false;
                btnGuardar.Enabled = false;
                
            }
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

          await  Guardar();
            txtContraseña.Text = string.Empty;
        }

        private async Task Guardar() 
        {
            bool resultado = false;

            Configuracion conf = new Configuracion();
            conf.EnvioALaPLataformaLaVecindad = chkEnviarALaVecindad.Checked;
            conf.ImprimirEnCarniceria = chkImprimirEnCarniceria.Checked;
            conf.ImprimirEnLegumbreria = chkImprimirEnLegumbria.Checked;
            conf.DireccionImpresoraCarniceria = txtDireccionImpresoraCarniceria.Text;
            conf.DireccionImpresoraLegumbreria = txtDireccionImpresoraLegumbreria.Text;
            conf.CadenaDeConexionXPos = txtCadenaDeConexion.Text;
            conf.CadenaDeConexionBDCallCenter = txtCadenaDeConexionCallCenter.Text;

            CD_Configuracion obj = new CD_Configuracion();
            resultado = await obj.Actualizar(conf);

            if (!resultado)
            {
                MessageBox.Show("No fue posible actualizar. esto puede deberse a que la tabla este abierta."); 
            }
            else
            {
                MessageBox.Show("Actualizado. Porfavor reinicie el programa");
                
            }
        }

    }
}
