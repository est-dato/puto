﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor entre 1 y 5: ");
            int valor = int.Parse(Console.ReadLine());
            switch(valor)
             {
                case 1: Console.Write("uno");
                        break;
                case 2: Console.Write("dos");
                        break;
                case 3: Console.Write("tres");
                        break;
                case 4: Console.Write("cuatro");
                        break;
                case 5: Console.Write("cinco");
                        break;
                default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
            }
            Console.ReadKey();

        }
    }
}
