using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class CollectionExamples
    {
        public CollectionExamples()
        {
            Console.WriteLine("I am constructor");
        }

        public CollectionExamples(string value)
        {
            Console.WriteLine("This is another constuctor");
        }
        public void ArrayListOperations()
        {
            // ArrayList 

            // Define
            ArrayList objArr = new ArrayList();


            // Add values to the Arraylist.
            objArr.Add(1);
            objArr.Add("Test");
            objArr.Add(false);
            objArr.Add(DateTime.Now);

            // Read the value from the Arraylist

            int value1 = Convert.ToInt32(objArr[0]);
            string value2 = Convert.ToString(objArr[1]);
            bool value3 = Convert.ToBoolean(objArr[2]);
            DateTime value4 = Convert.ToDateTime(objArr[3]);

            bool result1 = objArr.Contains("Test");


            // Insert in between. 

            objArr.Insert(2, "New Value");

            // Delete from ArrayList using value

            objArr.Remove("Test");

            // Delete from ArrayList using index

            objArr.RemoveAt(2);

            // Delete Everything 

            objArr.Clear();

            bool result = objArr.Contains("Test");

        }

        public void HashTableOperation()
        {
            // Indexing.. 

            Hashtable objHashTable = new Hashtable();

            // Add Value

            objHashTable.Add(1, "test");
            objHashTable.Add("abc", false);
            objHashTable.Add(3, DateTime.Now);
            objHashTable.Add(4, "test2");


            // Read the value from hashtable. 


            string value1 = Convert.ToString(objHashTable[1]);
            bool value2 = Convert.ToBoolean(objHashTable["abc"]);
            DateTime value3 = Convert.ToDateTime(objHashTable[3]);
            string value4 = Convert.ToString(objHashTable[4]);

            // Remove

            objHashTable.Remove("abc");

            int count = objHashTable.Count;
            objHashTable.Clear();
        }

        public void StackOperation()
        {
            // LIFO | Last IN First Out

            Stack objStack = new Stack();

            // To add the value

            objStack.Push(1);
            objStack.Push("test");
            objStack.Push(false);
            objStack.Push(DateTime.Now);

            // Peek | it won't delete it will just give last value. 

            DateTime val1 = Convert.ToDateTime( objStack.Peek());
            DateTime val2 = Convert.ToDateTime( objStack.Peek());
            DateTime val3 = Convert.ToDateTime( objStack.Peek());
            DateTime val4 = Convert.ToDateTime( objStack.Peek());
            DateTime val5 = Convert.ToDateTime( objStack.Peek());

            // Read | Pop | Pop will read and delete the value

            DateTime value1 = Convert.ToDateTime( objStack.Pop());
            bool value2 = Convert.ToBoolean( objStack.Pop());
            string value3 = Convert.ToString( objStack.Pop());
            int value4 = Convert.ToInt32( objStack.Pop());

            // Clear

            objStack.Clear();


        }

        public void QueueOperation()
        {
            // FIFO | First In First Out

            Queue objQueue = new Queue();

            objQueue.Enqueue(1);
            objQueue.Enqueue("Test");
            objQueue.Enqueue(false);
            objQueue.Enqueue(DateTime.Now);

            // Peek 

            int val1 = Convert.ToInt32(objQueue.Peek());
            int val2 = Convert.ToInt32(objQueue.Peek());
            int val3 = Convert.ToInt32(objQueue.Peek());
            int val4 = Convert.ToInt32(objQueue.Peek());
            int val5 = Convert.ToInt32(objQueue.Peek());

            // Dequeue

            int value1 = Convert.ToInt32(objQueue.Dequeue());
            string value2 = Convert.ToString(objQueue.Dequeue());
            bool value3 = Convert.ToBoolean(objQueue.Dequeue());
            DateTime value4 = Convert.ToDateTime(objQueue.Dequeue());

            // Clear

            objQueue.Clear();
        }

    }
}
