using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移除指定委托
{
    delegate void Fun();
    class Program
    {
        static void Main(string[] args)
        {
            Fun f1 = new Fun(Say1);
            Fun f2 = new Fun(Say1);
            Fun f3 =null;

            f3 += f1;

            f3 -= f2;

            f3();
        }

        static void Say1()
        {
            Console.WriteLine("委托方法1");
        }

        static void Say2()
        {
            Console.WriteLine("委托方法2");
        }
    }
}
