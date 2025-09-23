using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arearectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float l1;
            float l2;
            float area;
            float perimetro;

            Console.WriteLine("Calculando Área y Perímetro de un Terreno Rectangular");

            Console.Write("Ingrese primer lado del terreno: ");
            l1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo lado del terreno: ");
            l2 = float.Parse(Console.ReadLine());

            area = l1 * l2;
            perimetro = (2 * l1) + (2 * l2);

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    }
}

