using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int auxNumero = 1;
            bool esPrimo = true;

            do
            {
                Console.WriteLine("Ingrese el número 'TOPE' mayor a cero para optener los PRIMOS: ");
                int.TryParse(Console.ReadLine(), out auxNumero);
                for (int i = 2; i <= auxNumero; i++)
                {
                    esPrimo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                        }
                    }
                    if (esPrimo == true)
                    {
                        Console.WriteLine("\n" + i + " Es Primo");
                    }
                }
            } while (auxNumero < 1);
            Console.ReadLine();
        }
    }
}
