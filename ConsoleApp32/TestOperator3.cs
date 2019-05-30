using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestOperator3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(20, "Tom");
            Student s2 = new Student(18, "Jack");
            Student s3 = s1 + s2;

            s3.sayPlus();
            (s1 - s2).sayMinus();
            Console.ReadKey();
        }
    }

    public class Student
    {
        public Student() { }
        public Student(int age, string name)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public void sayPlus() {
            Console.WriteLine("{0}年龄之和为：{1}", this.name, this.age);
        }

        public void sayMinus() {
            Console.WriteLine("{0}年龄之差为：{1}", this.name, this.age);
        }

        public static Student operator +(Student s1, Student s2)
        {
            return new Student(s1.age + s2.age, s1.name + " And " + s2.name);
         }

        public static Student operator -(Student s1, Student s2)
        {
            return new Student(s1.age - s2.age, s1.name + " And " + s2.name);
        }
    }
}
