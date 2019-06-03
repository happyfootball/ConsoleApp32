using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    /*
     * 在这个示例中，定义一个类mathsOperations，它有两个静态方法，对double类型的值、
     *执行两个操作，然后使用该委托调用这些方法
     *
     */
    class MathsOperations {
        public static double MultiplyByTwo(double value) {
            return value * 2;
        }

        public static double Square(double value){
            return value * value;
        }
    }
    //下面来调用这些方法
    delegate double DoubleOp(double x);
    class TestDelegate4
    {
        static void Main()
        {
            DoubleOp[] operations = {
                new DoubleOp(MathsOperations.MultiplyByTwo),
                new DoubleOp(MathsOperations.Square)
            };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]",i);
                ProcessAndDisplayNumber(operations[i],2.0);
                ProcessAndDisplayNumber(operations[i],7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
            }           
         }

        static void ProcessAndDisplayNumber(DoubleOp action,double value) {
            double result = action(value);
            Console.WriteLine("Value is{0},result of operation is {1}", value, result);
            Console.ReadLine();
        }
     
    }
}
