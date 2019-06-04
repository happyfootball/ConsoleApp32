using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestGeneric3
    {
        static void Main(string[] args)
        {
            //使用string，int来实例化Test<T,S>类
            Test<String, int> t = new Test<string, int>("SHY520",22);

            //调用泛型类中的方法
            t.SetValue();
            Console.ReadLine();
        }
    }

    public class Test<T,S> {

        private T name;
        private S age;

        public  Test(T Name,S Age){
            this.name = Name;
            this.age = Age;
            }

        public void SetValue() {
            Console.WriteLine(name.ToString());
            Console.WriteLine(age.ToString());
        }
    }
}
