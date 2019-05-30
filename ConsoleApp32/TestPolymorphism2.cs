using System;
using System.Collections.Generic;
using System.Text;

/*您不能创建一个抽象类的实例。
 * 您不能在一个抽象类外部声明一个抽象方法。
 * 通过在类定义前面放置关键字 sealed，可以将
 * 类声明为密封类。当一个类被声明为 sealed 时,它
 * 不能被继承。抽象类不能被声明为 sealed。*/
namespace ConsoleApp32
{
    abstract class Shape {
        abstract public int area();
    }

    class Rectangle:Shape{
        private int length;
        private int width;
        public Rectangle(int a=0,int b = 0) {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("rectangle 类的面积：");
            return (width * length);
         
        }
    }

    
    class TestPolymorphism2
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(6,7);
            double a = r.area();
            Console.WriteLine("面积：{0}",a);
            Console.ReadKey();
        }
    }
}
