using System;
using System.Collections.Generic;
using System.Text;

/*匿名方法是通过使用 delegate 关键字创建委托实例来声明的
 * 代码块 Console.WriteLine("Anonymous Method: {0}", x); 
 * 是匿名方法的主体。委托可以通过匿名方法调用，也可以通过
 * 命名方法调用，即，通过向委托对象传递方法参数。
 */
delegate void NumberChanger(int n);

namespace ConsoleApp32
{
    class TestAnonymousMethods
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }

        static void Main(string[] args)
        {
            // 使用匿名方法创建委托实例
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            // 使用匿名方法调用委托
            nc(10);

            // 使用命名方法实例化委托
            nc = new NumberChanger(AddNum);

            // 使用命名方法调用委托
            nc(5);

            // 使用另一个命名方法实例化委托
            nc = new NumberChanger(MultNum);

            // 使用命名方法调用委托
            nc(2);
            Console.ReadKey();
        }
    }
}

