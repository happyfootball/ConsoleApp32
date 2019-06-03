using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestPointer1
    {
        static void Main(string[] args)
        {
            int var = 20;
            int *p = &var;
            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Address is: {0}", (int)p);
            Console.ReadKey();
        }
    }
}
