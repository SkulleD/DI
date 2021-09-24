using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Empleado : Persona
    {
        public double salario;
        private double irpf;
        public string telefono;

        public double Salario
        {
            set
            {

            }
            get
            {

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
            Console.WriteLine(salario);
            Console.WriteLine(telefono);
        }

        public override void IntroCampos(string nombre, string apellidos, int edad, string dni)
        {
            
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
