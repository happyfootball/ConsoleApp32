using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请限定数组的长度，随机生成N个数");
            int n = Convert.ToInt32(Console.ReadLine());
            //限定生成数组内元素的个数，也就是生成多少个数，也就是懒的，一个一个输入数字了
            int[] num = new int[10];
            Random r = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = r.Next(100);
            }
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i]<num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
               }
            }

            Console.WriteLine("该数组从大到小一次为：");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);

            }

            Console.ReadLine();
        }
      
        
    }
}
