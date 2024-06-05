using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Modelos;
using Tomapedidos.Presentacion.Sistema;

namespace ConexionBaseDeDatos.Utilitarios
{
    public class Funciones
    {
        /// <summary>
        /// Esta es una clase que modifica el formulario InputBox para invocar el formuario con una etiqueta, usando el parametro etiqueta. enviando un tambien una respueta rapida y defidiendo si se requieren
        /// unos campos de uso opcional que son del tipo radioButton.
        /// </summaryEtiqueta
        /// <param name="etiqueta"></param>
        /// <param name="txtInput"></param>
        /// <param name="Opt1"></param>
        /// <param name="Opt2"></param>
        /// <param name="Opt3"></param>
        /// 
        /// 
        /// <returns></returns>
        public InputBoxMessage MostrarInputBox(string etiqueta, string predeterminado = "",bool MedidasVisibles = false)
        {
            InputBoxMessage obj = new InputBoxMessage();

            using (var inputBoxForm = new InputBoxForm())
            {   
                inputBoxForm.Etiqueta.Text = etiqueta;  // Se modifica la etiqueta
                inputBoxForm.txtInput.Text = predeterminado; // Se modifica el valor predeterminado


                if (MedidasVisibles) // Se define si es necesatio que se vean las opciones del tipo radio Button, tiene predeterminado el uso del radio button Opt1 con valor "UND"
                {
                    inputBoxForm.Opt1.Visible = true;
                    inputBoxForm.Opt2.Visible = true;
                    inputBoxForm.Opt3.Visible = true;
                    inputBoxForm.Opt4.Visible = true;

                   

                }

                if (inputBoxForm.ShowDialog() == DialogResult.OK)
                {
                    // El usuario presionó Aceptar, puedes acceder al valor ingresado
                    obj.Descripcion = inputBoxForm.ValorIngresado.Trim().ToUpper();

                    if (inputBoxForm.Opt1.Checked == true) { obj.Umedida = "UND"; }
                    if (inputBoxForm.Opt2.Checked == true) { obj.Umedida = "LIBRA"; }
                    if (inputBoxForm.Opt3.Checked == true) { obj.Umedida = "KILO"; }
                    if (inputBoxForm.Opt4.Checked == true) { obj.Umedida = "MANOJO"; }


                    //MessageBox.Show($"Valor ingresado: {valorIngresado}");

                }
                else
                {
                    // El usuario presionó Cancelar
                    MessageBox.Show("Operación cancelada.");

                    obj.Descripcion = string.Empty;
                    return obj;
                }
            }
           

            return obj;

        }

        public string InputFormularioDireccion()
        {
            string direccion = string.Empty;
            

            using (var frm = new Frm_FormatoDireccion())
            {
                direccion = frm.lb_Direccion_Completa.Text;  // se recoje la direccion que este en el fomulario
               
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // El usuario presionó Aceptar, puedes acceder al valor ingresado
                    direccion = frm.lb_Direccion_Completa.Text.ToUpper();  // se recoje la direccion que este en el fomulario
                   
                    //MessageBox.Show($"Valor ingresado: {direccion}");

                }
                else
                {
                    // El usuario presionó Cancelar
                    MessageBox.Show("Operación cancelada.");

                    direccion = string.Empty;
                    return direccion;
                }
            }


            return direccion;

        }

        public string FormularioMensajeCliente(Mensaje_Cliente MC)
        {
            string direccion = string.Empty;


            using (var frm = new Frm_MensajeCliente())
            {
                // Se asignan las variables a los label del formulario
                frm.lbNombre.Text = MC.Nombre;
                frm.lbCelular.Text = MC.Celular;
                frm.lbCorreo.Text = MC.Correo;
                frm.lbFecha.Text = MC.Fecha.ToString();
                frm.lbDireccion.Text = MC.Direccion;
                frm.lbFactura.Text = MC.Factura;
                frm.lbMensaje.Text = MC.TextoMensaje;
                

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("has aceptado encargarte de esta solicitud");

                }
                else
                {
                    // El usuario presionó Cancelar
                    MessageBox.Show("Operación cancelada.");

                    direccion = string.Empty;
                    return direccion;
                }
            }


            return direccion;

        }
    }
}
