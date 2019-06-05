using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    //求两个数的最大公约数或者最小公倍数

    /*
     * 这里采用公式法，也就是辗转相除法，即两
     * 个整数的最大公约数等于其中比较小的数和两数
     * 的相除余数的最大公约数，最小公倍数同理
     */
     
    class Example3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个整数");
            int max = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int temp, r;

            if (max<min)//找出输入的两个数中最大的数，复制给max,小的赋值给min
            {
                temp = max;
                max = min;
                min = temp;
            }
            r = max % min;//令r为两数相除的余数，利用辗转相除法，获得相应的数据
            int a = max, b = min;
            while (r!=0) {   //获得相应的数据，利用公式法即可求出最小公约数和公倍数
                max = min;
                min = r;
                r = max % min;
            }
            Console.WriteLine("{0}和{1}的最小公约数为{2}",a,b,min);
            Console.WriteLine("{0}和{1}的最小公倍数为{2}",a,b,a*b/min);
            Console.ReadLine();

        }
    }
}
