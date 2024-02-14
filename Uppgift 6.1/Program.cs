using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addera(5, 7, 9));
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            int sum = tal1 + tal2 + tal3;
            return sum;
        }
    }
}