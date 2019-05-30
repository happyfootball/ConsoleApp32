using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestContructorFunction
    {
        private double length;
        public TestContructorFunction() {
            Console.WriteLine("对象已经创建");
            }

        public void setLength(double len) {
            length = len;
        }

        public double getlength() {
            return length;
        }

        static void Main(string[] args)
        {
            TestContructorFunction test = new TestContructorFunction();
            //设置线条长度
            test.setLength(6.0);
            Console.WriteLine("线条的长度为：{0}",test.getlength());
            Console.ReadKey();
        }
    }
}
