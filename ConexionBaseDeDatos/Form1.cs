using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;




namespace ConexionBaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private void ProbandoConexion() { 
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Desktop\acces del escritorio\X-POS.mdb; ");

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Desktop\Carpetas\vfp\LABODEGADENACHO.accdb; ");
            conn.Open();


            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TRABAJADORES", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            conn.Close();

         }

        private void button1_Click(object sender, EventArgs e)
        {
            ProbandoConexion();
        }
    }
}
