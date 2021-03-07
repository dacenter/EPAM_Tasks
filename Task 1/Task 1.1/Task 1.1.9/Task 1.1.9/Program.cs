using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                var x = i + 5;
                var y =i -3;
                var z = i ;
                array[i] = unchecked(x - y * x + z ^ y + (x << (y % 2) * 8) * (-17 * z + x))%100;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            foreach (int i in array)
            {
                if(i<=0) continue;
                sum += i;
            }
            Console.WriteLine($"Sum:{sum}");
            Console.ReadLine();
        }
    }
}
