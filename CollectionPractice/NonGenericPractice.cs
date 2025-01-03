using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    internal class NonGenericPractice
    {
        public static void ArrayListPrac()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("H1");
            DateTime dt = DateTime.Now;
            arr.Add(dt);
            Console.WriteLine("Items in Non-Generic ArrayList: ");
            foreach (var item in arr) {
                Console.WriteLine(item+" ");
            }
        }

        public static void HashTablePrac()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, 12);
            hash.Add(3, null);
            hash.Add("One", "String");
            Console.WriteLine("Non-Generic Hash Table");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortedListPrac()
        {
            SortedList sList = new SortedList();
            sList.Add(5, 13);
            sList.Add(3, 12);
            sList.Add(4, 12);
            Console.WriteLine("Non-Generic Sorted List");
            foreach (var item in sList) {
                Console.WriteLine(item);
            }
        }

        public static void StackPrac()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Abc");
            DateTime dt = DateTime.Now;
            stack.Push(dt);

            Console.WriteLine("Non-Generic Stack:");
            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            }
        }

        public static void QueuePrac()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("ABC");
            q.Enqueue(null);
            DateTime dt = DateTime.Now;
            q.Enqueue(dt);

            Console.WriteLine("Non-Generic Queue");
            foreach (var item in q) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
