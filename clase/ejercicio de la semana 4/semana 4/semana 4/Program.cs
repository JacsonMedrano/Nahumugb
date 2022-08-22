using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Nombres;
            string []carrera;
            int[] edad;
            string[] email;
            int[] celular;

            Console.WriteLine("Ingrese cuantos registro desea ingresar");
            int registro = int.Parse(Console.ReadLine());

            Nombres = new string [registro];
            carrera = new string [registro];
            edad = new int [registro];
            email = new string [registro];
            celular = new int [registro];

            for (int i = 0; i < registro; i++)
            { 
                Console.Write("Ingresar el nombre del registro"+"["+(i+1)+"]");
                Nombres[i] = Console.ReadLine();

                Console.Write("Ingresar la carrera del registro" + "[" + (i + 1) + "]");
                carrera[i] = Console.ReadLine();

                Console.Write("Ingresar edad del registro" + "[" + (i + 1) + "]");
                edad[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingresar el correo del registro" + "[" + (i + 1) + "]");
                email[i] = Console.ReadLine();

                Console.WriteLine("Ingresar el celular del registro" + "[" + (i + 1) + "]");
                celular[i] = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");


            }
            string opciones = "si";
            while (opciones == "SI" || opciones == "si") 
            {
                Console.WriteLine("Ingresar el numero de registro que desea observar");
                int registroA = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre: " + Nombres[registroA] + "\nCarrera: " + carrera[registroA] + "\nEdad: " + edad[registroA] + "\nEmail: " + email[registroA] + "\nTelefono: " + celular[registroA] + "\n");
                

                Console.WriteLine("¿Desea ver otros registro? (SI/NO): ");
                opciones = Console.ReadLine();

            }
       
        }
    }
}
