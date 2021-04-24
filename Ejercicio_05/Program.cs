using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            double auxNumero;
            double acumuladorG1;
            double acumuladorG2;        

            do
            {
                Console.WriteLine("Ingrese el número 'TOPE' mayor a cero para obtener los centros numéricos: ");
                double.TryParse(Console.ReadLine(), out auxNumero);
                for (int i = 6; i <= auxNumero; i++)
                {
                    acumuladorG1 = 0;
                    acumuladorG2 = 0;
                    for (int j = 1; j < i; j++)
                    {
                        acumuladorG1 += j;
                    }
                    for (int k = i+1; acumuladorG2 < acumuladorG1; k++)
                    {
                        acumuladorG2 += k;
                    }
                    if (acumuladorG1 == acumuladorG2)
                    {
                        Console.WriteLine("El número " + i + " es un centro numérico.");
                    }       
                }
            } while (auxNumero < 1);
            Console.ReadLine();

        }
    }
}
