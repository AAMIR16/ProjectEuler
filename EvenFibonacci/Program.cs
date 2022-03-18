using System;
using System.Collections.Generic;

namespace EvenFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 100;
            int regcount = 0;long evencount = 0;
            List<long> x = new List<long>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    x.Add(1);
                else if (i == 1)
                    x.Add(1);
                else
                    x.Add(x[i-1]+x[i-2]);
            }

            foreach(var a in x)
            {
                if (a % 2 == 0)
                    evencount += a;
            }
            
            Console.WriteLine(evencount);

            foreach(var b in x)            
                Console.WriteLine(b);            
        }
    }
}
