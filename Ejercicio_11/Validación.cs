using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validación
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool output = false;
            if (valor >= min && valor <= max)
            {
                output = true;
            }
            return output;
        }
    }
}
