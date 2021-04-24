using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            int auxNumero = 0;

            do
            {
                Console.WriteLine("Ingrese un número mayor que cero: ");
                int.TryParse(Console.ReadLine(), out auxNumero);
                if(auxNumero > 0)
                {
                    Console.WriteLine("El cuadrado de " + auxNumero + " es " + Math.Pow(auxNumero, 2));
                    Console.WriteLine("El cubo de " + auxNumero + " es " + Math.Pow(auxNumero, 3));
                }
            } while (auxNumero <= 0);
            Console.ReadLine();
        }
    }
}
