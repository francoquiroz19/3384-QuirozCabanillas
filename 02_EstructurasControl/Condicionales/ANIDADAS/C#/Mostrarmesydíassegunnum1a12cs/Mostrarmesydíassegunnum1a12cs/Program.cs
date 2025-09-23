using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrarmesydíassegunnum1a12cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número del 1 al 12: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
                Console.WriteLine("Enero, 31 días");
            else
            {
                if (num == 2)
                    Console.WriteLine("Febrero, 28 o 29 días");
                else
                {
                    if (num == 3)
                        Console.WriteLine("Marzo, 31 días");
                    else
                    {
                        if (num == 4)
                            Console.WriteLine("Abril, 30 días");
                        else
                        {
                            if (num == 5)
                                Console.WriteLine("Mayo, 31 días");
                            else
                            {
                                if (num == 6)
                                    Console.WriteLine("Junio, 30 días");
                                else
                                {
                                    if (num == 7)
                                        Console.WriteLine("Julio, 31 días");
                                    else
                                    {
                                        if (num == 8)
                                            Console.WriteLine("Agosto, 31 días");
                                        else
                                        {
                                            if (num == 9)
                                                Console.WriteLine("Septiembre, 30 días");
                                            else
                                            {
                                                if (num == 10)
                                                    Console.WriteLine("Octubre, 31 días");
                                                else
                                                {
                                                    if (num == 11)
                                                        Console.WriteLine("Noviembre, 30 días");
                                                    else
                                                    {
                                                        if (num == 12)
                                                            Console.WriteLine("Diciembre, 31 días");
                                                        else
                                                            Console.WriteLine("Número inválido");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
