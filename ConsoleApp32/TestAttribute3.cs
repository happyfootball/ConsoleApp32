using AttributeTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestAttribute3
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo memberInfo = typeof(Student);
            System.Reflection.PropertyInfo propertyInfo = typeof(Student).GetProperty("Name");
            HobbyAttribute hobbyStudent = (HobbyAttribute)Attribute.GetCustomAttribute(memberInfo, typeof(HobbyAttribute));
            HobbyAttribute hobbyName = (HobbyAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(HobbyAttribute));
            if (hobbyStudent != null)
            {
                Console.WriteLine("类Student的特性");
                Console.WriteLine("类名：{0}", memberInfo.Name);
                Console.WriteLine("兴趣类型：{0}", hobbyStudent.Type);
                Console.WriteLine("兴趣指数：{0}\n", hobbyStudent.Level);
            }
            if (hobbyName != null)
            {
                Console.WriteLine("属性Name的特性");
                Console.WriteLine("属性名：{0}", propertyInfo.Name);
                Console.WriteLine("兴趣类型：{0}", hobbyName.Type);
                Console.WriteLine("兴趣指数：{0}", hobbyName.Level);
            }
            Console.ReadKey();
        }
    }


    [Hobby("Sport", Level = 5)]
    class Student
    {
        [Hobby("Tennis", Level = 3)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


namespace AttributeTest
{
        class HobbyAttribute : Attribute
        {
            //值为null的string是危险的，所以必需在构造函数中赋值
            public HobbyAttribute(string type)
            {
                this.Type = type;
            }

            public string Type { get; set; }
            public int Level { get; set; }
        }
 }






