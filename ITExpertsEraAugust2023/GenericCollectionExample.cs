using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class GenericCollectionExample
    {

        public void ListOperation()
        {
            // Declaration
            List<int> genList = new List<int>();

            // Insert value to List.
            genList.Add(10);
            genList.Add(20);
            genList.Add(30);
            genList.Add(40);


            // Read value from list.

            int value1 = genList[2];

            // loop through list

            foreach (int value in genList)
            {
                Console.WriteLine(value);
            }

            // Remove

            genList.Remove(0);

            // INsert 

            genList.Insert(2, 100);


            int count = genList.Count;

            // Clear

            genList.Clear();

            // 
            genList.Contains(3000);


        }

        public void DictionaryOperation()
        {
            Dictionary<int, string> dicElement = new Dictionary<int, string>();

            // Add value

            dicElement.Add(1, "Avishek");
            dicElement.Add(2, "Rajesh");
            dicElement.Add(3, "Seema");
            dicElement.Add(4, "Shivani");
            dicElement.Add(5, "Shankar");

            // get value from dictionary

            string value = dicElement[4];

            // loop in the dictionary

            foreach (KeyValuePair<int, string> item in dicElement)
            {

                Console.WriteLine("Key is " + item.Key + " and value is " + item.Value);
            }

            // Remove 

            dicElement.Remove(4);

           int count =  dicElement.Count;

            // loop for all the keys in the dictionary

            foreach(int item in dicElement.Keys)
            {
                Console.WriteLine(item);
            }

            // loop for all the keys in the dictionary

            foreach (string value2 in dicElement.Values)
            {
                Console.WriteLine(value2);
            }


            // clear
            dicElement.Clear();


        }

        public void StackGenericOperation() // LIFO
        {
            Stack<int> objstack = new   Stack<int>();

            // push

            objstack.Push(1);
            objstack.Push(1);
            objstack.Push(1);
            objstack.Push(111);
            objstack.Push(10);

            // peek 

            objstack.Peek();
            objstack.Peek();

            // pop 

            objstack.Pop();
            objstack.Pop();
        }


        public void QueueGenericOperation() // FIFO
        {
            Queue<int> objQueue = new Queue<int>();

            // Enquee
            objQueue.Enqueue(1);
            objQueue.Enqueue(10);
            objQueue.Enqueue(100);
            objQueue.Enqueue(120);
            objQueue.Enqueue(1120);

            // Peek

            objQueue.Peek();
            objQueue.Peek();

            // DeQueue

            objQueue.Dequeue();
            objQueue.Dequeue();
        }
    }
}
