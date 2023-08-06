using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Heros hs = new Heros();
            //Hero a = new Hero();

            Hero a = hs.AddComponent<Hero>();
            a.Name = "张三";
            a.Say();
            hs.AddComponent<Hero>().Name = "李四";
            hs.AddComponent<Hero>().Name = "小明";
            hs.AddComponent<Hero>().Name = "老王";

            foreach (IComponent com in hs.list)
            {
                com.Say();
            }

            Console.ReadKey();
        }
    }
}
