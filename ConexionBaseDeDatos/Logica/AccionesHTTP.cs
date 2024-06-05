using ConexionBaseDeDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Modelos;


namespace ConexionBaseDeDatos.Logica
{
    public class AccionesHTTP
    {
        private static readonly HttpClient EnvioPedido = new HttpClient();
        private static readonly HttpClient EnvioPedidoBodegaWeb = new HttpClient();
        private static readonly HttpClient ReciboMensajes = new HttpClient();
        public async Task<bool> EnviarALaVecindad(DatosComanda DC, int Pedido)
        {
            bool respuesta = true;

            string CodMedioPago;

            switch (DC.MedioPago.ToString())
            {
                case "EFECTIVO":
                    CodMedioPago = "E";
                    break;
                case "TARJETA":
                    CodMedioPago = "T";
                    break;
                default:
                    CodMedioPago = "Q";
                    break;
            }
            string novedadVecindad;
            novedadVecindad = Pedido.ToString().Substring(Pedido.ToString().Length - 3, 3) + " - " + DC.Telefono + " - " + DC.Novedad;
            DC.IdPedido = DC.Puesto + "-" + Pedido;
            try
            {
                var objetoJson = new
                {
                    nitEmpresa = "900326895",
                    identificacionCliente = DC.IdCliente,
                    nombreCliente = DC.Nombre,
                    apellidosCliente = "1",
                    telefonoCliente = DC.Telefono,
                    telefonoCliente2 = "",
                    telefonoCliente3 = "",
                    telefonoCliente4 = "",
                    direccionCliente = DC.Direccion,
                    ciudadCliente = "Medellin",
                    vendedor = DC.Asesor,
                    pedido = DC.IdPedido,
                    fechaPedido = DC.Fecha,
                    horaPedido = DC.Hora,
                    textoPedido = string.Join("<br> ", DC.ListPedido),
                    canal = "CE",
                    categoria = "Bronce",
                    observacion = novedadVecindad,
                    medioPago = CodMedioPago
                };

                var url = "http://app.lavecindad.com.co/enviarPedido";
                var contenidoJson = JsonConvert.SerializeObject(objetoJson);
                var contenido = new StringContent(contenidoJson, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST y esperar la respuesta
                var respuestaPagina = await EnvioPedido.PostAsync(url, contenido);

                if (respuestaPagina.IsSuccessStatusCode)
                {
                    string resultado = await respuestaPagina.Content.ReadAsStringAsync();
                    // Procesar la respuesta si es necesario
                    //MessageBox.Show(resultado);
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("Error al enviar el pedido a la pagina de la vecindad: " + respuestaPagina.StatusCode);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                MessageBox.Show("Excepción: " + ex.Message);
            }

            return respuesta;
        }

        public async Task<bool> EnviarAPaginaWebLaBodega(DatosComanda DC, int Pedido)
        {
            bool respuesta = true;
            if (DC.Novedad == "") { DC.Novedad = "''"; }

            try
            {
                // Convertir la fecha de "dd/mm/yyyy" a "yyyy-mm-dd"
                DateTime fechaPedido = DateTime.ParseExact(DC.Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fechaFormateada = fechaPedido.ToString("yyyy-MM-dd");

                var objetoJson = new
                {
                    json = new
                    {
                        IdCliente = DC.IdCliente,
                        NombreCliente = DC.Nombre,
                        TelefonoCliente = DC.Telefono,
                        TelefonoCliente2 = "", 
                        TelefonoCliente3 = "",
                        TelefonoCliente4 = "",
                        DireccionCliente = DC.Direccion,
                        Vendedor = DC.Asesor,
                        Pedido = DC.Puesto + "-" + Pedido,
                        FechaPedido = fechaFormateada,
                        HoraPedido = DC.Hora,
                        Novedad = DC.Novedad,
                        MedioPago = DC.MedioPago,
                        Canal = DC.Medio,
                        Impre2 = true
                    },
                    jsonproductos = DC.ListPedido.Select(item => new { Item = item }).ToArray()
                };

                var url = "https://labodegadenacho.com.co/Api/RecibirPedido";
                //var url = "https://localhost:44351/Api/RecibirPedido";
                var contenidoJson = JsonConvert.SerializeObject(objetoJson,Formatting.Indented);
                var contenido = new StringContent(contenidoJson, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST y esperar la respuesta
                var respuestaPagina = await EnvioPedidoBodegaWeb.PostAsync(url, contenido);

                if (respuestaPagina.IsSuccessStatusCode)
                {
                    string resultado = await respuestaPagina.Content.ReadAsStringAsync();
                    // Procesar la respuesta si es necesario
                   // MessageBox.Show(resultado);
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("Error al enviar el pedido a la bodega web: " + respuestaPagina.StatusCode);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                //MessageBox.Show("Excepción: " + ex.Message);
            }

            return respuesta;
        }
        //public async Task<List<Mensaje_Cliente>> LeerMensajesClientes()
        //{
        //    List<Mensaje_Cliente> lista = new List<Mensaje_Cliente>();


        //    try
        //    {
        //        var url = "https://labodegadenacho.com.co/Api/LeerMensajesClientes";
        //        //var url = "https://localhost:44351/Api/LeerMensajesClientes";



        //        var respuesta = await ReciboMensajes.GetAsync(url);

        //        if (respuesta.IsSuccessStatusCode)
        //        {
        //            var jsonString = await respuesta.Content.ReadAsStringAsync();
        //            var jsonResponse = JsonConvert.DeserializeObject<RootObject>(jsonString);
        //            //lista = JsonConvert.DeserializeObject<List<Mensaje_Cliente>>(jsonString.data.ToString());

        //            if (jsonResponse?.Data != null)
        //            {
        //                lista = jsonResponse.Data;

        //                MessageBox.Show(
        //                    lista[2].Nombre + "\n" +
        //                    lista[2].Celular + "\n" +
        //                    lista[2].Direccion + "\n" +
        //                    lista[2].TextoMensaje
        //                    );

        //                //if (lista.Count > 1)
        //                //{
        //                //    DataTable dataTable = ConvertToDataTable(lista);
        //                //    dataGridView.DataSource = dataTable;
        //                //}
        //            }

        //            //if (lista.Count > 1)
        //            //{

        //            //    MessageBox.Show("Hay un mensaje de un cliente");
        //            //    //DataTable dataTable = ConvertToDataTable(lista);
        //            //    //dataGridView.DataSource = dataTable;
        //            //}
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return lista;
        //    }

        //    return lista;
        //}

        public async Task<int?> LeerMensajesClientes()
        {
            int? lista = 0;


            try
            {
                var url = "https://labodegadenacho.com.co/Api/LeerMensajesClientes";
                //var url = "https://localhost:44351/Api/LeerMensajesClientes";


               
               var respuesta = await ReciboMensajes.GetAsync(url);

                if (respuesta.IsSuccessStatusCode)
                {
                    var jsonString = await respuesta.Content.ReadAsStringAsync();
                    var jsonResponse = JsonConvert.DeserializeObject<RootObject>(jsonString);

                    if (jsonResponse?.Data.Count > 0)
                    {

                        lista = jsonResponse?.Data.Count;


                    }
                    
                                     
                    
                   
                }
            }
            catch (Exception ex)
            {
            
            return lista;
            }
              
            return lista;
        }
        public class RootObject
        {
            public List<Mensaje_Cliente> Data { get; set; }
        }

        private DataTable ConvertToDataTable(List<Mensaje_Cliente> lista)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Mensaje", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));

            foreach (var item in lista)
            {
                //var row = dataTable.NewRow();
                //row["Id"] = item.Id;
                //row["Mensaje"] = item.Mensaje;
                //row["Fecha"] = item.Fecha;

                //dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        // LeerMensajesClientes
    }
}
