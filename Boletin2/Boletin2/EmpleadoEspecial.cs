using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public EmpleadoEspecial(string nombre, string apellidos, int edad, string dni, double salario, string telefono) : base()
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.DNI = dni;
            this.Salario = salario;
            this.Telefono = telefono;
        }

        public EmpleadoEspecial() : this("", "", 0, "", 0, "")
        {

        }

        public double ganarPasta(double pasta)
        {
            pasta = (0.5 * pasta) / 100;
            return pasta;
        }

        public override void MuestraCampos()
        {
            base.MuestraCampos();
        }

        public override double Hacienda()
        {
            return base.Hacienda() + ((10 * ganarPasta(42356)) / 100);
        }
    }
}