using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double volumen;
            double Altura;
            double pi = 3.1416;
            double Radio;
            
            

            Console.Write("Ingrese el Radio del cilindro: \n ");
            Radio = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la altura del cilindro: \n ");
            Altura = int.Parse(Console.ReadLine());

            
            area = 2
                   * pi
                   * Radio
                   * (Radio + Altura);

            volumen = (double)(pi
                     * Radio * 2
                     * Altura);

            Console.WriteLine("El Area del cilindo es: \n A: " + area);
            Console.WriteLine(value: "El volumen del cilindo es:\n V: " + volumen);
            Console.Read();


          


        }
    }
}
