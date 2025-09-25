using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cobroencocheracs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hallar el costo total a pagar por estacionamiento si el monto por
hora cuesta S/. 2.5*/
            Console.WriteLine("COSTO DE ESTACIONAMIENTO s/.2,5/h");
            Console.WriteLine("Ingrese las oras del uso de estacionamiento: ");
            float h = float.Parse(Console.ReadLine());
            var ce = 0.25 * h;
            Console.WriteLine($"Su costo de estacionamiento es de {ce}");
            Console.ReadLine();
        }
    }
}
