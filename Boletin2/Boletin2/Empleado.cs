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
        public double Salario
        {
            set
            {
                salario = value;
                if (salario < 600)
                {
                    irpf = 7;
                }
                else if ( salario <= 3000)
                {
                    irpf = 15;
                }
                else
                {
                    irpf = 20;
                }
            }
            get
            {
                return salario;
            }
        }

        private double irpf;
        public double IRPF
        {
            get
            {
                return irpf;
            }
        }

        private string telefono;
        public string Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return "+34 " + telefono;
            }
        }

        public Empleado(double salario, string telefono) : base("Álvaro", "Vila", 23, "21075006")  //usa base
        {
            this.Salario = salario;
            this.Telefono = telefono;
        }

        public Empleado() : this(0, "")
        {

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

        public override void IntroCampos()
        {
            base.IntroCampos();
            Console.Write("Salario: ");
            this.Salario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Teléfono: ");
            this.Telefono = Console.ReadLine();
        }

        public override double Hacienda()
        {
            return IRPF * Salario / 100;
        }
    }
}