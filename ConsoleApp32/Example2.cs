using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    //判断一个数为2的几次方
    class Example2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的数字");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = 1,i = 0;
            while (n<num)
            {
                i++;
                n  *= 2;
                if (n==num)
                {
                    Console.WriteLine("该数字为2的{0}次方",i);
                }
                if (n>num)
                {
                    Console.WriteLine("该数字不为2的次方幂");
                }
            }
            Console.ReadLine();


        }
    }
}
