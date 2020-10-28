using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            int s = 0, bS = -1;
            int l = 1, bL = -1;

            Console.Write("Input length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[s]) { l++; }
                else
                {
                    s = i;
                    l = 1;
                }
                if (bL < l)
                {
                    bL = l;
                    bS = s;
                }
            }
            Console.Write($"s={bS} l={bL}\n");
            for (int i = bS; i < bL + bS; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
        }
    }
}
