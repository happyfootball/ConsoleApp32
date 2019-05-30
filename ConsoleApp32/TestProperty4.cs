using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestProperty4
    {
        static void Main(string[] args)
        {
            WordtoBit w = new WordtoBit();
            w.X[5] = true;
            foreach (bool b in w.X)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }

    }
    
    //属性如果是一个数组的话，set 中的其它代码不会执行。
    class WordtoBit
    {
        private bool[] x = new bool[16];
        public bool[] X
        {
            get { return x; }
            set
            {
                x = value;
                Console.WriteLine("这句不能执行！");
            }
        }
    }
}
