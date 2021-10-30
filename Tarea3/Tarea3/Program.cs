using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, producto;
            string linea;
            Console.Write("Ingrese primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            producto = num1 * num2;
            Console.Write("El resultado de la multiplicacion es:");
            Console.ReadKey();

        }
    }
}
