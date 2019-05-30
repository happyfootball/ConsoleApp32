using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            Box1.breadth = 7.0;
            Box1.length = 6.0;
            Box1.height = 5.0;

            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1 的体积： {0}", volume);

            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2 的体积： {0}", volume);
            Console.ReadKey();
         }
    }

    class Box {
        public double length;
        public double breadth;
        public double height;
    }
}
