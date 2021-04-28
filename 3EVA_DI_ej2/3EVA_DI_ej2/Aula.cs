using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2
{
    class Aula
    {
        public string[] alumnos = new string[12];
        public int[,] notas = new int[12, 4];

        //public int this[int indice]
        //{
        //    set
        //    {
        //        alumnos[indice] = Convert.ToInt32(value);
        //    }
        //    get
        //    {
        //        return [indice];
        //    }
        //}

        public enum Asignaturas
        {
            Matemáticas,
            Biología,
            Tecnología,
            Inglés
        }

        public void CrearAlumnos()
        {
            for (int i = 0; i < 12; i++)
            {
                alumnos[i] = "Alumno " + i;
            }
        }
    }
}