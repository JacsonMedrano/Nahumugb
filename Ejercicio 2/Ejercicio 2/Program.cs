using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
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

            Console.Write("Ingrese el area del angulo a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo c: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el area del angulo h: ");
            h = int.Parse(Console.ReadLine());

            Areas = b * h / 2;
            Perimetros = a + b + c;

            Console.WriteLine("El Area del angulo es: " + Areas);
            Console.WriteLine("El Perimetro del angulo es: " + Perimetros);
            Console.Read();


        }
    }
}
