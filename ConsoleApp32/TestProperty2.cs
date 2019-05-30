using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    public abstract class Person {
         public abstract string Name {
            get;
            set;
         }
        public abstract int Age {
            get;
            set;
        }  
    }

    class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        //声明类型为string的Code属性
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // 声明类型为 string 的 Name 属性
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // 声明类型为 int 的 Age 属性
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class TestProperty2
    {
        public static void Main(string[] args)
        {
            //创建一个新的Student对象
            Student s = new Student();
            s.Age = 9;
            s.Code = "001";
            s.Name = "Zara";
            Console.WriteLine("Student Info:{0}", s);
            // 增加年龄
            s.Age += 1;
            Console.WriteLine("Student Info:{0}", s);
            Console.ReadKey();
        }


    }
}

