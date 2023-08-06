using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型练习
{
    /// <summary>
    /// 下面的示例代码演示了客户代码如何使用泛型类MyList<T>，来创建一个整数表。
    /// 通过简单地改变参数的类型，很容易改写下面的代码，以创建字符串或其他自定义类型的表。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> //type parameter T in angle brackets
    {
        private Node head;
        // The nested type is also generic on T.
        private class Node
        {
            private Node next;
            //T as private member data type:
            private T data;
            //T used in non-generic constructor:
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
            //T as return type of property:
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

        //T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

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
