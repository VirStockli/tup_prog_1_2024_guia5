using Gallinero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallinero
{
    class Gallina
    {
        private int raciones;
        public bool estaviva;
        public string dueño;
        public bool tienehambre;
        static Random azar = new Random();
        public void Alimentar(ref int alimento)
        {
            if (tiene_hambre)
            {
                if (alimento >= 2)
                {
                    tienehambre = false;
                    alimento = 2;
                    raciones = 2;
                }
                else
                {
                    raciones = 1;
                    alimento = 1;
                }
            }
        }
        public int Aovar()
        {
            int huevos = 0;
            if (raciones == 2)
            {
                huevos = azar.Next(2);
            }
            else
            {
                if (raciones == 1)
                {
                    huevos = azar.Next(1);
                }
            }
        }
        public void VerEstado()
        { string estado = "Gallina: ";
            estado += "Viva: ";
            if (estaviva)
            {
                estado += "Sí";
            }
            else
            {
                estado += "No";
            }
        }
    class Zorro
    {
        public bool tienehambre = true;
        public static void Alimentar(Gallina g)
        { 
          if (tienehambre && g.estaviva)
          { 
            g.estaviva = false;
            tienehambre = false;
          }

    class Program
    static void Main(string[] args[])
    {
        int alimento = 10;
        int canasta = 0;
       
        Gallina g1 =new Gallina();
        g1.estaviva = true;
        g1.tiene_hambre = true;
        g1.dueño = "Ana";
        
        Gallina g2 =new Gallina();
        g2.estaviva = true;
        g2.tiene_hambre=true;
        g2.dueño = "Ana";

        g1.Alimentar(ref alimento);
        g2.Alimentar(ref alimento);
        canasta+=g1.Aovar();
        canasta+=g2.Aovar();

        Zorro z1 = new Zorro();
        z1.tienehambre=true;
        z1.comer(g1);
    }



