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
            int numero = 1 ;
            while (numero != 0)
            {
                Console.WriteLine("Escriba la altura (H) del cilindro");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el radio (R) del cilindro");
                double Radio = double.Parse(Console.ReadLine());

                double R2 = (Radio + altura);
                double Area = (3.14 * 2) * R2;
                double Volumen = 3.14 * (Radio * 2) * altura;

                Console.WriteLine($"El area del cilindro es de: \n  {Area} cm2");
                Console.WriteLine($"el perimetro del cilindro es de:\n {Volumen} cm2 ");
                Console.WriteLine("Ingresar el numero 0 para finalizar o otro numero para continuar");
                numero = int.Parse(Console.ReadLine());


            }

            Console.Read();

        }    
             

        

    }
}

