using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    //重载索引器
    class TestIndexer1
    {
        static public int size = 10;

        private static string[] namelist = new string[size];

        public TestIndexer1() {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N.A";
            }
        }

        public string this[int index] {
            get {
                string temp;
                if (index>=0&&index<=size-1)
                {
                    temp = namelist[index];
                }
                else
                {
                    temp = "";
                }

                return (temp);
            }
            set {
                if (index >= 0 && index < size - 1) {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }

        static void Main(string[] args)
        {
            TestIndexer1 names = new TestIndexer1();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            // 使用带有 int 参数的第一个索引器
            for (int i = 0; i < TestIndexer1.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            // 使用带有 string 参数的第二个索引器
            Console.WriteLine(names["Nuha"]);
            Console.ReadKey();
        }
    }

}
