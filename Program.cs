using System;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"these numbers are divisible by {num}");
            div(num);
        }
        public static void div(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
