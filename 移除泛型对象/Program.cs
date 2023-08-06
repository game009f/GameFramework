using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移除泛型对象
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { };

            list.Add("abc");
            list.Add("zhangsan");

            list.Remove("zhangsan");

            foreach(string str in list)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
