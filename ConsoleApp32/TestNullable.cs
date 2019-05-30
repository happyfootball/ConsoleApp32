using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestNullable
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            //显示值
            Console.WriteLine("显示可空类型的值：{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值：{0}", boolval);
            Console.ReadLine();

        }
    }
}
/*Null 合并运算符用于定义可空类型和引用类型的默认值
 * Null 合并运算符为类型转换定义了一个预设值，以防可
 * 类型的值为 Null。Null 合并运算符把操作数类型隐式转
 * 为另一个可空（或不可空）的值类型的操作数的类型。
 * 果第一个操作数的值为 null，则运算符返回第二个操作数
 * 值，否则返回第一个操作数的值*/

