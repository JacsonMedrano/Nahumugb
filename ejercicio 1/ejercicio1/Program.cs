using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas;
            int minutos = 60;
            int segundos = 3600;

            Console.Write("Ingrese las horas: \n ");
            Horas = int.Parse(Console.ReadLine());

            minutos = Horas * minutos;
            segundos = Horas * segundos;

            Console.WriteLine("El total de minutos es: \n m: "+ minutos);
            Console.WriteLine("El total de segundo es:\n s: "+ segundos);
            Console.Read();
        }
    }
}
