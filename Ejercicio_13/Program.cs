using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";
            Console.WriteLine(Conversor.DecimalBinario(50));
            Console.WriteLine(Conversor.BinarioDecimal("110010"));
            Console.ReadLine();
        }
    }
}
