#define PI
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp32
{
    class TestPreprocessinginstruction1
    {
        static void Main(string[] args)
        {
#if PI
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.ReadKey();
        }
    }
}
