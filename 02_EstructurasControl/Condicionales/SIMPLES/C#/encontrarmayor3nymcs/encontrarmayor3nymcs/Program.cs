using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encontrarmayor3nymcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            int c = int.Parse(Console.ReadLine());

            int mayor = a;

            if (b > mayor)
                mayor = b;
            if (c > mayor)
                mayor = c;

            Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
