using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int MM = 0;
                int SS = 0;
                int mayorCancion = 0;
                string cancion;
                int canciones;
                string nombreMayorDuracion = "";

                Console.WriteLine("Ingrese el total de canciones a cargar");
                canciones = Convert.ToInt32(Console.ReadLine());

          for (int i = 1; i <= canciones; i++)
          {
            Console.WriteLine("Ingrese el nombre de la cancion");
            cancion = Console.ReadLine();

            Console.WriteLine("Ingrese la duración en minutos y segundos");
            int min = Convert.ToInt32(Console.ReadLine());
            int seg = Convert.ToInt32(Console.ReadLine());
                    //deberia calcular todo en segundos
            int duracionCancion = min * 60 + seg;
            MM = MM + min;//total de los minutos
            SS = SS + seg;//total de los segundos
                if (duracionCancion > mayorCancion)
                {
                    nombreMayorDuracion = cancion;
                    mayorCancion = duracionCancion;

                }
          }
          Console.WriteLine("El tiempo total de la lista es de {0}:{1}, y la cancion con mayor duracion es {2}", MM, SS, nombreMayorDuracion);
          Console.ReadKey();
        }
    }
}
