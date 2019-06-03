using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/*
 * Abort() 方法用于销毁线程。通过抛出 threadabortexception 
 * 在运行时中止线程。这个异常不能被捕获，如果有 finally 块，
 * 控制会被送至 finally 块。
 */
namespace ConsoleApp32
{
    class TestThread3
    {
        public static void CallToChildThread() {
            try
            {
                Console.WriteLine("Child thread starts");
                //计数到10
                for (int counter = 0; counter < 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thrad Completed");

            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            //停止主线程一段时间
            Thread.Sleep(2000);
            //现在中止子线程
            Console.WriteLine("In Main: Aborting the Child thread");
            childThread.Abort();
            Console.ReadKey();
        }
    }
}
