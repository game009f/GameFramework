using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int is the type argument.
            MyList<int> list = new MyList<int>();
            for (int x = 0; x < 10; x++)
                list.AddHead(x);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done");


            //The .NET Framework 1.1 way of creating a list  容器
            ArrayList list1 = new ArrayList();
            list1.Add(3);
            list1.Add(105);
            //...
            ArrayList list2 = new ArrayList();
            list2.Add("It is raining in Redmond.");
            list2.Add("It is snowing in the mountains.");
            //...

            ArrayList list3 = new ArrayList(); 
            //Okay.  
            list3.Add(3); 
            //Okay, but did you really want to do this?
            list3.Add("It is raining in Redmond.");
 
            int t = 0;
            //This causes an InvalidCastException to be returned.
            foreach(int x in list3)
            {
                t += x;
            }


            //The .NET Framework 2.0 way of creating a list
            List<int> list4 = new List<int>();
            //No boxing, no casting:
            list4.Add(3);
            //Compile-time error:
            //list4.Add("It is raining in Redmond.");    //更快的发现错误

            //与ArrayList相比，在客户代码中唯一增加的List<T>语法是声明和实例化中的类型参数。代码略微复杂的回报是，你创建的表不仅比ArrayList更安全，而且明显地更加快速，尤其当表中的元素是值类型的时候。






            Console.ReadKey();
        }
    }
}
