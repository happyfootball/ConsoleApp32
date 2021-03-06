﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/*
 * 本实例提供一个简单的用于热水锅炉系统故障
 * 排除的应用程序。当维修工程师检查锅炉时，
 * 锅炉的温度和压力会随着维修工程师的备注自
 * 动记录到日志文件中。
 */  

namespace ConsoleApp32
{
    //定义锅炉类
    class Boiler {
        private int temp;
        private int pressure;
        public  Boiler(int t, int p) {
            temp = t;
            pressure = t;
        }

        public int getTemp() {
            return temp;
        }

        public int getPressure() {

            return pressure;
        }
    }

    //事件发布类
    class DelegateBoilerEvent {
        public delegate void BoilerLogHander(string status);
        //基于上面的委托定义事件
        public event BoilerLogHander BoilerEventLog;

        public void LogProcess() {
            string remarks = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }

        protected void OnBoilerEventLog(String message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }     
    }


    // 该类保留写入日志文件的条款
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;
        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        public void Logger(string info)
        {
            sw.WriteLine(info);
        }
        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }

    // 事件订阅器
    public class TestEvent2
    {
        static void Logger(String info) {
            Console.WriteLine(info);
        }//end of Logger

        static void Main(string[] args)
        {
            BoilerInfoLogger filelog = new BoilerInfoLogger("C:\\Users\\Sino\\Desktop\\test.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new
            DelegateBoilerEvent.BoilerLogHander(Logger);
            boilerEvent.BoilerEventLog += new
            DelegateBoilerEvent.BoilerLogHander(filelog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            filelog.Close();

        }//end of main
    }//end of RecordBoilerInfo
}
