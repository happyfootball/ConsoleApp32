using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
 //定义DEBUG宏，则下面有输出，不定义则没有输出
/*这个预定义特性标记了一个条件方法，其执行依赖于它顶的预处理标识符
 * 它会引起方法调用的条件编译，取决于指定的值，比如Debug或者Trace。
 * 比如，当调试代码时显示变量的值。*/
namespace ConsoleApp32
{

    class TestConditional
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Test
    {
        static void Function1()
        {
           TestConditional.Message("In Function 1.");
        }
        static void Function2()
        {
            TestConditional.Message("In Function2.");
        }
        public static void Main()
        {
            TestConditional.Message("In Main function.");
            Function1();
            Console.ReadKey();
        }
    }

       


}
