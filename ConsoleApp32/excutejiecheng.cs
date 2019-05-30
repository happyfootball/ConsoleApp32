using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class excutejiecheng
    {
        static void Main(string[] args)
        {
            jiecheng n = new jiecheng();
            int result = n.Jc(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("result is {0}", result);
            Console.ReadKey();
        }
    }

    class jiecheng {
        public int Jc(int num)
        {
            return num > 0 ? num * Jc(num - 1) : 1;
         
            }
    }
}
