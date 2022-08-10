using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Areas;
            int Perimetros;
            int a;
            int b;
            int c;
            int h;

            Console.Write("Ingrese el area del angulo a:\n ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo b:\n ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo c:\n ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo h:\n ");
            h = int.Parse(Console.ReadLine());

            Areas = b * h / 2;
            Perimetros = a + b + c;

            Console.WriteLine("El Area del angulo es: \n A: " + Areas);
            Console.WriteLine("El Perimetro del angulo es:\n P: " + Perimetros);
            Console.Read();


        }
    }
}
