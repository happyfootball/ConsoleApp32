using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//该实例演示了sleep方法的使用，用于在一个特定的时间暂停线程
namespace ConsoleApp32
{
    class TestThread2
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Chid Thrad starts");
            //线程暂停5000毫秒
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main:Creating the Child thread");
            Thread childThraed = new Thread(childref);
            childThraed.Start();
            Console.ReadKey();
        }
    }
}

