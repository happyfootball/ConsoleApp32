using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class ExolicitConversion
    {
        static void Main(String[] args) {
            double d = 236.32;
            int i;
            //强制转化
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
