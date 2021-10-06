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
        private double beneficios;
        public double Beneficios
        {
            set
            {
                beneficios = value;
            }

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
                    Beneficios = 2;
                }
                else if (personas >= 11 && personas <= 50)
                {
                    Beneficios = 3.5;
                }
                else
                {
                    Beneficios = 4;
                }
            }
            get
            {
                return personas;
            }
        }

        public Directivo(int personas, string depart, double beneficios) : base("Álvaro", "Vila", 23, "21075006")
        {
            this.Personas = personas;
            this.Depart = depart;
            this.Beneficios = beneficios;
        }

        public Directivo() : this(0, "", 0)
        {

        }

        public override void MuestraCampos()
        {
            base.MuestraCampos();
            Console.WriteLine("Departamento: {0}", Depart);
            Console.WriteLine("Beneficios: {0}", Beneficios);
            Console.WriteLine("Personas: {0}", Personas);
        }

        public override void IntroCampos()
        {
            base.IntroCampos();
            Console.Write("Departamento: ");
            Depart = Console.ReadLine();
            Console.Write("Beneficios: ");
            Beneficios = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nº Personas: ");
            Personas = Convert.ToInt32(Console.ReadLine());
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

        public static Directivo operator -(Directivo beneficiosDirector)
        {
            beneficiosDirector.Beneficios--;

            if (beneficiosDirector.Beneficios <= 0)
            {
                beneficiosDirector.Beneficios = 0;
            }

            return beneficiosDirector;
        }
    }
}