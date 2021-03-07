using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 1; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
            }

            Console.WriteLine($"Sum {sum}");
            Console.ReadLine();
        }
    }
}
