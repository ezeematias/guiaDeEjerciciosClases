using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            int perfectNumber = 6;
            int collector = 0;
            int amount = 0;
            Console.WriteLine("Los primeros cuatro números perfectos son: ");
            do
            {
                for (int i = 1; i < perfectNumber; i++)
                {
                    if (perfectNumber % i == 0)
                    {
                        collector += i;
                    }
                }
                if (perfectNumber == collector)
                {
                    Console.WriteLine(perfectNumber);
                    amount++;
                }
                collector = 0;
                perfectNumber++;
            } while (amount < 4);
            Console.WriteLine("\n\nFIN =)");
            Console.ReadKey();
        }
    }
}
