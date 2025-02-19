using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[Input()];
            ArrayFilling(arr);
            ArrayPrinting(arr);

            Console.ReadKey();
        }
        static int Input()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static void ArrayFilling(int[] arr)

        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
;
        }
        static void ArrayPrinting(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }
;
        }


    }
}
