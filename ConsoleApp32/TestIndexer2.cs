using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestIndexer2
    {
        public int size;

        private string[] nameList;

        public TestIndexer2(int size)
        {

            this.size = size;

            nameList = new string[size];

            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A.";

            }
        }

        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index < size)
                {
                    temp = nameList[index];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }

            set
            {
                if (index >= 0 && index < size)
                {
                    nameList[index] = value;
                }
            }

        }

        static void Main(string[] args)
        {
            TestIndexer2 index = new TestIndexer2(5);
            index[0] = "Zara";
            index[1] = "Riz";
            index[2] = "Nuha";
            index[3] = "Asif";
            index[4] = "Davinder";
            for (int i = 0; i < index.size; i++)
            {
                Console.WriteLine(index[i]);
            }
            Console.ReadKey();
        }
    }
}
