using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longitudDeUnaCircunferenciacs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hallar longitud de una circunferencia");

            Console.WriteLine("Ingresar medida del radio(metros)");
            double radio = double.Parse(Console.ReadLine());

            double lgc = radio * Math.PI * 2;
            Console.WriteLine($"Longitud de la circunferenia: {lgc} metros");
           
        }
    }
}
