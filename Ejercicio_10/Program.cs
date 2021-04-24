using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";

            int altura;
            string caracter;           

            Console.WriteLine("Vamos a realizar una media pirámide...\n\n¿Qué altura le vamos a dar?");
            int.TryParse(Console.ReadLine(), out altura);
            Console.WriteLine("Ahora ingresar solamente un caracter para crearla: ");
            caracter = Console.ReadLine();
            Console.WriteLine("-------------------\n");

            for (int i = 0; i < altura; i++)
            {
                for (int k = 1; k <= (altura - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {                    
                    if (j == 0)
                        Console.Write(caracter);
                    else
                        Console.Write(caracter + caracter);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
