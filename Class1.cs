﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTable
{
    public class Class1
    {
        int i=0;
        public void TakeUserValue(int num)
        {
           
            while(i<10)
            {
               
                int r = i * num;
                Console.WriteLine(r);
                i++;
            }

        }
    }
}
