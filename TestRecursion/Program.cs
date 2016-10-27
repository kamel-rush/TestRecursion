using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
        }


        static int Fact(int x)
        {  // if (x == 1)
              //  return 1;
         
            return x * Fact(x - 1);

        }
    }
}
