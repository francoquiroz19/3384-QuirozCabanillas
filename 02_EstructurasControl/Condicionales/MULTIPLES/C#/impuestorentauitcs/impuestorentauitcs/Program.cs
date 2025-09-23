using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impuestorentauitcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto de su renta: ");
            double renta = double.Parse(Console.ReadLine());

            double UIT = 5250; 
            double limite = 7 * UIT;
            double impuesto;

            if (renta > limite)
            {
                impuesto = renta * 0.05;
                Console.WriteLine("Debe pagar impuesto de: " + impuesto);
            }
            else
            {
                impuesto = 0;
                Console.WriteLine("No paga impuesto.");
            }
        }
    }
    }
}
