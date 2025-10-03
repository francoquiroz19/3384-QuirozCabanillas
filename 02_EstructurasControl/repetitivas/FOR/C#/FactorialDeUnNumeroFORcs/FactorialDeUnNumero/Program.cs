using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDeUnNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El factorial de un número se define como el producto de todos los números
             * consecutivos desde la unidad hasta el número y se denota por el símbolo !
             * Por ejemplo, 4! = 4×3×2×1. Teniendo en cuenta esto, lea un número y encuentre su factorial.*/
            int fac = 1;
            int num;
            Console.WriteLine("Ingrese un numero para calcular su factorial: ");
            num = int.Parse(Console.ReadLine());    
            for (int i=1 ; i<=num; i++) 
            {
                fac= fac * i;   

            }
            Console.WriteLine($"{num}!: {fac}");
            Console.ReadKey();
        }
    }
}
