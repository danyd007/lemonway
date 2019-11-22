using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWebService.MyWebService myWS = null;
            double res = 0;

            try
            {
                myWS = new MyWebService.MyWebService();
                res = myWS.Fibonacci(10);
                Console.WriteLine(res);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.Read();
        }
    }
}
