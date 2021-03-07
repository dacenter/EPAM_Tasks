using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[10,10,10];

            for(int x =0; x<array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = unchecked(z-y*x+z^y+(x << (y % 2)*8) * (-17 * z + x));
            }

            for (int x = 0; x < array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"x:{x} y:{y} z:{z} : {array[x, y, z]}");
            }


            for (int x = 0; x < array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (array[x, y, z] > 0) array[x, y, z] = 0;
            }

            for (int x = 0; x < array.GetLength(0); x++)
            for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"x:{x} y:{y} z:{z} : {array[x, y, z]}");
            }


            Console.ReadLine();
        }
    }
}
