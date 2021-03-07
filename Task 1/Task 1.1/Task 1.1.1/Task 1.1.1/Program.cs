using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            Console.Write("Enter a:");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0) Console.Write("Error! Enter new a:");
            Console.Write("Enter b:");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0) Console.Write("Error! Enter new b:");
            Console.Write($"Area of rectangle:{a*b}");
            Console.ReadLine();
        }
    }
}
