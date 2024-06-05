using ConexionBaseDeDatos.Presentacion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos.Logica
{
    public class LoopConsultas
    {
        private readonly Timer timer;
        private readonly TomaPedido form;
        private readonly Principal frmprincipal;



        public LoopConsultas()
        {
            
            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += async (sender, e) => await Timer_Tick();
            form = ObtenerInstanciaTomaPedido();
            frmprincipal = ObtenerInstanciaMenuPrincipal();

          

        }

        private async Task Timer_Tick()
        {
            // Este método se ejecutará cada vez que el temporizador alcance su intervalo
            // Puedes llamar a tus métodos aquí
            await Task.Run(() => Semaforo());
            await Task.Run(() => RevisarMensajesClientes());

            //await Metodo2();
            //await Metodo3();
        }

        private async Task Metodo1()
        {
          await Task.Run(() => Semaforo());
        }

        private async Task RevisarMensajesClientes()
        {
            AccionesHTTP obj = new AccionesHTTP();

            int? valor = await obj.LeerMensajesClientes();

            frmprincipal.Invoke((MethodInvoker)delegate { frmprincipal.btn_Cant_Mensaje.Text = valor.ToString(); });

        }

        private async Task Metodo3()
        {
            await Task.Run(() => Semaforo());
        }

        public void IniciarCiclo()
        {
            timer.Start();
        }
        #region Semaforo
        private void Semaforo()
        {

            if (form == null)
                return;

            DateTime horaAtencion;
            if (form.LbHoraAtencion.Text == "0:00")
                return;
            else
                horaAtencion = DateTime.ParseExact(form.LbHoraAtencion.Text, "HH:mm", CultureInfo.InvariantCulture);

            DateTime ahora = DateTime.Now;
            string ahora2 = ahora.ToString("HH:mm");
            DateTime ahora3 = DateTime.ParseExact(ahora2, "HH:mm", CultureInfo.InvariantCulture);

            double diferenciaMinutos = (ahora3 - horaAtencion).TotalMinutes;

            int tiempo = (int)diferenciaMinutos;

            if (tiempo > 3 && tiempo < 15)
            {
                form.Invoke((MethodInvoker)delegate { form.btnSemaforo4.Visible = true; });
            }
            else if (tiempo > 2)
            {
                form.Invoke((MethodInvoker)delegate { form.btnSemaforo3.Visible = true; });
            }
            else if (tiempo > 1)
            {
                form.Invoke((MethodInvoker)delegate { form.btnSemaforo2.Visible = true; });
            }
            else if (tiempo > 0)
            {
                form.Invoke((MethodInvoker)delegate { form.btnSemaforo1.Visible = true; });
            }
            else
            {
                // organizar para enviar un mensaje al coordinador
            }
        }




        #endregion // semaforo para detectar los tiempos de atención

        #region Mensajes

        // aca estara la logica para buscar los mensajes y hacer que salg

        #endregion //LosMensajes son para que si hay novedades todas las del call puedan estar al tanto
        private TomaPedido ObtenerInstanciaTomaPedido()
        {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is TomaPedido form)
                    {
                        return form;
                    }
                }
                return null;
        }
        private Principal ObtenerInstanciaMenuPrincipal()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Principal form)
                {
                    return form;
                }
            }
            return null;
        }
    }
   
}
