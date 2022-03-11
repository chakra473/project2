using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class Class1
    {
        public void MyMethod(int num)
        {
            int i=2;
           
            for (i = 2; i > 1; i++)
            {

                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
                
            }   
        }

    }
}
