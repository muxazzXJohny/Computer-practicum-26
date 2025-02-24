using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 10, 7, 15, 21, 5, 8, 13 };
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < omas.Length; i++)
            {
                if (omas[i] > a)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();

            }
        }
    }
}

