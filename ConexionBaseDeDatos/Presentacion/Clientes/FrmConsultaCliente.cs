using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomapedidos.Logica;

namespace Tomapedidos.Presentacion.Clientes
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var buscado = txtBuscado.Text;

            if (buscado != "")
            {
                BuscarRegistros(buscado);
            }

        }

        private void BuscarRegistros(string NombreODocumento)
        {
            DataTable lista = new CD_Cliente().Buscar(NombreODocumento);


            if (lista.Columns.Count > 1)
            {
                dgvBusqueda.DataSource = lista;
            }
        }

    }
}
