using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tomapedidos.Logica
{
    public class CD_Configuracion
    {
        public async Task<Configuracion> Estado()
        {
            Configuracion configuracion = new Configuracion();
            CONEXION cn = new CONEXION();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionCallCenter()))
                {
                    await conn.OpenAsync();

                    string Query = @"select EnvioALaPLataformaLaVecindad,EnvioLaBodegaWeb,
                                 DireccionImpresoraCarniceria,DireccionImpresoraLegumbreria,
                                 ImprimirEnCarniceria,ImprimirEnLegumbreria from configuracion";




                    OleDbDataAdapter da = new OleDbDataAdapter(Query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    configuracion.EnvioALaPLataformaLaVecindad = Convert.ToBoolean(dt.Rows[0]["EnvioALaPLataformaLaVecindad"].ToString());
                    configuracion.EnvioLaBodegaWeb = Convert.ToBoolean(dt.Rows[0]["EnvioLaBodegaWeb"].ToString());
                    configuracion.DireccionImpresoraCarniceria = dt.Rows[0]["DireccionImpresoraCarniceria"].ToString();
                    configuracion.DireccionImpresoraLegumbreria = dt.Rows[0]["DireccionImpresoraLegumbreria"].ToString();
                    configuracion.ImprimirEnCarniceria = Convert.ToBoolean(dt.Rows[0]["ImprimirEnCarniceria"].ToString());
                    configuracion.ImprimirEnLegumbreria = Convert.ToBoolean(dt.Rows[0]["ImprimirEnLegumbreria"].ToString());





                }
            }
            catch (Exception)
            {

                return configuracion;
            }
            return configuracion;

        }

        public async Task<bool> Actualizar(Configuracion configuracion)
        {
            bool resultado = false;

            CONEXION cn = new CONEXION();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(cn.ConexionCallCenter()))
                {
                    await conn.OpenAsync();

                    string Query = @"UPDATE CONFIGURACION
                                 SET EnvioALaPLataformaLaVecindad = @EnvioALaPLataformaLaVecindad,
                                     EnvioLaBodegaWeb = @EnvioLaBodegaWeb,
                                     DireccionImpresoraCarniceria = @DireccionImpresoraCarniceria,
                                     DireccionImpresoraLegumbreria = @DireccionImpresoraLegumbreria,
                                     ImprimirEnCarniceria = @ImprimirEnCarniceria,
                                     ImprimirEnLegumbreria = @ImprimirEnLegumbreria,
                                     CadenaDeConexionXPos = @CadenaDeConexionXPos,
                                     CadenaDeConexionBDCallCenter = @CadenaDeConexionBDCallCenter,
                                     ApiActualizacionCliente = @ApiActualizacionCliente
                    ";

                    OleDbCommand command = new OleDbCommand(Query, conn);

                        command.Parameters.AddWithValue("@EnvioALaPLataformaLaVecindad", configuracion.EnvioALaPLataformaLaVecindad);
                        command.Parameters.AddWithValue("@EnvioLaBodegaWeb", configuracion.EnvioLaBodegaWeb);
                        command.Parameters.AddWithValue("@DireccionImpresoraCarniceria", configuracion.DireccionImpresoraCarniceria);
                    command.Parameters.AddWithValue("@DireccionImpresoraLegumbreria", configuracion.DireccionImpresoraLegumbreria);
                    command.Parameters.AddWithValue("@ImprimirEnCarniceria", configuracion.ImprimirEnCarniceria);
                        command.Parameters.AddWithValue("@ImprimirEnLegumbreria", configuracion.ImprimirEnLegumbreria);
                    command.Parameters.AddWithValue("@CadenaDeConexionXPos", configuracion.CadenaDeConexionXPos);
                    command.Parameters.AddWithValue("@CadenaDeConexionBDCallCenter", configuracion.CadenaDeConexionBDCallCenter);
                    command.Parameters.AddWithValue("@ApiActualizacionCliente", configuracion.ApiActualizacionCliente);
                    await command.ExecuteNonQueryAsync();


                    resultado = true;

                }
            }
            catch (Exception)
            {

                return resultado;
            }
            return resultado;

        }



    }
}
