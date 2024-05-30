using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio2Asteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int baSe;
            int altura;

            Console.WriteLine("Ingrese la base del rectángulo");
            baSe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            if (baSe < altura || baSe > 120 || altura > 29)
            {
                Console.SetCursorPosition(70, 12);
                Console.WriteLine("Rango no válido");
            }
            else
            {
                Console.SetWindowSize(baSe + 1, altura + 1);
                for (int columna = 5; columna < baSe; columna++)
                {
                    //linea superior
                    Console.SetCursorPosition(columna, 2);
                    Console.Write("-");
                    //linea inferior
                    Console.SetCursorPosition(columna, altura);
                    Console.Write("-");
                }
                for (int fila = 3; fila < altura; fila++)
                {
                    Console.CursorLeft = 5;
                    Console.CursorTop = fila;
                    Console.Write("|");
                    Console.CursorLeft = baSe;
                    Console.Write("|");
                }
                
            }
            Console.ReadKey();
        }
    }
}

