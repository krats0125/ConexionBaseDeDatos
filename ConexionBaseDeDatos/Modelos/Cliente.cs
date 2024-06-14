using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDeDatos.Modelos
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Telefono4 { get; set; }
        public string Categoria { get; set; }
        public string Puntos { get;set; }


        //________________________________________ Datos como estan en la base de datos de xpos_____________________________________________

        public string strIdCliente { get; set; } // lo mismo de idCliente
        public string strEmpresa { get; set; } // los mismo denombre completo
        public string strTelefono { get; set; } // telefono 1
        public string strNit { get; set; } // telefono 2
        public string strCiudad { get; set; }  
        public string strTipoCliente { get; set; } // si es bronce, cobre, plata, oro, platino, diamante
        public string strDireccion { get; set; } // lo mismo que direccion
        public bool blnperjuridica { get; set; } 
        public int bytTipoDocumento { get; set; }
        public int bytDigitoVerificacion { get; set; }
        public string strRazonSocial { get; set; }
        public int bytTipoDireccion { get; set; } = 1;
        public bool blnRegimenComun { get; set; }
        public int bytRegimen { get; set; }
        public int lngCodigoMunicipio { get; set; }
        public string strWeb { get; set; }
        public bool blnImpoconsumoEnVenta { get; set; }
        public string strIdUrbanaRural { get; set; } = "U";
        public string strNroDocumento { get; set; }
        public DateTime dtmFechaCreoCliente { get; set; } = DateTime.Now;
        public DateTime dtmFechaCreoReferenciaPer1 { get; set; } = DateTime.Now;
        public int bytFacturaIVA { get; set; } = 1;
        public int lngCodigoPais { get; set; } = 1;
        public string strUsuarioCreoCliente { get; set; }
        public int lngIDCajaCreoCliente { get; set; }
        public bool blnFE { get; set; } = true;

        public string strmail { get; set; }

        public string strNombre1 { get; set; } // Primer Nombre
        public string strApellido1 { get; set; } // Primer Apellido

        public string dtmFechaUltimaCompra { get; set; } // Fecha de la ultima compra

        public string dtmNacimiento { get; set; }


    }
}
