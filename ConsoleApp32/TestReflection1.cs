using System;
using System.Collections.Generic;
using System.Text;

[AttributeUsage(AttributeTargets.All)]  //指定Attribute的范围
public class HelpAttribute : System.Attribute
{
    public readonly string Url;
    private string topic;

    public string Topic  //Topic是一个命名的参数
    {
        get
        {
            return topic;
        }
        set
        {
            Topic = value;
        }
    }

    public HelpAttribute(string url)//url是一个定位的参数
    {
        this.Url = url;
    }
}

[HelpAttribute("Infomation on the class MyClass")]
     class MyClass{}


    
 namespace ConsoleApp32 {
        class TestReflection1
        {
            static void Main(string[] args)
            {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();

        }
        }

 }
