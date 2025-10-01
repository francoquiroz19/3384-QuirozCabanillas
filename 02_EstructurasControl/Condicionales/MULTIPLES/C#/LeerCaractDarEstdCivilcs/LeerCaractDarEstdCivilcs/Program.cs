using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerCaractDarEstdCivilcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ec;
            Console.WriteLine("Ingrese el estado civil (s, c, d, v): ");
            ec = char.Parse(Console.ReadLine());

            switch (ec)
            { 
            case 'S':
                Console.WriteLine("Soltero");
                break;

            case 'C':
                Console.WriteLine("Casado");
                break;
            case 'D':
                Console.WriteLine("Divorciado");
                break;
            case 'V':
                Console.WriteLine("Viudo");
                break;
            default:
                Console.WriteLine("Estado civil no valido");
                break;
            }
            Console.ReadKey();
        }
    }
}
