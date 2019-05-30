using System;
using System.Collections.Generic;
using System.Text;
/*
派生类继承了基类的成员变量和成员方法。
因此父类对象应在子类对象创建之前被创建
。您可以在成员初始化列表中进行父类的初
始化。*/
namespace ConsoleApp32
{
    class Rectangle
    {
        // 成员变量
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle  
    class Tabletop : Rectangle
    {
        private double cost;
        /*C#中base关键字在继承中起到非常重要的作用。
         * 它与this关键字相比，this关键字代表当前实例。
         * base关键字代表父类，使用base关键字可以调用
         * 父类的构造函数、属性和方法。使用base关键字
         * 调用父类构造函数的语法如下：子类构造函数：
         * base（参数列表）使用base关键字调用父类方法
         * 的语法如下：base.父类方法（）;*/
        public Tabletop(double l, double w) : base(l, w)//是类TableTop的构造函数，意思是继承父类的构造函数，也就是类Rectangle的
        { }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("成本： {0}", GetCost());
        }
    }
    class TestExtends2
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}
