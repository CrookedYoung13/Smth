using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());
            int arraySize = input.Length;

            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int[] sum = new int[arraySize];
            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i <= arraySize - 1; i++)
                {
                    sum[(i + r) % arraySize] += numbers[i];
                }
            }

            foreach (int item in sum)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
