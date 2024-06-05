using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos.Presentacion.PQRS
{
    public partial class Frm_PQRS : Form
    {
        public Frm_PQRS()
        {
            InitializeComponent();
        }

        private void Frm_PQRS_Load(object sender, EventArgs e)
        {

        }



        private DataTable BuscarMotivos() 
        {
            DataTable lista = new DataTable();

            return lista;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lista = new DataTable();
            
            if (cbTipo.SelectedIndex == 0) 
            {
              //lista  
            }
            else 
            {
            
            }
        }
    }
}
