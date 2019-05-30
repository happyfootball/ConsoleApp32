using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Shape {
        public void setWidth(int w) {
            width = w;
        }
        public void setHeight(int h) {
           height = h;
        }
        protected int width;
        protected int height;
    }

    //C# 不支持多重继承。但是，您可以使用接口来实现多重继承。
    public interface paintcost
    {
        int getCost(int area);
    }

    class Rectangle : Shape,paintcost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }
       
    class TestExtends3
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.WriteLine("油漆总成本： ${0}", Rect.getCost(area));
            Console.ReadKey();
        }

    }
}
