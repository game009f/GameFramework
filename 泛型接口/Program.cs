using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and instantiate a new generic SortedList class.
            //Person is the type argument.
            SortedList<Person> list = new SortedList<Person>();

            //Create name and age values to initialize Person objects.
            string[] names = new string[] { "Franscoise", "Bill", "Li", "Sandra", "Gunnar", "Alok", "Hiroyuki", "Maria", "Alessandro", "Raul" };
            int[] ages = new int[] { 45, 19, 28, 23, 18, 9, 108, 72, 30, 35 };

            //Populate the list.
            for (int x = 0; x < 10; x++)
            {
                list.AddHead(new Person(names[x], ages[x]));
            }
            //Print out unsorted list.
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            //Sort the list.
            list.BubbleSort();

            //Print out sorted list.
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("Done");
        }
    }
}
