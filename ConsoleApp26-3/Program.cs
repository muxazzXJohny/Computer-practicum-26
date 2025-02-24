using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[10];
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = i;
            }
            foreach (int value in omas)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();

        }
    }
}
