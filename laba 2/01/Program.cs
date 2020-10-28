using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            string a, b;
            a = Console.ReadLine();
            b = Console.ReadLine();

            int length1 = 0, length2 = 0, p = 0, d = 0;



            for (int i = 0, j = 0; i < a.Length && j < b.Length; i++, j++)
            {
                if ((i + 1) < a.Length && (j + 1) < b.Length)
                {
                    if (a[i] == b[j] && a[i + 1] == b[j + 1])
                    {
                        length1 = length1 + 1;
                    }
                }
            }
            for (int i = a.Length, j = b.Length; i < 0 && j < 0; i--, j--)
            {
                if ((i - 1) < 0 && (j - 1) < 0)
                {
                    if (a[i] == b[j] && a[i - 1] == b[j - 1])
                    {
                        length2 = length2 + 1;
                    }
                }
            }

            for (int i = 0; i < length1; i++)
            {
                if (a[i] == ' ')
                {
                    p++;
                }
            }

            for (int i = 0; i < length2; i++)
            {
                if (b[i] == ' ')
                {
                    d++;
                }
            }
            if (length1 != 0 && length2 != 0)
            {

                if (length2 > length1)
                {
                    Console.WriteLine($"word namber: {d + 1}");
                    Console.WriteLine(d + 1);
                }
                else
                {
                    Console.WriteLine($"word namber: {p + 1}");
                    Console.WriteLine(p + 1);
                }
            }
            else { Console.WriteLine($"word namber: 0"); }
            Console.ReadKey();

        }
    }
}
