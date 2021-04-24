using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            DateTime dateTime = new DateTime();            
            Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/yy)");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)) //no me improta la cultura porque es un parseo exacto. 
            {                
                DateTime now = DateTime.Now;
                TimeSpan diff = now - dateTime;
                Console.WriteLine($"La cantidad de dias vividos es: {diff.Days}");
            }
            Console.ReadLine();
        }
    }
}
