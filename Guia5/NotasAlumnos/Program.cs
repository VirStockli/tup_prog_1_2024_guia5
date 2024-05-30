using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] es; //numero ingresado
                int cont = 0; //contador
                int a = 0; //acumulador
                double prom = 0; //resultado promedio de notas

                es = new int[6];
                es[cont++] = Convert.ReadLine();

                for (int n = 0; n < cont; n++)
                {
                    a += es[n];
                }
                //Variable Literal: representacion segun el tipo "1f" float o "1d" double
                prom = 1d * a / cont;

                //Metodo Burbuja
                //ordenamiento de las notas
                // notas 9 5 4 3  el n se fija en la primera posición [0] y el m se inicia uno a su derecha [1]
                // comp0 5 9 4 3  el n se compara con el m, se invierten por ser menor, el m se corre una posición a la derecha [2]
                // comp1 4 9 5 3  el n [0] se compara con m [2] e invierten posicion, m se corre uno a la derecha [3]
                // comp2 3 9 5 4  una vez se consigue el menor (ya invirtieron), el n se corre una posición a la derecha [1] y m inicia uno a la derecha de n [2]
                // comp3 3 5 9 4  realiza la misma comparación anterior
                // comp4 3 4 9 5
                // comp5 3 4 5 9

                for (int n = 0; n < (cont - 1); n++)
                {
                    for (int m = n + 1; m < cont; ++m)
                    {
                        if (es[n] > es[m])
                        {
                            int aux = es[mbox];
                            es[m] = es[n];
                            es[n] = aux;
                        }
                    }
                }
            }
        }
    }
}
