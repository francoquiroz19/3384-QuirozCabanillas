using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTrapecioBasesYhalturaConocidascs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallando area de un trapecio de:\nBase mayor: 18 \nBase menor: 10\n" +
                "Haltura: 8");
            var (bma, bme, h) = (18, 10, 8);
            double at = ((bma + bme) / 2) * h;
            Console.WriteLine($"Area del trapecio: {at}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("formula usada: ((base mayor + base menor)/2)*haltura");
            Console.ReadLine();


        }
    }
}
