using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    //定义接口
    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }
    class TestInterface:IMyInterface
    {
        static void Main()
        {
            TestInterface imp = new TestInterface();
            imp.ParentInterfaceMethod();
            imp.MethodToImplement();
        }

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }
    }
}
