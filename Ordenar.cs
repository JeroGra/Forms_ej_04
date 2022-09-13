using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEjercicio04
{
    class Ordenar
    {
        public static bool OrdenarAscendente;
        public static int[] arrayNums = new int[100];
        public static void Ordenamiento(int tam)
        {
            int aux = 0;

            if (Ordenar.OrdenarAscendente == true)
            {
                for (int i = 0; i < tam - 1; i++)
                {
                    for (int j = i + 1; j < tam; j++)
                    {
                        if (Ordenar.arrayNums[i] > Ordenar.arrayNums[j])
                        {
                            aux = Ordenar.arrayNums[i];
                            Ordenar.arrayNums[i] = Ordenar.arrayNums[j];
                            Ordenar.arrayNums[j] = aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < tam - 1; i++)
                {
                    for (int j = i + 1; j < tam; j++)
                    {
                        if (Ordenar.arrayNums[i] < Ordenar.arrayNums[j])
                        {
                            aux = Ordenar.arrayNums[i];
                            Ordenar.arrayNums[i] = Ordenar.arrayNums[j];
                            Ordenar.arrayNums[j] = aux;
                        }
                    }
                }
            }

        }

    }
}
