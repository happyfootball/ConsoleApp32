using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp32
{
    class TestMD5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UserMd5("8"));
            Console.WriteLine(GetMd5Str("8"));
        }

        //16位加密
        public static string GetMd5Str(string ConvertString) {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }


        //32位加密
        static string UserMd5(string str) {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个MD5对象
            //加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            //通过使用循环，将字节类型的数组转化为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++) {
                //将得到的字符使用十六进制类型格式，格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                pwd = pwd + s[i].ToString("X");
            }
            return pwd;
        }
    }
}


