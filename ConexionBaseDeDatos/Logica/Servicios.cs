using ConexionBaseDeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos.Logica
{
    public  class Servicios
    {
        public DataTable ConvertirDataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Agregas las columnas al DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Type columnType = column.ValueType ?? typeof(string); // Si el tipo de dato es nulo, se usa string como tipo predeterminado
                dataTable.Columns.Add(column.HeaderText, columnType);
            }

            // Agregas las filas al DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        public void ImprimirRecibo(PrintPageEventArgs e, DatosComanda datoscomanda)
        {
            // Configuración de la fuente y posición de impresión
            Font font = new Font("Arial", 12);
            float yPos = 100;
            float leftMargin = 5;

            // Imprimir la hora
            e.Graphics.DrawString($"Hora: {datoscomanda.Hora}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            e.Graphics.DrawString($"Pedido: {datoscomanda.IdPedido}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();
            yPos += font.GetHeight();

            // Imprimir el asesor
            e.Graphics.DrawString($"Asesor: {datoscomanda.Asesor}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            e.Graphics.DrawString($"Puesto: {datoscomanda.Puesto}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            e.Graphics.DrawString($"Nombre: {datoscomanda.Nombre}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            e.Graphics.DrawString($"Telefono: {datoscomanda.Telefono}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            ImprimirDatoConSalto($"Direccion: {datoscomanda.Direccion}", e, font, ref yPos);
            //e.Graphics.DrawString($"Direccion: {datoscomanda.Direccion}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            // Imprimir el ID del cliente
            e.Graphics.DrawString($"ID Cliente: {datoscomanda.IdCliente}", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();
            yPos += font.GetHeight();
            

            e.Graphics.DrawString($"Novedad:", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();
            ImprimirDatoConSalto(datoscomanda.Novedad, e, font, ref yPos);
            yPos += font.GetHeight();
            yPos += font.GetHeight();
            yPos += font.GetHeight();

            e.Graphics.DrawString($"Articulos:", font, Brushes.Black, leftMargin, yPos);
            yPos += font.GetHeight();

            //foreach (string dato in datoscomanda.ListPedido)
            //{
            //    e.Graphics.DrawString($"{dato}", font, Brushes.Black, leftMargin, yPos);
            //    yPos += font.GetHeight();

            //}

            foreach (string dato in datoscomanda.ListPedido)
            {
                ImprimirDatoConSalto(dato, e, font, ref yPos);
            }


        }

        private List<string> DividirCadenaPorLineas(string cadena, int caracteresPorLinea)
        {
            List<string> lineas = new List<string>();

            // Dividir la cadena en palabras
            string[] palabras = cadena.Split(' ');

            // Construir las líneas
            string lineaActual = "";
            foreach (string palabra in palabras)
            {
                if ((lineaActual + palabra).Length > caracteresPorLinea)
                {
                    // La palabra actual excede la longitud máxima por línea, iniciar una nueva línea
                    lineas.Add(lineaActual);
                    lineaActual = palabra + " ";
                }
                else
                {
                    lineaActual += palabra + " ";
                }
            }

            // Agregar la última línea
            if (!string.IsNullOrWhiteSpace(lineaActual))
            {
                lineas.Add(lineaActual.Trim());
            }

            return lineas;
        }

        private void ImprimirDatoConSalto(string dato, PrintPageEventArgs e, Font font, ref float yPos) 
        {
            // lo que busco con este codigo, es que como estoy imprimiendo en colilla, que cada 27 letras  del valor de la variable 
            //baje una fila ,para ello uso la logica de dividir cadenas por lineas lo cual hace que si la ultima palaba hace que esta
            //sobrepase las 27 letras. que mas bien baje la fila con la palabra completa.
            

            float leftMargin = 15;

            List<string> lineas = DividirCadenaPorLineas($"{dato}", 27);

            foreach (string linea in lineas)
            {
                e.Graphics.DrawString(linea, font, Brushes.Black, leftMargin, yPos);
                yPos += font.GetHeight();
            }

            yPos += font.GetHeight();
        }

    }
}
