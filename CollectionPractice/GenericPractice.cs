using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    internal class GenericPractice
    {
        public static void ArrayListPrac()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(10);
            Console.WriteLine("Generic List");
            foreach(int i in arr)
            {
                Console.WriteLine(i+" ");
            }
        }

        public static void DictionaryPrac()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Shreyas");
            dict.Add(2, "ABC");
            dict.Add(3, "XYZ");
            Console.WriteLine("Generic Dictionary: ");
            foreach(var i in dict)
            {
                Console.WriteLine(i.Key+" "+i.Value);
            }
        }

        public static void SortedListPrac()
        {
            SortedList<int,int> sList = new SortedList<int,int>();
            sList.Add(5, 13);
            sList.Add(3, 12);
            sList.Add(4, 12);
            Console.WriteLine("Generic Sorted List");
            foreach (var item in sList)
            {
                Console.WriteLine(item);
            }
        }

        public static void StackPrac()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(int.MaxValue);

            Console.WriteLine("Generic Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void QueuePrac()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(200);
            q.Enqueue(10);
            Console.WriteLine("Generic Queue");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
