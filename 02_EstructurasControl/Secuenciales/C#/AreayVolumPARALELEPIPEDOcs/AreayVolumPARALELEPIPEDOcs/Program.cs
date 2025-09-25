using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreayVolumPARALELEPIPEDOcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallar el área y el volumen de un paralelepípedo");
            Console.WriteLine("ingrese medida la arista de la primera cara");
            float l1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese medida la arista de la segunda cara (altura)");
            float l2 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese medida la arista de la tercera cara (base or parte superior)");
            float l3 = float.Parse(Console.ReadLine());

            double Ap= 2*l1*l1 + 2*l2*l2 + 2*l3*l3;
            double Vp = l3 * l3 * l2;

            Console.WriteLine($"PARALELEPIPEDO \nÁrea: {Ap}m^2\nVolumen: {Vp}m^3");


        }
    }
}
