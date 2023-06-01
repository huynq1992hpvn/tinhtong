using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khai_bao_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 6;
            numbers[3] = 7;
            numbers[4] = 8;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            int total = 0;
            for(int i = 0; i< numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
