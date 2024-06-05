using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Modelos;

namespace Tomapedidos.Logica.LaBodegaWeb
{
    public class CD_VentaWeb
    {

        public async Task EnviarVenta(VentaWeb venta)
        {
            try
            {
                // Serializar la venta a formato JSON
                string jsonVenta = Newtonsoft.Json.JsonConvert.SerializeObject(venta);

                // Crear una instancia de HttpClient para realizar la solicitud POST
                using (HttpClient client = new HttpClient())
                {
                    // Configurar la URL del servidor
                    string urlServidor = "https://labodegadenacho.com.co/Api/PedidoTomaPedido";

                    // Configurar el contenido de la solicitud como JSON
                    StringContent content = new StringContent(jsonVenta, Encoding.UTF8, "application/json");

                    // Realizar la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(urlServidor, content);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta enviada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al enviar la venta: " + response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
