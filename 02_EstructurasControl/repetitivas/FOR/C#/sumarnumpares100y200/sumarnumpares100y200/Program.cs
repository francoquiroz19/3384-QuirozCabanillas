using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace sumarnumpares100y200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma1=0;
            int suma2=0;    
            for (int i = 100; i < 150; i++)
                {
                if (i % 2 == 0)
                    suma1 += i;

            }

            for (int i = 176; i < 200; i++)
            {
                if (i % 2 == 0)
                    suma1 += i;

            }
            int sumaTotal = suma1 + suma2;
            Console.WriteLine("la suma de los #s pares enre 100-200  exceptuando los #s entre 150-176");
            Console.WriteLine("suma: "+ sumaTotal);


        }
    }
}
