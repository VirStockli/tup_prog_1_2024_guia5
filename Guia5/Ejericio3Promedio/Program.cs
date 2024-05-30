using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio3Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double sumapromedio = 0;
            double promedio;
            for (int cont = 1; cont <= 10; cont++)
            {
                    Console.WriteLine("Ingrese número para calcular promedio");
                    num = Convert.ToDouble(Console.ReadLine());
                    sumapromedio = sumapromedio + num;
            }
                promedio = sumapromedio / 10;
            Console.WriteLine("El promedio de los números ingresados es de {0}", promedio);
            Console.ReadKey();
        }
    }

}
