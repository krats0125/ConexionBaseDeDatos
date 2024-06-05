using Tomapedidos.Logica;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDeDatos.Modelos
{
    public class Configuracion
    {
        private static bool consultaRealizada = false;
        private static object lockObject = new object();

        public bool EnvioALaPLataformaLaVecindad { get; set; }
        public bool EnvioLaBodegaWeb { get; set; }
        public string DireccionImpresoraCarniceria { get; set; }
        public string DireccionImpresoraLegumbreria { get; set; }
        public bool ImprimirEnCarniceria { get; set; }
        public bool ImprimirEnLegumbreria { get; set; }

        public string CadenaDeConexionXPos { get; set; }
        public string CadenaDeConexionBDCallCenter { get; set; }
        public bool ApiActualizacionCliente { get; set; }
        public string version { get; set; }


        // Constructor
        public Configuracion()
        {
            // Verificar si la consulta ya se ha realizado
            if (!consultaRealizada)
            {
                // Bloquear el acceso concurrente para asegurar que la consulta se ejecute una vez
                lock (lockObject)
                {
                    if (!consultaRealizada)
                    {
                        
                        DataTable dt = Consulta();

                        try
                        {
                            this.EnvioALaPLataformaLaVecindad = Convert.ToBoolean(dt.Rows[0]["EnvioALaPLataformaLaVecindad"].ToString());
                            this.EnvioLaBodegaWeb = Convert.ToBoolean(dt.Rows[0]["EnvioLaBodegaWeb"].ToString());
                            this.DireccionImpresoraCarniceria = dt.Rows[0]["DireccionImpresoraCarniceria"].ToString();
                            this.DireccionImpresoraLegumbreria = dt.Rows[0]["DireccionImpresoraLegumbreria"].ToString();
                            this.ImprimirEnCarniceria = Convert.ToBoolean(dt.Rows[0]["ImprimirEnCarniceria"].ToString());
                            this.ImprimirEnLegumbreria = Convert.ToBoolean(dt.Rows[0]["ImprimirColillaLegumbre"].ToString());
                            this.CadenaDeConexionXPos = dt.Rows[0]["CadenaDeConexionXPos"].ToString();
                            this.CadenaDeConexionBDCallCenter = dt.Rows[0]["CadenaDeConexionBDCallCenter"].ToString();
                            //this.ApiActualizacionCliente = Convert.ToBoolean(dt.Rows[0]["Version"].ToString());
                            this.version = dt.Rows[0]["Version"].ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("La consulta a Configuración arroja un error");
                        }

                       


                        // Marcar la consulta como realizada
                        consultaRealizada = true;
                    }
                }
            }
        }

        private DataTable Consulta()
        {
            DataTable dt = new DataTable();
           
            CONEXION cn = new CONEXION();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionCallCenter()))
                {
                     conn.Open();

                      string Query = "select EnvioALaPLataformaLaVecindad,EnvioLaBodegaWeb," +
                                     " ImprimirColillaLegumbre,ImprimirEnCarniceria," +
                                     " DireccionImpresoraCarniceria,DireccionImpresoraLegumbreria,CadenaDeConexionXPos,CadenaDeConexionBDCallCenter,Version from CONFIGURACION";

                                       

                    OleDbDataAdapter da = new OleDbDataAdapter(Query, conn);
                    da.Fill(dt);

                    
                }
            }
            catch (Exception)
            {

                return dt;
            }
            return dt;

        }

    }

}
