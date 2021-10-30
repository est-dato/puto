using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div ;
            string linea;
            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if (num2 == 0)
            {
             Console.Write("Error:NO se puede dividir entre cero.");
            }
            else
            {
                div = num1 / num2;
                Console.Write("El resultado es :");
                Console.WriteLine(div);
            }
            Console.ReadKey();

        }
    }
}
