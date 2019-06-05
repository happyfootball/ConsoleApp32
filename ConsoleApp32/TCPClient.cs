using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApp32
{
    class TCPClient
    {
        static void Main(string[] args)
        {
            //Parse将字符串装换为IP地址类型
            IPAddress myIP = IPAddress.Parse("127.0.0.1");
            //构造一个TcpClient类对象，TCP客户端
            TcpClient client=new TcpClient();
            //与TCP服务器连接
            client.Connect(myIP ,6688);
            Console.WriteLine("服务器已经连接...请输入对话内容...");


            // 创建网络流,获取数据流
             NetworkStream stream = client.GetStream();
            //读数据流对象
             StreamReader sr = new StreamReader(stream);
            //写数据流对象
             StreamWriter sw = new StreamWriter(stream);

            while (true)
            {
                string msg = Console.ReadLine();
                sw.WriteLine(msg);
                sw.Flush();
                Console.WriteLine("服务器："+sr.ReadLine());
            }
            client.Close();
            Console.Read();
           

        }
    }
}
