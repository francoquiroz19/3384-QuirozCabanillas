using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equivmetrosapulgcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el equivalente de metros en pulgadas*/
            Console.WriteLine("Calcular el equivalente de metros en pulgadas");
            Console.WriteLine("Ingrese la cantidad de metros: ");
            double met = double.Parse(Console.ReadLine());

            double pulgadas = met * 39.3701;

            
            Console.WriteLine(met + " metros <> " + pulgadas + " pulgadas.");

        }
    }
}
