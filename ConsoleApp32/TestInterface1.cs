using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    public interface IWorker
    {
        void work(string s);
    }
    class James1 : IWorker
    {
        public void work(string s)
        {
            Console.WriteLine("我的名字是James1，我的工作是" + s);
        }
    }
    class James2 : IWorker
    {
        public void work(string s)
        {
            Console.WriteLine("我的名字是James2，我的工作是" + s);
        }
    }
    class TestInterface1
    {
        static void Main(string[] args)
        {
            IWorker james1 = new James1();
            IWorker james2 = new James2();
            james1.work("设计");
            james2.work("编程");
            Console.ReadKey();
            //从这个例子我体会到了有接口的好处，可以想象如果又来了新的员工。
            //如果不采用接口，而是每个员工都有一个单独的类，这样就会容易出错。
            //如果有接口这种协议约束的话，那么只要实现了接口就肯定有接口里声明的方法，我们只需拿来调用。
        }
    }
}
