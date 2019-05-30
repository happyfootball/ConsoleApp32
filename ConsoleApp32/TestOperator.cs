using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestOperator
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line1-c的值是{0}",c);
            c = ++a;
            Console.WriteLine("Line2-c的值是{0}",c);
            Console.ReadLine();
        }
    }
}
