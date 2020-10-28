using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = Console.ReadLine();
            Console.WriteLine(" ");
            string y = Console.ReadLine();
            Console.WriteLine(" ");

            int size1 = 0, size2 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    size1++;
                }
            }
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] != ' ')
                {
                    size2++;
                }
            }
            char[] x1 = new char[size1];
            char[] y1 = new char[size2];

            for (int i = 0, j = 0; i < size1; i++, j += 2)
            {
                x1[i] = x[j];
            }
            for (int i = 0, j = 0; i < size2; i++, j += 2)
            {
                y1[i] = y[j];
            }

            int min = Math.Min(size1, size2);

            for (int i = 0; i < min; i++)
            {
                if (x1[i] > y1[i])
                {
                    for (int j = 0; j < size2; j++)
                    {
                        Console.Write(y1[j]);
                    }
                    Console.WriteLine(" ");
                    for (int j = 0; j < size1; j++)
                    {
                        Console.Write(x1[j]);
                    }
                    break;
                }
                else
                {
                    if (x1[i] < y1[i])
                    {
                        for (int j = 0; j < size1; j++)
                        {
                            Console.Write(x1[j]);
                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < size2; j++)
                        {
                            Console.Write(y1[j]);
                        }
                        break;
                    }
                    if (x1[i] == y1[i])
                    {
                        if (i == min - 1)
                        {
                            if (size1 > size2)
                            {
                                for (int j = 0; j < size2; j++)
                                {
                                    Console.Write(y1[j]);
                                }
                                Console.WriteLine(" ");
                                for (int j = 0; j < size1; j++)
                                {
                                    Console.Write(x1[j]);
                                }
                                break;
                            }
                            else
                            {
                                for (int j = 0; j < size1; j++)
                                {
                                    Console.Write(x1[j]);
                                }
                                Console.WriteLine(" ");
                                for (int j = 0; j < size2; j++)
                                {
                                    Console.Write(y1[j]);
                                }
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }







            Console.WriteLine(" ");

            Console.ReadKey();

        }
    }
}
