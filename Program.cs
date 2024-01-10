using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 
            bool isMale = true;

            if (isMale)
            {
                Console.WriteLine("you are male");
            }else
            {
                Console.WriteLine("you are female");
            }

            bool isTall = false;

            if (isTall && isMale) {
                Console.WriteLine("you  are tall and male");
            }else if (!isTall && isMale) {
                Console.WriteLine("you are not tall but you are male");
                    }else { Console.WriteLine("you are either not tall or  not male"); }

        }
    }
}
