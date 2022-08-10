using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el nombre del paciente:");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingresar la edad del paciente: ");
            int Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar el peso del paciente:");
            double Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar la estatura del paciente:");
            double Estatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar el tipo de sangre del paciente:");
            string Tiposangre = Console.ReadLine();

            Console.WriteLine("Presiona la tecla ENTER para continuar");
            Console.ReadKey();

            Console.WriteLine("Los datos del paciente son los siguientes: \n" + "Nombre: \n " + Nombre + " \nEdad: \n" + Edad + "\nPeso: \n" + Peso + "\nEstatura: \n" + Estatura + "\nTipo sangre: \n" + Tiposangre);
            Console.ReadKey();



        }
    }
}
