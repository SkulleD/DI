using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Directivo : Persona, IPastaGansa
    {
        private int personas;
        public string Depart { set; get; }
        public double Beneficios { set; get; }
        public int Personas
        {
            set
            {
                if (personas < 10)
                {
                    Beneficios = (2 * Beneficios) / 100;
                } else if (personas >= 11 && personas <= 50)
                {
                    Beneficios = (3.5 * Beneficios) / 100;
                } else
                {
                    Beneficios = (4 * Beneficios) / 100;
                }
            }
            get
            {
                return personas;
            }
        }

        public override void MuestraCampos()
        {
            base.MuestraCampos();
            Console.WriteLine("Departamento: {0}", Depart);
            Console.WriteLine("Beneficios: {0}", Beneficios);
            Console.WriteLine("Personas: {0}", personas);
        }

        public override void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            base.IntroCampos(nombre, apellidos, edad, dni);
            Console.Write("Departamento: ");
            Depart = Console.ReadLine();
            Console.Write("Beneficios: ");
            Beneficios = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nº Personas: ");
            personas = Convert.ToInt32(Console.ReadLine());
        }

        public override double Hacienda()
        {
            double resHacienda = 0;

            resHacienda = (30 * ganarPasta(Beneficios)) / 100;
            return resHacienda;
        }

        public double ganarPasta(double pasta) //Pasta es el dinero que gana la empresa
        {
            Directivo directivo = new Directivo();
            directivo = this;

            directivo.Beneficios = Beneficios - pasta;

            if (pasta < 0)
            {
                directivo.Beneficios = 0;
            }
            return directivo.Beneficios;
        }

        public static Directivo operator -(Directivo beneficios)
        {
            beneficios.Beneficios--;

            if (beneficios.Beneficios <= 0)
            {
                beneficios.Beneficios = 0;
            }

            return beneficios;
        }
    }
}