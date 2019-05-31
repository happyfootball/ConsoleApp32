using System;
using System.Collections.Generic;
using System.Text;
/*委托对象可使用 "+" 运算符进行合并。一个合并委托调用它
 * 所合并的两个委托。只有相同类型的委托可被合并。"-" 运算符
 * 可用于从合并的委托中移除组件委托。使用委托的这个有用的特点，
 * 您可以创建一个委托被调用时要调用的方法的调用列表。这被称为委
 * 托的 多播（multicasting），也叫组播*/


delegate int NumberChanger(int n);
namespace ConsoleApp32
{
    class TestDelegate1
    {
        static int num = 10;
         public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q) {
            num *= q;
            return num;
        }

        public static int getNum() {
            return num;
        }

        static void Main(string[] args)
        {
            //创建委托实例
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;
            // 调用多播
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }

    }
}
