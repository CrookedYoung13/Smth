using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("isert A size A = 4 * a : ");

            int a;
            a = 4 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int[] arr = new int[a];

            int[] x = new int[a / 2];
            int[] y = new int[a / 2];
            int[] sum = new int[a / 2];

            for (int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = a / 4, j = 0; i <= ((arr.Length - 1) - (a / 4)); i++, j++)
            {
                x[j] = arr[i];
            }

            for (int i = (a / 4) - 1, j = 0; i >= 0; i--, j++)
            {
                y[j] = arr[i];
            }
            for (int i = arr.Length - 1, j = a / 4; i > (arr.Length - 1) - (a / 4); i--, j++)
            {
                y[j] = arr[i];
            }

            Console.WriteLine(" ");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = x[i] + y[i];
                Console.Write(sum[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
