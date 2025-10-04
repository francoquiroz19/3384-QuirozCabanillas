using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCMde2NUMEROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Encuentre el mcm de dos números a y b sabiendo que (a)(b) = (mcm)(mcd).*/
            Console.Write("Ingrese el primer número (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número (b): ");
            int b = int.Parse(Console.ReadLine());

            int mcd = 1;

           
            int menor;
            if (a < b)
                menor = a;
            else
                menor = b;

            
            for (int i = 1; i <= menor; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    mcd = i;
                }
            }

           
            int mcm = (a * b) / mcd;

            Console.WriteLine($"El MCD de {a} y {b} es: {mcd}");
            Console.WriteLine($"El MCM de {a} y {b} es: {mcm}");
        }
    }
}
