using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomapedidos.Utilitarios
{
    public class Recursos
    {
        public int DigitoVerificacion(string Numero)
        {

            int total = 0;

            int CantidadCaracteres = Numero.Length;

            for (int i = CantidadCaracteres; i >= 1; i--)
            {
                int value = int.Parse(Numero.Substring(CantidadCaracteres - i, 1));
                total += value * GetMultiplier(i);
            }

            int residuo = total % 11;
            int resultado = residuo == 0 ? 0 : residuo == 1 ? 1 : 11 - residuo;



            return resultado;
        }

        private int GetMultiplier(int posicion)
        {
            switch (posicion)
            {
                case 1: return 3;
                case 2: return 7;
                case 3: return 13;
                case 4: return 17;
                case 5: return 19;
                case 6: return 23;
                case 7: return 29;
                case 8: return 37;
                case 9: return 41;
                case 10: return 43;
                case 11: return 47;
                case 12: return 53;
                case 13: return 59;
                case 14: return 67;
                case 15: return 71;
                default: throw new ArgumentOutOfRangeException(nameof(posicion));
            }
        }
    }
}
