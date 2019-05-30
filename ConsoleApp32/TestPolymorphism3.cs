using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{/*当有一个定义在类中的函数需要在继承类中实现时，
  可以使用虚方法。虚方法是使用关键字 virtual 声
  明的。虚方法可以在不同的继承类中有不同的实现。
  对虚方法的调用是在运行时发生的。动态多态性是通
  过 抽象类 和 虚方法 实现的。*/

    public class Shape
    {
        public int X { get; private set; }
        /*private int x; //编译器创建的一个私有的匿名支持字段
          public int X {
          get { return this.x; }
          set { this.x = value; }
         }*/
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // 虚方法
        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画图任务");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个圆形");
            base.Draw();
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
            base.Draw();
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个三角形");
            base.Draw();
        }
    }

    class TestPolymorphism3
    {
        static void Main(string[] args)
        {
            // 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
            var shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

            // 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法 
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("按下任意键退出。");
            Console.ReadKey();
        }
    }
}
