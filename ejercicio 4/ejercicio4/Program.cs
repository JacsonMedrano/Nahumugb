using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            double suma;
            double resta;
            double division;
            double multiplicacion;
            double m;
            double n;

            Console.Write("Escriba el Primer numero: \n ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo numero: \n ");
            n = Convert.ToInt32(Console.ReadLine());

            suma = (double)(m + n);

            Console.WriteLine("La suma de los numeros es: \n " + "Suma: " + suma );
            resta = m + n;
            Console.WriteLine("Presiona la tecla ENTER para continuar");
            Console.ReadKey();

   
            //------------------------------------------------------------
            Console.Write("Escriba el Primer numero: \n ");
             m = Convert.ToInt32(Console.ReadLine());

             Console.Write("Escriba el segundo numero: \n ");
             n = Convert.ToInt32(Console.ReadLine());


            resta = (double)(m - n);

            Console.WriteLine("La Resta de los numeros es: \n " + "Resta: " + resta);
            resta = m - n;
            Console.WriteLine("Presiona la tecla ENTER para continuar");
            Console.ReadKey();

            //-------------------------------------------------------------

            Console.Write("Escriba el Primer numero: \n ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba el segundo numero: \n ");
            n = Convert.ToInt32(Console.ReadLine());


            division = (double)(m / n);

            Console.WriteLine("La Division de los numeros es: \n " + "Division: " + division);
            division = m / n;
            Console.WriteLine("Presiona la tecla ENTER para continuar");
            Console.ReadKey();

            //-------------------------------------------------------------


            Console.Write("Escriba el Primer numero: \n ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba el segundo numero: \n ");
            n = Convert.ToInt32(Console.ReadLine());


            multiplicacion = (double)(m * n);

            Console.WriteLine("La Multiplicacion de los numeros es: \n " + "Multiplicacion: " + multiplicacion);
            multiplicacion = m * n;
            Console.WriteLine("Presiona la tecla ENTER para continuar" );
            Console.ReadKey();

            //------------------------------------------------------------------










        }
    }

}
