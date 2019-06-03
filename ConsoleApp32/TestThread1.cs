using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp32
{
    class TestThread1
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "Main Thread";
            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}
