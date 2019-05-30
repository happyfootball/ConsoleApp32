using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    public class TestData
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class TestPolymorphism1
    {
        static void Main(string[] args)
        {
            TestData dataclass = new TestData();
            int add1 = dataclass.Add(1,2);
            int add2 = dataclass.Add(1,2,3);

            Console.WriteLine("add1:"+add1);
            Console.WriteLine("add2:"+ add2);
            Console.ReadKey();

        }
    }
}
