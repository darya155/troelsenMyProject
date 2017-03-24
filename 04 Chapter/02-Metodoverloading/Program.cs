using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Metod Overloading *****\n");
            //вызов int-версии Add()
            Console.WriteLine(Add(10, 10));
            //вызов long-версии Add()
            Console.WriteLine(Add(900000000, 900000000));
            //вызов double-версии Add()
            Console.WriteLine(Add(4.3, 4.4));
        }
        //перегруженный метод Add()
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
