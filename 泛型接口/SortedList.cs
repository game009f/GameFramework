using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型接口
{
    public class SortedList<T> : MyList<T> where T : IComparable<T>
    {
        // A simple, unoptimized sort algorithm that
        // orders list elements from lowest to highest:

        public void BubbleSort()
        {

            if (null == head || null == head.Next)
                return;
            bool swapped;

            do
            {
                Node previous = null;
                Node current = head;
                swapped = false;

                while (current.next != null)
                {
                    //  Because we need to call this method, the SortedList
                    //  class is constrained on IEnumerable<T>
                    if (current.Data.CompareTo(current.next.Data) > 0)
                    {
                        Node tmp = current.next;
                        current.next = current.next.next;
                        tmp.next = current;

                        if (previous == null)
                        {
                            head = tmp;
                        }
                        else
                        {
                            previous.next = tmp;
                        }
                        previous = tmp;
                        swapped = true;
                    }

                    else
                    {
                        previous = current;
                        current = current.next;
                    }

                }// end while
            } while (swapped);
        }

    }
}
