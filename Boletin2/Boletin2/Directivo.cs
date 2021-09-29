using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Directivo : Persona, IPastaGansa
    {
        private string depart;
        private double beneficios;
        private int personas;
        public string Depart { set; get; }
        public double Beneficios { set; get; }
        public int Personas
        {
            set
            {
                if (personas < 10)
                {
                    beneficios = (2 * beneficios) / 100;
                } else if (personas >= 11 && personas <= 50)
                {
                    beneficios = (3.5 * beneficios) / 100;
                } else
                {
                    beneficios = (4 * beneficios) / 100;
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
            Console.WriteLine("Departamento: {0}", depart);
            Console.WriteLine("Beneficios: {0}", beneficios);
            Console.WriteLine("Personas: {0}", personas);
        }

        public override void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            base.IntroCampos(nombre, apellidos, edad, dni);
            Console.Write("Departamento: ");
            depart = Console.ReadLine();
            Console.Write("Beneficios: ");
            beneficios = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nº Personas: ");
            personas = Convert.ToInt32(Console.ReadLine());
        }

        public override double Hacienda()
        {
            double resHacienda = 0;

            resHacienda = (30 * ganarPasta(beneficios)) / 100;
            return resHacienda;
        }

        public double ganarPasta(double pasta) //Pasta es el dinero que gana la empresa
        {
            double moneyDirectivo = 0;

            moneyDirectivo = beneficios - pasta;

            if (pasta < 0)
            {
                moneyDirectivo = 0;
            }
            return moneyDirectivo;
        }
    }
}