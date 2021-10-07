using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Directivo : Persona, IPastaGansa
    {
        private double pastaGanada;
        private int personas;
        public string Depart { set; get; }
        private double beneficios;
        public double Beneficios
        {
            get
            {
                return beneficios;

            }
        }
        public int Personas
        {
            set
            {
                personas = value;
                if (personas < 10)
                {
                    beneficios = 2;
                }
                else if ( personas <= 50)
                {
                    beneficios = 3.5;
                }
                else
                {
                    beneficios = 4;
                }
            }
            get
            {
                return personas;
            }
        }

        public Directivo(string nombre, string apellidos, int edad, string dni, int personas, string depart, double beneficios) : base(nombre, apellidos, edad, dni)
        {
            this.Personas = personas;
            this.Depart = depart;
        }

        public Directivo() : this("", "", 0, "", 0, "", 0)
        {

        }

        public override void MuestraCampos()
        {
            base.MuestraCampos();
            Console.WriteLine("Departamento: {0}", Depart);
            Console.WriteLine("Beneficios: {0}", beneficios);
            Console.WriteLine("Personas: {0}", Personas);
        }

        public override void IntroCampos()
        {
            base.IntroCampos();
            Console.Write("Departamento: ");
            Depart = Console.ReadLine();
            Console.Write("Nº Personas: ");
            Personas = Convert.ToInt32(Console.ReadLine());
        }

        public double ganarPasta(double pasta) //Pasta es el dinero que gana la empresa
        {
            Directivo directivo;
            directivo = this;

            pastaGanada = (directivo.beneficios * pasta) / 100;

            if (pasta < 0)
            {
                directivo--;
                pastaGanada = 0;
            }

            return pastaGanada;
        }
        public override double Hacienda()
        {
            double resHacienda = 0;

            resHacienda = (30 * pastaGanada) / 100;
            return resHacienda;
        }

        public static Directivo operator --(Directivo beneficiosDirector)
        {
            beneficiosDirector.beneficios--;

            if (beneficiosDirector.beneficios <= 0)
            {
                beneficiosDirector.beneficios = 0;
            }

            return beneficiosDirector;
        }
    }
}