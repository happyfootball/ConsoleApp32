using System;
using System.Diagnostics;


namespace ConsoleApp32
{
    class TestAttribute1
    {
        static void Main(string[] args)
        {
            GetAttributeInfo(typeof(OldClass));//typeof运算符不能重载
                                               //typeof(x)中的x必须是具体的类名，类型名称等等
            Console.WriteLine("==============");
            GetAttributeInfo(typeof(NewClass));

            Console.ReadKey();
        }
        public static void GetAttributeInfo(Type t)
        {
            OldAttribute myattribute = (OldAttribute)Attribute.GetCustomAttribute(t, typeof(OldAttribute));
            if (myattribute == null)
            {
                Console.WriteLine(t.ToString() + "类中自定义特性不存在！");
            }
            else
            {
                Console.WriteLine("特性描述:{0}\n加入事件{1}", myattribute.Discretion, myattribute.date);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false)]  //设置了定位参数和命名参数,不被继承，而且可以对类应用特性
    class OldAttribute : Attribute    //继承自Attribute
    {
        private string discretion;
        //内部类
        public string Discretion
        {
            get { return discretion; }
            set { discretion = value; }
        }

        public DateTime date;
        //构造方法
        public OldAttribute(string discretion)
        {
            this.discretion = discretion;
            date = DateTime.Now;
        }
    }

    //现在我们定义两类
    [Old("这个类将过期")]//使用定义的新特性
    class OldClass
    {
        public void OldTest()
        {
            Console.WriteLine("测试特性");
        }
    }

    class NewClass : OldClass
    {
        public void NewTest()
        {
            Console.WriteLine("测试特性的继承");
        }
    }
    //我们写一个方法用来获取特性信息
}

