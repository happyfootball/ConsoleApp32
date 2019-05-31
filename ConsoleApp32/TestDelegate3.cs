using System;
using System.Collections.Generic;
using System.Text;
//委托多播实例
namespace ConsoleApp32
{
    //小张类
    public class MrZhang {
        //其实买车票的悲情人物是小张
        public static void BuyTicket() {
            Console.WriteLine("每次都让我去买票！");
        }

        public static void BuyMovieTicket() {
            Console.WriteLine("还让我去带电影票！");
        }
    }

    //小明类
    class TestDelegate3
    {
        //声明一个委托，其实就是一个命令
        public delegate void BugTicketEventhandler();
        public static void Main(string[] args)
        {
            //这里就是具体阐述命令是干什么的，本例就是MrZhang.BuyTicket"小张买车票"
            BugTicketEventhandler myDelegate = new BugTicketEventhandler(MrZhang
                .BuyTicket);
            myDelegate += MrZhang.BuyMovieTicket;
            //这里委托被附上了具体的方法
            myDelegate();
            Console.ReadKey();
        }
    }
}
