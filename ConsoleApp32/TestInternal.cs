using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    /*Internal 访问说明符允许一个类将其成员变量和成员函数暴露给当前程序中的
     * 其他函数和对象。换句话说，带有 internal访问修饰符的任何成员可以被定义
     * 在该成员所定义的应用程序内的任何类或方法访问。*/
    class TestInternal
    {
        //成员变量
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }


        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                TestInternal r = new TestInternal();
                r.length = 4.5;
                r.width = 3.5;
                r.Display();
                Console.ReadLine();
            }
        }
    }
}
