using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    abstract class Persona
    {

        public string Nombre { set; get; }
        public string Apellidos { set; get; }

        private int edad;
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

        private string dni;
        public string DNI
        {
            set
            {
                dni = value;
            }
            get
            {
                // string[] letras = new string[] {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "X", "B" +
                //  "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};
                string letras = "TRWAGMYFPDXBNJZSQVHLCKE";

                int result = 0;
                int numeros = Convert.ToInt32(dni);
                result = numeros % 23;

                return dni + letras[result];
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

        public virtual void MuestraCampos()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Apellidos: {0}", Apellidos);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("DNI: {0}", DNI);
        }

        public virtual void IntroCampos() //arreglar
        {
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            Apellidos = Console.ReadLine();
            Console.Write("Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("DNI: ");
            DNI = Console.ReadLine();
        }

        public abstract double Hacienda();
    }
}