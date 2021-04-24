using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            int primerNumero;
            int segundoNumero;
            do
            {
                Console.WriteLine("\nIngrese el primer núnero: ");
                int.TryParse(Console.ReadLine(), out primerNumero);
                Console.WriteLine("\nIngrese el segundo núnero: ");
                int.TryParse(Console.ReadLine(), out segundoNumero);
                Console.WriteLine($"La suma es {primerNumero + segundoNumero}");
                Console.WriteLine("\n¿Desea realizar otra suma?\n > S / N");

            } while (ValidarRespuesta.ValidarS_N(Console.ReadKey().KeyChar));

        }
    }
}
