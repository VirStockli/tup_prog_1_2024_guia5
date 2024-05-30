using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tornillos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nroLote = 0;
            double medidaEsperada = 0;
            double medidaReal = 0;
            int cantLotes = 0;
            int fallos = 0;
            int loteMenor = 0;
            int loteMayor = 0;
            int contadorFallasTemporal = 0;
            int cantFallasMenor = 0;
            int cantFallasMayor = 0;
            double porcentaje = 0;

            Console.WriteLine("Ingrese el numero de lote");
            nroLote = Convert.ToInt32(Console.ReadLine());
            while (nroLote != 0) 
            {
                contadorFallasTemporal = 0;

            }
        }
    }
}
