using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {

        public static string DecimalBinario(int numDecimal)
        {

            long binario = 0;
            int divisor = 2;
            long digito;

            for (int i = numDecimal % divisor, j = 0; numDecimal > 0; numDecimal /= divisor, i = numDecimal % divisor, j++)
            {
                digito = i % divisor;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario.ToString();
        }

        public static int BinarioDecimal(string binario)
        {
            int numero = 0;
            int digito;
            int divisor = 10;

            for (long i = int.Parse(binario), j = 0; i > 0; i /= divisor, j++)
            {
                digito = (int)i % divisor;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero;
        }
    }
}
