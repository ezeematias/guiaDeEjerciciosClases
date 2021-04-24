using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int auxValor;
            int maxValor = 0;
            int minValor = 0;
            int acumulador = 0;
            int promedio;
            bool valido;

            for (int i = 0; i < 10; i++)
            {
                valido = false;
                do
                {
                    Console.WriteLine("Ingrese el " + (i + 1) + "º número");
                    int.TryParse(Console.ReadLine(), out auxValor);
                    if (Validación.Validar(auxValor, -100, 100))
                    {
                        acumulador += auxValor;
                        if (i == 0 || auxValor > maxValor)
                        {
                            maxValor = auxValor;
                        }
                        if (i == 0 || auxValor < minValor)
                        {
                            minValor = auxValor;
                        }
                        valido = true;
                    }
                } while (valido == false);
            }
            promedio = acumulador / 10;
            Console.WriteLine("Número  máximo: " + maxValor);
            Console.WriteLine("Número  mínimo: " + minValor);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadLine();

        }
    }
}
