using ConexionBaseDeDatos.Modelos;
using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;

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
                    string query = "SELECT (strDireccion) as Direccion,(strIDCliente) as IdCliente, (strTelefono) as Telefono1, (strCelular) as Telefono2, (strTelefonoOficina) as Telefono3,(strWhatsapp) as Telefono4, (strEmpresa) AS NombreCompleto," +
                                   " (strNit) as Documento, (strCiudad) as Ciudad, (dtmNacimiento) as Nacimiento, (strTipoCliente) As IdCategoria, (lngPuntosAcumulados) as Puntos, (strmail) as Correo, (blnperjuridica) as EsPersonaJuridica," +
                                   " bytTipoDocumento, (strRazonSocial) as RazonSocial, (strNombre1) As Nombre1, (strNombre2) as Nombre2,(strApellido1) as Apellido1, (strApellido2) as Apelllido2," +
                                   " (blnRegimenComun) as EsRegimenComun, (dtmFechaCreoCliente) As FechaCreacion, (lngMesUltimaFactura) As FechaUltCompra" +
                                   " FROM tblCliente" +
                                   " where strIDCliente like '%" + documento + "%'" +
                                   " or strNit like '%" + documento + "%'" +
                                   " or strEmpresa like '%" + documento + "%'" +
                                   " or strRazonSocial like '%" + documento + "%'" +
                                   " or strDireccion like '%" + documento + "%'";

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
                    "bytTipoDireccion,blnRegimenComun,bytRegimen,lngCodigoMunicipio,strmail,strEmailContactoFE,strEmailEntregaFE," +
                    "blnImpoconsumoEnVenta,strIdUrbanaRural,strNroDocumento," +
                   "dtmFechaCreoCliente,dtmFechaCreoReferenciaPer1," +
                    "bytFacturaIVA,lngCodigoPais,strUsuarioCreoCliente,lngIDCajaCreoCliente,blnFE)" +
                    " values(@strIdCliente,@strEmpresa,@strTelefono,@strNit,@strCiudad,@strTipoCliente,@strDireccion,@blnperjuridica," +
                    "@bytTipoDocumento,@bytDigitoVerificacion,@strRazonSocial,@bytTipoDireccion,@blnRegimenComun,@bytRegimen,@lngCodigoMunicipio," +
                    "@strmail,@strEmailContactoFE,@strEmailEntregaFE,@blnImpoconsumoEnVenta,@strIdUrbanaRural," +
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
                    cmd.Parameters.AddWithValue("@strmail", obj.strmail);
                    cmd.Parameters.AddWithValue("@strEmailContactoFE", obj.strmail);
                    cmd.Parameters.AddWithValue("@strEmailEntregaFE", obj.strmail);
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
                     "bytTipoDireccion,blnRegimenComun,bytRegimen,lngCodigoMunicipio,strmail,strEmailContactoFE,strEmailEntregaFE," +
                     "blnImpoconsumoEnVenta,strIdUrbanaRural,strNroDocumento," +
                    "dtmFechaCreoCliente,dtmFechaCreoReferenciaPer1," +
                     "bytFacturaIVA,lngCodigoPais,strUsuarioCreoCliente,lngIDCajaCreoCliente,blnFE,dtmNacimiento)" +
                     " values(@strNombre1,@strApellido1,@strIdCliente,@strEmpresa,@strTelefono,@strCiudad,@strTipoCliente,@strDireccion,@blnperjuridica," +
                     "@bytTipoDocumento,@bytTipoDireccion,@blnRegimenComun,@bytRegimen,@lngCodigoMunicipio," +
                     "@strmail,@strEmailContactoFE,@strEmailEntregaFE,@blnImpoconsumoEnVenta,@strIdUrbanaRural," +
                     "@strNroDocumento," +
                     "@dtmFechaCreoCliente,@dtmFechaCreoReferenciaPer1," +
                     "@bytFacturaIVA,@lngCodigoPais," +
                     "@strUsuarioCreoCliente,@lngIDCajaCreoCliente,@blnFE,@dtmNacimiento)";


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
                    cmd.Parameters.AddWithValue("@strmail", obj.strmail);
                    cmd.Parameters.AddWithValue("@strEmailContactoFE", obj.strmail);
                    cmd.Parameters.AddWithValue("@strEmailEntregaFE", obj.strmail);
                    cmd.Parameters.AddWithValue("@blnImpoconsumoEnVenta", -1 * Convert.ToInt16(obj.blnImpoconsumoEnVenta));
                    cmd.Parameters.AddWithValue("@strIdUrbanaRural", obj.strIdUrbanaRural);
                    cmd.Parameters.AddWithValue("@strNroDocumento", obj.strNroDocumento);
                    cmd.Parameters.AddWithValue("@dtmFechaCreoCliente", Convert.ToString(obj.dtmFechaCreoCliente));
                    cmd.Parameters.AddWithValue("@dtmFechaCreoReferenciaPer1", Convert.ToString(obj.dtmFechaCreoReferenciaPer1));
                    cmd.Parameters.AddWithValue("@bytFacturaIVA", obj.bytFacturaIVA);
                    cmd.Parameters.AddWithValue("@lngCodigoPais", obj.lngCodigoPais);
                    cmd.Parameters.AddWithValue("@strUsuarioCreoCliente", obj.strUsuarioCreoCliente);
                    cmd.Parameters.AddWithValue("@lngIDCajaCreoCliente", obj.lngIDCajaCreoCliente);
                    cmd.Parameters.AddWithValue("@dtmNacimiento", obj.dtmNacimiento) ;
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


        /*,
            update tblCliente set,
            strNombre1 = @strNombre1,
            strApellido1 = @strApellido1,
            blnperjuridica = @blnperjuridica,
            strRazonSocial = @strRazonSocial,
            blnperjuridica = @blnperjuridica,
            strNit = @strNit,
            Telefono = @Telefono,
            Telefono2 = @Telefono2,
            Telefono3 = @Telefono3,
            Telefono4 = @Telefono4,
            strDireccion  = @strDireccion,
            strmail = @strmail,
            strEmailContactoFE = @strmail,
            strEmailEntregaFE = @strmail,
            dtmNacimiento= @dtmNacimiento,
            where strIdCliente = @strIdCliente,
         
         */

        
        public bool ActualizarCliente(Cliente obj)
        {
            CONEXION con = new CONEXION();

            List<string> listaDeQueries = new List<string> ();

            string inicio = "UPDATE tblCliente SET ";
            string fin = " Where strIdCliente = '" + obj.strIdCliente + "'";


            string text1 = inicio + "strNombre1 = " + "'" + obj.strNombre1 + "'" + fin;
            string text2 = inicio + "strApellido1 = " + "'" + obj.strApellido1 + "'" +  fin;
            string text3 = inicio + "blnperjuridica = " + obj.blnperjuridica + fin;
            string text4 = inicio + "strRazonSocial = " + "'" + obj.strRazonSocial + "'" + fin;
            string text5 = inicio + "strNit = " + "'" + obj.strNit + "'" + fin;
            string text6 = inicio + "strTelefono = " + "'" + obj.Telefono + "'" + fin;
            string text7 = inicio + "strCelular = " + "'" + obj.Telefono2 + "'" + fin;
            string text8 = inicio + "strTelefonoOficina = " + "'" + obj.Telefono3 + "'" + fin;
            string text9 = inicio + "strWhatsapp = " + "'" + obj.Telefono4 + "'" + fin;
            string text10 = inicio + "strDireccion = " + "'" + obj.strDireccion + "'" + fin;
            string text11 = inicio + "strmail = " + "'" + obj.strmail + "'" + fin;
            string text12 = inicio + "strEmailContactoFE = " + "'" + obj.strmail + "'" + fin;
            string text13 = inicio + "strEmailEntregaFE = " + "'" + obj.strmail + "'" + fin;
            string text14 = inicio + "dtmNacimiento = " + "'" + obj.dtmNacimiento + "'" + fin;
          

            listaDeQueries.Add(text1);
            listaDeQueries.Add(text2);
            listaDeQueries.Add(text3);
            listaDeQueries.Add(text4);
            listaDeQueries.Add(text5);
            listaDeQueries.Add(text6);
            listaDeQueries.Add(text7);
            listaDeQueries.Add(text8);
            listaDeQueries.Add(text9);
            listaDeQueries.Add(text10);
            listaDeQueries.Add(text11);
            listaDeQueries.Add(text12);
            listaDeQueries.Add(text13);
            listaDeQueries.Add(text14);
           


            try
            {
                using (OleDbConnection conexion = new OleDbConnection(con.ConexionXpos()))
                {
                    conexion.Open();

                    foreach (var item in listaDeQueries)
                    {
                        OleDbCommand cmd = new OleDbCommand(item, conexion);
                        cmd.ExecuteNonQuery();
                    }
                   
                }
            }
            catch (Exception)
            {

                return false;
            }
            
                            



            return true;
        }
    }
}
