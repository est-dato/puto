using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma ;
            string linea;
            Console.Write("Ingrese primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = (num1 + num2)/6;
           
            Console.Write("El resultado es :");
            Console.WriteLine(suma);
            Console.ReadKey();



        }
    }
}
