using System;

namespace Factorial
{
    internal class Program
    {
        
        public static void fact(int num)
        {
            long result = 1;
            for (int i=1;i<=num;i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
            static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check factorial number");
            int  num =int.Parse(Console.ReadLine());
            fact(num);
                
        }
    }
}
