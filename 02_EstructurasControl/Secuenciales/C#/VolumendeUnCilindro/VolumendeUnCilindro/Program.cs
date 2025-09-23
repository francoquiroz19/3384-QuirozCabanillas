using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumendeUnCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float h;
            float r;
            double pi= 3.1415929;
            double abc;
            double v;
            Console.WriteLine("Hallar volumen de un Cilindro");
            Console.WriteLine("Ingre halura del cilindro");
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar radio del cilindro");
            r = float.Parse(Console.ReadLine());

            abc = pi * r * r;
            v = abc * h;

            Console.WriteLine($"el cilindro de : \nradio: {r}\nhaltura: {h}\narea de su base: {abc}\nvolumen: {v}");




        }
    }
}
