using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            String Código;
            String Nombre;
            int Edad;

            Console.WriteLine("Ingresa cuantos registros desea ingresar:");
            int registros = int.Parse(Console.ReadLine());

            Estudiantes[] arregloestudiantes = new Estudiantes[registros];


            for (int i = 0; i < registros; i++)
            {
                Id = i + 1;
                Console.WriteLine("-----------Ingrese los siguientes datos--------------:");
                Console.WriteLine("°°°°°°°°°°°Ingrese el Código del registro:°°°°°°°°°°°° ");
                Código = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("°°°°°°°°°°°Ingrese el Nombre del registro:°°°°°°°°°°° ");
                Nombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("°°°°°°°°°°Ingrese la edad del registro°°°°°°°°°°° ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                arregloestudiantes[i] = new Estudiantes(Id, Código, Nombre, Edad);
            }

           
            int consultas = 1;

            while (consultas == 1)
            {
                int datoint, op;
                string dato;

                Console.WriteLine(" 1: si desea, consultar por la edad. \n 2: si desea, consultar por id. \n 3: si desea, consultar por el nombre ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {

                    Console.WriteLine("Ingresar desde que rango desea buscar la edad ");
                    datoint = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Edad >= datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }

                else if (op == 2)
                {

                    Console.WriteLine("Ingresar el id que desea buscar, en los registro ");
                    datoint = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Id == datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }
                }
                else if (op == 3)
                {


                    Console.WriteLine("Ingresar el Nombre, que desea buscar, en los registro ");
                    dato = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Nombre == dato
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }


                }
                Console.WriteLine("1: si desea, consultar nuevamente u otro digito si, no se desea");
                consultas = int.Parse(Console.ReadLine());

            }



            Console.Read();
        }
    }
}
