using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mayorCancion = 0;
           
            string cancion;
            int canciones;
            
            int duracionCD = 0;
            string nombreMayorDuracion = "";
           
            Console.WriteLine("Ingrese el total de canciones a cargar");
            canciones = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= canciones; i++)
            {
                Console.WriteLine("Ingrese el nombre de la cancion");
                cancion = Console.ReadLine();

                Console.WriteLine("Ingrese el tiempo de la canción en minutos y luego en segundos");
                int min = Convert.ToInt32(Console.ReadLine());
                int seg = Convert.ToInt32(Console.ReadLine());
                
                //deberia calcular todo en segundos
                int segundosTotal = min * 60 + seg;
                duracionCD = duracionCD + segundosTotal;

                if (duracionCD > mayorCancion)
                {
                    nombreMayorDuracion = cancion;
                    mayorCancion = duracionCD;
                }
            }
            TimeSpan duration = TimeSpan.FromSeconds(duracionCD);
            string duracion = duration.ToString(@"mm:ss");
            
            Console.WriteLine("El tiempo total de la lista es de {0}, y la cancion con mayor duracion es {1}", duracion, nombreMayorDuracion);
            Console.ReadKey();
        }
    }
}
