using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nr 08";

            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            float sueldoBruto;
            float sueldoNeto;
            float descuento = 0.87f;
            int cantidadEmpleados;

            Console.WriteLine("¿Cuantos empleados vamos a liquidar?");
            int.TryParse(Console.ReadLine(), out cantidadEmpleados);
            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("Ingresar nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresar la antigüedad del empleado: ");
                int.TryParse(Console.ReadLine(), out antiguedad);
                Console.WriteLine("Ingresar la cantidad de horas trabajadas del empleado: ");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);
                Console.WriteLine("Ingresar valor de la hora: ");
                int.TryParse(Console.ReadLine(), out valorHora);
                sueldoBruto = (horasTrabajadas * valorHora) + (antiguedad * 150);
                sueldoNeto = sueldoBruto * descuento;
                Console.WriteLine($"\nNombre: {nombre}\nAntigüedad: {antiguedad}\nValor de Hora: {valorHora}\nSueldo Bruto: {sueldoBruto}\nDescuentos: {sueldoBruto*0.13}\nSueldo Neto: {sueldoNeto}");

            }
            Console.ReadLine();
        }
    }
}
