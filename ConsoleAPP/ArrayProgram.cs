using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    public class ArrayProgram
    {

        public void MultiDimensional()
        {
            int[,] array = new int[2, 2];
            array[0, 0] = 0;
            array[0, 1] = 3;
            array[1, 0] = 3;
            array[1, 1] = 3;

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(array[i, j] + "");
                }
            }
        }

        public void ArrayListExample()
        {
            ArrayList arrayList1 = new ArrayList();
            var arrayList2 = new ArrayList()
            {
                23, "smith", 34, true
            };

            arrayList1.Add(10);
            arrayList1.Add(20);
            arrayList1.Insert(0, "first element");
            arrayList2.InsertRange(1, arrayList1);
            arrayList2.RemoveAt(1);
            arrayList2.RemoveRange(2, 3);
            int totalItems = arrayList1.Count;
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList1.Capacity}"));

            Console.WriteLine(arrayList1.Contains(14));
            //arrayList1.Clear();
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList1.Capacity}"));
            ArrayList cloneArrayList = (ArrayList)arrayList1.Clone();
            int[] arrayListCopy = new int[arrayList1.Count];
            //arrayList1.CopyTo(arrayListCopy);
            foreach (int items in arrayListCopy)
            {
                Console.WriteLine("These are copy to items" + items);

            }
            for (int i = 0; i < cloneArrayList.Count; i++)
            {
                Console.WriteLine(cloneArrayList[i]);
            }
            foreach (var item in arrayList2)
            {

                Console.WriteLine(item);
            }

            for (int i = 0; i < arrayList1.Count; i++)
            {

                Console.WriteLine(arrayList1[i]);
            }

        }

        public void HashTableArray()
        {
            Hashtable hashArray1 = new Hashtable()
            {
                {"uK","manchestor, scotland" },
                {"India", "Hyderabad, Delhi" }
            };
            /*hashArray1.Add("Id", 10);
            hashArray1.Add("Name", "Keerthi");*/
            Console.WriteLine("this is hashtable array has key exists" + hashArray1.Contains("Name"));
            foreach (DictionaryEntry item in hashArray1)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }

        public void StackArray2()
        {
            Stack stackArray2 = new Stack();
            stackArray2.Push("Supraja");
            stackArray2.Push((string)null);
            stackArray2.Push(23);
            stackArray2.Push(14.5);
            /*foreach (object item in stackArray2)
           {
               Console.WriteLine(item);
           }*/
            //stackArray2.Count();

            /*foreach (object item in stackArray2)
            {
                Console.WriteLine(item);
            }*/
            Console.WriteLine(stackArray2.Peek());
            Console.WriteLine(stackArray2.GetHashCode);
            Queue queue = new Queue();
            queue.Enqueue("Rajesh");
            queue.Enqueue("Ram");
            queue.Enqueue(122);
            queue.Dequeue();


            //Console.WriteLine(queue);
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            Queue cloneQueue = (Queue)queue.Clone();

            foreach (object item in cloneQueue)
            {

                Console.WriteLine(item);
            }
            object[] queueCopy = new object[5];

            queue.CopyTo(queueCopy, 0);
            Console.WriteLine(queueCopy.Length);
            foreach (object item in queueCopy)
            {

                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "software");
            sortedList.Add(2, "keerthi");
            Console.WriteLine($"Key:1,Value: {sortedList[2]}");
            foreach (DictionaryEntry item in sortedList)
            {

                Console.WriteLine($"Key:{item.Key}, Value: {item.Value}");
            }

        }
    }

}


