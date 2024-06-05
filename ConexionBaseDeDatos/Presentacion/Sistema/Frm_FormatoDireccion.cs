using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Logica;

namespace Tomapedidos.Presentacion.Sistema
{
    public partial class Frm_FormatoDireccion : Form
    {
        // formulario alto 169

        CD_UnidadResidencial obj = new CD_UnidadResidencial();
        public Frm_FormatoDireccion()
        {
            InitializeComponent();

            this.Controls.SetChildIndex(PanelDireccion, 0);
            this.Controls.SetChildIndex(PanelUnidad, 1);
            this.Controls.SetChildIndex(PanelCasa, 2);

            
        }

        private void Frm_FormatoDireccion_Load(object sender, EventArgs e)
        {
            ListarUnidades();
            Opt1.Checked=true;
        }

        private void ListarUnidades() 
        {
         DataTable datos =  obj.ListarUnidades(); // quedan todos los datos de la unidad en el combo box para luego ser
                                                  // usados como logica para lahabilitacion de las torres y el tipo de viviena
                                                  // sea apt o casa
            cb_unidades.DataSource = datos;     
            cb_unidades.DisplayMember = "Unidad";
        }

        private void Opt1_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt1.Checked)
            { 
              PanelCasa.Visible = false;
              PanelUnidad.Visible = true;
            }else 
            {
                PanelUnidad.Visible = false;
                PanelCasa.Visible = true;
                

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
               
        private void cb_torres_SelectedIndexChanged(object sender, EventArgs e)
        {

            OrganizarDireccionUnidad();
        }

        private void txt_apartamento_TextChanged(object sender, EventArgs e)
        {
            OrganizarDireccionUnidad();
        }

        private void cb_unidades_SelectedIndexChanged(object sender, EventArgs e)
        {



            OrganizarDireccionUnidad();
        }

        private void cb_Dir_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }

        private void txt_numero_1_TextChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }

        private void cb_letra_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }

        private void txt_numero_2_TextChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }

        private void cb_letra_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }

        private void txt_numero_3_TextChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }
        private void txt_Interior_TextChanged(object sender, EventArgs e)
        {
            OrganizarDireccionCasa();
        }
        private void OrganizarDireccionCasa()
        {
            if (txt_Interior.Text == "") 
            {
                lb_Direccion_Completa.Text = cb_Dir.Text + " " + txt_numero_1.Text + cb_letra_1.Text + " # " + txt_numero_2.Text + cb_letra_2.Text + " - " + txt_numero_3.Text;
            }
            else 
            {
                lb_Direccion_Completa.Text = cb_Dir.Text + " " + txt_numero_1.Text + cb_letra_1.Text + " # " + txt_numero_2.Text + cb_letra_2.Text + " - " + txt_numero_3.Text + " Interior " + txt_Interior.Text;
            }
        
        }

        private void OrganizarDireccionUnidad()
        {

            lb_Direccion_Completa.Text = cb_unidades.Text + " " + cb_torres.Text + " APT " + txt_apartamento.Text;

        }

      
    }
}
