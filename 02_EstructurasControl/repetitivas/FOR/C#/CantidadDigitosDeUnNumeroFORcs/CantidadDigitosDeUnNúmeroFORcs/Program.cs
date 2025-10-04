using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CantidadDigitosDeUnNúmeroFORcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, digitos=0;
            Console.WriteLine("determinar # digitos de un número");
            Console.WriteLine("Ingrese un número entero porfavor");
            numero = int.Parse(Console.ReadLine());

            if (numero<0)
            {
                numero = -numero;
            }

            if (numero == 0)
            {
                digitos = 1;
            }
            else
            {
                for (; numero > 0; numero = numero / 10)
                {
                    digitos++;
                }
            }

            Console.WriteLine("El número tiene " + digitos + " dígitos");
        }
    }
}
s