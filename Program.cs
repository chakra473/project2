using System;

namespace CountTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 obj=new Class1();
            Console.WriteLine("Enter your Number");
            int num = int.Parse(Console.ReadLine());
            obj.TakeUserValue(num);
        }
    }
}
