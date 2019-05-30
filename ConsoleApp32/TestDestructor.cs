using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestDestructor
    {
        private double length;
        public TestDestructor()//构造函数
        {
            Console.WriteLine("对象已将创建");
        }

        ~TestDestructor()//析构函数
        {
            Console.WriteLine("对象已经删除");
        }

        public void setLength(double len) {
            length = len;
        }
        public double getLength() {
            return length;
        }

        static void Main(string[] args)
        {
            TestDestructor test = new TestDestructor();
            //设置线条长度
            test.setLength(6.0);
            Console.WriteLine("线条的长度： {0}",test.getLength());
            Console.ReadKey();//不知道为什么这里没有打印出来
        }
    }
}
