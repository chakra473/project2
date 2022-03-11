using System;

namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("Please ente your number");
            int num = int.Parse(Console.ReadLine());
            obj.MyMethod(num);
        }
    }
}
