using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedionotascs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;
            double prom;
            Console.WriteLine("Claculando promedio de notas nota>=12 sera aprobado");
            Console.WriteLine("Ingresar pirmera nota");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar segunda nota");
            nota2= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar tercera nota");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar cuarta  nota");
            nota4= int.Parse(Console.ReadLine());

            prom = ((nota1 + nota2 + nota3 + nota4) / 4);
            if (prom >= 12)
            {
                Console.WriteLine($"nota: {prom} APROBADO");
            }
            else
            {
                Console.WriteLine($"nota: {prom} DESAPROBADO"); 
                
            }
            

        }
    }
}
