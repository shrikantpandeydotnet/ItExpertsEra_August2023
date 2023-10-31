using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class PolymorphismExample
    {

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(int[] a)
        {
            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                result = result + a[i];
            }
            Console.WriteLine(result);
        }


        public void Add(int a, int b, int c) // 10, 20, 30
        {
            Console.WriteLine(a + b + c); // 60
        }

        public void Add(string a, string b) //raj //shyam
        {
            Console.WriteLine(a + b); //rajshyam
        }

        // Param keyword, 

        //public void Add(string abc, int param2,  params int[] a)
        //{
        //    int result = 0;

        //    foreach (int i in a)
        //    {
        //        result = result + i;
        //    }
        //    Console.WriteLine(result);
        //}
    }
}
