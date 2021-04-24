using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejrcicio Nro 06";

            int desde;
            int hasta;
            bool esBisiesto;

            Console.WriteLine("Ingrese un rango de años para averiguar los Bisiestos\nDesde: ");
            int.TryParse(Console.ReadLine(),out desde);
            Console.WriteLine("Hasta: ");
            int.TryParse(Console.ReadLine(), out hasta);

            for (int i = desde; i <= hasta; i++)
            {
                esBisiesto = false;
                if( i % 4 == 0)
                {
                    esBisiesto = true;
                }
                if( i % 100 == 0)
                {
                    esBisiesto = false;
                    if(i % 400 == 0)
                    {
                        esBisiesto = true;
                    }
                }                
                if(esBisiesto)
                    Console.WriteLine("El año " + i + " es bisiesto.");
            }
            Console.ReadLine();
        }
    }
}
