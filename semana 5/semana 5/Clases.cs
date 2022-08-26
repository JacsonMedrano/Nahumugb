using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_5
{
    class Estudiantes
    {
        private int id;
        private String código;
        private String nombre;
        private int edad;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Código
        {
            get { return código; }
            set { código = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }



        public Estudiantes(int id, String código, string nombre, int edad)
        {
            this.id = id;
            this.código = código;
            this.nombre = nombre;
            this.edad = edad;

        }

        public string mostrar()
        {
            return id + " " + código + " " + nombre + " " + edad;
        }

    }
}
