using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Caninos
{
    static void Main(string[] args)
    { 
        class Perro 
        {
            public string color();
            public string ladrar();
            {
                return "WauWau";
            }
        }
        class Lobo
        {
            public string aullar();
            {
                return "Auuuu";
            }
        }
        class program
        {
        static void Main(string[] args)
        { 
        Perro Manchis = new Perro();
        Perro Lazy = new Perro();
        Perro Fatiga = new Perro();
        Lobo Lupus = new Lobo();

        Manchis.color = "pardo";
        Lazy.color = "negro";
        Fatiga.color = "blanco";

        Console.WriteLine(Fatiga.ladrar());
        Console.WriteLine(Fatiga.ladrar());
        Console.WriteLine(Fatiga.ladrar());

        Console.WriteLine(Lupus.aullar());
        
        }       
    }
}
