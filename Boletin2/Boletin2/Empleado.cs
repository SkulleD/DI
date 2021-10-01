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
        private string telefono;

        public double Salario
        {
            set
            {
                if  (salario < 600)
                {
                    IRPF = (7 * salario) / 100;
                } else if (salario >= 600 && salario <= 3000)
                {
                    IRPF = (15 * salario) / 100;
                } else
                {
                    IRPF = (20 * salario);
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
            Console.WriteLine("Salario: {0}", Salario);
            Console.WriteLine("IRPF: {0}", IRPF);
            Console.WriteLine("Teléfono: {0}", Telefono);
        }

        public void MuestraCampos(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Nombre: {0}", Nombre);
                    break;
                case 2:
                    Console.WriteLine("Apellidos: {0}", Apellidos);
                    break;
                case 3:
                    Console.WriteLine("Edad: {0}", Edad);
                    break;
                case 4:
                    Console.WriteLine("DNI: {0}", DNI);
                    break;
                case 5:
                    Console.WriteLine("Salario: {0}", Salario);
                    break;
                case 6:
                    Console.WriteLine("IRPF: {0}", IRPF);
                    break;
                case 7:
                    Console.WriteLine("Teléfono: {0}", Telefono);
                    break;
                default:
                    break;
            }
        }

        public override void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            base.IntroCampos(nombre, apellidos, edad, dni);
            Console.Write("Salario: ");
            this.salario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Teléfono: ");
            this.telefono = Console.ReadLine();
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
