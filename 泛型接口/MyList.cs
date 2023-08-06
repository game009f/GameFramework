using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口
{
    public class MyList<T>
    {
        protected Node head;
        protected Node current = null;

        // Nested type is also generic on T
        protected class Node
        {
            public Node next;
            //T as private member datatype.
            private T data;
            //T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            //T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        public MyList()
        {
            head = null;
        }
        //T as method parameter type.
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
        // Implement IEnumerator<T> to enable foreach
        // iteration of our list. Note that in C# 2.0
        // you are not required to implment Current and
        // GetNext. The compiler does that for you.
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
