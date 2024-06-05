using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Modelos;

namespace ConexionBaseDeDatos
{
    public partial class InputBoxForm : Form
    {
        public InputBoxForm()
        {
            InitializeComponent();

        }

        public string ValorIngresado
        {
            get { return txtInput.Text; }
        }


        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Aceptar.Focus();
                e.SuppressKeyPress = true; // Evitar el sonido
                e.Handled = true;
            }
        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {
            Opt1.Checked = true;

            if (Opt2.Visible == true)
            { 
                Opt2.Checked = true; 
            }
        }

        private void LecturaDeTeclasParaAccesosDirectos(object sender, KeyEventArgs e)
        {


            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T:
                        Opt1.Checked = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true; // Evitar el sonido
                        break;
                    case Keys.Y:
                        Opt2.Checked = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true; // Evitar el sonido
                        break;
                    case Keys.U:
                        Opt3.Checked = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true; // Evitar el sonido
                        break;
                    case Keys.I:
                        Opt4.Checked = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true; // Evitar el sonido
                        break;
                    case Keys.O:
                        // aun no hay otra opcion
                        //e.Handled = true;
                        break;
                   
                    default:
                        e.Handled = true;
                        e.SuppressKeyPress = true; // Evitar el sonido
                        break;
                }
            }
        }
    }
}
