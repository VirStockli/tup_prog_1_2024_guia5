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
            for (int columna = 5; columna < 76; columna++)
            {
                //linea superior
                Console.SetCursorPosition(columna, 2);
                Console.Write("*");
                //linea inferior
                Console.SetCursorPosition(columna, 22);
                Console.Write("*");
            }

            for (int fila = 3; fila < 22; fila++)
            {
                Console.CursorLeft = 5;
                Console.CursorTop = fila;
                Console.Write("*");
                Console.CursorLeft = 75;
                Console.Write("*");
            }
            Console.ReadKey();
        }

    }
}
