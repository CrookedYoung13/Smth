using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {

            string quest;
            quest = Console.ReadLine();

            for (int i = 0; i < quest.Length; i++)
            {
                Console.WriteLine(quest[i] + " -> " + ((int)quest[i] - 97));
            }

            Console.ReadKey();

        }
    }
}
