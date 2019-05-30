using System;
using System.Collections.Generic;
using System.Text;


/*命名空间的设计目的是提供一种让一组名称
 * 与其他名称分隔开的方式。在一个命名空间中
 * 声明的类的名称与另一个命名空间中声明的
 * 相同的类的名称不冲突。*/
namespace ConsoleApp32
{
    namespace first_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
    }

    namespace second_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside second_space");
            }
        }
    }

    class TestNamespace
    {
        static void Main(string[] args)
        {
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();
            Console.ReadKey();
        }

    }
}


