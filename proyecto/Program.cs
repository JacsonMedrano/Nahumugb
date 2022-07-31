using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteros;
            int enteros2;
            int Total_suma;

            Console.Write("Ingrese un numero entero");
            enteros = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero entero");
            enteros2 = int.Parse(Console.ReadLine());

            Total_suma = enteros + enteros2;

            Console.Write("El total de la suma es: " + Total_suma);
            Console.Read();
        }

    }    }
