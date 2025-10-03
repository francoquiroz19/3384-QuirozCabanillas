using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verpromealumnscs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida las notas de n alumnos y muestre: el promedio grupal, el números de
aprobados y desaprobados, así como el mayor y el menor puntaje obtenido.*/
            Console.Write("Ingrese la cantidad de alumnos: ");
            int n = int.Parse(Console.ReadLine());

            double SumaNotas = 0;
            int aprobados = 0, desaprobados = 0;

            double mayor = -9999;
            double menor = 9999;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Ingrese la nota del alumno {i}: ");
                double nota = double.Parse(Console.ReadLine());

                SumaNotas += nota;

                if (nota >= 11)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
                if (nota > mayor)
                {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }

            double promedio = SumaNotas / n;

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Promedio grupal: " + promedio);
            Console.WriteLine("Número de aprobados: " + aprobados);
            Console.WriteLine("Número de desaprobados: " + desaprobados);
            Console.WriteLine("Nota más alta: " + mayor);
            Console.WriteLine("Nota más baja: " + menor);

            Console.ReadLine();






        }
    }
}
