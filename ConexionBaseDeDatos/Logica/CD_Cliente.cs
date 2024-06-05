using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Logica
{
    public class CD_Cliente
    {
        /*
         1 listar
         2 actualizar
         3 buscar
         4 eliminar
         5 revisarCompras

         */

        public DataTable Buscar(string documento)
        {
            DataTable lista = new DataTable();
            CONEXION cn = new CONEXION();
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cn.ConexionXpos()))
                {
                    conexion.Open();
                    string query = "SELECT *" +
                                   " FROM tblCliente" +
                                   " where strIDCliente like '%" + documento + "%'" +
                                   " or strNit like '%" + documento + "%'" +
                                   " or strEmpresa like '%" + documento + "%'" +
                                   " or strRazonSocial like '%" + documento + "%'";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexion))
                    {
                        adapter.Fill(lista);
                    }


                }
            }
            catch (Exception)
            {

                lista = new DataTable();
            }

            return lista;

        }


        public bool CrearPersonaJuridica(Cliente obj)
        {
            bool respuesta;
            string query;


            CONEXION cn = new CONEXION();

            query = "insert into tblCliente (strIdCliente,strEmpresa,strTelefono,strNit,strCiudad,strTipoCliente," +
                    "strDireccion,blnperjuridica,bytTipoDocumento,bytDigitoVerificacion,strRazonSocial," +
                    "bytTipoDireccion,blnRegimenComun,bytRegimen,lngCodigoMunicipio,strWeb,strEmailContactoFE,strEmailEntregaFE," +
                    "blnImpoconsumoEnVenta,strIdUrbanaRural,strNroDocumento," +
                   "dtmFechaCreoCliente,dtmFechaCreoReferenciaPer1," +
                    "bytFacturaIVA,lngCodigoPais,strUsuarioCreoCliente,lngIDCajaCreoCliente,blnFE)" +
                    " values(@strIdCliente,@strEmpresa,@strTelefono,@strNit,@strCiudad,@strTipoCliente,@strDireccion,@blnperjuridica," +
                    "@bytTipoDocumento,@bytDigitoVerificacion,@strRazonSocial,@bytTipoDireccion,@blnRegimenComun,@bytRegimen,@lngCodigoMunicipio," +
                    "@strWeb,@strEmailContactoFE,@strEmailEntregaFE,@blnImpoconsumoEnVenta,@strIdUrbanaRural," +
                    "@strNroDocumento," +
                    "@dtmFechaCreoCliente,@dtmFechaCreoReferenciaPer1," +
                    "@bytFacturaIVA,@lngCodigoPais," +
                    "@strUsuarioCreoCliente,@lngIDCajaCreoCliente,@blnFE)";



            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cn.ConexionXpos()))
                {
                    conexion.Open();

                    OleDbCommand cmd = new OleDbCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@strNombre1", obj.strNombre1);
                    //cmd.Parameters.AddWithValue("@strApellido1", obj.strApellido1);
                    cmd.Parameters.AddWithValue("@strIdCliente", obj.strIdCliente);
                    cmd.Parameters.AddWithValue("@strEmpresa", obj.strEmpresa);
                    cmd.Parameters.AddWithValue("@strTelefono", obj.strTelefono);
                    cmd.Parameters.AddWithValue("@strNit", obj.strNit);
                    cmd.Parameters.AddWithValue("@strCiudad", obj.strCiudad);
                    cmd.Parameters.AddWithValue("@strTipoCliente", obj.strTipoCliente);
                    cmd.Parameters.AddWithValue("@strDireccion", obj.strDireccion);
                    cmd.Parameters.AddWithValue("@blnperjuridica", -1 * Convert.ToInt16(obj.blnperjuridica));
                    cmd.Parameters.AddWithValue("@bytTipoDocumento", obj.bytTipoDocumento);
                    cmd.Parameters.AddWithValue("@bytDigitoVerificacion", obj.bytDigitoVerificacion);
                    cmd.Parameters.AddWithValue("@strRazonSocial", obj.strRazonSocial);
                    cmd.Parameters.AddWithValue("@bytTipoDireccion", obj.bytTipoDireccion);
                    cmd.Parameters.AddWithValue("@blnRegimenComun", -1 * Convert.ToInt16(obj.blnRegimenComun));
                    cmd.Parameters.AddWithValue("@bytRegimen", obj.bytRegimen);
                    cmd.Parameters.AddWithValue("@lngCodigoMunicipio", obj.lngCodigoMunicipio);
                    cmd.Parameters.AddWithValue("@strWeb", obj.strWeb);
                    cmd.Parameters.AddWithValue("@strEmailContactoFE", obj.strWeb);
                    cmd.Parameters.AddWithValue("@strEmailEntregaFE", obj.strWeb);
                    cmd.Parameters.AddWithValue("@blnImpoconsumoEnVenta", -1 * Convert.ToInt16(obj.blnImpoconsumoEnVenta));
                    cmd.Parameters.AddWithValue("@strIdUrbanaRural", obj.strIdUrbanaRural);
                    cmd.Parameters.AddWithValue("@strNroDocumento", obj.strNroDocumento);
                    cmd.Parameters.AddWithValue("@dtmFechaCreoCliente", Convert.ToString(obj.dtmFechaCreoCliente));
                    cmd.Parameters.AddWithValue("@dtmFechaCreoReferenciaPer1", Convert.ToString(obj.dtmFechaCreoReferenciaPer1));
                    cmd.Parameters.AddWithValue("@bytFacturaIVA", obj.bytFacturaIVA);
                    cmd.Parameters.AddWithValue("@lngCodigoPais", obj.lngCodigoPais);
                    cmd.Parameters.AddWithValue("@strUsuarioCreoCliente", obj.strUsuarioCreoCliente);
                    cmd.Parameters.AddWithValue("@lngIDCajaCreoCliente", obj.lngIDCajaCreoCliente);
                    cmd.Parameters.AddWithValue("@blnFE", -1 * Convert.ToInt16(obj.blnFE));

                    cmd.ExecuteNonQuery();

                }

                respuesta = true;
            }
            catch (Exception ex)
            {

                respuesta = false;
            }




            return respuesta;
        }
        public bool CrearPersonaNatural(Cliente obj)
        {
            bool respuesta = false;
            string query = "";


            CONEXION cn = new CONEXION();

            query = "insert into tblCliente (strNombre1,strApellido1,strIdCliente,strEmpresa,strTelefono,strCiudad,strTipoCliente," +
                     "strDireccion,blnperjuridica,bytTipoDocumento," +
                     "bytTipoDireccion,blnRegimenComun,bytRegimen,lngCodigoMunicipio,strWeb,strEmailContactoFE,strEmailEntregaFE," +
                     "blnImpoconsumoEnVenta,strIdUrbanaRural,strNroDocumento," +
                    "dtmFechaCreoCliente,dtmFechaCreoReferenciaPer1," +
                     "bytFacturaIVA,lngCodigoPais,strUsuarioCreoCliente,lngIDCajaCreoCliente,blnFE)" +
                     " values(@strNombre1,@strApellido1,@strIdCliente,@strEmpresa,@strTelefono,@strCiudad,@strTipoCliente,@strDireccion,@blnperjuridica," +
                     "@bytTipoDocumento,@bytTipoDireccion,@blnRegimenComun,@bytRegimen,@lngCodigoMunicipio," +
                     "@strWeb,@strEmailContactoFE,@strEmailEntregaFE,@blnImpoconsumoEnVenta,@strIdUrbanaRural," +
                     "@strNroDocumento," +
                     "@dtmFechaCreoCliente,@dtmFechaCreoReferenciaPer1," +
                     "@bytFacturaIVA,@lngCodigoPais," +
                     "@strUsuarioCreoCliente,@lngIDCajaCreoCliente,@blnFE)";


            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cn.ConexionXpos()))
                {
                    conexion.Open();

                    OleDbCommand cmd = new OleDbCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@strNombre1", obj.strNombre1);
                    cmd.Parameters.AddWithValue("@strApellido1", obj.strApellido1);
                    cmd.Parameters.AddWithValue("@strIdCliente", obj.strIdCliente);
                    cmd.Parameters.AddWithValue("@strEmpresa", obj.strEmpresa);
                    cmd.Parameters.AddWithValue("@strTelefono", obj.strTelefono);
                    // cmd.Parameters.AddWithValue("@strNit", obj.strNit);
                    cmd.Parameters.AddWithValue("@strCiudad", obj.strCiudad);
                    cmd.Parameters.AddWithValue("@strTipoCliente", obj.strTipoCliente);
                    cmd.Parameters.AddWithValue("@strDireccion", obj.strDireccion);
                    cmd.Parameters.AddWithValue("@blnperjuridica", -1 * Convert.ToInt16(obj.blnperjuridica));
                    cmd.Parameters.AddWithValue("@bytTipoDocumento", obj.bytTipoDocumento);
                    //cmd.Parameters.AddWithValue("@bytDigitoVerificacion", obj.bytDigitoVerificacion);
                    //cmd.Parameters.AddWithValue("@strRazonSocial", obj.strRazonSocial);
                    cmd.Parameters.AddWithValue("@bytTipoDireccion", obj.bytTipoDireccion);
                    cmd.Parameters.AddWithValue("@blnRegimenComun", -1 * Convert.ToInt16(obj.blnRegimenComun));
                    cmd.Parameters.AddWithValue("@bytRegimen", obj.bytRegimen);
                    cmd.Parameters.AddWithValue("@lngCodigoMunicipio", obj.lngCodigoMunicipio);
                    cmd.Parameters.AddWithValue("@strWeb", obj.strWeb);
                    cmd.Parameters.AddWithValue("@strEmailContactoFE", obj.strWeb);
                    cmd.Parameters.AddWithValue("@strEmailEntregaFE", obj.strWeb);
                    cmd.Parameters.AddWithValue("@blnImpoconsumoEnVenta", -1 * Convert.ToInt16(obj.blnImpoconsumoEnVenta));
                    cmd.Parameters.AddWithValue("@strIdUrbanaRural", obj.strIdUrbanaRural);
                    cmd.Parameters.AddWithValue("@strNroDocumento", obj.strNroDocumento);
                    cmd.Parameters.AddWithValue("@dtmFechaCreoCliente", Convert.ToString(obj.dtmFechaCreoCliente));
                    cmd.Parameters.AddWithValue("@dtmFechaCreoReferenciaPer1", Convert.ToString(obj.dtmFechaCreoReferenciaPer1));
                    cmd.Parameters.AddWithValue("@bytFacturaIVA", obj.bytFacturaIVA);
                    cmd.Parameters.AddWithValue("@lngCodigoPais", obj.lngCodigoPais);
                    cmd.Parameters.AddWithValue("@strUsuarioCreoCliente", obj.strUsuarioCreoCliente);
                    cmd.Parameters.AddWithValue("@lngIDCajaCreoCliente", obj.lngIDCajaCreoCliente);
                    cmd.Parameters.AddWithValue("@blnFE", -1 * Convert.ToInt16(obj.blnFE));

                    cmd.ExecuteNonQuery();

                }

                respuesta = true;
            }
            catch (Exception ex)
            {

                respuesta = false;
            }




            return respuesta;
        }

        public bool ActualizarCliente(string Telefono)
        {
            string query = "UPDATE tblCliente set strApellido1 = 1,strCiudad = 'MEDELLÍN',strTipoCliente = '1',lngCodigoPais = 1," +
                           "bytFacturaIVA = 1" +
                           "strNroDocumento = '222222222222', strIdUrbanaRural = 'U'" +
                           "strWeb = 'labodegadenacho@hotmail.com'," +
                           "strEmailContactoFE = 'labodegadenacho@hotmail.com'" +
                           "strEmailEntregaFE = 'labodegadenacho@hotmail.com'" +
                           " where strIdCliente = '" + Telefono + "'";



            return false;
        }
    }
}
