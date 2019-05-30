using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestEnum
    {
        enum Day
        { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            Console.ReadKey();
        }
        
    }
}
