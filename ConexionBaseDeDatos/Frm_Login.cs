using ConexionBaseDeDatos.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tomapedidos.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConexionBaseDeDatos
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            ListarAsesores();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HTCAPTION = 2;

        private void moverForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public static string Asesor = "";
        public static string CodTel = "";
        public static string CodWpp = "";
        public static string Puesto = "";

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbAsesor.SelectedItem;

            if (cbAsesor.Text == "")
            {
                Asesor = "PRUEBA";
                CodTel = "";
                CodWpp = "";
            
            } else
            {
                Asesor = cbAsesor.Text;
                if (selectedRow["CodigoTelefono"].ToString() != "")
                {
                    CodTel = (string)selectedRow["CodigoTelefono"];
                }
                if (selectedRow["CodigoWhatsapp"].ToString() != "")
                {
                    CodWpp = (string)selectedRow["CodigoWhatsapp"];
                }

            }
                      
          
           
            Puesto = cbPuesto.Text;


            Principal frm = new Principal(this);
            frm.Show();
            this.Hide();
            

            
        }

        private void ListarAsesores() 
        {
        
          CD_Asesor objAsesor = new CD_Asesor();
          DataTable Asesores = objAsesor.Listar();
            cbAsesor.DataSource = Asesores;
            cbAsesor.DisplayMember = "Nombre";
        
        }

        public void mostrarFormulario() 
        {
         this.Show();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm(e);
        }


    }
}
