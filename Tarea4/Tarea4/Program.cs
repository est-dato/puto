using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resta;
            string  linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            resta = num1 - num2;
            Console.Write("La resta de los siguientes numeros es: ");
            Console.WriteLine(resta);
            Console.ReadKey();

        }
    }
}
