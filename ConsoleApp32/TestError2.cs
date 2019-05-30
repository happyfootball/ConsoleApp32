using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    class TestError2
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showtemp();
            }
            catch (TempIsZeroexception e)
            {
                Console.WriteLine("TempIsZeroException:{0}", e.Message);

            }
            Console.ReadKey();

            

        }
    }
}

    public class TempIsZeroexception : ApplicationException {
        public TempIsZeroexception(string message) : base(message)
        {
        }
    }

    public class Temperature
    {
        int temperature = 0;
        public void showtemp() {
            if (temperature == 0) {
                throw (new TempIsZeroexception("zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature:{0}", temperature);
            }
        }

    }
