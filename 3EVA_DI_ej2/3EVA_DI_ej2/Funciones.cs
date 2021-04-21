using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2
{
    class Funciones
    {
        Aula aula = new Aula();
        Random random = new Random();
        int rand;

        public bool rellenaTabla()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    rand = random.Next(1, 11);
                    aula.notas[i, j] = rand;
                }
            }
            return true;
        }

        public void CalculaMedia()
        {

        }

        public void MediaAlumno()
        {

        }

        public void MediaAsignatura()
        {

        }

        public void VerNotasAlumno()
        {

        }

        public void VerNotasAsignatura()
        {

        }

        public void NotaMinMax()
        {

        }

        public void TablaAprobados()
        {

        }

        public void TablaCompleta()
        {

        }
    }
}
