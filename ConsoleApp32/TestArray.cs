using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i, j;

            //初始化
            for ( i = 0; i < 10; i++)
                
            {
                n[i] = i + 10;
            }
            //输出每个数组元素的值
            for (j = 0; j< 10; j++)
            {
                Console.WriteLine("Element[{0}]={1}", j, n[j]);
            }
            Console.ReadLine();
        }
    }
}
