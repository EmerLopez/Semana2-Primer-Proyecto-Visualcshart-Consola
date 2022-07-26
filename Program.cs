using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Primer_Proyecto_Visualcshart_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0; int b = 0;

        
            Console.WriteLine("Consola de calculadora en C#\r");
            Console.WriteLine("------------------------\n");

          
            Console.WriteLine("Escriba un numero luego presione enter");
            a = Convert.ToInt32(Console.ReadLine());

          
            Console.WriteLine("Escriba un numero luego presione enter");
            b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Elige una opcion de la lista:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicacion");
            Console.WriteLine("\td - Division");
            Console.Write("Su opcion? ");

        
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"El resultado es: {a} + {b} = " + (a + b));
                    break;
                case "r":
                    Console.WriteLine($"El resultado es:{a} - {b} = " + (a - b));
                    break;
                case "m":
                    Console.WriteLine($"El resultado es: {a} * {b} = " + (a * b));
                    break;
                case "d":
                    Console.WriteLine($"El resultado es: {a} / {b} = " + (a / b));
                    break;
            }
            
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
