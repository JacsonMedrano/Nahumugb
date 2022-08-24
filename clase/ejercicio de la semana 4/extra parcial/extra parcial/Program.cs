using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] tabla = new string[3, 3];
           

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (y == 0)
                    {
                        Console.Write("Ingrese el nombre: ");
                        tabla[x, y] = Console.ReadLine();
                    }
                    else if (y == 1)
                    {
                        Console.Write("Ingrese el edad ");
                        tabla[x, y] = Console.ReadLine();
                    }
                    else if (y == 2) ;
                    {
                        Console.Write("Ingrese el carrera: ");
                        tabla[x, y] = Console.ReadLine();
                    }





                }
                Console.WriteLine();


            }

            Console.WriteLine("---------------");
            Console.WriteLine("mostrando en pantalla Nombre, edad y carrera");

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine(tabla[x, y] + "      ");
                }
                Console.ReadLine();
            }
            Console.ReadLine();


            

            




        }
    }
}  

           




