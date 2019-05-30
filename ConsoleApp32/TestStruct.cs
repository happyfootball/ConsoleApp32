using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    struct books
    {
        public string title;
        public string author;
        public string subject;
        public int  book_id;
    }
    public class TestStruct
    {
        public static void Main(string[] args)
        {
            books Book1;
            books Book2;

            //设置属性1
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 649540;

            //设置属性2
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

            Console.ReadKey();

        }
    }
}
