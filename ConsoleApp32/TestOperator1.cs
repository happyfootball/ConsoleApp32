using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Box
    {
        private double length;      // 长度
        private double breadth;     // 宽度
        private double height;      // 高度

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
        // 重载 + 运算符来把两个 Box 对象相加
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

    }
    class TestOperator1
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            double volume = 0.0;

            box1.setBreadth(6.0);
            box1.setHeight(1.2);
            box1.setLength(3.0);

            box2.setBreadth(6.0);
            box2.setHeight(1.2);
            box2.setLength(3.0);

            volume = box1.getVolume();
            Console.WriteLine("box1的体积：{0}",volume);

            volume = box2.getVolume();
            Console.WriteLine("box2的体积：{0}", volume);

            box3 = box1 + box2;

            //box3的体积
            volume = box3.getVolume();
            Console.WriteLine("box3的体积：{0}",volume);
            Console.ReadKey();




        }
    }
}
