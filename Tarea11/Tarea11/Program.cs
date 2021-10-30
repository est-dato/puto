using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese un segundo numero: ");
            linea = Console.ReadLine();
            num2= int.Parse(linea);


            if (num1 > num2) 
            {
                Console.Write("El numero mayor es: ");
                Console.WriteLine(num1);
            }
            else
            {
                Console.Write("El numero mayor es: ");
                Console.WriteLine(num2);
            }
            Console.ReadKey();





        }
    }
}
