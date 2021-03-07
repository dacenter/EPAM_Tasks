using System;

namespace Task_1._1._10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new int[25, 25];

            for (int x = 0; x < array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
            {
                int z = x + y;
                array[x, y] = unchecked((x - y * x + z) ^ (y + (x << (y % 3 * 11)) * (-17 * z + x))) % 100;
            }

            for (int x = 0; x < array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
                Console.WriteLine($"X:{x} Y:{y} : {array[x, y]}");


            int sum = 0;
            for (int y = 0; y < array.GetLength(1); y++)
            for (int x = (1-y%2); x < array.GetLength(0); x += 2)
                sum+=array[x, y];

            Console.WriteLine($"Sum:{sum}");
            Console.ReadLine();
        }
    }
}