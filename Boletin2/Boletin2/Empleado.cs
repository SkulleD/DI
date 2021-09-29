using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Empleado : Persona
    {
        private double salario;
        private double irpf;
        private string telefono;

        public double Salario
        {
            set
            {
                if  (salario < 600)
                {
                    irpf = (7 * salario) / 100;
                } else if (salario >= 600 && salario <= 3000)
                {
                    irpf = (15 * salario) / 100;
                } else
                {
                    irpf = (20 * salario);
                }
            }
            get
            {
                return salario;
            }
        }

        public double IRPF { set; get; }

        public string Telefono
        {
            set { }
            get
            {
                return "+34 " + telefono;
            }
        }

        public override void MuestraCampos()
        {
            base.MuestraCampos();
            Console.WriteLine("Salario: {0}", salario);
            Console.WriteLine("IRPF: {0}", salario);
            Console.WriteLine("Teléfono: {0}", telefono);
        }

        public override void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            base.IntroCampos(nombre, apellidos, edad, dni);
            Console.Write("Salario: ");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Teléfono: ");
            telefono = Console.ReadLine();
        }

        public Empleado(double salario, string telefono) : base("", "", 0, "")
        {
            this.Salario = salario;
            this.Telefono = telefono;
        }

        public Empleado() : this(0, "") {

        }

        public override double Hacienda()
        {
            return IRPF * Salario / 100;
        }
    }
}
