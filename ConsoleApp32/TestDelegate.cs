using System;
using System.Collections.Generic;
using System.Text;

//先声明一个委托Delegate
//委托声明决定了可由该委托引用的方法。委托可指向一个与其具有相同标签的方法。
delegate int NumberChanger(int n);
namespace ConsoleApp32
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p) {
            num += p;
            return num;
        }

        public static int MultNum(int p) {
            num *= p;
            return num;
        }

        public  static int getNum() {
            return num;
        }

        static void Main(string[] args)
        {
            //创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            //委托委托对象调用方法
            nc1(25);
            Console.WriteLine("value of Num:{0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
