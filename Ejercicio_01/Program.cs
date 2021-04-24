using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int maxValor = 0;
            int minValor = 0;
            int auxValor;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el " + (i+1) + "º número");
                int.TryParse(Console.ReadLine(), out auxValor);
                acumulador += auxValor;
                if (i == 0 || auxValor > maxValor)
                {
                    maxValor = auxValor;
                }
                if (i == 0 || auxValor < minValor)
                {
                    minValor = auxValor;
                }
            }
            promedio = acumulador / 5;
            Console.WriteLine("Número  máximo: " + maxValor);
            Console.WriteLine("Número  mínimo: " + minValor);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadLine();
        }
    }
}
