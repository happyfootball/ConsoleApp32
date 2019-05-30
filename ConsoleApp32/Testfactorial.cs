using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Testfactorial
    {
        public int factorial(int num) {

            int result;
            if (num==1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Testfactorial n = new Testfactorial();
            Console.WriteLine("6的阶乘是{0}",n.factorial(6));
            Console.ReadLine();
        }
    }
}
