using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N:");
            var n = int.Parse(Console.ReadLine());
            for (int y = 1; y <= n; y++)
            {
                for (int x = y; x > 0; x--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
