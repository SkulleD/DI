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
        int porcentaje;
        int acu = 0;

        public int RellenaTabla()
        {
            acu = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    porcentaje = random.Next(1, 101);

                    if (porcentaje <= 15) // De 0% a 15%. 5% cada nota
                    {
                        rand = random.Next(0, 3); // 0, 1, 2
                        aula.notas[i, j] = rand;
                    }

                    if (porcentaje > 15 && porcentaje <= 25) // De 16% a 25% 
                    {
                        rand = 3; // 3
                        aula.notas[i, j] = rand;
                    }

                    if (porcentaje > 25 && porcentaje <= 70) // De 26% a 70%. 15% cada nota
                    {
                        rand = random.Next(4, 7); // 4, 5, 6
                        aula.notas[i, j] = rand;
                    }

                    if (porcentaje > 70 && porcentaje <= 90) // De 71% a 90%. 10% cada nota
                    {
                        rand = random.Next(7, 9); // 7, 9
                        aula.notas[i, j] = rand;
                    }

                    if (porcentaje > 90 && porcentaje <= 100) // De 91% a 100%. 5% cada nota
                    {
                        rand = random.Next(9, 11); // 9, 10
                        aula.notas[i, j] = rand;
                    }
                    acu = acu + rand;
                }
            }
            return acu;
        }

        public void CalculaMedia()
        {
            RellenaTabla();
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
