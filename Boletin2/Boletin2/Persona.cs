using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    abstract class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;

        public string Nombre { set; get; }
        public string Apellidos { set; get; }

        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return edad;
            }
        }

        public string DNI
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.DNI = dni;
        }

        public Persona() : this("", "", 0, "")
        {

        }

        public virtual void MuestraCampos() {
            Console.WriteLine(nombre);
            Console.WriteLine(apellidos);
            Console.WriteLine(edad);
            Console.WriteLine(dni);
        }

        public virtual void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            nombre = Console.ReadLine();
            apellidos = Console.ReadLine();
            edad = Convert.ToInt32(Console.ReadLine());
            dni = Console.ReadLine();
        }

        public abstract double Hacienda();
    }
}