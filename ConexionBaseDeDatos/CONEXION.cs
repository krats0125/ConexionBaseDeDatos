using ADODB;
using ConexionBaseDeDatos.Modelos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConexionBaseDeDatos
{
    public class CONEXION
    {
        //private static bool consultaRealizada = false;
        //private static object lockObject = new object();

        //public string CadenaDeConexionXpos { get; set; }
        //public string CadenaDeConexionCallCenter { get; set; }

        public string ConexionXpos()
        {
            //string direccionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conexionXpos.txt");
            //string originalFilePath = LeerDireccion(direccionFilePath);

            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + originalFilePath;
            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Y:\X-POS.mdb; ";  // cadena de conexion del computador de carlos
            string cadena = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Y:\X-POS.mdb; ";   // cadena de conexion para los computadores del call center
            return cadena;
        }
        //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Y:\X-POS.mdb; ";
        public string ConexionCallCenter()
        {
            //string direccionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conexionCallCenter.txt");
            //string originalFilePath = LeerDireccion(direccionFilePath);

            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + originalFilePath;
            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Y:\CallCenter2.accdb; "; // cadena de conexion del computador de carlos
            string cadena = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Y:\CallCenter.mdb; ";   // cadena de conexion para los computadores del call center
            return cadena;
        }

        //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Y:\CallCenter2.accdb; ";

        public string ConexionBDInterna()
        {
            //string direccionconexion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BddLocal.accdb");

            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + direccionconexion;
            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=X:\APP BODEGA DE NACHO\Nuevos projectos\BddLocal.accdb; ";
            //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\ejecutable del TomaPedidos\BddLocal.accdb; ";  // cadena de conexion del computador de carlos
            string cadena = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\ejecutable del TomaPedidos\BddLocal.mdb; ";  // cadena de conexion para los computadores del call center
            return cadena;
            //C:\ejecutable del TomaPedidos
            //C:\Users\user\Desktop\ejecutable del TomaPedidos\
           
        }
        //string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=X:\APP BODEGA DE NACHO\Nuevos projectos\BddLocal.accdb; ";
        public string ConexionAzure()
        {

            string servidor = "";
            string baseDeDatos = "";
            string usuario = "";
            string password = "";
            string conexion = "";

            servidor = "tcp:carlosdbprojects.database.windows.net";
            baseDeDatos = "DBLABODEGAWEB";
            usuario = "krats0125";
            password = "Valentinag11";


            //conexion = @"Driver={SQL Server};Server=" + servidor + ";Database=" + baseDeDatos + ";Uid=" + usuario + ";Pwd=" + password + ";Encrypt=yes;";
            conexion = $"Server = {servidor},1433; Initial Catalog ={baseDeDatos}; Persist Security Info = False; User ID ={usuario}; Password ={password}; MultipleActiveResultSets = True; Encrypt = True; Connection Timeout = 60; ";

            return conexion;
        }
        private string LeerDireccion(string direccionFilePath)
        {
            string direccion = "";

            try
            {
                using (StreamReader sr = new StreamReader(direccionFilePath))
                {
                    direccion = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer la dirección del archivo: " + ex.Message);
            }

            return direccion;
        }

        //public CONEXION()
        //{
        //    // Verificar si la consulta ya se ha realizado
        //    if (!consultaRealizada)
        //    {
        //        // Bloquear el acceso concurrente para asegurar que la consulta se ejecute una vez
        //        lock (lockObject)
        //        {
        //            if (!consultaRealizada)
        //            {

        //                Configuracion configuracion = new Configuracion();
        //                this.CadenaDeConexionXpos = configuracion.CadenaDeConexionXPos;
        //                this.CadenaDeConexionCallCenter = configuracion.CadenaDeConexionBDCallCenter;

        //                // Marcar la consulta como realizada
        //                consultaRealizada = true;
        //            }
        //        }
        //    }
        //}


    }
}
