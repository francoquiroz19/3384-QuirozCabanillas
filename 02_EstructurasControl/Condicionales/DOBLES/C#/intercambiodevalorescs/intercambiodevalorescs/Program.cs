using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intercambiodevalorescs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            int b = int.Parse(Console.ReadLine());

         
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            else
            {
          
                a = a + 1;
                b = b + 1;
            }

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
