using System;

namespace Task_1._1._7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new int[25];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = r.Next(-50, 50);
            Console.WriteLine("original array");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine($"Max:{FindMax(array)}");
            Console.WriteLine($"Min:{FindMin(array)}");
            Console.WriteLine("Sorted:");
            foreach (int i in Sort(array)) Console.Write(i + " ");
            Console.ReadLine();
        }


        public static int FindMax(int[] array) => FindMaxR(array, 0, array.Length - 1);

        public static int FindMaxR(int[] array, int leftI, int rightI)
        {
            if (leftI == rightI) return array[leftI];

            int leftMax = FindMaxR(array, leftI, (rightI + leftI) / 2);
            int rightMax = FindMaxR(array, (rightI + leftI) / 2 + 1, rightI);
            if (leftMax > rightMax) return leftMax;
            return rightMax;
        }

        public static int FindMin(int[] array) => FindMinR(array, 0, array.Length - 1);

        public static int FindMinR(int[] array, int leftI, int rightI)
        {
            if (leftI == rightI) return array[leftI];

            int leftMin = FindMinR(array, leftI, (rightI + leftI) / 2);
            int rightMin = FindMinR(array, (rightI + leftI) / 2 + 1, rightI);
            if (leftMin < rightMin) return leftMin;
            return rightMin;
        }



        public static int[] Sort(int[] array)
        {
            return SortR(array, 0, array.Length - 1);
        }

        public static int[] SortR(int[] array, int leftI, int rightI)
        {
            if (leftI == rightI) return new int[]{array[leftI]};


            else
            {
                int[] arr = new int[rightI+1-leftI];
                int[] leftSub = SortR(array, leftI, (rightI + leftI) / 2);
                int[] rightSub = SortR(array, (rightI + leftI) / 2 + 1, rightI);

                int i = 0;

                int l = 0;
                int r = 0;

                while (leftI+i <= rightI)
                {
                    if (r>=rightSub.Length||(l<leftSub.Length&&leftSub[l] < rightSub[r]))
                    {
                        arr[i] = leftSub[l];
                        l++;
                        i++;
                    }
                    else if(r < rightSub.Length)
                    {
                        arr[i] = rightSub[r];
                        r++;
                        i++;
                    }
                }

                return arr;
            }
        }
    }
}