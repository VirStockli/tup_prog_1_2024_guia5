using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Divisiblespor2y3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("Ingrese primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese primer numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                mayor = num1;
                menor = num2;
            }
            else
            {
                mayor = num2;
                menor = num1;
            }
            for (int cont = menor; cont <= mayor; cont++)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine("El número {0} es divisible por 2", cont);
                }
                if (cont % 3 == 0)
                {
                    Console.WriteLine("El número {0} es divisible por 3", cont);
                }
            }
            Console.ReadKey();
        }
    }
}
