using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2) {

            /*局部变量声明*/
            int result; 
            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //调用 FindMax 方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}", ret);
            Console.ReadLine();
        }
    }
}
  