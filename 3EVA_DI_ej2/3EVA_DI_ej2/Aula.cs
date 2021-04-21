using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2
{
    class Aula
    {
        public string[] alumnos = new string[12];
        public int[,] notas = new int[12, 4];

        public enum Asignaturas
        {
            Matemáticas = 1,
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