using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{

    class Shape {
        public void setwidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        protected int height;
        protected int width;
    }

    //派生类
    class Rectangle:Shape{
        public int getArea() {
            return (width * height);
        }
    }

    class TestExtends1
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setHeight(7);
            Rect.setwidth(5);

            //打印对象的面积
            Console.WriteLine("总面积;{0}", Rect.getArea());
            Console.ReadKey();
        }
    }


}
