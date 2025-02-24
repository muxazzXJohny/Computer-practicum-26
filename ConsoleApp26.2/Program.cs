using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input();
            int[] omas = new int[n];
            Rnd(omas, n);
            Output(omas);
            Console.ReadLine();
        }
        public static int Input()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void Rnd(int[] omas, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                omas[i] = random.Next(-10, 10);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Output(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Elements(int[] omas)
        {
            int f = 0;
            for (int i = 0; i < omas.Length; i++)
                if (omas[i] % 2 == 0)
            {
                f++;
            }
            Console.WriteLine($"Количество чётных елементов:{f}");
        }
    }
}





