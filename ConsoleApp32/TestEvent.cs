﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    using System;

    /*****发布器类*****/
    public class EventTest
    {
        private int value;

        public delegate void NumManipulationHandler();

        public event NumManipulationHandler ChangeNum;
        protected virtual void OnNumChanged() {
            if (ChangeNum != null) {
                ChangeNum();/*事件被触发*/
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey();
            }
        }

        public EventTest() {
            int n = 5;
            SetValue(n);
        }

        public void SetValue(int n) {
            if (value!=n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }


    /*****订阅器类*****/
    public class subscribEvent {
        public void printf() {
            Console.WriteLine("event fire");
            Console.ReadKey();//回车继续
        }
    }


   /*****触发*****/
   public  class TestEvent
    {
        public static void Main(string[] args)
        {
            EventTest e = new EventTest();//实例化对象，第一次没有触发事件
            subscribEvent v = new subscribEvent();//实例化对象
            e.ChangeNum += new EventTest.NumManipulationHandler(v.printf);//注册
            e.SetValue(7);
            e.SetValue(11);

        }

    }
}
