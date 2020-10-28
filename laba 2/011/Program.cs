using System;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1 };
            int sum1 = 0, sum2 = 0;
            bool fin = false;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sum1 = sum1 + arr[j];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum2 = sum2 + arr[j];
                }

                if (sum1 == sum2)
                {
                    Console.WriteLine("Its : " + i);
                    fin = true;
                }
                sum1 = 0;
                sum2 = 0;


            }
            if (arr.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            if (fin == false)
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();

        }
    }
}
