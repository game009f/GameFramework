using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口
{
    // A simple class that implements IComparable<T>
    // using itself as the type argument. This is a
    // common design pattern in objects that are
    // stored in generic lists.
    public class Person : IComparable<Person>
    {
        string name;
        int age;
        public Person(string s, int i)
        {
            name = s;
            age = i;
        }
        // This will cause list elements
        // to be sorted on age values.
        public int CompareTo(Person p)
        {
            return age - p.age;
        }
        public override string ToString()
        {
            return name + ":" + age;
        }
        // Must implement Equals.
        public bool Equals(Person p)
        {
            return (this.age == p.age);
        }
    }
}
