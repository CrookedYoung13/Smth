using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("isert n size : ");

            int n;

            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                arr[i] = i;
            }

            Console.WriteLine(" ");

            for (int i = 1; i < n + 1; i++)
            {
                if (i != 2)
                    if (arr[i] % 2 == 0)
                    {
                        arr[i] = 0;
                    }
                if (i > 8)
                {
                    if (arr[i] % 3 == 0)
                    {
                        arr[i] = 0;
                    }
                    if (arr[i] % 5 == 0)
                    {
                        arr[i] = 0;
                    }
                    if (arr[i] % 7 == 0)
                    {
                        arr[i] = 0;
                    }
                }
            }

            Console.WriteLine(" ");

            for (int i = 1; i < n + 1; i++)
            {
                if (arr[i] != 0)
                    Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
