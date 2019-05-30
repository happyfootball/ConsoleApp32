using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class VariableDefinition
    {
        static void Main(string[] args) {
            short a;
            int b;
            double c;

            /*实际初始化*/
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a={0}.b={1}.c={2}",a,b,c);
            Console.ReadLine();
        }
    }
}
