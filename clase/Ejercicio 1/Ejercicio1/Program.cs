using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas;
            int minutos = 60;
            int segundos = 3600;
            int valor;
            Console.Write("|------------digite una opcion---------| \n 1 = convertir horas a minutos. \n 2 = convertir horas a segundos. \n"); 
                         
             valor = int.Parse(Console.ReadLine());

          
            if (valor <= 1)
            {
                Console.Write("|-------------Ingrese las horas-------| \n ");
                Horas = int.Parse(Console.ReadLine()); 
                int v = Horas * minutos;
                minutos = v;
                Console.WriteLine("|------------El total de minutos es-----------| \n m: " + minutos);
            }
            else if (valor == 2)
            {
                Console.Write("|----------Ingrese las horas----------| \n ");
                Horas = int.Parse(Console.ReadLine ()); 
                segundos = Horas
                    * segundos;
                Console.WriteLine("|------------El total de segundo es------------|\n s: " + segundos);
            }
            else
            {
                Console.Write("|--------------La opcion ingresada es incorrecta-------------|");
            }
                
            Console.Read();
        }
    }
}
