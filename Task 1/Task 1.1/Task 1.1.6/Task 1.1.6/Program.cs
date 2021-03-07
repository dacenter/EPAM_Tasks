using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._6
{
    class Program
    {
        [Flags]
        enum Format:byte
        {
            None=0,
            Bold=1,
            Italic=2,
            Underline=4
        }
        static void Main(string[] args)
        {
            Format format = Format.None;

            while (true)
            {
                Console.Write("Параметры надписи:");
                string formatStr = "";
                if (format.HasFlag(Format.Bold)) formatStr += "Bold, ";
                if (format.HasFlag(Format.Italic)) formatStr += "Italic, ";
                if (format.HasFlag(Format.Underline)) formatStr += "Underline, ";
                formatStr = (formatStr == "") ? "None" : formatStr;

                Console.WriteLine(formatStr.TrimEnd(' ',','));

                Console.WriteLine("Введите:");
                Console.WriteLine("\t 1:bold");
                Console.WriteLine("\t 1:italic");
                Console.WriteLine("\t 1:underline");

                int i = int.Parse(Console.ReadLine());

                int val = 1 << (i - 1);
                format = (Format)((((byte) format & val) == val) 
                    ? (byte)format&~val 
                    : (byte)format|val);
            }
        }
    }
}
