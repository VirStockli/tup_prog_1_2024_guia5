using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tope;
            int suma = 0;
            Console.WriteLine("Ingrese hasta qué número quiere sumar");
            tope = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= tope; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma de los números naturales de 0 hasta {1} es igual a {0}", suma, tope);
            Console.ReadKey();
        }
    }
}
