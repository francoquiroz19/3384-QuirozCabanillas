using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raicesecuacioncs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Raíces reales y distintas: x1 = " + x1 + ", x2 = " + x2);
            }
            else
            {
                if (discriminante == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Raíz real doble: x = " + x);
                }
                else
                {
                    Console.WriteLine("No existen raíces reales.");
                }
            }
        }
    }
}
  
